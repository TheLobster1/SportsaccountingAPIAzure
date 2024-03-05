import time
import threading
import tkinter as tk
from tkinter import filedialog

import requests
from watchdog.observers import Observer
from watchdog.events import FileSystemEventHandler
import mt940
import json
from pymongo import MongoClient
from connectionString import connection_string

API_IP = "http://127.0.0.1:122"


def send_to_mongo(file_path):
    try:
        client = MongoClient(connection_string)
        db = client['ProjTest']
        collection = db['MT940Parsed']
        file = parse_mt940_file(file_path)
        result = collection.insert_one(file)
        inserted_id = result.inserted_id
        print(f"Inserted document ID: {inserted_id}")
        client.close()
        return inserted_id
    except Exception as e:
        print(f"Error sending data to MongoDB: {e}")


def send_request_to_api(inserted_id):
    try:
        api_endpoint = API_IP + "/api/uploadFile"
        params = {"entry_id": inserted_id}
        # Make a GET or POST request to the API, passing the inserted ID
        response = requests.get(api_endpoint, params)

        if response.status_code == 200:
            print("API request successful")
            print(response.json())
        else:
            print(f"API request failed with status code {response.status_code}")
    except Exception as e:
        print(f"Error sending request to API: {e}")


class FileHandler(FileSystemEventHandler):
    def __init__(self, folder_path):
        super().__init__()
        self.folder_path = folder_path

    def on_created(self, event):
        if event.src_path.endswith('.sta') or event.src_path.endswith('.txt'):
            print(f"New file detected: {event.src_path}")
            inserted_id = send_to_mongo(event.src_path)
            send_request_to_api(inserted_id)


def watch_folder(folder_path):
    observer = Observer()
    event_handler = FileHandler(folder_path)
    observer.schedule(event_handler, folder_path, recursive=False)
    observer.start()
    print(f"Watching folder: {folder_path}")

    try:
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        observer.stop()
    observer.join()


def select_folder():
    selected_folder = filedialog.askdirectory()
    if selected_folder:
        print(f"Selected folder: {selected_folder}")
        threading.Thread(target=watch_folder, args=(selected_folder,), daemon=True).start()


class FolderSelect(tk.Tk):
    def __init__(self):
        super().__init__()

        self.title("File Browser")
        self.geometry("400x200")

        button = tk.Button(self, text="Select Folder", command=select_folder)
        button.pack(pady=50)


def parse_mt940_file(file_path):
    # PARSES THE MT940 FILE AND RETURNS A COLLECTION
    transaction = mt940.parse(file_path)
    # CONVERTS THE COLLECTION TO JSON STRING
    transaction = json.dumps(transaction, indent=4, sort_keys=True, cls=mt940.JSONEncoder)
    # CONVERTS THE JSON STRING TO A DICTIONARY
    transaction = json.loads(transaction)
    return transaction


if __name__ == "__main__":
    app = FolderSelect()
    app.mainloop()

# Sports Accounting
Repository for the assignment from company Quintor. The team is to do the finance application for Sports Clubs.
Its role is to manage bank transfers for the members and facilities.
This project would be made with help of the databases and APIs, thus making data processing easier.

|      Members       |
|:------------------:|
| Krystian Wiazowski |
| Evald Narkevicius  |
|  Miroslav Penchev  |
|   Kareem Glasgow   |
|    Rob Veldman     |

## Coding Conventions
This part will clarify the structure and naming norms that code needs to match

### Naming
Our code uses camelCase for the method and variable naming. Classes are the only exception using capital letters at the start.

    class Exampleclass{}
    public void exampleMethod(){}
    private boolean isValid;

### Commenting
Commenting the code is mandatory. This is to ensure readability and scalability. Should be done in a logical, short phrases.


### Indenting
Single indenting should look like this:

    if(statement){
        code;
    }

Nested indenting should look like this:

    for(object var1 in list){
        for(object var2 in list){
            code;
        }
    }

### Working on code
When the code is not readable or agreeable, doesn't follow the conventions or raises questions, then the code change can be requested and needs to be approved by the orginal author.


## Setup
### Prerequisites:
* Installed and configured XAMPP (Other database hosting services will work, but the application was created using xampp.)
* Installed Visual Studio
* Installed IntelliJ or similar IDE that supports Python with Python 3.10 or higher configured
### Steps:
1. Download the project files to your device
2. Launch XAMPP.
3. Run Apache and MySQL
4. Press the Admin button next to the start/stop button for SQL to enter phpmyadmin
5. In phpmyadmin import the database.sql file (from the downloaded GitHub repo)
7. Open the PythonAPI folder in IntelliJ, Install requirements.txt file. Use the command pip install -r requirements.txt.
8. Run DBCommunication.py file
9. Open the solution located in the base application folder in Visual Studio
10. Run the form

## User Guide

1. Navigate to the register tab and create an account
1. Once you have created a user, log into that user account
1. You can now view the Base application tab of the application
1. From here you can viewe modules info, add/edit descriptions, search for keywords, and add members of the sports club (add/edit descriptions and add members are only available to admin users)

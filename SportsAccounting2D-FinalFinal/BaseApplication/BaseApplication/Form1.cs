using ConsoleApp2;
using Microsoft.AspNetCore.Identity;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonConvert = Newtonsoft.Json.JsonConvert;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;
using System.Data.SqlTypes;

namespace BaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        string userRole = "";
        string commType = "json";
        List<Tuple<TextBox, ComboBox, ComboBox>> assignCategoryHelper = new();
        private List<User> users = new();
        JObject modulesInformation = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            navigation.TabPages.Remove(editTransaction);
            navigation.TabPages.Remove(editDescription);
            navigation.TabPages.Remove(modules);
            navigation.TabPages.Remove(searchKeyword);
            navigation.TabPages.Remove(addMember);
            navigation.TabPages.Remove(mainPage);
            navigation.TabPages.Remove(chartPage);
            UpdateBalance();
        }
        
        void AdjustUser()
        {
            if (userRole == "user")
            {
                Controls.Remove(addMemberBtnMain);
                Controls.Remove(goToEditDescBtn);
                Controls.Remove(addFileBtn);
                addMemberBtnMain.Dispose();
                goToEditDescBtn.Dispose();
                addFileBtn.Dispose();

            }
        }
        
        string UploadToAPI(string fileToUpload)
        {
            string url = "http://127.0.0.1:122/api/uploadFile";
            using var client = new WebClient();
            var response = client.UploadFile(url, fileToUpload);
            return GetJSONResponse(Encoding.Default.GetString(response));
            
        }
        void UpdateCategories(NameValueCollection categories)
        {
            var dictionary = categories.AllKeys.ToDictionary(key => key, key => categories[key]);
            
            
            string json = JsonConvert.SerializeObject(dictionary);
            string url = "http://127.0.0.1:122/api/updateCategory";
            using var client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            client.UploadString(url, "POST", json);
            assignCategoryHelper.Clear();
        }
        
        void ConnectToApp(NameValueCollection userInfo, string type)
        {
            var dictionary = userInfo.AllKeys.ToDictionary(key => key, key => userInfo[key]);
            string url = "http://127.0.0.1:122/api/user/" + type;
            using var client = new WebClient();
            string message = "";
            string responseString = "";
            if (commType == "json") 
            {
                message = JsonConvert.SerializeObject(dictionary);
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
            }
            else if (commType == "xml")
            {
                message = SerializeDict(dictionary);
                client.Headers[HttpRequestHeader.ContentType] = "application/xml";
            }
            
            responseString = client.UploadString(url, "POST", message);
            string contentType = client.ResponseHeaders["Content-Type"];
            if (contentType == "application/json")
            {
                responseString = GetJSONResponse(responseString);
            }
            else if (contentType == "application/xml")
            {
                responseString = GetXMLResponse(responseString);
            }
            
            MessageBox.Show(responseString);
            if (responseString.Contains("successful"))
            {
                userRole = userInfo["role"];
                navigation.TabPages.Add(mainPage);
                navigation.TabPages.Remove(registerPage);
                navigation.TabPages.Remove(loginPage);
                navigation.SelectTab(mainPage);
                AdjustUser();
                populateChart();
            }
            else
            {
                MessageBox.Show(responseString);
            }
        }

        private void Login(String username, String password)
        {
            NameValueCollection userInfo = new()
            {
                {"username", username},
                {"password", ComputeHash(password) },
            };
            ConnectToApp(userInfo, "login");
        }
        
        private bool ValidateRegister()
        {
            //username
            if(!string.IsNullOrEmpty(usernameBox.Text) && usernameBox.Text.Length <= 50)
            {
                //firstName
                if(!string.IsNullOrEmpty(firstNameBox.Text) && firstNameBox.Text.Length <= 20)
                {
                    //lastName
                    if(!string.IsNullOrEmpty(lastNameBox.Text) && lastNameBox.Text.Length <= 20)
                    {
                        //email
                        if(!string.IsNullOrEmpty(emailBox.Text) && emailBox.Text.Length <= 320 && emailBox.Text.Contains("@"))
                        {
                            if(!string.IsNullOrEmpty(passwordBox.Text) && passwordBox.Text.Length <= 255 && passwordBox.Text.Length >= 7)
                            {
                                return true;
                            }
                            else 
                            {
                                MessageBox.Show("Password cannot be empty and must be at least 7 characters!"); 
                                return false; 
                            }
                        }
                        else {
                            MessageBox.Show("Email must not be empty and must contain a @!"); 
                            return false; 
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Last name must not be empty!"); 
                        return false; 
                    }
                }
                else 
                {
                    MessageBox.Show("First name must not be empty!"); 
                    return false; 
                }
            }
            else 
            {
                MessageBox.Show("Username must not be empty!");
                return false; 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateRegister())
            {
                var dateOfJoin = DateTime.Now.ToShortDateString();
                NameValueCollection userInfo = new()
      
                {
                    { "username", usernameBox.Text },
                    { "firstName", firstNameBox.Text },
                    { "lastName", lastNameBox.Text },
                    { "email", emailBox.Text },
                    { "password", ComputeHash(passwordBox.Text) },
                    { "dateOfJoin", dateOfJoin },
                    { "role", userTypeBox.SelectedItem.ToString()}
                };
                ConnectToApp(userInfo, "register");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login(loginUsernameBox.Text, loginPasswordBox.Text);
        }

        private async Task<string[]> GetTransactions(string request)
        {
            string url = $"http://127.0.0.1:122/api/getTransactions/{request}";
            using var client = new HttpClient();

            string transactions = await client.GetStringAsync(url);
            populateChart();
            return SplitResponse(transactions);
        }
        
        private async Task GetTransactionAsync()
        {
            int bRefX = 30;
            int categoryX = 180;
            int membersX = 330;
            int pointY = 40;

            string[] transactionList = await GetTransactions("other");

            foreach (string bankReference in transactionList)
            {
                TextBox bRef = new()
                {
                    Text = TrimString(bankReference),
                    Location = new Point(bRefX, pointY),
                    ReadOnly = true
                };
                //editTransaction.Controls.Add(bRef);
                panel1.Controls.Add(bRef);

                ComboBox category = new()
                {
                    Location = new Point(categoryX, pointY),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                category.Items.Add("bar");
                category.Items.Add("membership fee");
                category.Items.Add("rental");
                category.SelectedIndex = 0;
                //editTransaction.Controls.Add(category);
                panel1.Controls.Add(category);

                ComboBox members = new()
                {
                    Location = new Point(membersX, pointY),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                members.Items.Add("not applicable");
                foreach (string member in await GetMembers())
                {
                    members.Items.Add(TrimString(member));
                }
                members.SelectedIndex = 0;
                //editTransaction.Controls.Add(members);
                panel1.Controls.Add(members);
                pointY += 25;

                assignCategoryHelper.Add(new Tuple<TextBox, ComboBox, ComboBox>(bRef, category, members));
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            List<Tuple<TextBox, ComboBox, ComboBox>> tuples = assignCategoryHelper.ToList();
            foreach (Tuple<TextBox, ComboBox, ComboBox> tuple in tuples)
            {
                NameValueCollection updatedCategories = new();
                string bankReference = tuple.Item1.Text;
                string category = tuple.Item2.Text;
                string member = tuple.Item3.Text;
                updatedCategories.Add("bankReference", bankReference);
                updatedCategories.Add("category", category);
                updatedCategories.Add("member", member);
                UpdateCategories(updatedCategories);
            }
            EditTabs(false);
            panel1.Controls.Clear();
            navigation.SelectTab(mainPage);
            navigation.TabPages.Remove(editTransaction);
        }

        private async Task<string[]> GetMembers()
        {
            string url = "http://127.0.0.1:122/api/getMembers";
            using var client = new HttpClient();

            string response = await client.GetStringAsync(url);

            return SplitResponse(response);
        }

        private async void addFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new()
            {
                Title = "Select MT940 Files",
                Multiselect = true
            };

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string response = "";
                foreach (String fileName in openFileDialog1.FileNames)
                {
                    response += UploadToAPI(fileName) + " ";
                }
                if (!response.Contains("Unsupported file format") && !response.Contains("Duplicate file"))
                {
                    MessageBox.Show("File(s) uploaded. Please give each transaction a category");
                    navigation.TabPages.Add(editTransaction);
                    navigation.SelectTab(editTransaction);
                    EditTabs(true);
                    await GetTransactionAsync();
                    UpdateBalance();
                }
                else if(response.Contains("Duplicate file"))
                {
                    MessageBox.Show("Duplicate file");
                }
                else
                {
                    MessageBox.Show("Unsupported file format");
                }
                
            }
        }

        private void EditTabs(bool hide)
        {
            if (hide)
            {
                navigation.TabPages.Remove(mainPage);
            }
            else
            {
                navigation.TabPages.Add(mainPage);
            }
        }

        private async void updateBatBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/ModuleInfo/bar_information";
            using var client = new HttpClient();

            string content = await client.GetStringAsync(url);
            dynamic jsonObj = JsonConvert.DeserializeObject(content);
            barCostTxt.Text = jsonObj.bar_information.expense;
            barIncomeTxt.Text = jsonObj.bar_information.income;
            barTurnoverTxt.Text = jsonObj.bar_information.turnover;
        }

        private async void updateRental_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/ModuleInfo/rental_information";
            using var client = new HttpClient();

            string content = await client.GetStringAsync(url);
            dynamic jsonObj = JsonConvert.DeserializeObject(content);
            rentalCostTxt.Text = jsonObj.rental_information.expense;
            rentalIncomeTxt.Text = jsonObj.rental_information.income;
            rentalTurnoverTxt.Text = jsonObj.rental_information.turnover;
        }

        private async void generateSummaryBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/ModulesSummary";
            using var client = new HttpClient();

            await client.GetStringAsync(url);
            MessageBox.Show("Summary generated");
        }

        private void modulesInfoBtn_Click(object sender, EventArgs e)
        {
            if (!navigation.TabPages.Contains(modules))
            {
                navigation.TabPages.Add(modules);
                navigation.SelectTab(modules);
            }
            navigation.SelectTab(modules);
        }

        private async void goToEditDescBtn_Click(object sender, EventArgs e)
        {
            if (!navigation.TabPages.Contains(editDescription))
            {
                navigation.TabPages.Add(editDescription);
                string[] transactionList = await GetTransactions("all");

                foreach (string bankReference in transactionList)
                {

                    bRefCBox.Items.Add(TrimString(bankReference));
                }
            }
            navigation.SelectTab(editDescription);
            bRefCBox.SelectedIndex = 0;
            bRefCBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void bRefCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string bRef = bRefCBox.SelectedItem.ToString();
            

            string url = "http://127.0.0.1:122/api/getTransactionDescription/"+ bRef;
            using var client = new HttpClient();

            string description = await client.GetStringAsync(url);
            richTextBox2.Text = TrimString(description);
        }

        private async void updateDescBtn_Click(object sender, EventArgs e)
        {
            string description = richTextBox2.Text;
            string bRef = bRefCBox.SelectedItem.ToString();

            string url = $"http://127.0.0.1:122/api/updateTransactionDescription?customDetails={description}&bankReference={bRef}";
            using var client = new HttpClient();

            string response = await client.GetStringAsync(url);
            MessageBox.Show(GetJSONResponse(response));

            navigation.TabPages.Remove(editDescription);
            navigation.SelectTab(mainPage);
        }

        private async void searchKeywordBtn_Click(object sender, EventArgs e)
        {
            searchTable.Rows.Clear();
            string table = searchTableCBox.SelectedItem.ToString();
            string column = searchColumnCBox.SelectedItem.ToString();
            string keyword = keywordSeach.Text;

            string url = $"http://127.0.0.1:122/api/searchKeyword?table={table}&column={column}&keyword={keyword}";
            using var client = new HttpClient();
            string response = await client.GetStringAsync(url);
            string[][] parsedResponse = ParseStringToArray(response);
            for (int i = 0; i < parsedResponse.Length; i++)
            {
                searchTable.Rows.Add(parsedResponse[i]);
            }
        }

        private async void searchTableCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string table = searchTableCBox.SelectedItem.ToString();
            
            string url = $"http://127.0.0.1:122/api/Columns/{table}";
            using var client = new HttpClient();
            string response = await client.GetStringAsync(url);
            string[] columns = SplitResponse(response);
            searchColumnCBox.Items.Clear();
            searchTable.Columns.Clear();
            searchTable.Rows.Clear();
            foreach (string column in columns)
            {   
                searchColumnCBox.Items.Add(TrimString(column));

                string columnName = TrimString(column);

                DataGridViewTextBoxColumn insertedColumn = new DataGridViewTextBoxColumn();
                insertedColumn.HeaderText = columnName;
                insertedColumn.DataPropertyName = columnName;

                searchTable.Columns.Add(insertedColumn);

            }
            searchColumnCBox.SelectedIndex = 0;
        }

        static string[][] ParseStringToArray(string input)
        {
            JArray jsonArray = JsonConvert.DeserializeObject<JArray>(input);
            string[][] array = new string[jsonArray.Count][];

            for (int i = 0; i < jsonArray.Count; i++)
            {
                JArray innerArray = jsonArray[i].ToObject<JArray>();
                array[i] = new string[innerArray.Count];

                for (int j = 0; j < innerArray.Count; j++)
                {
                    array[i][j] = innerArray[j].ToString();
                }
            }

            return array;
        }

        private string TrimString(string str)
        {
            string pattern = "[\"\\[\\]]|\n";
            string replacement = "";
            string strTrim = Regex.Replace(str, pattern, replacement);
            return strTrim;
        }
        private string[] SplitResponse(string response)
        {
            return response.Split(',');
        }

        private async void searchKWordBtn_Click(object sender, EventArgs e)
        {
            if (!navigation.TabPages.Contains(searchKeyword))
            {
                string url = $"http://127.0.0.1:122/api/Tables";
                using var client = new HttpClient();
                string response = await client.GetStringAsync(url);
                string[] tables = SplitResponse(response);

                foreach (string table in tables)
                {
                    searchTableCBox.Items.Add(TrimString(table));
                }
            }
            navigation.TabPages.Add(searchKeyword);
            navigation.SelectTab(searchKeyword);
            searchTableCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchColumnCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchTableCBox.SelectedIndex = 0;
        }
        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            using var client = new WebClient();
            string url = "http://127.0.0.1:122/api/addMember";
            var emailValid = new EmailAddressAttribute();
            if (emailValid.IsValid(memberEmailBox.Text))
            {
                string email = memberEmailBox.Text;
                string name = memberNameBox.Text;
                var memberInfo = new Dictionary<string, string>
                {
                    {"name", name},
                    {"email", email}
                };
                
                string response = "";
                string message = "";
                if (commType == "json")
                {
                    message = JsonConvert.SerializeObject(memberInfo);
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                }
                else if(commType == "xml")
                {
                    message = SerializeDict(memberInfo);
                    client.Headers[HttpRequestHeader.ContentType] = "application/xml";
                }
                
                response = client.UploadString(url, "POST", message);
                string contentType = client.ResponseHeaders["Content-Type"];
                if (contentType == "application/json")
                {
                    MessageBox.Show(GetJSONResponse(response));
                }
                else if(contentType == "application/xml")
                {
                    MessageBox.Show(GetXMLResponse(response));
                }
            }
            else
            {
                MessageBox.Show("Invalid email address");
            }
        }

        private void addMemberBtnMain_Click(object sender, EventArgs e)
        {
            if (!navigation.TabPages.Contains(addMember))
            {
                navigation.TabPages.Add(addMember);
                navigation.SelectTab(addMember);
            }
            navigation.SelectTab(addMember);
        }
        private async Task<string> GetBalance()
        {
            string url = "http://127.0.0.1:122/api/getBalance";
            using var client = new HttpClient();

            return await client.GetStringAsync(url);

        }

        private async void UpdateBalance()
        {
            string balance = TrimString(await GetBalance());
            if (balance.Contains("No balance"))
            {
                availableBalanceLbl.Visible = false;
                generateSummaryBtn.Visible = false;
                generateSummaryBtn.Enabled = false;
            }
            else
            {
                availableBalanceLbl.Visible = true;
                availableBalanceLbl.Text = "Account Balance: " + balance + "EUR";
                generateSummaryBtn.Visible = true;
                generateSummaryBtn.Enabled = true;
            }
        }
        static string ComputeHash(string data)
        {
            byte[] hashBytes;
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes("iLoveBozosort")))
            {
                hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }

        private async void summaryBtn_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:122/api/Summary";
            using var client = new HttpClient();

            await client.GetStringAsync(url);
            MessageBox.Show("Summary generated");
        }


        
        private async void populateChart()
        {
            chart1.Series[0].Points.Clear();
            string url = "http://127.0.0.1:122/api/getTransactionsForChart";
            using var client = new HttpClient();

            var json = await client.GetStringAsync(url);
            if (json.Contains("No transactions"))
            {
                return;
            }
                if(!navigation.TabPages.Contains(chartPage))
                {
                    navigation.TabPages.Add(chartPage);
                    chart1.Series[0].Name = "Money, EUR";
                }
                object[][] dataArray;
                dataArray = JsonConvert.DeserializeObject<object[][]>(json);

                for (int i = 0; i < dataArray.Length; i++)
                {
                    if (dataArray[i].Length > 1 && dataArray[i][1] is string dateString)
                    {
                        if (DateTime.TryParseExact(dateString, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                        {
                            dataArray[i][1] = date.ToString("yyyy-MM-dd");
                        }
                        dataArray = dataArray.OrderBy(item => DateTime.Parse((string)item[1])).ToArray();
                    }
                }
                foreach (var item in dataArray)
                {
                    var xValue = item[1].ToString(); // Assuming date is the x-value
                    var yValue = Convert.ToDouble(item[0]); // Assuming value is the y-value

                    chart1.Series[0].Points.AddXY(xValue, yValue);
                }
                //chart1.Series[0].Name = "Money, EUR";
        }

        public static string GetJSONResponse(string jsonResponse)
        {
            JObject responseJson = JObject.Parse(jsonResponse);
            JToken responseToken = responseJson["response"];

            if (responseToken != null && responseToken.Type == JTokenType.String)
            {
                string hiPart = responseToken.Value<string>();
                return hiPart;
            }

            return jsonResponse;
        }

        public static string GetXMLResponse(string xmlResponse)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlResponse);

            // Find the 'response' element
            XmlNode responseNode = xmlDoc.SelectSingleNode("/root/response");

            // Get the text content of the 'response' element
            return responseNode.InnerText;
        }

        public static string SerializeDict(Dictionary<string, string> dict)
        {
            // serialize the dictionary
            DataContractSerializer serializer = new DataContractSerializer(dict.GetType());

            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    // add formatting so the XML is easy to read in the log
                    writer.Formatting = Formatting.Indented;

                    serializer.WriteObject(writer, dict);

                    writer.Flush();

                    return sw.ToString();
                }
            }
        }

        private void xmlResponseSlct_CheckedChanged(object sender, EventArgs e)
        {
            commType = "xml";
        }

        private void jsonResponseSlct_CheckedChanged(object sender, EventArgs e)
        {
            commType = "json";
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            navigation.TabPages.Remove(editTransaction);
            navigation.TabPages.Remove(editDescription);
            navigation.TabPages.Remove(modules);
            navigation.TabPages.Remove(searchKeyword);
            navigation.TabPages.Remove(addMember);
            navigation.TabPages.Remove(mainPage);
            navigation.TabPages.Remove(chartPage);
            navigation.TabPages.Add(loginPage);
            navigation.TabPages.Add(registerPage);
            navigation.SelectTab(loginPage);
        }
    }
}

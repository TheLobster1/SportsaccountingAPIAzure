using System.Windows.Forms;

namespace BaseApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.navigation = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.responseTypeBox = new System.Windows.Forms.GroupBox();
            this.xmlResponseSlct = new System.Windows.Forms.RadioButton();
            this.jsonResponseSlct = new System.Windows.Forms.RadioButton();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.availableBalanceLbl = new System.Windows.Forms.Label();
            this.addMemberBtnMain = new System.Windows.Forms.Button();
            this.searchKWordBtn = new System.Windows.Forms.Button();
            this.modulesInfoBtn = new System.Windows.Forms.Button();
            this.goToEditDescBtn = new System.Windows.Forms.Button();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.loginUsernameBox = new System.Windows.Forms.TextBox();
            this.registerPage = new System.Windows.Forms.TabPage();
            this.userTypeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.editTransaction = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberTrans = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.bankRefLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.modules = new System.Windows.Forms.TabPage();
            this.generateSummaryBtn = new System.Windows.Forms.Button();
            this.turnoverLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.costsLbl = new System.Windows.Forms.Label();
            this.updateRental = new System.Windows.Forms.Button();
            this.updateBatBtn = new System.Windows.Forms.Button();
            this.rentalinfoLbl = new System.Windows.Forms.Label();
            this.rentalTurnoverTxt = new System.Windows.Forms.TextBox();
            this.rentalIncomeTxt = new System.Windows.Forms.TextBox();
            this.rentalCostTxt = new System.Windows.Forms.TextBox();
            this.barTurnoverTxt = new System.Windows.Forms.TextBox();
            this.barIncomeTxt = new System.Windows.Forms.TextBox();
            this.barCostTxt = new System.Windows.Forms.TextBox();
            this.barinfoLbl = new System.Windows.Forms.Label();
            this.editDescription = new System.Windows.Forms.TabPage();
            this.updateDescBtn = new System.Windows.Forms.Button();
            this.descLbl = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bankRefEditLbl = new System.Windows.Forms.Label();
            this.bRefCBox = new System.Windows.Forms.ComboBox();
            this.searchKeyword = new System.Windows.Forms.TabPage();
            this.searchTable = new System.Windows.Forms.DataGridView();
            this.searchKeywordBtn = new System.Windows.Forms.Button();
            this.searchKeywordLbl = new System.Windows.Forms.Label();
            this.searchColumnLbl = new System.Windows.Forms.Label();
            this.seachTableLbl = new System.Windows.Forms.Label();
            this.keywordSeach = new System.Windows.Forms.TextBox();
            this.searchColumnCBox = new System.Windows.Forms.ComboBox();
            this.searchTableCBox = new System.Windows.Forms.ComboBox();
            this.addMember = new System.Windows.Forms.TabPage();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.memberEmail = new System.Windows.Forms.Label();
            this.memberEmailBox = new System.Windows.Forms.TextBox();
            this.memberNameBox = new System.Windows.Forms.TextBox();
            this.memberNameLbl = new System.Windows.Forms.Label();
            this.chartPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.navigation.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.responseTypeBox.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.registerPage.SuspendLayout();
            this.editTransaction.SuspendLayout();
            this.modules.SuspendLayout();
            this.editDescription.SuspendLayout();
            this.searchKeyword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).BeginInit();
            this.addMember.SuspendLayout();
            this.chartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.Controls.Add(this.mainPage);
            this.navigation.Controls.Add(this.loginPage);
            this.navigation.Controls.Add(this.registerPage);
            this.navigation.Controls.Add(this.editTransaction);
            this.navigation.Controls.Add(this.modules);
            this.navigation.Controls.Add(this.editDescription);
            this.navigation.Controls.Add(this.searchKeyword);
            this.navigation.Controls.Add(this.addMember);
            this.navigation.Controls.Add(this.chartPage);
            this.navigation.Location = new System.Drawing.Point(1, 0);
            this.navigation.Name = "navigation";
            this.navigation.SelectedIndex = 0;
            this.navigation.Size = new System.Drawing.Size(801, 447);
            this.navigation.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.LogoutBtn);
            this.mainPage.Controls.Add(this.responseTypeBox);
            this.mainPage.Controls.Add(this.summaryBtn);
            this.mainPage.Controls.Add(this.availableBalanceLbl);
            this.mainPage.Controls.Add(this.addMemberBtnMain);
            this.mainPage.Controls.Add(this.searchKWordBtn);
            this.mainPage.Controls.Add(this.modulesInfoBtn);
            this.mainPage.Controls.Add(this.goToEditDescBtn);
            this.mainPage.Controls.Add(this.addFileBtn);
            this.mainPage.Location = new System.Drawing.Point(4, 25);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(793, 418);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // responseTypeBox
            // 
            this.responseTypeBox.Controls.Add(this.xmlResponseSlct);
            this.responseTypeBox.Controls.Add(this.jsonResponseSlct);
            this.responseTypeBox.Location = new System.Drawing.Point(547, 28);
            this.responseTypeBox.Name = "responseTypeBox";
            this.responseTypeBox.Size = new System.Drawing.Size(200, 100);
            this.responseTypeBox.TabIndex = 21;
            this.responseTypeBox.TabStop = false;
            this.responseTypeBox.Text = "Select Communication Type";
            // 
            // xmlResponseSlct
            // 
            this.xmlResponseSlct.AutoSize = true;
            this.xmlResponseSlct.Location = new System.Drawing.Point(6, 63);
            this.xmlResponseSlct.Name = "xmlResponseSlct";
            this.xmlResponseSlct.Size = new System.Drawing.Size(54, 20);
            this.xmlResponseSlct.TabIndex = 1;
            this.xmlResponseSlct.Text = "XML";
            this.xmlResponseSlct.UseVisualStyleBackColor = true;
            this.xmlResponseSlct.CheckedChanged += new System.EventHandler(this.xmlResponseSlct_CheckedChanged);
            // 
            // jsonResponseSlct
            // 
            this.jsonResponseSlct.AutoSize = true;
            this.jsonResponseSlct.Checked = true;
            this.jsonResponseSlct.Location = new System.Drawing.Point(6, 30);
            this.jsonResponseSlct.Name = "jsonResponseSlct";
            this.jsonResponseSlct.Size = new System.Drawing.Size(64, 20);
            this.jsonResponseSlct.TabIndex = 0;
            this.jsonResponseSlct.TabStop = true;
            this.jsonResponseSlct.Text = "JSON";
            this.jsonResponseSlct.UseVisualStyleBackColor = true;
            this.jsonResponseSlct.CheckedChanged += new System.EventHandler(this.jsonResponseSlct_CheckedChanged);
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(217, 340);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(156, 46);
            this.summaryBtn.TabIndex = 20;
            this.summaryBtn.Text = "Generate Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // availableBalanceLbl
            // 
            this.availableBalanceLbl.AutoSize = true;
            this.availableBalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableBalanceLbl.Location = new System.Drawing.Point(53, 14);
            this.availableBalanceLbl.Name = "availableBalanceLbl";
            this.availableBalanceLbl.Size = new System.Drawing.Size(89, 25);
            this.availableBalanceLbl.TabIndex = 19;
            this.availableBalanceLbl.Text = "Balance:";
            // 
            // addMemberBtnMain
            // 
            this.addMemberBtnMain.Location = new System.Drawing.Point(217, 118);
            this.addMemberBtnMain.Name = "addMemberBtnMain";
            this.addMemberBtnMain.Size = new System.Drawing.Size(156, 32);
            this.addMemberBtnMain.TabIndex = 18;
            this.addMemberBtnMain.Text = "Add member";
            this.addMemberBtnMain.UseVisualStyleBackColor = true;
            this.addMemberBtnMain.Click += new System.EventHandler(this.addMemberBtnMain_Click);
            // 
            // searchKWordBtn
            // 
            this.searchKWordBtn.Location = new System.Drawing.Point(217, 58);
            this.searchKWordBtn.Name = "searchKWordBtn";
            this.searchKWordBtn.Size = new System.Drawing.Size(156, 32);
            this.searchKWordBtn.TabIndex = 17;
            this.searchKWordBtn.Text = "Search keyword";
            this.searchKWordBtn.UseVisualStyleBackColor = true;
            this.searchKWordBtn.Click += new System.EventHandler(this.searchKWordBtn_Click);
            // 
            // modulesInfoBtn
            // 
            this.modulesInfoBtn.Location = new System.Drawing.Point(25, 58);
            this.modulesInfoBtn.Name = "modulesInfoBtn";
            this.modulesInfoBtn.Size = new System.Drawing.Size(156, 32);
            this.modulesInfoBtn.TabIndex = 16;
            this.modulesInfoBtn.Text = "Modules Info";
            this.modulesInfoBtn.UseVisualStyleBackColor = true;
            this.modulesInfoBtn.Click += new System.EventHandler(this.modulesInfoBtn_Click);
            // 
            // goToEditDescBtn
            // 
            this.goToEditDescBtn.Location = new System.Drawing.Point(25, 118);
            this.goToEditDescBtn.Name = "goToEditDescBtn";
            this.goToEditDescBtn.Size = new System.Drawing.Size(156, 32);
            this.goToEditDescBtn.TabIndex = 15;
            this.goToEditDescBtn.Text = "Edit/Add Description";
            this.goToEditDescBtn.UseVisualStyleBackColor = true;
            this.goToEditDescBtn.Click += new System.EventHandler(this.goToEditDescBtn_Click);
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(25, 340);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(156, 46);
            this.addFileBtn.TabIndex = 14;
            this.addFileBtn.Text = "Add file";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.label8);
            this.loginPage.Controls.Add(this.label7);
            this.loginPage.Controls.Add(this.button3);
            this.loginPage.Controls.Add(this.loginPasswordBox);
            this.loginPage.Controls.Add(this.loginUsernameBox);
            this.loginPage.Location = new System.Drawing.Point(4, 25);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(793, 418);
            this.loginPage.TabIndex = 2;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Username";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "LOGIN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Location = new System.Drawing.Point(418, 148);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.PasswordChar = '*';
            this.loginPasswordBox.Size = new System.Drawing.Size(130, 22);
            this.loginPasswordBox.TabIndex = 1;
            // 
            // loginUsernameBox
            // 
            this.loginUsernameBox.Location = new System.Drawing.Point(219, 148);
            this.loginUsernameBox.Name = "loginUsernameBox";
            this.loginUsernameBox.Size = new System.Drawing.Size(130, 22);
            this.loginUsernameBox.TabIndex = 0;
            // 
            // registerPage
            // 
            this.registerPage.Controls.Add(this.userTypeBox);
            this.registerPage.Controls.Add(this.label6);
            this.registerPage.Controls.Add(this.label5);
            this.registerPage.Controls.Add(this.label4);
            this.registerPage.Controls.Add(this.label3);
            this.registerPage.Controls.Add(this.label2);
            this.registerPage.Controls.Add(this.label1);
            this.registerPage.Controls.Add(this.button2);
            this.registerPage.Controls.Add(this.passwordBox);
            this.registerPage.Controls.Add(this.emailBox);
            this.registerPage.Controls.Add(this.lastNameBox);
            this.registerPage.Controls.Add(this.firstNameBox);
            this.registerPage.Controls.Add(this.usernameBox);
            this.registerPage.Location = new System.Drawing.Point(4, 25);
            this.registerPage.Name = "registerPage";
            this.registerPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerPage.Size = new System.Drawing.Size(793, 418);
            this.registerPage.TabIndex = 1;
            this.registerPage.Text = "Register";
            this.registerPage.UseVisualStyleBackColor = true;
            // 
            // userTypeBox
            // 
            this.userTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeBox.FormattingEnabled = true;
            this.userTypeBox.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.userTypeBox.Location = new System.Drawing.Point(325, 249);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(121, 24);
            this.userTypeBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "User type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(325, 202);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(124, 22);
            this.passwordBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(325, 162);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(124, 22);
            this.emailBox.TabIndex = 3;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(325, 120);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(124, 22);
            this.lastNameBox.TabIndex = 2;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(325, 79);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(124, 22);
            this.firstNameBox.TabIndex = 1;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(325, 39);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(124, 22);
            this.usernameBox.TabIndex = 0;
            // 
            // editTransaction
            // 
            this.editTransaction.Controls.Add(this.panel1);
            this.editTransaction.Controls.Add(this.memberTrans);
            this.editTransaction.Controls.Add(this.categoryLbl);
            this.editTransaction.Controls.Add(this.bankRefLbl);
            this.editTransaction.Controls.Add(this.submitBtn);
            this.editTransaction.Location = new System.Drawing.Point(4, 25);
            this.editTransaction.Name = "editTransaction";
            this.editTransaction.Size = new System.Drawing.Size(793, 418);
            this.editTransaction.TabIndex = 3;
            this.editTransaction.Text = "Edit Transaction";
            this.editTransaction.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 289);
            this.panel1.TabIndex = 6;
            // 
            // memberTrans
            // 
            this.memberTrans.AutoSize = true;
            this.memberTrans.Location = new System.Drawing.Point(473, 23);
            this.memberTrans.Name = "memberTrans";
            this.memberTrans.Size = new System.Drawing.Size(57, 16);
            this.memberTrans.TabIndex = 5;
            this.memberTrans.Text = "Member";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(276, 23);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(62, 16);
            this.categoryLbl.TabIndex = 4;
            this.categoryLbl.Text = "Category";
            // 
            // bankRefLbl
            // 
            this.bankRefLbl.AutoSize = true;
            this.bankRefLbl.Location = new System.Drawing.Point(42, 23);
            this.bankRefLbl.Name = "bankRefLbl";
            this.bankRefLbl.Size = new System.Drawing.Size(104, 16);
            this.bankRefLbl.TabIndex = 3;
            this.bankRefLbl.Text = "Bank Reference";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(269, 349);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(87, 34);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // modules
            // 
            this.modules.Controls.Add(this.generateSummaryBtn);
            this.modules.Controls.Add(this.turnoverLbl);
            this.modules.Controls.Add(this.incomeLbl);
            this.modules.Controls.Add(this.costsLbl);
            this.modules.Controls.Add(this.updateRental);
            this.modules.Controls.Add(this.updateBatBtn);
            this.modules.Controls.Add(this.rentalinfoLbl);
            this.modules.Controls.Add(this.rentalTurnoverTxt);
            this.modules.Controls.Add(this.rentalIncomeTxt);
            this.modules.Controls.Add(this.rentalCostTxt);
            this.modules.Controls.Add(this.barTurnoverTxt);
            this.modules.Controls.Add(this.barIncomeTxt);
            this.modules.Controls.Add(this.barCostTxt);
            this.modules.Controls.Add(this.barinfoLbl);
            this.modules.Location = new System.Drawing.Point(4, 25);
            this.modules.Name = "modules";
            this.modules.Padding = new System.Windows.Forms.Padding(3);
            this.modules.Size = new System.Drawing.Size(793, 418);
            this.modules.TabIndex = 4;
            this.modules.Text = "Modules";
            this.modules.UseVisualStyleBackColor = true;
            // 
            // generateSummaryBtn
            // 
            this.generateSummaryBtn.Location = new System.Drawing.Point(312, 293);
            this.generateSummaryBtn.Name = "generateSummaryBtn";
            this.generateSummaryBtn.Size = new System.Drawing.Size(121, 52);
            this.generateSummaryBtn.TabIndex = 14;
            this.generateSummaryBtn.Text = "Generate Summary";
            this.generateSummaryBtn.UseVisualStyleBackColor = true;
            this.generateSummaryBtn.Click += new System.EventHandler(this.generateSummaryBtn_Click);
            // 
            // turnoverLbl
            // 
            this.turnoverLbl.AutoSize = true;
            this.turnoverLbl.Location = new System.Drawing.Point(465, 75);
            this.turnoverLbl.Name = "turnoverLbl";
            this.turnoverLbl.Size = new System.Drawing.Size(64, 16);
            this.turnoverLbl.TabIndex = 12;
            this.turnoverLbl.Text = "Turnover:";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(347, 75);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(54, 16);
            this.incomeLbl.TabIndex = 11;
            this.incomeLbl.Text = "Income:";
            // 
            // costsLbl
            // 
            this.costsLbl.AutoSize = true;
            this.costsLbl.Location = new System.Drawing.Point(229, 75);
            this.costsLbl.Name = "costsLbl";
            this.costsLbl.Size = new System.Drawing.Size(44, 16);
            this.costsLbl.TabIndex = 10;
            this.costsLbl.Text = "Costs:";
            // 
            // updateRental
            // 
            this.updateRental.Location = new System.Drawing.Point(588, 166);
            this.updateRental.Name = "updateRental";
            this.updateRental.Size = new System.Drawing.Size(116, 27);
            this.updateRental.TabIndex = 9;
            this.updateRental.Text = "Update Rental";
            this.updateRental.UseVisualStyleBackColor = true;
            this.updateRental.Click += new System.EventHandler(this.updateRental_Click);
            // 
            // updateBatBtn
            // 
            this.updateBatBtn.Location = new System.Drawing.Point(588, 110);
            this.updateBatBtn.Name = "updateBatBtn";
            this.updateBatBtn.Size = new System.Drawing.Size(116, 27);
            this.updateBatBtn.TabIndex = 8;
            this.updateBatBtn.Text = "Update Bar";
            this.updateBatBtn.UseVisualStyleBackColor = true;
            this.updateBatBtn.Click += new System.EventHandler(this.updateBatBtn_Click);
            // 
            // rentalinfoLbl
            // 
            this.rentalinfoLbl.AutoSize = true;
            this.rentalinfoLbl.Location = new System.Drawing.Point(66, 177);
            this.rentalinfoLbl.Name = "rentalinfoLbl";
            this.rentalinfoLbl.Size = new System.Drawing.Size(117, 16);
            this.rentalinfoLbl.TabIndex = 7;
            this.rentalinfoLbl.Text = "Rental Information:";
            // 
            // rentalTurnoverTxt
            // 
            this.rentalTurnoverTxt.Location = new System.Drawing.Point(445, 170);
            this.rentalTurnoverTxt.Name = "rentalTurnoverTxt";
            this.rentalTurnoverTxt.ReadOnly = true;
            this.rentalTurnoverTxt.Size = new System.Drawing.Size(100, 22);
            this.rentalTurnoverTxt.TabIndex = 6;
            // 
            // rentalIncomeTxt
            // 
            this.rentalIncomeTxt.Location = new System.Drawing.Point(322, 170);
            this.rentalIncomeTxt.Name = "rentalIncomeTxt";
            this.rentalIncomeTxt.ReadOnly = true;
            this.rentalIncomeTxt.Size = new System.Drawing.Size(100, 22);
            this.rentalIncomeTxt.TabIndex = 5;
            // 
            // rentalCostTxt
            // 
            this.rentalCostTxt.Location = new System.Drawing.Point(201, 171);
            this.rentalCostTxt.Name = "rentalCostTxt";
            this.rentalCostTxt.ReadOnly = true;
            this.rentalCostTxt.Size = new System.Drawing.Size(100, 22);
            this.rentalCostTxt.TabIndex = 4;
            // 
            // barTurnoverTxt
            // 
            this.barTurnoverTxt.Location = new System.Drawing.Point(445, 112);
            this.barTurnoverTxt.Name = "barTurnoverTxt";
            this.barTurnoverTxt.ReadOnly = true;
            this.barTurnoverTxt.Size = new System.Drawing.Size(100, 22);
            this.barTurnoverTxt.TabIndex = 3;
            // 
            // barIncomeTxt
            // 
            this.barIncomeTxt.Location = new System.Drawing.Point(322, 112);
            this.barIncomeTxt.Name = "barIncomeTxt";
            this.barIncomeTxt.ReadOnly = true;
            this.barIncomeTxt.Size = new System.Drawing.Size(100, 22);
            this.barIncomeTxt.TabIndex = 2;
            // 
            // barCostTxt
            // 
            this.barCostTxt.Location = new System.Drawing.Point(201, 112);
            this.barCostTxt.Name = "barCostTxt";
            this.barCostTxt.ReadOnly = true;
            this.barCostTxt.Size = new System.Drawing.Size(100, 22);
            this.barCostTxt.TabIndex = 1;
            // 
            // barinfoLbl
            // 
            this.barinfoLbl.AutoSize = true;
            this.barinfoLbl.Location = new System.Drawing.Point(67, 115);
            this.barinfoLbl.Name = "barinfoLbl";
            this.barinfoLbl.Size = new System.Drawing.Size(99, 16);
            this.barinfoLbl.TabIndex = 0;
            this.barinfoLbl.Text = "Bar Information:";
            // 
            // editDescription
            // 
            this.editDescription.Controls.Add(this.updateDescBtn);
            this.editDescription.Controls.Add(this.descLbl);
            this.editDescription.Controls.Add(this.richTextBox2);
            this.editDescription.Controls.Add(this.bankRefEditLbl);
            this.editDescription.Controls.Add(this.bRefCBox);
            this.editDescription.Location = new System.Drawing.Point(4, 25);
            this.editDescription.Name = "editDescription";
            this.editDescription.Padding = new System.Windows.Forms.Padding(3);
            this.editDescription.Size = new System.Drawing.Size(793, 418);
            this.editDescription.TabIndex = 5;
            this.editDescription.Text = "Edit Description";
            this.editDescription.UseVisualStyleBackColor = true;
            // 
            // updateDescBtn
            // 
            this.updateDescBtn.Location = new System.Drawing.Point(311, 279);
            this.updateDescBtn.Name = "updateDescBtn";
            this.updateDescBtn.Size = new System.Drawing.Size(102, 47);
            this.updateDescBtn.TabIndex = 7;
            this.updateDescBtn.Text = "Update Description";
            this.updateDescBtn.UseVisualStyleBackColor = true;
            this.updateDescBtn.Click += new System.EventHandler(this.updateDescBtn_Click);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(291, 25);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(149, 16);
            this.descLbl.TabIndex = 6;
            this.descLbl.Text = "Transaction Description";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(277, 44);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(174, 214);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // bankRefEditLbl
            // 
            this.bankRefEditLbl.AutoSize = true;
            this.bankRefEditLbl.Location = new System.Drawing.Point(96, 25);
            this.bankRefEditLbl.Name = "bankRefEditLbl";
            this.bankRefEditLbl.Size = new System.Drawing.Size(104, 16);
            this.bankRefEditLbl.TabIndex = 4;
            this.bankRefEditLbl.Text = "Bank Reference";
            // 
            // bRefCBox
            // 
            this.bRefCBox.FormattingEnabled = true;
            this.bRefCBox.Location = new System.Drawing.Point(70, 44);
            this.bRefCBox.Name = "bRefCBox";
            this.bRefCBox.Size = new System.Drawing.Size(166, 24);
            this.bRefCBox.TabIndex = 0;
            this.bRefCBox.SelectionChangeCommitted += new System.EventHandler(this.bRefCBox_SelectionChangeCommitted);
            // 
            // searchKeyword
            // 
            this.searchKeyword.Controls.Add(this.searchTable);
            this.searchKeyword.Controls.Add(this.searchKeywordBtn);
            this.searchKeyword.Controls.Add(this.searchKeywordLbl);
            this.searchKeyword.Controls.Add(this.searchColumnLbl);
            this.searchKeyword.Controls.Add(this.seachTableLbl);
            this.searchKeyword.Controls.Add(this.keywordSeach);
            this.searchKeyword.Controls.Add(this.searchColumnCBox);
            this.searchKeyword.Controls.Add(this.searchTableCBox);
            this.searchKeyword.Location = new System.Drawing.Point(4, 25);
            this.searchKeyword.Name = "searchKeyword";
            this.searchKeyword.Padding = new System.Windows.Forms.Padding(3);
            this.searchKeyword.Size = new System.Drawing.Size(793, 418);
            this.searchKeyword.TabIndex = 6;
            this.searchKeyword.Text = "Search Keyword";
            this.searchKeyword.UseVisualStyleBackColor = true;
            // 
            // searchTable
            // 
            this.searchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchTable.Location = new System.Drawing.Point(7, 135);
            this.searchTable.Name = "searchTable";
            this.searchTable.RowHeadersWidth = 51;
            this.searchTable.RowTemplate.Height = 24;
            this.searchTable.Size = new System.Drawing.Size(776, 262);
            this.searchTable.TabIndex = 7;
            // 
            // searchKeywordBtn
            // 
            this.searchKeywordBtn.Location = new System.Drawing.Point(661, 103);
            this.searchKeywordBtn.Name = "searchKeywordBtn";
            this.searchKeywordBtn.Size = new System.Drawing.Size(75, 23);
            this.searchKeywordBtn.TabIndex = 6;
            this.searchKeywordBtn.Text = "Search";
            this.searchKeywordBtn.UseVisualStyleBackColor = true;
            this.searchKeywordBtn.Click += new System.EventHandler(this.searchKeywordBtn_Click);
            // 
            // searchKeywordLbl
            // 
            this.searchKeywordLbl.AutoSize = true;
            this.searchKeywordLbl.Location = new System.Drawing.Point(474, 84);
            this.searchKeywordLbl.Name = "searchKeywordLbl";
            this.searchKeywordLbl.Size = new System.Drawing.Size(135, 16);
            this.searchKeywordLbl.TabIndex = 5;
            this.searchKeywordLbl.Text = "Keyword to search for";
            // 
            // searchColumnLbl
            // 
            this.searchColumnLbl.AutoSize = true;
            this.searchColumnLbl.Location = new System.Drawing.Point(277, 84);
            this.searchColumnLbl.Name = "searchColumnLbl";
            this.searchColumnLbl.Size = new System.Drawing.Size(110, 16);
            this.searchColumnLbl.TabIndex = 4;
            this.searchColumnLbl.Text = "Column to search";
            // 
            // seachTableLbl
            // 
            this.seachTableLbl.AutoSize = true;
            this.seachTableLbl.Location = new System.Drawing.Point(88, 86);
            this.seachTableLbl.Name = "seachTableLbl";
            this.seachTableLbl.Size = new System.Drawing.Size(101, 16);
            this.seachTableLbl.TabIndex = 3;
            this.seachTableLbl.Text = "Table to search";
            // 
            // keywordSeach
            // 
            this.keywordSeach.Location = new System.Drawing.Point(474, 105);
            this.keywordSeach.Name = "keywordSeach";
            this.keywordSeach.Size = new System.Drawing.Size(135, 22);
            this.keywordSeach.TabIndex = 2;
            // 
            // searchColumnCBox
            // 
            this.searchColumnCBox.FormattingEnabled = true;
            this.searchColumnCBox.Location = new System.Drawing.Point(243, 105);
            this.searchColumnCBox.Name = "searchColumnCBox";
            this.searchColumnCBox.Size = new System.Drawing.Size(183, 24);
            this.searchColumnCBox.TabIndex = 1;
            // 
            // searchTableCBox
            // 
            this.searchTableCBox.FormattingEnabled = true;
            this.searchTableCBox.Location = new System.Drawing.Point(72, 105);
            this.searchTableCBox.Name = "searchTableCBox";
            this.searchTableCBox.Size = new System.Drawing.Size(135, 24);
            this.searchTableCBox.TabIndex = 0;
            this.searchTableCBox.SelectionChangeCommitted += new System.EventHandler(this.searchTableCBox_SelectionChangeCommitted);
            // 
            // addMember
            // 
            this.addMember.Controls.Add(this.addMemberBtn);
            this.addMember.Controls.Add(this.memberEmail);
            this.addMember.Controls.Add(this.memberEmailBox);
            this.addMember.Controls.Add(this.memberNameBox);
            this.addMember.Controls.Add(this.memberNameLbl);
            this.addMember.Location = new System.Drawing.Point(4, 25);
            this.addMember.Name = "addMember";
            this.addMember.Padding = new System.Windows.Forms.Padding(3);
            this.addMember.Size = new System.Drawing.Size(793, 418);
            this.addMember.TabIndex = 7;
            this.addMember.Text = "Add Member ";
            this.addMember.UseVisualStyleBackColor = true;
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Location = new System.Drawing.Point(117, 252);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(112, 37);
            this.addMemberBtn.TabIndex = 4;
            this.addMemberBtn.Text = "Add member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // memberEmail
            // 
            this.memberEmail.AutoSize = true;
            this.memberEmail.Location = new System.Drawing.Point(155, 177);
            this.memberEmail.Name = "memberEmail";
            this.memberEmail.Size = new System.Drawing.Size(45, 16);
            this.memberEmail.TabIndex = 3;
            this.memberEmail.Text = "E-mail";
            // 
            // memberEmailBox
            // 
            this.memberEmailBox.Location = new System.Drawing.Point(82, 196);
            this.memberEmailBox.Name = "memberEmailBox";
            this.memberEmailBox.Size = new System.Drawing.Size(194, 22);
            this.memberEmailBox.TabIndex = 2;
            // 
            // memberNameBox
            // 
            this.memberNameBox.Location = new System.Drawing.Point(82, 108);
            this.memberNameBox.Name = "memberNameBox";
            this.memberNameBox.Size = new System.Drawing.Size(194, 22);
            this.memberNameBox.TabIndex = 1;
            // 
            // memberNameLbl
            // 
            this.memberNameLbl.AutoSize = true;
            this.memberNameLbl.Location = new System.Drawing.Point(145, 89);
            this.memberNameLbl.Name = "memberNameLbl";
            this.memberNameLbl.Size = new System.Drawing.Size(68, 16);
            this.memberNameLbl.TabIndex = 0;
            this.memberNameLbl.Text = "Full Name";
            // 
            // chartPage
            // 
            this.chartPage.Controls.Add(this.chart1);
            this.chartPage.Location = new System.Drawing.Point(4, 25);
            this.chartPage.Name = "chartPage";
            this.chartPage.Size = new System.Drawing.Size(793, 418);
            this.chartPage.TabIndex = 8;
            this.chartPage.Text = "Transaction Chart";
            this.chartPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(785, 414);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(603, 341);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(99, 45);
            this.LogoutBtn.TabIndex = 22;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigation);
            this.Name = "Form1";
            this.Text = "Sport\'s Accouting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navigation.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.responseTypeBox.ResumeLayout(false);
            this.responseTypeBox.PerformLayout();
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.registerPage.ResumeLayout(false);
            this.registerPage.PerformLayout();
            this.editTransaction.ResumeLayout(false);
            this.editTransaction.PerformLayout();
            this.modules.ResumeLayout(false);
            this.modules.PerformLayout();
            this.editDescription.ResumeLayout(false);
            this.editDescription.PerformLayout();
            this.searchKeyword.ResumeLayout(false);
            this.searchKeyword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).EndInit();
            this.addMember.ResumeLayout(false);
            this.addMember.PerformLayout();
            this.chartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navigation;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage registerPage;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.TextBox loginUsernameBox;
        private System.Windows.Forms.TabPage editTransaction;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label bankRefLbl;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.TabPage modules;
        private System.Windows.Forms.Label turnoverLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label costsLbl;
        private System.Windows.Forms.Button updateRental;
        private System.Windows.Forms.Button updateBatBtn;
        private System.Windows.Forms.Label rentalinfoLbl;
        private System.Windows.Forms.TextBox rentalTurnoverTxt;
        private System.Windows.Forms.TextBox rentalIncomeTxt;
        private System.Windows.Forms.TextBox rentalCostTxt;
        private System.Windows.Forms.TextBox barTurnoverTxt;
        private System.Windows.Forms.TextBox barIncomeTxt;
        private System.Windows.Forms.TextBox barCostTxt;
        private System.Windows.Forms.Label barinfoLbl;
        private System.Windows.Forms.Button generateSummaryBtn;
        private System.Windows.Forms.TabPage editDescription;
        private System.Windows.Forms.ComboBox bRefCBox;
        private System.Windows.Forms.Button goToEditDescBtn;
        private System.Windows.Forms.Button updateDescBtn;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label bankRefEditLbl;
        private System.Windows.Forms.Button modulesInfoBtn;
        private System.Windows.Forms.TabPage searchKeyword;
        private System.Windows.Forms.Button searchKeywordBtn;
        private System.Windows.Forms.Label searchKeywordLbl;
        private System.Windows.Forms.Label searchColumnLbl;
        private System.Windows.Forms.Label seachTableLbl;
        private System.Windows.Forms.TextBox keywordSeach;
        private System.Windows.Forms.ComboBox searchColumnCBox;
        private System.Windows.Forms.ComboBox searchTableCBox;
        private System.Windows.Forms.Button searchKWordBtn;
        private System.Windows.Forms.TabPage addMember;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.Label memberEmail;
        private System.Windows.Forms.TextBox memberEmailBox;
        private System.Windows.Forms.TextBox memberNameBox;
        private System.Windows.Forms.Label memberNameLbl;
        private System.Windows.Forms.Button addMemberBtnMain;
        private System.Windows.Forms.Label memberTrans;
        private System.Windows.Forms.Label availableBalanceLbl;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox userTypeBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage chartPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox responseTypeBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private RadioButton xmlResponseSlct;
        private RadioButton jsonResponseSlct;
        private DataGridView searchTable;
        private Button LogoutBtn;
    }
}


using System;
using System.Net.Http;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private const string apiServerIp = "http://127.0.0.1:122";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            string transId = "";
            var trans = await GetTransactionDetails(transId);
            var tupleTrans = (trans[0], trans[0], trans[0], trans[0], trans[0], trans[0], trans[0], trans[0], trans[0], trans[0], trans[0], trans[0]);

            // - Table -
            var table = new DataGridView();
            table.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "ID", DataPropertyName = "Id", Width = 20 },
                new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "Date", Width = 70 },
                new DataGridViewTextBoxColumn { Name = "Details", DataPropertyName = "Details", Width = 300 },
                new DataGridViewTextBoxColumn { Name = "Description", DataPropertyName = "Description", Width = 240 },
                new DataGridViewTextBoxColumn { Name = "Ref", DataPropertyName = "Ref", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Amount", DataPropertyName = "Amount", Width = 50 },
                new DataGridViewTextBoxColumn { Name = "BarID", DataPropertyName = "BarID", Width = 50 },
                new DataGridViewTextBoxColumn { Name = "Bar", DataPropertyName = "Bar", Width = 70 },
                new DataGridViewTextBoxColumn { Name = "RentalID", DataPropertyName = "RentalID", Width = 50 },
                new DataGridViewTextBoxColumn { Name = "Rental", DataPropertyName = "Rental", Width = 70 },
                new DataGridViewTextBoxColumn { Name = "Type", DataPropertyName = "Type", Width = 55 },
                new DataGridViewTextBoxColumn { Name = "Currency", DataPropertyName = "Currency", Width = 55 }
            );

            table.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0AFAF");
            table.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            table.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            table.RowHeadersVisible = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.BackgroundColor = System.Drawing.Color.White;
            table.BorderStyle = BorderStyle.None;
            table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            table.GridColor = System.Drawing.Color.LightGray;

            var tupleTransArray = new object[] { tupleTrans.Item1, tupleTrans.Item2, tupleTrans.Item3, tupleTrans.Item4,
                tupleTrans.Item5, tupleTrans.Item6, tupleTrans.Item7, tupleTrans.Item8, tupleTrans.Item9,
                tupleTrans.Item10, tupleTrans.Item11, tupleTrans.Item12 };
            table.Rows.Add(tupleTransArray);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }

        private async Task<object[]> GetTransactionDetails(string transId)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiServerIp + "/api/getTransactionOnIdJoin/" + transId);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var trans = JsonConvert.DeserializeObject<object[]>(json);
                    if (trans.Length > 0)
                    {
using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace ERPPrintingApplication
{
    public partial class PickPackWizardForm : Form
    {
        private Row _order;
        private Dictionary<string, string> _countries;
        private MagentoSoapAPI.salesOrderEntity _orderItems;
        private Dictionary<int, int> _warehouse;
        private bool _print = false;
        private bool _allPacked = false;
        private bool _upsDK;
        private bool _sign;
        private C1FlexGrid _orderGrid;

        public bool Print { get { return _print; } }

        public PickPackWizardForm()
        {
            InitializeComponent();
        }

        public PickPackWizardForm(Row order, Dictionary<string, string> countries, Dictionary<string, MagentoSoapAPI.salesOrderEntity> items, Dictionary<int, int> warehouse, C1FlexGrid orderGrid, bool UPSDK, bool sign)
        {
            InitializeComponent();
            _order = order;
            _countries = countries;
            _orderItems = items[order["increment_id"].ToString()];
            _warehouse = warehouse;
            _orderGrid = orderGrid;
            _upsDK = UPSDK;
            _sign = sign;

        }

        private void PickPackWizardForm_Load(object sender, EventArgs e)
        {
            Helper.FillAddress(label_OrderNumber, label_Address, _order, _countries);
            Helper.FillItems(_orderItems, c1FlexGrid_Items, _warehouse);
            DisableCheckbox();
            //Program.PrintService.PrintInvoice(label_Address.Text, c1FlexGrid_Items, label_OrderNumber.Text);

            this.ActiveControl = c1TextBox_BarcodeInput;         
        }

        private void DisableCheckbox()
        {
            foreach (Row row in c1FlexGrid_Items.Rows.Cast<Row>().Skip(1))
            {
                string selectStr = "SELECT * FROM barcode WHERE sku='" + row[2] + "'";
                Debug.WriteLine(row[2]);
                string connectionString = Properties.Settings.Default.BarcodeDataConnectionString; // @"Data Source=C:\Users\Alina\Source\Repos\PrintingApplication\ERPPrintingApplication\BarcodeData.mdf;Persist Security Info=False;";
                DataSet result = new DataSet();
                SqlConnection con = new SqlConnection(connectionString);
                DataTable table = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(selectStr, con);
                con.Open();
                adp.Fill(table);
                if (table.Rows.Count != 0) Debug.WriteLine(""); 
                c1FlexGrid_Items[row.DataIndex, 5].ToString();
            }
        }

        private void c1TextBox_BarcodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                SearchDB(c1TextBox_BarcodeInput.Text);
            }
        }

        private void SearchDB(string barcode)
        {
            Console.WriteLine("Barcode Scaned: " + barcode);
            string selectStr = "SELECT * FROM barcode WHERE barcode_seq=" + barcode;
            string connectionString = Properties.Settings.Default.BarcodeDataConnectionString; // @"Data Source=C:\Users\Alina\Source\Repos\PrintingApplication\ERPPrintingApplication\BarcodeData.mdf;Persist Security Info=False;";


            DataSet result = new DataSet();

            SqlConnection con = new SqlConnection(connectionString);
            DataTable table = new DataTable();

            SqlDataAdapter adp = new SqlDataAdapter(selectStr, con);

            con.Open();

            adp.Fill(table);
            if (table.Rows.Count == 0) MessageBox.Show("No product found with this barcode");
            else if (table.Rows.Count > 0) FindAndPack(table.Rows[0][1].ToString(), int.Parse(table.Rows[0][2].ToString()));
            c1TextBox_BarcodeInput.Clear();
            
        }

        private void FindAndPack(string sku, int qty)
        {
            foreach (Row r in c1FlexGrid_Items.Rows.Cast<Row>().Skip(1))
            {
                if (r[2].ToString() == sku)
                {
                    int toPack = int.Parse(r[3].ToString());
                    int packed = int.Parse(r[4].ToString());
                    packed += qty;
                    r[4] = packed;
                    if (toPack == packed)
                    {
                        r[5] = true;
                        _allPacked = Helper.AllItemsPacked(c1FlexGrid_Items);
                        if (_allPacked)
                        {
                            Helper.ShippingLabelPrint(_orderGrid, _countries, label_Address.Text, _upsDK, _sign);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
        }

        private void c1Button_Next_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void c1FlexGrid_Items_CellChecked(object sender, RowColEventArgs e)
        {
            _allPacked = Helper.AllItemsPacked(c1FlexGrid_Items);
            if (_allPacked)
            {
                Helper.ShippingLabelPrint(_orderGrid, _countries, label_Address.Text, _upsDK, _sign);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}

using C1.Win.C1FlexGrid;
using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.IO;

namespace ERPPrintingApplication
{
    public partial class MainForm : Form
    {
        private Properties.Settings _propSet;
        private string _orderID;
        private Dictionary<string,MagentoSoapAPI.salesOrderEntity> _orderItemArray = new Dictionary<string,MagentoSoapAPI.salesOrderEntity>();
        #region "Country Codes"
        private Dictionary<string, string> _countries = new Dictionary<string,string> {
            {"AF","Afghanistan"},
            {"AL","Albania"}, 
            {"DZ","Algeria"},
            {"AS","American Samoa"},
            {"AD","Andorra"},
            {"AO","Angola"},
            {"AI","Anguilla"},
            {"AQ","Antarctica"},
            {"AG","Antigua and Barbuda"},
            {"AR","Argentina"},
            {"AM","Armenia"},
            {"AW","Aruba"},
            {"AU","Australia"},
            {"AT","Austria"},
            {"AZ","Azerbaijan"},
            {"BS","Bahamas"},
            {"BH","Bahrain"},
            {"BD","Bangladesh"},
            {"BB","Barbados"},
            {"BY","Belarus"},
            {"BE","Belgium"},
            {"BZ","Belize"},
            {"BJ","Benin"},
            {"BM","Bermuda"},
            {"BT","Bhutan"},
            {"BO","Bolivia"},
            {"BA","Bosnia and Herzegovina"},
            {"BW","Botswana"},
            {"BV","Bouvet Island"},
            {"BR","Brazil"},
            {"IO","British Indian Ocean Territory"},
            {"BN","Brunei Darussalam"},
            {"BG","Bulgaria"},
            {"BF","Burkina Faso"},
            {"BI","Burundi"},
            {"KH","Cambodia"},
            {"CM","Cameroon"},
            {"CA","Canada"},
            {"CV","Cape Verde"},
            {"KY","Cayman Islands"},
            {"CF","Central African Republic"},
            {"TD","Chad"},
            {"CL","Chile"},
            {"CN","China"},
            {"CX","Christmas Island"},
            {"CC","Cocos (Keeling) Islands"},
            {"CO","Colombia"},
            {"KM","Comoros"},
            {"CG","Congo"},
            {"CD","Congo, the Democratic Republic of the"},
            {"CK","Cook Islands"},
            {"CR","Costa Rica"},
            {"CI","Cote D'Ivoire"},
            {"HR","Croatia"},
            {"CU","Cuba"},
            {"CY","Cyprus"},
            {"CZ","Czech Republic"},
            {"DK","Denmark"},
            {"DJ","Djibouti"},
            {"DM","Dominica"},
            {"DO","Dominican Republic"},
            {"EC","Ecuador"},
            {"EG","Egypt"},
            {"SV","El Salvador"},
            {"GQ","Equatorial Guinea"},
            {"ER","Eritrea"},
            {"EE","Estonia"},
            {"ET","Ethiopia"},
            {"FK","Falkland Islands (Malvinas)"},
            {"FO","Faroe Islands"},
            {"FJ","Fiji"},
            {"FI","Finland"},
            {"FR","France"},
            {"GF","French Guiana"},
            {"PF","French Polynesia"},
            {"TF","French Southern Territories"},
            {"GA","Gabon"},
            {"GM","Gambia"},
            {"GE","Georgia"},
            {"DE","Germany"},
            {"GH","Ghana"},
            {"GI","Gibraltar"},
            {"GR","Greece"},
            {"GL","Greenland"},
            {"GD","Grenada"},
            {"GP","Guadeloupe"},
            {"GU","Guam"},
            {"GT","Guatemala"},
            {"GN","Guinea"},
            {"GW","Guinea-Bissau"},
            {"GY","Guyana"},
            {"HT","Haiti"},
            {"HM","Heard Island and Mcdonald Islands"},
            {"VA","Holy See (Vatican City State)"},
            {"HN","Honduras"},
            {"HK","Hong Kong"},
            {"HU","Hungary"},
            {"IS","Iceland"},
            {"IN","India"},
            {"ID","Indonesia"},
            {"IR","Iran, Islamic Republic of"},
            {"IQ","Iraq"},
            {"IE","Ireland"},
            {"IL","Israel"},
            {"IT","Italy"},
            {"JM","Jamaica"},
            {"JP","Japan"},
            {"JO","Jordan"},
            {"KZ","Kazakhstan"},
            {"KE","Kenya"},
            {"KI","Kiribati"},
            {"KP","Korea, Democratic People's Republic of"},
            {"KR","Korea, Republic of"},
            {"KW","Kuwait"},
            {"KG","Kyrgyzstan"},
            {"LA","Lao People's Democratic Republic"},
            {"LV","Latvia"},
            {"LB","Lebanon"},
            {"LS","Lesotho"},
            {"LR","Liberia"},
            {"LY","Libyan Arab Jamahiriya"},
            {"LI","Liechtenstein"},
            {"LT","Lithuania"},
            {"LU","Luxembourg"},
            {"MO","Macao"},
            {"MK","Macedonia, the Former Yugoslav Republic of"},
            {"MG","Madagascar"},
            {"MW","Malawi"},
            {"MY","Malaysia"},
            {"MV","Maldives"},
            {"ML","Mali"},
            {"MT","Malta"},
            {"MH","Marshall Islands"},
            {"MQ","Martinique"},
            {"MR","Mauritania"},
            {"MU","Mauritius"},
            {"YT","Mayotte"},
            {"MX","Mexico"},
            {"FM","Micronesia, Federated States of"},
            {"MD","Moldova, Republic of"},
            {"MC","Monaco"},
            {"MN","Mongolia"},
            {"MS","Montserrat"},
            {"MA","Morocco"},
            {"MZ","Mozambique"},
            {"MM","Myanmar"},
            {"NA","Namibia"},
            {"NR","Nauru"},
            {"NP","Nepal"},
            {"NL","Netherlands"},
            {"AN","Netherlands Antilles"},
            {"NC","New Caledonia"},
            {"NZ","New Zealand"},
            {"NI","Nicaragua"},
            {"NE","Niger"},
            {"NG","Nigeria"},
            {"NU","Niue"},
            {"NF","Norfolk Island"},
            {"MP","Northern Mariana Islands"},
            {"NO","Norway"},
            {"OM","Oman"},
            {"PK","Pakistan"},
            {"PW","Palau"},
            {"PS","Palestinian Territory, Occupied"},
            {"PA","Panama"},
            {"PG","Papua New Guinea"},
            {"PY","Paraguay"},
            {"PE","Peru"},
            {"PH","Philippines"},
            {"PN","Pitcairn"},
            {"PL","Poland"},
            {"PT","Portugal"},
            {"PR","Puerto Rico"},
            {"QA","Qatar"},
            {"RE","Reunion"},
            {"RO","Romania"},
            {"RU","Russian Federation"},
            {"RW","Rwanda"},
            {"SH","Saint Helena"},
            {"KN","Saint Kitts and Nevis"},
            {"LC","Saint Lucia"},
            {"PM","Saint Pierre and Miquelon"},
            {"VC","Saint Vincent and the Grenadines"},
            {"WS","Samoa"},
            {"SM","San Marino"},
            {"ST","Sao Tome and Principe"},
            {"SA","Saudi Arabia"},
            {"SN","Senegal"},
            {"RS","Serbia"},
            {"CS","Serbia and Montenegro"},
            {"SC","Seychelles"},
            {"SL","Sierra Leone"},
            {"SG","Singapore"},
            {"SK","Slovakia"},
            {"SI","Slovenia"},
            {"SB","Solomon Islands"},
            {"SO","Somalia"},
            {"ZA","South Africa"},
            {"GS","South Georgia and the South Sandwich Islands"},
            {"ES","Spain"},
            {"LK","Sri Lanka"},
            {"SD","Sudan"},
            {"SR","Suriname"},
            {"SJ","Svalbard and Jan Mayen"},
            {"SZ","Swaziland"},
            {"SE","Sweden"},
            {"CH","Switzerland"},
            {"SY","Syrian Arab Republic"},
            {"TW","Taiwan, Province of China"},
            {"TJ","Tajikistan"},
            {"TZ","Tanzania, United Republic of"},
            {"TH","Thailand"},
            {"TL","Timor-Leste"},
            {"TG","Togo"},
            {"TK","Tokelau"},
            {"TO","Tonga"},
            {"TT","Trinidad and Tobago"},
            {"TN","Tunisia"},
            {"TR","Turkey"},
            {"TM","Turkmenistan"},
            {"TC","Turks and Caicos Islands"},
            {"TV","Tuvalu"},
            {"UG","Uganda"},
            {"UA","Ukraine"},
            {"AE","United Arab Emirates"},
            {"GB","United Kingdom"},
            {"US","United States"},
            {"UM","United States Minor Outlying Islands"},
            {"UY","Uruguay"},
            {"UZ","Uzbekistan"},
            {"VU","Vanuatu"},
            {"VE","Venezuela"},
            {"VN","Viet Nam"},
            {"VG","Virgin Islands, British"},
            {"VI","Virgin Islands, US"},
            {"WF","Wallis and Futuna"},
            {"EH","Western Sahara"},
            {"YE","Yemen"},
            {"ZM","Zambia"},
            {"ZW","Zimbabwe"},
     };
        #endregion
        private Dictionary<int, int> _preparationWarehouse = new Dictionary<int, int>{{0, 2}, {1,4}, {2,3}};
        private Dictionary<int, string> _warehouse = new Dictionary<int, string> { {0, "Sweden"}, {1, "Denmark"}, {2, "USA"} };
        private string _upsDescription = "Snus";
        private bool _restart = false;
        
        public MainForm()
        {
            InitializeComponent();
            _propSet = Properties.Settings.Default;
            LoadSettings();
        }

        private void LoadSettings()
        {
            label_InvoicePrinterName.Text = _propSet.INVOICE_PRINTER;
            label_InvoicePrinterDrawer.Text = _propSet.INVOICE_PRINTER_DRAWER;
            label_InvoicePrinterPaper.Text = Math.Round(_propSet.INVOICE_PRINTER_PAPER_WIDTH / 40.0, 1) + " cm x " + Math.Round(_propSet.INVOICE_PRINTER_PAPER_HEIGHT / 40.0, 1) + " cm";

            label_LabelPrinterName.Text = _propSet.LABEL_PRINTER;
            label_LabelPrinterDrawer.Text = _propSet.LABEL_PRINTER_DRAWER;
            label_LabelPrinterPaper.Text = Math.Round(_propSet.LABEL_PRINTER_PAPER_WIDTH/40.0, 1) + " cm x " + Math.Round(_propSet.LABEL_PRINTER_PAPER_HEIGHT/40.0, 1) + " cm";
            label_UPSPathLabel.Text = _propSet.UPS_IMPORT_PATH;

            c1CheckBox_EnableUPSForDK.Checked = _propSet.UPGRADE_TO_UPS;
            c1CheckBox_AdultSign.Checked = _propSet.REQ_ADULT;
            if(c1NumericEdit_WieghtLimit.Enabled) c1NumericEdit_WieghtLimit.Value = _propSet.UPS_UPGRADE_WEIGHT;
  
            c1ComboBox_waredhouseID.SelectedIndex = _propSet.WAREHOUSE;
            c1TextBox_ReturnAddress1.Visible = true;
            c1TextBox_ReturnAddress1.Enabled = true;
            c1TextBox_ReturnAddress1.ReadOnly = false;
            c1TextBox_ReturnAddress1.DisableOnNoData = false;
            c1TextBox_ReturnAddress1.Text = _propSet.RETURN_ADDRESS1;
            c1TextBox_ReturnAddress2.Text = _propSet.RETURN_ADDRESS2;
         }

        private void c1Button_InvoicePrinterConfig_Click(object sender, EventArgs e)
        {
            if (printInvoiceDialog.ShowDialog() == DialogResult.OK)
            {
                Program.PrintService.InvoicePrinterConfiguration(printInvoiceDialog);

                label_InvoicePrinterName.Text = printInvoiceDialog.PrinterSettings.PrinterName;
                label_InvoicePrinterDrawer.Text = printInvoiceDialog.PrinterSettings.DefaultPageSettings.PaperSource.SourceName;
                label_InvoicePrinterPaper.Text = Math.Round(_propSet.INVOICE_PRINTER_PAPER_WIDTH / 40.0, 1) + " cm x " + Math.Round(_propSet.INVOICE_PRINTER_PAPER_HEIGHT / 40.0, 1) + " cm";
                _propSet.INVOICE_PRINTER_MARGIN_TOP = printInvoiceDialog.PrinterSettings.DefaultPageSettings.Margins.Top;
                _propSet.INVOICE_PRINTER_MARGIN_LEFT = printInvoiceDialog.PrinterSettings.DefaultPageSettings.Margins.Left;
            }
        }

        private void c1Button_LabelPrinterConfig_Click(object sender, EventArgs e)
        {
            if (printLabelDialog.ShowDialog() == DialogResult.OK)
            {
                Program.PrintService.LabelPrinterConfiguration(printLabelDialog);
                
                label_LabelPrinterName.Text = printLabelDialog.PrinterSettings.PrinterName;
                label_LabelPrinterDrawer.Text = printLabelDialog.PrinterSettings.DefaultPageSettings.PaperSource.SourceName;
                label_LabelPrinterPaper.Text = Math.Round(printLabelDialog.PrinterSettings.DefaultPageSettings.PaperSize.Width / 40.0, 1) + " cm x " + Math.Round(printLabelDialog.PrinterSettings.DefaultPageSettings.PaperSize.Height / 40.0, 1) + " cm";
            }
        }

        private void c1Button_InvoicePreview_Click(object sender, EventArgs e) {}

        private void c1Button_LabelPreview_Click(object sender, EventArgs e) {}

        private void c1ComboBox_waredhouseID_SelectedItemChanged(object sender, EventArgs e)
        {
            _propSet.WAREHOUSE = c1ComboBox_waredhouseID.SelectedIndex;
            if (_propSet.WAREHOUSE == 2) _propSet.UPS_WEIGHT_TYPE = 1;
            _propSet.Save();
            c1FlexGrid_ListOfOrders.DataSource = Program.MagentoService.GetOrders(_warehouse[_propSet.WAREHOUSE]);
            if (backgroundWorker.IsBusy)
            { 
                _restart = true;
                backgroundWorker.CancelAsync();          
            }
            else
            {
                c1FlexGrid_ListOfOrders.Enabled = false;
                backgroundWorker.RunWorkerAsync();
            }
            StyleTheGrid(c1FlexGrid_ListOfOrders);
        }

        private void StyleTheGrid(C1FlexGrid g)
        {
            for (int i = 0; i < g.Cols.Count; i++ ) g.Cols[i].AllowFiltering = AllowFiltering.None;
            g.Cols["shipping_description"].AllowFiltering = AllowFiltering.ByValue;
            g.Cols["created_at"].Visible = false;
            g.Cols["updated_at"].Visible = false;
            //g.Cols["status"].Visible = false;

            g.Cols["increment_id"].Caption = "order #";
            g.Cols["shipping_name"].Caption = "name";
            g.Cols["country_id"].Caption = "country";
            g.Cols["base_grand_total"].Caption = "value";
            g.Cols["shipping_description"].Caption = "service";

            g.Cols["increment_id"].Width = 75;
            g.Cols["shipping_name"].Width = 120;
            g.Cols["company"].Width = 100;
            g.Cols["street"].Width = 175;
            g.Cols["city"].Width = 100;
            g.Cols["postcode"].Width = 70;
            g.Cols["region"].Width = 80;
            g.Cols["country_id"].Width = 50;
            g.Cols["base_grand_total"].Width = 50;
            g.Cols["weight"].Width = 50;
            g.Cols["shipping_description"].Width = 180;
        }

        private void c1FlexGrid_ListOfOrders_Click(object sender, EventArgs e)
        {
            FillOrderDetails(c1FlexGrid_ListOfOrders);
            c1SplitterPanel_OrderDetail.Visible = true;
            c1SplitterPanel_Items.Visible = true;
        }

       
        private void c1DockingTabPage_Settings_Enter(object sender, EventArgs e)
        {
            c1ComboBox_waredhouseID.SelectedIndex = _propSet.WAREHOUSE;
        }

        internal void c1Button_Invoice_Print_Click(object sender, EventArgs e)
        {
            Program.PrintService.PrintInvoice(label_orderAddressDetail.Text, c1FlexGrid_Items, label_orderNumberDetail.Text);
        }

        internal void c1Button_Label_Print_Click(object sender, EventArgs e)
        {
            Helper.ShippingLabelPrint(c1FlexGrid_ListOfOrders, _countries, label_orderAddressDetail.Text, c1CheckBox_EnableUPSForDK.Checked, c1CheckBox_AdultSign.Checked);
        }

        private void c1Button_SaveAddress_Click(object sender, EventArgs e)
        {
            _propSet.RETURN_ADDRESS1 = c1TextBox_ReturnAddress1.Text;
            _propSet.RETURN_ADDRESS2 = c1TextBox_ReturnAddress2.Text;
            _propSet.Save();
        }

        private void FillOrderItemArray()
        {
            int i = 0;
            foreach (Row row in c1FlexGrid_ListOfOrders.Rows)
            {
                if (i > 0) _orderItemArray[row[1].ToString()] = Program.MagentoService.RetrieveOrderInformation(row["increment_id"].ToString());
                i++;
            }
        }

        private void FillOrderDetails(C1FlexGrid grid)
        {
            Helper.FillAddress(label_orderNumberDetail, label_orderAddressDetail, c1FlexGrid_ListOfOrders.Rows[c1FlexGrid_ListOfOrders.RowSel], _countries);

            _orderID = grid.GetData(c1FlexGrid_ListOfOrders.RowSel, "increment_id").ToString();

            CellRange rng = c1FlexGrid_Items.GetCellRange(1, 0, c1FlexGrid_Items.Rows.Count - 1, c1FlexGrid_Items.Cols.Count - 1);
            rng.Clear(ClearFlags.Content);

            MagentoSoapAPI.salesOrderEntity orderData = _orderItemArray[_orderID.ToString()];

            Helper.FillItems(orderData, c1FlexGrid_Items, _preparationWarehouse);

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            c1FlexGrid_ListOfOrders.Invoke(new MethodInvoker(delegate { c1FlexGrid_ListOfOrders.Enabled = false; }));
            c1SplitterPanel_OrderDetail.Invoke(new MethodInvoker(delegate { c1SplitterPanel_OrderDetail.Visible = false; }));
            c1SplitterPanel_Items.Invoke(new MethodInvoker(delegate { c1SplitterPanel_Items.Visible = false; }));
                
            for(int i = 1; i < c1FlexGrid_ListOfOrders.Rows.Count; i++)
            {
                _orderItemArray[c1FlexGrid_ListOfOrders[i, 1].ToString()] = Program.MagentoService.RetrieveOrderInformation(c1FlexGrid_ListOfOrders[i, "increment_id"].ToString());
                backgroundWorker.ReportProgress((i * 100) / c1FlexGrid_ListOfOrders.Rows.Count);
                ribbonLabel_Progress.Text = "   " + (i * 100) / c1FlexGrid_ListOfOrders.Rows.Count + "%     ";
                
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }
         
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                ribbonProgressBar.Value = e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled && _restart)
            {
                _restart = false;
                ribbonProgressBar.Value = 0;
                backgroundWorker.RunWorkerAsync();
            }
            ribbonLabel_Progress.Text = "Done   ";
            ribbonProgressBar.Value = 0;
            c1FlexGrid_ListOfOrders.Enabled = true;
        }

        private void c1Button_FolderBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_UPS.ShowDialog() == DialogResult.OK)
            {
                _propSet.UPS_IMPORT_PATH = folderBrowserDialog_UPS.SelectedPath;
                _propSet.Save();
                label_UPSPathLabel.Text = folderBrowserDialog_UPS.SelectedPath;
            }
        }

        private void c1CheckBox_EnableUPSForDK_CheckStateChanged(object sender, EventArgs e)
        {
            _propSet.UPGRADE_TO_UPS = c1CheckBox_EnableUPSForDK.Checked;
            if (c1CheckBox_EnableUPSForDK.Checked) c1NumericEdit_WieghtLimit.Enabled = true;
            else c1NumericEdit_WieghtLimit.Enabled = false;
            _propSet.Save();
        }

        private void c1NumericEdit_WieghtLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _propSet.UPS_UPGRADE_WEIGHT = c1NumericEdit_WieghtLimit.Text;
                _propSet.Save();
            }
        }

        private void c1CheckBox_AdultSign_CheckStateChanged(object sender, EventArgs e)
        {
            _propSet.REQ_ADULT = c1CheckBox_AdultSign.Checked;
            _propSet.Save();
        }



        

        private void c1FlexGrid_Items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Debug.WriteLine("Scaned code");
            }
        }

        private void c1Button_PickPack_Click(object sender, EventArgs e)
        {
            foreach (Row order in c1FlexGrid_ListOfOrders.Rows.Cast<Row>().Skip(1))
            {
                if(order.IsVisible)
                {
                    using (PickPackWizardForm pickPackWiz = new PickPackWizardForm(order, _countries, _orderItemArray, _preparationWarehouse, c1FlexGrid_ListOfOrders, c1CheckBox_EnableUPSForDK.Checked, c1CheckBox_AdultSign.Checked))
                    {
                        if (pickPackWiz.ShowDialog() == DialogResult.OK) continue;
                        else if (pickPackWiz.DialogResult == DialogResult.Cancel) break;
                    }
                }            
            }
        }
    }
}

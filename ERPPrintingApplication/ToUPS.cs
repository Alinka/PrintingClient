using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPPrintingApplication
{
    class ToUPS
    {
        private Properties.Settings _propSet;

        public ToUPS()
        {
            _propSet = Properties.Settings.Default;
        }
        
        internal void Create_UPS_XML(int rowN, string service, C1FlexGrid g, Dictionary<string, string> _countries, string _upsDescription, string reqSign)
        {           
            string xmltext = "<?xml version=\"1.0\" ?>\n<OpenShipments xmlns=\"x-schema:openshipments.xdr\">\n";
            xmltext += "\t<OpenShipment ShipmentOption=\"\" ProcessStatus=\"\" >\n";
            xmltext += "\t\t<ShipTo>\n";
            if (g[rowN, "company"] != null)
            {
                xmltext += XMLtag("CompanyOrName", g[rowN, "company"].ToString());
                xmltext += XMLtag("Attention", g[rowN, "shipping_name"].ToString());
            }
            else
            {
                xmltext += XMLtag("CompanyOrName", g[rowN, "shipping_name"].ToString());
                xmltext += XMLtag("Attention", ".");
            }
            xmltext += XMLtag("Address1", g[rowN, "street"].ToString());
            xmltext += XMLtag("CountryTerritory", _countries[g[rowN, "country_id"].ToString()]);
            xmltext += XMLtag("PostalCode", g[rowN, "postcode"].ToString());
            xmltext += XMLtag("CityOrTown", g[rowN, "city"].ToString());


            if (g[rowN, "region"] != null) xmltext += XMLtag("StateProvinceCounty", g[rowN, "region"].ToString());

            xmltext += XMLtag("Telephone", g[rowN, "telephone"].ToString());
            xmltext += XMLtag("EmailAddress", g[rowN, "customer_email"].ToString());
            xmltext += "\t\t</ShipTo>\n";
            xmltext += "\t\t<ShipmentInformation>\n";
            xmltext += XMLtag("ServiceType", service);
            xmltext += XMLtag("NumberOfPackages", "1");
            xmltext += XMLtag("DescriptionOfGoods", _upsDescription);
            xmltext += XMLtag("ShipperNumber", "");
            xmltext += XMLtag("BillingOption", "Prepaid");
            xmltext += XMLtag("BillTransportationTo", "");
            xmltext += XMLtag("BillDutyTaxTo", "");
            xmltext += XMLtag("SplitDutyAndTax", "");

            if (_propSet.UPS_WEIGHT_TYPE == 1)
            {
                xmltext += "\t\t\t\t<SpecialCommodities>\n";
                xmltext += XMLtag("ISC-Tobacco", "Y");
                xmltext += "\t\t\t\t</SpecialCommodities>\n";
            }
            xmltext += XMLtag("AdditionalDocuments", "Y");
            xmltext += "\t\t</ShipmentInformation>\n";

            xmltext += "\t\t<Package>\n";
            xmltext += XMLtag("PackageType", "Package");
            xmltext += XMLtag("Weight", getUPSWeight(rowN, g));
            /** 
             * TO DO:
             *      Replace g[rowN, 1].ToString() with shipment number
             */
            xmltext += XMLtag("Reference1", g[rowN, 1].ToString());
            xmltext += XMLtag("Reference2", g[rowN, "increment_id"].ToString());
            if (Properties.Settings.Default.UPS_WEIGHT_TYPE == 1)
                xmltext += XMLtag("Reference3", "VERIFY AGE OF 19 OR OVER");

            xmltext += "\t<QVNOrReturnNotificationOption>\n";
            xmltext += "\t\t<QVNOrReturnRecipientAndNotificationTypes>\n";
            xmltext += XMLtag("EMailAddress", g[rowN, "customer_email"].ToString());
            xmltext += XMLtag("Ship", "1");
            xmltext += "\t\t</QVNOrReturnRecipientAndNotificationTypes>\n";
            xmltext += XMLtag("SubjectLine", "0");
            /** 
             * TO DO:
             *      Replace g[rowN, 1].ToString() with shipment number
             */
            xmltext += XMLtag("Memo", "Shipment #" + g[rowN, 1].ToString());
            xmltext += "\t</QVNOrReturnNotificationOption>\n";
            xmltext += "\t<DeliveryConfirmation>\n";
            xmltext += XMLtag("AdultSignatureRequired", reqSign);
            xmltext += "\t</DeliveryConfirmation>\n";
            xmltext += "\t\t</Package>\n";

            xmltext += "\t</OpenShipment>\n";
            xmltext += "</OpenShipments>\n";
            try
            {
                string filename = _propSet.UPS_IMPORT_PATH + "\\ups-standard-" + g[rowN, 1].ToString() + ".xml";
                FileStream f = new FileStream(filename, FileMode.CreateNew);
                StreamWriter w = new StreamWriter(f);
                w.Write(xmltext);
                w.Close();
                f.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string XMLtag(string tag, string text)
        {
            return "\t\t\t\t<" + tag + ">" + String_2_XML(text) + "</" + tag + ">\n";

        }

        private string String_2_XML(string Text)
        {
            string r = Text;
            r = r.Replace("&", "&amp;");
            r = r.Replace("<", "&lt;");
            r = r.Replace(">", "&gt;");
            r = r.Replace("\"", "&quote;");
            r = r.Replace("'", "&apos;");
            r = r.Replace("ß", "ss");
            return r;
        }

        private string getUPSWeight(int row, C1FlexGrid grid)
        {
            double w = Convert.ToDouble(grid[row, "weight"], new System.Globalization.CultureInfo("en-US").NumberFormat);
            if (_propSet.UPS_WEIGHT_TYPE == 1)
                w = Math.Ceiling(w * 0.45);
            else
                w = Math.Round(w, 2);

            if (w < 0.1) w = 0.1;
            return w.ToString().Replace(",", ".");
        }
    }
}

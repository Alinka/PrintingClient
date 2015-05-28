using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Diagnostics;

namespace ERPPrintingApplication
{
    class Helper
    {
        private static string[] _EUarray = { "AT", "BE", "BG", "CY", "CZ", "DE", "ES", "FR", "GB", "GR", "HU", "HR", "IE", "IT", "LT", "LU", "LV", "MT", "MC", "NL", "PL", "PT", "RO", "SI", "SE", "SK" };
        
        internal static void FillAddress(Label number, Label address, Row row, Dictionary<string, string> countries)
        {
            number.Text = "Order #" + row["increment_id"];
            address.Text = row["shipping_name"] + "\n";
            if (row["company"] != null)
                address.Text += row["company"] + "\n";
            address.Text += row["street"] + "\n" + row["city"] + "\n";
            if (row["region"] != null)
                address.Text += row["region"] + "\n";
            address.Text += row["postcode"] + "\n" + countries[row["country_id"].ToString()];
        }

        internal static void FillItems(MagentoSoapAPI.salesOrderEntity orderData, C1FlexGrid grid, Dictionary<int, int> _preparationWarehouse)
        {
            int i = 0;
            int snus = 0;
            int snuff = 0;
            int tobfree = 0;
            if (orderData != null)
            {
                foreach (MagentoSoapAPI.salesOrderItemEntity item in orderData.items)
                {
                    int x, y, z = 0;
                    x = Convert.ToInt32(item.qty_ordered.Remove(item.qty_ordered.IndexOf('.')));
                    y = Convert.ToInt32(item.qty_refunded.Remove(item.qty_refunded.IndexOf('.')));
                    z = Convert.ToInt32(item.qty_shipped.Remove(item.qty_shipped.IndexOf('.')));
                    int qty = x - y - z;
                    if (i < orderData.items.Length)
                    {
                        if (Convert.ToInt32(item.preparation_warehouse) == _preparationWarehouse[Properties.Settings.Default.WAREHOUSE])
                        {
                            if (qty > 0)
                            {
                                grid.Rows.Count = i + 2;
                                grid[i + 1, 0] = (i + 1).ToString();
                                grid[i + 1, 1] = item.name;
                                grid[i + 1, 2] = item.sku;
                                grid[i + 1, 3] = qty;
                                if (grid.Cols[4].Caption == "Qty packed") grid[i + 1, 4] = 0;
                                grid[i + 1, 5] = false;

                                if (item.name.ToString().Contains("Snus") || item.name.Contains("Dry")) snus++;
                                if (item.name.ToString().Contains("Snuff")) snuff++;
                                if (item.name.ToString().Contains("Tobacco Free")) tobfree++;

                                i++;

                            }
                        }
                    }
                }
            }
/*            if (snus > 0) _upsDescription = "Snus";
            else if (snuff > 0) _upsDescription = "Snuff";
            else if (tobfree > 0) _upsDescription = "Tobacco Free";*/
        }

        internal static bool AllItemsPacked(C1FlexGrid grid)
        {
            int check = 0;
            foreach (Row row in grid.Rows.Cast<Row>().Skip(1))
            {
                if (grid.GetCellCheck(row.Index, 5) == CheckEnum.Checked) check++;
            }
            if (grid.Rows.Count - 1 == check)
            {
                return true;
            }
            else return false;
        }

        internal static bool IsInternational(int warehouse, string country)
        {
            if ((warehouse == 0 || warehouse == 1) && _EUarray.Contains(country)) return false;
            else if (warehouse == 2 && country == "US") return false;
            else return true;
        }

        private static bool shipWithUPS(C1FlexGrid grid, bool UPSForDK)
        {
            if (grid.GetData(grid.RowSel, "shipping_description").ToString().Contains("UPS")) return true;
            else if (UPSForDK && Convert.ToInt16(grid.GetData(grid.RowSel, "shipping_description")) >= Convert.ToInt16(Properties.Settings.Default.UPS_UPGRADE_WEIGHT)) return true;
            else return false;
        }

        internal static void ShippingLabelPrint(C1FlexGrid grid, Dictionary<string, string> _countries, string address, bool UPSForDK, bool adult)
        {
            if (shipWithUPS(grid, UPSForDK))
                Program.convertUPS.Create_UPS_XML(grid.RowSel, grid.GetData(grid.RowSel, "shipping_description").ToString(), grid, _countries, ReqSign(adult));
            else
                Program.PrintService.PrintLabel(address, Math.Round(Convert.ToDecimal(grid.GetData(grid.RowSel, "base_grand_total")), 0).ToString(), Helper.IsInternational(Properties.Settings.Default.WAREHOUSE, grid.GetData(grid.RowSel, "country_id").ToString()));
        }

        private static string ReqSign(bool adult)
        {
            if (adult) return "Y";
            else return "N";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ERPPrintingApplication
{
    class Helper
    {
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
    }
}

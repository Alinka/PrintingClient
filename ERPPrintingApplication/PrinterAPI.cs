using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPPrintingApplication
{
    class PrinterAPI
    {
        private Properties.Settings _propSet;
        
        private PrintDocument _printInvoiceDoc;
        private PrintDocument _printLabelDoc;
        private int _posX = 10;
        private int _posY = 10;

        public PrinterAPI() 
        {
            _propSet = Properties.Settings.Default;
        }

        internal void PrintInvoice(string address, C1FlexGrid items, string orderID)
        {
            _printInvoiceDoc = new PrintDocument();
            PaperSize pS = new PaperSize("Invoice Size", _propSet.INVOICE_PRINTER_PAPER_WIDTH, _propSet.INVOICE_PRINTER_PAPER_HEIGHT);
            _printInvoiceDoc.DefaultPageSettings.PaperSize = pS;
            _printInvoiceDoc.PrinterSettings.PrinterName = _propSet.INVOICE_PRINTER;
            _printInvoiceDoc.PrinterSettings.DefaultPageSettings.PaperSize = pS;
            _printInvoiceDoc.PrintPage += (sender, e) => Invoice_PrintPage(e.Graphics, address, items, orderID);
            try
            {
                _printInvoiceDoc.Print();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            _printInvoiceDoc.Dispose();
        }
 
        internal void PrintLabel(string address, string value, /*string descUPS,*/ bool international)
        {
            Debug.WriteLine("PrinterApi: PrintLebel");
            string[] info = address.Split(new char[] { '\n' }, 2);
            
            _printLabelDoc = new PrintDocument();
            PaperSize pS = new PaperSize("Lable Size", _propSet.LABEL_PRINTER_PAPER_WIDTH, _propSet.LABEL_PRINTER_PAPER_HEIGHT);
            _printLabelDoc.DefaultPageSettings.PaperSize = pS;
            _printLabelDoc.PrinterSettings.PrinterName = _propSet.LABEL_PRINTER;
            _printLabelDoc.PrinterSettings.DefaultPageSettings.PaperSize = pS;
            _printLabelDoc.PrintPage += (sender, e) => Label_PrintPage(e.Graphics, info[0], info[1], value, /*descUPS,*/ international);
            try
            {
                _printLabelDoc.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            _printLabelDoc.Dispose();
        }

        private void Label_PrintPage(Graphics graphics, string name, string address, string value, /*string descUPS,*/ bool international)
        {
            
            Brush headerBrush = Brushes.DimGray;
            Font headerFont = new Font("Tahoma", 10);
            Brush bodyBrush = Brushes.Black;
            Font nameFont = new Font("Arial", 16);
            Font bodyFont = new Font("Arial", 14);
            Font tullFont = new Font("Tahoma", 8);
            int rowHeight = 22;
            
            graphics.DrawString("From: " + _propSet.RETURN_ADDRESS1, headerFont, headerBrush, new PointF(10, 10));
            graphics.DrawString("         " + _propSet.RETURN_ADDRESS2, headerFont, headerBrush, new PointF(10, 10 + rowHeight));
            if (_propSet.WAREHOUSE == 0) graphics.DrawImage(Properties.Resources.Porto, _propSet.LABEL_PRINTER_PAPER_WIDTH - 100, 20, 80, 111);
            graphics.DrawString(name, nameFont, bodyBrush, new PointF(10, rowHeight * 6));
            SizeF sf = graphics.MeasureString(address, bodyFont, _propSet.LABEL_PRINTER_PAPER_WIDTH - 60);
            graphics.DrawString(address, bodyFont, bodyBrush, new RectangleF(new PointF(10.0f, rowHeight * 7), sf), StringFormat.GenericTypographic);
            if (_propSet.WAREHOUSE == 2 && !international )
            {
                graphics.DrawImage(Properties.Resources.cn22, _propSet.LABEL_PRINTER_PAPER_WIDTH - 200, 14 * rowHeight, 180, 217);
                //graphics.DrawString(descUPS, headerFont, bodyBrush, _propSet.LABEL_PRINTER_PAPER_WIDTH - 190, 18 * rowHeight);
                graphics.DrawString("€" + value, headerFont, bodyBrush, _propSet.LABEL_PRINTER_PAPER_WIDTH - 55, 18 * rowHeight);
               
            
            }
            else if (_propSet.WAREHOUSE == 0 || (_propSet.WAREHOUSE == 1 && !international ))
            {
                graphics.DrawImage(Properties.Resources.tull, _propSet.LABEL_PRINTER_PAPER_WIDTH - 160, _posY + (11 * rowHeight), 140, 225);
                //graphics.DrawString(descUPS, headerFont, bodyBrush, _propSet.LABEL_PRINTER_PAPER_WIDTH - 150, 15 * rowHeight + 5);
                graphics.DrawString("€" + value, headerFont, bodyBrush, _propSet.LABEL_PRINTER_PAPER_WIDTH - 60, 15 * rowHeight + 5);
            }



            bodyFont.Dispose();
            headerFont.Dispose();

        }

        private void Invoice_PrintPage(Graphics graphics, string address, C1FlexGrid grid, string id)
        {
            Brush brush = Brushes.Black;
            
            Brush northBrush = Brushes.Red;
            Font northFont = new Font("Times New Roman", 16, FontStyle.Bold);
            StringFormat strCenterCol = new StringFormat();
            StringFormat strRight = new StringFormat();
            int rowHeight = 22;
            Rectangle shipStrip = new Rectangle(_posX, _posY + 10 + rowHeight * 4, _propSet.INVOICE_PRINTER_PAPER_WIDTH - _posY, rowHeight + 4);
            Rectangle itemsStrip = new Rectangle(_posX, _posY + 10 + rowHeight * 12, _propSet.INVOICE_PRINTER_PAPER_WIDTH - _posY, rowHeight + 4);
            

            StringFormat centerAling = new StringFormat();
            centerAling.Alignment = StringAlignment.Center;
            strCenterCol.LineAlignment = StringAlignment.Center;
            strRight.Alignment = StringAlignment.Far;
            using (Font font = new Font("Arial", 10), fontB = new Font("Arial", 12))
            {
            // Draw the text and the surrounding rectangle.
                graphics.DrawImage(Properties.Resources.logo_2x, 0, 0, 96, 96);
                graphics.DrawString("THE NORTHERNER", northFont, northBrush, Properties.Resources.logo_2x.Width/2.8f, Properties.Resources.logo_2x.Height / 8 + 10, StringFormat.GenericTypographic);
                graphics.DrawString(id, fontB, brush, _propSet.INVOICE_PRINTER_PAPER_WIDTH - 200, _posY + rowHeight);
                graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), font, brush, _propSet.INVOICE_PRINTER_PAPER_WIDTH - 200, _posY + rowHeight*2);
            

                graphics.FillRectangle(Brushes.Beige, shipStrip);
                graphics.DrawString("Shipping Address: ", fontB, brush, new PointF(_posX + 10, _posY + 15 + rowHeight * 4));
                graphics.DrawString(address, font, brush, new PointF(_posX + 10, _posY + rowHeight*6));
                graphics.FillRectangle(Brushes.Beige, itemsStrip);
                graphics.DrawString("Items included in this shippment: ", fontB, brush, new PointF(_posX + 10, _posY + 15 + rowHeight * 12));

                graphics.DrawString("Name", font, brush, _posX + 15, _posY + rowHeight * 14, StringFormat.GenericTypographic);
                graphics.DrawString("SKU", font, brush, _propSet.INVOICE_PRINTER_PAPER_WIDTH / 2 + 110, _posY + rowHeight * 14, StringFormat.GenericTypographic);
                graphics.DrawString("Qty", font, brush, _propSet.INVOICE_PRINTER_PAPER_WIDTH - 80, _posY + rowHeight * 14, StringFormat.GenericTypographic);
           

                for (int i = 1; i < grid.Rows.Count; i++)
                {
                
                    if (grid[i, 1] != null)
                    {
                        if (i % 2 != 0)
                        {
                            Rectangle tableRow = new Rectangle(_posX, _posY + rowHeight * (14 + i), _propSet.INVOICE_PRINTER_PAPER_WIDTH - _posY, rowHeight);
                            graphics.FillRectangle(Brushes.Azure, tableRow);
                        }

                        graphics.DrawString(grid[i, 1].ToString(), font, brush, _posX + 15, _posY + rowHeight * (14 + i) + 5, StringFormat.GenericTypographic);
                        graphics.DrawString(grid[i, 2].ToString(), font, brush, _propSet.INVOICE_PRINTER_PAPER_WIDTH / 2 + 110, _posY + rowHeight * (14 + i) + 5, StringFormat.GenericTypographic);
                        graphics.DrawString(grid[i, 3].ToString(), font, brush, _propSet.INVOICE_PRINTER_PAPER_WIDTH - 80, _posY + rowHeight * (14 + i) + 5, StringFormat.GenericTypographic);
                    }                           
                }
            }
        }

        internal void InvoicePrinterConfiguration(PrintDialog printInvoiceDialog)
        {
            _propSet.INVOICE_PRINTER = printInvoiceDialog.PrinterSettings.PrinterName;
            _propSet.INVOICE_PRINTER_DRAWER = printInvoiceDialog.PrinterSettings.DefaultPageSettings.PaperSource.SourceName;
            _propSet.INVOICE_PRINTER_PAPER_WIDTH = printInvoiceDialog.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            _propSet.INVOICE_PRINTER_PAPER_HEIGHT = printInvoiceDialog.PrinterSettings.DefaultPageSettings.PaperSize.Height;
            _propSet.Save();
        }

        internal void LabelPrinterConfiguration(PrintDialog printLabelDialog)
        {
            _propSet.LABEL_PRINTER = printLabelDialog.PrinterSettings.PrinterName;
            _propSet.LABEL_PRINTER_DRAWER = printLabelDialog.PrinterSettings.DefaultPageSettings.PaperSource.SourceName;
            _propSet.LABEL_PRINTER_PAPER_WIDTH = printLabelDialog.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            _propSet.LABEL_PRINTER_PAPER_HEIGHT = printLabelDialog.PrinterSettings.DefaultPageSettings.PaperSize.Height;
            _propSet.Save();
        }
    }
}

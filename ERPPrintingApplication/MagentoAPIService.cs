using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPPrintingApplication.MagentoSoapAPI;
using System.Diagnostics;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ERPPrintingApplication
{
    class MagentoAPIService
    {
        private MagentoService _mageService = new MagentoService();
        private string _sessionKey;

        public bool DoLogin(string username, string password)
        {
            try
            {
                _sessionKey = _mageService.login(username, password);
                Properties.Settings.Default.SessionKey = _sessionKey;
                Properties.Settings.Default.Save();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed: " + ex.Message);
                return false;
            }
        }

        public salesOrderPrintinfoEntity[] GetOrders(string warehouse)
        {        
            try
            {
                salesOrderPrintinfoEntity[] sopie = _mageService.salesOrderPrintinfo(_sessionKey, warehouse);
                return sopie;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retieving orders: " + ex.Message);
                return null;
            }
        }
        
        private filters magentoFilter(string filterField, string filterOperator, string filterValue)
        {
            filters mFilter = new filters();
            complexFilter cmplxFilter = new complexFilter();
            cmplxFilter.key = filterField;
            cmplxFilter.value = new associativeEntity { key = filterOperator, value = filterValue };

            mFilter.complex_filter = new complexFilter[] { cmplxFilter };

            return mFilter;
        }

        public salesOrderEntity RetrieveOrderInformation(string _orderID)
        {
            try
            {
                salesOrderEntity order = _mageService.salesOrderDetail(_sessionKey, _orderID);             
                return order;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retieving items for order #"+ _orderID+":\r\n\r\n" + ex.Message);
                return null;
            }
        }
    }
}

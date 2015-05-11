using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERPPrintingApplication.MagentoSoapAPI;
using System.Diagnostics;

namespace ERPPrintingApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != "")
            {
                c1TextBox_username.Text = Properties.Settings.Default.Username;
                c1TextBox_password.Focus();
            }

        }
                
        private void c1TextBox_username_TextChanged(object sender, EventArgs e)
        {
            if (c1TextBox_username.Text.Trim() == "" || c1TextBox_password.Text == "")
                c1Button_Login.Enabled = false;
            else
                c1Button_Login.Enabled = true;
        }

        private void c1TextBox_password_TextChanged(object sender, EventArgs e)
        {
            if (c1TextBox_username.Text.Trim() == "" || c1TextBox_password.Text == "")
                c1Button_Login.Enabled = false;
            else
                c1Button_Login.Enabled = true;
        }
       
        private void c1TextBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) c1Button_Login_Click(sender, e);
        }

        private void c1Button_Login_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = c1TextBox_username.Text.Trim();
            if (Program.MagentoService.DoLogin(c1TextBox_username.Text.Trim(), c1TextBox_password.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                c1TextBox_password.Text = "";
        }
    }
}

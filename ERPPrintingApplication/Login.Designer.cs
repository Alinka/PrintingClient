namespace ERPPrintingApplication
{
    partial class Login
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
            this.c1Button_Login = new C1.Win.C1Input.C1Button();
            this.c1TextBox_username = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox_password = new C1.Win.C1Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_password)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Button_Login
            // 
            this.c1Button_Login.Location = new System.Drawing.Point(112, 118);
            this.c1Button_Login.Name = "c1Button_Login";
            this.c1Button_Login.Size = new System.Drawing.Size(75, 23);
            this.c1Button_Login.TabIndex = 7;
            this.c1Button_Login.Text = "Log In";
            this.c1Button_Login.UseVisualStyleBackColor = true;
            this.c1Button_Login.Click += new System.EventHandler(this.c1Button_Login_Click);
            // 
            // c1TextBox_username
            // 
            this.c1TextBox_username.Location = new System.Drawing.Point(121, 24);
            this.c1TextBox_username.Name = "c1TextBox_username";
            this.c1TextBox_username.Size = new System.Drawing.Size(128, 18);
            this.c1TextBox_username.TabIndex = 8;
            this.c1TextBox_username.Tag = null;
            this.c1TextBox_username.TextDetached = true;
            this.c1TextBox_username.TextChanged += new System.EventHandler(this.c1TextBox_username_TextChanged);
            // 
            // c1TextBox_password
            // 
            this.c1TextBox_password.Location = new System.Drawing.Point(121, 60);
            this.c1TextBox_password.Name = "c1TextBox_password";
            this.c1TextBox_password.PasswordChar = '*';
            this.c1TextBox_password.Size = new System.Drawing.Size(128, 18);
            this.c1TextBox_password.TabIndex = 9;
            this.c1TextBox_password.Tag = null;
            this.c1TextBox_password.TextDetached = true;
            this.c1TextBox_password.TextChanged += new System.EventHandler(this.c1TextBox_password_TextChanged);
            this.c1TextBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TextBox_password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1TextBox_password);
            this.Controls.Add(this.c1TextBox_username);
            this.Controls.Add(this.c1Button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1Button c1Button_Login;
        private C1.Win.C1Input.C1TextBox c1TextBox_username;
        private C1.Win.C1Input.C1TextBox c1TextBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
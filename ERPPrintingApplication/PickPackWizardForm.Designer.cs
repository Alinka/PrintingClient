namespace ERPPrintingApplication
{
    partial class PickPackWizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickPackWizardForm));
            this.label_OrderNumber = new System.Windows.Forms.Label();
            this.c1SplitContainer_PickPackOrder = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel_OrderInfo = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1Button_PartialShipment = new C1.Win.C1Input.C1Button();
            this.c1Button_Next = new C1.Win.C1Input.C1Button();
            this.label_Address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1TextBox_BarcodeInput = new C1.Win.C1Input.C1TextBox();
            this.c1SplitterPanel_ItemsOrdered = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1FlexGrid_Items = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer_PickPackOrder)).BeginInit();
            this.c1SplitContainer_PickPackOrder.SuspendLayout();
            this.c1SplitterPanel_OrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_PartialShipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_BarcodeInput)).BeginInit();
            this.c1SplitterPanel_ItemsOrdered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // label_OrderNumber
            // 
            this.label_OrderNumber.AutoSize = true;
            this.label_OrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OrderNumber.Location = new System.Drawing.Point(15, 40);
            this.label_OrderNumber.Name = "label_OrderNumber";
            this.label_OrderNumber.Size = new System.Drawing.Size(57, 13);
            this.label_OrderNumber.TabIndex = 1;
            this.label_OrderNumber.Text = "Oreder #";
            // 
            // c1SplitContainer_PickPackOrder
            // 
            this.c1SplitContainer_PickPackOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer_PickPackOrder.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer_PickPackOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer_PickPackOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer_PickPackOrder.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer_PickPackOrder.Name = "c1SplitContainer_PickPackOrder";
            this.c1SplitContainer_PickPackOrder.Panels.Add(this.c1SplitterPanel_OrderInfo);
            this.c1SplitContainer_PickPackOrder.Panels.Add(this.c1SplitterPanel_ItemsOrdered);
            this.c1SplitContainer_PickPackOrder.Size = new System.Drawing.Size(1274, 611);
            this.c1SplitContainer_PickPackOrder.TabIndex = 2;
            // 
            // c1SplitterPanel_OrderInfo
            // 
            this.c1SplitterPanel_OrderInfo.Controls.Add(this.c1Button_PartialShipment);
            this.c1SplitterPanel_OrderInfo.Controls.Add(this.c1Button_Next);
            this.c1SplitterPanel_OrderInfo.Controls.Add(this.label_Address);
            this.c1SplitterPanel_OrderInfo.Controls.Add(this.label1);
            this.c1SplitterPanel_OrderInfo.Controls.Add(this.c1TextBox_BarcodeInput);
            this.c1SplitterPanel_OrderInfo.Controls.Add(this.label_OrderNumber);
            this.c1SplitterPanel_OrderInfo.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel_OrderInfo.Height = 611;
            this.c1SplitterPanel_OrderInfo.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel_OrderInfo.Name = "c1SplitterPanel_OrderInfo";
            this.c1SplitterPanel_OrderInfo.Resizable = false;
            this.c1SplitterPanel_OrderInfo.Size = new System.Drawing.Size(301, 590);
            this.c1SplitterPanel_OrderInfo.SizeRatio = 23.622D;
            this.c1SplitterPanel_OrderInfo.TabIndex = 0;
            this.c1SplitterPanel_OrderInfo.Text = "Shipping Details";
            this.c1SplitterPanel_OrderInfo.Width = 301;
            // 
            // c1Button_PartialShipment
            // 
            this.c1Button_PartialShipment.Location = new System.Drawing.Point(4, 564);
            this.c1Button_PartialShipment.Name = "c1Button_PartialShipment";
            this.c1Button_PartialShipment.Size = new System.Drawing.Size(105, 23);
            this.c1Button_PartialShipment.TabIndex = 6;
            this.c1Button_PartialShipment.Text = "Partial Shipment";
            this.c1Button_PartialShipment.UseVisualStyleBackColor = true;
            this.c1Button_PartialShipment.Click += new System.EventHandler(this.c1Button_PartialShipment_Click);
            // 
            // c1Button_Next
            // 
            this.c1Button_Next.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.c1Button_Next.Location = new System.Drawing.Point(221, 564);
            this.c1Button_Next.Name = "c1Button_Next";
            this.c1Button_Next.Size = new System.Drawing.Size(75, 23);
            this.c1Button_Next.TabIndex = 5;
            this.c1Button_Next.Text = "Next Order";
            this.c1Button_Next.UseVisualStyleBackColor = true;
            this.c1Button_Next.Click += new System.EventHandler(this.c1Button_Next_Click);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(15, 79);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(94, 13);
            this.label_Address.TabIndex = 4;
            this.label_Address.Text = "CustomersAddress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barcode:";
            // 
            // c1TextBox_BarcodeInput
            // 
            this.c1TextBox_BarcodeInput.AcceptsReturn = true;
            this.c1TextBox_BarcodeInput.EmptyAsNull = true;
            this.c1TextBox_BarcodeInput.Location = new System.Drawing.Point(70, 7);
            this.c1TextBox_BarcodeInput.Name = "c1TextBox_BarcodeInput";
            this.c1TextBox_BarcodeInput.ShowFocusRectangle = true;
            this.c1TextBox_BarcodeInput.Size = new System.Drawing.Size(200, 18);
            this.c1TextBox_BarcodeInput.TabIndex = 2;
            this.c1TextBox_BarcodeInput.Tag = null;
            this.c1TextBox_BarcodeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TextBox_BarcodeInput_KeyDown);
            // 
            // c1SplitterPanel_ItemsOrdered
            // 
            this.c1SplitterPanel_ItemsOrdered.Controls.Add(this.c1FlexGrid_Items);
            this.c1SplitterPanel_ItemsOrdered.Height = 611;
            this.c1SplitterPanel_ItemsOrdered.Location = new System.Drawing.Point(302, 21);
            this.c1SplitterPanel_ItemsOrdered.Name = "c1SplitterPanel_ItemsOrdered";
            this.c1SplitterPanel_ItemsOrdered.Size = new System.Drawing.Size(972, 590);
            this.c1SplitterPanel_ItemsOrdered.TabIndex = 1;
            this.c1SplitterPanel_ItemsOrdered.Text = "Items Ordered";
            // 
            // c1FlexGrid_Items
            // 
            this.c1FlexGrid_Items.ColumnInfo = resources.GetString("c1FlexGrid_Items.ColumnInfo");
            this.c1FlexGrid_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid_Items.ExtendLastCol = true;
            this.c1FlexGrid_Items.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid_Items.Name = "c1FlexGrid_Items";
            this.c1FlexGrid_Items.Rows.DefaultSize = 19;
            this.c1FlexGrid_Items.Size = new System.Drawing.Size(972, 590);
            this.c1FlexGrid_Items.TabIndex = 0;
            this.c1FlexGrid_Items.CellChecked += new C1.Win.C1FlexGrid.RowColEventHandler(this.c1FlexGrid_Items_CellChecked);
            // 
            // PickPackWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 611);
            this.Controls.Add(this.c1SplitContainer_PickPackOrder);
            this.Name = "PickPackWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickPackWizardForm";
            this.Load += new System.EventHandler(this.PickPackWizardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer_PickPackOrder)).EndInit();
            this.c1SplitContainer_PickPackOrder.ResumeLayout(false);
            this.c1SplitterPanel_OrderInfo.ResumeLayout(false);
            this.c1SplitterPanel_OrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_PartialShipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_BarcodeInput)).EndInit();
            this.c1SplitterPanel_ItemsOrdered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_OrderNumber;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer_PickPackOrder;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel_OrderInfo;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel_ItemsOrdered;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox c1TextBox_BarcodeInput;
        private System.Windows.Forms.Label label_Address;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid_Items;
        private C1.Win.C1Input.C1Button c1Button_Next;
        private C1.Win.C1Input.C1Button c1Button_PartialShipment;
    }
}
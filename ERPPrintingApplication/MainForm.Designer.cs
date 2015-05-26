namespace ERPPrintingApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.printInvoiceDialog = new System.Windows.Forms.PrintDialog();
            this.c1DockingTab_Main = new C1.Win.C1Command.C1DockingTab();
            this.c1Button_Refresh = new C1.Win.C1Input.C1Button();
            this.printLabelDialog = new System.Windows.Forms.PrintDialog();
            this.c1PrintPreviewDialog_Label = new C1.Win.C1Preview.C1PrintPreviewDialog();
            this.c1PrintPreviewDialog_Invoice = new C1.Win.C1Preview.C1PrintPreviewDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.c1StatusBar = new C1.Win.C1Ribbon.C1StatusBar();
            this.ribbonLabel_Progress = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonProgressBar = new C1.Win.C1Ribbon.RibbonProgressBar();
            this.folderBrowserDialog_UPS = new System.Windows.Forms.FolderBrowserDialog();
            this.c1DockingTabPage_PrepareOrders = new C1.Win.C1Command.C1DockingTabPage();
            this.c1SplitContainer = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel_OrderList = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1FlexGrid_ListOfOrders = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1SplitterPanel_OrderDetail = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1Button_Label_Print = new C1.Win.C1Input.C1Button();
            this.c1Button_Invoice_Print = new C1.Win.C1Input.C1Button();
            this.label_customerAddress = new System.Windows.Forms.Label();
            this.label_orderAddressDetail = new System.Windows.Forms.Label();
            this.label_orderNumberDetail = new System.Windows.Forms.Label();
            this.c1SplitterPanel_Items = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1FlexGrid_Items = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1DockingTabPage_Settings = new C1.Win.C1Command.C1DockingTabPage();
            this.c1CheckBox_AdultSign = new C1.Win.C1Input.C1CheckBox();
            this.c1NumericEdit_WieghtLimit = new C1.Win.C1Input.C1NumericEdit();
            this.c1CheckBox_EnableUPSForDK = new C1.Win.C1Input.C1CheckBox();
            this.c1Button_FolderBrowse = new C1.Win.C1Input.C1Button();
            this.label_UPSPathLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c1Button_SaveAddress = new C1.Win.C1Input.C1Button();
            this.label2 = new System.Windows.Forms.Label();
            this.c1TextBox_ReturnAddress2 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox_ReturnAddress1 = new C1.Win.C1Input.C1TextBox();
            this.label_ReturnAddress = new System.Windows.Forms.Label();
            this.c1Button_LabelPrinterConfig = new C1.Win.C1Input.C1Button();
            this.c1Button_InvoicePrinterConfig = new C1.Win.C1Input.C1Button();
            this.label_LabelPrinterPaper = new System.Windows.Forms.Label();
            this.label_LabelPrinterDrawer = new System.Windows.Forms.Label();
            this.label_LabelPrinterName = new System.Windows.Forms.Label();
            this.label_LabelPrintingSettings = new System.Windows.Forms.Label();
            this.label_InvoicePrinterPaper = new System.Windows.Forms.Label();
            this.label_PrinterPaperInvoice = new System.Windows.Forms.Label();
            this.label_InvoicePrinterDrawer = new System.Windows.Forms.Label();
            this.label_PrinterDrawerInvoice = new System.Windows.Forms.Label();
            this.label_InvoicePrinterName = new System.Windows.Forms.Label();
            this.label_PrinterNameInvoice = new System.Windows.Forms.Label();
            this.label_InvoicePrinterSettings = new System.Windows.Forms.Label();
            this.c1ComboBox_waredhouseID = new C1.Win.C1Input.C1ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salesOrderPrintinfoEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1Button_PickPack = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_Main)).BeginInit();
            this.c1DockingTab_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Label.PrintPreviewControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Label.PrintPreviewControl.PreviewPane)).BeginInit();
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.SuspendLayout();
            this.c1PrintPreviewDialog_Label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Invoice.PrintPreviewControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.PreviewPane)).BeginInit();
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.SuspendLayout();
            this.c1PrintPreviewDialog_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar)).BeginInit();
            this.c1DockingTabPage_PrepareOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer)).BeginInit();
            this.c1SplitContainer.SuspendLayout();
            this.c1SplitterPanel_OrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid_ListOfOrders)).BeginInit();
            this.c1SplitterPanel_OrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Label_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Invoice_Print)).BeginInit();
            this.c1SplitterPanel_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid_Items)).BeginInit();
            this.c1DockingTabPage_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox_AdultSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit_WieghtLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox_EnableUPSForDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_FolderBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_SaveAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_ReturnAddress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_ReturnAddress1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_LabelPrinterConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_InvoicePrinterConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox_waredhouseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderPrintinfoEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_PickPack)).BeginInit();
            this.SuspendLayout();
            // 
            // printInvoiceDialog
            // 
            this.printInvoiceDialog.UseEXDialog = true;
            // 
            // c1DockingTab_Main
            // 
            this.c1DockingTab_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.c1DockingTab_Main.Controls.Add(this.c1DockingTabPage_PrepareOrders);
            this.c1DockingTab_Main.Controls.Add(this.c1DockingTabPage_Settings);
            this.c1DockingTab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab_Main.Indent = 2;
            this.c1DockingTab_Main.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab_Main.Name = "c1DockingTab_Main";
            this.c1DockingTab_Main.Padding = new System.Drawing.Point(5, 5);
            this.c1DockingTab_Main.Size = new System.Drawing.Size(1463, 739);
            this.c1DockingTab_Main.TabIndex = 0;
            this.c1DockingTab_Main.TabLayout = C1.Win.C1Command.ButtonLayoutEnum.TextBelow;
            this.c1DockingTab_Main.TabsSpacing = 2;
            this.c1DockingTab_Main.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003;
            this.c1DockingTab_Main.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue;
            this.c1DockingTab_Main.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue;
            // 
            // c1Button_Refresh
            // 
            this.c1Button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Button_Refresh.Location = new System.Drawing.Point(1379, 10);
            this.c1Button_Refresh.Name = "c1Button_Refresh";
            this.c1Button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.c1Button_Refresh.TabIndex = 23;
            this.c1Button_Refresh.Text = "Refresh";
            this.c1Button_Refresh.UseVisualStyleBackColor = true;
            this.c1Button_Refresh.Click += new System.EventHandler(this.c1ComboBox_waredhouseID_SelectedItemChanged);
            // 
            // printLabelDialog
            // 
            this.printLabelDialog.UseEXDialog = true;
            // 
            // c1PrintPreviewDialog_Label
            // 
            this.c1PrintPreviewDialog_Label.ClientSize = new System.Drawing.Size(716, 543);
            this.c1PrintPreviewDialog_Label.Icon = ((System.Drawing.Icon)(resources.GetObject("c1PrintPreviewDialog_Label.Icon")));
            this.c1PrintPreviewDialog_Label.Name = "C1PrintPreviewDialog";
            // 
            // c1PrintPreviewDialog_Label.PrintPreviewControl
            // 
            // 
            // c1PrintPreviewDialog_Label.PrintPreviewControl.PreviewPane
            // 
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.GoFirst,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.GoPrev,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.LblPage,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.PageNo,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.LblOfPages,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.GoNext,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.GoLast,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.HistoryPrev,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.HistoryNext});
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Location = new System.Drawing.Point(292, 0);
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Name = "navigationStrip";
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Size = new System.Drawing.Size(264, 25);
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolStrip.TabIndex = 2;
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.SearchLabel,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.SearchText,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.SearchNext,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.SearchPrevious,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.MatchCase,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.MatchWholeWord,
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.CloseSearch});
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Name = "searchStrip";
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Size = new System.Drawing.Size(444, 25);
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.TabIndex = 6;
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Tag = "C1PreviewSearchToolStrip";
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ToolBars.Search.ToolStrip.Visible = false;
            this.c1PrintPreviewDialog_Label.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Auto;
            this.c1PrintPreviewDialog_Label.Text = "c1PrintPreviewDialog1";
            // 
            // c1PrintPreviewDialog_Invoice
            // 
            this.c1PrintPreviewDialog_Invoice.ClientSize = new System.Drawing.Size(716, 543);
            this.c1PrintPreviewDialog_Invoice.Icon = ((System.Drawing.Icon)(resources.GetObject("c1PrintPreviewDialog_Invoice.Icon")));
            this.c1PrintPreviewDialog_Invoice.Name = "C1PrintPreviewDialog";
            // 
            // c1PrintPreviewDialog_Invoice.PrintPreviewControl
            // 
            // 
            // c1PrintPreviewDialog_Invoice.PrintPreviewControl.PreviewPane
            // 
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.GoFirst,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.GoPrev,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.LblPage,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.PageNo,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.LblOfPages,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.GoNext,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.GoLast,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.HistoryPrev,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.HistoryNext});
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Location = new System.Drawing.Point(292, 0);
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Name = "navigationStrip";
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolStrip.Size = new System.Drawing.Size(264, 25);
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolStrip.TabIndex = 2;
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.SearchLabel,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.SearchText,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.SearchNext,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.SearchPrevious,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.MatchCase,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.MatchWholeWord,
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.CloseSearch});
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Name = "searchStrip";
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Size = new System.Drawing.Size(444, 25);
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.TabIndex = 6;
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Tag = "C1PreviewSearchToolStrip";
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ToolBars.Search.ToolStrip.Visible = false;
            this.c1PrintPreviewDialog_Invoice.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Auto;
            this.c1PrintPreviewDialog_Invoice.Text = "c1PrintPreviewDialog1";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // c1StatusBar
            // 
            this.c1StatusBar.LeftPaneItems.Add(this.ribbonLabel_Progress);
            this.c1StatusBar.LeftPaneItems.Add(this.ribbonProgressBar);
            this.c1StatusBar.Location = new System.Drawing.Point(0, 739);
            this.c1StatusBar.Margin = new System.Windows.Forms.Padding(10);
            this.c1StatusBar.Name = "c1StatusBar";
            this.c1StatusBar.Size = new System.Drawing.Size(1463, 22);
            // 
            // ribbonLabel_Progress
            // 
            this.ribbonLabel_Progress.Name = "ribbonLabel_Progress";
            this.ribbonLabel_Progress.Text = "Label";
            // 
            // ribbonProgressBar
            // 
            this.ribbonProgressBar.Height = 20;
            this.ribbonProgressBar.Name = "ribbonProgressBar";
            this.ribbonProgressBar.Width = 1000;
            // 
            // c1DockingTabPage_PrepareOrders
            // 
            this.c1DockingTabPage_PrepareOrders.Controls.Add(this.c1SplitContainer);
            this.c1DockingTabPage_PrepareOrders.Image = global::ERPPrintingApplication.Properties.Resources.Table;
            this.c1DockingTabPage_PrepareOrders.Location = new System.Drawing.Point(1, 81);
            this.c1DockingTabPage_PrepareOrders.Name = "c1DockingTabPage_PrepareOrders";
            this.c1DockingTabPage_PrepareOrders.Size = new System.Drawing.Size(1461, 657);
            this.c1DockingTabPage_PrepareOrders.TabIndex = 0;
            this.c1DockingTabPage_PrepareOrders.Text = "Preapare Orders";
            // 
            // c1SplitContainer
            // 
            this.c1SplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer.Name = "c1SplitContainer";
            this.c1SplitContainer.Panels.Add(this.c1SplitterPanel_OrderList);
            this.c1SplitContainer.Panels.Add(this.c1SplitterPanel_OrderDetail);
            this.c1SplitContainer.Panels.Add(this.c1SplitterPanel_Items);
            this.c1SplitContainer.Size = new System.Drawing.Size(1461, 657);
            this.c1SplitContainer.TabIndex = 1;
            // 
            // c1SplitterPanel_OrderList
            // 
            this.c1SplitterPanel_OrderList.Controls.Add(this.c1FlexGrid_ListOfOrders);
            this.c1SplitterPanel_OrderList.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel_OrderList.KeepRelativeSize = false;
            this.c1SplitterPanel_OrderList.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel_OrderList.Name = "c1SplitterPanel_OrderList";
            this.c1SplitterPanel_OrderList.Resizable = false;
            this.c1SplitterPanel_OrderList.Size = new System.Drawing.Size(1243, 636);
            this.c1SplitterPanel_OrderList.SizeRatio = 90D;
            this.c1SplitterPanel_OrderList.TabIndex = 0;
            this.c1SplitterPanel_OrderList.Text = "Order List";
            this.c1SplitterPanel_OrderList.Width = 1243;
            // 
            // c1FlexGrid_ListOfOrders
            // 
            this.c1FlexGrid_ListOfOrders.AllowFiltering = true;
            this.c1FlexGrid_ListOfOrders.ColumnInfo = "15,1,0,0,0,95,Columns:1{AllowSorting:False;AllowFiltering:None;AllowDragging:Fals" +
    "e;AllowResizing:False;AllowEditing:False;}\t";
            this.c1FlexGrid_ListOfOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid_ListOfOrders.ExtendLastCol = true;
            this.c1FlexGrid_ListOfOrders.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid_ListOfOrders.Name = "c1FlexGrid_ListOfOrders";
            this.c1FlexGrid_ListOfOrders.Rows.Count = 1;
            this.c1FlexGrid_ListOfOrders.Rows.DefaultSize = 19;
            this.c1FlexGrid_ListOfOrders.Size = new System.Drawing.Size(1243, 636);
            this.c1FlexGrid_ListOfOrders.TabIndex = 0;
            this.c1FlexGrid_ListOfOrders.Click += new System.EventHandler(this.c1FlexGrid_ListOfOrders_Click);
            // 
            // c1SplitterPanel_OrderDetail
            // 
            this.c1SplitterPanel_OrderDetail.Controls.Add(this.c1Button_Label_Print);
            this.c1SplitterPanel_OrderDetail.Controls.Add(this.c1Button_Invoice_Print);
            this.c1SplitterPanel_OrderDetail.Controls.Add(this.label_customerAddress);
            this.c1SplitterPanel_OrderDetail.Controls.Add(this.label_orderAddressDetail);
            this.c1SplitterPanel_OrderDetail.Controls.Add(this.label_orderNumberDetail);
            this.c1SplitterPanel_OrderDetail.Height = 203;
            this.c1SplitterPanel_OrderDetail.KeepRelativeSize = false;
            this.c1SplitterPanel_OrderDetail.Location = new System.Drawing.Point(1244, 21);
            this.c1SplitterPanel_OrderDetail.MinHeight = 10;
            this.c1SplitterPanel_OrderDetail.MinWidth = 20;
            this.c1SplitterPanel_OrderDetail.Name = "c1SplitterPanel_OrderDetail";
            this.c1SplitterPanel_OrderDetail.Resizable = false;
            this.c1SplitterPanel_OrderDetail.Size = new System.Drawing.Size(217, 182);
            this.c1SplitterPanel_OrderDetail.SizeRatio = 30D;
            this.c1SplitterPanel_OrderDetail.TabIndex = 1;
            this.c1SplitterPanel_OrderDetail.Text = "Order Detail";
            this.c1SplitterPanel_OrderDetail.Visible = false;
            this.c1SplitterPanel_OrderDetail.Width = 217;
            // 
            // c1Button_Label_Print
            // 
            this.c1Button_Label_Print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.c1Button_Label_Print.Location = new System.Drawing.Point(139, 30);
            this.c1Button_Label_Print.Name = "c1Button_Label_Print";
            this.c1Button_Label_Print.Size = new System.Drawing.Size(75, 23);
            this.c1Button_Label_Print.TabIndex = 3;
            this.c1Button_Label_Print.Text = "Print Label";
            this.c1Button_Label_Print.UseVisualStyleBackColor = true;
            this.c1Button_Label_Print.Click += new System.EventHandler(this.c1Button_Label_Print_Click);
            // 
            // c1Button_Invoice_Print
            // 
            this.c1Button_Invoice_Print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.c1Button_Invoice_Print.Location = new System.Drawing.Point(139, 3);
            this.c1Button_Invoice_Print.Name = "c1Button_Invoice_Print";
            this.c1Button_Invoice_Print.Size = new System.Drawing.Size(75, 23);
            this.c1Button_Invoice_Print.TabIndex = 1;
            this.c1Button_Invoice_Print.Text = "Print Invoice";
            this.c1Button_Invoice_Print.UseVisualStyleBackColor = true;
            this.c1Button_Invoice_Print.Click += new System.EventHandler(this.c1Button_Invoice_Print_Click);
            // 
            // label_customerAddress
            // 
            this.label_customerAddress.AutoSize = true;
            this.label_customerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerAddress.Location = new System.Drawing.Point(10, 35);
            this.label_customerAddress.Name = "label_customerAddress";
            this.label_customerAddress.Size = new System.Drawing.Size(136, 18);
            this.label_customerAddress.TabIndex = 2;
            this.label_customerAddress.Text = "Customer Address:";
            // 
            // label_orderAddressDetail
            // 
            this.label_orderAddressDetail.AutoSize = true;
            this.label_orderAddressDetail.Location = new System.Drawing.Point(15, 55);
            this.label_orderAddressDetail.Name = "label_orderAddressDetail";
            this.label_orderAddressDetail.Size = new System.Drawing.Size(66, 52);
            this.label_orderAddressDetail.TabIndex = 1;
            this.label_orderAddressDetail.Text = "Name Name\r\nStreet\r\nCity\r\nCountry";
            // 
            // label_orderNumberDetail
            // 
            this.label_orderNumberDetail.AutoSize = true;
            this.label_orderNumberDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderNumberDetail.Location = new System.Drawing.Point(10, 10);
            this.label_orderNumberDetail.Name = "label_orderNumberDetail";
            this.label_orderNumberDetail.Size = new System.Drawing.Size(69, 20);
            this.label_orderNumberDetail.TabIndex = 0;
            this.label_orderNumberDetail.Text = "Order #";
            // 
            // c1SplitterPanel_Items
            // 
            this.c1SplitterPanel_Items.Controls.Add(this.c1FlexGrid_Items);
            this.c1SplitterPanel_Items.Height = 453;
            this.c1SplitterPanel_Items.KeepRelativeSize = false;
            this.c1SplitterPanel_Items.Location = new System.Drawing.Point(1244, 225);
            this.c1SplitterPanel_Items.Name = "c1SplitterPanel_Items";
            this.c1SplitterPanel_Items.Resizable = false;
            this.c1SplitterPanel_Items.Size = new System.Drawing.Size(217, 432);
            this.c1SplitterPanel_Items.TabIndex = 2;
            this.c1SplitterPanel_Items.Text = "Items:";
            this.c1SplitterPanel_Items.Visible = false;
            // 
            // c1FlexGrid_Items
            // 
            this.c1FlexGrid_Items.ColumnInfo = resources.GetString("c1FlexGrid_Items.ColumnInfo");
            this.c1FlexGrid_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid_Items.ExtendLastCol = true;
            this.c1FlexGrid_Items.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid_Items.Name = "c1FlexGrid_Items";
            this.c1FlexGrid_Items.Rows.DefaultSize = 19;
            this.c1FlexGrid_Items.Size = new System.Drawing.Size(217, 432);
            this.c1FlexGrid_Items.TabIndex = 0;
            this.c1FlexGrid_Items.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1FlexGrid_Items_KeyDown);
            // 
            // c1DockingTabPage_Settings
            // 
            this.c1DockingTabPage_Settings.Controls.Add(this.c1CheckBox_AdultSign);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1NumericEdit_WieghtLimit);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1CheckBox_EnableUPSForDK);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1Button_FolderBrowse);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_UPSPathLabel);
            this.c1DockingTabPage_Settings.Controls.Add(this.label3);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1Button_SaveAddress);
            this.c1DockingTabPage_Settings.Controls.Add(this.label2);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1TextBox_ReturnAddress2);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1TextBox_ReturnAddress1);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_ReturnAddress);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1Button_LabelPrinterConfig);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1Button_InvoicePrinterConfig);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_LabelPrinterPaper);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_LabelPrinterDrawer);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_LabelPrinterName);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_LabelPrintingSettings);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_InvoicePrinterPaper);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_PrinterPaperInvoice);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_InvoicePrinterDrawer);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_PrinterDrawerInvoice);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_InvoicePrinterName);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_PrinterNameInvoice);
            this.c1DockingTabPage_Settings.Controls.Add(this.label_InvoicePrinterSettings);
            this.c1DockingTabPage_Settings.Controls.Add(this.c1ComboBox_waredhouseID);
            this.c1DockingTabPage_Settings.Controls.Add(this.label1);
            this.c1DockingTabPage_Settings.Image = global::ERPPrintingApplication.Properties.Resources.Settings;
            this.c1DockingTabPage_Settings.Location = new System.Drawing.Point(1, 81);
            this.c1DockingTabPage_Settings.Name = "c1DockingTabPage_Settings";
            this.c1DockingTabPage_Settings.Size = new System.Drawing.Size(1461, 657);
            this.c1DockingTabPage_Settings.TabIndex = 1;
            this.c1DockingTabPage_Settings.Text = "Settings";
            this.c1DockingTabPage_Settings.Enter += new System.EventHandler(this.c1DockingTabPage_Settings_Enter);
            // 
            // c1CheckBox_AdultSign
            // 
            this.c1CheckBox_AdultSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CheckBox_AdultSign.Location = new System.Drawing.Point(500, 35);
            this.c1CheckBox_AdultSign.Name = "c1CheckBox_AdultSign";
            this.c1CheckBox_AdultSign.Size = new System.Drawing.Size(148, 24);
            this.c1CheckBox_AdultSign.TabIndex = 30;
            this.c1CheckBox_AdultSign.Text = "Require Adult Signature";
            this.c1CheckBox_AdultSign.UseVisualStyleBackColor = true;
            this.c1CheckBox_AdultSign.Value = null;
            this.c1CheckBox_AdultSign.CheckStateChanged += new System.EventHandler(this.c1CheckBox_AdultSign_CheckStateChanged);
            // 
            // c1NumericEdit_WieghtLimit
            // 
            this.c1NumericEdit_WieghtLimit.Enabled = false;
            this.c1NumericEdit_WieghtLimit.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1NumericEdit_WieghtLimit.Location = new System.Drawing.Point(748, 10);
            this.c1NumericEdit_WieghtLimit.MaxLength = 5000;
            this.c1NumericEdit_WieghtLimit.Name = "c1NumericEdit_WieghtLimit";
            this.c1NumericEdit_WieghtLimit.Size = new System.Drawing.Size(72, 18);
            this.c1NumericEdit_WieghtLimit.TabIndex = 29;
            this.c1NumericEdit_WieghtLimit.Tag = null;
            this.c1NumericEdit_WieghtLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.c1NumericEdit_WieghtLimit.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.c1NumericEdit_WieghtLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1NumericEdit_WieghtLimit_KeyDown);
            // 
            // c1CheckBox_EnableUPSForDK
            // 
            this.c1CheckBox_EnableUPSForDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CheckBox_EnableUPSForDK.Location = new System.Drawing.Point(500, 10);
            this.c1CheckBox_EnableUPSForDK.Name = "c1CheckBox_EnableUPSForDK";
            this.c1CheckBox_EnableUPSForDK.Size = new System.Drawing.Size(253, 24);
            this.c1CheckBox_EnableUPSForDK.TabIndex = 28;
            this.c1CheckBox_EnableUPSForDK.Text = "Auto upgrade to UPS Standard (EU) at weight:";
            this.c1CheckBox_EnableUPSForDK.UseVisualStyleBackColor = true;
            this.c1CheckBox_EnableUPSForDK.Value = null;
            this.c1CheckBox_EnableUPSForDK.CheckStateChanged += new System.EventHandler(this.c1CheckBox_EnableUPSForDK_CheckStateChanged);
            // 
            // c1Button_FolderBrowse
            // 
            this.c1Button_FolderBrowse.Location = new System.Drawing.Point(314, 10);
            this.c1Button_FolderBrowse.Name = "c1Button_FolderBrowse";
            this.c1Button_FolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.c1Button_FolderBrowse.TabIndex = 27;
            this.c1Button_FolderBrowse.Text = "Browse";
            this.c1Button_FolderBrowse.UseVisualStyleBackColor = true;
            this.c1Button_FolderBrowse.Click += new System.EventHandler(this.c1Button_FolderBrowse_Click);
            // 
            // label_UPSPathLabel
            // 
            this.label_UPSPathLabel.AutoSize = true;
            this.label_UPSPathLabel.Location = new System.Drawing.Point(65, 15);
            this.label_UPSPathLabel.Name = "label_UPSPathLabel";
            this.label_UPSPathLabel.Size = new System.Drawing.Size(90, 13);
            this.label_UPSPathLabel.TabIndex = 26;
            this.label_UPSPathLabel.Text = "C://Path/to/UPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "UPS Path:";
            // 
            // c1Button_SaveAddress
            // 
            this.c1Button_SaveAddress.Location = new System.Drawing.Point(318, 90);
            this.c1Button_SaveAddress.Name = "c1Button_SaveAddress";
            this.c1Button_SaveAddress.Size = new System.Drawing.Size(71, 23);
            this.c1Button_SaveAddress.TabIndex = 22;
            this.c1Button_SaveAddress.Text = "Save";
            this.c1Button_SaveAddress.UseVisualStyleBackColor = true;
            this.c1Button_SaveAddress.Click += new System.EventHandler(this.c1Button_SaveAddress_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1350, 2);
            this.label2.TabIndex = 21;
            // 
            // c1TextBox_ReturnAddress2
            // 
            this.c1TextBox_ReturnAddress2.DisableOnNoData = false;
            this.c1TextBox_ReturnAddress2.Location = new System.Drawing.Point(9, 95);
            this.c1TextBox_ReturnAddress2.Name = "c1TextBox_ReturnAddress2";
            this.c1TextBox_ReturnAddress2.Size = new System.Drawing.Size(303, 18);
            this.c1TextBox_ReturnAddress2.TabIndex = 20;
            this.c1TextBox_ReturnAddress2.Tag = null;
            this.c1TextBox_ReturnAddress2.TextDetached = true;
            // 
            // c1TextBox_ReturnAddress1
            // 
            this.c1TextBox_ReturnAddress1.DisableOnNoData = false;
            this.c1TextBox_ReturnAddress1.Location = new System.Drawing.Point(114, 71);
            this.c1TextBox_ReturnAddress1.Name = "c1TextBox_ReturnAddress1";
            this.c1TextBox_ReturnAddress1.Size = new System.Drawing.Size(275, 18);
            this.c1TextBox_ReturnAddress1.TabIndex = 19;
            this.c1TextBox_ReturnAddress1.Tag = null;
            this.c1TextBox_ReturnAddress1.TextDetached = true;
            // 
            // label_ReturnAddress
            // 
            this.label_ReturnAddress.AutoSize = true;
            this.label_ReturnAddress.Location = new System.Drawing.Point(9, 75);
            this.label_ReturnAddress.Name = "label_ReturnAddress";
            this.label_ReturnAddress.Size = new System.Drawing.Size(83, 13);
            this.label_ReturnAddress.TabIndex = 18;
            this.label_ReturnAddress.Text = "Return Address:";
            // 
            // c1Button_LabelPrinterConfig
            // 
            this.c1Button_LabelPrinterConfig.Location = new System.Drawing.Point(447, 225);
            this.c1Button_LabelPrinterConfig.Name = "c1Button_LabelPrinterConfig";
            this.c1Button_LabelPrinterConfig.Size = new System.Drawing.Size(75, 23);
            this.c1Button_LabelPrinterConfig.TabIndex = 17;
            this.c1Button_LabelPrinterConfig.Text = "Configure";
            this.c1Button_LabelPrinterConfig.UseVisualStyleBackColor = true;
            this.c1Button_LabelPrinterConfig.Click += new System.EventHandler(this.c1Button_LabelPrinterConfig_Click);
            // 
            // c1Button_InvoicePrinterConfig
            // 
            this.c1Button_InvoicePrinterConfig.Location = new System.Drawing.Point(147, 225);
            this.c1Button_InvoicePrinterConfig.Name = "c1Button_InvoicePrinterConfig";
            this.c1Button_InvoicePrinterConfig.Size = new System.Drawing.Size(75, 23);
            this.c1Button_InvoicePrinterConfig.TabIndex = 16;
            this.c1Button_InvoicePrinterConfig.Text = "Configure";
            this.c1Button_InvoicePrinterConfig.UseVisualStyleBackColor = true;
            this.c1Button_InvoicePrinterConfig.Click += new System.EventHandler(this.c1Button_InvoicePrinterConfig_Click);
            // 
            // label_LabelPrinterPaper
            // 
            this.label_LabelPrinterPaper.AutoSize = true;
            this.label_LabelPrinterPaper.Location = new System.Drawing.Point(419, 197);
            this.label_LabelPrinterPaper.Name = "label_LabelPrinterPaper";
            this.label_LabelPrinterPaper.Size = new System.Drawing.Size(35, 13);
            this.label_LabelPrinterPaper.TabIndex = 15;
            this.label_LabelPrinterPaper.Text = "Paper";
            // 
            // label_LabelPrinterDrawer
            // 
            this.label_LabelPrinterDrawer.AutoSize = true;
            this.label_LabelPrinterDrawer.Location = new System.Drawing.Point(419, 177);
            this.label_LabelPrinterDrawer.Name = "label_LabelPrinterDrawer";
            this.label_LabelPrinterDrawer.Size = new System.Drawing.Size(41, 13);
            this.label_LabelPrinterDrawer.TabIndex = 13;
            this.label_LabelPrinterDrawer.Text = "Drawer";
            // 
            // label_LabelPrinterName
            // 
            this.label_LabelPrinterName.AutoSize = true;
            this.label_LabelPrinterName.Location = new System.Drawing.Point(419, 157);
            this.label_LabelPrinterName.Name = "label_LabelPrinterName";
            this.label_LabelPrinterName.Size = new System.Drawing.Size(35, 13);
            this.label_LabelPrinterName.TabIndex = 11;
            this.label_LabelPrinterName.Text = "Name";
            // 
            // label_LabelPrintingSettings
            // 
            this.label_LabelPrintingSettings.AutoSize = true;
            this.label_LabelPrintingSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LabelPrintingSettings.Location = new System.Drawing.Point(414, 137);
            this.label_LabelPrintingSettings.Name = "label_LabelPrintingSettings";
            this.label_LabelPrintingSettings.Size = new System.Drawing.Size(133, 13);
            this.label_LabelPrintingSettings.TabIndex = 9;
            this.label_LabelPrintingSettings.Text = "Label Printer Settings:";
            // 
            // label_InvoicePrinterPaper
            // 
            this.label_InvoicePrinterPaper.AutoSize = true;
            this.label_InvoicePrinterPaper.Location = new System.Drawing.Point(90, 197);
            this.label_InvoicePrinterPaper.Name = "label_InvoicePrinterPaper";
            this.label_InvoicePrinterPaper.Size = new System.Drawing.Size(35, 13);
            this.label_InvoicePrinterPaper.TabIndex = 8;
            this.label_InvoicePrinterPaper.Text = "Paper";
            // 
            // label_PrinterPaperInvoice
            // 
            this.label_PrinterPaperInvoice.AutoSize = true;
            this.label_PrinterPaperInvoice.Location = new System.Drawing.Point(10, 197);
            this.label_PrinterPaperInvoice.Name = "label_PrinterPaperInvoice";
            this.label_PrinterPaperInvoice.Size = new System.Drawing.Size(71, 13);
            this.label_PrinterPaperInvoice.TabIndex = 7;
            this.label_PrinterPaperInvoice.Text = "Printer Paper:";
            // 
            // label_InvoicePrinterDrawer
            // 
            this.label_InvoicePrinterDrawer.AutoSize = true;
            this.label_InvoicePrinterDrawer.Location = new System.Drawing.Point(90, 177);
            this.label_InvoicePrinterDrawer.Name = "label_InvoicePrinterDrawer";
            this.label_InvoicePrinterDrawer.Size = new System.Drawing.Size(41, 13);
            this.label_InvoicePrinterDrawer.TabIndex = 6;
            this.label_InvoicePrinterDrawer.Text = "Drawer";
            // 
            // label_PrinterDrawerInvoice
            // 
            this.label_PrinterDrawerInvoice.AutoSize = true;
            this.label_PrinterDrawerInvoice.Location = new System.Drawing.Point(10, 177);
            this.label_PrinterDrawerInvoice.Name = "label_PrinterDrawerInvoice";
            this.label_PrinterDrawerInvoice.Size = new System.Drawing.Size(77, 13);
            this.label_PrinterDrawerInvoice.TabIndex = 5;
            this.label_PrinterDrawerInvoice.Text = "Printer Drawer:";
            // 
            // label_InvoicePrinterName
            // 
            this.label_InvoicePrinterName.AutoSize = true;
            this.label_InvoicePrinterName.Location = new System.Drawing.Point(90, 157);
            this.label_InvoicePrinterName.Name = "label_InvoicePrinterName";
            this.label_InvoicePrinterName.Size = new System.Drawing.Size(35, 13);
            this.label_InvoicePrinterName.TabIndex = 4;
            this.label_InvoicePrinterName.Text = "Name";
            // 
            // label_PrinterNameInvoice
            // 
            this.label_PrinterNameInvoice.AutoSize = true;
            this.label_PrinterNameInvoice.Location = new System.Drawing.Point(10, 157);
            this.label_PrinterNameInvoice.Name = "label_PrinterNameInvoice";
            this.label_PrinterNameInvoice.Size = new System.Drawing.Size(71, 13);
            this.label_PrinterNameInvoice.TabIndex = 3;
            this.label_PrinterNameInvoice.Text = "Printer Name:";
            // 
            // label_InvoicePrinterSettings
            // 
            this.label_InvoicePrinterSettings.AutoSize = true;
            this.label_InvoicePrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvoicePrinterSettings.Location = new System.Drawing.Point(144, 137);
            this.label_InvoicePrinterSettings.Name = "label_InvoicePrinterSettings";
            this.label_InvoicePrinterSettings.Size = new System.Drawing.Size(144, 13);
            this.label_InvoicePrinterSettings.TabIndex = 2;
            this.label_InvoicePrinterSettings.Text = "Invoice Printer Settings:";
            // 
            // c1ComboBox_waredhouseID
            // 
            this.c1ComboBox_waredhouseID.AllowSpinLoop = false;
            this.c1ComboBox_waredhouseID.GapHeight = 0;
            this.c1ComboBox_waredhouseID.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox_waredhouseID.Items.Add("Sweden");
            this.c1ComboBox_waredhouseID.Items.Add("Denmark");
            this.c1ComboBox_waredhouseID.Items.Add("USA");
            this.c1ComboBox_waredhouseID.ItemsDisplayMember = "";
            this.c1ComboBox_waredhouseID.ItemsValueMember = "";
            this.c1ComboBox_waredhouseID.Location = new System.Drawing.Point(114, 42);
            this.c1ComboBox_waredhouseID.Name = "c1ComboBox_waredhouseID";
            this.c1ComboBox_waredhouseID.Size = new System.Drawing.Size(275, 18);
            this.c1ComboBox_waredhouseID.TabIndex = 1;
            this.c1ComboBox_waredhouseID.Tag = null;
            this.c1ComboBox_waredhouseID.SelectedIndexChanged += new System.EventHandler(this.c1ComboBox_waredhouseID_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Warehouse:";
            // 
            // salesOrderPrintinfoEntityBindingSource
            // 
            this.salesOrderPrintinfoEntityBindingSource.DataSource = typeof(ERPPrintingApplication.MagentoSoapAPI.salesOrderPrintinfoEntity);
            // 
            // c1Button_PickPack
            // 
            this.c1Button_PickPack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Button_PickPack.Location = new System.Drawing.Point(1379, 39);
            this.c1Button_PickPack.Name = "c1Button_PickPack";
            this.c1Button_PickPack.Size = new System.Drawing.Size(75, 23);
            this.c1Button_PickPack.TabIndex = 25;
            this.c1Button_PickPack.Text = "Pick&&Pack";
            this.c1Button_PickPack.UseVisualStyleBackColor = true;
            this.c1Button_PickPack.Click += new System.EventHandler(this.c1Button_PickPack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 761);
            this.Controls.Add(this.c1Button_PickPack);
            this.Controls.Add(this.c1Button_Refresh);
            this.Controls.Add(this.c1DockingTab_Main);
            this.Controls.Add(this.c1StatusBar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printing Application";
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_Main)).EndInit();
            this.c1DockingTab_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Label.PrintPreviewControl.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Label.PrintPreviewControl)).EndInit();
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.ResumeLayout(false);
            this.c1PrintPreviewDialog_Label.PrintPreviewControl.PerformLayout();
            this.c1PrintPreviewDialog_Label.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewDialog_Invoice.PrintPreviewControl)).EndInit();
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.ResumeLayout(false);
            this.c1PrintPreviewDialog_Invoice.PrintPreviewControl.PerformLayout();
            this.c1PrintPreviewDialog_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar)).EndInit();
            this.c1DockingTabPage_PrepareOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer)).EndInit();
            this.c1SplitContainer.ResumeLayout(false);
            this.c1SplitterPanel_OrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid_ListOfOrders)).EndInit();
            this.c1SplitterPanel_OrderDetail.ResumeLayout(false);
            this.c1SplitterPanel_OrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Label_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_Invoice_Print)).EndInit();
            this.c1SplitterPanel_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid_Items)).EndInit();
            this.c1DockingTabPage_Settings.ResumeLayout(false);
            this.c1DockingTabPage_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox_AdultSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit_WieghtLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CheckBox_EnableUPSForDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_FolderBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_SaveAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_ReturnAddress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox_ReturnAddress1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_LabelPrinterConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_InvoicePrinterConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox_waredhouseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderPrintinfoEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button_PickPack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printInvoiceDialog;
        private System.Windows.Forms.BindingSource salesOrderPrintinfoEntityBindingSource;
        private C1.Win.C1Command.C1DockingTab c1DockingTab_Main;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage_PrepareOrders;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid_ListOfOrders;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage_Settings;
        private C1.Win.C1Input.C1ComboBox c1ComboBox_waredhouseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_InvoicePrinterName;
        private System.Windows.Forms.Label label_PrinterNameInvoice;
        private System.Windows.Forms.Label label_InvoicePrinterSettings;
        private System.Windows.Forms.Label label_InvoicePrinterDrawer;
        private System.Windows.Forms.Label label_PrinterDrawerInvoice;
        private System.Windows.Forms.Label label_InvoicePrinterPaper;
        private System.Windows.Forms.Label label_PrinterPaperInvoice;
        private System.Windows.Forms.Label label_LabelPrinterPaper;
        private System.Windows.Forms.Label label_LabelPrinterDrawer;
        private System.Windows.Forms.Label label_LabelPrinterName;
        private System.Windows.Forms.Label label_LabelPrintingSettings;
        private C1.Win.C1Input.C1Button c1Button_InvoicePrinterConfig;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel_OrderList;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel_OrderDetail;
        private System.Windows.Forms.Label label_orderNumberDetail;
        private System.Windows.Forms.Label label_orderAddressDetail;
        private System.Windows.Forms.Label label_customerAddress;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel_Items;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid_Items;
        private C1.Win.C1Input.C1Button c1Button_LabelPrinterConfig;
        private C1.Win.C1Input.C1Button c1Button_Label_Print;
        private C1.Win.C1Input.C1Button c1Button_Invoice_Print;
        private System.Windows.Forms.PrintDialog printLabelDialog;
        private C1.Win.C1Preview.C1PrintPreviewDialog c1PrintPreviewDialog_Label;
        private C1.Win.C1Preview.C1PrintPreviewDialog c1PrintPreviewDialog_Invoice;
        private C1.Win.C1Input.C1TextBox c1TextBox_ReturnAddress1;
        private System.Windows.Forms.Label label_ReturnAddress;
        private C1.Win.C1Input.C1TextBox c1TextBox_ReturnAddress2;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1Button c1Button_SaveAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private C1.Win.C1Input.C1Button c1Button_Refresh;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel_Progress;
        private C1.Win.C1Ribbon.RibbonProgressBar ribbonProgressBar;
        private System.Windows.Forms.Label label_UPSPathLabel;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Input.C1Button c1Button_FolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_UPS;
        private C1.Win.C1Input.C1CheckBox c1CheckBox_EnableUPSForDK;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit_WieghtLimit;
        private C1.Win.C1Input.C1CheckBox c1CheckBox_AdultSign;
        private C1.Win.C1Input.C1Button c1Button_PickPack;


    }
}


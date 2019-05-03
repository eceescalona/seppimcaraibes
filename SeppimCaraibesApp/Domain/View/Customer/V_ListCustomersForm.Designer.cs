namespace SeppimCaraibesApp.Domain.View.Customer
{
    partial class V_ListCustomersForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.listCustomersRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.listCustomersPC = new DevExpress.XtraEditors.PanelControl();
            this.listCustomersGC = new DevExpress.XtraGrid.GridControl();
            this.customersEIFS = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.customersGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersPC)).BeginInit();
            this.listCustomersPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // listCustomersRC
            // 
            this.listCustomersRC.ExpandCollapseItem.Id = 0;
            this.listCustomersRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.listCustomersRC.ExpandCollapseItem,
            this.registerBBI,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.listCustomersRC.Location = new System.Drawing.Point(0, 0);
            this.listCustomersRC.MaxItemId = 5;
            this.listCustomersRC.Name = "listCustomersRC";
            this.listCustomersRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.listCustomersRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.listCustomersRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.listCustomersRC.ShowToolbarCustomizeItem = false;
            this.listCustomersRC.Size = new System.Drawing.Size(800, 95);
            this.listCustomersRC.Toolbar.ShowCustomizeItem = false;
            this.listCustomersRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.listCustomersRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // registerBBI
            // 
            this.registerBBI.Caption = "Registrar";
            this.registerBBI.Id = 1;
            this.registerBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.New_32x32;
            this.registerBBI.Name = "registerBBI";
            this.registerBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RegisterBBI_ItemClick);
            // 
            // findBBI
            // 
            this.findBBI.Caption = "Buscar";
            this.findBBI.Id = 2;
            this.findBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.Find_32x32;
            this.findBBI.Name = "findBBI";
            this.findBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FindBBI_ItemClick);
            // 
            // filterBBI
            // 
            this.filterBBI.Caption = "Filtrar";
            this.filterBBI.Id = 3;
            this.filterBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.Filter_32x32;
            this.filterBBI.Name = "filterBBI";
            this.filterBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FilterBBI_ItemClick);
            // 
            // refreshBBI
            // 
            this.refreshBBI.Caption = "Refrescar";
            this.refreshBBI.Id = 4;
            this.refreshBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.Refresh_32x32;
            this.refreshBBI.Name = "refreshBBI";
            this.refreshBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBBI_ItemClick);
            // 
            // actionsRP
            // 
            this.actionsRP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.actionsRPG});
            this.actionsRP.Name = "actionsRP";
            // 
            // actionsRPG
            // 
            this.actionsRPG.AllowTextClipping = false;
            this.actionsRPG.ItemLinks.Add(this.registerBBI);
            this.actionsRPG.ItemLinks.Add(this.findBBI);
            this.actionsRPG.ItemLinks.Add(this.filterBBI);
            this.actionsRPG.ItemLinks.Add(this.refreshBBI);
            this.actionsRPG.Name = "actionsRPG";
            this.actionsRPG.ShowCaptionButton = false;
            // 
            // listCustomersPC
            // 
            this.listCustomersPC.Controls.Add(this.listCustomersGC);
            this.listCustomersPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCustomersPC.Location = new System.Drawing.Point(0, 95);
            this.listCustomersPC.Name = "listCustomersPC";
            this.listCustomersPC.Size = new System.Drawing.Size(800, 355);
            this.listCustomersPC.TabIndex = 1;
            // 
            // listCustomersGC
            // 
            this.listCustomersGC.DataSource = this.customersEIFS;
            this.listCustomersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCustomersGC.Location = new System.Drawing.Point(2, 2);
            this.listCustomersGC.MainView = this.customersGV;
            this.listCustomersGC.MenuManager = this.listCustomersRC;
            this.listCustomersGC.Name = "listCustomersGC";
            this.listCustomersGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE});
            this.listCustomersGC.Size = new System.Drawing.Size(796, 351);
            this.listCustomersGC.TabIndex = 0;
            this.listCustomersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customersGV});
            // 
            // customersEIFS
            // 
            this.customersEIFS.AreSourceRowsThreadSafe = true;
            this.customersEIFS.DefaultSorting = "Name ASC";
            this.customersEIFS.DesignTimeElementType = typeof(SeppimCaraibesApp.Data.ORM.CustomersView);
            this.customersEIFS.KeyExpression = "Code";
            // 
            // customersGV
            // 
            this.customersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colActions});
            this.customersGV.GridControl = this.listCustomersGC;
            this.customersGV.Name = "customersGV";
            this.customersGV.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.CustomersGV_RowStyle);
            // 
            // colCode
            // 
            this.colCode.Caption = "Código";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 129;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre Completo";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 129;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Teléfono";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            this.colPhone.Width = 129;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Correo Electrónico";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 134;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Dirección";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 207;
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 5;
            this.colActions.Width = 50;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions3.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions4.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Edit Customer", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "Delete Customer", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // V_ListCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCustomersPC);
            this.Controls.Add(this.listCustomersRC);
            this.Name = "V_ListCustomersForm";
            this.Text = "V_ListCustomersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListCustomersForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersPC)).EndInit();
            this.listCustomersPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl listCustomersRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraBars.BarButtonItem registerBBI;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraEditors.PanelControl listCustomersPC;
        private DevExpress.XtraGrid.GridControl listCustomersGC;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource customersEIFS;
        private DevExpress.XtraGrid.Views.Grid.GridView customersGV;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
    }
}
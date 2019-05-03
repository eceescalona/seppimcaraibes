namespace SeppimCaraibesApp.Domain.View.Provider
{
    partial class V_ListProvidersForm
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
            this.listProvidersRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.listProvidersPC = new DevExpress.XtraEditors.PanelControl();
            this.listProvidersGC = new DevExpress.XtraGrid.GridControl();
            this.providersEIFS = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.providersGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProvider_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listProvidersRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProvidersPC)).BeginInit();
            this.listProvidersPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProvidersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // listProvidersRC
            // 
            this.listProvidersRC.ExpandCollapseItem.Id = 0;
            this.listProvidersRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.listProvidersRC.ExpandCollapseItem,
            this.registerBBI,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.listProvidersRC.Location = new System.Drawing.Point(0, 0);
            this.listProvidersRC.MaxItemId = 5;
            this.listProvidersRC.Name = "listProvidersRC";
            this.listProvidersRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.listProvidersRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.listProvidersRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.listProvidersRC.ShowToolbarCustomizeItem = false;
            this.listProvidersRC.Size = new System.Drawing.Size(800, 95);
            this.listProvidersRC.Toolbar.ShowCustomizeItem = false;
            this.listProvidersRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.listProvidersRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
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
            // listProvidersPC
            // 
            this.listProvidersPC.Controls.Add(this.listProvidersGC);
            this.listProvidersPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProvidersPC.Location = new System.Drawing.Point(0, 95);
            this.listProvidersPC.Name = "listProvidersPC";
            this.listProvidersPC.Size = new System.Drawing.Size(800, 355);
            this.listProvidersPC.TabIndex = 1;
            // 
            // listProvidersGC
            // 
            this.listProvidersGC.DataSource = this.providersEIFS;
            this.listProvidersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProvidersGC.Location = new System.Drawing.Point(2, 2);
            this.listProvidersGC.MainView = this.providersGV;
            this.listProvidersGC.MenuManager = this.listProvidersRC;
            this.listProvidersGC.Name = "listProvidersGC";
            this.listProvidersGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE});
            this.listProvidersGC.Size = new System.Drawing.Size(796, 351);
            this.listProvidersGC.TabIndex = 0;
            this.listProvidersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.providersGV});
            // 
            // providersEIFS
            // 
            this.providersEIFS.AreSourceRowsThreadSafe = true;
            this.providersEIFS.DefaultSorting = "Provider_Name ASC";
            this.providersEIFS.DesignTimeElementType = typeof(SeppimCaraibesApp.Data.ORM.ProvidersView);
            this.providersEIFS.KeyExpression = "Provider_Code";
            // 
            // providersGV
            // 
            this.providersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProvider_Code,
            this.colProvider_Name,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colProduct_Code,
            this.colProduct_Name,
            this.colActions});
            this.providersGV.GridControl = this.listProvidersGC;
            this.providersGV.GroupCount = 1;
            this.providersGV.Name = "providersGV";
            this.providersGV.OptionsBehavior.AutoExpandAllGroups = true;
            this.providersGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProvider_Code, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.providersGV.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ProvidersGV_RowStyle);
            // 
            // colProvider_Code
            // 
            this.colProvider_Code.Caption = "Código";
            this.colProvider_Code.FieldName = "Provider_Code";
            this.colProvider_Code.Name = "colProvider_Code";
            this.colProvider_Code.Visible = true;
            this.colProvider_Code.VisibleIndex = 0;
            this.colProvider_Code.Width = 91;
            // 
            // colProvider_Name
            // 
            this.colProvider_Name.Caption = "Nombre Completo";
            this.colProvider_Name.FieldName = "Provider_Name";
            this.colProvider_Name.Name = "colProvider_Name";
            this.colProvider_Name.Visible = true;
            this.colProvider_Name.VisibleIndex = 0;
            this.colProvider_Name.Width = 101;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Teléfono";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 1;
            this.colPhone.Width = 89;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Correo Electrónico";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 97;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Dirección";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            this.colAddress.Width = 97;
            // 
            // colProduct_Code
            // 
            this.colProduct_Code.Caption = "Código del Producto";
            this.colProduct_Code.FieldName = "Product_Code";
            this.colProduct_Code.Name = "colProduct_Code";
            this.colProduct_Code.Visible = true;
            this.colProduct_Code.VisibleIndex = 4;
            this.colProduct_Code.Width = 121;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Nombre del Producto";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 5;
            this.colProduct_Name.Width = 120;
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 6;
            this.colActions.Width = 62;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions3.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions4.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Editar Proveedor", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "Eliminar Proveedor", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // V_ListProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listProvidersPC);
            this.Controls.Add(this.listProvidersRC);
            this.Name = "V_ListProvidersForm";
            this.Text = "V_ListProvidersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListProvidersForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListProvidersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProvidersRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProvidersPC)).EndInit();
            this.listProvidersPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listProvidersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl listProvidersRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraBars.BarButtonItem registerBBI;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraEditors.PanelControl listProvidersPC;
        private DevExpress.XtraGrid.GridControl listProvidersGC;
        private DevExpress.XtraGrid.Views.Grid.GridView providersGV;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource providersEIFS;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
    }
}
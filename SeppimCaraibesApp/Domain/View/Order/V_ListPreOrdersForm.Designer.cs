namespace SeppimCaraibesApp.Domain.View.Order
{
    partial class V_ListPreOrdersForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.listPreOrdersRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.listPreOrdersPC = new DevExpress.XtraEditors.PanelControl();
            this.listPreOrdersGC = new DevExpress.XtraGrid.GridControl();
            this.preOrdersGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.preOrdersEIFS = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.colOrder_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Reference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listPreOrdersRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPreOrdersPC)).BeginInit();
            this.listPreOrdersPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPreOrdersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // listPreOrdersRC
            // 
            this.listPreOrdersRC.ExpandCollapseItem.Id = 0;
            this.listPreOrdersRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.listPreOrdersRC.ExpandCollapseItem,
            this.registerBBI,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.listPreOrdersRC.Location = new System.Drawing.Point(0, 0);
            this.listPreOrdersRC.MaxItemId = 5;
            this.listPreOrdersRC.Name = "listPreOrdersRC";
            this.listPreOrdersRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.listPreOrdersRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.listPreOrdersRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.listPreOrdersRC.ShowToolbarCustomizeItem = false;
            this.listPreOrdersRC.Size = new System.Drawing.Size(800, 95);
            this.listPreOrdersRC.Toolbar.ShowCustomizeItem = false;
            this.listPreOrdersRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.listPreOrdersRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // actionsRP
            // 
            this.actionsRP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.actionsRPG});
            this.actionsRP.Name = "actionsRP";
            // 
            // actionsRPG
            // 
            this.actionsRPG.ItemLinks.Add(this.registerBBI);
            this.actionsRPG.ItemLinks.Add(this.findBBI);
            this.actionsRPG.ItemLinks.Add(this.filterBBI);
            this.actionsRPG.ItemLinks.Add(this.refreshBBI);
            this.actionsRPG.Name = "actionsRPG";
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
            // listPreOrdersPC
            // 
            this.listPreOrdersPC.Controls.Add(this.listPreOrdersGC);
            this.listPreOrdersPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPreOrdersPC.Location = new System.Drawing.Point(0, 95);
            this.listPreOrdersPC.Name = "listPreOrdersPC";
            this.listPreOrdersPC.Size = new System.Drawing.Size(800, 355);
            this.listPreOrdersPC.TabIndex = 1;
            // 
            // listPreOrdersGC
            // 
            this.listPreOrdersGC.DataSource = this.preOrdersEIFS;
            this.listPreOrdersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPreOrdersGC.Location = new System.Drawing.Point(2, 2);
            this.listPreOrdersGC.MainView = this.preOrdersGV;
            this.listPreOrdersGC.MenuManager = this.listPreOrdersRC;
            this.listPreOrdersGC.Name = "listPreOrdersGC";
            this.listPreOrdersGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE});
            this.listPreOrdersGC.Size = new System.Drawing.Size(796, 351);
            this.listPreOrdersGC.TabIndex = 0;
            this.listPreOrdersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.preOrdersGV});
            // 
            // preOrdersGV
            // 
            this.preOrdersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrder_Code,
            this.colDate,
            this.colCustomer_Reference,
            this.colCustomer_Code,
            this.colCustomer_Name,
            this.colProduct_Code,
            this.colProduct_Name,
            this.colProduct_Qty,
            this.colActions});
            this.preOrdersGV.GridControl = this.listPreOrdersGC;
            this.preOrdersGV.GroupCount = 1;
            this.preOrdersGV.Name = "preOrdersGV";
            this.preOrdersGV.OptionsBehavior.AutoExpandAllGroups = true;
            this.preOrdersGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // preOrdersEIFS
            // 
            this.preOrdersEIFS.AreSourceRowsThreadSafe = true;
            this.preOrdersEIFS.DefaultSorting = "Date DESC";
            this.preOrdersEIFS.DesignTimeElementType = typeof(SeppimCaraibesApp.Data.ORM.PreOrdersView);
            this.preOrdersEIFS.KeyExpression = "Order_Code";
            // 
            // colOrder_Code
            // 
            this.colOrder_Code.Caption = "Código de Orden";
            this.colOrder_Code.FieldName = "Order_Code";
            this.colOrder_Code.Name = "colOrder_Code";
            this.colOrder_Code.Visible = true;
            this.colOrder_Code.VisibleIndex = 0;
            this.colOrder_Code.Width = 96;
            // 
            // colDate
            // 
            this.colDate.Caption = "Fecha";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 96;
            // 
            // colCustomer_Reference
            // 
            this.colCustomer_Reference.Caption = "Referencia del Cliente";
            this.colCustomer_Reference.FieldName = "Customer_Reference";
            this.colCustomer_Reference.Name = "colCustomer_Reference";
            this.colCustomer_Reference.Visible = true;
            this.colCustomer_Reference.VisibleIndex = 2;
            this.colCustomer_Reference.Width = 120;
            // 
            // colCustomer_Code
            // 
            this.colCustomer_Code.Caption = "Código del Cliente";
            this.colCustomer_Code.FieldName = "Customer_Code";
            this.colCustomer_Code.Name = "colCustomer_Code";
            this.colCustomer_Code.Visible = true;
            this.colCustomer_Code.VisibleIndex = 3;
            this.colCustomer_Code.Width = 108;
            // 
            // colCustomer_Name
            // 
            this.colCustomer_Name.Caption = "Nombre del Cliente";
            this.colCustomer_Name.FieldName = "Customer_Name";
            this.colCustomer_Name.Name = "colCustomer_Name";
            this.colCustomer_Name.Visible = true;
            this.colCustomer_Name.VisibleIndex = 4;
            this.colCustomer_Name.Width = 86;
            // 
            // colProduct_Code
            // 
            this.colProduct_Code.Caption = "Código del Producto";
            this.colProduct_Code.FieldName = "Product_Code";
            this.colProduct_Code.Name = "colProduct_Code";
            this.colProduct_Code.Visible = true;
            this.colProduct_Code.VisibleIndex = 4;
            this.colProduct_Code.Width = 118;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Nombre del Producto";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 5;
            this.colProduct_Name.Width = 115;
            // 
            // colProduct_Qty
            // 
            this.colProduct_Qty.Caption = "Cantidad";
            this.colProduct_Qty.FieldName = "Product_Qty";
            this.colProduct_Qty.Name = "colProduct_Qty";
            this.colProduct_Qty.Visible = true;
            this.colProduct_Qty.VisibleIndex = 6;
            this.colProduct_Qty.Width = 72;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions1.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions2.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar Pre-Orden", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Eliminar Pre-Orden", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 7;
            this.colActions.Width = 53;
            // 
            // V_ListPreOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPreOrdersPC);
            this.Controls.Add(this.listPreOrdersRC);
            this.Name = "V_ListPreOrdersForm";
            this.Text = "V_ListPreOrdersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListPreOrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListPreOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPreOrdersRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPreOrdersPC)).EndInit();
            this.listPreOrdersPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listPreOrdersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl listPreOrdersRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraBars.BarButtonItem registerBBI;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraEditors.PanelControl listPreOrdersPC;
        private DevExpress.XtraGrid.GridControl listPreOrdersGC;
        private DevExpress.XtraGrid.Views.Grid.GridView preOrdersGV;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource preOrdersEIFS;
        private DevExpress.XtraGrid.Columns.GridColumn colOrder_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Reference;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Qty;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
    }
}
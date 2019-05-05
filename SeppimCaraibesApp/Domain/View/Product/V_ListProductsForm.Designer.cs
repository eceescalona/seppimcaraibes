namespace SeppimCaraibesApp.Domain.View.Product
{
    partial class V_ListProductsForm
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
            this.listProductsRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.listProductsPC = new DevExpress.XtraEditors.PanelControl();
            this.listProductsGC = new DevExpress.XtraGrid.GridControl();
            this.productsEIFS = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.productsGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustoms_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty_Units = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcronyms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsPC)).BeginInit();
            this.listProductsPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // listProductsRC
            // 
            this.listProductsRC.ExpandCollapseItem.Id = 0;
            this.listProductsRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.listProductsRC.ExpandCollapseItem,
            this.registerBBI,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.listProductsRC.Location = new System.Drawing.Point(0, 0);
            this.listProductsRC.MaxItemId = 5;
            this.listProductsRC.Name = "listProductsRC";
            this.listProductsRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.listProductsRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.listProductsRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.listProductsRC.ShowQatLocationSelector = false;
            this.listProductsRC.Size = new System.Drawing.Size(800, 95);
            this.listProductsRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.listProductsRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
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
            this.actionsRP.Text = "ribbonPage1";
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
            // listProductsPC
            // 
            this.listProductsPC.Controls.Add(this.listProductsGC);
            this.listProductsPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProductsPC.Location = new System.Drawing.Point(0, 95);
            this.listProductsPC.Name = "listProductsPC";
            this.listProductsPC.Size = new System.Drawing.Size(800, 355);
            this.listProductsPC.TabIndex = 1;
            // 
            // listProductsGC
            // 
            this.listProductsGC.DataSource = this.productsEIFS;
            this.listProductsGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProductsGC.Location = new System.Drawing.Point(2, 2);
            this.listProductsGC.MainView = this.productsGV;
            this.listProductsGC.MenuManager = this.listProductsRC;
            this.listProductsGC.Name = "listProductsGC";
            this.listProductsGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE});
            this.listProductsGC.Size = new System.Drawing.Size(796, 351);
            this.listProductsGC.TabIndex = 0;
            this.listProductsGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productsGV});
            // 
            // productsEIFS
            // 
            this.productsEIFS.AreSourceRowsThreadSafe = true;
            this.productsEIFS.DefaultSorting = "Product_Name ASC";
            this.productsEIFS.DesignTimeElementType = typeof(SeppimCaraibesApp.Data.ORM.ProductsView);
            this.productsEIFS.KeyExpression = "Product_Code";
            // 
            // productsGV
            // 
            this.productsGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_Code,
            this.colProduct_Name,
            this.colProduct_Description,
            this.colCustoms_Code,
            this.colUnit_Price,
            this.colQty_Units,
            this.colQty_Price,
            this.colSale_Price,
            this.colOrigin,
            this.colAcronyms,
            this.colProvider_Code,
            this.colProvider_Name,
            this.colActions});
            this.productsGV.GridControl = this.listProductsGC;
            this.productsGV.GroupCount = 1;
            this.productsGV.Name = "productsGV";
            this.productsGV.OptionsBehavior.AutoExpandAllGroups = true;
            this.productsGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_Code, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.productsGV.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ProductsGV_RowStyle);
            // 
            // colProduct_Code
            // 
            this.colProduct_Code.Caption = "Código";
            this.colProduct_Code.FieldName = "Product_Code";
            this.colProduct_Code.Name = "colProduct_Code";
            this.colProduct_Code.Visible = true;
            this.colProduct_Code.VisibleIndex = 0;
            this.colProduct_Code.Width = 59;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Nombre";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 0;
            this.colProduct_Name.Width = 58;
            // 
            // colProduct_Description
            // 
            this.colProduct_Description.Caption = "Descripción";
            this.colProduct_Description.FieldName = "Product_Description";
            this.colProduct_Description.Name = "colProduct_Description";
            this.colProduct_Description.Visible = true;
            this.colProduct_Description.VisibleIndex = 1;
            this.colProduct_Description.Width = 65;
            // 
            // colCustoms_Code
            // 
            this.colCustoms_Code.Caption = "Código de Aduana";
            this.colCustoms_Code.FieldName = "Customs_Code";
            this.colCustoms_Code.Name = "colCustoms_Code";
            this.colCustoms_Code.Visible = true;
            this.colCustoms_Code.VisibleIndex = 2;
            // 
            // colUnit_Price
            // 
            this.colUnit_Price.Caption = "Precio por Unidad";
            this.colUnit_Price.FieldName = "Unit_Price";
            this.colUnit_Price.Name = "colUnit_Price";
            this.colUnit_Price.Visible = true;
            this.colUnit_Price.VisibleIndex = 3;
            this.colUnit_Price.Width = 73;
            // 
            // colQty_Units
            // 
            this.colQty_Units.Caption = "Cantidad de Unidades";
            this.colQty_Units.FieldName = "Qty_Units";
            this.colQty_Units.Name = "colQty_Units";
            this.colQty_Units.Visible = true;
            this.colQty_Units.VisibleIndex = 4;
            this.colQty_Units.Width = 80;
            // 
            // colQty_Price
            // 
            this.colQty_Price.Caption = "Precio por Cantidad";
            this.colQty_Price.FieldName = "Qty_Price";
            this.colQty_Price.Name = "colQty_Price";
            this.colQty_Price.Visible = true;
            this.colQty_Price.VisibleIndex = 5;
            this.colQty_Price.Width = 69;
            // 
            // colSale_Price
            // 
            this.colSale_Price.Caption = "Precio de Venta";
            this.colSale_Price.FieldName = "Sale_Price";
            this.colSale_Price.Name = "colSale_Price";
            this.colSale_Price.Visible = true;
            this.colSale_Price.VisibleIndex = 6;
            this.colSale_Price.Width = 67;
            // 
            // colOrigin
            // 
            this.colOrigin.Caption = "Orígen";
            this.colOrigin.FieldName = "Origin";
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.Visible = true;
            this.colOrigin.VisibleIndex = 7;
            this.colOrigin.Width = 41;
            // 
            // colAcronyms
            // 
            this.colAcronyms.Caption = "País";
            this.colAcronyms.FieldName = "Acronyms";
            this.colAcronyms.Name = "colAcronyms";
            this.colAcronyms.Visible = true;
            this.colAcronyms.VisibleIndex = 8;
            this.colAcronyms.Width = 43;
            // 
            // colProvider_Code
            // 
            this.colProvider_Code.Caption = "Código del Proveedor";
            this.colProvider_Code.FieldName = "Provider_Code";
            this.colProvider_Code.Name = "colProvider_Code";
            this.colProvider_Code.Visible = true;
            this.colProvider_Code.VisibleIndex = 9;
            this.colProvider_Code.Width = 72;
            // 
            // colProvider_Name
            // 
            this.colProvider_Name.Caption = "Nombre del Proveedor";
            this.colProvider_Name.FieldName = "Provider_Name";
            this.colProvider_Name.Name = "colProvider_Name";
            this.colProvider_Name.Visible = true;
            this.colProvider_Name.VisibleIndex = 10;
            this.colProvider_Name.Width = 74;
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 11;
            this.colActions.Width = 61;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions1.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions2.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar Producto", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Eliminar Producto", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // V_ListProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listProductsPC);
            this.Controls.Add(this.listProductsRC);
            this.Name = "V_ListProductsForm";
            this.Text = "V_ListProductsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListProductsForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listProductsRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsPC)).EndInit();
            this.listProductsPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listProductsGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl listProductsRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraBars.BarButtonItem registerBBI;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraEditors.PanelControl listProductsPC;
        private DevExpress.XtraGrid.GridControl listProductsGC;
        private DevExpress.XtraGrid.Views.Grid.GridView productsGV;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource productsEIFS;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colCustoms_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colQty_Units;
        private DevExpress.XtraGrid.Columns.GridColumn colQty_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigin;
        private DevExpress.XtraGrid.Columns.GridColumn colAcronyms;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
    }
}
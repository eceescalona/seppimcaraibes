namespace SeppimCaraibesApp.Domain.View.Order
{
    partial class V_ListOrdersForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.listOrdersRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.listOrdersRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.listOrdersRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.listOrderPC = new DevExpress.XtraEditors.PanelControl();
            this.ordersGC = new DevExpress.XtraGrid.GridControl();
            this.ordersBS = new System.Windows.Forms.BindingSource(this.components);
            this.ordersGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrder_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider_Reference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Reference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment_Option = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipping_Method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDevise = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncoterm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContract_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocuments_Required = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listOrdersRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOrderPC)).BeginInit();
            this.listOrderPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // listOrdersRC
            // 
            this.listOrdersRC.ExpandCollapseItem.Id = 0;
            this.listOrdersRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.listOrdersRC.ExpandCollapseItem,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.listOrdersRC.Location = new System.Drawing.Point(0, 0);
            this.listOrdersRC.MaxItemId = 4;
            this.listOrdersRC.Name = "listOrdersRC";
            this.listOrdersRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.listOrdersRP});
            this.listOrdersRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.listOrdersRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.listOrdersRC.ShowToolbarCustomizeItem = false;
            this.listOrdersRC.Size = new System.Drawing.Size(1802, 95);
            this.listOrdersRC.Toolbar.ShowCustomizeItem = false;
            this.listOrdersRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.listOrdersRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // findBBI
            // 
            this.findBBI.Caption = "Buscar";
            this.findBBI.Id = 1;
            this.findBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.Find_32x32;
            this.findBBI.Name = "findBBI";
            this.findBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FindBBI_ItemClick);
            // 
            // filterBBI
            // 
            this.filterBBI.Caption = "Filtrar";
            this.filterBBI.Id = 2;
            this.filterBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.Filter_32x32;
            this.filterBBI.Name = "filterBBI";
            this.filterBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FilterBBI_ItemClick);
            // 
            // refreshBBI
            // 
            this.refreshBBI.Caption = "Refrescar";
            this.refreshBBI.Id = 3;
            this.refreshBBI.ImageOptions.LargeImage = global::SeppimCaraibesApp.Properties.Resources.Refresh_32x32;
            this.refreshBBI.Name = "refreshBBI";
            this.refreshBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBBI_ItemClick);
            // 
            // listOrdersRP
            // 
            this.listOrdersRP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.listOrdersRPG});
            this.listOrdersRP.Name = "listOrdersRP";
            // 
            // listOrdersRPG
            // 
            this.listOrdersRPG.AllowTextClipping = false;
            this.listOrdersRPG.ItemLinks.Add(this.findBBI);
            this.listOrdersRPG.ItemLinks.Add(this.filterBBI);
            this.listOrdersRPG.ItemLinks.Add(this.refreshBBI);
            this.listOrdersRPG.Name = "listOrdersRPG";
            this.listOrdersRPG.ShowCaptionButton = false;
            // 
            // listOrderPC
            // 
            this.listOrderPC.Controls.Add(this.ordersGC);
            this.listOrderPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOrderPC.Location = new System.Drawing.Point(0, 95);
            this.listOrderPC.Name = "listOrderPC";
            this.listOrderPC.Size = new System.Drawing.Size(1802, 355);
            this.listOrderPC.TabIndex = 1;
            // 
            // ordersGC
            // 
            this.ordersGC.DataSource = this.ordersBS;
            this.ordersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGC.Location = new System.Drawing.Point(2, 2);
            this.ordersGC.MainView = this.ordersGV;
            this.ordersGC.MenuManager = this.listOrdersRC;
            this.ordersGC.Name = "ordersGC";
            this.ordersGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE});
            this.ordersGC.Size = new System.Drawing.Size(1798, 351);
            this.ordersGC.TabIndex = 0;
            this.ordersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ordersGV});
            // 
            // ordersBS
            // 
            this.ordersBS.DataSource = typeof(SeppimCaraibesApp.Data.ORM.OrdersView);
            // 
            // ordersGV
            // 
            this.ordersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrder_Code,
            this.colDate,
            this.colProvider_Reference,
            this.colProvider_Name,
            this.colProvider_Phone,
            this.colCustomer_Reference,
            this.colCustomer_Name,
            this.colCustomer_Phone,
            this.colCustomer_Address,
            this.colPayment_Option,
            this.colShipping_Method,
            this.colDevise,
            this.colIncoterm,
            this.colProduct_Code,
            this.colProduct_Name,
            this.colProduct_Qty,
            this.colUnit_Price,
            this.colProduct_Discount,
            this.colTotal_Cost,
            this.colContract_Description,
            this.colDocuments_Required,
            this.colActions});
            this.ordersGV.GridControl = this.ordersGC;
            this.ordersGV.Name = "ordersGV";
            // 
            // colOrder_Code
            // 
            this.colOrder_Code.Caption = "Código";
            this.colOrder_Code.FieldName = "Order_Code";
            this.colOrder_Code.Name = "colOrder_Code";
            this.colOrder_Code.Visible = true;
            this.colOrder_Code.VisibleIndex = 0;
            this.colOrder_Code.Width = 80;
            // 
            // colDate
            // 
            this.colDate.Caption = "Fecha";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 80;
            // 
            // colProvider_Reference
            // 
            this.colProvider_Reference.Caption = "Referencia del Proveedor";
            this.colProvider_Reference.FieldName = "Provider_Reference";
            this.colProvider_Reference.Name = "colProvider_Reference";
            this.colProvider_Reference.Visible = true;
            this.colProvider_Reference.VisibleIndex = 2;
            this.colProvider_Reference.Width = 114;
            // 
            // colProvider_Name
            // 
            this.colProvider_Name.Caption = "Nombre del Proveedor";
            this.colProvider_Name.FieldName = "Provider_Name";
            this.colProvider_Name.Name = "colProvider_Name";
            this.colProvider_Name.Visible = true;
            this.colProvider_Name.VisibleIndex = 3;
            this.colProvider_Name.Width = 109;
            // 
            // colProvider_Phone
            // 
            this.colProvider_Phone.Caption = "Teléfono del Proveedor";
            this.colProvider_Phone.FieldName = "Provider_Phone";
            this.colProvider_Phone.Name = "colProvider_Phone";
            this.colProvider_Phone.Visible = true;
            this.colProvider_Phone.VisibleIndex = 4;
            this.colProvider_Phone.Width = 91;
            // 
            // colCustomer_Reference
            // 
            this.colCustomer_Reference.Caption = "Referencia del Cliente";
            this.colCustomer_Reference.FieldName = "Customer_Reference";
            this.colCustomer_Reference.Name = "colCustomer_Reference";
            this.colCustomer_Reference.Visible = true;
            this.colCustomer_Reference.VisibleIndex = 5;
            this.colCustomer_Reference.Width = 99;
            // 
            // colCustomer_Name
            // 
            this.colCustomer_Name.Caption = "Nombre del Cliente";
            this.colCustomer_Name.FieldName = "Customer_Name";
            this.colCustomer_Name.Name = "colCustomer_Name";
            this.colCustomer_Name.Visible = true;
            this.colCustomer_Name.VisibleIndex = 6;
            this.colCustomer_Name.Width = 86;
            // 
            // colCustomer_Phone
            // 
            this.colCustomer_Phone.Caption = "Teléfono del Cliente";
            this.colCustomer_Phone.FieldName = "Customer_Phone";
            this.colCustomer_Phone.Name = "colCustomer_Phone";
            this.colCustomer_Phone.Visible = true;
            this.colCustomer_Phone.VisibleIndex = 7;
            this.colCustomer_Phone.Width = 91;
            // 
            // colCustomer_Address
            // 
            this.colCustomer_Address.Caption = "Dirección del Cliente";
            this.colCustomer_Address.FieldName = "Customer_Address";
            this.colCustomer_Address.Name = "colCustomer_Address";
            this.colCustomer_Address.Visible = true;
            this.colCustomer_Address.VisibleIndex = 8;
            this.colCustomer_Address.Width = 95;
            // 
            // colPayment_Option
            // 
            this.colPayment_Option.Caption = "Forma de Pago";
            this.colPayment_Option.FieldName = "Payment_Option";
            this.colPayment_Option.Name = "colPayment_Option";
            this.colPayment_Option.Visible = true;
            this.colPayment_Option.VisibleIndex = 9;
            this.colPayment_Option.Width = 86;
            // 
            // colShipping_Method
            // 
            this.colShipping_Method.Caption = "Método de Envío";
            this.colShipping_Method.FieldName = "Shipping_Method";
            this.colShipping_Method.Name = "colShipping_Method";
            this.colShipping_Method.Visible = true;
            this.colShipping_Method.VisibleIndex = 10;
            this.colShipping_Method.Width = 89;
            // 
            // colDevise
            // 
            this.colDevise.Caption = "Divisa";
            this.colDevise.FieldName = "Devise";
            this.colDevise.Name = "colDevise";
            this.colDevise.Visible = true;
            this.colDevise.VisibleIndex = 11;
            this.colDevise.Width = 61;
            // 
            // colIncoterm
            // 
            this.colIncoterm.Caption = "Incoterm";
            this.colIncoterm.FieldName = "Incoterm";
            this.colIncoterm.Name = "colIncoterm";
            this.colIncoterm.Visible = true;
            this.colIncoterm.VisibleIndex = 12;
            this.colIncoterm.Width = 61;
            // 
            // colProduct_Code
            // 
            this.colProduct_Code.Caption = "Código del Producto";
            this.colProduct_Code.FieldName = "Product_Code";
            this.colProduct_Code.Name = "colProduct_Code";
            this.colProduct_Code.Visible = true;
            this.colProduct_Code.VisibleIndex = 13;
            this.colProduct_Code.Width = 77;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Nombre del Producto";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 14;
            this.colProduct_Name.Width = 84;
            // 
            // colProduct_Qty
            // 
            this.colProduct_Qty.Caption = "Cantidad";
            this.colProduct_Qty.FieldName = "Product_Qty";
            this.colProduct_Qty.Name = "colProduct_Qty";
            this.colProduct_Qty.Visible = true;
            this.colProduct_Qty.VisibleIndex = 15;
            this.colProduct_Qty.Width = 56;
            // 
            // colUnit_Price
            // 
            this.colUnit_Price.Caption = "Precio Unitario";
            this.colUnit_Price.FieldName = "Unit_Price";
            this.colUnit_Price.Name = "colUnit_Price";
            this.colUnit_Price.Visible = true;
            this.colUnit_Price.VisibleIndex = 16;
            this.colUnit_Price.Width = 62;
            // 
            // colProduct_Discount
            // 
            this.colProduct_Discount.Caption = "Descuento";
            this.colProduct_Discount.FieldName = "Product_Discount";
            this.colProduct_Discount.Name = "colProduct_Discount";
            this.colProduct_Discount.Visible = true;
            this.colProduct_Discount.VisibleIndex = 17;
            this.colProduct_Discount.Width = 70;
            // 
            // colTotal_Cost
            // 
            this.colTotal_Cost.Caption = "Costo Total";
            this.colTotal_Cost.FieldName = "Total_Cost";
            this.colTotal_Cost.Name = "colTotal_Cost";
            this.colTotal_Cost.Visible = true;
            this.colTotal_Cost.VisibleIndex = 18;
            this.colTotal_Cost.Width = 78;
            // 
            // colContract_Description
            // 
            this.colContract_Description.Caption = "Descripción del Contrato";
            this.colContract_Description.FieldName = "Contract_Description";
            this.colContract_Description.Name = "colContract_Description";
            this.colContract_Description.Visible = true;
            this.colContract_Description.VisibleIndex = 19;
            this.colContract_Description.Width = 94;
            // 
            // colDocuments_Required
            // 
            this.colDocuments_Required.Caption = "Documentos Requeridos";
            this.colDocuments_Required.FieldName = "Documents_Required";
            this.colDocuments_Required.Name = "colDocuments_Required";
            this.colDocuments_Required.Visible = true;
            this.colDocuments_Required.VisibleIndex = 20;
            this.colDocuments_Required.Width = 66;
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 21;
            this.colActions.Width = 51;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions1.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions2.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            editorButtonImageOptions3.Image = global::SeppimCaraibesApp.Properties.Resources.Convert_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Eliminar", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Convertir a Factura", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // V_ListOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 450);
            this.Controls.Add(this.listOrderPC);
            this.Controls.Add(this.listOrdersRC);
            this.Name = "V_ListOrdersForm";
            this.Text = "V_ListOrdersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListOrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOrdersRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOrderPC)).EndInit();
            this.listOrderPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl listOrdersRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage listOrdersRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup listOrdersRPG;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraEditors.PanelControl listOrderPC;
        private DevExpress.XtraGrid.GridControl ordersGC;
        private System.Windows.Forms.BindingSource ordersBS;
        private DevExpress.XtraGrid.Views.Grid.GridView ordersGV;
        private DevExpress.XtraGrid.Columns.GridColumn colOrder_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Reference;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Reference;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Address;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment_Option;
        private DevExpress.XtraGrid.Columns.GridColumn colShipping_Method;
        private DevExpress.XtraGrid.Columns.GridColumn colDevise;
        private DevExpress.XtraGrid.Columns.GridColumn colIncoterm;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Qty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Discount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Cost;
        private DevExpress.XtraGrid.Columns.GridColumn colContract_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colDocuments_Required;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
    }
}
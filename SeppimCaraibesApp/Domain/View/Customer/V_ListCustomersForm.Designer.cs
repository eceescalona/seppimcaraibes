﻿namespace SeppimCaraibesApp.Domain.View.Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ListCustomersForm));
            this.listCustomersRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.closeBBI = new DevExpress.XtraBars.BarButtonItem();
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.refreshBBI,
            this.closeBBI,
            this.listCustomersRC.SearchEditItem});
            this.listCustomersRC.Location = new System.Drawing.Point(0, 0);
            this.listCustomersRC.MaxItemId = 8;
            this.listCustomersRC.Name = "listCustomersRC";
            this.listCustomersRC.PageHeaderItemLinks.Add(this.closeBBI);
            this.listCustomersRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.listCustomersRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.listCustomersRC.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.listCustomersRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.listCustomersRC.ShowToolbarCustomizeItem = false;
            this.listCustomersRC.Size = new System.Drawing.Size(800, 116);
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
            // closeBBI
            // 
            this.closeBBI.Caption = "Cerrar";
            this.closeBBI.Id = 5;
            this.closeBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Close_16x16;
            this.closeBBI.Name = "closeBBI";
            this.closeBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBBI_ItemClick);
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
            this.listCustomersPC.Location = new System.Drawing.Point(0, 116);
            this.listCustomersPC.Name = "listCustomersPC";
            this.listCustomersPC.Size = new System.Drawing.Size(800, 334);
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
            this.listCustomersGC.Size = new System.Drawing.Size(796, 330);
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
            editorButtonImageOptions1.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions2.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Edit Customer", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Delete Customer", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Listar Clientes";
            // 
            // V_ListCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listCustomersPC);
            this.Controls.Add(this.listCustomersRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private DevExpress.XtraGrid.Views.Grid.GridView customersGV;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource customersEIFS;
        private DevExpress.XtraBars.BarButtonItem closeBBI;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
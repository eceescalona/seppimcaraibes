namespace SeppimCaraibesApp.Domain.View.Role
{
    partial class V_ListRolesForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.roleRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.closeBBI = new DevExpress.XtraBars.BarButtonItem();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rolePC = new DevExpress.XtraEditors.PanelControl();
            this.roleGC = new DevExpress.XtraGrid.GridControl();
            this.roleEIFS = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.roleGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermissionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.roleRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePC)).BeginInit();
            this.rolePC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // roleRC
            // 
            this.roleRC.ExpandCollapseItem.Id = 0;
            this.roleRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.roleRC.ExpandCollapseItem,
            this.closeBBI,
            this.registerBBI,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.roleRC.Location = new System.Drawing.Point(0, 0);
            this.roleRC.MaxItemId = 6;
            this.roleRC.Name = "roleRC";
            this.roleRC.PageHeaderItemLinks.Add(this.closeBBI);
            this.roleRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.roleRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.roleRC.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.roleRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.roleRC.ShowQatLocationSelector = false;
            this.roleRC.Size = new System.Drawing.Size(800, 116);
            this.roleRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.roleRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // closeBBI
            // 
            this.closeBBI.Caption = "Cerrar";
            this.closeBBI.Id = 1;
            this.closeBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Close_16x16;
            this.closeBBI.Name = "closeBBI";
            this.closeBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBBI_ItemClick);
            // 
            // registerBBI
            // 
            this.registerBBI.Caption = "Registrar";
            this.registerBBI.Id = 2;
            this.registerBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.New_32x32;
            this.registerBBI.Name = "registerBBI";
            this.registerBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // findBBI
            // 
            this.findBBI.Caption = "Buscar";
            this.findBBI.Id = 3;
            this.findBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Find_32x32;
            this.findBBI.Name = "findBBI";
            this.findBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.findBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FindBBI_ItemClick);
            // 
            // filterBBI
            // 
            this.filterBBI.Caption = "Filtrar";
            this.filterBBI.Id = 4;
            this.filterBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Filter_32x32;
            this.filterBBI.Name = "filterBBI";
            this.filterBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.filterBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FilterBBI_ItemClick);
            // 
            // refreshBBI
            // 
            this.refreshBBI.Caption = "Refrescar";
            this.refreshBBI.Id = 5;
            this.refreshBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Refresh_32x32;
            this.refreshBBI.Name = "refreshBBI";
            this.refreshBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.actionsRPG.ItemLinks.Add(this.registerBBI);
            this.actionsRPG.ItemLinks.Add(this.findBBI);
            this.actionsRPG.ItemLinks.Add(this.filterBBI);
            this.actionsRPG.ItemLinks.Add(this.refreshBBI);
            this.actionsRPG.Name = "actionsRPG";
            // 
            // rolePC
            // 
            this.rolePC.Controls.Add(this.roleGC);
            this.rolePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolePC.Location = new System.Drawing.Point(0, 116);
            this.rolePC.Name = "rolePC";
            this.rolePC.Size = new System.Drawing.Size(800, 334);
            this.rolePC.TabIndex = 1;
            // 
            // roleGC
            // 
            this.roleGC.DataSource = this.roleEIFS;
            this.roleGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleGC.Location = new System.Drawing.Point(2, 2);
            this.roleGC.MainView = this.roleGV;
            this.roleGC.MenuManager = this.roleRC;
            this.roleGC.Name = "roleGC";
            this.roleGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE});
            this.roleGC.Size = new System.Drawing.Size(796, 330);
            this.roleGC.TabIndex = 0;
            this.roleGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.roleGV});
            // 
            // roleEIFS
            // 
            this.roleEIFS.AreSourceRowsThreadSafe = true;
            this.roleEIFS.DefaultSorting = "Name ASC";
            this.roleEIFS.DesignTimeElementType = typeof(SeppimCaraibesApp.Data.ORM.RoleView);
            this.roleEIFS.KeyExpression = "RoleId";
            // 
            // roleGV
            // 
            this.roleGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription,
            this.colPermissionName,
            this.colActions});
            this.roleGV.GridControl = this.roleGC;
            this.roleGV.Name = "roleGV";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 194;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 229;
            // 
            // colPermissionName
            // 
            this.colPermissionName.FieldName = "PermissionName";
            this.colPermissionName.Name = "colPermissionName";
            this.colPermissionName.Visible = true;
            this.colPermissionName.VisibleIndex = 2;
            this.colPermissionName.Width = 301;
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 3;
            this.colActions.Width = 54;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions1.Image = global::SeppimCaraibesApp.Properties.Resources.Add_16x16;
            editorButtonImageOptions2.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions3.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Adicionar Usuario", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Eliminar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // V_ListRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rolePC);
            this.Controls.Add(this.roleRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_ListRolesForm";
            this.Text = "V_ListRolesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListRolesForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListRolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePC)).EndInit();
            this.rolePC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl roleRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraBars.BarButtonItem closeBBI;
        private DevExpress.XtraBars.BarButtonItem registerBBI;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraEditors.PanelControl rolePC;
        private DevExpress.XtraGrid.GridControl roleGC;
        private DevExpress.XtraGrid.Views.Grid.GridView roleGV;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource roleEIFS;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissionName;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
    }
}
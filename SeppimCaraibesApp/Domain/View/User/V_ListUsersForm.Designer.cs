namespace SeppimCaraibesApp.Domain.View.User
{
    partial class V_ListUsersForm
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
            this.userRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.registerBBI = new DevExpress.XtraBars.BarButtonItem();
            this.closeBBI = new DevExpress.XtraBars.BarButtonItem();
            this.findBBI = new DevExpress.XtraBars.BarButtonItem();
            this.filterBBI = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBBI = new DevExpress.XtraBars.BarButtonItem();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.usersPC = new DevExpress.XtraEditors.PanelControl();
            this.usersGC = new DevExpress.XtraGrid.GridControl();
            this.userEIFS = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.usersGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEnable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.enableRICE = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionsRIBE = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.userRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersPC)).BeginInit();
            this.usersPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enableRICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).BeginInit();
            this.SuspendLayout();
            // 
            // userRC
            // 
            this.userRC.ExpandCollapseItem.Id = 0;
            this.userRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.userRC.ExpandCollapseItem,
            this.userRC.SearchEditItem,
            this.registerBBI,
            this.closeBBI,
            this.findBBI,
            this.filterBBI,
            this.refreshBBI});
            this.userRC.Location = new System.Drawing.Point(0, 0);
            this.userRC.MaxItemId = 6;
            this.userRC.Name = "userRC";
            this.userRC.PageHeaderItemLinks.Add(this.closeBBI);
            this.userRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.userRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.userRC.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.userRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.userRC.ShowToolbarCustomizeItem = false;
            this.userRC.Size = new System.Drawing.Size(800, 116);
            this.userRC.Toolbar.ShowCustomizeItem = false;
            this.userRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.userRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // registerBBI
            // 
            this.registerBBI.Caption = "Registrar";
            this.registerBBI.Id = 1;
            this.registerBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.New_32x32;
            this.registerBBI.Name = "registerBBI";
            this.registerBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.registerBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RegisterBBI_ItemClick);
            // 
            // closeBBI
            // 
            this.closeBBI.Caption = "Cerrar";
            this.closeBBI.Id = 2;
            this.closeBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Close_16x16;
            this.closeBBI.Name = "closeBBI";
            this.closeBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBBI_ItemClick);
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
            // usersPC
            // 
            this.usersPC.Controls.Add(this.usersGC);
            this.usersPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersPC.Location = new System.Drawing.Point(0, 116);
            this.usersPC.Name = "usersPC";
            this.usersPC.Size = new System.Drawing.Size(800, 334);
            this.usersPC.TabIndex = 1;
            // 
            // usersGC
            // 
            this.usersGC.DataSource = this.userEIFS;
            this.usersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGC.Location = new System.Drawing.Point(2, 2);
            this.usersGC.MainView = this.usersGV;
            this.usersGC.MenuManager = this.userRC;
            this.usersGC.Name = "usersGC";
            this.usersGC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.actionsRIBE,
            this.enableRICE});
            this.usersGC.Size = new System.Drawing.Size(796, 330);
            this.usersGC.TabIndex = 0;
            this.usersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGV});
            // 
            // userEIFS
            // 
            this.userEIFS.AreSourceRowsThreadSafe = true;
            this.userEIFS.DefaultSorting = "Name ASC";
            this.userEIFS.DesignTimeElementType = typeof(SeppimCaraibesApp.Data.ORM.UserView);
            this.userEIFS.KeyExpression = "UserId";
            this.userEIFS.GetQueryable += new System.EventHandler<DevExpress.Data.Linq.GetQueryableEventArgs>(this.UserEIFS_GetQueryable);
            // 
            // usersGV
            // 
            this.usersGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser,
            this.colName,
            this.colEmail,
            this.colPhone,
            this.colIsEnable,
            this.colEnable,
            this.colRole,
            this.colActions});
            this.usersGV.GridControl = this.usersGC;
            this.usersGV.GroupCount = 1;
            this.usersGV.Name = "usersGV";
            this.usersGV.OptionsBehavior.AutoExpandAllGroups = true;
            this.usersGV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRole, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.usersGV.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.UsersGV_RowStyle);
            // 
            // colUser
            // 
            this.colUser.Caption = "Usuario";
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Nombre";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Correo Electrónico";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Teléfono";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colIsEnable
            // 
            this.colIsEnable.Caption = "Habilitado";
            this.colIsEnable.FieldName = "colIsEnable";
            this.colIsEnable.Name = "colIsEnable";
            this.colIsEnable.UnboundExpression = "Iif([Enable], \'Si\', \'No\')";
            this.colIsEnable.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colIsEnable.Visible = true;
            this.colIsEnable.VisibleIndex = 4;
            // 
            // colEnable
            // 
            this.colEnable.Caption = "Habilitar";
            this.colEnable.ColumnEdit = this.enableRICE;
            this.colEnable.FieldName = "Enable";
            this.colEnable.Name = "colEnable";
            this.colEnable.Visible = true;
            this.colEnable.VisibleIndex = 5;
            // 
            // enableRICE
            // 
            this.enableRICE.AutoHeight = false;
            this.enableRICE.Caption = "Habilitar";
            this.enableRICE.Name = "enableRICE";
            this.enableRICE.Click += new System.EventHandler(this.EnableRICE_CheckedChanged);
            // 
            // colRole
            // 
            this.colRole.Caption = "Rol";
            this.colRole.FieldName = "Role";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 5;
            // 
            // colActions
            // 
            this.colActions.Caption = "Acciones";
            this.colActions.ColumnEdit = this.actionsRIBE;
            this.colActions.Name = "colActions";
            this.colActions.Visible = true;
            this.colActions.VisibleIndex = 6;
            // 
            // actionsRIBE
            // 
            this.actionsRIBE.AutoHeight = false;
            editorButtonImageOptions1.Image = global::SeppimCaraibesApp.Properties.Resources.Show_16x16;
            editorButtonImageOptions2.Image = global::SeppimCaraibesApp.Properties.Resources.Edit_16x16;
            editorButtonImageOptions3.Image = global::SeppimCaraibesApp.Properties.Resources.Delete_16x16;
            this.actionsRIBE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Causa de Inhabilitación", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Editar", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Eliminar", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.actionsRIBE.Name = "actionsRIBE";
            this.actionsRIBE.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.actionsRIBE.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ActionsRIBE_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Listar Usuarios";
            // 
            // V_ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.usersPC);
            this.Controls.Add(this.userRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_ListUsersForm";
            this.Text = "V_ListUsersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_ListUsersForm_FormClosed);
            this.Load += new System.EventHandler(this.V_ListUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersPC)).EndInit();
            this.usersPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enableRICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionsRIBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl userRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraBars.BarButtonItem registerBBI;
        private DevExpress.XtraEditors.PanelControl usersPC;
        private DevExpress.XtraBars.BarButtonItem closeBBI;
        private DevExpress.XtraBars.BarButtonItem findBBI;
        private DevExpress.XtraBars.BarButtonItem filterBBI;
        private DevExpress.XtraBars.BarButtonItem refreshBBI;
        private DevExpress.XtraGrid.GridControl usersGC;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGV;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEnable;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEnable;
        private DevExpress.XtraGrid.Columns.GridColumn colActions;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit enableRICE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit actionsRIBE;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource userEIFS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
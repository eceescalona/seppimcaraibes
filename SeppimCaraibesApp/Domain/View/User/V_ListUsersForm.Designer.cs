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
            this.usersGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.userRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersPC)).BeginInit();
            this.usersPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // userRC
            // 
            this.userRC.ExpandCollapseItem.Id = 0;
            this.userRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.userRC.ExpandCollapseItem,
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
            // 
            // closeBBI
            // 
            this.closeBBI.Caption = "Cerrar";
            this.closeBBI.Id = 2;
            this.closeBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Close_16x16;
            this.closeBBI.Name = "closeBBI";
            // 
            // findBBI
            // 
            this.findBBI.Caption = "Buscar";
            this.findBBI.Id = 3;
            this.findBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Find_32x32;
            this.findBBI.Name = "findBBI";
            this.findBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // filterBBI
            // 
            this.filterBBI.Caption = "Filtrar";
            this.filterBBI.Id = 4;
            this.filterBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Filter_32x32;
            this.filterBBI.Name = "filterBBI";
            this.filterBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // refreshBBI
            // 
            this.refreshBBI.Caption = "Refrescar";
            this.refreshBBI.Id = 5;
            this.refreshBBI.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Refresh_32x32;
            this.refreshBBI.Name = "refreshBBI";
            this.refreshBBI.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.usersGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGC.Location = new System.Drawing.Point(2, 2);
            this.usersGC.MainView = this.usersGV;
            this.usersGC.MenuManager = this.userRC;
            this.usersGC.Name = "usersGC";
            this.usersGC.Size = new System.Drawing.Size(796, 330);
            this.usersGC.TabIndex = 0;
            this.usersGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGV});
            // 
            // usersGV
            // 
            this.usersGV.GridControl = this.usersGC;
            this.usersGV.Name = "usersGV";
            // 
            // V_ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersPC);
            this.Controls.Add(this.userRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_ListUsersForm";
            this.Text = "V_ListUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.userRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersPC)).EndInit();
            this.usersPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).EndInit();
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
    }
}
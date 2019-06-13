namespace SeppimCaraibesApp
{
    partial class V_MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager welcomePageSSM = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SeppimCaraibesApp.Domain.View.S_WelcomePage), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MainForm));
            this.mainLC = new DevExpress.XtraLayout.LayoutControl();
            this.viewsPC = new DevExpress.XtraEditors.PanelControl();
            this.menuPC = new DevExpress.XtraEditors.PanelControl();
            this.mainAC = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.customersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.providersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.productsACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ordersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.preOrdersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.quotesACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ordersOACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.invoicesACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mainLCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.menuLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.viewsLCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLC)).BeginInit();
            this.mainLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewsPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPC)).BeginInit();
            this.menuPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsLCI)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomePageSSM
            // 
            welcomePageSSM.ClosingDelay = 1000;
            // 
            // mainLC
            // 
            this.mainLC.Controls.Add(this.viewsPC);
            this.mainLC.Controls.Add(this.menuPC);
            this.mainLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLC.Location = new System.Drawing.Point(0, 0);
            this.mainLC.Name = "mainLC";
            this.mainLC.Root = this.mainLCG;
            this.mainLC.Size = new System.Drawing.Size(800, 450);
            this.mainLC.TabIndex = 0;
            this.mainLC.Text = "layoutControl1";
            // 
            // viewsPC
            // 
            this.viewsPC.Location = new System.Drawing.Point(70, 12);
            this.viewsPC.Name = "viewsPC";
            this.viewsPC.Size = new System.Drawing.Size(718, 426);
            this.viewsPC.TabIndex = 5;
            // 
            // menuPC
            // 
            this.menuPC.Controls.Add(this.mainAC);
            this.menuPC.Location = new System.Drawing.Point(12, 12);
            this.menuPC.Name = "menuPC";
            this.menuPC.Size = new System.Drawing.Size(54, 426);
            this.menuPC.TabIndex = 4;
            // 
            // mainAC
            // 
            this.mainAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAC.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.customersACE,
            this.providersACE,
            this.productsACE,
            this.ordersACE,
            this.invoicesACE});
            this.mainAC.Location = new System.Drawing.Point(2, 2);
            this.mainAC.Name = "mainAC";
            this.mainAC.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.mainAC.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.mainAC.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.mainAC.Size = new System.Drawing.Size(50, 422);
            this.mainAC.TabIndex = 0;
            this.mainAC.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // customersACE
            // 
            this.customersACE.Name = "customersACE";
            this.customersACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.customersACE.Text = "Clientes";
            this.customersACE.Click += new System.EventHandler(this.CustomersACE_Click);
            // 
            // providersACE
            // 
            this.providersACE.Name = "providersACE";
            this.providersACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.providersACE.Text = "Proveedores";
            this.providersACE.Click += new System.EventHandler(this.ProvidersACE_Click);
            // 
            // productsACE
            // 
            this.productsACE.Name = "productsACE";
            this.productsACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.productsACE.Text = "Productos";
            this.productsACE.Click += new System.EventHandler(this.ProductsACE_Click);
            // 
            // ordersACE
            // 
            this.ordersACE.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.preOrdersACE,
            this.quotesACE,
            this.ordersOACE});
            this.ordersACE.Name = "ordersACE";
            this.ordersACE.Text = "Ordenes";
            // 
            // preOrdersACE
            // 
            this.preOrdersACE.Name = "preOrdersACE";
            this.preOrdersACE.Text = "Pre-Ordenes";
            this.preOrdersACE.Click += new System.EventHandler(this.PreOrdersACE_Click);
            // 
            // quotesACE
            // 
            this.quotesACE.Name = "quotesACE";
            this.quotesACE.Text = "Cotizaciones";
            this.quotesACE.Click += new System.EventHandler(this.QuotesACE_Click);
            // 
            // ordersOACE
            // 
            this.ordersOACE.Name = "ordersOACE";
            this.ordersOACE.Text = "Ordenes Firmes";
            this.ordersOACE.Click += new System.EventHandler(this.OrdersOACE_Click);
            // 
            // invoicesACE
            // 
            this.invoicesACE.Name = "invoicesACE";
            this.invoicesACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.invoicesACE.Text = "Facturas";
            this.invoicesACE.Click += new System.EventHandler(this.InvoicesACE_Click);
            // 
            // mainLCG
            // 
            this.mainLCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.mainLCG.GroupBordersVisible = false;
            this.mainLCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.menuLCI,
            this.viewsLCI});
            this.mainLCG.Name = "mainLCG";
            this.mainLCG.Size = new System.Drawing.Size(800, 450);
            this.mainLCG.TextVisible = false;
            // 
            // menuLCI
            // 
            this.menuLCI.Control = this.menuPC;
            this.menuLCI.Location = new System.Drawing.Point(0, 0);
            this.menuLCI.Name = "menuLCI";
            this.menuLCI.Size = new System.Drawing.Size(58, 430);
            this.menuLCI.TextSize = new System.Drawing.Size(0, 0);
            this.menuLCI.TextVisible = false;
            // 
            // viewsLCI
            // 
            this.viewsLCI.Control = this.viewsPC;
            this.viewsLCI.Location = new System.Drawing.Point(58, 0);
            this.viewsLCI.Name = "viewsLCI";
            this.viewsLCI.Size = new System.Drawing.Size(722, 430);
            this.viewsLCI.TextSize = new System.Drawing.Size(0, 0);
            this.viewsLCI.TextVisible = false;
            // 
            // V_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elitech";
            ((System.ComponentModel.ISupportInitialize)(this.mainLC)).EndInit();
            this.mainLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewsPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPC)).EndInit();
            this.menuPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsLCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLC;
        private DevExpress.XtraEditors.PanelControl viewsPC;
        private DevExpress.XtraEditors.PanelControl menuPC;
        private DevExpress.XtraBars.Navigation.AccordionControl mainAC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customersACE;
        private DevExpress.XtraLayout.LayoutControlGroup mainLCG;
        private DevExpress.XtraLayout.LayoutControlItem menuLCI;
        private DevExpress.XtraLayout.LayoutControlItem viewsLCI;
        private DevExpress.XtraBars.Navigation.AccordionControlElement providersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement productsACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ordersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement preOrdersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement quotesACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ordersOACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement invoicesACE;
    }
}


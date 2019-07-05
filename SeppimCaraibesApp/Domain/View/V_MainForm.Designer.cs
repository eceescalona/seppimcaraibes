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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MainForm));
            this.mainLC = new DevExpress.XtraLayout.LayoutControl();
            this.viewsPC = new DevExpress.XtraEditors.PanelControl();
            this.mainLCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.viewsLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.mainAC = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.customersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.providersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.productsACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ordersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.preOrdersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.quotesACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ordersOACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.invoicesACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.usersACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mainFDFC = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.rolesACE = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.mainLC)).BeginInit();
            this.mainLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewsPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAC)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLC
            // 
            this.mainLC.Controls.Add(this.viewsPC);
            this.mainLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLC.Location = new System.Drawing.Point(50, 0);
            this.mainLC.Name = "mainLC";
            this.mainLC.Root = this.mainLCG;
            this.mainLC.Size = new System.Drawing.Size(750, 563);
            this.mainLC.TabIndex = 0;
            this.mainLC.Text = "layoutControl1";
            // 
            // viewsPC
            // 
            this.viewsPC.Location = new System.Drawing.Point(12, 12);
            this.viewsPC.Name = "viewsPC";
            this.viewsPC.Size = new System.Drawing.Size(726, 539);
            this.viewsPC.TabIndex = 5;
            // 
            // mainLCG
            // 
            this.mainLCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.mainLCG.GroupBordersVisible = false;
            this.mainLCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.viewsLCI});
            this.mainLCG.Name = "mainLCG";
            this.mainLCG.Size = new System.Drawing.Size(750, 563);
            this.mainLCG.TextVisible = false;
            // 
            // viewsLCI
            // 
            this.viewsLCI.Control = this.viewsPC;
            this.viewsLCI.Location = new System.Drawing.Point(0, 0);
            this.viewsLCI.Name = "viewsLCI";
            this.viewsLCI.Size = new System.Drawing.Size(730, 543);
            this.viewsLCI.TextSize = new System.Drawing.Size(0, 0);
            this.viewsLCI.TextVisible = false;
            // 
            // mainAC
            // 
            this.mainAC.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainAC.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.customersACE,
            this.providersACE,
            this.productsACE,
            this.ordersACE,
            this.invoicesACE,
            this.usersACE,
            this.rolesACE});
            this.mainAC.Location = new System.Drawing.Point(0, 0);
            this.mainAC.Name = "mainAC";
            this.mainAC.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.mainAC.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.mainAC.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.mainAC.Size = new System.Drawing.Size(50, 563);
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
            // usersACE
            // 
            this.usersACE.Name = "usersACE";
            this.usersACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.usersACE.Text = "Usuarios";
            this.usersACE.Click += new System.EventHandler(this.UsersACE_Click);
            // 
            // mainFDFC
            // 
            this.mainFDFC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFDFC.Location = new System.Drawing.Point(50, 0);
            this.mainFDFC.Name = "mainFDFC";
            this.mainFDFC.Size = new System.Drawing.Size(750, 563);
            this.mainFDFC.TabIndex = 1;
            // 
            // rolesACE
            // 
            this.rolesACE.Name = "rolesACE";
            this.rolesACE.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.rolesACE.Text = "Roles";
            this.rolesACE.Click += new System.EventHandler(this.RolesACE_Click);
            // 
            // V_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.mainLC);
            this.Controls.Add(this.mainFDFC);
            this.Controls.Add(this.mainAC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "V_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elitech";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.V_MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainLC)).EndInit();
            this.mainLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewsPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLC;
        private DevExpress.XtraEditors.PanelControl viewsPC;
        private DevExpress.XtraBars.Navigation.AccordionControl mainAC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customersACE;
        private DevExpress.XtraLayout.LayoutControlGroup mainLCG;
        private DevExpress.XtraLayout.LayoutControlItem viewsLCI;
        private DevExpress.XtraBars.Navigation.AccordionControlElement providersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement productsACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ordersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement preOrdersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement quotesACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ordersOACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement invoicesACE;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainFDFC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement usersACE;
        private DevExpress.XtraBars.Navigation.AccordionControlElement rolesACE;
    }
}


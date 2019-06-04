namespace SeppimCaraibesApp.Domain.View.Order
{
    partial class V_ReportQuoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ReportQuoteForm));
            this.quoteRC = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.actionsRP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.actionsRPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.quotePC = new DevExpress.XtraEditors.PanelControl();
            this.quoteDV = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.quoteRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotePC)).BeginInit();
            this.quotePC.SuspendLayout();
            this.SuspendLayout();
            // 
            // quoteRC
            // 
            this.quoteRC.ExpandCollapseItem.Id = 0;
            this.quoteRC.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.quoteRC.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.quoteRC.Location = new System.Drawing.Point(0, 0);
            this.quoteRC.MaxItemId = 4;
            this.quoteRC.Name = "quoteRC";
            this.quoteRC.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actionsRP});
            this.quoteRC.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.quoteRC.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.quoteRC.ShowToolbarCustomizeItem = false;
            this.quoteRC.Size = new System.Drawing.Size(800, 95);
            this.quoteRC.Toolbar.ShowCustomizeItem = false;
            this.quoteRC.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.quoteRC.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Enviar";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.SendPDF_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Imprimir";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.Print_32x32;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
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
            this.actionsRPG.ItemLinks.Add(this.barButtonItem3);
            this.actionsRPG.ItemLinks.Add(this.barButtonItem2);
            this.actionsRPG.ItemLinks.Add(this.barButtonItem1);
            this.actionsRPG.Name = "actionsRPG";
            this.actionsRPG.ShowCaptionButton = false;
            // 
            // quotePC
            // 
            this.quotePC.Controls.Add(this.quoteDV);
            this.quotePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quotePC.Location = new System.Drawing.Point(0, 95);
            this.quotePC.Name = "quotePC";
            this.quotePC.Size = new System.Drawing.Size(800, 355);
            this.quotePC.TabIndex = 1;
            // 
            // quoteDV
            // 
            this.quoteDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quoteDV.DocumentSource = typeof(SeppimCaraibesApp.Domain.View.Reports.Quote.R_Quote);
            this.quoteDV.IsMetric = false;
            this.quoteDV.Location = new System.Drawing.Point(2, 2);
            this.quoteDV.Name = "quoteDV";
            this.quoteDV.Size = new System.Drawing.Size(796, 351);
            this.quoteDV.TabIndex = 0;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Guardar";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = global::SeppimCaraibesApp.Properties.Resources.ExportToPDF_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // V_ReportQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quotePC);
            this.Controls.Add(this.quoteRC);
            this.Name = "V_ReportQuoteForm";
            this.Text = "V_ReportQuoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.quoteRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotePC)).EndInit();
            this.quotePC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl quoteRC;
        private DevExpress.XtraBars.Ribbon.RibbonPage actionsRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup actionsRPG;
        private DevExpress.XtraEditors.PanelControl quotePC;
        private DevExpress.XtraPrinting.Preview.DocumentViewer quoteDV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}
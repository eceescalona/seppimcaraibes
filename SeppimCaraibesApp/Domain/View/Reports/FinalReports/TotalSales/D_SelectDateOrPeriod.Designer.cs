namespace SeppimCaraibesApp.Domain.View.Reports.FinalReports.TotalSales
{
    partial class D_SelectDateOrPeriod
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
            this.periodPC = new DevExpress.XtraEditors.PanelControl();
            this.periodRG = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.periodPC)).BeginInit();
            this.periodPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodRG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // periodPC
            // 
            this.periodPC.Controls.Add(this.periodRG);
            this.periodPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodPC.Location = new System.Drawing.Point(0, 0);
            this.periodPC.Name = "periodPC";
            this.periodPC.Size = new System.Drawing.Size(226, 72);
            this.periodPC.TabIndex = 0;
            // 
            // periodRG
            // 
            this.periodRG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodRG.Location = new System.Drawing.Point(2, 2);
            this.periodRG.Name = "periodRG";
            this.periodRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), "Hasta la fecha"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "Trimestral"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(2)), "Semestral"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(3)), "Anual")});
            this.periodRG.Size = new System.Drawing.Size(222, 68);
            this.periodRG.TabIndex = 0;
            this.periodRG.SelectedIndexChanged += new System.EventHandler(this.PeriodRG_SelectedIndexChanged);
            // 
            // D_SelectDateOrPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 72);
            this.Controls.Add(this.periodPC);
            this.Name = "D_SelectDateOrPeriod";
            ((System.ComponentModel.ISupportInitialize)(this.periodPC)).EndInit();
            this.periodPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.periodRG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl periodPC;
        private DevExpress.XtraEditors.RadioGroup periodRG;
    }
}
namespace SeppimCaraibesApp.Domain.View
{
    partial class S_WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_WelcomePage));
            this.loadBarMPBC = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.copyrightLC = new DevExpress.XtraEditors.LabelControl();
            this.loadLC = new DevExpress.XtraEditors.LabelControl();
            this.logoElitechPE = new DevExpress.XtraEditors.PictureEdit();
            this.logoPE = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBarMPBC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoElitechPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBarMPBC
            // 
            this.loadBarMPBC.EditValue = 0;
            this.loadBarMPBC.Location = new System.Drawing.Point(23, 231);
            this.loadBarMPBC.Name = "loadBarMPBC";
            this.loadBarMPBC.Size = new System.Drawing.Size(404, 12);
            this.loadBarMPBC.TabIndex = 5;
            // 
            // copyrightLC
            // 
            this.copyrightLC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.copyrightLC.Location = new System.Drawing.Point(23, 286);
            this.copyrightLC.Name = "copyrightLC";
            this.copyrightLC.Size = new System.Drawing.Size(47, 13);
            this.copyrightLC.TabIndex = 6;
            this.copyrightLC.Text = "Copyright";
            // 
            // loadLC
            // 
            this.loadLC.Location = new System.Drawing.Point(23, 206);
            this.loadLC.Name = "loadLC";
            this.loadLC.Size = new System.Drawing.Size(59, 13);
            this.loadLC.TabIndex = 7;
            this.loadLC.Text = "Cargando...";
            // 
            // logoElitechPE
            // 
            this.logoElitechPE.EditValue = global::SeppimCaraibesApp.Properties.Resources.ElitechLogo;
            this.logoElitechPE.Location = new System.Drawing.Point(12, 12);
            this.logoElitechPE.Name = "logoElitechPE";
            this.logoElitechPE.Properties.AllowFocused = false;
            this.logoElitechPE.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.logoElitechPE.Properties.Appearance.Options.UseBackColor = true;
            this.logoElitechPE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logoElitechPE.Properties.ShowMenu = false;
            this.logoElitechPE.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical;
            this.logoElitechPE.Size = new System.Drawing.Size(426, 180);
            this.logoElitechPE.TabIndex = 9;
            // 
            // logoPE
            // 
            this.logoPE.EditValue = global::SeppimCaraibesApp.Properties.Resources.SeppimCaraibesLogo;
            this.logoPE.Location = new System.Drawing.Point(278, 266);
            this.logoPE.Name = "logoPE";
            this.logoPE.Properties.AllowFocused = false;
            this.logoPE.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.logoPE.Properties.Appearance.Options.UseBackColor = true;
            this.logoPE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logoPE.Properties.ShowMenu = false;
            this.logoPE.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.logoPE.Size = new System.Drawing.Size(160, 48);
            this.logoPE.TabIndex = 8;
            // 
            // S_WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.logoElitechPE);
            this.Controls.Add(this.logoPE);
            this.Controls.Add(this.loadLC);
            this.Controls.Add(this.copyrightLC);
            this.Controls.Add(this.loadBarMPBC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "S_WelcomePage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loadBarMPBC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoElitechPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl loadBarMPBC;
        private DevExpress.XtraEditors.LabelControl copyrightLC;
        private DevExpress.XtraEditors.LabelControl loadLC;
        private DevExpress.XtraEditors.PictureEdit logoPE;
        private DevExpress.XtraEditors.PictureEdit logoElitechPE;
    }
}

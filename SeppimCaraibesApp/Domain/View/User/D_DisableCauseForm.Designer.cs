namespace SeppimCaraibesApp.Domain.View.User
{
    partial class D_DisableCauseForm
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
            this.dialogLC = new DevExpress.XtraLayout.LayoutControl();
            this.dialogLCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.formPC = new DevExpress.XtraEditors.PanelControl();
            this.formLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsPC = new DevExpress.XtraEditors.PanelControl();
            this.buttonLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.disableCauseGC = new DevExpress.XtraEditors.GroupControl();
            this.buttonLC = new DevExpress.XtraLayout.LayoutControl();
            this.buttonLCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptyPC = new DevExpress.XtraEditors.PanelControl();
            this.emptyLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.acceptPC = new DevExpress.XtraEditors.PanelControl();
            this.acceptLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.acceptSB = new DevExpress.XtraEditors.SimpleButton();
            this.disableCauseME = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dialogLC)).BeginInit();
            this.dialogLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogLCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPC)).BeginInit();
            this.formPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsPC)).BeginInit();
            this.buttonsPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disableCauseGC)).BeginInit();
            this.disableCauseGC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLC)).BeginInit();
            this.buttonLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptPC)).BeginInit();
            this.acceptPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disableCauseME.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogLC
            // 
            this.dialogLC.Controls.Add(this.buttonsPC);
            this.dialogLC.Controls.Add(this.formPC);
            this.dialogLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogLC.Location = new System.Drawing.Point(0, 0);
            this.dialogLC.Name = "dialogLC";
            this.dialogLC.Root = this.dialogLCG;
            this.dialogLC.Size = new System.Drawing.Size(517, 174);
            this.dialogLC.TabIndex = 0;
            this.dialogLC.Text = "layoutControl1";
            // 
            // dialogLCG
            // 
            this.dialogLCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.dialogLCG.GroupBordersVisible = false;
            this.dialogLCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.formLCI,
            this.buttonLCI});
            this.dialogLCG.Name = "dialogLCG";
            this.dialogLCG.Size = new System.Drawing.Size(517, 174);
            this.dialogLCG.TextVisible = false;
            // 
            // formPC
            // 
            this.formPC.Controls.Add(this.disableCauseGC);
            this.formPC.Location = new System.Drawing.Point(12, 12);
            this.formPC.Name = "formPC";
            this.formPC.Size = new System.Drawing.Size(493, 90);
            this.formPC.TabIndex = 4;
            // 
            // formLCI
            // 
            this.formLCI.Control = this.formPC;
            this.formLCI.Location = new System.Drawing.Point(0, 0);
            this.formLCI.Name = "formLCI";
            this.formLCI.Size = new System.Drawing.Size(497, 94);
            this.formLCI.TextSize = new System.Drawing.Size(0, 0);
            this.formLCI.TextVisible = false;
            // 
            // buttonsPC
            // 
            this.buttonsPC.Controls.Add(this.buttonLC);
            this.buttonsPC.Location = new System.Drawing.Point(12, 106);
            this.buttonsPC.Name = "buttonsPC";
            this.buttonsPC.Size = new System.Drawing.Size(493, 56);
            this.buttonsPC.TabIndex = 5;
            // 
            // buttonLCI
            // 
            this.buttonLCI.Control = this.buttonsPC;
            this.buttonLCI.Location = new System.Drawing.Point(0, 94);
            this.buttonLCI.Name = "buttonLCI";
            this.buttonLCI.Size = new System.Drawing.Size(497, 60);
            this.buttonLCI.TextSize = new System.Drawing.Size(0, 0);
            this.buttonLCI.TextVisible = false;
            // 
            // disableCauseGC
            // 
            this.disableCauseGC.Controls.Add(this.disableCauseME);
            this.disableCauseGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableCauseGC.Location = new System.Drawing.Point(2, 2);
            this.disableCauseGC.Name = "disableCauseGC";
            this.disableCauseGC.Size = new System.Drawing.Size(489, 86);
            this.disableCauseGC.TabIndex = 0;
            this.disableCauseGC.Text = "Especifique la causa*:";
            // 
            // buttonLC
            // 
            this.buttonLC.Controls.Add(this.acceptPC);
            this.buttonLC.Controls.Add(this.emptyPC);
            this.buttonLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLC.Location = new System.Drawing.Point(2, 2);
            this.buttonLC.Name = "buttonLC";
            this.buttonLC.Root = this.buttonLCG;
            this.buttonLC.Size = new System.Drawing.Size(489, 52);
            this.buttonLC.TabIndex = 0;
            this.buttonLC.Text = "layoutControl2";
            // 
            // buttonLCG
            // 
            this.buttonLCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.buttonLCG.GroupBordersVisible = false;
            this.buttonLCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptyLCI,
            this.acceptLCI});
            this.buttonLCG.Name = "buttonLCG";
            this.buttonLCG.Size = new System.Drawing.Size(489, 52);
            this.buttonLCG.TextVisible = false;
            // 
            // emptyPC
            // 
            this.emptyPC.Location = new System.Drawing.Point(12, 12);
            this.emptyPC.Name = "emptyPC";
            this.emptyPC.Size = new System.Drawing.Size(360, 28);
            this.emptyPC.TabIndex = 4;
            // 
            // emptyLCI
            // 
            this.emptyLCI.Control = this.emptyPC;
            this.emptyLCI.Location = new System.Drawing.Point(0, 0);
            this.emptyLCI.Name = "emptyLCI";
            this.emptyLCI.Size = new System.Drawing.Size(364, 32);
            this.emptyLCI.TextSize = new System.Drawing.Size(0, 0);
            this.emptyLCI.TextVisible = false;
            // 
            // acceptPC
            // 
            this.acceptPC.Controls.Add(this.acceptSB);
            this.acceptPC.Location = new System.Drawing.Point(376, 12);
            this.acceptPC.Name = "acceptPC";
            this.acceptPC.Size = new System.Drawing.Size(101, 28);
            this.acceptPC.TabIndex = 5;
            // 
            // acceptLCI
            // 
            this.acceptLCI.Control = this.acceptPC;
            this.acceptLCI.Location = new System.Drawing.Point(364, 0);
            this.acceptLCI.Name = "acceptLCI";
            this.acceptLCI.Size = new System.Drawing.Size(105, 32);
            this.acceptLCI.TextSize = new System.Drawing.Size(0, 0);
            this.acceptLCI.TextVisible = false;
            // 
            // acceptSB
            // 
            this.acceptSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptSB.Location = new System.Drawing.Point(2, 2);
            this.acceptSB.Name = "acceptSB";
            this.acceptSB.Size = new System.Drawing.Size(97, 24);
            this.acceptSB.TabIndex = 0;
            this.acceptSB.Text = "Aceptar";
            this.acceptSB.Click += new System.EventHandler(this.AcceptSB_Click);
            // 
            // disableCauseME
            // 
            this.disableCauseME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disableCauseME.Location = new System.Drawing.Point(2, 20);
            this.disableCauseME.Name = "disableCauseME";
            this.disableCauseME.Size = new System.Drawing.Size(485, 64);
            this.disableCauseME.TabIndex = 0;
            // 
            // D_DisableCauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 174);
            this.Controls.Add(this.dialogLC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "D_DisableCauseForm";
            this.Text = "D_DisableCauseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dialogLC)).EndInit();
            this.dialogLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialogLCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formPC)).EndInit();
            this.formPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsPC)).EndInit();
            this.buttonsPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disableCauseGC)).EndInit();
            this.disableCauseGC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLC)).EndInit();
            this.buttonLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptPC)).EndInit();
            this.acceptPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acceptLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disableCauseME.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl dialogLC;
        private DevExpress.XtraLayout.LayoutControlGroup dialogLCG;
        private DevExpress.XtraEditors.PanelControl buttonsPC;
        private DevExpress.XtraLayout.LayoutControl buttonLC;
        private DevExpress.XtraEditors.PanelControl acceptPC;
        private DevExpress.XtraEditors.SimpleButton acceptSB;
        private DevExpress.XtraEditors.PanelControl emptyPC;
        private DevExpress.XtraLayout.LayoutControlGroup buttonLCG;
        private DevExpress.XtraLayout.LayoutControlItem emptyLCI;
        private DevExpress.XtraLayout.LayoutControlItem acceptLCI;
        private DevExpress.XtraEditors.PanelControl formPC;
        private DevExpress.XtraEditors.GroupControl disableCauseGC;
        private DevExpress.XtraEditors.MemoEdit disableCauseME;
        private DevExpress.XtraLayout.LayoutControlItem formLCI;
        private DevExpress.XtraLayout.LayoutControlItem buttonLCI;
    }
}
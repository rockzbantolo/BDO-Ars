namespace ActivityReportSystem.Forms
{
    partial class frmViewReports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewReports));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.myViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bneDashBody = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Tm_FadeIn = new System.Windows.Forms.Timer(this.components);
            this.Tm_FadeOut = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(938, 48);
            this.pnHeader.TabIndex = 278;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 332;
            this.label1.Text = "Report View";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(901, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 331;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // myViewer
            // 
            this.myViewer.ActiveViewIndex = -1;
            this.myViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.myViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myViewer.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myViewer.Location = new System.Drawing.Point(0, 48);
            this.myViewer.Name = "myViewer";
            this.myViewer.Size = new System.Drawing.Size(938, 680);
            this.myViewer.TabIndex = 277;
            this.myViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // bneDashBody
            // 
            this.bneDashBody.ElipseRadius = 6;
            this.bneDashBody.TargetControl = this;
            // 
            // DragHeader
            // 
            this.DragHeader.Fixed = true;
            this.DragHeader.Horizontal = true;
            this.DragHeader.TargetControl = this.pnHeader;
            this.DragHeader.Vertical = true;
            // 
            // Tm_FadeIn
            // 
            this.Tm_FadeIn.Interval = 30;
            // 
            // Tm_FadeOut
            // 
            this.Tm_FadeOut.Interval = 20;
            // 
            // frmViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 728);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.myViewer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmViewReports_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer myViewer;
        private Bunifu.Framework.UI.BunifuElipse bneDashBody;
        private Bunifu.Framework.UI.BunifuDragControl DragHeader;
        private System.Windows.Forms.Timer Tm_FadeIn;
        private System.Windows.Forms.Timer Tm_FadeOut;
    }
}
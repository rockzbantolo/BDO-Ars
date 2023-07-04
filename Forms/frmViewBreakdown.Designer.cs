namespace ActivityReportSystem.Forms
{
    partial class frmViewBreakdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBreakdown));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DragHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.BodyRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnShadBDpen = new System.Windows.Forms.Panel();
            this.bne_BDP_Rep = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bne_BDPendings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bne_pnShadBDpen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bne_pnShadBDPrep = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Tm_FadeIn = new System.Windows.Forms.Timer(this.components);
            this.Tm_FadeOut = new System.Windows.Forms.Timer(this.components);
            this.dgv_Status_Remarks = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Tx_Search = new System.Windows.Forms.TextBox();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Status_Remarks)).BeginInit();
            this.SuspendLayout();
            // 
            // DragHeader
            // 
            this.DragHeader.Fixed = true;
            this.DragHeader.Horizontal = true;
            this.DragHeader.TargetControl = this.pnHeader;
            this.DragHeader.Vertical = true;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1141, 60);
            this.pnHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 332;
            this.label1.Text = "Breakdown";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1104, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 331;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BodyRadius
            // 
            this.BodyRadius.ElipseRadius = 6;
            this.BodyRadius.TargetControl = this;
            // 
            // pnShadBDpen
            // 
            this.pnShadBDpen.BackColor = System.Drawing.Color.Silver;
            this.pnShadBDpen.Location = new System.Drawing.Point(35, 154);
            this.pnShadBDpen.Margin = new System.Windows.Forms.Padding(2);
            this.pnShadBDpen.Name = "pnShadBDpen";
            this.pnShadBDpen.Size = new System.Drawing.Size(1086, 536);
            this.pnShadBDpen.TabIndex = 153;
            // 
            // bne_BDP_Rep
            // 
            this.bne_BDP_Rep.ElipseRadius = 12;
            this.bne_BDP_Rep.TargetControl = this;
            // 
            // bne_BDPendings
            // 
            this.bne_BDPendings.ElipseRadius = 12;
            this.bne_BDPendings.TargetControl = this;
            // 
            // bne_pnShadBDpen
            // 
            this.bne_pnShadBDpen.ElipseRadius = 12;
            this.bne_pnShadBDpen.TargetControl = this.pnShadBDpen;
            // 
            // bne_pnShadBDPrep
            // 
            this.bne_pnShadBDPrep.ElipseRadius = 12;
            this.bne_pnShadBDPrep.TargetControl = this;
            // 
            // Tm_FadeIn
            // 
            this.Tm_FadeIn.Interval = 20;
            this.Tm_FadeIn.Tick += new System.EventHandler(this.Tm_FadeIn_Tick);
            // 
            // Tm_FadeOut
            // 
            this.Tm_FadeOut.Interval = 20;
            this.Tm_FadeOut.Tick += new System.EventHandler(this.Tm_FadeOut_Tick);
            // 
            // dgv_Status_Remarks
            // 
            this.dgv_Status_Remarks.AllowUserToAddRows = false;
            this.dgv_Status_Remarks.AllowUserToDeleteRows = false;
            this.dgv_Status_Remarks.AllowUserToResizeColumns = false;
            this.dgv_Status_Remarks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Status_Remarks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Status_Remarks.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Status_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Status_Remarks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Status_Remarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Status_Remarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Status_Remarks.ColumnHeadersHeight = 35;
            this.dgv_Status_Remarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Status_Remarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Status_Remarks.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Status_Remarks.DoubleBuffered = true;
            this.dgv_Status_Remarks.EnableHeadersVisualStyles = false;
            this.dgv_Status_Remarks.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_Status_Remarks.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.dgv_Status_Remarks.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Status_Remarks.Location = new System.Drawing.Point(28, 151);
            this.dgv_Status_Remarks.Name = "dgv_Status_Remarks";
            this.dgv_Status_Remarks.ReadOnly = true;
            this.dgv_Status_Remarks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Status_Remarks.RowHeadersVisible = false;
            this.dgv_Status_Remarks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Status_Remarks.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Status_Remarks.RowTemplate.DividerHeight = 1;
            this.dgv_Status_Remarks.RowTemplate.Height = 48;
            this.dgv_Status_Remarks.RowTemplate.ReadOnly = true;
            this.dgv_Status_Remarks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Status_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Status_Remarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Status_Remarks.ShowCellErrors = false;
            this.dgv_Status_Remarks.ShowCellToolTips = false;
            this.dgv_Status_Remarks.ShowEditingIcon = false;
            this.dgv_Status_Remarks.ShowRowErrors = false;
            this.dgv_Status_Remarks.Size = new System.Drawing.Size(1089, 535);
            this.dgv_Status_Remarks.TabIndex = 158;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn10.HeaderText = "MODEL";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn11.HeaderText = "SOURCE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 130;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn12.HeaderText = "STATUS REMARKS";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 240;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn13.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn14.HeaderText = "< 7 DAYS";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "> 7-30 DAYS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column2.HeaderText = "> 30 DAYS";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column3.HeaderText = "TOTAL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 15);
            this.label4.TabIndex = 293;
            this.label4.Text = "Terminal Model / Status Remarks";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(995, 102);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(122, 33);
            this.Btn_Search.TabIndex = 292;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Tx_Search
            // 
            this.Tx_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_Search.Location = new System.Drawing.Point(28, 103);
            this.Tx_Search.Name = "Tx_Search";
            this.Tx_Search.Size = new System.Drawing.Size(961, 29);
            this.Tx_Search.TabIndex = 291;
            // 
            // frmBreakdown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1141, 711);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Tx_Search);
            this.Controls.Add(this.dgv_Status_Remarks);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnShadBDpen);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBreakdown";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBreakdown_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBreakdown_KeyDown);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Status_Remarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragHeader;
        private Bunifu.Framework.UI.BunifuElipse BodyRadius;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnShadBDpen;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bne_BDP_Rep;
        private Bunifu.Framework.UI.BunifuElipse bne_BDPendings;
        private Bunifu.Framework.UI.BunifuElipse bne_pnShadBDpen;
        private Bunifu.Framework.UI.BunifuElipse bne_pnShadBDPrep;
        private System.Windows.Forms.Timer Tm_FadeIn;
        private System.Windows.Forms.Timer Tm_FadeOut;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Status_Remarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Tx_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
namespace ActivityReportSystem.Forms
{
    partial class frmBreakdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBreakdown));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DragHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.BodyRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnShadBDpen = new System.Windows.Forms.Panel();
            this.pnShadBDPrep = new System.Windows.Forms.Panel();
            this.bne_BDP_Rep = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_BdPendings = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bne_BDPendings = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_Bdp_Rep = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bne_pnShadBDpen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bne_pnShadBDPrep = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Tm_FadeIn = new System.Windows.Forms.Timer(this.components);
            this.Tm_FadeOut = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BdPendings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bdp_Rep)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.pnHeader.Size = new System.Drawing.Size(890, 60);
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
            this.btnClose.Location = new System.Drawing.Point(853, 12);
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
            this.pnShadBDpen.Location = new System.Drawing.Point(29, 20);
            this.pnShadBDpen.Margin = new System.Windows.Forms.Padding(2);
            this.pnShadBDpen.Name = "pnShadBDpen";
            this.pnShadBDpen.Size = new System.Drawing.Size(811, 585);
            this.pnShadBDpen.TabIndex = 153;
            // 
            // pnShadBDPrep
            // 
            this.pnShadBDPrep.BackColor = System.Drawing.Color.Silver;
            this.pnShadBDPrep.Location = new System.Drawing.Point(27, 21);
            this.pnShadBDPrep.Margin = new System.Windows.Forms.Padding(2);
            this.pnShadBDPrep.Name = "pnShadBDPrep";
            this.pnShadBDPrep.Size = new System.Drawing.Size(814, 577);
            this.pnShadBDPrep.TabIndex = 154;
            // 
            // bne_BDP_Rep
            // 
            this.bne_BDP_Rep.ElipseRadius = 12;
            this.bne_BDP_Rep.TargetControl = this.dgv_BdPendings;
            // 
            // dgv_BdPendings
            // 
            this.dgv_BdPendings.AllowUserToAddRows = false;
            this.dgv_BdPendings.AllowUserToDeleteRows = false;
            this.dgv_BdPendings.AllowUserToResizeColumns = false;
            this.dgv_BdPendings.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgv_BdPendings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_BdPendings.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BdPendings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BdPendings.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_BdPendings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BdPendings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_BdPendings.ColumnHeadersHeight = 40;
            this.dgv_BdPendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_BdPendings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BdPendings.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_BdPendings.DoubleBuffered = true;
            this.dgv_BdPendings.EnableHeadersVisualStyles = false;
            this.dgv_BdPendings.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_BdPendings.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.dgv_BdPendings.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_BdPendings.Location = new System.Drawing.Point(22, 16);
            this.dgv_BdPendings.Name = "dgv_BdPendings";
            this.dgv_BdPendings.ReadOnly = true;
            this.dgv_BdPendings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BdPendings.RowHeadersVisible = false;
            this.dgv_BdPendings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BdPendings.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_BdPendings.RowTemplate.DividerHeight = 1;
            this.dgv_BdPendings.RowTemplate.Height = 54;
            this.dgv_BdPendings.RowTemplate.ReadOnly = true;
            this.dgv_BdPendings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BdPendings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_BdPendings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_BdPendings.ShowCellErrors = false;
            this.dgv_BdPendings.ShowCellToolTips = false;
            this.dgv_BdPendings.ShowEditingIcon = false;
            this.dgv_BdPendings.ShowRowErrors = false;
            this.dgv_BdPendings.Size = new System.Drawing.Size(816, 587);
            this.dgv_BdPendings.TabIndex = 155;
            this.dgv_BdPendings.Leave += new System.EventHandler(this.dgv_BdPendings_Leave);
            // 
            // bne_BDPendings
            // 
            this.bne_BDPendings.ElipseRadius = 12;
            this.bne_BDPendings.TargetControl = this.dgv_Bdp_Rep;
            // 
            // dgv_Bdp_Rep
            // 
            this.dgv_Bdp_Rep.AllowUserToAddRows = false;
            this.dgv_Bdp_Rep.AllowUserToDeleteRows = false;
            this.dgv_Bdp_Rep.AllowUserToResizeColumns = false;
            this.dgv_Bdp_Rep.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgv_Bdp_Rep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_Bdp_Rep.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Bdp_Rep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Bdp_Rep.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Bdp_Rep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bdp_Rep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_Bdp_Rep.ColumnHeadersHeight = 40;
            this.dgv_Bdp_Rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Bdp_Rep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bdp_Rep.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_Bdp_Rep.DoubleBuffered = true;
            this.dgv_Bdp_Rep.EnableHeadersVisualStyles = false;
            this.dgv_Bdp_Rep.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_Bdp_Rep.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.dgv_Bdp_Rep.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Bdp_Rep.Location = new System.Drawing.Point(21, 16);
            this.dgv_Bdp_Rep.Name = "dgv_Bdp_Rep";
            this.dgv_Bdp_Rep.ReadOnly = true;
            this.dgv_Bdp_Rep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Bdp_Rep.RowHeadersVisible = false;
            this.dgv_Bdp_Rep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bdp_Rep.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgv_Bdp_Rep.RowTemplate.DividerHeight = 1;
            this.dgv_Bdp_Rep.RowTemplate.Height = 41;
            this.dgv_Bdp_Rep.RowTemplate.ReadOnly = true;
            this.dgv_Bdp_Rep.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Bdp_Rep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Bdp_Rep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Bdp_Rep.ShowCellErrors = false;
            this.dgv_Bdp_Rep.ShowCellToolTips = false;
            this.dgv_Bdp_Rep.ShowEditingIcon = false;
            this.dgv_Bdp_Rep.ShowRowErrors = false;
            this.dgv_Bdp_Rep.Size = new System.Drawing.Size(818, 580);
            this.dgv_Bdp_Rep.TabIndex = 156;
            this.dgv_Bdp_Rep.Leave += new System.EventHandler(this.dgv_Bdp_Rep_Leave);
            // 
            // bne_pnShadBDpen
            // 
            this.bne_pnShadBDpen.ElipseRadius = 12;
            this.bne_pnShadBDpen.TargetControl = this.pnShadBDpen;
            // 
            // bne_pnShadBDPrep
            // 
            this.bne_pnShadBDPrep.ElipseRadius = 12;
            this.bne_pnShadBDPrep.TargetControl = this.pnShadBDPrep;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 642);
            this.tabControl1.TabIndex = 157;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_BdPendings);
            this.tabPage1.Controls.Add(this.pnShadBDpen);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Breakdown of Pendings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Bdp_Rep);
            this.tabPage2.Controls.Add(this.pnShadBDPrep);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Breakdown of Pending Repairs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTextBoxColumn5.HeaderText = "BREAKDOWN OF PENDING REPAIRS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 310;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewTextBoxColumn6.HeaderText = "< 7 DAYS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewTextBoxColumn7.HeaderText = "> 7-30 DAYS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewTextBoxColumn8.HeaderText = "> 30 DAYS";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewTextBoxColumn9.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 160;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn1.HeaderText = "BREAKDOWN OF PENDINGS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 310;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn2.HeaderText = "< 7 DAYS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn3.HeaderText = "> 7-30 DAYS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn4.HeaderText = "> 30 DAYS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle25;
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 160;
            // 
            // frmBreakdown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(890, 720);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnHeader);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BdPendings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bdp_Rep)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragHeader;
        private Bunifu.Framework.UI.BunifuElipse BodyRadius;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnShadBDpen;
        private System.Windows.Forms.Panel pnShadBDPrep;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bne_BDP_Rep;
        private Bunifu.Framework.UI.BunifuElipse bne_BDPendings;
        private Bunifu.Framework.UI.BunifuElipse bne_pnShadBDpen;
        private Bunifu.Framework.UI.BunifuElipse bne_pnShadBDPrep;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_BdPendings;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Bdp_Rep;
        private System.Windows.Forms.Timer Tm_FadeIn;
        private System.Windows.Forms.Timer Tm_FadeOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
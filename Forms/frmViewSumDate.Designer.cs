namespace ActivityReportSystem.Forms
{
    partial class frmViewSumDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSumDate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_Lookup_Body = new System.Windows.Forms.Panel();
            this.btn_Model_Search = new System.Windows.Forms.Button();
            this.btn_Model_Clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Model_Template = new System.Windows.Forms.ComboBox();
            this.dtp_Model_From = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Model_To = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Status_List = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblActivity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Lookup_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Status_List)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Lookup_Body
            // 
            this.pn_Lookup_Body.BackColor = System.Drawing.Color.White;
            this.pn_Lookup_Body.Controls.Add(this.btn_Model_Search);
            this.pn_Lookup_Body.Controls.Add(this.btn_Model_Clear);
            this.pn_Lookup_Body.Controls.Add(this.label8);
            this.pn_Lookup_Body.Controls.Add(this.cmb_Model_Template);
            this.pn_Lookup_Body.Controls.Add(this.dtp_Model_From);
            this.pn_Lookup_Body.Controls.Add(this.label4);
            this.pn_Lookup_Body.Controls.Add(this.dtp_Model_To);
            this.pn_Lookup_Body.Controls.Add(this.label3);
            this.pn_Lookup_Body.Location = new System.Drawing.Point(828, 89);
            this.pn_Lookup_Body.Name = "pn_Lookup_Body";
            this.pn_Lookup_Body.Size = new System.Drawing.Size(367, 144);
            this.pn_Lookup_Body.TabIndex = 350;
            // 
            // btn_Model_Search
            // 
            this.btn_Model_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Model_Search.Image")));
            this.btn_Model_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Model_Search.Location = new System.Drawing.Point(14, 93);
            this.btn_Model_Search.Name = "btn_Model_Search";
            this.btn_Model_Search.Size = new System.Drawing.Size(167, 37);
            this.btn_Model_Search.TabIndex = 9;
            this.btn_Model_Search.Text = "    Search";
            this.btn_Model_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Model_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Model_Clear
            // 
            this.btn_Model_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Model_Clear.Image")));
            this.btn_Model_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Model_Clear.Location = new System.Drawing.Point(192, 93);
            this.btn_Model_Clear.Name = "btn_Model_Clear";
            this.btn_Model_Clear.Size = new System.Drawing.Size(167, 37);
            this.btn_Model_Clear.TabIndex = 8;
            this.btn_Model_Clear.Text = "    Clear";
            this.btn_Model_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Model_Clear.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "To";
            // 
            // cmb_Model_Template
            // 
            this.cmb_Model_Template.DropDownHeight = 150;
            this.cmb_Model_Template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Model_Template.DropDownWidth = 250;
            this.cmb_Model_Template.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Model_Template.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Model_Template.FormattingEnabled = true;
            this.cmb_Model_Template.IntegralHeight = false;
            this.cmb_Model_Template.ItemHeight = 18;
            this.cmb_Model_Template.Items.AddRange(new object[] {
            "",
            "INSTALLATION",
            "REPROGRAMMING",
            "SERVICING",
            "REPAIR"});
            this.cmb_Model_Template.Location = new System.Drawing.Point(85, 16);
            this.cmb_Model_Template.Name = "cmb_Model_Template";
            this.cmb_Model_Template.Size = new System.Drawing.Size(273, 26);
            this.cmb_Model_Template.TabIndex = 4;
            // 
            // dtp_Model_From
            // 
            this.dtp_Model_From.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Model_From.CustomFormat = "MMM dd, yyyy";
            this.dtp_Model_From.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Model_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Model_From.Location = new System.Drawing.Point(85, 55);
            this.dtp_Model_From.Name = "dtp_Model_From";
            this.dtp_Model_From.Size = new System.Drawing.Size(112, 26);
            this.dtp_Model_From.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Template";
            // 
            // dtp_Model_To
            // 
            this.dtp_Model_To.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Model_To.CustomFormat = "MMM, dd yyyy";
            this.dtp_Model_To.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Model_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Model_To.Location = new System.Drawing.Point(242, 55);
            this.dtp_Model_To.Name = "dtp_Model_To";
            this.dtp_Model_To.Size = new System.Drawing.Size(116, 26);
            this.dtp_Model_To.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date From";
            // 
            // dgv_Status_List
            // 
            this.dgv_Status_List.AllowUserToAddRows = false;
            this.dgv_Status_List.AllowUserToDeleteRows = false;
            this.dgv_Status_List.AllowUserToResizeColumns = false;
            this.dgv_Status_List.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Status_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Status_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Status_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Status_List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Status_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Status_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Status_List.ColumnHeadersHeight = 33;
            this.dgv_Status_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Status_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Status_List.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Status_List.DoubleBuffered = false;
            this.dgv_Status_List.EnableHeadersVisualStyles = false;
            this.dgv_Status_List.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_Status_List.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.dgv_Status_List.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Status_List.Location = new System.Drawing.Point(22, 89);
            this.dgv_Status_List.Name = "dgv_Status_List";
            this.dgv_Status_List.ReadOnly = true;
            this.dgv_Status_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Status_List.RowHeadersVisible = false;
            this.dgv_Status_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Status_List.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Status_List.RowTemplate.Height = 34;
            this.dgv_Status_List.RowTemplate.ReadOnly = true;
            this.dgv_Status_List.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Status_List.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_Status_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Status_List.ShowCellErrors = false;
            this.dgv_Status_List.ShowCellToolTips = false;
            this.dgv_Status_List.ShowEditingIcon = false;
            this.dgv_Status_List.ShowRowErrors = false;
            this.dgv_Status_List.Size = new System.Drawing.Size(787, 614);
            this.dgv_Status_List.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Terminal ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Model";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Merchant Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date Received";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column7
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // Column6
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Visible = false;
            this.Column6.Width = 131;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblActivity);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1207, 56);
            this.pnlHeader.TabIndex = 352;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1172, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.ForeColor = System.Drawing.Color.White;
            this.lblActivity.Location = new System.Drawing.Point(17, 12);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(71, 25);
            this.lblActivity.TabIndex = 7;
            this.lblActivity.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(828, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 464);
            this.panel1.TabIndex = 351;
            // 
            // frmSumDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 726);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_Lookup_Body);
            this.Controls.Add(this.dgv_Status_List);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSumDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pn_Lookup_Body.ResumeLayout(false);
            this.pn_Lookup_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Status_List)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Lookup_Body;
        private System.Windows.Forms.Button btn_Model_Search;
        private System.Windows.Forms.Button btn_Model_Clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Model_Template;
        private System.Windows.Forms.DateTimePicker dtp_Model_From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Model_To;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Status_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblActivity;
        private System.Windows.Forms.Panel panel1;
    }
}
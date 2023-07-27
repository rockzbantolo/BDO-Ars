namespace ActivityReportSystem
{
    partial class frmMImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMImport));
            this.pn_Header = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Imp_OpenRepair = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Imp_OpenServicing = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Imp_OpenReprog = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Imp_OpenInstallation = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_Imp_ServicingFile = new System.Windows.Forms.TextBox();
            this.tx_Imp_RepairFile = new System.Windows.Forms.TextBox();
            this.tx_Imp_ReprogFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Imp_InstallationFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Imp_Clear = new System.Windows.Forms.Button();
            this.btn_Imp_Save = new System.Windows.Forms.Button();
            this.pn_Imp_BxPreview = new System.Windows.Forms.Panel();
            this.tpcActivity = new System.Windows.Forms.TabControl();
            this.tbpInstallation = new System.Windows.Forms.TabPage();
            this.dgv_Imp_Installation = new System.Windows.Forms.DataGridView();
            this.tbpReprogramming = new System.Windows.Forms.TabPage();
            this.dgv_Imp_Reprogramming = new System.Windows.Forms.DataGridView();
            this.tbpServicing = new System.Windows.Forms.TabPage();
            this.dgv_Imp_Servicing = new System.Windows.Forms.DataGridView();
            this.tbpRepair = new System.Windows.Forms.TabPage();
            this.dgv_Imp_Repair = new System.Windows.Forms.DataGridView();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.dgv_Imp_Inventory = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.bndragBody = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_Imp_BxDataClick = new System.Windows.Forms.Panel();
            this.rtb_Imp_Selected = new System.Windows.Forms.RichTextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lb_Imp_Selected = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pn_Imp_BxTemplate = new System.Windows.Forms.Panel();
            this.btn_Imp_OpenInvent = new Bunifu.Framework.UI.BunifuImageButton();
            this.tx_Imp_Inventory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bneBoxImport = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bneBody = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bneBoxPreview = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bneBoxDataClick = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Tm_FadeIn = new System.Windows.Forms.Timer(this.components);
            this.Tm_FadeOut = new System.Windows.Forms.Timer(this.components);
            this.pn_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenServicing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenReprog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenInstallation)).BeginInit();
            this.pn_Imp_BxPreview.SuspendLayout();
            this.tpcActivity.SuspendLayout();
            this.tbpInstallation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Installation)).BeginInit();
            this.tbpReprogramming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Reprogramming)).BeginInit();
            this.tbpServicing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Servicing)).BeginInit();
            this.tbpRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Repair)).BeginInit();
            this.tbpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Inventory)).BeginInit();
            this.panel9.SuspendLayout();
            this.pn_Imp_BxDataClick.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pn_Imp_BxTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenInvent)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Header
            // 
            this.pn_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.pn_Header.Controls.Add(this.lb_Title);
            this.pn_Header.Controls.Add(this.btnExit);
            this.pn_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Header.Location = new System.Drawing.Point(0, 0);
            this.pn_Header.Name = "pn_Header";
            this.pn_Header.Size = new System.Drawing.Size(625, 53);
            this.pn_Header.TabIndex = 273;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(19, 12);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(83, 25);
            this.lb_Title.TabIndex = 9;
            this.lb_Title.Text = "Imports";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(590, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_Imp_OpenRepair
            // 
            this.btn_Imp_OpenRepair.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_OpenRepair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_OpenRepair.Image")));
            this.btn_Imp_OpenRepair.ImageActive = null;
            this.btn_Imp_OpenRepair.Location = new System.Drawing.Point(514, 175);
            this.btn_Imp_OpenRepair.Name = "btn_Imp_OpenRepair";
            this.btn_Imp_OpenRepair.Size = new System.Drawing.Size(41, 31);
            this.btn_Imp_OpenRepair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Imp_OpenRepair.TabIndex = 347;
            this.btn_Imp_OpenRepair.TabStop = false;
            this.btn_Imp_OpenRepair.Zoom = 10;
            this.btn_Imp_OpenRepair.Click += new System.EventHandler(this.btn_Imp_OpenRepair_Click);
            // 
            // btn_Imp_OpenServicing
            // 
            this.btn_Imp_OpenServicing.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_OpenServicing.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_OpenServicing.Image")));
            this.btn_Imp_OpenServicing.ImageActive = null;
            this.btn_Imp_OpenServicing.Location = new System.Drawing.Point(514, 138);
            this.btn_Imp_OpenServicing.Name = "btn_Imp_OpenServicing";
            this.btn_Imp_OpenServicing.Size = new System.Drawing.Size(41, 31);
            this.btn_Imp_OpenServicing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Imp_OpenServicing.TabIndex = 346;
            this.btn_Imp_OpenServicing.TabStop = false;
            this.btn_Imp_OpenServicing.Zoom = 10;
            this.btn_Imp_OpenServicing.Click += new System.EventHandler(this.btn_Imp_OpenServicing_Click);
            // 
            // btn_Imp_OpenReprog
            // 
            this.btn_Imp_OpenReprog.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_OpenReprog.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_OpenReprog.Image")));
            this.btn_Imp_OpenReprog.ImageActive = null;
            this.btn_Imp_OpenReprog.Location = new System.Drawing.Point(514, 101);
            this.btn_Imp_OpenReprog.Name = "btn_Imp_OpenReprog";
            this.btn_Imp_OpenReprog.Size = new System.Drawing.Size(41, 31);
            this.btn_Imp_OpenReprog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Imp_OpenReprog.TabIndex = 345;
            this.btn_Imp_OpenReprog.TabStop = false;
            this.btn_Imp_OpenReprog.Zoom = 10;
            this.btn_Imp_OpenReprog.Click += new System.EventHandler(this.btn_Imp_OpenReprog_Click);
            // 
            // btn_Imp_OpenInstallation
            // 
            this.btn_Imp_OpenInstallation.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_OpenInstallation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_OpenInstallation.Image")));
            this.btn_Imp_OpenInstallation.ImageActive = null;
            this.btn_Imp_OpenInstallation.Location = new System.Drawing.Point(514, 65);
            this.btn_Imp_OpenInstallation.Name = "btn_Imp_OpenInstallation";
            this.btn_Imp_OpenInstallation.Size = new System.Drawing.Size(41, 31);
            this.btn_Imp_OpenInstallation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Imp_OpenInstallation.TabIndex = 344;
            this.btn_Imp_OpenInstallation.TabStop = false;
            this.btn_Imp_OpenInstallation.Zoom = 10;
            this.btn_Imp_OpenInstallation.Click += new System.EventHandler(this.btn_Imp_OpenInstallation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 343;
            this.label5.Text = "SERVICING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 341;
            this.label3.Text = "REPAIR";
            // 
            // tx_Imp_ServicingFile
            // 
            this.tx_Imp_ServicingFile.BackColor = System.Drawing.Color.White;
            this.tx_Imp_ServicingFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Imp_ServicingFile.Location = new System.Drawing.Point(144, 140);
            this.tx_Imp_ServicingFile.Name = "tx_Imp_ServicingFile";
            this.tx_Imp_ServicingFile.ReadOnly = true;
            this.tx_Imp_ServicingFile.Size = new System.Drawing.Size(360, 27);
            this.tx_Imp_ServicingFile.TabIndex = 336;
            // 
            // tx_Imp_RepairFile
            // 
            this.tx_Imp_RepairFile.BackColor = System.Drawing.Color.White;
            this.tx_Imp_RepairFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Imp_RepairFile.Location = new System.Drawing.Point(144, 177);
            this.tx_Imp_RepairFile.Name = "tx_Imp_RepairFile";
            this.tx_Imp_RepairFile.ReadOnly = true;
            this.tx_Imp_RepairFile.Size = new System.Drawing.Size(360, 27);
            this.tx_Imp_RepairFile.TabIndex = 337;
            // 
            // tx_Imp_ReprogFile
            // 
            this.tx_Imp_ReprogFile.BackColor = System.Drawing.Color.White;
            this.tx_Imp_ReprogFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Imp_ReprogFile.Location = new System.Drawing.Point(144, 103);
            this.tx_Imp_ReprogFile.Name = "tx_Imp_ReprogFile";
            this.tx_Imp_ReprogFile.ReadOnly = true;
            this.tx_Imp_ReprogFile.Size = new System.Drawing.Size(360, 27);
            this.tx_Imp_ReprogFile.TabIndex = 335;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 340;
            this.label2.Text = "REPROGRAMMING";
            // 
            // tx_Imp_InstallationFile
            // 
            this.tx_Imp_InstallationFile.BackColor = System.Drawing.Color.White;
            this.tx_Imp_InstallationFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Imp_InstallationFile.Location = new System.Drawing.Point(144, 68);
            this.tx_Imp_InstallationFile.Name = "tx_Imp_InstallationFile";
            this.tx_Imp_InstallationFile.ReadOnly = true;
            this.tx_Imp_InstallationFile.Size = new System.Drawing.Size(360, 27);
            this.tx_Imp_InstallationFile.TabIndex = 334;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 339;
            this.label6.Text = "INSTALLATION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(18, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 310;
            this.label11.Text = "TEMPLATES";
            // 
            // btn_Imp_Clear
            // 
            this.btn_Imp_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Imp_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Imp_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imp_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Imp_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_Clear.Image")));
            this.btn_Imp_Clear.Location = new System.Drawing.Point(447, 259);
            this.btn_Imp_Clear.Name = "btn_Imp_Clear";
            this.btn_Imp_Clear.Size = new System.Drawing.Size(104, 34);
            this.btn_Imp_Clear.TabIndex = 461;
            this.btn_Imp_Clear.Text = "     Clear";
            this.btn_Imp_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Imp_Clear.UseVisualStyleBackColor = false;
            this.btn_Imp_Clear.Click += new System.EventHandler(this.btnImpClear_Click);
            // 
            // btn_Imp_Save
            // 
            this.btn_Imp_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_Save.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Imp_Save.FlatAppearance.BorderSize = 0;
            this.btn_Imp_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imp_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Imp_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_Save.Image")));
            this.btn_Imp_Save.Location = new System.Drawing.Point(331, 259);
            this.btn_Imp_Save.Name = "btn_Imp_Save";
            this.btn_Imp_Save.Size = new System.Drawing.Size(104, 34);
            this.btn_Imp_Save.TabIndex = 460;
            this.btn_Imp_Save.Text = "     Save";
            this.btn_Imp_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Imp_Save.UseVisualStyleBackColor = false;
            this.btn_Imp_Save.Click += new System.EventHandler(this.btnImpSave_Click);
            // 
            // pn_Imp_BxPreview
            // 
            this.pn_Imp_BxPreview.BackColor = System.Drawing.Color.White;
            this.pn_Imp_BxPreview.Controls.Add(this.tpcActivity);
            this.pn_Imp_BxPreview.Controls.Add(this.panel9);
            this.pn_Imp_BxPreview.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Imp_BxPreview.Location = new System.Drawing.Point(25, 444);
            this.pn_Imp_BxPreview.Name = "pn_Imp_BxPreview";
            this.pn_Imp_BxPreview.Size = new System.Drawing.Size(661, 225);
            this.pn_Imp_BxPreview.TabIndex = 462;
            this.pn_Imp_BxPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Imp_BxPreview_Paint);
            // 
            // tpcActivity
            // 
            this.tpcActivity.Controls.Add(this.tbpInstallation);
            this.tpcActivity.Controls.Add(this.tbpReprogramming);
            this.tpcActivity.Controls.Add(this.tbpServicing);
            this.tpcActivity.Controls.Add(this.tbpRepair);
            this.tpcActivity.Controls.Add(this.tbpInventory);
            this.tpcActivity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpcActivity.Location = new System.Drawing.Point(3, 53);
            this.tpcActivity.Name = "tpcActivity";
            this.tpcActivity.SelectedIndex = 0;
            this.tpcActivity.Size = new System.Drawing.Size(655, 325);
            this.tpcActivity.TabIndex = 0;
            // 
            // tbpInstallation
            // 
            this.tbpInstallation.Controls.Add(this.dgv_Imp_Installation);
            this.tbpInstallation.Location = new System.Drawing.Point(4, 21);
            this.tbpInstallation.Name = "tbpInstallation";
            this.tbpInstallation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInstallation.Size = new System.Drawing.Size(647, 300);
            this.tbpInstallation.TabIndex = 0;
            this.tbpInstallation.Text = " INSTALLATION";
            this.tbpInstallation.UseVisualStyleBackColor = true;
            // 
            // dgv_Imp_Installation
            // 
            this.dgv_Imp_Installation.AllowUserToAddRows = false;
            this.dgv_Imp_Installation.AllowUserToDeleteRows = false;
            this.dgv_Imp_Installation.AllowUserToResizeColumns = false;
            this.dgv_Imp_Installation.AllowUserToResizeRows = false;
            this.dgv_Imp_Installation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Imp_Installation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Imp_Installation.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Imp_Installation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Imp_Installation.ColumnHeadersHeight = 25;
            this.dgv_Imp_Installation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Imp_Installation.Location = new System.Drawing.Point(3, 3);
            this.dgv_Imp_Installation.MultiSelect = false;
            this.dgv_Imp_Installation.Name = "dgv_Imp_Installation";
            this.dgv_Imp_Installation.ReadOnly = true;
            this.dgv_Imp_Installation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Imp_Installation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Imp_Installation.Size = new System.Drawing.Size(641, 294);
            this.dgv_Imp_Installation.TabIndex = 121;
            this.dgv_Imp_Installation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdImpInstallation_RowPostPaint);
            this.dgv_Imp_Installation.DoubleClick += new System.EventHandler(this.dgv_Imp_Installation_DoubleClick);
            // 
            // tbpReprogramming
            // 
            this.tbpReprogramming.Controls.Add(this.dgv_Imp_Reprogramming);
            this.tbpReprogramming.Location = new System.Drawing.Point(4, 21);
            this.tbpReprogramming.Name = "tbpReprogramming";
            this.tbpReprogramming.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReprogramming.Size = new System.Drawing.Size(647, 300);
            this.tbpReprogramming.TabIndex = 1;
            this.tbpReprogramming.Text = "REPROGRAMMING";
            this.tbpReprogramming.UseVisualStyleBackColor = true;
            // 
            // dgv_Imp_Reprogramming
            // 
            this.dgv_Imp_Reprogramming.AllowUserToAddRows = false;
            this.dgv_Imp_Reprogramming.AllowUserToDeleteRows = false;
            this.dgv_Imp_Reprogramming.AllowUserToResizeColumns = false;
            this.dgv_Imp_Reprogramming.AllowUserToResizeRows = false;
            this.dgv_Imp_Reprogramming.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Imp_Reprogramming.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Imp_Reprogramming.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Imp_Reprogramming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Imp_Reprogramming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Imp_Reprogramming.Location = new System.Drawing.Point(3, 3);
            this.dgv_Imp_Reprogramming.MultiSelect = false;
            this.dgv_Imp_Reprogramming.Name = "dgv_Imp_Reprogramming";
            this.dgv_Imp_Reprogramming.ReadOnly = true;
            this.dgv_Imp_Reprogramming.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Imp_Reprogramming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Imp_Reprogramming.Size = new System.Drawing.Size(641, 294);
            this.dgv_Imp_Reprogramming.TabIndex = 122;
            this.dgv_Imp_Reprogramming.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdImpReprogramming_RowPostPaint);
            this.dgv_Imp_Reprogramming.DoubleClick += new System.EventHandler(this.dgv_Imp_Reprogramming_DoubleClick);
            // 
            // tbpServicing
            // 
            this.tbpServicing.Controls.Add(this.dgv_Imp_Servicing);
            this.tbpServicing.Location = new System.Drawing.Point(4, 21);
            this.tbpServicing.Name = "tbpServicing";
            this.tbpServicing.Padding = new System.Windows.Forms.Padding(3);
            this.tbpServicing.Size = new System.Drawing.Size(647, 300);
            this.tbpServicing.TabIndex = 2;
            this.tbpServicing.Text = "SERVICING";
            this.tbpServicing.UseVisualStyleBackColor = true;
            // 
            // dgv_Imp_Servicing
            // 
            this.dgv_Imp_Servicing.AllowUserToAddRows = false;
            this.dgv_Imp_Servicing.AllowUserToDeleteRows = false;
            this.dgv_Imp_Servicing.AllowUserToResizeColumns = false;
            this.dgv_Imp_Servicing.AllowUserToResizeRows = false;
            this.dgv_Imp_Servicing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Imp_Servicing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Imp_Servicing.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Imp_Servicing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Imp_Servicing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Imp_Servicing.Location = new System.Drawing.Point(3, 3);
            this.dgv_Imp_Servicing.MultiSelect = false;
            this.dgv_Imp_Servicing.Name = "dgv_Imp_Servicing";
            this.dgv_Imp_Servicing.ReadOnly = true;
            this.dgv_Imp_Servicing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Imp_Servicing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Imp_Servicing.Size = new System.Drawing.Size(641, 294);
            this.dgv_Imp_Servicing.TabIndex = 122;
            this.dgv_Imp_Servicing.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdImpServicing_RowPostPaint);
            this.dgv_Imp_Servicing.DoubleClick += new System.EventHandler(this.dgv_Imp_Servicing_DoubleClick);
            // 
            // tbpRepair
            // 
            this.tbpRepair.Controls.Add(this.dgv_Imp_Repair);
            this.tbpRepair.Location = new System.Drawing.Point(4, 21);
            this.tbpRepair.Name = "tbpRepair";
            this.tbpRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRepair.Size = new System.Drawing.Size(647, 300);
            this.tbpRepair.TabIndex = 3;
            this.tbpRepair.Text = "REPAIR";
            this.tbpRepair.UseVisualStyleBackColor = true;
            // 
            // dgv_Imp_Repair
            // 
            this.dgv_Imp_Repair.AllowUserToAddRows = false;
            this.dgv_Imp_Repair.AllowUserToDeleteRows = false;
            this.dgv_Imp_Repair.AllowUserToResizeColumns = false;
            this.dgv_Imp_Repair.AllowUserToResizeRows = false;
            this.dgv_Imp_Repair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Imp_Repair.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Imp_Repair.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Imp_Repair.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Imp_Repair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Imp_Repair.Location = new System.Drawing.Point(3, 3);
            this.dgv_Imp_Repair.MultiSelect = false;
            this.dgv_Imp_Repair.Name = "dgv_Imp_Repair";
            this.dgv_Imp_Repair.ReadOnly = true;
            this.dgv_Imp_Repair.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Imp_Repair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Imp_Repair.Size = new System.Drawing.Size(641, 294);
            this.dgv_Imp_Repair.TabIndex = 122;
            this.dgv_Imp_Repair.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdImpRepair_RowPostPaint);
            this.dgv_Imp_Repair.DoubleClick += new System.EventHandler(this.dgv_Imp_Repair_DoubleClick);
            // 
            // tbpInventory
            // 
            this.tbpInventory.Controls.Add(this.dgv_Imp_Inventory);
            this.tbpInventory.Location = new System.Drawing.Point(4, 21);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInventory.Size = new System.Drawing.Size(647, 300);
            this.tbpInventory.TabIndex = 4;
            this.tbpInventory.Text = "INVENTORY";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // dgv_Imp_Inventory
            // 
            this.dgv_Imp_Inventory.AllowUserToAddRows = false;
            this.dgv_Imp_Inventory.AllowUserToDeleteRows = false;
            this.dgv_Imp_Inventory.AllowUserToResizeColumns = false;
            this.dgv_Imp_Inventory.AllowUserToResizeRows = false;
            this.dgv_Imp_Inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Imp_Inventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Imp_Inventory.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Imp_Inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Imp_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Imp_Inventory.Location = new System.Drawing.Point(3, 3);
            this.dgv_Imp_Inventory.MultiSelect = false;
            this.dgv_Imp_Inventory.Name = "dgv_Imp_Inventory";
            this.dgv_Imp_Inventory.ReadOnly = true;
            this.dgv_Imp_Inventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Imp_Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Imp_Inventory.Size = new System.Drawing.Size(641, 294);
            this.dgv_Imp_Inventory.TabIndex = 123;
            this.dgv_Imp_Inventory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Imp_Inventory_RowPostPaint);
            this.dgv_Imp_Inventory.DoubleClick += new System.EventHandler(this.dgv_Imp_Inventory_DoubleClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(658, 51);
            this.panel9.TabIndex = 311;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 310;
            this.label1.Text = "DATA PREVIEW";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(658, 1);
            this.panel10.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Silver;
            this.panel16.Location = new System.Drawing.Point(440, 265);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(2, 23);
            this.panel16.TabIndex = 462;
            // 
            // bndragBody
            // 
            this.bndragBody.Fixed = true;
            this.bndragBody.Horizontal = true;
            this.bndragBody.TargetControl = this.pn_Header;
            this.bndragBody.Vertical = true;
            // 
            // pn_Imp_BxDataClick
            // 
            this.pn_Imp_BxDataClick.BackColor = System.Drawing.Color.White;
            this.pn_Imp_BxDataClick.Controls.Add(this.rtb_Imp_Selected);
            this.pn_Imp_BxDataClick.Controls.Add(this.panel13);
            this.pn_Imp_BxDataClick.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Imp_BxDataClick.Location = new System.Drawing.Point(711, 356);
            this.pn_Imp_BxDataClick.Name = "pn_Imp_BxDataClick";
            this.pn_Imp_BxDataClick.Size = new System.Drawing.Size(330, 310);
            this.pn_Imp_BxDataClick.TabIndex = 495;
            this.pn_Imp_BxDataClick.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Imp_BxDataClick_Paint);
            // 
            // rtb_Imp_Selected
            // 
            this.rtb_Imp_Selected.BackColor = System.Drawing.Color.White;
            this.rtb_Imp_Selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Imp_Selected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Imp_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtb_Imp_Selected.Location = new System.Drawing.Point(1, 34);
            this.rtb_Imp_Selected.Name = "rtb_Imp_Selected";
            this.rtb_Imp_Selected.ReadOnly = true;
            this.rtb_Imp_Selected.Size = new System.Drawing.Size(326, 552);
            this.rtb_Imp_Selected.TabIndex = 312;
            this.rtb_Imp_Selected.Text = "";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.lb_Imp_Selected);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(327, 33);
            this.panel13.TabIndex = 311;
            // 
            // lb_Imp_Selected
            // 
            this.lb_Imp_Selected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Imp_Selected.ForeColor = System.Drawing.Color.Red;
            this.lb_Imp_Selected.Location = new System.Drawing.Point(207, 9);
            this.lb_Imp_Selected.Name = "lb_Imp_Selected";
            this.lb_Imp_Selected.Size = new System.Drawing.Size(110, 15);
            this.lb_Imp_Selected.TabIndex = 311;
            this.lb_Imp_Selected.Text = "ACTIVITY";
            this.lb_Imp_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 310;
            this.label4.Text = "SELECTED INFORMATION";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Silver;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(327, 1);
            this.panel14.TabIndex = 0;
            // 
            // pn_Imp_BxTemplate
            // 
            this.pn_Imp_BxTemplate.BackColor = System.Drawing.Color.White;
            this.pn_Imp_BxTemplate.Controls.Add(this.panel16);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_OpenInvent);
            this.pn_Imp_BxTemplate.Controls.Add(this.tx_Imp_Inventory);
            this.pn_Imp_BxTemplate.Controls.Add(this.label8);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_Clear);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_Save);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_OpenRepair);
            this.pn_Imp_BxTemplate.Controls.Add(this.panel6);
            this.pn_Imp_BxTemplate.Controls.Add(this.tx_Imp_InstallationFile);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_OpenServicing);
            this.pn_Imp_BxTemplate.Controls.Add(this.tx_Imp_RepairFile);
            this.pn_Imp_BxTemplate.Controls.Add(this.tx_Imp_ReprogFile);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_OpenReprog);
            this.pn_Imp_BxTemplate.Controls.Add(this.tx_Imp_ServicingFile);
            this.pn_Imp_BxTemplate.Controls.Add(this.label2);
            this.pn_Imp_BxTemplate.Controls.Add(this.btn_Imp_OpenInstallation);
            this.pn_Imp_BxTemplate.Controls.Add(this.label3);
            this.pn_Imp_BxTemplate.Controls.Add(this.label6);
            this.pn_Imp_BxTemplate.Controls.Add(this.label5);
            this.pn_Imp_BxTemplate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Imp_BxTemplate.Location = new System.Drawing.Point(24, 65);
            this.pn_Imp_BxTemplate.Name = "pn_Imp_BxTemplate";
            this.pn_Imp_BxTemplate.Size = new System.Drawing.Size(575, 312);
            this.pn_Imp_BxTemplate.TabIndex = 456;
            this.pn_Imp_BxTemplate.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Imp_BxTemplate_Paint);
            // 
            // btn_Imp_OpenInvent
            // 
            this.btn_Imp_OpenInvent.BackColor = System.Drawing.Color.Transparent;
            this.btn_Imp_OpenInvent.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imp_OpenInvent.Image")));
            this.btn_Imp_OpenInvent.ImageActive = null;
            this.btn_Imp_OpenInvent.Location = new System.Drawing.Point(514, 213);
            this.btn_Imp_OpenInvent.Name = "btn_Imp_OpenInvent";
            this.btn_Imp_OpenInvent.Size = new System.Drawing.Size(41, 31);
            this.btn_Imp_OpenInvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Imp_OpenInvent.TabIndex = 350;
            this.btn_Imp_OpenInvent.TabStop = false;
            this.btn_Imp_OpenInvent.Zoom = 10;
            this.btn_Imp_OpenInvent.Click += new System.EventHandler(this.btn_Imp_OpenInvent_Click);
            // 
            // tx_Imp_Inventory
            // 
            this.tx_Imp_Inventory.BackColor = System.Drawing.Color.White;
            this.tx_Imp_Inventory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_Imp_Inventory.Location = new System.Drawing.Point(144, 215);
            this.tx_Imp_Inventory.Name = "tx_Imp_Inventory";
            this.tx_Imp_Inventory.ReadOnly = true;
            this.tx_Imp_Inventory.Size = new System.Drawing.Size(360, 27);
            this.tx_Imp_Inventory.TabIndex = 348;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 349;
            this.label8.Text = "INVENTORY";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(572, 50);
            this.panel6.TabIndex = 311;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(572, 1);
            this.panel7.TabIndex = 0;
            // 
            // bneBoxImport
            // 
            this.bneBoxImport.ElipseRadius = 7;
            this.bneBoxImport.TargetControl = this.pn_Imp_BxTemplate;
            // 
            // bneBody
            // 
            this.bneBody.ElipseRadius = 6;
            this.bneBody.TargetControl = this;
            // 
            // bneBoxPreview
            // 
            this.bneBoxPreview.ElipseRadius = 7;
            this.bneBoxPreview.TargetControl = this.pn_Imp_BxPreview;
            // 
            // bneBoxDataClick
            // 
            this.bneBoxDataClick.ElipseRadius = 7;
            this.bneBoxDataClick.TargetControl = this.pn_Imp_BxDataClick;
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
            // frmMImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.ControlBox = false;
            this.Controls.Add(this.pn_Imp_BxTemplate);
            this.Controls.Add(this.pn_Imp_BxDataClick);
            this.Controls.Add(this.pn_Header);
            this.Controls.Add(this.pn_Imp_BxPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMImport";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMImport_KeyDown);
            this.pn_Header.ResumeLayout(false);
            this.pn_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenServicing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenReprog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenInstallation)).EndInit();
            this.pn_Imp_BxPreview.ResumeLayout(false);
            this.tpcActivity.ResumeLayout(false);
            this.tbpInstallation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Installation)).EndInit();
            this.tbpReprogramming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Reprogramming)).EndInit();
            this.tbpServicing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Servicing)).EndInit();
            this.tbpRepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Repair)).EndInit();
            this.tbpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Imp_Inventory)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pn_Imp_BxDataClick.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pn_Imp_BxTemplate.ResumeLayout(false);
            this.pn_Imp_BxTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Imp_OpenInvent)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_Header;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Button btn_Imp_Clear;
        private System.Windows.Forms.Button btn_Imp_Save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pn_Imp_BxPreview;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuImageButton btn_Imp_OpenRepair;
        private Bunifu.Framework.UI.BunifuImageButton btn_Imp_OpenServicing;
        private Bunifu.Framework.UI.BunifuImageButton btn_Imp_OpenReprog;
        private Bunifu.Framework.UI.BunifuImageButton btn_Imp_OpenInstallation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_Imp_ServicingFile;
        private System.Windows.Forms.TextBox tx_Imp_RepairFile;
        private System.Windows.Forms.TextBox tx_Imp_ReprogFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Imp_InstallationFile;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDragControl bndragBody;
        private System.Windows.Forms.TabControl tpcActivity;
        private System.Windows.Forms.TabPage tbpInstallation;
        private System.Windows.Forms.TabPage tbpReprogramming;
        private System.Windows.Forms.TabPage tbpServicing;
        private System.Windows.Forms.TabPage tbpRepair;
        private System.Windows.Forms.DataGridView dgv_Imp_Installation;
        private System.Windows.Forms.DataGridView dgv_Imp_Reprogramming;
        private System.Windows.Forms.DataGridView dgv_Imp_Servicing;
        private System.Windows.Forms.DataGridView dgv_Imp_Repair;
        private System.Windows.Forms.Panel pn_Imp_BxDataClick;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lb_Imp_Selected;
        private System.Windows.Forms.RichTextBox rtb_Imp_Selected;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel pn_Imp_BxTemplate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuElipse bneBoxImport;
        private Bunifu.Framework.UI.BunifuElipse bneBody;
        private Bunifu.Framework.UI.BunifuElipse bneBoxPreview;
        private Bunifu.Framework.UI.BunifuElipse bneBoxDataClick;
        private System.Windows.Forms.TabPage tbpInventory;
        private System.Windows.Forms.DataGridView dgv_Imp_Inventory;
        private Bunifu.Framework.UI.BunifuImageButton btn_Imp_OpenInvent;
        private System.Windows.Forms.TextBox tx_Imp_Inventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Tm_FadeIn;
        private System.Windows.Forms.Timer Tm_FadeOut;
    }
}


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
            this.panel16 = new System.Windows.Forms.Panel();
            this.bndragBody = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.pn_Header.Size = new System.Drawing.Size(626, 53);
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
            this.btnExit.Location = new System.Drawing.Point(591, 12);
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
            this.pn_Imp_BxTemplate.Location = new System.Drawing.Point(24, 66);
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
            // 
            // bneBoxDataClick
            // 
            this.bneBoxDataClick.ElipseRadius = 7;
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
            this.ClientSize = new System.Drawing.Size(626, 401);
            this.ControlBox = false;
            this.Controls.Add(this.pn_Imp_BxTemplate);
            this.Controls.Add(this.pn_Header);
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
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel pn_Imp_BxTemplate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuElipse bneBoxImport;
        private Bunifu.Framework.UI.BunifuElipse bneBody;
        private Bunifu.Framework.UI.BunifuElipse bneBoxPreview;
        private Bunifu.Framework.UI.BunifuElipse bneBoxDataClick;
        private Bunifu.Framework.UI.BunifuImageButton btn_Imp_OpenInvent;
        private System.Windows.Forms.TextBox tx_Imp_Inventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Tm_FadeIn;
        private System.Windows.Forms.Timer Tm_FadeOut;
    }
}


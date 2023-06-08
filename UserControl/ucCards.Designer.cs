namespace ActivityReportSystem
{
    partial class ucCards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Lb_Header = new System.Windows.Forms.Label();
            this.Pn_Body = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Header = new System.Windows.Forms.PictureBox();
            this.Lb_Value = new System.Windows.Forms.Label();
            this.pn_Bottom = new System.Windows.Forms.Panel();
            this.Lk_Details = new System.Windows.Forms.LinkLabel();
            this.Pn_Left = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Pn_Body.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Header)).BeginInit();
            this.pn_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Lb_Header
            // 
            this.Lb_Header.AutoSize = true;
            this.Lb_Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Header.Location = new System.Drawing.Point(11, 11);
            this.Lb_Header.Margin = new System.Windows.Forms.Padding(6, 6, 0, 0);
            this.Lb_Header.Name = "Lb_Header";
            this.Lb_Header.Size = new System.Drawing.Size(101, 21);
            this.Lb_Header.TabIndex = 0;
            this.Lb_Header.Text = "Header Text";
            // 
            // Pn_Body
            // 
            this.Pn_Body.BackColor = System.Drawing.Color.White;
            this.Pn_Body.Controls.Add(this.tableLayoutPanel1);
            this.Pn_Body.Controls.Add(this.pn_Bottom);
            this.Pn_Body.Controls.Add(this.Pn_Left);
            this.Pn_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Body.Location = new System.Drawing.Point(0, 0);
            this.Pn_Body.Name = "Pn_Body";
            this.Pn_Body.Size = new System.Drawing.Size(328, 176);
            this.Pn_Body.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.05195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.94805F));
            this.tableLayoutPanel1.Controls.Add(this.pb_Header, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lb_Value, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lb_Header, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 133);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pb_Header
            // 
            this.pb_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Header.Location = new System.Drawing.Point(233, 8);
            this.pb_Header.Name = "pb_Header";
            this.pb_Header.Size = new System.Drawing.Size(77, 54);
            this.pb_Header.TabIndex = 5;
            this.pb_Header.TabStop = false;
            // 
            // Lb_Value
            // 
            this.Lb_Value.AutoSize = true;
            this.Lb_Value.BackColor = System.Drawing.Color.White;
            this.Lb_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Value.Location = new System.Drawing.Point(8, 65);
            this.Lb_Value.Name = "Lb_Value";
            this.Lb_Value.Padding = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.Lb_Value.Size = new System.Drawing.Size(219, 63);
            this.Lb_Value.TabIndex = 2;
            this.Lb_Value.Text = "999,999";
            this.Lb_Value.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pn_Bottom
            // 
            this.pn_Bottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_Bottom.Controls.Add(this.Lk_Details);
            this.pn_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Bottom.Location = new System.Drawing.Point(10, 133);
            this.pn_Bottom.Name = "pn_Bottom";
            this.pn_Bottom.Size = new System.Drawing.Size(318, 43);
            this.pn_Bottom.TabIndex = 4;
            // 
            // Lk_Details
            // 
            this.Lk_Details.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Lk_Details.AutoSize = true;
            this.Lk_Details.BackColor = System.Drawing.Color.Transparent;
            this.Lk_Details.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lk_Details.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Lk_Details.LinkColor = System.Drawing.Color.Black;
            this.Lk_Details.Location = new System.Drawing.Point(14, 14);
            this.Lk_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lk_Details.Name = "Lk_Details";
            this.Lk_Details.Size = new System.Drawing.Size(76, 15);
            this.Lk_Details.TabIndex = 325;
            this.Lk_Details.TabStop = true;
            this.Lk_Details.Text = "View Details";
            this.Lk_Details.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.Lk_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lk_Details_LinkClicked);
            // 
            // Pn_Left
            // 
            this.Pn_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.Pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pn_Left.Location = new System.Drawing.Point(0, 0);
            this.Pn_Left.Name = "Pn_Left";
            this.Pn_Left.Size = new System.Drawing.Size(10, 176);
            this.Pn_Left.TabIndex = 3;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.Pn_Body;
            // 
            // ucCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.Pn_Body);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucCards";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.Size = new System.Drawing.Size(330, 178);
            this.Pn_Body.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Header)).EndInit();
            this.pn_Bottom.ResumeLayout(false);
            this.pn_Bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Pn_Body;
        private System.Windows.Forms.PictureBox pb_Header;
        private System.Windows.Forms.Panel pn_Bottom;
        private System.Windows.Forms.Panel Pn_Left;
        private System.Windows.Forms.Label Lb_Value;
        private System.Windows.Forms.Label Lb_Header;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.LinkLabel Lk_Details;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

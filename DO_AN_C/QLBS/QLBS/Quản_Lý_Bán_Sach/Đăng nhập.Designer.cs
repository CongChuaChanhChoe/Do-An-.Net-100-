namespace Quản_Lý_Bán_Sach
{
    partial class Đăng_nhập
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đăng_nhập));
            this.btnDN = new System.Windows.Forms.Button();
            this.lablTTK = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTTK = new System.Windows.Forms.TextBox();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmback = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.DarkGray;
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDN.Location = new System.Drawing.Point(321, 281);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(177, 80);
            this.btnDN.TabIndex = 0;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // lablTTK
            // 
            this.lablTTK.AutoSize = true;
            this.lablTTK.BackColor = System.Drawing.Color.DarkGray;
            this.lablTTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablTTK.ForeColor = System.Drawing.Color.Black;
            this.lablTTK.Location = new System.Drawing.Point(82, 100);
            this.lablTTK.Name = "lablTTK";
            this.lablTTK.Size = new System.Drawing.Size(167, 33);
            this.lablTTK.TabIndex = 1;
            this.lablTTK.Text = "Tên tài khoản";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(279, 175);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(284, 35);
            this.txtMK.TabIndex = 0;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyDown);
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.BackColor = System.Drawing.Color.DarkGray;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMK.Location = new System.Drawing.Point(82, 183);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(121, 33);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật khẩu";
            // 
            // txtTTK
            // 
            this.txtTTK.Location = new System.Drawing.Point(279, 100);
            this.txtTTK.Name = "txtTTK";
            this.txtTTK.Size = new System.Drawing.Size(284, 35);
            this.txtTTK.TabIndex = 0;
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbHienMK.Location = new System.Drawing.Point(494, 244);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(179, 31);
            this.cbHienMK.TabIndex = 4;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = false;
            this.cbHienMK.Click += new System.EventHandler(this.cbHienMK_Click);
            this.cbHienMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbHienMK_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmback});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "<";
            // 
            // tsmback
            // 
            this.tsmback.Image = ((System.Drawing.Image)(resources.GetObject("tsmback.Image")));
            this.tsmback.Name = "tsmback";
            this.tsmback.Size = new System.Drawing.Size(40, 28);
            this.tsmback.Click += new System.EventHandler(this.tsmback_Click);
            // 
            // Đăng_nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 525);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.txtTTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lablTTK);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Đăng_nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_nhập";
            this.Load += new System.EventHandler(this.Đăng_nhập_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDN;
        private Label lablTTK;
        private TextBox txtMK;
        private Label lblMK;
        private TextBox txtTTK;
        private CheckBox cbHienMK;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmback;
    }
}
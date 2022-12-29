namespace Quản_Lý_Bán_Sach
{
    partial class Hướng_dẫn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hướng_dẫn));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tpgTK = new System.Windows.Forms.TabPage();
            this.pnlTK = new System.Windows.Forms.Panel();
            this.tpgDBH = new System.Windows.Forms.TabPage();
            this.pnlDBH = new System.Windows.Forms.Panel();
            this.tpgQLS = new System.Windows.Forms.TabPage();
            this.pnlHDQLS = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgTK.SuspendLayout();
            this.tpgDBH.SuspendLayout();
            this.tpgQLS.SuspendLayout();
            this.pnlHDQLS.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "7.png");
            this.imageList1.Images.SetKeyName(1, "9.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "tk1.png");
            // 
            // tpgTK
            // 
            this.tpgTK.Controls.Add(this.pnlTK);
            this.tpgTK.ImageIndex = 1;
            this.tpgTK.Location = new System.Drawing.Point(4, 36);
            this.tpgTK.Name = "tpgTK";
            this.tpgTK.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTK.Size = new System.Drawing.Size(1257, 668);
            this.tpgTK.TabIndex = 2;
            this.tpgTK.Text = "From Thống kê";
            this.tpgTK.UseVisualStyleBackColor = true;
            // 
            // pnlTK
            // 
            this.pnlTK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTK.BackgroundImage")));
            this.pnlTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTK.Location = new System.Drawing.Point(0, 3);
            this.pnlTK.Name = "pnlTK";
            this.pnlTK.Size = new System.Drawing.Size(1251, 580);
            this.pnlTK.TabIndex = 0;
            // 
            // tpgDBH
            // 
            this.tpgDBH.Controls.Add(this.pnlDBH);
            this.tpgDBH.ImageIndex = 2;
            this.tpgDBH.Location = new System.Drawing.Point(4, 36);
            this.tpgDBH.Name = "tpgDBH";
            this.tpgDBH.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDBH.Size = new System.Drawing.Size(1257, 668);
            this.tpgDBH.TabIndex = 1;
            this.tpgDBH.Text = "From Đơn Bán Hàng";
            this.tpgDBH.UseVisualStyleBackColor = true;
            // 
            // pnlDBH
            // 
            this.pnlDBH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDBH.BackgroundImage")));
            this.pnlDBH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDBH.Location = new System.Drawing.Point(3, 0);
            this.pnlDBH.Name = "pnlDBH";
            this.pnlDBH.Size = new System.Drawing.Size(1245, 567);
            this.pnlDBH.TabIndex = 0;
            // 
            // tpgQLS
            // 
            this.tpgQLS.Controls.Add(this.pnlHDQLS);
            this.tpgQLS.ImageIndex = 0;
            this.tpgQLS.Location = new System.Drawing.Point(4, 36);
            this.tpgQLS.Name = "tpgQLS";
            this.tpgQLS.Padding = new System.Windows.Forms.Padding(3);
            this.tpgQLS.Size = new System.Drawing.Size(1257, 668);
            this.tpgQLS.TabIndex = 0;
            this.tpgQLS.Text = "Form Quản lý Sách";
            this.tpgQLS.UseVisualStyleBackColor = true;
            // 
            // pnlHDQLS
            // 
            this.pnlHDQLS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHDQLS.BackgroundImage")));
            this.pnlHDQLS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHDQLS.Controls.Add(this.button1);
            this.pnlHDQLS.Location = new System.Drawing.Point(3, 3);
            this.pnlHDQLS.Name = "pnlHDQLS";
            this.pnlHDQLS.Size = new System.Drawing.Size(1248, 570);
            this.pnlHDQLS.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-7, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnback);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgQLS);
            this.tabControl1.Controls.Add(this.tpgDBH);
            this.tabControl1.Controls.Add(this.tpgTK);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1265, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // Hướng_dẫn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 615);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Hướng_dẫn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng_dẫn";
            this.tpgTK.ResumeLayout(false);
            this.tpgDBH.ResumeLayout(false);
            this.tpgQLS.ResumeLayout(false);
            this.pnlHDQLS.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList1;
        private TabPage tpgTK;
        private Panel pnlTK;
        private TabPage tpgDBH;
        private Panel pnlDBH;
        private TabPage tpgQLS;
        private Panel pnlHDQLS;
        private Button button1;
        private TabControl tabControl1;
    }
}
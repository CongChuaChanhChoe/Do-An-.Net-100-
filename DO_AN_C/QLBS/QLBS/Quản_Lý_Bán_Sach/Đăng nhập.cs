using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Sach
{
    public partial class Đăng_nhập : Form
    {
        public Đăng_nhập()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            
            if ((this.txtTTK.Text == "") || (this.txtMK.Text == ""))
            {

                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            }
            else
            {
                if ((this.txtTTK.Text == "Admin1") && (this.txtMK.Text == "9999."))

               
                {
                    Chức_năng CN = new Chức_năng();
                    CN.ShowDialog();
                }
                else if ((this.txtTTK.Text == "NV1") && (this.txtMK.Text == "9999."))
                {
                    Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                    CNNV.ShowDialog();
                }
                else if ((this.txtTTK.Text == "Admin2") && (this.txtMK.Text == "12345."))
                {
                    Chức_năng CNQL = new Chức_năng();
                    CNQL.ShowDialog();
                }
                else if ((this.txtTTK.Text == "NV2") && (this.txtMK.Text == "abc12345."))
                {
                    Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                    CNNV.ShowDialog();
                }
                else if ((this.txtTTK.Text == "Admin3") && (this.txtMK.Text == "98765."))
                {
                    Chức_năng CNQL = new Chức_năng();
                    CNQL.ShowDialog();
                }
                else if ((this.txtTTK.Text == "NV3") && (this.txtMK.Text == "abc98765."))
                {
                    Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                    CNNV.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtTTK.Clear();
                    this.txtMK.Clear(); this.txtTTK.Focus();
                }
                this.txtTTK.ResetText();
                this.txtMK.ResetText();
            }
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((this.txtTTK.Text == "") || (this.txtMK.Text == ""))
                {

                    MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
                }
                else
                {
                    if ((this.txtTTK.Text == "Admin1") && (this.txtMK.Text == "9999."))

                    {
                        Chức_năng CN = new Chức_năng();
                        CN.ShowDialog();                      
                    }
                    else if ((this.txtTTK.Text == "NV1") && (this.txtMK.Text == "9999."))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
                    else if ((this.txtTTK.Text == "Admin2") && (this.txtMK.Text == "12345."))
                    {
                        Chức_năng CNQL = new Chức_năng();
                        CNQL.ShowDialog();
                    }
                    else if ((this.txtTTK.Text == "NV2") && (this.txtMK.Text == "abc12345."))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }                 
                    else if ((this.txtTTK.Text == "Admin3") && (this.txtMK.Text == "98765."))
                    {                       
                        Chức_năng CNQL = new Chức_năng();
                        CNQL.ShowDialog();
                    }
                    else if ((this.txtTTK.Text == "NV3") && (this.txtMK.Text == "abc98765."))
                    {                       
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                        this.txtTTK.Clear();
                        this.txtMK.Clear(); this.txtTTK.Focus();
                    }
                    this.txtTTK.ResetText();
                    this.txtMK.ResetText();
                }  
            }
        }
        private void cbHienMK_Click(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                this.txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMK.UseSystemPasswordChar = true;
            }
        }

        private void cbHienMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((this.txtTTK.Text == "") || (this.txtMK.Text == ""))
                {

                    MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
                }
                else
                {
                    if ((this.txtTTK.Text == "Admin1") && (this.txtMK.Text == "9999."))
                    {
                        Chức_năng CN = new Chức_năng();
                        CN.ShowDialog();

                    }
                    else if ((this.txtTTK.Text == "NV1") && (this.txtMK.Text == "9999."))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();

                    }
                    else if ((this.txtTTK.Text == "Admin2") && (this.txtMK.Text == "12345."))
                    {
                        Chức_năng CNQL = new Chức_năng();
                        CNQL.ShowDialog();

                    }
                    else if ((this.txtTTK.Text == "NV2") && (this.txtMK.Text == "abc12345."))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
                    else if ((this.txtTTK.Text == "Admin3") && (this.txtMK.Text == "98765."))
                    {
                        Chức_năng CNQL = new Chức_năng();
                        CNQL.ShowDialog();
                    }
                    else if ((this.txtTTK.Text == "NV3") && (this.txtMK.Text == "abc98765."))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
                    
                    else if ((this.txtTTK.Text == "NV4") && (this.txtMK.Text == "abc4"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }

                   
                    else if ((this.txtTTK.Text == "NV5") && (this.txtMK.Text == "abc5"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }

                    
                    else if ((this.txtTTK.Text == "NV6") && (this.txtMK.Text == "abc6"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }

                    
                    else if ((this.txtTTK.Text == "NV7") && (this.txtMK.Text == "abc7"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }

                    
                    else if ((this.txtTTK.Text == "NV8") && (this.txtMK.Text == "abc8"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }

                    
                    else if ((this.txtTTK.Text == "NV9") && (this.txtMK.Text == "abc9"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
      
                    else if ((this.txtTTK.Text == "NV10") && (this.txtMK.Text == "abc10"))
                    {
                        Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                        CNNV.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                        this.txtTTK.Clear();
                        this.txtMK.Clear(); this.txtTTK.Focus();
                    }
                }
            }
        }

        private void Đăng_nhập_Load(object sender, EventArgs e)
        {
            txtTTK.Focus();
        }

        private void tsmback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Người_sử_dụng nsd= new Người_sử_dụng();
            nsd.ShowDialog();
        }
    }
}

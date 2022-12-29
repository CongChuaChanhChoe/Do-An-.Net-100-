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
    public partial class Chức_năng_nhân_viên : Form
    {
        public Chức_năng_nhân_viên()
        {
            InitializeComponent();
        }

        private void tsmQLSach_Click(object sender, EventArgs e)
        {
            frmQLBS QLS = new frmQLBS();
            QLS.Show();
        }

        private void tsmHDBH_Click(object sender, EventArgs e)
        {
            Don_Ban_Hang DBH = new Don_Ban_Hang();
            DBH.Show();
        }

        private void tsmHDan_Click(object sender, EventArgs e)
        {
            Hướng_dẫn hdan = new Hướng_dẫn();
            hdan.Show();
        }
    }
}

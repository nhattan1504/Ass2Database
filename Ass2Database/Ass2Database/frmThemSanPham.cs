using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2Database
{
    public partial class frmThemSanPham : Form
    {
        public delegate void sendInfo(string masanpham, string tensanpham, string xuatxu, long gianiemyet, string loaisanpham);
        public event sendInfo SendInfoEvent;
        public frmThemSanPham()
        {
            InitializeComponent();
            //btnHuy.Click += btnHuy_Click;
            //btnThem.Click += btnHoantat_Click;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn co muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            if (txtMasanpham.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!");
            }
            else if (txtTensanpham.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
            }
            else if (txtXuatxu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xuất xứ của sản phẩm!");
            }
            else if (txtGianiemyet.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm!");
            }
            else if (txtLoaisanpham.Text=="")
            {
                MessageBox.Show("Vui lòng nhập loại sản phẩm!");
            }
            else
            {
                string masanpham = txtMasanpham.Text;
                string tensanpham = txtTensanpham.Text;
                string xuatxu = txtXuatxu.Text;
                long gianiemyet =Int32.Parse(txtGianiemyet.Text);
                string loaisanpham = txtLoaisanpham.Text;
                if (SendInfoEvent!=null)
                {
                    SendInfoEvent(masanpham, tensanpham, xuatxu, gianiemyet, loaisanpham);
                    this.Close();
                }
            }
               
        }
    }
}

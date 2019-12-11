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
    public partial class frmMainInterface : Form
    {
        
        public frmMainInterface()
        {
            InitializeComponent();
            lvChucNang.Items.Clear();
            ListViewItem item1 = new ListViewItem("Thêm thông tin đối tác, sản phẩm");
            item1.SubItems.Add("Dũng (đối tác)");
            ListViewItem item2 = new ListViewItem("Xuất tên sản phẩm đã bán");
            item2.SubItems.Add("Dũng");
            ListViewItem item3 = new ListViewItem("Xuất thông tin khách hàng có >= n đơn hàng");
            item3.SubItems.Add("Dũng");
            ListViewItem item4 = new ListViewItem("Xuất thông tin tất cả đối tác bán hàng");
            item4.SubItems.Add("Dũng");
            ListViewItem item5 = new ListViewItem("Thêm đơn hàng");
            item5.SubItems.Add("Đăng Dũng");
            ListViewItem item6 = new ListViewItem("Nhập địa chỉ xuất thông tin KH ở đó");
            item6.SubItems.Add("Đăng Dũng");
            ListViewItem item7 = new ListViewItem("Nhập địa chỉ xuất ra tổng tiền mà tất cả KH ở đó đã mua");
            item7.SubItems.Add("Đăng Dũng");
            ListViewItem item8 = new ListViewItem("Xem thông tin tất cả đơn hàng");
            item8.SubItems.Add("Đăng Dũng");
            ListViewItem item9 = new ListViewItem("Thêm khách hàng");
            item9.SubItems.Add("Trung Tính");
            lvChucNang.Items.Add(item1);
            lvChucNang.Items.Add(item2);
            lvChucNang.Items.Add(item3);
            lvChucNang.Items.Add(item4);
            lvChucNang.Items.Add(item5);
            lvChucNang.Items.Add(item6);
            lvChucNang.Items.Add(item7);
            lvChucNang.Items.Add(item8);
            lvChucNang.Items.Add(item9);
        }

        private void lvChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string getFunction = null;
            if(lvChucNang.SelectedItems.Count==1)
            {
                getFunction = lvChucNang.SelectedItems[0].SubItems[0].Text;
            }
            else if(lvChucNang.SelectedItems.Count==0)
            {
                MessageBox.Show("Bạn chưa chọn chức năng!");
                return; 
            }
            else
            {
                MessageBox.Show("Lựa chọn của bạn không hợp lệ!");
                return;
            }
            if (getFunction!=null)
            {
                if (getFunction== "Thêm thông tin đối tác, sản phẩm")
                {
                    frmThemDoiTacSanPham frmActive = new frmThemDoiTacSanPham();
                    frmActive.ShowDialog();
                }
                else if (getFunction == "Xuất tên sản phẩm đã bán")
                {
                    frmGetNameProduct frmGetName = new frmGetNameProduct(); 
                    frmGetName.ShowDialog();
                }
                else if (getFunction== "Xuất thông tin khách hàng có >= n đơn hàng")
                {
                    frmThongTinKhachHang frmInfo = new frmThongTinKhachHang();
                    frmInfo.ShowDialog();
                }
                else if (getFunction== "Xuất thông tin tất cả đối tác bán hàng")
                {
                    frmThongTinDoiTac frmDoiTac = new frmThongTinDoiTac();
                    frmDoiTac.ShowDialog();
                }
                else if (getFunction== "Thêm đơn hàng")
                {
                    frmThemDonHang frmthemDonHang = new frmThemDonHang();
                    frmthemDonHang.ShowDialog();
                }
                else if (getFunction == "Nhập địa chỉ xuất thông tin KH ở đó")
                {
                    frmCau3aAss frmcau3aAss = new frmCau3aAss();
                    frmcau3aAss.ShowDialog();
                }
                else if (getFunction== "Nhập địa chỉ xuất ra tổng tiền mà tất cả KH ở đó đã mua")
                {
                    frmCau3bAss frmcau3bAss = new frmCau3bAss();
                    frmcau3bAss.ShowDialog();
                }
                else if (getFunction== "Xem thông tin tất cả đơn hàng")
                {
                    frmTatCaDonHang frmtatcaDonHang = new frmTatCaDonHang();
                    frmtatcaDonHang.ShowDialog();
                }
                else if (getFunction == "Thêm khách hàng")
                {
                    frmTh frmtatcaDonHang = new frmTatCaDonHang();
                    frmtatcaDonHang.ShowDialog();
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

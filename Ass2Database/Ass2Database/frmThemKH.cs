using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2Database
{
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemkhachhang_Click(object sender, EventArgs e)
        {
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số khách hàng!");
            }
            else if (txtHoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ Email!");
            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
            }
            else if (txtSodienthoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
            }
            else if (txtGioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giới tính!");
            }
            else
            {
                SqlConnection conn = null;
                string strConn = "Data Source=DESKTOP-191OR3Q\\MSSQLSERVER01;Initial Catalog=Store;Integrated Security=True";
                try
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection(strConn);
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "themKH";
                    sqlCommand.Connection = conn;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

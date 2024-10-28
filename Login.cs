using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassword.Text == "1")
            {
                fMain fMain = new fMain();
                this.Hide();
                fMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

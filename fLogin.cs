using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCafe.DAO;

namespace QuanLiCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //nhấn vào nút oke mới đc thoát 
            if (MessageBox.Show("bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPass.Text;
            if (Login(username, password))
            {
                fTableManeger f = new fTableManeger();
                // ẩn form đăng nhập
                this.Hide();
                //làm việc trên form mới khi xong ròi thoát hiện form cũ
                f.ShowDialog();
                //form cũ
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên taì khoản và mật khẩu!");
            }
        }
        bool Login(String userName,string passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

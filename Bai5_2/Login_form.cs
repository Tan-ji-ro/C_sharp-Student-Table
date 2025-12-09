using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Login_form : Form
    {
        readonly String Sys_user = "Admin", Sys_pass = "12345";
        public Login_form()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            String Username = User_box.Text, Password = Pass_box.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                W_label.Text = "Xin hãy nhập tài khoản và mật khẩu";
            }

            if (Username == Sys_user && Password == Sys_pass)
            {
                Main_form mf = new Main_form();
                mf.Show();
                this.Hide();
            }
            else
            {
                W_label.Text = "Tài khoản không hợp lệ";
            }
        }
    }
}

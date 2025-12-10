using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Passchange : Form
    {
        public Passchange()
        {
            InitializeComponent();
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            String cur_pass = Current_passbox.Text, new_pass = New_pass_box.Text, ret = Retype_box.Text;

            if (string.IsNullOrEmpty(cur_pass) || string.IsNullOrEmpty(new_pass) || string.IsNullOrEmpty(ret))
            {
                P_alert.Text = "Xin hãy nhập mật khẩu";
            }

            if (cur_pass == "12345" && new_pass == ret)
            {
                try
                {
                    TextWriter pswrt = new StreamWriter("Password.bak");

                    pswrt.Write("010110011010100100100101010100101001");
                    pswrt.WriteLine("00101010001" + new_pass + "01011010100101001");
                    pswrt.WriteLine("0100101010010101010100110101011101");

                    pswrt.Close();
                    P_alert.Text = "Mật khẩu mới đã lưu";
                } 
                catch (Exception ex) 
                {
                    P_alert.Text = "Có vấn đề khi lưu: " + ex;
                }
            } else
            {
                P_alert.Text = "Thông tin không hợp lệ";
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_form lgn = new Login_form();
            lgn.Show();
        }
    }
}

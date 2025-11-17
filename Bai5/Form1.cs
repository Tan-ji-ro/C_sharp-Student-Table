using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Main_form : Form
    {

        public Main_form()
        {
            InitializeComponent();
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            float w = float.Parse(Length_box.Text), h = float.Parse(Width_box.Text);
            Rectangle rt1 = new Rectangle(w, h);
            float perimeter = rt1.Perimeter(), area = rt1.Area();

            Res_label_1.Text = "Chu vi của hình chữ nhật là: " + perimeter;
            Res_label_2.Text = "Diện tích của hình chữ nhật là: " + area;
        }
    }
}

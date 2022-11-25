using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Ketqua_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_Soa.Text);
            double b = double.Parse(txt_Sob.Text);
            if (rbtn_pt1.Checked == true)
            {
                txt_Ketqua.Text = $"Phương trình có nghiệm: {-b / a}";
                return;
            }

            if (rbtn_pt2.Checked == true)
            {
                double c = double.Parse(txt_Soc.Text);
                double delta = b * b - 4 * a * c;
                if (delta> 0)
                {
                    txt_Ketqua.Text =
                        $"Phương trình có 2 nghiệm: {(-b + Math.Sqrt(delta)) / 2 * a} và {(-b - Math.Sqrt(delta)) / 2 * a}";
                }
                else if (delta == 0)
                {
                    txt_Ketqua.Text = $"Phương trình có nghiệm kép: {-b / 2 * a}";
                }
                else
                    txt_Ketqua.Text = "Phương trình vô nghiệm";
            }
        }

        private void rbtn_pt1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_pt1.Checked == true)
            {
                txt_Soc.Enabled = false;
                return;
            }
            txt_Soc.Enabled = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

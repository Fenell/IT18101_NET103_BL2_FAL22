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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_Soa.Text);
            int b = int.Parse(txt_Sob.Text);
            if (rbtn_Ucln.Checked == true)
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                txt_Ketqua.Text = a.ToString();
                return;
            }

            if (rbtn_Bcnn.Checked == true)
            {
                int step;
                if (a > b) step = a;
                else step = b;
                for (int i = step; i < a * b; i += step)
                {
                    if (i % a == 0 && i % b == 0)
                    {
                        txt_Ketqua.Text = i.ToString();
                        return;
                    }
                }
            }
        }

        private void btn_Boqua_Click(object sender, EventArgs e)
        {
            txt_Ketqua.Text = "";
            txt_Soa.Text = "";
            txt_Sob.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

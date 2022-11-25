using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_4_GROUPBOX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int i = 0;
        private void btn_AddControl_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Button btn = new Button()
            {
                Text = i.ToString(),
                Location = new Point(rd.Next(pn1.Width), rd.Next(pn1.Height))
            };
            //add button vào panel
            fpn1.Controls.Add(btn);
            //tăng biến đếm 1
            i++;
        }

        void Btn_Click(object? sender, EventArgs e)
        {
            var brn = sender as Button;
            //MessageBox.Show(btn?.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pn1.Enabled = !pn1.Enabled;
            fpn1.Enabled = false;
        }
    }
}

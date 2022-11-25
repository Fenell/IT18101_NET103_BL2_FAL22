using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GioiThieu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userName = textBox1.Text;
            var pass = textBox2.Text;
            if (userName == "dat" && pass == "dat")
            {
                var mainForm = new Form1();
                this.Hide();
                mainForm.Show();
            }
        }
    }
}

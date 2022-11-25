using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Menu_Strip : Form
    {
        public Menu_Strip()
        {
            InitializeComponent();
        }

        private void mstripCn1_Click(object sender, EventArgs e)
        {
            Tinh_Tien_Dien form1 = new Tinh_Tien_Dien();
            form1.ShowDialog();
        }

        private void mstripCn2_Click(object sender, EventArgs e)
        {
            Danh_Sach_The_Thao form2 = new Danh_Sach_The_Thao();
            form2.ShowDialog();
        }

        private void mstripCn3_Click(object sender, EventArgs e)
        {
            Chuyen_Du_Lieu form3 = new Chuyen_Du_Lieu();
            form3.ShowDialog();
        }
    }
}

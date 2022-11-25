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
    public partial class Chuyen_Du_Lieu : Form
    {
        public Chuyen_Du_Lieu()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Form4 frm = new Form4(txtContent.Text);
            Chuyen_Du_Lieu_2 frm = new Chuyen_Du_Lieu_2();
            frm.Show();
        }
    }
}

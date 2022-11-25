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
    public partial class Chuyen_Du_Lieu_2 : Form
    {
        public Chuyen_Du_Lieu frm3;
        public Chuyen_Du_Lieu_2()
        {
            InitializeComponent();
            frm3 = new Chuyen_Du_Lieu();
            frm3.txtContent.Text = label1.Text;
        }

        //public Form4(string strTextBox)
        //{
        //    InitializeComponent();
        //    label1.Text = strTextBox;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAINING_3.Utilities;

namespace TRAINING_3.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            lbl_NameAcc.Text = Utility.Account.Acc;
            lbl_TypeAcc.Text = Utility.Role.Role1;
            if (lbl_TypeAcc.Text != "Giám đốc") btn_QLNhanVien.Enabled = false;
        }

        
    }
}

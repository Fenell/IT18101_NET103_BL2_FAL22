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
    public partial class Danh_Sach_The_Thao : Form
    {
        private List<string> lstNames;
        private List<string> lstSports;
        public Danh_Sach_The_Thao()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            txt_Time.Text = DateTime.Now.ToShortDateString();
            txt_Time2.Text = DateTime.Now.ToShortTimeString();
            lstNames = new List<string>() { "Nam", "Quốc", "Sơn", "Hà", "Đế" };
            lstSports = new List<string>() { "Bóng đá", "Bóng bàn", "Nhảy dù", "Bập bênh" };
            cbb_Name.DataSource = lstNames;
            foreach (var sport in lstSports)
            {
                lstb_Check.Items.Add(sport);
            }
            lstb_Checked.Items.Clear();
            richTextBox1.Text = "";
        }

        

        private void btn_CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstb_Check.Items.Count; i++)
            {
                lstb_Checked.Items.Add(lstb_Check.Items[i]);
            }

            for (int i = lstb_Check.Items.Count -1; i >= 0; i--)
            {
                lstb_Check.Items.RemoveAt(i);
            }
            
        }

        private void btn_CheckOne_Click(object sender, EventArgs e)
        {
            lstb_Checked.Items.Add(lstb_Check.SelectedItem);
            lstb_Check.Items.RemoveAt(lstb_Check.SelectedIndex);
        }

        private void btn_UnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstb_Checked.Items.Count; i++)
            {
                lstb_Check.Items.Add(lstb_Checked.Items[i]);
            }
            for (int i = lstb_Checked.Items.Count -1; i >= 0; i--)
            {
                lstb_Checked.Items.RemoveAt(i);
            }
        }

        private void btn_UnCheckOne_Click(object sender, EventArgs e)
        {
            lstb_Check.Items.Add(lstb_Checked.SelectedItem);
            lstb_Checked.Items.RemoveAt(lstb_Checked.SelectedIndex);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(cbb_Name.Text);
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText($"{txt_Time.Text}  {txt_Time2.Text} \n");
            richTextBox1.AppendText("Môn chọn: \n");
            foreach (var item in lstb_Checked.Items)
            {
                richTextBox1.AppendText($"{item.ToString()}, ");
            }
        }

        private void bnt_Reset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}

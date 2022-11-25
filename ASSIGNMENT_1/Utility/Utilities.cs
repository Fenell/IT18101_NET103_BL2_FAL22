namespace ASSIGNMENT_1.Utility
{
    internal class Utilities
    {
        public static string EmptyIfNull(string s)
        {
            return string.IsNullOrEmpty(s) ? "" : s;
        }

        public static decimal? NullIfEmpty(string s)
        {
            return string.IsNullOrWhiteSpace(s) ? null : Convert.ToDecimal(s);
        }

        public static double ZeroIfNull(string s)
        {
            return string.IsNullOrEmpty(s) ? 0 : Convert.ToDouble(s);
        }

        public static void ResetForm(Form frm)
        {
            foreach (Control crt in frm.Controls)
            {
                ResetControl(crt);
            }
        }

        private static void ResetControl(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control crt in control.Controls)
                {
                    ResetControl(crt);
                }
            }

            switch (control.GetType().Name)
            {
                case "TextBox":
                    control.Text = "";
                    control.Enabled = true;
                    break;
                case "RadioButton":
                    RadioButton rbtn = new RadioButton();
                    rbtn.Checked = false;
                    break;
                case "PictureBox":
                    PictureBox pimg = new PictureBox();
                    pimg.Image = null;
                    break;
            }
        }
    }
}

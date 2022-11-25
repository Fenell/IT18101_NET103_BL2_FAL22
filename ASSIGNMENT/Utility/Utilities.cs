namespace ASSIGNMENT.Utility
{
    internal class Utilities
    {
        public static void ResetAllControl(Form frm)
        {
            foreach (Control frmControl in frm.Controls)
            {
                ResetControl(frmControl);
            }
        }

        private static void ResetControl(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control crt in control.Controls)
                {
                    ResetControl(control);
                }
            }

            switch (control.GetType().Name)
            {
                case "TextBox":
                    control.Text = "";
                    control.Enabled = true;
                    break;
                case "RadioButton":
                    RadioButton rbtn = control as RadioButton;
                    rbtn.Checked = false;
                    break;
            }

        }
    }
}

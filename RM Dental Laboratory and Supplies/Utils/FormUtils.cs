using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Utils
{
    public class FormUtils
    {
        public static void CloseOnEscapeKeyDown(Form form)
        {
            form.KeyPreview = true; // Ensure the form receives key events before its controls
            form.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    ((Form)sender).Close(); // Close the form
                }
            };
        }

        public static void PerformClickOnEnterKey(Form form, Button button)
        {
            form.KeyPreview = true; // Ensure the form receives key events before its controls
            form.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button.PerformClick(); // Simulate a button click
                }
            };
        }
    }
}

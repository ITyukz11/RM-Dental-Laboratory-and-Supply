using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Reflection;
using System.Windows.Forms;

namespace RM_Dental_Laboratory_and_Supplies.Utils
{
    public class DoubleBuffer
    {
    public void SetDoubleBuffer(System.Windows.Forms.Control ctl, bool DoubleBuffered)
        {
			try
			{
				typeof(System.Windows.Forms.Control).InvokeMember("DoubleBuffered",
					BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
					null, ctl, new object[] { DoubleBuffered });
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }
    }
}

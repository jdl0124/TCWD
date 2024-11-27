using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcsys.modules
{
	internal class changeIcon
	{
		public static void SetApplicationIcon(string iconPath, Form mainForm)
		{
			try
			{
				// Load the icon from the specified path
				Icon newIcon = new Icon(iconPath);

				// Set the icon for the main form
				mainForm.Icon = newIcon;

				// Set the icon for all open forms in the application
				foreach (Form frm in Application.OpenForms)
				{
					frm.Icon = newIcon;
				}

				//MessageBox.Show("Icon changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				// Handle any errors (e.g., if the icon file does not exist)
				MessageBox.Show($"Error changing icon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

using DesktopAPP.View.City;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View
{
    public partial class MainForm : Form
    {
        private CityPanel cityPanel;
        public MainForm()
        {
            InitializeComponent();
            cityPanel = new CityPanel();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CityTabPage customTabPage = new CityTabPage("Tab Personalizada");
            //tabControl.TabPages.Add(customTabPage);
            HideAllPanels();
            
            pnlContainer.Controls.Add(cityPanel);

        }

        private void HideAllPanels()
        {
            foreach (Control control in pnlContainer.Controls)
            {
                if (control is Panel)
                {
                    pnlContainer.Controls.Remove(control);
                    //control.Dispose();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

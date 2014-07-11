using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GetMoneyGame_Installer
{
    public partial class InstallXNA : UserControl
    {
        public InstallXNA()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Start XNA installer
            Process.Start("C:\\Temp\\Installer_Freddy\\ExtractedFiles" + "\\XNA 4_redist.msi");

            // Change slide
            Form1.changeSlide(3);
        }
    }
}

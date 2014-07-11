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
    public partial class Finish : UserControl
    {
        public Finish()
        {
            InitializeComponent();
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ToolBox.appShortcutToDesktop("GetMoneyGame", DesktopPath + "\\GetMoneyGame\\Get Money Game.exe");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Process.Start(DesktopPath + "\\GetMoneyGame\\Get Money Game.exe");
            Form1.closeApp();
        }
    }
}

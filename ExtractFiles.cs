using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.IO.Compression;
// Also added the reference to system.io.compression.filesystem to get zip support
using System.Diagnostics;

namespace GetMoneyGame_Installer
{
    public partial class ExtractFiles : UserControl
    {
        public ExtractFiles()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            progressBar1.Maximum = 100;
        }

        private void btnNext_Click(object sender, EventArgs e) 
        {
            progressBar1.Visible = true;
            // Only install once
            btnNext.Enabled = false;
            progressBar1.Value = 10;

            // Write zip file to temp folder
            string zipFilePath = "C:\\Temp\\GetMoneyGame_Installer\\Game Files.zip";
            if (!Directory.Exists("C:\\Temp\\GetMoneyGame_Installer")) Directory.CreateDirectory("C:\\Temp\\GetMoneyGame_Installer");
            Assembly _assembly = Assembly.GetExecutingAssembly();
            progressBar1.Value = 20;
            using (var fileStream = File.Create(zipFilePath))
            {
                _assembly.GetManifestResourceStream("GetMoneyGame_Installer.Game Files.zip").CopyTo(fileStream);
            }
            progressBar1.Value = 30;
            // Unzip
            string extractPath = "C:\\Temp\\GetMoneyGame_Installer\\ExtractedFiles";
            if (!Directory.Exists(extractPath)) System.IO.Compression.ZipFile.ExtractToDirectory(zipFilePath, extractPath);
            progressBar1.Value = 50;
            // Get desktop path for current user
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(!Directory.Exists(DesktopPath + "\\GetMoneyGame")) ToolBox.DirectoryCopy(extractPath + "\\Debug", DesktopPath + "\\GetMoneyGame", true);
            progressBar1.Value = 70;
            // Next slide
            Form1.changeSlide(2);

        }
    }
}

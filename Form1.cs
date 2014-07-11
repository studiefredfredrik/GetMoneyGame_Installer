using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Reflection;

namespace GetMoneyGame_Installer
{
    public partial class Form1 : Form
    {
        public static Form1 currentFrm;
        public Form1()
        {
            InitializeComponent();
            currentFrm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the image on the side on the installer
            Assembly _assembly = Assembly.GetExecutingAssembly();
            Image setupImg;
            setupImg = Image.FromStream(_assembly.GetManifestResourceStream("GetMoneyGame_Installer.GMG-logo.png"));
            pictureBox1.Image = setupImg;
            
            ExtractFiles extractFilesUC = new ExtractFiles();
            extractFilesUC.Dock = DockStyle.Fill;
            //this.Controls.Add(extractFilesUC);
            panel1.Controls.Add(extractFilesUC);
        }
        public static void changeSlide(int slide)
        {
            if(slide == 2)
            {
                InstallXNA installUC = new InstallXNA();
                installUC.Dock = DockStyle.Fill;
                //currentFrm.Controls.Clear();
                //currentFrm.Controls.Add(installUC);
                currentFrm.panel1.Controls.Clear();
                currentFrm.panel1.Controls.Add(installUC);
            }
            if(slide == 3)
            {
                Finish finishUC = new Finish();
                finishUC.Dock = DockStyle.Fill;
                //currentFrm.Controls.Clear();
                //currentFrm.Controls.Add(finishUC);
                currentFrm.panel1.Controls.Clear();
                currentFrm.panel1.Controls.Add(finishUC);
            }
        }
        public static void closeApp()
        {
            currentFrm.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //System.Diagnostics.Process.Start

namespace Dev_Launcher
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\JetBrains\IntelliJ IDEA Community Edition 2022.1.2\bin\idea64.exe");
        }

        private void picCmd_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\WINDOWS\system32\cmd.exe"); //use '@' to infront of local dir. or use '\\' for each dir.
        }

        private void picGit_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://github.com/yarzardhiyit");
        }

        private void picStackoverflow_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://stackoverflow.com/");
        }

        private void picVscode_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\yarza\AppData\Local\Programs\Microsoft VS Code\code.exe");
        }

        private void picVscommunity_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe");
        }
    }
}

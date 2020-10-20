using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SwiftDown.Menus
{
    public partial class AllApps_Page_3 : Form
    {
        public AllApps_Page_3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string discord = @"https://discord.com/api/download?platform=win";
            Process.Start(discord);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string spotify = @"https://www.spotify.com/download/windows/";
            Process.Start(spotify);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string obs = @"https://cdn-fastly.obsproject.com/downloads/OBS-Studio-26.0-Full-Installer-x64.exe";
            Process.Start(obs);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string slobs = @"https://streamlabs.com/slobs/download";
            Process.Start(slobs);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mclauncher = @"https://launcher.mojang.com/download/MinecraftInstaller.msi";
            Process.Start(mclauncher);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form2 = new Form3();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string chromium = @"https://download-chromium.appspot.com/dl/Win_x64?type=snapshots";
            Process.Start(chromium);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string whatsapp = @"https://web.whatsapp.com/desktop/windows/release/x64/WhatsAppSetup.exe";
            Process.Start(whatsapp);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string nordvpn = @"https://downloads.nordcdn.com/apps/windows/10/NordVPN/latest/NordVPNSetup.exe";
            Process.Start(nordvpn);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string githubdesktop = @"https://central.github.com/deployments/desktop/desktop/latest/win32";
            Process.Start(githubdesktop);
        }
    }
}

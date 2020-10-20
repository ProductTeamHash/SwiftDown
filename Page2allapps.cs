using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftDown.Menus
{
    public partial class Page2allapps : Form
    {
        public Page2allapps()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Steam = @"https://steamcdn-a.akamaihd.net/client/installer/SteamSetup.exe";
            Process.Start(Steam);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string origin = @"https://www.dm.origin.com/download";
            Process.Start(origin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string epicgames = @"https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi?trackingId=5f1a85b4388441a294f1caf7f7153f16";
            Process.Start(epicgames);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Valorant = @"https://valorant.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.live.eu.exe";
            Process.Start(Valorant);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string osu = @"https://osu.ppy.sh/home/download";
            Process.Start(osu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string osulazer = @"https://github.com/ppy/osu/releases/download/2020.1002.0/install.exe";
            Process.Start(osulazer);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string discord = @"https://discord.com/api/download?platform=win";
            Process.Start(discord);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string spotify = @"https://www.spotify.com/us/download/windows/";
            Process.Start(spotify);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string obs = @"https://cdn-fastly.obsproject.com/downloads/OBS-Studio-26.0-Full-Installer-x64.exe";
            Process.Start(obs);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string obs = @"https://cdn-fastly.obsproject.com/downloads/OBS-Studio-26.0-Full-Installer-x64.exe";
            Process.Start(obs);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new page3allappps();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}

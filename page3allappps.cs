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
    public partial class page3allappps : Form
    {
        public page3allappps()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Page2allapps();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new allappspage4();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string slobs = @"https://streamlabs.com/slobs/download";
            Process.Start(slobs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string minecraft = @"https://launcher.mojang.com/download/MinecraftInstaller.msi";
            Process.Start(minecraft);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string chromium = @"https://download-chromium.appspot.com/dl/Win_x64?type=snapshots";
            Process.Start(chromium);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string whatsapp = @"https://web.whatsapp.com/desktop/windows/release/x64/WhatsAppSetup.exe";
            Process.Start(whatsapp);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nordvpn = @"https://downloads.nordcdn.com/apps/windows/10/NordVPN/latest/NordVPNSetup.exe";
            Process.Start(nordvpn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string github = @"https://central.github.com/deployments/desktop/desktop/latest/win32";
            Process.Start(github);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string unityhub = @"https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe";
            Process.Start(unityhub);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string hitfilmexpress = @"https://installers.fxhome.com/hitfilm-express/HitFilmExpress_x64_15.1.10413.07203.msi";
            Process.Start(hitfilmexpress);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string adobecc = @"https://creativecloud.adobe.com/apps/download/creative-cloud?locale=en&x-product=CCHome%2F1.0&guid=41752743-1276-4c69-9de2-667fc32b8dca&x-location=Landing&comVer=Trailhead";
            Process.Start(adobecc);
        }
    }
}

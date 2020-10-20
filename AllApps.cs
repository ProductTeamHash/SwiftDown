using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SwiftDown.Menus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chrome = @"https://github.com/ProductTeamHash/SwiftDown-Apps/releases/download/N%2FA/ChromeSetup.exe";
            Process.Start(chrome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vmbox = @"https://download.virtualbox.org/virtualbox/6.1.14/VirtualBox-6.1.14-140239-Win.exe";
            Process.Start(vmbox);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string torbrowser = @"https://www.torproject.org/dist/torbrowser/10.0/torbrowser-install-win64-10.0_en-US.exe";
            Process.Start(torbrowser);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string firefox = @"https://www.mozilla.org/en-GB/firefox/download/thanks/";
            Process.Start(firefox);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string opera = @"https://www.opera.com/computer/thanks?ni=stable&os=windows";
            Process.Start(opera);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string operagx = @"https://www.opera.com/computer/thanks?ni=eapgx&os=windows";
            Process.Start(operagx);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string kali = @"https://cdimage.kali.org/kali-2020.3/kali-linux-2020.3-live-amd64.iso";
            Process.Start(kali);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ubuntu = @"https://ubuntu.com/download/desktop/thank-you?version=20.04.1&architecture=amd64";
            Process.Start(ubuntu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string centos = @"http://isoredirect.centos.org/centos/8/isos/x86_64/";
            Process.Start(centos);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Page2allapps();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}

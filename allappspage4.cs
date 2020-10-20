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
    public partial class allappspage4 : Form
    {
        public allappspage4()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string krita = @"https://download.kde.org/stable/krita/4.3.0/krita-x64-4.3.0-setup.exe";
            Process.Start(krita);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sidequest = @"https://github.com/SideQuestVR/SideQuest/releases/download/v0.10.14/SideQuest-Setup-0.10.14-x64-win.exe";
            Process.Start(sidequest);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string twitch = @"https://desktop.twitchsvc.net/installer/windows/TwitchSetup.exe";
            Process.Start(twitch);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string wireshark = @"https://1.eu.dl.wireshark.org/win64/Wireshark-win64-3.2.7.exe";
            Process.Start(wireshark);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new page3allappps();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string botnett = @"https://github.com/ProductTeamHash/SwiftDown-Apps/releases/download/0.1/botnett.exe";
            Process.Start(botnett);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string winaerotweak = @"https://winaero.com/downloads/winaerotweaker.zip";
            Process.Start(winaerotweak);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}

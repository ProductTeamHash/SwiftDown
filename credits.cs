using System.Diagnostics;
using System.Windows.Forms;

namespace SwiftDown.Menus
{
    public partial class credits : Form
    {
        public credits()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string youtubeb = @"https://www.youtube.com/channel/UCEeRDX2dBot2uGBqcHVGCxQ?view_as=subscriber";
            Process.Start(youtubeb);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            string discordb = @"https://discord.gg/UCXutUT";
            Process.Start(discordb);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string githubb = @"https://github.com/XaSeCRXZY";
            Process.Start(githubb);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            string twitterb = @"https://twitter.com/xasecrxzy";
            Process.Start(twitterb);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}

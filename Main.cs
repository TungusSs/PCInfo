using PCInfos.UIs;
using System;
using System.Windows.Forms;

namespace PCInfos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            user.Text = CollectSystemInfo.GetUserNameAndPcName();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainInfo mi = new MainInfo();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ethernet mi = new Ethernet();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BiosUI mi = new BiosUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            TempUI mi = new TempUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DiskUI mi = new DiskUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OperationSystemUI mi = new OperationSystemUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PrintersUI mi = new PrintersUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VideocardUI mi = new VideocardUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cpuUI mi = new cpuUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SoundCard mi = new SoundCard();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SettingsUI st = new SettingsUI();
            flowLayoutPanel1.Controls.Add(st);
            st.BringToFront();
        }
    }
}

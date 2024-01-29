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
            flowLayoutPanel1.Controls.Clear();
            MainInfo mi = new MainInfo();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Ethernet mi = new Ethernet();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            BiosUI mi = new BiosUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            TempUI mi = new TempUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DiskUI mi = new DiskUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            OperationSystemUI mi = new OperationSystemUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            PrintersUI mi = new PrintersUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            VideocardUI mi = new VideocardUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cpuUI mi = new cpuUI();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SoundCard mi = new SoundCard();
            flowLayoutPanel1.Controls.Add(mi);
            mi.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SettingsUI st = new SettingsUI();
            flowLayoutPanel1.Controls.Add(st);
            st.BringToFront();
        }
    }
}

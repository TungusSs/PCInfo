using PCInfos.UIs;
using System.Windows.Forms;

namespace PCInfos
{
    public partial class ModernForm : Form
    {
        public ModernForm()
        {
            InitializeComponent();
            loadTheme();
            user.Text = CollectSystemInfo.GetUserNameAndPcName();
        }

        private void loadTheme()
        {
            bool isDarkTheme = Theme.IsDarkTheme();
            swithTheme.Checked = isDarkTheme;
            Theme theme = new Theme(isDarkTheme);
            theme.ApplyTheme(this);
            Theme.SaveTheme(isDarkTheme); 
        }
        
        private void togleTheme(bool dark)
        {
            Theme theme = new Theme(dark);
            theme.ApplyTheme(this);
            Theme.SaveTheme(dark); 
        }

        private void swithTheme_CheckedChanged(object sender, System.EventArgs e)
        {
            togleTheme(swithTheme.Checked);
        }

        private void panelNetworkCardBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            Ethernet mi = new Ethernet();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelBiosBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            BiosUI mi = new BiosUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelmainBtnOn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            MainInfo mi = new MainInfo();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelTempBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            TempUI mi = new TempUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelDiskBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            DiskUI mi = new DiskUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelOSBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            OperationSystemUI mi = new OperationSystemUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelPrintersBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            PrintersUI mi = new PrintersUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelGraphCardBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            VideocardUI mi = new VideocardUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelCPUBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            cpuUI mi = new cpuUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelSoundCardBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            SoundCard mi = new SoundCard();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }

        private void panelSettingsBtn_Click(object sender, System.EventArgs e)
        {
            renderP.Controls.Clear();
            SettingsUI mi = new SettingsUI();
            renderP.Controls.Add(mi);
            mi.BringToFront();
            loadTheme();
        }
    }
}

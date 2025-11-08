using Clowned_OpenSource.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clowned_OpenSource
{
    public partial class MainPanel : Form
    {
        protected Form activeform = null;
        private void OpenOtherForm(Form NameForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = NameForm;
            NameForm.TopLevel = false;
            NameForm.FormBorderStyle = FormBorderStyle.None;
            NameForm.Dock = DockStyle.Fill;
            SelectGamesPanel.Invoke((MethodInvoker)delegate ()
            {
                SelectGamesPanel.Controls.Add(NameForm);
            });
            SelectGamesPanel.Tag = NameForm;
            NameForm.BringToFront();
            NameForm.Show();
        }

        public MainPanel()
        {
            InitializeComponent();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            OpenOtherForm(new HomePanel());
        }

        private void SelectHomeButton_Click(object sender, EventArgs e)
        {
            OpenOtherForm(new HomePanel());
        }

        private void SelectSSOButton_Click(object sender, EventArgs e)
        {
            if (HelpMisc.mem.OpenProcess("SSOClient"))
            {
                OpenOtherForm(new Games.SSOPanel());
            }
            else
            {
                MessageBox.Show("Star Stable Online is not running. Please start the game first.", "Game Not Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectAOButton_Click(object sender, EventArgs e)
        {
            if (HelpMisc.mem.OpenProcess("Alicia"))
            {
                OpenOtherForm(new Games.AOPanel());
            }
            else
            {
                MessageBox.Show("Alicia Online is not running. Please start the game first.", "Game Not Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectETS2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Euro Truck Simulator 2 support is coming soon!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectGIButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Genshin Impact support is coming soon!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectSettingsButton_Click(object sender, EventArgs e)
        {
            OpenOtherForm(new SettingsPanel());
        }
    }
}

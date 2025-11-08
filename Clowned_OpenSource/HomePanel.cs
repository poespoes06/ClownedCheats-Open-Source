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
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to ClownedCheats!";
            welcomeLabel.Font = new Font(welcomeLabel.Font.FontFamily, 16, FontStyle.Bold);
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(50, 50);
            this.Controls.Add(welcomeLabel);

            Label instructionLabel = new Label();
            instructionLabel.Text = "Select a game from the menu on the left to begin.";
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(50, 90);
            this.Controls.Add(instructionLabel);
        }
    }
}

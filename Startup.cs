using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumble
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void startupTime(object sender, EventArgs e)
        {
            splashTimer.Stop();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }
    }
}

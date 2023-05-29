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
    public partial class Main : Form
    {
        Random r = new Random();
        List<string> messages = new List<string>();
        public Main()
        {
            InitializeComponent();
            messages.Add("Borna's Game Rumble Vol. 2 - Now in 2.5D!");
            messages.Add("Borna's Game Rumble Vol. 2 - Also try Vol. 1");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.Text = messages[r.Next(0,2)];
            Startup start = new Startup();
            start.MdiParent = this;
            start.Show();
            start.Dock = DockStyle.Fill;
        }
    }
}

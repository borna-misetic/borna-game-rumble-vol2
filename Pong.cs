using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumble
{
    public partial class Pong : Form
    {
        const int playerSpeed = 10;
        int topMax, bottomMax;
        bool playerUp = false, playerDown = false;
        public Pong()
        {
            InitializeComponent();
            topMax = 0;
            bottomMax = ClientSize.Height - Player.Height;
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) playerUp = false;
            if (e.KeyCode == Keys.Down) playerDown = false;
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up ) playerUp = true;
            if (e.KeyCode == Keys.Down) playerDown = true;
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            playerScore.Text = bottomMax.ToString() + " / " + Player.Top.ToString();
            if (playerUp && Player.Top > topMax) Player.Top -= playerSpeed;
            if (playerDown && Player.Top < bottomMax) Player.Top += playerSpeed;
        }
    }
}

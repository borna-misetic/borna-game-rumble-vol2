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
    public partial class GameSelect : Form
    {
        public GameSelect()
        {
            InitializeComponent();
        }

        private void btnGameOne_Click(object sender, EventArgs e)
        {
            Pong pong = new Pong();
            pong.ShowDialog();
        }

        private void btnGameTwo_Click(object sender, EventArgs e)
        {
            Frogger frogger = new Frogger();
            frogger.ShowDialog();
        }

        private void btnGameThree_Click(object sender, EventArgs e)
        {
            FlappyBird flappyBird = new FlappyBird();
            flappyBird.ShowDialog();
        }

        private void btnGameFour_Click(object sender, EventArgs e)
        {
            Snake snake = new Snake();
            snake.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Game oGame;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            oGame = new Game(pictureBox1,lbPoints, timer1);

            timer1.Enabled= true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!oGame.IsLost)
            {
                oGame.Next();
                oGame.Show();

            }
            else
            {
                timer1.Enabled= false;
                timer1.Interval = 300;

                MessageBox.Show("Has Perdido");

                
            } 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.NumPad8) oGame.ActualDirection = Game.Direction.Up;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.NumPad6) oGame.ActualDirection = Game.Direction.Right;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.NumPad4) oGame.ActualDirection = Game.Direction.Left;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.NumPad2) oGame.ActualDirection = Game.Direction.Down;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

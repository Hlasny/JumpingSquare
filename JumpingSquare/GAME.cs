using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingSquare
{
    public partial class GAME : Form
    {
        private World _world;

        public GAME()
        {
            InitializeComponent();
            this._world = new World(this.pictureBox1.Width, this.pictureBox1.Height);            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this._world.Render(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this._world.Next();
            this.pictureBox1.Refresh();              
        }

        private void GAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Right)
            {
                this._world.MovePRight();
            }

            if (e.KeyCode == Keys.Left)
            {
                this._world.MovePLeft();
            }

            if (e.KeyCode == Keys.Space)
            {
                this._world.JumpP();
            }
        }
    }
}

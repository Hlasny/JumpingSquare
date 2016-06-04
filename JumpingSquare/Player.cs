using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSquare
{
    public class Player
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Vx { get; set; }

        public double Vy { get; set; }

        public void RenderP(Graphics g)
        {
            g.FillRectangle(Brushes.White, (float)(X - this.Width / 2), (float)(Y - this.Height / 2), (float)Width, (float)Height);
        }

        public void MoveP()
        {
            this.X = (this.Vx + this.X);
            this.Y = (this.Vy + this.Y);
        }

        public void CollideP(int width, int height)
        {
            // overeni funkcionality kolize na souradnici x
            if (this.X - this.Width / 2 <= 0)
            {
                this.X += 10;
                HINT h = new HINT();
                h.ShowDialog();
            }

            if (this.X + this.Width / 2 >= width)
            {
                this.X -= 10;
                HINT h = new HINT();
                h.ShowDialog();
            }
        }
    }
}

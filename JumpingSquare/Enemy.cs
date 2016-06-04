using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSquare
{
    public class Enemy
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Vx { get; set; }

        public double Vy { get; set; }

        public void RenderE(Graphics g)
        {
            g.FillRectangle(Brushes.Black, (float)(X - this.Width / 2), (float)(Y - this.Height / 2), (float)Width, (float)Height);
        }

        public void MoveE()
        {
            this.X = (this.Vx + this.X);
            this.Y = (this.Vy + this.Y);
        }

        public void CollideE(int width, int height)
        {
            // kolize na ose x vypada, ze funguje; pri kolizi vyrazne zrychli a zmizi 
            if (this.X - this.Width / 2 <= 0 || this.X + this.Width / 2 >= width)
                this.Vx = -40;

            if (this.Y - this.Height / 2 <= 0 || this.Y + this.Height / 2 >= height)
                this.Vy = -40;
        }
    }
}

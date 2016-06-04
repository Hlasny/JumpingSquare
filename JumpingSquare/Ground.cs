using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSquare
{
    public class Ground
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Vx { get; set; }

        public double Vy { get; set; }

        public void RenderG(Graphics g)
        {
            g.FillRectangle(Brushes.Black, (float)(X - this.Width / 2), (float)(Y - this.Height / 2), (float)Width, (float)Height);
        }

        public void MoveG()
        {
            this.X = (this.Vx + this.X);
            this.Y = (this.Vy + this.Y);
        }

        public void CollideG(int width, int height)
        {
            if (this.X - this.Width <= 0 || this.X + this.Width >= width)
                this.Vx *= -1;

            if (this.Y - this.Height <= 0 || this.Y + this.Height >= height)
                this.Vy *= -1;
        }
    }
}

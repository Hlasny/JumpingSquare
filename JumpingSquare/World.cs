using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingSquare
{
    public class World
    {
        private int _width;
        private int _height;

        private List<Ground> _ground { get; set; }
        private List<Enemy> _enemy { get; set; }
        private Player _player = new Player();

        public World(int width, int height)
        {
            this._width = width;
            this._height = height;

            _ground = new List<Ground>() { new Ground { Height = 30, Width = 1000, X = 0, Y = 448 } };
            _enemy = new List<Enemy>() { new Enemy { Height = 50, Width = 70, X = 420, Y = 150, Vx = 1 } };

            this._player.X = 50;
            this._player.Y = 150;
            this._player.Height = 30;
            this._player.Width = 30;
            
            //this._player.Vx = 2;
        }


        public void Next()
        {
            foreach (Ground item in this._ground)
            {
                item.MoveG();
                item.CollideG(this._width, this._height);
            }

            foreach (Enemy item in this._enemy)
            {
                item.MoveE();
                item.CollideE(this._width, this._height);
            }

            this._player.MoveP();
            this._player.CollideP(this._width, this._height);

        }


        internal void Render(object graphics)
        {
            throw new NotImplementedException();
        }

        public void Render(Graphics g)
        {
            foreach (Enemy item in this._enemy)
            {
                item.RenderE(g);
            }

            foreach (Ground item in this._ground)
            {
                item.RenderG(g);
            }

            this._player.RenderP(g);
        }

        public void MovePRight()
        {
            //this._player.Vx += 1;
            this._player.X += 10;
        }

        public void MovePLeft()
        {
            //this._player.Vx -= 1;
            this._player.X -= 10;
        }

        public void JumpP()
        {
            //this._player.Vy -= 1.5;
            this._player.Y -= 20; 
        }
    }
}

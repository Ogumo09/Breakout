using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    
    class Game
    {
        public Vector2 MapSize { get; private set; } = new Vector2(1132, 800);
        List<Brick> Bricks = new List<Brick>(); List<Ball> Balls = new List<Ball>(); List<Bat> Bats = new List<Bat>();
        public void Update()
        {
        }
        public void Draw(Graphics g)
        {
        }
    }

}

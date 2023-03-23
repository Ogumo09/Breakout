using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    
    abstract class Brick
    {
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        public float CornerRadius { get; set; }
        public abstract void Draw(Graphics g);
        public abstract void OnHit();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    class Ball
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float Radius { get; set; }
        public void Update(float dT)
        {
            Position += Velocity * dT;
        }
        public void Draw(Graphics g)
        {
        }
    }
}

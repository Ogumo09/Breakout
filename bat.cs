using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    class Bat
    {
         
        public float X { get; set; }
        public float Width { get; set; }
        public float Speed { get; set; }
        public void Update(float dT) {
            X += Speed * dT; }
        public void Draw(Graphics g)
        {
        }

    }
    
}
   


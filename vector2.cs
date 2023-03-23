using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Length => (float)Math.Sqrt(X * X + Y * Y);
        public Vector2(float x, float y) { X = x; Y = y; }
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 operator *(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 operator /(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 normalize (Vector2 v)
        {
            return v/v.Length;
        }
        public static float Dot (Vector2 v1, Vector2 v2)
        {
            return v1.X*v2.X+v1.Y*v2.Y;
        }
    }
}

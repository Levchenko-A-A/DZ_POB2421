using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOP_26._1
{
    internal class SnowFlake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; init; }
        public int FallingSpeed { get; init; }

        public SnowFlake(int x, int y, int size, int fallingSpeed)
        {
            X = x;
            Y = y;
            Size = size;
            FallingSpeed = fallingSpeed;
        }

        public void Fall()
        {
            Y += FallingSpeed;
        }
    }
}

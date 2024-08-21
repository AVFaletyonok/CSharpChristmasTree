using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTree
{
    internal class TSnowFlake
    {
        const double MinSpeed = 1.0;
        const double MaxSpeed = 6.0;
        const double MaxSpeedX = 4.0;
        const int MinSize = 4;
        const int MaxSize = 11;
        const int MaxA = 50;

        public static int SnowCount { get; set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        private double speedTx, speedTy;
        private double X0;
        private int A;
        private double Time;
        private double Angle0;

        public TSnowFlake(double x, double y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
        public TSnowFlake(Random random, int width)
        {
            Width = Height = MinSize + random.Next(MaxSize - MinSize);
            Y = -Height;
            X = X0 = random.Next(width + 2 * A) - A;
            speedTy = MinSpeed + random.NextDouble() * (MaxSpeed - MinSpeed);
            speedTx = MinSpeed + random.NextDouble() * (MaxSpeedX - MinSpeed);
            A = (int)(MaxA * speedTx / MaxSpeedX);
            Time = 0.0;
            Angle0 = 2 * Math.PI * random.NextDouble();
        }

        public void Move()
        {
            Y += speedTy;
            Time += 0.03;
            X = X0 + A * Math.Sin(Angle0 + Time * speedTx);
        }
    }
}

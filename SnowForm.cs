using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTree
{
    public partial class SnowForm : Form
    {
        private Graphics g;

        private Random random;
        private List<TSnowFlake> snowFlakes;
        private TSnowFlake snowFlake;

        public SnowForm()
        {
            InitializeComponent();
            g = CreateGraphics();

            random = new Random(DateTime.Now.Millisecond);
            TSnowFlake.SnowCount = 350;
            snowFlakes = new List<TSnowFlake>(TSnowFlake.SnowCount);
            for (int i = 0; i < TSnowFlake.SnowCount; i++)
            {
                snowFlake = new TSnowFlake(random, this.Width);
                snowFlakes.Add(snowFlake);
            }
            foreach(TSnowFlake snowFlake in snowFlakes)
                g.FillEllipse(Brushes.White, (int)snowFlake.X, (int)snowFlake.Y, snowFlake.Width, snowFlake.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g.Clear(TransparencyKey);
            for (int i = 0; i <TSnowFlake.SnowCount; i++)
            {
                snowFlakes[i].Move();
                if (snowFlakes[i].Y > this.Height)
                    snowFlakes[i] = new TSnowFlake(random, this.Width);
                g.FillEllipse(Brushes.White, (int)snowFlakes[i].X, (int)snowFlakes[i].Y, snowFlakes[i].Width, snowFlakes[i].Height);
            }
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Invalidate();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}

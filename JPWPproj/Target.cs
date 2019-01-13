using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JPWPproj
{
    internal class Target : MovingObject
    {
        Point startingPoint;

        internal Brush Brush;


        public Target(int x, int y)
        {
            startingPoint.X = x;
            startingPoint.Y = y;
            this.acutalPosition.X = x;
            this.acutalPosition.Y = y;
            Brush = Brushes.Plum;
        }

        

        public void setBrush(Brush brush)
        {
            Brush = brush;
        }

        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brush, this.acutalPosition.X, this.acutalPosition.Y, 25, 25);
            refreshPosition();
        }

        public override bool isColliding(MovingObject toCheck)
        {
            return false; //need to detect borders of map
        }

        protected override void refreshPosition()
        {
            acutalPosition.X -= 3;
            acutalPosition.Y = startingPoint.Y - (int)(Math.Sin((double)acutalPosition.X/23.00)*52)+ (int)(Math.Cos((double)acutalPosition.X / 37.00) * 78);
        }
    }
}

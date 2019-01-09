using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JPWPproj
{
    class Target : MovingObject
    {
        Point startingPoint;

        public Target(int x, int y)
        {
            startingPoint.X = x;
            startingPoint.Y = y;
            this.acutalPosition.X = x;
            this.acutalPosition.Y = y;
        }

        public override void collideEvent()
        {
            throw new NotImplementedException();
        }

        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Plum, this.acutalPosition.X, this.acutalPosition.Y, 25, 25);
            refreshPosition();
        }

        public override bool isColliding(MovingObject toCheck)
        {
            return false; //need to detect borders of map
        }

        protected override void refreshPosition()
        {
            acutalPosition.X -= 5;
            acutalPosition.Y = startingPoint.Y - (int)(Math.Sin((double)acutalPosition.X/50.00)*100)+ (int)(Math.Sin((double)acutalPosition.X / 40.00) * 150);
        }
    }
}

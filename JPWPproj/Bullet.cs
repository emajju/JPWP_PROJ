using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWPproj
{
    class Bullet : MovingObject
    {
        public Bullet(int x, int y)
        {
            this.acutalPosition.X = x;
            this.acutalPosition.Y = y;
        }

        

        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Bisque, this.acutalPosition.X, this.acutalPosition.Y, 10, 10);
            refreshPosition();
        }

        public override bool isColliding(MovingObject toCheck)
        {
            int distance = 0;
            if(toCheck is Target)
            {

                distance = (int)Math.Sqrt((double)(Math.Pow((acutalPosition.X - toCheck.acutalPosition.X), 2) + Math.Pow((acutalPosition.Y - toCheck.acutalPosition.Y), 2)));
                if (distance <= 35)
                    return true;
            }

            return false;
        }

        protected override void refreshPosition()
        {
            acutalPosition.X += 10;
        }
    }
}

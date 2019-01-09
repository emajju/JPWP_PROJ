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
            e.Graphics.FillRectangle(Brushes.Bisque, this.acutalPosition.X, this.acutalPosition.Y, 10, 10);
            refreshPosition();
        }

        public override bool isColliding(MovingObject toCheck)
        {


            throw new NotImplementedException();
        }

        protected override void refreshPosition()
        {
            acutalPosition.X += 10;
        }
    }
}

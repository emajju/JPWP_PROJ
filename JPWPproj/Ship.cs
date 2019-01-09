using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JPWPproj
{
    class Ship : MovingObject
    {
        GraphicsDrawing graphicsDrawing;

        public Ship()
        {
            acutalPosition = new Point(50, 50);
        }

        public void defineGraphics(GraphicsDrawing pointer)
        {
            graphicsDrawing = pointer;
        }

        public override void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BurlyWood, this.acutalPosition.X, this.acutalPosition.Y, 100, 100);
        }

        public override bool isColliding(MovingObject toCheck)
        {
            return false;
        }

        protected override void refreshPosition()
        {
            throw new NotImplementedException();
        }

        public void forcePosition (Point newPosition)
        {
            this.acutalPosition = newPosition;
        }

        public void changePosition (int x, int y)
        {
            if(acutalPosition.Y >= 10 && acutalPosition.Y <= 814)
            this.acutalPosition.Y += y;
            else if(acutalPosition.Y<10 && y>=0)
                this.acutalPosition.Y += y;
            else if(acutalPosition.Y > 814 && y<=0)
                this.acutalPosition.Y += y;


            this.acutalPosition.X += x;
        }

        public void createBullet()
        {
            Bullet temp = new Bullet( acutalPosition.X + 110, acutalPosition.Y+50);
                       
            graphicsDrawing.addObjectToDraw(temp);
        }

        public override void collideEvent()
        {
            throw new NotImplementedException();
        }
    }
}

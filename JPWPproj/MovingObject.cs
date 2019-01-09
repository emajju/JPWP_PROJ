using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Klasa podstawowa dla obiektów
namespace JPWPproj
{
    public abstract class MovingObject
    {

        public int moveEquationType;
        public int outlineType;
        public Point acutalPosition;
        public int objType;


        public abstract bool isColliding(MovingObject toCheck);
        public abstract void Draw(PaintEventArgs e);
        protected abstract void refreshPosition();
                       
        

    }

    enum moveEquation { line, sine, custom};
    //enum outline { square, triangle, circle};
    enum objectType { ship, target, bullet, frame }

    //typical collision detection is needed only for buller and targer, both are circles
}
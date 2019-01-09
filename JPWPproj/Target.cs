using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWPproj
{
    class Target : MovingObject
    {
        public override void Draw(PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override bool isColliding(MovingObject toCheck)
        {
            throw new NotImplementedException();
        }

        protected override void refreshPosition()
        {
            throw new NotImplementedException();
        }
    }
}

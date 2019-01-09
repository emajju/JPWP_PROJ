using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWPproj
{
    class GraphicsDrawing
    {
        private List<MovingObject> objectsToDraw = new List<MovingObject>();
        

        public void draw (PaintEventArgs e)
        {
            foreach (var obj in objectsToDraw)
            {
                obj.Draw(e);
               
            }
            findHiddenObj();
        }

        public void addObjectToDraw(MovingObject obj)
        {
            objectsToDraw.Add(obj);
        }

        public void deleteObjectFromList(MovingObject obj)
        {
            objectsToDraw.Remove(obj);
        }

        private void findHiddenObj()
        {
            for (int i = 0; i < objectsToDraw.Count; i++)          
            {
                if (objectsToDraw[i].acutalPosition.X > 1000)
                {
                    deleteObjectFromList(objectsToDraw[i]);
                    continue;
                }
                    
                if (objectsToDraw[i].acutalPosition.Y > 1000)
                    deleteObjectFromList(objectsToDraw[i]);
            }
        }
    }
}

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
            findCollisions();
            listCleanup();
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
                    objectsToDraw[i].toDelete = true;
                    continue;
                }
                    
                if (objectsToDraw[i].acutalPosition.Y > 1000)
                    objectsToDraw[i].toDelete = true;
            }
        }

        private void findCollisions()
        {
            for (int x = 0; x < objectsToDraw.Count; x++)
            {
                for (int y = 0; y < objectsToDraw.Count; y++)
                {
                    
                    if (objectsToDraw[x].isColliding(objectsToDraw[y]))
                    {
                        objectsToDraw[x].collideEvent();
                        objectsToDraw[y].collideEvent();
                        objectsToDraw[x].toDelete = true;
                        objectsToDraw[y].toDelete = true;
                        continue;
                    }
                }
            }
        }

        private void listCleanup()
        {
            for (int i = objectsToDraw.Count-1; i > 0; i--)//backward wont generate errors
            {
                if (objectsToDraw[i].toDelete)
                {
                    deleteObjectFromList(objectsToDraw[i]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JPWPproj
{
    class GraphicsDrawing
    {
        private List<MovingObject> objectsToDraw = new List<MovingObject>();

        bool inUse = false;

        public void draw (PaintEventArgs e)
        {
            while (inUse)
            {
                Thread.Sleep(1);
            }
            inUse = true;
            foreach (var obj in objectsToDraw)
            {
                obj.Draw(e);
               
            }
            Console.WriteLine("Do narysowania "+objectsToDraw.Count);
            inUse = false;
            findHiddenObj();
            findCollisions();
            listCleanup();
            
        }

        public void addObjectToDraw(MovingObject obj)
        {
            while (inUse)
            {
                Thread.Sleep(1);
            }
            inUse = true;
            objectsToDraw.Add(obj);
            inUse = false;
        }

        public void deleteObjectFromList(MovingObject obj)
        {
            while (inUse)
            {
                Thread.Sleep(1);
            }
            inUse = true;
            objectsToDraw.Remove(obj);
            inUse = false;
        }

        private void findHiddenObj()
        {
            for (int i = 0; i < objectsToDraw.Count; i++)          
            {
                if (objectsToDraw[i].acutalPosition.X > 1201)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }
                    
                if (objectsToDraw[i].acutalPosition.Y > 800)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }

                if (objectsToDraw[i].acutalPosition.Y < 2)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }

                if (objectsToDraw[i].acutalPosition.X < 2)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }


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

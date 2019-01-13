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

        int lastCounter = 0;

        public void dumpObjects()

        {
            while (inUse)
            {
                // Thread.Sleep(1);
            }
            inUse = true;
            foreach (var item in objectsToDraw)
            {
                if(!(item is Ship))
                {
                    item.toDelete = true;
                }
            }
            inUse = false;
        }

        public void draw (PaintEventArgs e)
        {
            while (inUse)
            {
               // Thread.Sleep(1);
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
               // Thread.Sleep(1);
            }
            inUse = true;
            objectsToDraw.Add(obj);
            inUse = false;
        }

        public void deleteObjectFromList(MovingObject obj)
        {
           
            objectsToDraw.Remove(obj);
            inUse = false;
        }

        private void findHiddenObj()
        {
            while (inUse)
            {
                //  Thread.Sleep(1);
            }
            inUse = true;
            for (int i = 0; i < objectsToDraw.Count; i++)          
            {
                if (objectsToDraw[i] == null)
                {
                    break;
                }

                if (objectsToDraw[i].acutalPosition.X > 1201)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }
                    
                else if (objectsToDraw[i].acutalPosition.Y > 800)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }

                else if(objectsToDraw[i].acutalPosition.Y < 2)
                {
                    objectsToDraw[i].toDelete = true;
                    continue;
                }

                else if(objectsToDraw[i].acutalPosition.X < 2)
                {
                    //objectsToDraw[i].toDelete = true; //Przekroczenie lewej ściany
                    objectsToDraw[i].collideEvent();
                    continue;
                }


            }
            inUse = false;
        }

        private void findCollisions()
        {
            lastCounter = 0;
            for (int x = 0; x < objectsToDraw.Count; x++)
            {
                for (int y = 0; y < objectsToDraw.Count; y++)
                {
                    
                    if (objectsToDraw[x].isColliding(objectsToDraw[y]))
                    {
                        objectsToDraw[x].collideEvent();
                        objectsToDraw[y].collideEvent();
                        
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

        public MovingObject getNextColliding()
        {
            for (int i = lastCounter; i < objectsToDraw.Count; i++)
            {
                if (objectsToDraw[i] == null)
                {
                    lastCounter++;
                    return null;
                }
                if (objectsToDraw[i].collideDetected)
                {
                    objectsToDraw[i].toDelete = true;
                    lastCounter = i+1;
                    return objectsToDraw[i];
                }
            }
            
            return null;
        }
    }
}

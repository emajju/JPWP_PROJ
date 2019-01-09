using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace JPWPproj
{
    public partial class MainWindow : Form
    {
        
        Stopwatch stopwatch = new Stopwatch();
        GraphicsDrawing graphicsDrawing = new GraphicsDrawing();
        Ship ship = new Ship();
        int spaceSlower = 0;
        public MainWindow()
        {
            InitializeComponent();

            graphicsDrawing.addObjectToDraw(ship);
            ship.defineGraphics(graphicsDrawing);
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        { //First window load after start app
            
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        { 
            
            graphicsDrawing.draw(e);
        }

        private void tmrPaintScreen_Tick(object sender, EventArgs e)
        {
            stopwatch.Start();
            //smooth keys are done here
            checkSmoothKeys();



           //Do all math here
            Invalidate(); //Redraw window every 20ms 50fps
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();
        }

        private void LoadFirstInfoText(object sender)
        {
            
                
        }

        private void checkSmoothKeys() //Keys used to move ship have to work without interrupts
        {
            
            if (Keyboard.IsKeyDown(Key.Up))
            {
                ship.changePosition(0, -10);
                Console.WriteLine("Keyup detected!");
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                ship.changePosition(0, 10);
                Console.WriteLine("Keydown detected!");
            }
            if(Keyboard.IsKeyDown(Key.Space))//obsługa nieblokująca
            {
                spaceSlower++;
                if(spaceSlower >= 3)
                {
                    ship.createBullet();
                    spaceSlower = 0;
                    Random r = new Random();
                    int rInt = r.Next(200,800); //for ints
                    graphicsDrawing.addObjectToDraw(new Target(1000,rInt));
                }
            }
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)//Keys used with interrupts.
        {
            //Console.WriteLine(e.KeyCode);

            switch (e.KeyCode)
            {
                

                case Keys.F1:
                    graphicsDrawing.addObjectToDraw(new Target(900, 500));
                    break;
                case Keys.F2:
                    throw new NotImplementedException();
                    break;
                case Keys.F3:
                    throw new NotImplementedException();
                    break;
                case Keys.F4:
                    this.Close();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }
           
            
        }

       
    }
}

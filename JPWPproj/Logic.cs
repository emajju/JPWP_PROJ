using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JPWPproj
{
    class Logic
    {
        GraphicsDrawing Graphics;
        MainWindow Window;
        System.Timers.Timer timer;

        int score = 0;
        int lastRndY = 400;
        bool stop = false;
        bool gameStarted = false;

        int stripCounter = 1;

        int colourRandomCounter = 0;

        int endedCounter = 0;

        public void checkPoints()
        {
            if(score <0)
            {
                stopGame();
                MessageBox.Show("Przegrałeś!", "Przegrałeś!", MessageBoxButtons.OK);
            }
        }

        public Logic(GraphicsDrawing graphics, MainWindow window)
        {
            Graphics = graphics;
            Window = window;
        }

        public void processCollisions()
        {
            MovingObject tmp;
            tmp = Graphics.getNextColliding();
            while (tmp != null)
            {
                checkIfWanted(tmp);
                tmp = Graphics.getNextColliding();
            }
        }

        bool checkIfWanted(MovingObject obj)
        {
            if (obj is Target)
            {
                Brush tmpB = neededColour();
                Target tmp = (Target)obj;
                if (((SolidBrush)tmp.Brush).Color == ((SolidBrush)tmpB).Color)
                {
                    if (obj.acutalPosition.X <2)
                    {
                        score -= 50; //Ucieczka potrzebnego koloru
                        return true;
                    }

                    if (stripCounter == 3)
                    {
                        Window.resistor.Hide3 = false;
                        stripCounter = 1;
                        Window.resistor.setNewRandomVal();
                        score += 300;
                        endedCounter++;
                    }
                    else stripCounter++;
                    score += 100;
                    neededColour(); //dla odswieżenia
                    return true;
                }
                else
                {
                    //kara za zły zestrzelony kolor
                    if (score > 1200)
                    {
                        score -= 10;
                    }
                    return false;
                }
            }
            return false;
        }

        Brush neededColour()
        {
            switch (stripCounter)
            {
                case 1 :
                    
                    return Window.resistor.FirstBarColor;
                    
                case 2:
                    Window.resistor.Hide1 = false;
                    return Window.resistor.SecondBarColor;
                case 3:
                    Window.resistor.Hide2 = false;
                    return Window.resistor.ThirdBarColor;
                default:
                    throw new NotImplementedException();
            }
        }

        public void startGame()
        {
            stop = false;
            if(Window.tmrPaintScreen.Enabled==false)
            Window.tmrPaintScreen.Start();
            
            Window.helpPictureBox.Hide();
            
            if (!gameStarted)
            {
                Window.resistor.Hide();
                setupTimer();
                gameStarted = true;
                Window.resistor.setNewRandomVal();
            }
            if(timer.Enabled == false)
            {
                timer.Enabled = true;
            }
        }

        public void pauseGame()
        {
            timer.Enabled = false;
            Window.tmrPaintScreen.Stop();
            if(score > 1200)
            {
                score -= 600; //kara za podpowiedź
            }
        }

        public void stopGame()
        {
            endedCounter = 0;
            Window.InitLabel.Show();
            stop = true;
            gameStarted = false;
            if (timer != null) timer.Enabled = false;
            score = 0;
            stripCounter = 1;
            refreshScore();
            Graphics.dumpObjects();
        }

        public void refreshScore()
        {
            Window.scoreLabel.Text = "Wynik: " + score;
            Window.scoreLabel.Show();
        }
        //timer.Elapsed += async ( sender, e ) => await HandleTimer();

        public void writeValue()
        {
            Window.valueLabel.Show();
            Window.valueLabel.Text = "Wartość = " + Window.resistor.Value;
        }

        public void writeEndedCount()
        {
            Window.valueLabel.Show();
            Window.valueLabel.Text = "Ukończonych = " + endedCounter;
        }

        void setupTimer()
        {
            timer = new System.Timers.Timer(4500);
            //timer.Elapsed += async (sender,e) => timerEvent();
            timer.Elapsed +=  (sender,e) => timerEvent();
            timer.AutoReset = true;
            timer.Enabled = true;
            //timerEvent(); //pierwsze wykonianie ręcznie aby nie czekać na odmierzenie czasu
        }

         void timerEvent()
        {
            prepareSeries();
        }

        void  prepareSeries()
        {
            if (stop) return; 
            Random rnd = new Random();
            Target temp;
            int rndY = rnd.Next(14, 55)*10;
            while (Math.Abs(rndY-lastRndY)<150)
            {
                rndY = rnd.Next(14, 55) * 10;
            }
            lastRndY = rndY;
            int rndCount = rnd.Next(4, 12);
            Brush seriesBrush = Window.resistor.enum2brush((ResistorBars.StripColours)rnd.Next(0, 10));
            if (((SolidBrush)seriesBrush).Color != ((SolidBrush)neededColour()).Color)
            {
                colourRandomCounter++;

                if (colourRandomCounter > 1)
                {
                    seriesBrush = neededColour();
                    colourRandomCounter = 0;
                }

            }



            for (int i = 0; (i <= rndCount)&&stop==false; i++)
            {
                
                temp = new Target(1199, rndY);
                temp.setBrush(seriesBrush);

                Graphics.addObjectToDraw(temp);

                Thread.Sleep(300);
                
            }
            
        }

    }
}

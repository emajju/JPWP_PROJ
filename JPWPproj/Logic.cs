using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace JPWPproj
{
    class Logic
    {
        GraphicsDrawing Graphics;
        MainWindow Window;
        System.Timers.Timer timer;

        int score = 0;


        public Logic(GraphicsDrawing graphics, MainWindow window)
        {
            Graphics = graphics;
            Window = window;
        }

        public void startGame()
        {
            setupTimer();
        }

        public void pauseGame()
        {
            timer.Enabled = false;
        }

        public void stopGame()
        {
            timer.Enabled = false;
            score = 0;
            refreshScore();
        }

        void refreshScore()
        {
            Window.scoreLabel.Text = "Wynik: " + score;
        }
        //timer.Elapsed += async ( sender, e ) => await HandleTimer();

        void setupTimer()
        {
            timer = new System.Timers.Timer(3000);
            //timer.Elapsed += async (sender,e) => timerEvent();
            timer.Elapsed += (sender,e) => timerEvent();
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        void timerEvent()
        {
            prepareSeries();
        }

        void prepareSeries()
        {
            Random rnd = new Random();
            Target temp;
            int rndY = rnd.Next(2, 70)*10;
            for (int i = 0; i <= rnd.Next(4,25); i++)
            {
                temp = new Target(1199, rndY);
                Graphics.addObjectToDraw(temp);
                Thread.Sleep(300);
            }
        }

    }
}

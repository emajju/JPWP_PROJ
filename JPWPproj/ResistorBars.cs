using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWPproj
{
  internal class ResistorBars
    {
        public int Value {  get; private set; }
        internal Brush FirstBarColor;
        internal Brush SecondBarColor;
        internal Brush ThirdBarColor;
        internal Brush FourthBarColor;
        public bool Hide1 = false;
        public bool Hide2 = false;
        public bool Hide3 = false;
        public bool Hide4 = false;

        public ResistorBars()
        {
            FirstBarColor = Brushes.Black;
            SecondBarColor = Brushes.Blue;
            ThirdBarColor = Brushes.Red;
            FourthBarColor = Brushes.Gold;
        }

        public void Hide()
        {
            Hide1 = true;
            Hide2 = true;
            Hide3 = true;
            Hide4 = false;
        }

        public void setNewRandomVal()
        {
            Hide();
            Value = 0;
            Random rnd = new Random();
            int rndVal = rnd.Next(0, 9);//pierwszy pasek
            Value += rndVal * 10;
            FirstBarColor = enum2brush((StripColours)rndVal);

            rndVal = rnd.Next(0, 9);//pierwszy pasek
            Value += rndVal;
            SecondBarColor = enum2brush((StripColours)rndVal);

            rndVal = rnd.Next(0, 7);//pierwszy pasek
            Value *= (int)Math.Pow(10,rndVal);
            ThirdBarColor = enum2brush((StripColours)rndVal);
        }

        public void drawBars(Graphics e)
        {
            
            int x = 67;
            int xplus = 20;
            int y = 4;
            e.FillRectangle((Hide1 ? Brushes.Moccasin : FirstBarColor), x, y, 13, 33);
            x += xplus;
            e.FillRectangle((Hide2 ? Brushes.Moccasin : SecondBarColor), x, y, 13, 33);
            x += xplus;
            e.FillRectangle((Hide3 ? Brushes.Moccasin : ThirdBarColor), x, y, 13, 33);
            x += xplus;
            e.FillRectangle((Hide4 ? Brushes.Moccasin : FourthBarColor), x, y, 13, 33);

        }
        
        internal Brush enum2brush (StripColours strip)
        {
            switch (strip)
            {
                case StripColours.black:
                    return Brushes.Black;
                case StripColours.brown:
                    return Brushes.Brown;
                case StripColours.red:
                    return Brushes.Red;
                case StripColours.orange:
                    return Brushes.Orange;
                case StripColours.yellow:
                    return Brushes.Yellow;
                case StripColours.green:
                    return Brushes.Green;
                case StripColours.blue:
                    return Brushes.Blue;
                case StripColours.violet:
                    return Brushes.Violet;
                case StripColours.gray:
                    return Brushes.Gray;
                case StripColours.white:
                    return Brushes.White;
                case StripColours.gold:
                    return Brushes.Gold;
                case StripColours.silver:
                    return Brushes.Silver;
                default:
                    throw new NotImplementedException();
            }
        }

        //Dostępne kolory
        internal enum StripColours { black = 0, brown, red, orange, yellow, green , blue, violet, gray, white, gold, silver};
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWPproj
{
    public partial class MainWindow : Form
    {
        private int _y;
        private int _x;

        public MainWindow()
        {
            InitializeComponent();
            _y = 50;
            _x = 50;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        { //First window load after start app
            LoadFirstButtons(sender);
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        { //Drawing window
            //Console.WriteLine("Paint");
            e.Graphics.FillRectangle(Brushes.BurlyWood, _x, _y, 100, 100);
        }

        private void tmrPaintScreen_Tick(object sender, EventArgs e)
        {
           //Do all math here
            Invalidate(); //Redraw window every 20ms 50fps
        }

        private void LoadFirstButtons(object sender)
        {
            var startButton = new Button();
            startButton.Text = "Start";
            Point loc = new Point(500, 200);
            startButton.Location = loc;
            startButton.Visible = true;
                
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       
    }
}

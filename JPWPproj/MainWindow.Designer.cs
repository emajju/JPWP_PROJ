namespace JPWPproj
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrPaintScreen = new System.Windows.Forms.Timer(this.components);
            this.InitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrPaintScreen
            // 
            this.tmrPaintScreen.Enabled = true;
            this.tmrPaintScreen.Interval = 20;
            this.tmrPaintScreen.Tick += new System.EventHandler(this.tmrPaintScreen_Tick);
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InitLabel.Location = new System.Drawing.Point(408, 42);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(440, 275);
            this.InitLabel.TabIndex = 0;
            this.InitLabel.Text = "Witaj\r\nF1 - Pomoc\r\nF2 - Rozpocznij grę\r\nF3 - Zatrzymaj grę\r\nF4 - Zakończ grę";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.ControlBox = false;
            this.Controls.Add(this.InitLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Tin Shooter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPaintScreen;
        private System.Windows.Forms.Label InitLabel;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tmrPaintScreen = new System.Windows.Forms.Timer(this.components);
            this.InitLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.helpPictureBox = new System.Windows.Forms.PictureBox();
            this.endedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).BeginInit();
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
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 766);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(70, 25);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label1";
            this.scoreLabel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(991, 759);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueLabel.Location = new System.Drawing.Point(278, 766);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(70, 25);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "label1";
            this.valueLabel.Visible = false;
            // 
            // helpPictureBox
            // 
            this.helpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("helpPictureBox.Image")));
            this.helpPictureBox.Location = new System.Drawing.Point(198, 124);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(748, 310);
            this.helpPictureBox.TabIndex = 5;
            this.helpPictureBox.TabStop = false;
            this.helpPictureBox.Visible = false;
            // 
            // endedLabel
            // 
            this.endedLabel.AutoSize = true;
            this.endedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endedLabel.Location = new System.Drawing.Point(538, 766);
            this.endedLabel.Name = "endedLabel";
            this.endedLabel.Size = new System.Drawing.Size(70, 25);
            this.endedLabel.TabIndex = 6;
            this.endedLabel.Text = "label1";
            this.endedLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.endedLabel);
            this.Controls.Add(this.helpPictureBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.InitLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tin Shooter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label valueLabel;
        internal System.Windows.Forms.Timer tmrPaintScreen;
        internal System.Windows.Forms.PictureBox helpPictureBox;
        internal System.Windows.Forms.Label InitLabel;
        public System.Windows.Forms.Label endedLabel;
    }
}


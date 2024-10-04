namespace Projektuppgift_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            drawbutton = new Button();
            pointlabel = new Label();
            standbutton = new Button();
            cardbox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cardbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // drawbutton
            // 
            drawbutton.BackColor = Color.Red;
            drawbutton.Font = new Font("Segoe UI", 25F);
            drawbutton.ForeColor = Color.White;
            drawbutton.Location = new Point(501, 331);
            drawbutton.Name = "drawbutton";
            drawbutton.Size = new Size(151, 68);
            drawbutton.TabIndex = 0;
            drawbutton.Text = "Draw";
            drawbutton.UseVisualStyleBackColor = false;
            drawbutton.Click += button1_Click;
            // 
            // pointlabel
            // 
            pointlabel.AutoSize = true;
            pointlabel.Font = new Font("Segoe UI", 35F);
            pointlabel.ForeColor = Color.White;
            pointlabel.Location = new Point(314, 90);
            pointlabel.Name = "pointlabel";
            pointlabel.Size = new Size(145, 62);
            pointlabel.TabIndex = 1;
            pointlabel.Text = "00/21";
            pointlabel.Click += label1_Click;
            // 
            // standbutton
            // 
            standbutton.BackColor = Color.FromArgb(0, 192, 0);
            standbutton.Font = new Font("Segoe UI", 25F);
            standbutton.ForeColor = Color.White;
            standbutton.Location = new Point(501, 428);
            standbutton.Name = "standbutton";
            standbutton.Size = new Size(151, 68);
            standbutton.TabIndex = 2;
            standbutton.Text = "Stand";
            standbutton.UseVisualStyleBackColor = false;
            standbutton.Click += button2_Click;
            // 
            // cardbox
            // 
            cardbox.BackColor = Color.Transparent;
            cardbox.Image = (Image)resources.GetObject("cardbox.Image");
            cardbox.Location = new Point(42, 360);
            cardbox.Name = "cardbox";
            cardbox.Size = new Size(186, 252);
            cardbox.SizeMode = PictureBoxSizeMode.Zoom;
            cardbox.TabIndex = 3;
            cardbox.TabStop = false;
            cardbox.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\miro\\source\\repos\\Projektuppgift 1\\Projektuppgift 1\\Sprites\\cardBack_blue5.png";
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1157, 655);
            Controls.Add(pictureBox1);
            Controls.Add(cardbox);
            Controls.Add(standbutton);
            Controls.Add(pointlabel);
            Controls.Add(drawbutton);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Blackjack?";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button drawbutton;
        private Label pointlabel;
        private Button standbutton;
        private PictureBox cardbox;
        private PictureBox pictureBox1;
    }
}

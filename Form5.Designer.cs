namespace The_Guessing_Game_App
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            guessedNum = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.guessing;
            pictureBox1.Location = new Point(96, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(193, 31);
            label1.Name = "label1";
            label1.Size = new Size(450, 57);
            label1.TabIndex = 6;
            label1.Text = "Finger Guessing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(182, 233);
            label2.Name = "label2";
            label2.Size = new Size(423, 29);
            label2.TabIndex = 7;
            label2.Text = "Enter a Number between 1 and 5";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(414, 367);
            button3.Name = "button3";
            button3.Size = new Size(118, 42);
            button3.TabIndex = 10;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(238, 367);
            button1.Name = "button1";
            button1.Size = new Size(118, 42);
            button1.TabIndex = 11;
            button1.Text = "enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // guessedNum
            // 
            guessedNum.Cursor = Cursors.IBeam;
            guessedNum.Location = new Point(316, 284);
            guessedNum.Name = "guessedNum";
            guessedNum.Size = new Size(145, 27);
            guessedNum.TabIndex = 12;
            guessedNum.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(81, 148);
            label3.Name = "label3";
            label3.Size = new Size(653, 50);
            label3.TabIndex = 13;
            label3.Text = "How Many Fingers do i have?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Harrington", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(695, 417);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 14;
            label4.Text = "blvckrvy";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(guessedNum);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Guessing Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button1;
        private TextBox guessedNum;
        private Label label3;
        private Label label4;
    }
}
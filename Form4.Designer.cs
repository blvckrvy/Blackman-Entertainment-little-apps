namespace The_Guessing_Game_App
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(160, 263);
            button1.Name = "button1";
            button1.Size = new Size(118, 42);
            button1.TabIndex = 6;
            button1.Text = "ROCK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(127, 29);
            label1.Name = "label1";
            label1.Size = new Size(634, 57);
            label1.TabIndex = 5;
            label1.Text = "Rock - Paper - Scissors";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.guessing;
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(179, 140);
            label3.Name = "label3";
            label3.Size = new Size(465, 50);
            label3.TabIndex = 8;
            label3.Text = "Pick your poison !!!";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(341, 341);
            button3.Name = "button3";
            button3.Size = new Size(118, 42);
            button3.TabIndex = 9;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(524, 263);
            button4.Name = "button4";
            button4.Size = new Size(139, 42);
            button4.TabIndex = 10;
            button4.Text = "SCISSORS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(341, 263);
            button2.Name = "button2";
            button2.Size = new Size(118, 42);
            button2.TabIndex = 11;
            button2.Text = "PAPER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(695, 417);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 12;
            label2.Text = "blvckrvy";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Guessing Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label label2;
    }
}
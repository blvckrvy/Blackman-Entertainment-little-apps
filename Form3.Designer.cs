namespace The_Guessing_Game_App
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            randomNumberText = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(181, 25);
            label1.Name = "label1";
            label1.Size = new Size(455, 57);
            label1.TabIndex = 0;
            label1.Text = "Higher or Lower";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.guessing;
            pictureBox1.Location = new Point(82, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(181, 164);
            label2.Name = "label2";
            label2.Size = new Size(261, 37);
            label2.TabIndex = 2;
            label2.Text = "First Number: ";
            // 
            // randomNumberText
            // 
            randomNumberText.AutoSize = true;
            randomNumberText.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            randomNumberText.ForeColor = SystemColors.Control;
            randomNumberText.Location = new Point(448, 164);
            randomNumberText.Name = "randomNumberText";
            randomNumberText.Size = new Size(125, 37);
            randomNumberText.TabIndex = 3;
            randomNumberText.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(82, 259);
            label3.Name = "label3";
            label3.Size = new Size(632, 37);
            label3.TabIndex = 4;
            label3.Text = "Second Number is Higher or Lower ?";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(221, 352);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 5;
            button1.Text = "HIGHER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(438, 352);
            button2.Name = "button2";
            button2.Size = new Size(121, 45);
            button2.TabIndex = 6;
            button2.Text = "LOWER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(338, 431);
            button3.Name = "button3";
            button3.Size = new Size(94, 43);
            button3.TabIndex = 7;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Harrington", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(695, 520);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 8;
            label4.Text = "blvckrvy";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 553);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(randomNumberText);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Guessing Game";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label randomNumberText;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
    }
}
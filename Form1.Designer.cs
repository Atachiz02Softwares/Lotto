namespace Lotto
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
            one = new Label();
            two = new Label();
            three = new Label();
            four = new Label();
            five = new Label();
            six = new Label();
            pick = new Button();
            reset = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // one
            // 
            one.AutoSize = true;
            one.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            one.Location = new Point(528, 19);
            one.Name = "one";
            one.Size = new Size(0, 41);
            one.TabIndex = 0;
            // 
            // two
            // 
            two.AutoSize = true;
            two.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            two.Location = new Point(478, 19);
            two.Name = "two";
            two.Size = new Size(0, 41);
            two.TabIndex = 1;
            // 
            // three
            // 
            three.AutoSize = true;
            three.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            three.Location = new Point(428, 19);
            three.Name = "three";
            three.Size = new Size(0, 41);
            three.TabIndex = 2;
            // 
            // four
            // 
            four.AutoSize = true;
            four.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            four.Location = new Point(378, 19);
            four.Name = "four";
            four.Size = new Size(0, 41);
            four.TabIndex = 3;
            // 
            // five
            // 
            five.AutoSize = true;
            five.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            five.Location = new Point(328, 19);
            five.Name = "five";
            five.Size = new Size(0, 41);
            five.TabIndex = 4;
            // 
            // six
            // 
            six.AutoSize = true;
            six.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            six.Location = new Point(278, 19);
            six.Name = "six";
            six.Size = new Size(0, 41);
            six.TabIndex = 5;
            // 
            // pick
            // 
            pick.AutoSize = true;
            pick.Location = new Point(278, 147);
            pick.Name = "pick";
            pick.Size = new Size(170, 30);
            pick.TabIndex = 6;
            pick.Text = "Get My Lucky Numbers";
            pick.UseVisualStyleBackColor = true;
            pick.Click += pick_Click;
            // 
            // reset
            // 
            reset.Location = new Point(484, 148);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 7;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 190);
            Controls.Add(pictureBox1);
            Controls.Add(reset);
            Controls.Add(pick);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Lotto Number Picker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label one;
        private Label two;
        private Label three;
        private Label four;
        private Label five;
        private Label six;
        private Button pick;
        private Button reset;
        private PictureBox pictureBox1;
    }
}
namespace VicsekFractal
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
            btnGenerate = new Button();
            label1 = new Label();
            txtIterations = new TextBox();
            pictureBox = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(33, 108);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 23);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "button1";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 1;
            label1.Text = "Количество итераций:";
            label1.Click += label1_Click;
            // 
            // txtIterations
            // 
            txtIterations.Location = new Point(33, 56);
            txtIterations.Name = "txtIterations";
            txtIterations.Size = new Size(100, 23);
            txtIterations.TabIndex = 2;
            txtIterations.TextChanged += txtIterations_TextChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(332, 81);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(txtIterations);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Label label1;
        private TextBox txtIterations;
        private PictureBox pictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

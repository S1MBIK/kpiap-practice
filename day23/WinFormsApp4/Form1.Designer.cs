namespace WinFormsApp4
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
            textBoxLetter = new TextBox();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxLetter
            // 
            textBoxLetter.Location = new Point(67, 41);
            textBoxLetter.Name = "textBoxLetter";
            textBoxLetter.Size = new Size(151, 27);
            textBoxLetter.TabIndex = 0;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(67, 152);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(151, 27);
            textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(67, 200);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(151, 27);
            textBoxY.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(312, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 112);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "Координаты ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 18);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Буква";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(textBoxLetter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLetter;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}

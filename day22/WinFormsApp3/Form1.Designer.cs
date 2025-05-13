namespace WinFormsApp3
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
            txtX = new TextBox();
            txtY = new TextBox();
            txtZ = new TextBox();
            Result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            rbSquare = new RadioButton();
            rbSinh = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Location = new Point(148, 34);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 0;
            // 
            // txtY
            // 
            txtY.Location = new Point(148, 76);
            txtY.Name = "txtY";
            txtY.Size = new Size(125, 27);
            txtY.TabIndex = 1;
            // 
            // txtZ
            // 
            txtZ.Location = new Point(148, 123);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(125, 27);
            txtZ.TabIndex = 2;
            // 
            // Result
            // 
            Result.Location = new Point(299, 319);
            Result.Name = "Result";
            Result.Size = new Size(125, 27);
            Result.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 37);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 4;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 76);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 5;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 126);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 6;
            label3.Text = "z";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 319);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "result";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(rbSquare);
            groupBox1.Controls.Add(rbSinh);
            groupBox1.Location = new Point(393, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "выбор функции";
            
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "e^x";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            rbSquare.AutoSize = true;
            rbSquare.Location = new Point(16, 55);
            rbSquare.Name = "rbSquare";
            rbSquare.Size = new Size(43, 24);
            rbSquare.TabIndex = 1;
            rbSquare.TabStop = true;
            rbSquare.Text = "x²";
            rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbSinh
            // 
            rbSinh.AutoSize = true;
            rbSinh.Location = new Point(16, 25);
            rbSinh.Name = "rbSinh";
            rbSinh.Size = new Size(61, 24);
            rbSinh.TabIndex = 0;
            rbSinh.TabStop = true;
            rbSinh.Text = "sh(x)";
            rbSinh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(148, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Result);
            Controls.Add(txtZ);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtZ;
        private TextBox Result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton rbSquare;
        private RadioButton rbSinh;
        private Button button1;
    }
}

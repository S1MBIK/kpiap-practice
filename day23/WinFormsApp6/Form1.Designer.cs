namespace WinFormsApp6
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
            labelResult = new Label();
            ButtonSwap = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(208, 333);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(50, 20);
            labelResult.TabIndex = 8;
            labelResult.Text = "label1";
            // 
            // ButtonSwap
            // 
            ButtonSwap.Location = new Point(423, 133);
            ButtonSwap.Name = "ButtonSwap";
            ButtonSwap.Size = new Size(170, 49);
            ButtonSwap.TabIndex = 7;
            ButtonSwap.Text = "найти максимальное число";
            ButtonSwap.UseVisualStyleBackColor = true;
            ButtonSwap.Click += ButtonSwap_Click;
            // 
            // button1
            // 
            button1.Location = new Point(423, 98);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 6;
            button1.Text = "Заполнить массив";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(207, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 204);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(ButtonSwap);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private Button ButtonSwap;
        private Button button1;
        private ListBox listBox1;
    }
}

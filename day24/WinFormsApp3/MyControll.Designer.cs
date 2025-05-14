namespace WinFormsApp3
{
    partial class MyControll
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Button = new Button();
            colorTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Button
            // 
            Button.Location = new Point(121, 80);
            Button.Name = "Button";
            Button.Size = new Size(94, 29);
            Button.TabIndex = 1;
            Button.Text = "button1";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // colorTimer
            // 
            colorTimer.Tick += colorTimer_Tick;
            // 
            // MyControll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button);
            Name = "MyControll";
            Size = new Size(340, 279);
            ResumeLayout(false);
        }

        #endregion
        private Button Button;
        private System.Windows.Forms.Timer colorTimer;
    }
}

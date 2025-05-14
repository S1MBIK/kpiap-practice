namespace WinFormsApp2
{
    partial class UserControlTimer2
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
            timer1 = new System.Windows.Forms.Timer(components);
            userControlTimer1 = new UserControlTimer();
            userControlTimer3 = new UserControlTimer();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(-13, -9);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(188, 188);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // userControlTimer3
            // 
            userControlTimer3.Location = new Point(82, 57);
            userControlTimer3.Name = "userControlTimer3";
            userControlTimer3.Size = new Size(188, 188);
            userControlTimer3.TabIndex = 1;
            userControlTimer3.TimeEnabled = true;
            // 
            // UserControlTimer2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userControlTimer3);
            Controls.Add(userControlTimer1);
            Name = "UserControlTimer2";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private UserControlTimer userControlTimer1;
        private UserControlTimer userControlTimer3;
    }
}

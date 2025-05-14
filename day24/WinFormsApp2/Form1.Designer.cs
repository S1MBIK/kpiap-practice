namespace WinFormsApp2
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
            userControlTimer1 = new UserControlTimer();
            userControlTimer21 = new UserControlTimer2();
            userControlTimerNewTry1 = new UserControlTimerNewTry();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(165, 60);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(188, 188);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // userControlTimer21
            // 
            userControlTimer21.Location = new Point(393, 60);
            userControlTimer21.Name = "userControlTimer21";
            userControlTimer21.Size = new Size(188, 188);
            userControlTimer21.TabIndex = 1;
            // 
            // userControlTimerNewTry1
            // 
            userControlTimerNewTry1.Location = new Point(92, 182);
            userControlTimerNewTry1.Name = "userControlTimerNewTry1";
            userControlTimerNewTry1.Size = new Size(188, 188);
            userControlTimerNewTry1.TabIndex = 2;
            userControlTimerNewTry1.TimeEnabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlTimerNewTry1);
            Controls.Add(userControlTimer21);
            Controls.Add(userControlTimer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer userControlTimer1;
        private UserControlTimer2 userControlTimer21;
        private UserControlTimerNewTry userControlTimerNewTry1;
    }
}

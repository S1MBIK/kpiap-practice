namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            commandOneToolStripMenuItem = new ToolStripMenuItem();
            commandTwoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandOneToolStripMenuItem, commandTwoToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // commandOneToolStripMenuItem
            // 
            commandOneToolStripMenuItem.Name = "commandOneToolStripMenuItem";
            resources.ApplyResources(commandOneToolStripMenuItem, "commandOneToolStripMenuItem");
            // 
            // commandTwoToolStripMenuItem
            // 
            commandTwoToolStripMenuItem.Name = "commandTwoToolStripMenuItem";
            resources.ApplyResources(commandTwoToolStripMenuItem, "commandTwoToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandOneToolStripMenuItem;
        private ToolStripMenuItem commandTwoToolStripMenuItem;
    }
}

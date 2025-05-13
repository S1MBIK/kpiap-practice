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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            numericUpDownStart = new NumericUpDown();
            numericUpDownEnd = new NumericUpDown();
            numericUpDownStep = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStep).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(73, 12);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(567, 375);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // numericUpDownStart
            // 
            numericUpDownStart.Location = new Point(713, 84);
            numericUpDownStart.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownStart.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numericUpDownStart.Name = "numericUpDownStart";
            numericUpDownStart.Size = new Size(150, 27);
            numericUpDownStart.TabIndex = 1;
            // 
            // numericUpDownEnd
            // 
            numericUpDownEnd.Location = new Point(713, 139);
            numericUpDownEnd.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownEnd.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numericUpDownEnd.Name = "numericUpDownEnd";
            numericUpDownEnd.Size = new Size(150, 27);
            numericUpDownEnd.TabIndex = 2;
            // 
            // numericUpDownStep
            // 
            numericUpDownStep.DecimalPlaces = 1;
            numericUpDownStep.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownStep.Location = new Point(713, 183);
            numericUpDownStep.Maximum = new decimal(new int[] { 10, 0, 0, 65536 });
            numericUpDownStep.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownStep.Name = "numericUpDownStep";
            numericUpDownStep.Size = new Size(150, 27);
            numericUpDownStep.TabIndex = 3;
            numericUpDownStep.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownStep.ValueChanged += numericUpDownStep_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(646, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "XStart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 141);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Ystart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(646, 183);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Step";
            // 
            // button1
            // 
            button1.Location = new Point(711, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 660);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownStep);
            Controls.Add(numericUpDownEnd);
            Controls.Add(numericUpDownStart);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private NumericUpDown numericUpDownStart;
        private NumericUpDown numericUpDownEnd;
        private NumericUpDown numericUpDownStep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;

    }
}

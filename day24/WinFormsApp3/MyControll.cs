    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MyControll : UserControl
    {
        public MyControll()
        {
            InitializeComponent();

        }
        private Color[] rainbowColors = new Color[]
            {
                    Color.Red,
                    Color.Orange,
                    Color.Yellow,
                    Color.Green,
                    Color.Blue,
                    Color.Indigo,
                    Color.Violet
            };
        private int progressValue = 0;
        private int currentColorIndex = 0;


        private void Button_Click(object sender, EventArgs e)
        {
            if (colorTimer == null)
            {
                colorTimer = new System.Windows.Forms.Timer();
                colorTimer.Interval = 50;
                colorTimer.Tick += colorTimer_Tick;
            }
            progressValue = 0;
            colorTimer.Start();
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue++;
                this.Invalidate(); // Перерисовать контрол
            }
            else
            {
                colorTimer.Stop();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int barWidth = this.Width - 20;
            int barHeight = 30;
            int x = 10;
            int y = (this.Height - barHeight) / 2;

            // Рисуем фон
            g.FillRectangle(Brushes.LightGray, x, y, barWidth, barHeight);

            // Рисуем радугу по частям
            int segment = barWidth / rainbowColors.Length;
            int filled = (int)(barWidth * (progressValue / 100.0));
            int filledSegments = filled / segment;

            for (int i = 0; i < rainbowColors.Length; i++)
            {
                int segStart = x + i * segment;
                int segEnd = Math.Min(segStart + segment, x + filled);
                if (segEnd > segStart)
                {
                    g.FillRectangle(new SolidBrush(rainbowColors[i]), segStart, y, segEnd - segStart, barHeight);
                }
            }

            // Рисуем рамку
            g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);

            // Рисуем текст
            string text = $"{progressValue}%";
            SizeF textSize = g.MeasureString(text, this.Font);
            g.DrawString(text, this.Font, Brushes.Black, x + (barWidth - textSize.Width) / 2, y + (barHeight - textSize.Height) / 2);
        }
    }
}


using WinFormsApp5;
namespace WinFormsApp5
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
            label1 = new Label();
            Label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            gpGender = new GroupBox();
            rbWoman = new RadioButton();
            rbMale = new RadioButton();
            gbBirthDate = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cbYear = new ComboBox();
            cbMonth = new ComboBox();
            cbDay = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbRegion = new ComboBox();
            txtEmail = new TextBox();
            cbOperator = new ComboBox();
            txtPhone = new TextBox();
            groupBox1 = new GroupBox();
            rb5plus = new RadioButton();
            rb1to5 = new RadioButton();
            rbLess1 = new RadioButton();
            rbNoExp = new RadioButton();
            groupBox2 = new GroupBox();
            label10 = new Label();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            nudSalaryTo = new NumericUpDown();
            nudSalaryFrom = new NumericUpDown();
            groupBox4 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            txtResume = new TextBox();
            label13 = new Label();
            btSave = new Button();
            btClear = new Button();
            btCancel = new Button();
            gpGender.SuspendLayout();
            gbBirthDate.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalaryTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalaryFrom).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(61, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = SystemColors.Highlight;
            Label2.Location = new Point(95, 47);
            Label2.Name = "Label2";
            Label2.Size = new Size(39, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(73, 80);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 12);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(151, 44);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(151, 77);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(125, 27);
            txtMiddleName.TabIndex = 5;
            // 
            // gpGender
            // 
            gpGender.BackColor = SystemColors.Control;
            gpGender.Controls.Add(rbWoman);
            gpGender.Controls.Add(rbMale);
            gpGender.ForeColor = SystemColors.Highlight;
            gpGender.Location = new Point(402, 12);
            gpGender.Name = "gpGender";
            gpGender.Size = new Size(216, 92);
            gpGender.TabIndex = 6;
            gpGender.TabStop = false;
            gpGender.Text = "пол";
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.ForeColor = SystemColors.ControlText;
            rbWoman.Location = new Point(25, 63);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(98, 24);
            rbWoman.TabIndex = 1;
            rbWoman.TabStop = true;
            rbWoman.Text = "Женщина";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.ForeColor = SystemColors.ControlText;
            rbMale.Location = new Point(25, 33);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(95, 24);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Мужчина";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // gbBirthDate
            // 
            gbBirthDate.Controls.Add(label6);
            gbBirthDate.Controls.Add(label5);
            gbBirthDate.Controls.Add(label4);
            gbBirthDate.Controls.Add(cbYear);
            gbBirthDate.Controls.Add(cbMonth);
            gbBirthDate.Controls.Add(cbDay);
            gbBirthDate.ForeColor = SystemColors.Highlight;
            gbBirthDate.Location = new Point(69, 110);
            gbBirthDate.Name = "gbBirthDate";
            gbBirthDate.Size = new Size(744, 83);
            gbBirthDate.TabIndex = 7;
            gbBirthDate.TabStop = false;
            gbBirthDate.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(515, 23);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 5;
            label6.Text = "Год";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(269, 23);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Месяц";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(13, 23);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "День";
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(515, 46);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(151, 28);
            cbYear.TabIndex = 2;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(269, 46);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(151, 28);
            cbMonth.TabIndex = 1;
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(13, 46);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(197, 28);
            cbDay.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 207);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 8;
            label7.Text = "Область проживания ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 239);
            label8.Name = "label8";
            label8.Size = new Size(192, 20);
            label8.TabIndex = 9;
            label8.Text = "Адрес электронной почты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(81, 272);
            label9.Name = "label9";
            label9.Size = new Size(156, 20);
            label9.TabIndex = 10;
            label9.Text = "Мобильный телефон";
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new Point(319, 199);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(317, 28);
            cbRegion.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(319, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(317, 27);
            txtEmail.TabIndex = 12;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "МТС", "А1", "LIFE" });
            cbOperator.Location = new Point(278, 272);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(99, 28);
            cbOperator.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(424, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 27);
            txtPhone.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb5plus);
            groupBox1.Controls.Add(rb1to5);
            groupBox1.Controls.Add(rbLess1);
            groupBox1.Controls.Add(rbNoExp);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(69, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 112);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Опыт работы";
            // 
            // rb5plus
            // 
            rb5plus.AutoSize = true;
            rb5plus.ForeColor = SystemColors.ControlText;
            rb5plus.Location = new Point(242, 75);
            rb5plus.Name = "rb5plus";
            rb5plus.Size = new Size(110, 24);
            rb5plus.TabIndex = 3;
            rb5plus.TabStop = true;
            rb5plus.Text = "более 5 лет";
            rb5plus.UseVisualStyleBackColor = true;
            // 
            // rb1to5
            // 
            rb1to5.AutoSize = true;
            rb1to5.ForeColor = SystemColors.ControlText;
            rb1to5.Location = new Point(239, 45);
            rb1to5.Name = "rb1to5";
            rb1to5.Size = new Size(151, 24);
            rb1to5.TabIndex = 2;
            rb1to5.TabStop = true;
            rb1to5.Text = "от 1 года до 5 лет";
            rb1to5.UseVisualStyleBackColor = true;
            // 
            // rbLess1
            // 
            rbLess1.AutoSize = true;
            rbLess1.ForeColor = SystemColors.ControlText;
            rbLess1.Location = new Point(24, 75);
            rbLess1.Name = "rbLess1";
            rbLess1.Size = new Size(87, 24);
            rbLess1.TabIndex = 1;
            rbLess1.TabStop = true;
            rbLess1.Text = "< 1 года";
            rbLess1.UseVisualStyleBackColor = true;
            // 
            // rbNoExp
            // 
            rbNoExp.AutoSize = true;
            rbNoExp.ForeColor = SystemColors.ControlText;
            rbNoExp.Location = new Point(24, 45);
            rbNoExp.Name = "rbNoExp";
            rbNoExp.Size = new Size(167, 24);
            rbNoExp.TabIndex = 0;
            rbNoExp.TabStop = true;
            rbNoExp.Text = "Прежде не работал";
            rbNoExp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(69, 420);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 139);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Другие сведения ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 87);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 6;
            label10.Text = "Категория прав";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(139, 114);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(40, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "C";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(202, 114);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(42, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "D";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(70, 114);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(40, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "B";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(9, 114);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(41, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "A";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(8, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(236, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Водительские удостоверения";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(189, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Наличие личного авто";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(nudSalaryTo);
            groupBox3.Controls.Add(nudSalaryFrom);
            groupBox3.ForeColor = SystemColors.Highlight;
            groupBox3.Location = new Point(398, 420);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(507, 65);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Объём заработной платы";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(248, 31);
            label12.Name = "label12";
            label12.Size = new Size(28, 20);
            label12.TabIndex = 3;
            label12.Text = "До";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(29, 34);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 2;
            label11.Text = "От";
            // 
            // nudSalaryTo
            // 
            nudSalaryTo.Location = new Point(294, 27);
            nudSalaryTo.Maximum = new decimal(new int[] { 7000000, 0, 0, 0 });
            nudSalaryTo.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudSalaryTo.Name = "nudSalaryTo";
            nudSalaryTo.Size = new Size(150, 27);
            nudSalaryTo.TabIndex = 1;
            nudSalaryTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudSalaryFrom
            // 
            nudSalaryFrom.Location = new Point(66, 27);
            nudSalaryFrom.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudSalaryFrom.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudSalaryFrom.Name = "nudSalaryFrom";
            nudSalaryFrom.Size = new Size(150, 27);
            nudSalaryFrom.TabIndex = 0;
            nudSalaryFrom.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton9);
            groupBox4.Controls.Add(radioButton8);
            groupBox4.Controls.Add(radioButton7);
            groupBox4.Controls.Add(radioButton6);
            groupBox4.ForeColor = SystemColors.Highlight;
            groupBox4.Location = new Point(398, 491);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(498, 84);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Предпочитаемый график работы";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.ForeColor = SystemColors.ControlText;
            radioButton9.Location = new Point(215, 56);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(163, 24);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "Посменная работа";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.ForeColor = SystemColors.ControlText;
            radioButton8.Location = new Point(12, 56);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(175, 24);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "Частичная занятость";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.ForeColor = SystemColors.ControlText;
            radioButton7.Location = new Point(215, 26);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(138, 24);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "Работа на дому";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.ForeColor = SystemColors.ControlText;
            radioButton6.Location = new Point(12, 26);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(155, 24);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "Полная занятость";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // txtResume
            // 
            txtResume.Location = new Point(61, 606);
            txtResume.Multiline = true;
            txtResume.Name = "txtResume";
            txtResume.Size = new Size(823, 197);
            txtResume.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(61, 583);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 20;
            label13.Text = "Краткое резюме";
            // 
            // btSave
            // 
            btSave.Location = new Point(319, 842);
            btSave.Name = "btSave";
            btSave.Size = new Size(155, 29);
            btSave.TabIndex = 21;
            btSave.Text = "Сохранить данные";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(491, 842);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 22;
            btClear.Text = "Очистить форму";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(613, 842);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 23;
            btCancel.Text = "Отмена";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(909, 1055);
            Controls.Add(btCancel);
            Controls.Add(btClear);
            Controls.Add(btSave);
            Controls.Add(label13);
            Controls.Add(txtResume);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtPhone);
            Controls.Add(cbOperator);
            Controls.Add(txtEmail);
            Controls.Add(cbRegion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(gbBirthDate);
            Controls.Add(gpGender);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(Label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            gpGender.ResumeLayout(false);
            gpGender.PerformLayout();
            gbBirthDate.ResumeLayout(false);
            gbBirthDate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSalaryTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalaryFrom).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Label2;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private GroupBox gpGender;
        private RadioButton rbWoman;
        private RadioButton rbMale;
        private GroupBox gbBirthDate;
        private ComboBox cbYear;
        private ComboBox cbMonth;
        private ComboBox cbDay;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbRegion;
        private TextBox txtEmail;
        private ComboBox cbOperator;
        private TextBox txtPhone;
        private GroupBox groupBox1;
        private RadioButton rb5plus;
        private RadioButton rb1to5;
        private RadioButton rbLess1;
        private RadioButton rbNoExp;
        private GroupBox groupBox2;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label10;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private NumericUpDown nudSalaryTo;
        private NumericUpDown nudSalaryFrom;
        private GroupBox groupBox4;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private TextBox txtResume;
        private Label label13;
        private Button btSave;
        private Button btClear;
        private Button btCancel;
    }
}

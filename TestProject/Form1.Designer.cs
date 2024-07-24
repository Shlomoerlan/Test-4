namespace TestProject
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DayComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            DatMonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(911, 101);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(703, 101);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "היום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 101);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 3;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 101);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 4;
            label5.Text = "שנה";
            // 
            // DayComboBox
            // 
            DayComboBox.FormattingEnabled = true;
            DayComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayComboBox.Location = new Point(863, 144);
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(182, 33);
            DayComboBox.TabIndex = 5;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(451, 144);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(182, 33);
            MonthComboBox.TabIndex = 6;
            // 
            // DatMonthComboBox
            // 
            DatMonthComboBox.FormattingEnabled = true;
            DatMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DatMonthComboBox.Location = new Point(652, 144);
            DatMonthComboBox.Name = "DatMonthComboBox";
            DatMonthComboBox.Size = new Size(182, 33);
            DatMonthComboBox.TabIndex = 7;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            YearComboBox.Location = new Point(252, 144);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(182, 33);
            YearComboBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(46, 142);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "שליחה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 450);
            Controls.Add(button1);
            Controls.Add(YearComboBox);
            Controls.Add(DatMonthComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(DayComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox DayComboBox;
        private ComboBox MonthComboBox;
        private ComboBox DatMonthComboBox;
        private ComboBox YearComboBox;
        private Button button1;
    }
}

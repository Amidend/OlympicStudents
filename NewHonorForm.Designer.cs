﻿namespace OlympicStudents
{
    partial class NewHonorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            monthCalendar1 = new MonthCalendar();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            listView1 = new ListView();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(11, 820);
            button2.Name = "button2";
            button2.Size = new Size(175, 30);
            button2.TabIndex = 13;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(282, 820);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(175, 30);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(199, 280);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(419, 140);
            richTextBox1.TabIndex = 32;
            richTextBox1.Text = "";
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(199, 96);
            monthCalendar1.Margin = new Padding(12, 13, 12, 13);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 54);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(142, 25);
            label8.TabIndex = 27;
            label8.Text = "Мероприятие";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 427);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 28;
            label7.Text = "Результат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 280);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(189, 25);
            label6.TabIndex = 29;
            label6.Text = "Место проведения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 30;
            label1.Text = "Дата проведения";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(145, 427);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(480, 23);
            textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 54);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(464, 23);
            textBox3.TabIndex = 26;
            // 
            // listView1
            // 
            listView1.Location = new Point(633, 54);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1240, 753);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(633, 815);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(1251, 41);
            button3.TabIndex = 33;
            button3.Text = "Выбрать ученика";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // NewHonorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1884, 861);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NewHonorForm";
            Text = "NewHonorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private MonthCalendar monthCalendar1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private ListView listView1;
        private Button button3;
    }
}
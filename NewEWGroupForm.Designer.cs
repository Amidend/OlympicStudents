namespace OlympicStudents
{
    partial class NewEWGroupForm
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
            SpecializationBox = new ComboBox();
            textBoxEncouragement = new TextBox();
            textBoxRating = new TextBox();
            textBoxGroup = new TextBox();
            textBoxVenue = new TextBox();
            textBoxEvent = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBoxNomination = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(9, 363);
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
            button1.Location = new Point(393, 363);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(175, 30);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpecializationBox
            // 
            SpecializationBox.FormattingEnabled = true;
            SpecializationBox.Items.AddRange(new object[] { "Правоведение", "Коммерческая деятельность", "Банковское дело", "Бухгалтерский учет, анализ и контроль", "Операционная логистика", "Экономика и организация производства", "Программное обеспечение информационных технологий" });
            SpecializationBox.Location = new Point(243, 48);
            SpecializationBox.Margin = new Padding(3, 2, 3, 2);
            SpecializationBox.Name = "SpecializationBox";
            SpecializationBox.Size = new Size(325, 23);
            SpecializationBox.TabIndex = 26;
            // 
            // textBoxEncouragement
            // 
            textBoxEncouragement.Location = new Point(243, 315);
            textBoxEncouragement.Margin = new Padding(3, 2, 3, 2);
            textBoxEncouragement.Name = "textBoxEncouragement";
            textBoxEncouragement.Size = new Size(325, 23);
            textBoxEncouragement.TabIndex = 21;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(243, 285);
            textBoxRating.Margin = new Padding(3, 2, 3, 2);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(325, 23);
            textBoxRating.TabIndex = 22;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(243, 16);
            textBoxGroup.Margin = new Padding(3, 2, 3, 2);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(325, 23);
            textBoxGroup.TabIndex = 23;
            // 
            // textBoxVenue
            // 
            textBoxVenue.Location = new Point(243, 155);
            textBoxVenue.Margin = new Padding(3, 2, 3, 2);
            textBoxVenue.Multiline = true;
            textBoxVenue.Name = "textBoxVenue";
            textBoxVenue.Size = new Size(325, 50);
            textBoxVenue.TabIndex = 24;
            // 
            // textBoxEvent
            // 
            textBoxEvent.Location = new Point(243, 88);
            textBoxEvent.Margin = new Padding(3, 2, 3, 2);
            textBoxEvent.Multiline = true;
            textBoxEvent.Name = "textBoxEvent";
            textBoxEvent.Size = new Size(325, 47);
            textBoxEvent.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(9, 41);
            label12.Name = "label12";
            label12.Size = new Size(168, 30);
            label12.TabIndex = 14;
            label12.Text = "Специальность";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(9, 315);
            label10.Name = "label10";
            label10.Size = new Size(176, 30);
            label10.TabIndex = 15;
            label10.Text = "Вид поощрения";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(9, 285);
            label9.Name = "label9";
            label9.Size = new Size(77, 30);
            label9.TabIndex = 16;
            label9.Text = "Место";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(9, 9);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 17;
            label8.Text = "Группа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 220);
            label3.Name = "label3";
            label3.Size = new Size(131, 30);
            label3.TabIndex = 18;
            label3.Text = "Номинация";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(9, 81);
            label14.Margin = new Padding(0);
            label14.Name = "label14";
            label14.Size = new Size(155, 30);
            label14.TabIndex = 19;
            label14.Text = "Мероприятие";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(9, 148);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.Size = new Size(207, 30);
            label13.TabIndex = 20;
            label13.Text = "Место проведения";
            // 
            // textBoxNomination
            // 
            textBoxNomination.Location = new Point(243, 220);
            textBoxNomination.Margin = new Padding(3, 2, 3, 2);
            textBoxNomination.Multiline = true;
            textBoxNomination.Name = "textBoxNomination";
            textBoxNomination.Size = new Size(325, 50);
            textBoxNomination.TabIndex = 24;
            // 
            // NewEWGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 453);
            Controls.Add(SpecializationBox);
            Controls.Add(textBoxEncouragement);
            Controls.Add(textBoxRating);
            Controls.Add(textBoxGroup);
            Controls.Add(textBoxNomination);
            Controls.Add(textBoxVenue);
            Controls.Add(textBoxEvent);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NewEWGroupForm";
            Text = "NewEWForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox SpecializationBox;
        private TextBox textBoxEncouragement;
        private TextBox textBoxRating;
        private TextBox textBoxGroup;
        private TextBox textBoxVenue;
        private TextBox textBoxEvent;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label14;
        private Label label13;
        private TextBox textBoxNomination;
    }
}
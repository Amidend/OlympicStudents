namespace OlympicStudents
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.addStudent = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addOlimp = new System.Windows.Forms.Button();
            this.UpdateStudent = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.displayOlimp = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(12, 27);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(94, 29);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "+";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(129, 27);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 1;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 582);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addOlimp
            // 
            this.addOlimp.Location = new System.Drawing.Point(844, 27);
            this.addOlimp.Name = "addOlimp";
            this.addOlimp.Size = new System.Drawing.Size(175, 29);
            this.addOlimp.TabIndex = 3;
            this.addOlimp.Text = "Добавить олимпиады";
            this.addOlimp.UseVisualStyleBackColor = true;
            this.addOlimp.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Location = new System.Drawing.Point(744, 27);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(94, 29);
            this.UpdateStudent.TabIndex = 4;
            this.UpdateStudent.Text = "Обновить";
            this.UpdateStudent.UseVisualStyleBackColor = true;
            this.UpdateStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView2
            // 
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView2.Location = new System.Drawing.Point(706, 62);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(618, 582);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // displayOlimp
            // 
            this.displayOlimp.Location = new System.Drawing.Point(240, 31);
            this.displayOlimp.Name = "displayOlimp";
            this.displayOlimp.Size = new System.Drawing.Size(166, 29);
            this.displayOlimp.TabIndex = 5;
            this.displayOlimp.Text = "Показать олимпиады";
            this.displayOlimp.UseVisualStyleBackColor = true;
            this.displayOlimp.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1173, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ексеелахахаххаа";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1336, 673);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.displayOlimp);
            this.Controls.Add(this.UpdateStudent);
            this.Controls.Add(this.addOlimp);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addStudent);
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Button addStudent;
        private Button delete;
        private ListView listView1;
        private Button addOlimp;
        private Button UpdateStudent;
        private ListView listView2;
        private Button displayOlimp;
        private Button button6;
        private DateTimePicker dateTimePicker1;
    }
}
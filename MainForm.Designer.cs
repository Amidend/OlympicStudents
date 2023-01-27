namespace OlympicStudents
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.addOlimp = new System.Windows.Forms.Button();
            this.UpdateStudent = new System.Windows.Forms.Button();
            this.listViewOlimp = new System.Windows.Forms.ListView();
            this.buttonDisplayOlimp = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(12, 27);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(94, 29);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "+";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(129, 27);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewStudent
            // 
            this.listViewStudent.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewStudent.Location = new System.Drawing.Point(12, 66);
            this.listViewStudent.MultiSelect = false;
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(675, 582);
            this.listViewStudent.TabIndex = 2;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addOlimp
            // 
            this.addOlimp.Location = new System.Drawing.Point(806, 27);
            this.addOlimp.Name = "addOlimp";
            this.addOlimp.Size = new System.Drawing.Size(175, 29);
            this.addOlimp.TabIndex = 3;
            this.addOlimp.Text = "Добавить олимпиады";
            this.addOlimp.UseVisualStyleBackColor = true;
            this.addOlimp.Click += new System.EventHandler(this.addOlimp_Click);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Location = new System.Drawing.Point(706, 27);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(94, 29);
            this.UpdateStudent.TabIndex = 4;
            this.UpdateStudent.Text = "Обновить";
            this.UpdateStudent.UseVisualStyleBackColor = true;
            this.UpdateStudent.Click += new System.EventHandler(this.UpdateDataStudent_Click);
            // 
            // listViewOlimp
            // 
            this.listViewOlimp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOlimp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewOlimp.Location = new System.Drawing.Point(792, 62);
            this.listViewOlimp.MultiSelect = false;
            this.listViewOlimp.Name = "listViewOlimp";
            this.listViewOlimp.Size = new System.Drawing.Size(618, 582);
            this.listViewOlimp.TabIndex = 2;
            this.listViewOlimp.UseCompatibleStateImageBehavior = false;
            // 
            // buttonDisplayOlimp
            // 
            this.buttonDisplayOlimp.Location = new System.Drawing.Point(240, 31);
            this.buttonDisplayOlimp.Name = "buttonDisplayOlimp";
            this.buttonDisplayOlimp.Size = new System.Drawing.Size(177, 29);
            this.buttonDisplayOlimp.TabIndex = 5;
            this.buttonDisplayOlimp.Text = "Показать олимпиады";
            this.buttonDisplayOlimp.UseVisualStyleBackColor = true;
            this.buttonDisplayOlimp.Click += new System.EventHandler(this.buttonDisplayOlimp_Click);
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(1173, 26);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(151, 29);
            this.excel.TabIndex = 6;
            this.excel.Text = "excel отчет";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(997, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(423, 31);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(125, 27);
            this.textBoxSearch.TabIndex = 8;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(593, 27);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 29);
            this.search.TabIndex = 9;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.buttonDisplayOlimp);
            this.Controls.Add(this.UpdateStudent);
            this.Controls.Add(this.addOlimp);
            this.Controls.Add(this.listViewOlimp);
            this.Controls.Add(this.listViewStudent);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddStudent);
            this.HelpButton = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Олимпиады";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonAddStudent;
        private Button buttonDelete;
        private ListView listViewStudent;
        private Button addOlimp;
        private Button UpdateStudent;
        private ListView listViewOlimp;
        private Button buttonDisplayOlimp;
        private Button excel;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxSearch;
        private Button search;
    }
}
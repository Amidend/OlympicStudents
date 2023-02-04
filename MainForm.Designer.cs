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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.listViewOlimp = new System.Windows.Forms.ListView();
            this.excel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMenuStudents = new System.Windows.Forms.Panel();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewOlympiadsOfStudent = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelMenuStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(227, 965);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(82, 22);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "+";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 965);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 22);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewStudent
            // 
            this.listViewStudent.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listViewItem1.StateImageIndex = 0;
            this.listViewStudent.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewStudent.Location = new System.Drawing.Point(379, -3);
            this.listViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewStudent.MultiSelect = false;
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(1112, 504);
            this.listViewStudent.TabIndex = 2;
            this.listViewStudent.TabStop = false;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewStudents_MouseOneClick);
            // 
            // listViewOlimp
            // 
            this.listViewOlimp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewOlimp.Location = new System.Drawing.Point(3, 3);
            this.listViewOlimp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOlimp.MultiSelect = false;
            this.listViewOlimp.Name = "listViewOlimp";
            this.listViewOlimp.Size = new System.Drawing.Size(1500, 1007);
            this.listViewOlimp.TabIndex = 2;
            this.listViewOlimp.UseCompatibleStateImageBehavior = false;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(32, 80);
            this.excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(132, 22);
            this.excel.TabIndex = 6;
            this.excel.Text = "excel отчет";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 5);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1904, 1041);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMenuStudents);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1896, 1013);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPageStudent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelMenuStudents
            // 
            this.panelMenuStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuStudents.Controls.Add(this.checkedListBox2);
            this.panelMenuStudents.Controls.Add(this.checkedListBox1);
            this.panelMenuStudents.Controls.Add(this.label11);
            this.panelMenuStudents.Controls.Add(this.label1);
            this.panelMenuStudents.Controls.Add(this.textBoxSearch);
            this.panelMenuStudents.Controls.Add(this.buttonDelete);
            this.panelMenuStudents.Controls.Add(this.search);
            this.panelMenuStudents.Controls.Add(this.buttonAddStudent);
            this.panelMenuStudents.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuStudents.Location = new System.Drawing.Point(1578, 3);
            this.panelMenuStudents.Name = "panelMenuStudents";
            this.panelMenuStudents.Size = new System.Drawing.Size(315, 1007);
            this.panelMenuStudents.TabIndex = 12;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.checkedListBox2.Location = new System.Drawing.Point(3, 312);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(306, 76);
            this.checkedListBox2.TabIndex = 16;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Правоведение",
            "Коммерческая деятельность",
            "Банковское дело",
            "Бухгалтерский учет, анализ и контроль",
            "Операционная логистика",
            "Экономика и организация производства",
            "Программное обеспечение информационных технологий"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 155);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(306, 130);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "Курс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Специальность";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 2);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(211, 23);
            this.textBoxSearch.TabIndex = 11;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(3, 29);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(211, 22);
            this.search.TabIndex = 10;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewStudent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewOlympiadsOfStudent);
            this.splitContainer1.Size = new System.Drawing.Size(1890, 1007);
            this.splitContainer1.SplitterDistance = 503;
            this.splitContainer1.TabIndex = 13;
            // 
            // listViewOlympiadsOfStudent
            // 
            this.listViewOlympiadsOfStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOlympiadsOfStudent.Location = new System.Drawing.Point(7, 166);
            this.listViewOlympiadsOfStudent.MultiSelect = false;
            this.listViewOlympiadsOfStudent.Name = "listViewOlympiadsOfStudent";
            this.listViewOlympiadsOfStudent.Size = new System.Drawing.Size(1890, 329);
            this.listViewOlympiadsOfStudent.TabIndex = 6;
            this.listViewOlympiadsOfStudent.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listViewOlimp);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1896, 1013);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.excel);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1896, 1013);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1610, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabMain);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Олимпиады";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelMenuStudents.ResumeLayout(false);
            this.panelMenuStudents.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonAddStudent;
        private Button buttonDelete;
        private ListView listViewStudent;
        private ListView listViewOlimp;
        private Button excel;
        private DateTimePicker dateTimePicker1;
        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView listViewOlympiadsOfStudent;
        private TextBox textBoxSearch;
        private Button search;
        private Panel panelMenuStudents;
        private SplitContainer splitContainer1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label11;
        private CheckedListBox checkedListBox2;
        private Button button1;
    }
}
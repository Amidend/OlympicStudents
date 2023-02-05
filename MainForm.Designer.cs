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
            this.listViewOlimp = new System.Windows.Forms.ListView();
            this.excel = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.panelMenuStudents = new System.Windows.Forms.Panel();
            this.buttonDumping = new System.Windows.Forms.Button();
            this.checkedListBoxSearch = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxCourse = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxSpecialization = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewOlympiadsOfStudent = new System.Windows.Forms.ListView();
            this.tabPageOlimpiad = new System.Windows.Forms.TabPage();
            this.buttonDumpingOlimpyad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSearchOlimpyad = new System.Windows.Forms.TextBox();
            this.checkedListBoxEnco = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAvards = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxLevel = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxSearchOlipyad = new System.Windows.Forms.CheckedListBox();
            this.labelcou = new System.Windows.Forms.Label();
            this.labelph3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labeldob = new System.Windows.Forms.Label();
            this.labelspe = new System.Windows.Forms.Label();
            this.labelyor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelph2 = new System.Windows.Forms.Label();
            this.labelfio = new System.Windows.Forms.Label();
            this.labelyap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelph1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelgro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labeladd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageExcel = new System.Windows.Forms.TabPage();
            this.checkedListBoxCriteriaExcel = new System.Windows.Forms.CheckedListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabMain.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            this.panelMenuStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPageOlimpiad.SuspendLayout();
            this.tabPageExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(180, 940);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(130, 30);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "Добавить ученика";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(5, 940);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
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
            listViewItem3.StateImageIndex = 0;
            this.listViewStudent.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewStudent.Location = new System.Drawing.Point(379, -3);
            this.listViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewStudent.MultiSelect = false;
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(1112, 503);
            this.listViewStudent.TabIndex = 2;
            this.listViewStudent.TabStop = false;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewStudents_MouseOneClick);
            // 
            // listViewOlimp
            // 
            this.listViewOlimp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewOlimp.Location = new System.Drawing.Point(3, 3);
            this.listViewOlimp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewOlimp.MultiSelect = false;
            this.listViewOlimp.Name = "listViewOlimp";
            this.listViewOlimp.Size = new System.Drawing.Size(1500, 1007);
            this.listViewOlimp.TabIndex = 2;
            this.listViewOlimp.UseCompatibleStateImageBehavior = false;
            this.listViewOlimp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewOlimp_MouseOneClick);
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(8, 201);
            this.excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(132, 22);
            this.excel.TabIndex = 6;
            this.excel.Text = "excel отчет";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_ClickAsync);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageStudent);
            this.tabMain.Controls.Add(this.tabPageOlimpiad);
            this.tabMain.Controls.Add(this.tabPageExcel);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.HotTrack = true;
            this.tabMain.ItemSize = new System.Drawing.Size(64, 20);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1904, 1041);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 10;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.panelMenuStudents);
            this.tabPageStudent.Controls.Add(this.splitContainer1);
            this.tabPageStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 24);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(1896, 1013);
            this.tabPageStudent.TabIndex = 0;
            this.tabPageStudent.Text = "Студенты";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // panelMenuStudents
            // 
            this.panelMenuStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuStudents.Controls.Add(this.buttonDumping);
            this.panelMenuStudents.Controls.Add(this.checkedListBoxSearch);
            this.panelMenuStudents.Controls.Add(this.checkedListBoxCourse);
            this.panelMenuStudents.Controls.Add(this.checkedListBoxSpecialization);
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
            // buttonDumping
            // 
            this.buttonDumping.Location = new System.Drawing.Point(5, 433);
            this.buttonDumping.Name = "buttonDumping";
            this.buttonDumping.Size = new System.Drawing.Size(306, 23);
            this.buttonDumping.TabIndex = 18;
            this.buttonDumping.Text = "Сборс";
            this.buttonDumping.UseVisualStyleBackColor = true;
            this.buttonDumping.Click += new System.EventHandler(this.buttonDumping_Click);
            // 
            // checkedListBoxSearch
            // 
            this.checkedListBoxSearch.CheckOnClick = true;
            this.checkedListBoxSearch.FormattingEnabled = true;
            this.checkedListBoxSearch.Items.AddRange(new object[] {
            "ФИО",
            "Дата рождения",
            "Адрес",
            "Номер телефона",
            "Группа",
            "Дата поступления",
            "Дата выпуска",
            "Курс",
            "Специализация"});
            this.checkedListBoxSearch.Location = new System.Drawing.Point(5, 3);
            this.checkedListBoxSearch.MultiColumn = true;
            this.checkedListBoxSearch.Name = "checkedListBoxSearch";
            this.checkedListBoxSearch.Size = new System.Drawing.Size(304, 94);
            this.checkedListBoxSearch.TabIndex = 17;
            // 
            // checkedListBoxCourse
            // 
            this.checkedListBoxCourse.CheckOnClick = true;
            this.checkedListBoxCourse.FormattingEnabled = true;
            this.checkedListBoxCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.checkedListBoxCourse.Location = new System.Drawing.Point(5, 351);
            this.checkedListBoxCourse.Name = "checkedListBoxCourse";
            this.checkedListBoxCourse.Size = new System.Drawing.Size(304, 76);
            this.checkedListBoxCourse.TabIndex = 16;
            this.checkedListBoxCourse.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCourse_SelectedIndexChanged);
            // 
            // checkedListBoxSpecialization
            // 
            this.checkedListBoxSpecialization.CheckOnClick = true;
            this.checkedListBoxSpecialization.FormattingEnabled = true;
            this.checkedListBoxSpecialization.Items.AddRange(new object[] {
            "Правоведение",
            "Коммерческая деятельность",
            "Банковское дело",
            "Бухгалтерский учет, анализ и контроль",
            "Операционная логистика",
            "Экономика и организация производства",
            "Программное обеспечение информационных технологий"});
            this.checkedListBoxSpecialization.Location = new System.Drawing.Point(5, 194);
            this.checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            this.checkedListBoxSpecialization.Size = new System.Drawing.Size(304, 130);
            this.checkedListBoxSpecialization.TabIndex = 16;
            this.checkedListBoxSpecialization.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSpecialization_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "Курс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Специальность";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(5, 102);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(306, 23);
            this.textBoxSearch.TabIndex = 11;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(5, 129);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(306, 22);
            this.search.TabIndex = 10;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.TabIndex = 13;
            // 
            // listViewOlympiadsOfStudent
            // 
            this.listViewOlympiadsOfStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOlympiadsOfStudent.Location = new System.Drawing.Point(7, 167);
            this.listViewOlympiadsOfStudent.MultiSelect = false;
            this.listViewOlympiadsOfStudent.Name = "listViewOlympiadsOfStudent";
            this.listViewOlympiadsOfStudent.Size = new System.Drawing.Size(1890, 329);
            this.listViewOlympiadsOfStudent.TabIndex = 6;
            this.listViewOlympiadsOfStudent.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageOlimpiad
            // 
            this.tabPageOlimpiad.Controls.Add(this.buttonDumpingOlimpyad);
            this.tabPageOlimpiad.Controls.Add(this.button3);
            this.tabPageOlimpiad.Controls.Add(this.textBoxSearchOlimpyad);
            this.tabPageOlimpiad.Controls.Add(this.checkedListBoxEnco);
            this.tabPageOlimpiad.Controls.Add(this.checkedListBoxAvards);
            this.tabPageOlimpiad.Controls.Add(this.checkedListBoxType);
            this.tabPageOlimpiad.Controls.Add(this.checkedListBoxLevel);
            this.tabPageOlimpiad.Controls.Add(this.checkedListBoxSearchOlipyad);
            this.tabPageOlimpiad.Controls.Add(this.labelcou);
            this.tabPageOlimpiad.Controls.Add(this.labelph3);
            this.tabPageOlimpiad.Controls.Add(this.label10);
            this.tabPageOlimpiad.Controls.Add(this.labeldob);
            this.tabPageOlimpiad.Controls.Add(this.labelspe);
            this.tabPageOlimpiad.Controls.Add(this.labelyor);
            this.tabPageOlimpiad.Controls.Add(this.label6);
            this.tabPageOlimpiad.Controls.Add(this.labelph2);
            this.tabPageOlimpiad.Controls.Add(this.labelfio);
            this.tabPageOlimpiad.Controls.Add(this.labelyap);
            this.tabPageOlimpiad.Controls.Add(this.label9);
            this.tabPageOlimpiad.Controls.Add(this.labelph1);
            this.tabPageOlimpiad.Controls.Add(this.label5);
            this.tabPageOlimpiad.Controls.Add(this.label15);
            this.tabPageOlimpiad.Controls.Add(this.labelgro);
            this.tabPageOlimpiad.Controls.Add(this.label8);
            this.tabPageOlimpiad.Controls.Add(this.labeladd);
            this.tabPageOlimpiad.Controls.Add(this.label4);
            this.tabPageOlimpiad.Controls.Add(this.label13);
            this.tabPageOlimpiad.Controls.Add(this.label7);
            this.tabPageOlimpiad.Controls.Add(this.label12);
            this.tabPageOlimpiad.Controls.Add(this.label3);
            this.tabPageOlimpiad.Controls.Add(this.label18);
            this.tabPageOlimpiad.Controls.Add(this.label17);
            this.tabPageOlimpiad.Controls.Add(this.label16);
            this.tabPageOlimpiad.Controls.Add(this.label14);
            this.tabPageOlimpiad.Controls.Add(this.label21);
            this.tabPageOlimpiad.Controls.Add(this.label2);
            this.tabPageOlimpiad.Controls.Add(this.button2);
            this.tabPageOlimpiad.Controls.Add(this.button1);
            this.tabPageOlimpiad.Controls.Add(this.listViewOlimp);
            this.tabPageOlimpiad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageOlimpiad.Location = new System.Drawing.Point(4, 24);
            this.tabPageOlimpiad.Name = "tabPageOlimpiad";
            this.tabPageOlimpiad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOlimpiad.Size = new System.Drawing.Size(1896, 1013);
            this.tabPageOlimpiad.TabIndex = 1;
            this.tabPageOlimpiad.Text = "Олимпиады";
            this.tabPageOlimpiad.UseVisualStyleBackColor = true;
            // 
            // buttonDumpingOlimpyad
            // 
            this.buttonDumpingOlimpyad.Location = new System.Drawing.Point(1510, 454);
            this.buttonDumpingOlimpyad.Name = "buttonDumpingOlimpyad";
            this.buttonDumpingOlimpyad.Size = new System.Drawing.Size(380, 23);
            this.buttonDumpingOlimpyad.TabIndex = 9;
            this.buttonDumpingOlimpyad.Text = "Сброс";
            this.buttonDumpingOlimpyad.UseVisualStyleBackColor = true;
            this.buttonDumpingOlimpyad.Click += new System.EventHandler(this.buttonDumpingOlimpyad_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1510, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(378, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSearchOlympyad_Click);
            // 
            // textBoxSearchOlimpyad
            // 
            this.textBoxSearchOlimpyad.Location = new System.Drawing.Point(1510, 106);
            this.textBoxSearchOlimpyad.Name = "textBoxSearchOlimpyad";
            this.textBoxSearchOlimpyad.Size = new System.Drawing.Size(378, 23);
            this.textBoxSearchOlimpyad.TabIndex = 7;
            // 
            // checkedListBoxEnco
            // 
            this.checkedListBoxEnco.CheckOnClick = true;
            this.checkedListBoxEnco.FormattingEnabled = true;
            this.checkedListBoxEnco.Items.AddRange(new object[] {
            "Благодарность",
            "Доска почета",
            "Именная стипендия",
            "Скидка в оплате за обучение",
            "Без поощрения"});
            this.checkedListBoxEnco.Location = new System.Drawing.Point(1510, 390);
            this.checkedListBoxEnco.MultiColumn = true;
            this.checkedListBoxEnco.Name = "checkedListBoxEnco";
            this.checkedListBoxEnco.Size = new System.Drawing.Size(378, 58);
            this.checkedListBoxEnco.TabIndex = 6;
            // 
            // checkedListBoxAvards
            // 
            this.checkedListBoxAvards.CheckOnClick = true;
            this.checkedListBoxAvards.FormattingEnabled = true;
            this.checkedListBoxAvards.Items.AddRange(new object[] {
            "Диплом I степени",
            "Диплом II степени",
            "Диплом III степени",
            "Грамота",
            "Сертификат",
            "Без награды"});
            this.checkedListBoxAvards.Location = new System.Drawing.Point(1510, 305);
            this.checkedListBoxAvards.MultiColumn = true;
            this.checkedListBoxAvards.Name = "checkedListBoxAvards";
            this.checkedListBoxAvards.Size = new System.Drawing.Size(378, 58);
            this.checkedListBoxAvards.TabIndex = 6;
            // 
            // checkedListBoxType
            // 
            this.checkedListBoxType.CheckOnClick = true;
            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Items.AddRange(new object[] {
            "Конференция",
            "Олимпиада"});
            this.checkedListBoxType.Location = new System.Drawing.Point(1510, 256);
            this.checkedListBoxType.MultiColumn = true;
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(378, 22);
            this.checkedListBoxType.TabIndex = 6;
            // 
            // checkedListBoxLevel
            // 
            this.checkedListBoxLevel.CheckOnClick = true;
            this.checkedListBoxLevel.FormattingEnabled = true;
            this.checkedListBoxLevel.Items.AddRange(new object[] {
            "Колледж",
            "Район",
            "Город",
            "Республиканская",
            "Международная"});
            this.checkedListBoxLevel.Location = new System.Drawing.Point(1510, 189);
            this.checkedListBoxLevel.MultiColumn = true;
            this.checkedListBoxLevel.Name = "checkedListBoxLevel";
            this.checkedListBoxLevel.Size = new System.Drawing.Size(378, 40);
            this.checkedListBoxLevel.TabIndex = 6;
            // 
            // checkedListBoxSearchOlipyad
            // 
            this.checkedListBoxSearchOlipyad.CheckOnClick = true;
            this.checkedListBoxSearchOlipyad.FormattingEnabled = true;
            this.checkedListBoxSearchOlipyad.Items.AddRange(new object[] {
            "Дата",
            "Уровень",
            "Вид",
            "Награда",
            "Поощерение",
            "Номинации",
            "Продалжительность",
            "Название",
            "Место проведения"});
            this.checkedListBoxSearchOlipyad.Location = new System.Drawing.Point(1510, 6);
            this.checkedListBoxSearchOlipyad.MultiColumn = true;
            this.checkedListBoxSearchOlipyad.Name = "checkedListBoxSearchOlipyad";
            this.checkedListBoxSearchOlipyad.Size = new System.Drawing.Size(378, 94);
            this.checkedListBoxSearchOlipyad.TabIndex = 6;
            // 
            // labelcou
            // 
            this.labelcou.AutoSize = true;
            this.labelcou.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcou.Location = new System.Drawing.Point(1691, 815);
            this.labelcou.Name = "labelcou";
            this.labelcou.Size = new System.Drawing.Size(0, 21);
            this.labelcou.TabIndex = 5;
            // 
            // labelph3
            // 
            this.labelph3.AutoSize = true;
            this.labelph3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelph3.Location = new System.Drawing.Point(1691, 696);
            this.labelph3.Name = "labelph3";
            this.labelph3.Size = new System.Drawing.Size(0, 21);
            this.labelph3.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1509, 750);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Дата поступления";
            // 
            // labeldob
            // 
            this.labeldob.AutoSize = true;
            this.labeldob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldob.Location = new System.Drawing.Point(1691, 545);
            this.labeldob.Name = "labeldob";
            this.labeldob.Size = new System.Drawing.Size(0, 21);
            this.labeldob.TabIndex = 5;
            // 
            // labelspe
            // 
            this.labelspe.AutoSize = true;
            this.labelspe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelspe.Location = new System.Drawing.Point(1691, 845);
            this.labelspe.Name = "labelspe";
            this.labelspe.Size = new System.Drawing.Size(0, 21);
            this.labelspe.TabIndex = 5;
            // 
            // labelyor
            // 
            this.labelyor.AutoSize = true;
            this.labelyor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelyor.Location = new System.Drawing.Point(1691, 785);
            this.labelyor.Name = "labelyor";
            this.labelyor.Size = new System.Drawing.Size(0, 21);
            this.labelyor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1539, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Мобильный 1";
            // 
            // labelph2
            // 
            this.labelph2.AutoSize = true;
            this.labelph2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelph2.Location = new System.Drawing.Point(1691, 665);
            this.labelph2.Name = "labelph2";
            this.labelph2.Size = new System.Drawing.Size(0, 21);
            this.labelph2.TabIndex = 5;
            // 
            // labelfio
            // 
            this.labelfio.AutoSize = true;
            this.labelfio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelfio.Location = new System.Drawing.Point(1691, 515);
            this.labelfio.Name = "labelfio";
            this.labelfio.Size = new System.Drawing.Size(0, 21);
            this.labelfio.TabIndex = 5;
            // 
            // labelyap
            // 
            this.labelyap.AutoSize = true;
            this.labelyap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelyap.Location = new System.Drawing.Point(1691, 755);
            this.labelyap.Name = "labelyap";
            this.labelyap.Size = new System.Drawing.Size(0, 21);
            this.labelyap.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1508, 720);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Группа";
            // 
            // labelph1
            // 
            this.labelph1.AutoSize = true;
            this.labelph1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelph1.Location = new System.Drawing.Point(1691, 635);
            this.labelph1.Name = "labelph1";
            this.labelph1.Size = new System.Drawing.Size(0, 21);
            this.labelph1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1509, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер телефона";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(1509, 840);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "Специализация";
            // 
            // labelgro
            // 
            this.labelgro.AutoSize = true;
            this.labelgro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelgro.Location = new System.Drawing.Point(1691, 725);
            this.labelgro.Name = "labelgro";
            this.labelgro.Size = new System.Drawing.Size(0, 21);
            this.labelgro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1539, 690);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Домашний";
            // 
            // labeladd
            // 
            this.labeladd.AutoSize = true;
            this.labeladd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeladd.Location = new System.Drawing.Point(1691, 575);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(0, 21);
            this.labeladd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1510, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адрес";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1509, 810);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Курс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1539, 660);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Мобильный 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1509, 780);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Дата выпуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1510, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата рождения";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(1510, 366);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 21);
            this.label18.TabIndex = 5;
            this.label18.Text = "Поощерение";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1510, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 21);
            this.label17.TabIndex = 5;
            this.label17.Text = "Награды";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(1510, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "Вид";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1510, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "Уровень";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(1510, 480);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(219, 25);
            this.label21.TabIndex = 5;
            this.label21.Text = "Информация о ученике";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1509, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1510, 940);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1730, 940);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить олимпиаду";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddOlimpiads_Click);
            // 
            // tabPageExcel
            // 
            this.tabPageExcel.Controls.Add(this.checkedListBoxCriteriaExcel);
            this.tabPageExcel.Controls.Add(this.label19);
            this.tabPageExcel.Controls.Add(this.numericUpDown1);
            this.tabPageExcel.Controls.Add(this.excel);
            this.tabPageExcel.Location = new System.Drawing.Point(4, 24);
            this.tabPageExcel.Name = "tabPageExcel";
            this.tabPageExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExcel.Size = new System.Drawing.Size(1896, 1013);
            this.tabPageExcel.TabIndex = 2;
            this.tabPageExcel.Text = "Отчёт";
            this.tabPageExcel.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCriteriaExcel
            // 
            this.checkedListBoxCriteriaExcel.FormattingEnabled = true;
            this.checkedListBoxCriteriaExcel.Items.AddRange(new object[] {
            "Правоведение",
            "Коммерческая деятельность",
            "Банковское дело",
            "Бухгалтерский учет, анализ и контроль",
            "Операционная логистика",
            "Экономика и организация производства",
            "Программное обеспечение информационных технологий"});
            this.checkedListBoxCriteriaExcel.Location = new System.Drawing.Point(8, 48);
            this.checkedListBoxCriteriaExcel.MultiColumn = true;
            this.checkedListBoxCriteriaExcel.Name = "checkedListBoxCriteriaExcel";
            this.checkedListBoxCriteriaExcel.Size = new System.Drawing.Size(143, 148);
            this.checkedListBoxCriteriaExcel.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(8, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "Учебный год";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(164, 17);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
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
            this.tabPageStudent.ResumeLayout(false);
            this.panelMenuStudents.ResumeLayout(false);
            this.panelMenuStudents.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPageOlimpiad.ResumeLayout(false);
            this.tabPageOlimpiad.PerformLayout();
            this.tabPageExcel.ResumeLayout(false);
            this.tabPageExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonAddStudent;
        private Button buttonDelete;
        private ListView listViewStudent;
        private ListView listViewOlimp;
        private Button excel;
        private TabControl tabMain;
        private TabPage tabPageStudent;
        private TabPage tabPageOlimpiad;
        private TabPage tabPageExcel;
        private ListView listViewOlympiadsOfStudent;
        private TextBox textBoxSearch;
        private Button search;
        private Panel panelMenuStudents;
        private SplitContainer splitContainer1;
        private Label label1;
        private CheckedListBox checkedListBoxSpecialization;
        private Label label11;
        private CheckedListBox checkedListBoxCourse;
        private Button button1;
        private CheckedListBox checkedListBoxSearch;
        private Button buttonDumping;
        private Button button2;
        private Label labelph3;
        private Label label10;
        private Label labeldob;
        private Label label6;
        private Label labelph2;
        private Label labelfio;
        private Label label9;
        private Label labelph1;
        private Label label5;
        private Label label15;
        private Label label8;
        private Label labeladd;
        private Label label4;
        private Label label13;
        private Label label7;
        private Label label12;
        private Label label3;
        private Label label21;
        private Label label2;
        private Label labelcou;
        private Label labelspe;
        private Label labelyor;
        private Label labelyap;
        private Label labelgro;
        private Button buttonDumpingOlimpyad;
        private Button button3;
        private TextBox textBoxSearchOlimpyad;
        private CheckedListBox checkedListBoxLevel;
        private CheckedListBox checkedListBoxSearchOlipyad;
        private CheckedListBox checkedListBoxType;
        private Label label16;
        private Label label14;
        private CheckedListBox checkedListBoxEnco;
        private CheckedListBox checkedListBoxAvards;
        private Label label18;
        private Label label17;
        private NumericUpDown numericUpDown1;
        private CheckedListBox checkedListBoxCriteriaExcel;
        private Label label19;
    }
}
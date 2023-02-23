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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            buttonAddStudent = new Button();
            buttonDelete = new Button();
            listViewStudent = new ListView();
            listViewOlimp = new ListView();
            excel = new Button();
            tabMain = new TabControl();
            tabPageStudent = new TabPage();
            panelMenuStudents = new Panel();
            buttonDumping = new Button();
            checkedListBoxSearch = new CheckedListBox();
            checkedListBoxCourse = new CheckedListBox();
            checkedListBoxSpecialization = new CheckedListBox();
            label11 = new Label();
            label1 = new Label();
            textBoxSearchStudents = new TextBox();
            search = new Button();
            splitContainer1 = new SplitContainer();
            listViewOlympiadsOfStudent = new ListView();
            tabPageOlimpiad = new TabPage();
            buttonDumpingOlimpyad = new Button();
            button3 = new Button();
            textBoxSearchOlimpyad = new TextBox();
            checkedListBoxEnco = new CheckedListBox();
            checkedListBoxAvards = new CheckedListBox();
            checkedListBoxType = new CheckedListBox();
            checkedListBoxLevel = new CheckedListBox();
            checkedListBoxSearchOlipyad = new CheckedListBox();
            labelcou = new Label();
            labelph3 = new Label();
            label10 = new Label();
            labeldob = new Label();
            labelspe = new Label();
            labelyor = new Label();
            label6 = new Label();
            labelph2 = new Label();
            labelfio = new Label();
            labelyap = new Label();
            label9 = new Label();
            labelph1 = new Label();
            label5 = new Label();
            label15 = new Label();
            labelgro = new Label();
            label8 = new Label();
            labeladd = new Label();
            label4 = new Label();
            label13 = new Label();
            label7 = new Label();
            label12 = new Label();
            label3 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            label21 = new Label();
            label2 = new Label();
            DeleteOlimp = new Button();
            button1 = new Button();
            tabPageExcel = new TabPage();
            checkedListBoxCriteriaExcel = new CheckedListBox();
            label20 = new Label();
            label19 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            tabPageReport = new TabPage();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            tabMain.SuspendLayout();
            tabPageStudent.SuspendLayout();
            panelMenuStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabPageOlimpiad.SuspendLayout();
            tabPageExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPageReport.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(180, 940);
            buttonAddStudent.Margin = new Padding(3, 2, 3, 2);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(130, 30);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить ученика";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(5, 940);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 30);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += deleteStudents_Click;
            // 
            // listViewStudent
            // 
            listViewStudent.Activation = ItemActivation.OneClick;
            listViewStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewStudent.BorderStyle = BorderStyle.FixedSingle;
            listViewStudent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listViewItem1.StateImageIndex = 0;
            listViewStudent.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewStudent.Location = new Point(379, -3);
            listViewStudent.Margin = new Padding(3, 2, 3, 2);
            listViewStudent.MultiSelect = false;
            listViewStudent.Name = "listViewStudent";
            listViewStudent.Size = new Size(1112, 503);
            listViewStudent.TabIndex = 2;
            listViewStudent.TabStop = false;
            listViewStudent.UseCompatibleStateImageBehavior = false;
            listViewStudent.MouseClick += listViewStudents_MouseOneClick;
            // 
            // listViewOlimp
            // 
            listViewOlimp.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listViewOlimp.Location = new Point(3, 3);
            listViewOlimp.Margin = new Padding(3, 2, 3, 2);
            listViewOlimp.MultiSelect = false;
            listViewOlimp.Name = "listViewOlimp";
            listViewOlimp.Size = new Size(1500, 1007);
            listViewOlimp.TabIndex = 2;
            listViewOlimp.UseCompatibleStateImageBehavior = false;
            listViewOlimp.MouseClick += listViewOlimp_MouseOneClick;
            // 
            // excel
            // 
            excel.Location = new Point(8, 201);
            excel.Margin = new Padding(3, 2, 3, 2);
            excel.Name = "excel";
            excel.Size = new Size(132, 22);
            excel.TabIndex = 6;
            excel.Text = "excel отчет";
            excel.UseVisualStyleBackColor = true;
            excel.Click += excelReport_ClickAsync;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPageStudent);
            tabMain.Controls.Add(tabPageOlimpiad);
            tabMain.Controls.Add(tabPageExcel);
            tabMain.Controls.Add(tabPageReport);
            tabMain.Dock = DockStyle.Fill;
            tabMain.HotTrack = true;
            tabMain.ItemSize = new Size(64, 20);
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1904, 1041);
            tabMain.SizeMode = TabSizeMode.FillToRight;
            tabMain.TabIndex = 10;
            // 
            // tabPageStudent
            // 
            tabPageStudent.Controls.Add(panelMenuStudents);
            tabPageStudent.Controls.Add(splitContainer1);
            tabPageStudent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPageStudent.Location = new Point(4, 24);
            tabPageStudent.Name = "tabPageStudent";
            tabPageStudent.Padding = new Padding(3);
            tabPageStudent.Size = new Size(1896, 1013);
            tabPageStudent.TabIndex = 0;
            tabPageStudent.Text = "Студенты";
            tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // panelMenuStudents
            // 
            panelMenuStudents.BorderStyle = BorderStyle.FixedSingle;
            panelMenuStudents.Controls.Add(buttonDumping);
            panelMenuStudents.Controls.Add(checkedListBoxSearch);
            panelMenuStudents.Controls.Add(checkedListBoxCourse);
            panelMenuStudents.Controls.Add(checkedListBoxSpecialization);
            panelMenuStudents.Controls.Add(label11);
            panelMenuStudents.Controls.Add(label1);
            panelMenuStudents.Controls.Add(textBoxSearchStudents);
            panelMenuStudents.Controls.Add(buttonDelete);
            panelMenuStudents.Controls.Add(search);
            panelMenuStudents.Controls.Add(buttonAddStudent);
            panelMenuStudents.Dock = DockStyle.Right;
            panelMenuStudents.Location = new Point(1578, 3);
            panelMenuStudents.Name = "panelMenuStudents";
            panelMenuStudents.Size = new Size(315, 1007);
            panelMenuStudents.TabIndex = 12;
            // 
            // buttonDumping
            // 
            buttonDumping.Location = new Point(5, 433);
            buttonDumping.Name = "buttonDumping";
            buttonDumping.Size = new Size(306, 23);
            buttonDumping.TabIndex = 18;
            buttonDumping.Text = "Сброс";
            buttonDumping.UseVisualStyleBackColor = true;
            buttonDumping.Click += buttonDumpingStudents_Click;
            // 
            // checkedListBoxSearch
            // 
            checkedListBoxSearch.CheckOnClick = true;
            checkedListBoxSearch.FormattingEnabled = true;
            checkedListBoxSearch.Items.AddRange(new object[] { "ФИО", "Дата рождения", "Адрес", "Номер телефона", "Группа", "Дата поступления", "Дата выпуска", "Курс", "Специализация" });
            checkedListBoxSearch.Location = new Point(5, 3);
            checkedListBoxSearch.MultiColumn = true;
            checkedListBoxSearch.Name = "checkedListBoxSearch";
            checkedListBoxSearch.Size = new Size(304, 94);
            checkedListBoxSearch.TabIndex = 17;
            // 
            // checkedListBoxCourse
            // 
            checkedListBoxCourse.CheckOnClick = true;
            checkedListBoxCourse.FormattingEnabled = true;
            checkedListBoxCourse.Items.AddRange(new object[] { "1", "2", "3", "4" });
            checkedListBoxCourse.Location = new Point(5, 351);
            checkedListBoxCourse.Name = "checkedListBoxCourse";
            checkedListBoxCourse.Size = new Size(304, 76);
            checkedListBoxCourse.TabIndex = 16;
            checkedListBoxCourse.SelectedIndexChanged += checkBoxesStudents_CheckedChanged;
            // 
            // checkedListBoxSpecialization
            // 
            checkedListBoxSpecialization.CheckOnClick = true;
            checkedListBoxSpecialization.FormattingEnabled = true;
            checkedListBoxSpecialization.Items.AddRange(new object[] { "Правоведение", "Коммерческая деятельность", "Банковское дело", "Бухгалтерский учет, анализ и контроль", "Операционная логистика", "Экономика и организация производства", "Программное обеспечение информационных технологий" });
            checkedListBoxSpecialization.Location = new Point(5, 194);
            checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            checkedListBoxSpecialization.Size = new Size(304, 130);
            checkedListBoxSpecialization.TabIndex = 16;
            checkedListBoxSpecialization.SelectedIndexChanged += checkBoxesStudents_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(5, 327);
            label11.Name = "label11";
            label11.Size = new Size(46, 21);
            label11.TabIndex = 15;
            label11.Text = "Курс";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 170);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 13;
            label1.Text = "Специальность";
            // 
            // textBoxSearchStudents
            // 
            textBoxSearchStudents.Location = new Point(5, 102);
            textBoxSearchStudents.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchStudents.Name = "textBoxSearchStudents";
            textBoxSearchStudents.Size = new Size(306, 23);
            textBoxSearchStudents.TabIndex = 11;
            // 
            // search
            // 
            search.Location = new Point(5, 129);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(306, 22);
            search.TabIndex = 10;
            search.Text = "Поиск";
            search.UseVisualStyleBackColor = true;
            search.Click += buttonSearchStudents_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewStudent);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewOlympiadsOfStudent);
            splitContainer1.Size = new Size(1890, 1007);
            splitContainer1.SplitterDistance = 502;
            splitContainer1.TabIndex = 13;
            // 
            // listViewOlympiadsOfStudent
            // 
            listViewOlympiadsOfStudent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewOlympiadsOfStudent.Location = new Point(7, 167);
            listViewOlympiadsOfStudent.MultiSelect = false;
            listViewOlympiadsOfStudent.Name = "listViewOlympiadsOfStudent";
            listViewOlympiadsOfStudent.Size = new Size(1890, 329);
            listViewOlympiadsOfStudent.TabIndex = 6;
            listViewOlympiadsOfStudent.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageOlimpiad
            // 
            tabPageOlimpiad.Controls.Add(buttonDumpingOlimpyad);
            tabPageOlimpiad.Controls.Add(button3);
            tabPageOlimpiad.Controls.Add(textBoxSearchOlimpyad);
            tabPageOlimpiad.Controls.Add(checkedListBoxEnco);
            tabPageOlimpiad.Controls.Add(checkedListBoxAvards);
            tabPageOlimpiad.Controls.Add(checkedListBoxType);
            tabPageOlimpiad.Controls.Add(checkedListBoxLevel);
            tabPageOlimpiad.Controls.Add(checkedListBoxSearchOlipyad);
            tabPageOlimpiad.Controls.Add(labelcou);
            tabPageOlimpiad.Controls.Add(labelph3);
            tabPageOlimpiad.Controls.Add(label10);
            tabPageOlimpiad.Controls.Add(labeldob);
            tabPageOlimpiad.Controls.Add(labelspe);
            tabPageOlimpiad.Controls.Add(labelyor);
            tabPageOlimpiad.Controls.Add(label6);
            tabPageOlimpiad.Controls.Add(labelph2);
            tabPageOlimpiad.Controls.Add(labelfio);
            tabPageOlimpiad.Controls.Add(labelyap);
            tabPageOlimpiad.Controls.Add(label9);
            tabPageOlimpiad.Controls.Add(labelph1);
            tabPageOlimpiad.Controls.Add(label5);
            tabPageOlimpiad.Controls.Add(label15);
            tabPageOlimpiad.Controls.Add(labelgro);
            tabPageOlimpiad.Controls.Add(label8);
            tabPageOlimpiad.Controls.Add(labeladd);
            tabPageOlimpiad.Controls.Add(label4);
            tabPageOlimpiad.Controls.Add(label13);
            tabPageOlimpiad.Controls.Add(label7);
            tabPageOlimpiad.Controls.Add(label12);
            tabPageOlimpiad.Controls.Add(label3);
            tabPageOlimpiad.Controls.Add(label18);
            tabPageOlimpiad.Controls.Add(label17);
            tabPageOlimpiad.Controls.Add(label16);
            tabPageOlimpiad.Controls.Add(label14);
            tabPageOlimpiad.Controls.Add(label21);
            tabPageOlimpiad.Controls.Add(label2);
            tabPageOlimpiad.Controls.Add(DeleteOlimp);
            tabPageOlimpiad.Controls.Add(button1);
            tabPageOlimpiad.Controls.Add(listViewOlimp);
            tabPageOlimpiad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageOlimpiad.Location = new Point(4, 24);
            tabPageOlimpiad.Name = "tabPageOlimpiad";
            tabPageOlimpiad.Padding = new Padding(3);
            tabPageOlimpiad.Size = new Size(1896, 1013);
            tabPageOlimpiad.TabIndex = 1;
            tabPageOlimpiad.Text = "Олимпиады";
            tabPageOlimpiad.UseVisualStyleBackColor = true;
            // 
            // buttonDumpingOlimpyad
            // 
            buttonDumpingOlimpyad.Location = new Point(1510, 454);
            buttonDumpingOlimpyad.Name = "buttonDumpingOlimpyad";
            buttonDumpingOlimpyad.Size = new Size(380, 23);
            buttonDumpingOlimpyad.TabIndex = 9;
            buttonDumpingOlimpyad.Text = "Сброс";
            buttonDumpingOlimpyad.UseVisualStyleBackColor = true;
            buttonDumpingOlimpyad.Click += buttonDumpingOlimpyad_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1510, 135);
            button3.Name = "button3";
            button3.Size = new Size(378, 23);
            button3.TabIndex = 8;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonSearchOlympyad_Click;
            // 
            // textBoxSearchOlimpyad
            // 
            textBoxSearchOlimpyad.Location = new Point(1510, 106);
            textBoxSearchOlimpyad.Name = "textBoxSearchOlimpyad";
            textBoxSearchOlimpyad.Size = new Size(378, 23);
            textBoxSearchOlimpyad.TabIndex = 7;
            // 
            // checkedListBoxEnco
            // 
            checkedListBoxEnco.CheckOnClick = true;
            checkedListBoxEnco.FormattingEnabled = true;
            checkedListBoxEnco.Items.AddRange(new object[] { "Благодарность", "Доска почета", "Именная стипендия", "Скидка в оплате за обучение", "Без поощрения" });
            checkedListBoxEnco.Location = new Point(1510, 390);
            checkedListBoxEnco.MultiColumn = true;
            checkedListBoxEnco.Name = "checkedListBoxEnco";
            checkedListBoxEnco.Size = new Size(378, 58);
            checkedListBoxEnco.TabIndex = 6;
            checkedListBoxEnco.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxAvards
            // 
            checkedListBoxAvards.CheckOnClick = true;
            checkedListBoxAvards.FormattingEnabled = true;
            checkedListBoxAvards.Items.AddRange(new object[] { "Диплом I степени", "Диплом II степени", "Диплом III степени", "Грамота", "Сертификат", "Без награды" });
            checkedListBoxAvards.Location = new Point(1510, 305);
            checkedListBoxAvards.MultiColumn = true;
            checkedListBoxAvards.Name = "checkedListBoxAvards";
            checkedListBoxAvards.Size = new Size(378, 58);
            checkedListBoxAvards.TabIndex = 6;
            checkedListBoxAvards.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxType
            // 
            checkedListBoxType.CheckOnClick = true;
            checkedListBoxType.FormattingEnabled = true;
            checkedListBoxType.Items.AddRange(new object[] { "Конференция", "Олимпиада" });
            checkedListBoxType.Location = new Point(1510, 256);
            checkedListBoxType.MultiColumn = true;
            checkedListBoxType.Name = "checkedListBoxType";
            checkedListBoxType.Size = new Size(378, 22);
            checkedListBoxType.TabIndex = 6;
            checkedListBoxType.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxLevel
            // 
            checkedListBoxLevel.CheckOnClick = true;
            checkedListBoxLevel.FormattingEnabled = true;
            checkedListBoxLevel.Items.AddRange(new object[] { "Школа", "Колледж", "Район", "Город", "Республиканская", "Международная" });
            checkedListBoxLevel.Location = new Point(1510, 189);
            checkedListBoxLevel.MultiColumn = true;
            checkedListBoxLevel.Name = "checkedListBoxLevel";
            checkedListBoxLevel.Size = new Size(378, 40);
            checkedListBoxLevel.TabIndex = 6;
            checkedListBoxLevel.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxSearchOlipyad
            // 
            checkedListBoxSearchOlipyad.CheckOnClick = true;
            checkedListBoxSearchOlipyad.FormattingEnabled = true;
            checkedListBoxSearchOlipyad.Items.AddRange(new object[] { "Дата", "Уровень", "Вид", "Награда", "Поощерение", "Номинации", "Продалжительность", "Название", "Место проведения" });
            checkedListBoxSearchOlipyad.Location = new Point(1510, 6);
            checkedListBoxSearchOlipyad.MultiColumn = true;
            checkedListBoxSearchOlipyad.Name = "checkedListBoxSearchOlipyad";
            checkedListBoxSearchOlipyad.Size = new Size(378, 94);
            checkedListBoxSearchOlipyad.TabIndex = 6;
            // 
            // labelcou
            // 
            labelcou.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelcou.Location = new Point(1672, 815);
            labelcou.Name = "labelcou";
            labelcou.Size = new Size(216, 17);
            labelcou.TabIndex = 5;
            // 
            // labelph3
            // 
            labelph3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelph3.Location = new Point(1672, 696);
            labelph3.Name = "labelph3";
            labelph3.Size = new Size(216, 17);
            labelph3.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1509, 750);
            label10.Name = "label10";
            label10.Size = new Size(139, 21);
            label10.TabIndex = 5;
            label10.Text = "Дата поступления";
            // 
            // labeldob
            // 
            labeldob.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labeldob.Location = new Point(1672, 545);
            labeldob.Name = "labeldob";
            labeldob.Size = new Size(216, 17);
            labeldob.TabIndex = 5;
            // 
            // labelspe
            // 
            labelspe.AutoEllipsis = true;
            labelspe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelspe.Location = new Point(1672, 845);
            labelspe.Name = "labelspe";
            labelspe.Size = new Size(218, 54);
            labelspe.TabIndex = 5;
            // 
            // labelyor
            // 
            labelyor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelyor.Location = new Point(1672, 785);
            labelyor.Name = "labelyor";
            labelyor.Size = new Size(216, 17);
            labelyor.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1539, 630);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 5;
            label6.Text = "Мобильный 1";
            // 
            // labelph2
            // 
            labelph2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelph2.Location = new Point(1672, 665);
            labelph2.Name = "labelph2";
            labelph2.Size = new Size(216, 17);
            labelph2.TabIndex = 5;
            // 
            // labelfio
            // 
            labelfio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelfio.Location = new Point(1672, 515);
            labelfio.Name = "labelfio";
            labelfio.Size = new Size(216, 17);
            labelfio.TabIndex = 5;
            // 
            // labelyap
            // 
            labelyap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelyap.Location = new Point(1672, 755);
            labelyap.Name = "labelyap";
            labelyap.Size = new Size(216, 17);
            labelyap.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1508, 720);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 5;
            label9.Text = "Группа";
            // 
            // labelph1
            // 
            labelph1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelph1.Location = new Point(1672, 635);
            labelph1.Name = "labelph1";
            labelph1.Size = new Size(216, 17);
            labelph1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1509, 600);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 5;
            label5.Text = "Номер телефона";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1509, 840);
            label15.Name = "label15";
            label15.Size = new Size(123, 21);
            label15.TabIndex = 5;
            label15.Text = "Специализация";
            // 
            // labelgro
            // 
            labelgro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelgro.Location = new Point(1672, 725);
            labelgro.Name = "labelgro";
            labelgro.Size = new Size(216, 17);
            labelgro.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1539, 690);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 5;
            label8.Text = "Домашний";
            // 
            // labeladd
            // 
            labeladd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labeladd.Location = new Point(1672, 575);
            labeladd.Name = "labeladd";
            labeladd.Size = new Size(216, 17);
            labeladd.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1510, 570);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 5;
            label4.Text = "Адрес";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1509, 810);
            label13.Name = "label13";
            label13.Size = new Size(43, 21);
            label13.TabIndex = 5;
            label13.Text = "Курс";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1539, 660);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 5;
            label7.Text = "Мобильный 2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1509, 780);
            label12.Name = "label12";
            label12.Size = new Size(107, 21);
            label12.TabIndex = 5;
            label12.Text = "Дата выпуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1510, 540);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 5;
            label3.Text = "Дата рождения";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(1510, 366);
            label18.Name = "label18";
            label18.Size = new Size(113, 21);
            label18.TabIndex = 5;
            label18.Text = "Поощерение";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(1510, 281);
            label17.Name = "label17";
            label17.Size = new Size(80, 21);
            label17.TabIndex = 5;
            label17.Text = "Награды";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(1510, 232);
            label16.Name = "label16";
            label16.Size = new Size(40, 21);
            label16.TabIndex = 5;
            label16.Text = "Вид";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1510, 161);
            label14.Name = "label14";
            label14.Size = new Size(77, 21);
            label14.TabIndex = 5;
            label14.Text = "Уровень";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(1510, 480);
            label21.Name = "label21";
            label21.Size = new Size(219, 25);
            label21.TabIndex = 5;
            label21.Text = "Информация о ученике";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1509, 510);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 5;
            label2.Text = "ФИО";
            // 
            // DeleteOlimp
            // 
            DeleteOlimp.Location = new Point(1510, 940);
            DeleteOlimp.Name = "DeleteOlimp";
            DeleteOlimp.Size = new Size(175, 30);
            DeleteOlimp.TabIndex = 4;
            DeleteOlimp.Text = "Удалить";
            DeleteOlimp.UseVisualStyleBackColor = true;
            DeleteOlimp.Click += deleteOlimpyad_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1730, 940);
            button1.Name = "button1";
            button1.Size = new Size(175, 30);
            button1.TabIndex = 3;
            button1.Text = "Добавить олимпиаду";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addOlimpiads_Click;
            // 
            // tabPageExcel
            // 
            tabPageExcel.Controls.Add(checkedListBoxCriteriaExcel);
            tabPageExcel.Controls.Add(label20);
            tabPageExcel.Controls.Add(label19);
            tabPageExcel.Controls.Add(numericUpDown2);
            tabPageExcel.Controls.Add(numericUpDown1);
            tabPageExcel.Controls.Add(excel);
            tabPageExcel.Location = new Point(4, 24);
            tabPageExcel.Name = "tabPageExcel";
            tabPageExcel.Padding = new Padding(3);
            tabPageExcel.Size = new Size(1896, 1013);
            tabPageExcel.TabIndex = 2;
            tabPageExcel.Text = "Экспорт в Excel";
            tabPageExcel.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCriteriaExcel
            // 
            checkedListBoxCriteriaExcel.FormattingEnabled = true;
            checkedListBoxCriteriaExcel.Items.AddRange(new object[] { "Правоведение", "Коммерческая деятельность", "Банковское дело", "Бухгалтерский учет, анализ и контроль", "Операционная логистика", "Экономика и организация производства", "Программное обеспечение информационных технологий" });
            checkedListBoxCriteriaExcel.Location = new Point(8, 48);
            checkedListBoxCriteriaExcel.MultiColumn = true;
            checkedListBoxCriteriaExcel.Name = "checkedListBoxCriteriaExcel";
            checkedListBoxCriteriaExcel.Size = new Size(143, 148);
            checkedListBoxCriteriaExcel.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(262, 14);
            label20.Name = "label20";
            label20.Size = new Size(28, 21);
            label20.TabIndex = 9;
            label20.Text = "по";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(8, 14);
            label19.Name = "label19";
            label19.Size = new Size(113, 21);
            label19.TabIndex = 9;
            label19.Text = "Учебный год с";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(296, 12);
            numericUpDown2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(127, 12);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // tabPageReport
            // 
            tabPageReport.Controls.Add(reportViewer1);
            tabPageReport.Location = new Point(4, 24);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Size = new Size(1896, 1013);
            tabPageReport.TabIndex = 3;
            tabPageReport.Text = "Отчёт";
            tabPageReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1896, 1013);
            reportViewer1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tabMain);
            HelpButton = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Олимпиады";
            WindowState = FormWindowState.Maximized;
            tabMain.ResumeLayout(false);
            tabPageStudent.ResumeLayout(false);
            panelMenuStudents.ResumeLayout(false);
            panelMenuStudents.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabPageOlimpiad.ResumeLayout(false);
            tabPageOlimpiad.PerformLayout();
            tabPageExcel.ResumeLayout(false);
            tabPageExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPageReport.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox textBoxSearchStudents;
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
        private Button DeleteOlimp;
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
        private Label label20;
        private NumericUpDown numericUpDown2;
        private TabPage tabPageReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
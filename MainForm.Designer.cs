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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonAddStudent = new Button();
            buttonDelete = new Button();
            listViewStudent = new ListView();
            listViewOlimp = new ListView();
            excel = new Button();
            tabMain = new TabControl();
            tabPageStudent = new TabPage();
            panelMenuStudents = new Panel();
            checkBox1 = new CheckBox();
            buttonUpdateStudent = new Button();
            buttonDumping = new Button();
            checkedListBoxSearch = new CheckedListBox();
            checkedListBoxCourse = new CheckedListBox();
            checkedListBoxSpecialization = new CheckedListBox();
            label11 = new Label();
            label1 = new Label();
            textBoxSearchStudents = new TextBox();
            search = new Button();
            splitContainer1 = new SplitContainer();
            upPanel = new Panel();
            bottomPanel = new Panel();
            listViewOlympiadsOfStudent = new ListView();
            tabPageOlimpiad = new TabPage();
            buttonUpdateOlimpiad = new Button();
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
            tabPageEducationGroup = new TabPage();
            buttonUpdateEWG = new Button();
            buttonDeleteEWG = new Button();
            buttonAddEWG = new Button();
            listViewEducationWorkGroup = new ListView();
            tabPageStudentEW = new TabPage();
            buttonUpdateEWS = new Button();
            buttonDeleteEWS = new Button();
            buttonAddEWS = new Button();
            listViewEWByStudent = new ListView();
            listViewEWStudent = new ListView();
            tabPageEducationWork = new TabPage();
            buttonUpdateEW = new Button();
            buttonDeleteEW = new Button();
            buttonAddEW = new Button();
            listViewEducationWork = new ListView();
            tabPageStudentHonor = new TabPage();
            buttonUpdateHS = new Button();
            buttonDeleteHS = new Button();
            buttonAddHS = new Button();
            listViewHonorByS = new ListView();
            listViewStudentsH = new ListView();
            tabPageHonor = new TabPage();
            buttonUpdateHonor = new Button();
            buttonDeleteHonor = new Button();
            buttonAddHonor = new Button();
            listViewHonor = new ListView();
            tabPageMainReport = new TabPage();
            panelRightReport = new Panel();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panelLeftReport = new Panel();
            checkedListBoxCriteriaExcel = new CheckedListBox();
            label20 = new Label();
            label19 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            tabMain.SuspendLayout();
            tabPageStudent.SuspendLayout();
            panelMenuStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            upPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            tabPageOlimpiad.SuspendLayout();
            tabPageEducationGroup.SuspendLayout();
            tabPageStudentEW.SuspendLayout();
            tabPageEducationWork.SuspendLayout();
            tabPageStudentHonor.SuspendLayout();
            tabPageHonor.SuspendLayout();
            tabPageMainReport.SuspendLayout();
            panelRightReport.SuspendLayout();
            panelLeftReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(203, 881);
            buttonAddStudent.Margin = new Padding(3, 2, 3, 2);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(206, 50);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить учащегося";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(5, 881);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(180, 50);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += deleteStudents_Click;
            // 
            // listViewStudent
            // 
            listViewStudent.Activation = ItemActivation.OneClick;
            listViewStudent.BorderStyle = BorderStyle.FixedSingle;
            listViewStudent.Dock = DockStyle.Fill;
            listViewStudent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listViewItem1.StateImageIndex = 0;
            listViewStudent.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewStudent.Location = new Point(0, 0);
            listViewStudent.Margin = new Padding(3, 2, 3, 2);
            listViewStudent.MultiSelect = false;
            listViewStudent.Name = "listViewStudent";
            listViewStudent.Size = new Size(1490, 497);
            listViewStudent.TabIndex = 2;
            listViewStudent.TabStop = false;
            listViewStudent.UseCompatibleStateImageBehavior = false;
            listViewStudent.MouseClick += listViewStudents_MouseOneClick;
            // 
            // listViewOlimp
            // 
            listViewOlimp.Dock = DockStyle.Left;
            listViewOlimp.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listViewOlimp.Location = new Point(3, 3);
            listViewOlimp.Margin = new Padding(3, 2, 3, 2);
            listViewOlimp.MultiSelect = false;
            listViewOlimp.Name = "listViewOlimp";
            listViewOlimp.Size = new Size(1390, 997);
            listViewOlimp.TabIndex = 2;
            listViewOlimp.UseCompatibleStateImageBehavior = false;
            listViewOlimp.MouseClick += listViewOlimp_MouseOneClick;
            // 
            // excel
            // 
            excel.Location = new Point(3, 236);
            excel.Margin = new Padding(3, 2, 3, 2);
            excel.Name = "excel";
            excel.Size = new Size(292, 33);
            excel.TabIndex = 6;
            excel.Text = "Сформировать отчет";
            excel.UseVisualStyleBackColor = true;
            excel.Click += excelReport_ClickAsync;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPageStudent);
            tabMain.Controls.Add(tabPageOlimpiad);
            tabMain.Controls.Add(tabPageEducationGroup);
            tabMain.Controls.Add(tabPageStudentEW);
            tabMain.Controls.Add(tabPageEducationWork);
            tabMain.Controls.Add(tabPageStudentHonor);
            tabMain.Controls.Add(tabPageHonor);
            tabMain.Controls.Add(tabPageMainReport);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabMain.HotTrack = true;
            tabMain.ItemSize = new Size(150, 30);
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
            tabPageStudent.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageStudent.Location = new Point(4, 34);
            tabPageStudent.Name = "tabPageStudent";
            tabPageStudent.Padding = new Padding(3);
            tabPageStudent.Size = new Size(1896, 1003);
            tabPageStudent.TabIndex = 0;
            tabPageStudent.Text = "Учaщиecя";
            tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // panelMenuStudents
            // 
            panelMenuStudents.BorderStyle = BorderStyle.FixedSingle;
            panelMenuStudents.Controls.Add(checkBox1);
            panelMenuStudents.Controls.Add(buttonUpdateStudent);
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
            panelMenuStudents.Location = new Point(1478, 3);
            panelMenuStudents.Name = "panelMenuStudents";
            panelMenuStudents.Size = new Size(415, 997);
            panelMenuStudents.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(5, 644);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 35);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonUpdateStudent
            // 
            buttonUpdateStudent.Location = new Point(5, 834);
            buttonUpdateStudent.Name = "buttonUpdateStudent";
            buttonUpdateStudent.Size = new Size(404, 42);
            buttonUpdateStudent.TabIndex = 19;
            buttonUpdateStudent.Text = "Изменить";
            buttonUpdateStudent.UseVisualStyleBackColor = true;
            buttonUpdateStudent.Click += buttonUpdateStudent_Click;
            // 
            // buttonDumping
            // 
            buttonDumping.Location = new Point(5, 601);
            buttonDumping.Name = "buttonDumping";
            buttonDumping.Size = new Size(404, 37);
            buttonDumping.TabIndex = 18;
            buttonDumping.Text = "Сброс";
            buttonDumping.UseVisualStyleBackColor = true;
            buttonDumping.Click += buttonDumpingStudents_Click;
            // 
            // checkedListBoxSearch
            // 
            checkedListBoxSearch.CheckOnClick = true;
            checkedListBoxSearch.ColumnWidth = 200;
            checkedListBoxSearch.FormattingEnabled = true;
            checkedListBoxSearch.Items.AddRange(new object[] { "ФИО", "Дата рождения", "Адрес", "Номер телефона", "Группа", "Дата поступления", "Дата выпуска", "Курс", "Специализация" });
            checkedListBoxSearch.Location = new Point(5, 3);
            checkedListBoxSearch.MultiColumn = true;
            checkedListBoxSearch.Name = "checkedListBoxSearch";
            checkedListBoxSearch.Size = new Size(404, 139);
            checkedListBoxSearch.TabIndex = 17;
            // 
            // checkedListBoxCourse
            // 
            checkedListBoxCourse.CheckOnClick = true;
            checkedListBoxCourse.FormattingEnabled = true;
            checkedListBoxCourse.Items.AddRange(new object[] { "1", "2", "3", "4" });
            checkedListBoxCourse.Location = new Point(5, 483);
            checkedListBoxCourse.Name = "checkedListBoxCourse";
            checkedListBoxCourse.Size = new Size(404, 112);
            checkedListBoxCourse.TabIndex = 16;
            checkedListBoxCourse.SelectedIndexChanged += checkBoxesStudents_CheckedChanged;
            // 
            // checkedListBoxSpecialization
            // 
            checkedListBoxSpecialization.CheckOnClick = true;
            checkedListBoxSpecialization.FormattingEnabled = true;
            checkedListBoxSpecialization.Items.AddRange(new object[] { "Правоведение", "Коммерческая деятельность", "Банковское дело", "Бухгалтерский учет, анализ и контроль", "Операционная логистика", "Экономика и организация производства", "Программное обеспечение информационных технологий" });
            checkedListBoxSpecialization.Location = new Point(5, 254);
            checkedListBoxSpecialization.Name = "checkedListBoxSpecialization";
            checkedListBoxSpecialization.Size = new Size(404, 193);
            checkedListBoxSpecialization.TabIndex = 16;
            checkedListBoxSpecialization.SelectedIndexChanged += checkBoxesStudents_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(5, 450);
            label11.Name = "label11";
            label11.Size = new Size(63, 30);
            label11.TabIndex = 15;
            label11.Text = "Курс";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 221);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 13;
            label1.Text = "Специальность";
            // 
            // textBoxSearchStudents
            // 
            textBoxSearchStudents.Location = new Point(5, 152);
            textBoxSearchStudents.Margin = new Padding(3, 2, 3, 2);
            textBoxSearchStudents.Name = "textBoxSearchStudents";
            textBoxSearchStudents.Size = new Size(404, 32);
            textBoxSearchStudents.TabIndex = 11;
            // 
            // search
            // 
            search.Location = new Point(5, 188);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(404, 31);
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
            splitContainer1.Panel1.Controls.Add(upPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(bottomPanel);
            splitContainer1.Size = new Size(1490, 997);
            splitContainer1.SplitterDistance = 497;
            splitContainer1.TabIndex = 13;
            // 
            // upPanel
            // 
            upPanel.Controls.Add(listViewStudent);
            upPanel.Dock = DockStyle.Fill;
            upPanel.Location = new Point(0, 0);
            upPanel.Name = "upPanel";
            upPanel.Size = new Size(1490, 497);
            upPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(listViewOlympiadsOfStudent);
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Location = new Point(0, 0);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1490, 496);
            bottomPanel.TabIndex = 0;
            // 
            // listViewOlympiadsOfStudent
            // 
            listViewOlympiadsOfStudent.Dock = DockStyle.Fill;
            listViewOlympiadsOfStudent.Location = new Point(0, 0);
            listViewOlympiadsOfStudent.MultiSelect = false;
            listViewOlympiadsOfStudent.Name = "listViewOlympiadsOfStudent";
            listViewOlympiadsOfStudent.Size = new Size(1490, 496);
            listViewOlympiadsOfStudent.TabIndex = 6;
            listViewOlympiadsOfStudent.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageOlimpiad
            // 
            tabPageOlimpiad.Controls.Add(buttonUpdateOlimpiad);
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
            tabPageOlimpiad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageOlimpiad.Location = new Point(4, 34);
            tabPageOlimpiad.Name = "tabPageOlimpiad";
            tabPageOlimpiad.Padding = new Padding(3);
            tabPageOlimpiad.Size = new Size(1896, 1003);
            tabPageOlimpiad.TabIndex = 1;
            tabPageOlimpiad.Text = "Олимпиады";
            tabPageOlimpiad.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateOlimpiad
            // 
            buttonUpdateOlimpiad.Location = new Point(1408, 973);
            buttonUpdateOlimpiad.Name = "buttonUpdateOlimpiad";
            buttonUpdateOlimpiad.Size = new Size(478, 23);
            buttonUpdateOlimpiad.TabIndex = 10;
            buttonUpdateOlimpiad.Text = "button2";
            buttonUpdateOlimpiad.UseVisualStyleBackColor = true;
            // 
            // buttonDumpingOlimpyad
            // 
            buttonDumpingOlimpyad.Location = new Point(1407, 514);
            buttonDumpingOlimpyad.Name = "buttonDumpingOlimpyad";
            buttonDumpingOlimpyad.Size = new Size(479, 32);
            buttonDumpingOlimpyad.TabIndex = 9;
            buttonDumpingOlimpyad.Text = "Сброс";
            buttonDumpingOlimpyad.UseVisualStyleBackColor = true;
            buttonDumpingOlimpyad.Click += buttonDumpingOlimpyad_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1408, 135);
            button3.Name = "button3";
            button3.Size = new Size(480, 33);
            button3.TabIndex = 8;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonSearchOlympyad_Click;
            // 
            // textBoxSearchOlimpyad
            // 
            textBoxSearchOlimpyad.Location = new Point(1408, 97);
            textBoxSearchOlimpyad.Name = "textBoxSearchOlimpyad";
            textBoxSearchOlimpyad.Size = new Size(481, 32);
            textBoxSearchOlimpyad.TabIndex = 7;
            // 
            // checkedListBoxEnco
            // 
            checkedListBoxEnco.CheckOnClick = true;
            checkedListBoxEnco.ColumnWidth = 200;
            checkedListBoxEnco.FormattingEnabled = true;
            checkedListBoxEnco.Items.AddRange(new object[] { "Благодарность", "Доска почета", "Именная стипендия", "Скидка в оплате за обучение", "Без поощрения" });
            checkedListBoxEnco.Location = new Point(1407, 423);
            checkedListBoxEnco.MultiColumn = true;
            checkedListBoxEnco.Name = "checkedListBoxEnco";
            checkedListBoxEnco.Size = new Size(479, 85);
            checkedListBoxEnco.TabIndex = 6;
            checkedListBoxEnco.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxAvards
            // 
            checkedListBoxAvards.CheckOnClick = true;
            checkedListBoxAvards.ColumnWidth = 155;
            checkedListBoxAvards.FormattingEnabled = true;
            checkedListBoxAvards.Items.AddRange(new object[] { "Диплом I степени", "Диплом II степени", "Диплом III степени", "Грамота", "Сертификат", "Без награды" });
            checkedListBoxAvards.Location = new Point(1407, 338);
            checkedListBoxAvards.MultiColumn = true;
            checkedListBoxAvards.Name = "checkedListBoxAvards";
            checkedListBoxAvards.Size = new Size(479, 58);
            checkedListBoxAvards.TabIndex = 6;
            checkedListBoxAvards.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxType
            // 
            checkedListBoxType.CheckOnClick = true;
            checkedListBoxType.ColumnWidth = 200;
            checkedListBoxType.FormattingEnabled = true;
            checkedListBoxType.Items.AddRange(new object[] { "Конференция", "Олимпиада" });
            checkedListBoxType.Location = new Point(1409, 280);
            checkedListBoxType.MultiColumn = true;
            checkedListBoxType.Name = "checkedListBoxType";
            checkedListBoxType.Size = new Size(479, 31);
            checkedListBoxType.TabIndex = 6;
            checkedListBoxType.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxLevel
            // 
            checkedListBoxLevel.CheckOnClick = true;
            checkedListBoxLevel.ColumnWidth = 155;
            checkedListBoxLevel.FormattingEnabled = true;
            checkedListBoxLevel.Items.AddRange(new object[] { "Школа", "Колледж", "Район", "Город", "Республиканская", "Международная" });
            checkedListBoxLevel.Location = new Point(1408, 195);
            checkedListBoxLevel.MultiColumn = true;
            checkedListBoxLevel.Name = "checkedListBoxLevel";
            checkedListBoxLevel.Size = new Size(480, 58);
            checkedListBoxLevel.TabIndex = 6;
            checkedListBoxLevel.SelectedIndexChanged += checkBoxesOlimp_CheckedChanged;
            // 
            // checkedListBoxSearchOlipyad
            // 
            checkedListBoxSearchOlipyad.CheckOnClick = true;
            checkedListBoxSearchOlipyad.ColumnWidth = 155;
            checkedListBoxSearchOlipyad.FormattingEnabled = true;
            checkedListBoxSearchOlipyad.Items.AddRange(new object[] { "Дата", "Уровень", "Вид", "Награда", "Поощерение", "Номинации", "Продалжительность", "Название", "Место проведения" });
            checkedListBoxSearchOlipyad.Location = new Point(1408, 6);
            checkedListBoxSearchOlipyad.MultiColumn = true;
            checkedListBoxSearchOlipyad.Name = "checkedListBoxSearchOlipyad";
            checkedListBoxSearchOlipyad.Size = new Size(480, 85);
            checkedListBoxSearchOlipyad.TabIndex = 6;
            // 
            // labelcou
            // 
            labelcou.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelcou.Location = new Point(1571, 874);
            labelcou.Name = "labelcou";
            labelcou.Size = new Size(317, 28);
            labelcou.TabIndex = 5;
            // 
            // labelph3
            // 
            labelph3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelph3.Location = new Point(1571, 755);
            labelph3.Name = "labelph3";
            labelph3.Size = new Size(317, 28);
            labelph3.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1408, 809);
            label10.Name = "label10";
            label10.Size = new Size(139, 21);
            label10.TabIndex = 5;
            label10.Text = "Дата поступления";
            // 
            // labeldob
            // 
            labeldob.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeldob.Location = new Point(1571, 604);
            labeldob.Name = "labeldob";
            labeldob.Size = new Size(317, 28);
            labeldob.TabIndex = 5;
            // 
            // labelspe
            // 
            labelspe.AutoEllipsis = true;
            labelspe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelspe.Location = new Point(1553, 902);
            labelspe.Name = "labelspe";
            labelspe.Size = new Size(336, 33);
            labelspe.TabIndex = 5;
            // 
            // labelyor
            // 
            labelyor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelyor.Location = new Point(1571, 844);
            labelyor.Name = "labelyor";
            labelyor.Size = new Size(317, 28);
            labelyor.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1438, 689);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 5;
            label6.Text = "Мобильный 1";
            // 
            // labelph2
            // 
            labelph2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelph2.Location = new Point(1571, 724);
            labelph2.Name = "labelph2";
            labelph2.Size = new Size(317, 28);
            labelph2.TabIndex = 5;
            // 
            // labelfio
            // 
            labelfio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelfio.Location = new Point(1571, 574);
            labelfio.Name = "labelfio";
            labelfio.Size = new Size(317, 28);
            labelfio.TabIndex = 5;
            // 
            // labelyap
            // 
            labelyap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelyap.Location = new Point(1571, 814);
            labelyap.Name = "labelyap";
            labelyap.Size = new Size(317, 28);
            labelyap.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1407, 779);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 5;
            label9.Text = "Группа";
            // 
            // labelph1
            // 
            labelph1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelph1.Location = new Point(1571, 694);
            labelph1.Name = "labelph1";
            labelph1.Size = new Size(317, 28);
            labelph1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1408, 659);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 5;
            label5.Text = "Номер телефона";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1408, 899);
            label15.Name = "label15";
            label15.Size = new Size(123, 21);
            label15.TabIndex = 5;
            label15.Text = "Специализация";
            // 
            // labelgro
            // 
            labelgro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelgro.Location = new Point(1571, 784);
            labelgro.Name = "labelgro";
            labelgro.Size = new Size(317, 28);
            labelgro.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1438, 749);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 5;
            label8.Text = "Домашний";
            // 
            // labeladd
            // 
            labeladd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeladd.Location = new Point(1571, 634);
            labeladd.Name = "labeladd";
            labeladd.Size = new Size(317, 28);
            labeladd.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1409, 629);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 5;
            label4.Text = "Адрес";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1408, 869);
            label13.Name = "label13";
            label13.Size = new Size(43, 21);
            label13.TabIndex = 5;
            label13.Text = "Курс";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1438, 719);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 5;
            label7.Text = "Мобильный 2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1408, 839);
            label12.Name = "label12";
            label12.Size = new Size(107, 21);
            label12.TabIndex = 5;
            label12.Text = "Дата выпуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1409, 599);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 5;
            label3.Text = "Дата рождения";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(1407, 399);
            label18.Name = "label18";
            label18.Size = new Size(113, 21);
            label18.TabIndex = 5;
            label18.Text = "Поощерение";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(1408, 314);
            label17.Name = "label17";
            label17.Size = new Size(80, 21);
            label17.TabIndex = 5;
            label17.Text = "Награды";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(1408, 256);
            label16.Name = "label16";
            label16.Size = new Size(40, 21);
            label16.TabIndex = 5;
            label16.Text = "Вид";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1408, 171);
            label14.Name = "label14";
            label14.Size = new Size(77, 21);
            label14.TabIndex = 5;
            label14.Text = "Уровень";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(1407, 549);
            label21.Name = "label21";
            label21.Size = new Size(204, 21);
            label21.TabIndex = 5;
            label21.Text = "Информация об учащемся";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1408, 574);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 5;
            label2.Text = "ФИО";
            // 
            // DeleteOlimp
            // 
            DeleteOlimp.Location = new Point(1409, 940);
            DeleteOlimp.Name = "DeleteOlimp";
            DeleteOlimp.Size = new Size(200, 30);
            DeleteOlimp.TabIndex = 4;
            DeleteOlimp.Text = "Удалить";
            DeleteOlimp.UseVisualStyleBackColor = true;
            DeleteOlimp.Click += deleteOlimpyad_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1688, 940);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 3;
            button1.Text = "Добавить олимпиаду";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addOlimpiads_Click;
            // 
            // tabPageEducationGroup
            // 
            tabPageEducationGroup.Controls.Add(buttonUpdateEWG);
            tabPageEducationGroup.Controls.Add(buttonDeleteEWG);
            tabPageEducationGroup.Controls.Add(buttonAddEWG);
            tabPageEducationGroup.Controls.Add(listViewEducationWorkGroup);
            tabPageEducationGroup.Location = new Point(4, 34);
            tabPageEducationGroup.Name = "tabPageEducationGroup";
            tabPageEducationGroup.Padding = new Padding(3);
            tabPageEducationGroup.Size = new Size(1896, 1003);
            tabPageEducationGroup.TabIndex = 3;
            tabPageEducationGroup.Text = "Воспитательная работа группы";
            tabPageEducationGroup.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateEWG
            // 
            buttonUpdateEWG.Location = new Point(708, 506);
            buttonUpdateEWG.Name = "buttonUpdateEWG";
            buttonUpdateEWG.Size = new Size(478, 23);
            buttonUpdateEWG.TabIndex = 16;
            buttonUpdateEWG.Text = "Изменить";
            buttonUpdateEWG.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEWG
            // 
            buttonDeleteEWG.Location = new Point(709, 473);
            buttonDeleteEWG.Name = "buttonDeleteEWG";
            buttonDeleteEWG.Size = new Size(200, 30);
            buttonDeleteEWG.TabIndex = 15;
            buttonDeleteEWG.Text = "Удалить";
            buttonDeleteEWG.UseVisualStyleBackColor = true;
            // 
            // buttonAddEWG
            // 
            buttonAddEWG.Location = new Point(988, 473);
            buttonAddEWG.Name = "buttonAddEWG";
            buttonAddEWG.Size = new Size(200, 30);
            buttonAddEWG.TabIndex = 14;
            buttonAddEWG.Text = "Добавить олимпиаду";
            buttonAddEWG.UseVisualStyleBackColor = true;
            // 
            // listViewEducationWorkGroup
            // 
            listViewEducationWorkGroup.Location = new Point(239, 82);
            listViewEducationWorkGroup.Name = "listViewEducationWorkGroup";
            listViewEducationWorkGroup.Size = new Size(121, 97);
            listViewEducationWorkGroup.TabIndex = 0;
            listViewEducationWorkGroup.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageStudentEW
            // 
            tabPageStudentEW.Controls.Add(buttonUpdateEWS);
            tabPageStudentEW.Controls.Add(buttonDeleteEWS);
            tabPageStudentEW.Controls.Add(buttonAddEWS);
            tabPageStudentEW.Controls.Add(listViewEWByStudent);
            tabPageStudentEW.Controls.Add(listViewEWStudent);
            tabPageStudentEW.Location = new Point(4, 34);
            tabPageStudentEW.Name = "tabPageStudentEW";
            tabPageStudentEW.Size = new Size(1896, 1003);
            tabPageStudentEW.TabIndex = 6;
            tabPageStudentEW.Text = "Учащиеся по Воспитательной работе ";
            tabPageStudentEW.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateEWS
            // 
            buttonUpdateEWS.Location = new Point(943, 702);
            buttonUpdateEWS.Name = "buttonUpdateEWS";
            buttonUpdateEWS.Size = new Size(478, 23);
            buttonUpdateEWS.TabIndex = 20;
            buttonUpdateEWS.Text = "Изменить";
            buttonUpdateEWS.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEWS
            // 
            buttonDeleteEWS.Location = new Point(944, 669);
            buttonDeleteEWS.Name = "buttonDeleteEWS";
            buttonDeleteEWS.Size = new Size(200, 30);
            buttonDeleteEWS.TabIndex = 19;
            buttonDeleteEWS.Text = "Удалить";
            buttonDeleteEWS.UseVisualStyleBackColor = true;
            // 
            // buttonAddEWS
            // 
            buttonAddEWS.Location = new Point(1223, 669);
            buttonAddEWS.Name = "buttonAddEWS";
            buttonAddEWS.Size = new Size(200, 30);
            buttonAddEWS.TabIndex = 18;
            buttonAddEWS.Text = "Добавить олимпиаду";
            buttonAddEWS.UseVisualStyleBackColor = true;
            // 
            // listViewEWByStudent
            // 
            listViewEWByStudent.Location = new Point(474, 401);
            listViewEWByStudent.Name = "listViewEWByStudent";
            listViewEWByStudent.Size = new Size(121, 97);
            listViewEWByStudent.TabIndex = 17;
            listViewEWByStudent.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEWStudent
            // 
            listViewEWStudent.Location = new Point(474, 278);
            listViewEWStudent.Name = "listViewEWStudent";
            listViewEWStudent.Size = new Size(121, 97);
            listViewEWStudent.TabIndex = 17;
            listViewEWStudent.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageEducationWork
            // 
            tabPageEducationWork.Controls.Add(buttonUpdateEW);
            tabPageEducationWork.Controls.Add(buttonDeleteEW);
            tabPageEducationWork.Controls.Add(buttonAddEW);
            tabPageEducationWork.Controls.Add(listViewEducationWork);
            tabPageEducationWork.Location = new Point(4, 34);
            tabPageEducationWork.Name = "tabPageEducationWork";
            tabPageEducationWork.Padding = new Padding(3);
            tabPageEducationWork.Size = new Size(1896, 1003);
            tabPageEducationWork.TabIndex = 4;
            tabPageEducationWork.Text = "Воспитательная работа ";
            tabPageEducationWork.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateEW
            // 
            buttonUpdateEW.Location = new Point(708, 506);
            buttonUpdateEW.Name = "buttonUpdateEW";
            buttonUpdateEW.Size = new Size(478, 23);
            buttonUpdateEW.TabIndex = 13;
            buttonUpdateEW.Text = "Изменить";
            buttonUpdateEW.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEW
            // 
            buttonDeleteEW.Location = new Point(709, 473);
            buttonDeleteEW.Name = "buttonDeleteEW";
            buttonDeleteEW.Size = new Size(200, 30);
            buttonDeleteEW.TabIndex = 12;
            buttonDeleteEW.Text = "Удалить";
            buttonDeleteEW.UseVisualStyleBackColor = true;
            // 
            // buttonAddEW
            // 
            buttonAddEW.Location = new Point(988, 473);
            buttonAddEW.Name = "buttonAddEW";
            buttonAddEW.Size = new Size(200, 30);
            buttonAddEW.TabIndex = 11;
            buttonAddEW.Text = "Добавить олимпиаду";
            buttonAddEW.UseVisualStyleBackColor = true;
            // 
            // listViewEducationWork
            // 
            listViewEducationWork.Location = new Point(297, 120);
            listViewEducationWork.Name = "listViewEducationWork";
            listViewEducationWork.Size = new Size(121, 97);
            listViewEducationWork.TabIndex = 0;
            listViewEducationWork.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageStudentHonor
            // 
            tabPageStudentHonor.Controls.Add(buttonUpdateHS);
            tabPageStudentHonor.Controls.Add(buttonDeleteHS);
            tabPageStudentHonor.Controls.Add(buttonAddHS);
            tabPageStudentHonor.Controls.Add(listViewHonorByS);
            tabPageStudentHonor.Controls.Add(listViewStudentsH);
            tabPageStudentHonor.Location = new Point(4, 34);
            tabPageStudentHonor.Name = "tabPageStudentHonor";
            tabPageStudentHonor.Size = new Size(1896, 1003);
            tabPageStudentHonor.TabIndex = 7;
            tabPageStudentHonor.Text = "Учащиеся Доски Почета";
            tabPageStudentHonor.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateHS
            // 
            buttonUpdateHS.Location = new Point(943, 702);
            buttonUpdateHS.Name = "buttonUpdateHS";
            buttonUpdateHS.Size = new Size(478, 23);
            buttonUpdateHS.TabIndex = 25;
            buttonUpdateHS.Text = "Изменить";
            buttonUpdateHS.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteHS
            // 
            buttonDeleteHS.Location = new Point(944, 669);
            buttonDeleteHS.Name = "buttonDeleteHS";
            buttonDeleteHS.Size = new Size(200, 30);
            buttonDeleteHS.TabIndex = 24;
            buttonDeleteHS.Text = "Удалить";
            buttonDeleteHS.UseVisualStyleBackColor = true;
            // 
            // buttonAddHS
            // 
            buttonAddHS.Location = new Point(1223, 669);
            buttonAddHS.Name = "buttonAddHS";
            buttonAddHS.Size = new Size(200, 30);
            buttonAddHS.TabIndex = 23;
            buttonAddHS.Text = "Добавить олимпиаду";
            buttonAddHS.UseVisualStyleBackColor = true;
            // 
            // listViewHonorByS
            // 
            listViewHonorByS.Location = new Point(474, 401);
            listViewHonorByS.Name = "listViewHonorByS";
            listViewHonorByS.Size = new Size(121, 97);
            listViewHonorByS.TabIndex = 21;
            listViewHonorByS.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentsH
            // 
            listViewStudentsH.Location = new Point(474, 278);
            listViewStudentsH.Name = "listViewStudentsH";
            listViewStudentsH.Size = new Size(121, 97);
            listViewStudentsH.TabIndex = 22;
            listViewStudentsH.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageHonor
            // 
            tabPageHonor.Controls.Add(buttonUpdateHonor);
            tabPageHonor.Controls.Add(buttonDeleteHonor);
            tabPageHonor.Controls.Add(buttonAddHonor);
            tabPageHonor.Controls.Add(listViewHonor);
            tabPageHonor.Location = new Point(4, 34);
            tabPageHonor.Name = "tabPageHonor";
            tabPageHonor.Padding = new Padding(3);
            tabPageHonor.Size = new Size(1896, 1003);
            tabPageHonor.TabIndex = 5;
            tabPageHonor.Text = "Доска почета";
            tabPageHonor.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateHonor
            // 
            buttonUpdateHonor.Location = new Point(708, 506);
            buttonUpdateHonor.Name = "buttonUpdateHonor";
            buttonUpdateHonor.Size = new Size(478, 23);
            buttonUpdateHonor.TabIndex = 16;
            buttonUpdateHonor.Text = "Изменить";
            buttonUpdateHonor.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteHonor
            // 
            buttonDeleteHonor.Location = new Point(709, 473);
            buttonDeleteHonor.Name = "buttonDeleteHonor";
            buttonDeleteHonor.Size = new Size(200, 30);
            buttonDeleteHonor.TabIndex = 15;
            buttonDeleteHonor.Text = "Удалить";
            buttonDeleteHonor.UseVisualStyleBackColor = true;
            // 
            // buttonAddHonor
            // 
            buttonAddHonor.Location = new Point(988, 473);
            buttonAddHonor.Name = "buttonAddHonor";
            buttonAddHonor.Size = new Size(200, 30);
            buttonAddHonor.TabIndex = 14;
            buttonAddHonor.Text = "Добавить олимпиаду";
            buttonAddHonor.UseVisualStyleBackColor = true;
            // 
            // listViewHonor
            // 
            listViewHonor.Location = new Point(276, 76);
            listViewHonor.Name = "listViewHonor";
            listViewHonor.Size = new Size(121, 97);
            listViewHonor.TabIndex = 0;
            listViewHonor.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageMainReport
            // 
            tabPageMainReport.Controls.Add(panelRightReport);
            tabPageMainReport.Controls.Add(panelLeftReport);
            tabPageMainReport.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageMainReport.Location = new Point(4, 34);
            tabPageMainReport.Name = "tabPageMainReport";
            tabPageMainReport.Padding = new Padding(3);
            tabPageMainReport.Size = new Size(1896, 1003);
            tabPageMainReport.TabIndex = 2;
            tabPageMainReport.Text = "Отчёт";
            tabPageMainReport.UseVisualStyleBackColor = true;
            // 
            // panelRightReport
            // 
            panelRightReport.Controls.Add(reportViewer1);
            panelRightReport.Dock = DockStyle.Left;
            panelRightReport.Location = new Point(3, 3);
            panelRightReport.Name = "panelRightReport";
            panelRightReport.Size = new Size(1585, 997);
            panelRightReport.TabIndex = 12;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1585, 997);
            reportViewer1.TabIndex = 0;
            // 
            // panelLeftReport
            // 
            panelLeftReport.Controls.Add(checkedListBoxCriteriaExcel);
            panelLeftReport.Controls.Add(excel);
            panelLeftReport.Controls.Add(label20);
            panelLeftReport.Controls.Add(label19);
            panelLeftReport.Controls.Add(numericUpDown2);
            panelLeftReport.Controls.Add(numericUpDown1);
            panelLeftReport.Dock = DockStyle.Right;
            panelLeftReport.Location = new Point(1593, 3);
            panelLeftReport.Name = "panelLeftReport";
            panelLeftReport.Size = new Size(300, 997);
            panelLeftReport.TabIndex = 11;
            // 
            // checkedListBoxCriteriaExcel
            // 
            checkedListBoxCriteriaExcel.CheckOnClick = true;
            checkedListBoxCriteriaExcel.ColumnWidth = 280;
            checkedListBoxCriteriaExcel.FormattingEnabled = true;
            checkedListBoxCriteriaExcel.Items.AddRange(new object[] { "Правоведение", "Коммерческая деятельность", "Банковское дело", "Бухгалтерский учет, анализ и контроль", "Операционная логистика", "Экономика и организация производства", "Программное обеспечение информационных технологий" });
            checkedListBoxCriteriaExcel.Location = new Point(3, 3);
            checkedListBoxCriteriaExcel.MultiColumn = true;
            checkedListBoxCriteriaExcel.Name = "checkedListBoxCriteriaExcel";
            checkedListBoxCriteriaExcel.Size = new Size(292, 193);
            checkedListBoxCriteriaExcel.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(145, 199);
            label20.Name = "label20";
            label20.Size = new Size(39, 30);
            label20.TabIndex = 9;
            label20.Text = "по";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(3, 199);
            label19.Name = "label19";
            label19.Size = new Size(23, 30);
            label19.TabIndex = 9;
            label19.Text = "с";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(202, 199);
            numericUpDown2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 32);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(46, 199);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 32);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // reportViewer2
            // 
            reportViewer2.Location = new Point(0, 0);
            reportViewer2.Name = "ReportViewer";
            reportViewer2.ServerReport.BearerToken = null;
            reportViewer2.Size = new Size(396, 246);
            reportViewer2.TabIndex = 0;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
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
            upPanel.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            tabPageOlimpiad.ResumeLayout(false);
            tabPageOlimpiad.PerformLayout();
            tabPageEducationGroup.ResumeLayout(false);
            tabPageStudentEW.ResumeLayout(false);
            tabPageEducationWork.ResumeLayout(false);
            tabPageStudentHonor.ResumeLayout(false);
            tabPageHonor.ResumeLayout(false);
            tabPageMainReport.ResumeLayout(false);
            panelRightReport.ResumeLayout(false);
            panelLeftReport.ResumeLayout(false);
            panelLeftReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TabPage tabPageMainReport;
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panelLeftReport;
        private Panel panelRightReport;
        private TabPage tabPageEducationGroup;
        private TabPage tabPageEducationWork;
        private TabPage tabPageHonor;
        private Button buttonUpdateStudent;
        private Panel upPanel;
        private Panel bottomPanel;
        private Button buttonUpdateOlimpiad;
        private ListView listViewEducationWorkGroup;
        private Button buttonUpdateEW;
        private Button buttonDeleteEW;
        private Button buttonAddEW;
        private ListView listViewEducationWork;
        private ListView listViewHonor;
        private Button buttonUpdateEWG;
        private Button buttonDeleteEWG;
        private Button buttonAddEWG;
        private Button buttonUpdateHonor;
        private Button buttonDeleteHonor;
        private Button buttonAddHonor;
        private CheckBox checkBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private TabPage tabPageStudentEW;
        private Button buttonUpdateEWS;
        private Button buttonDeleteEWS;
        private Button buttonAddEWS;
        private ListView listViewEWByStudent;
        private ListView listViewEWStudent;
        private TabPage tabPageStudentHonor;
        private Button buttonUpdateHS;
        private Button buttonDeleteHS;
        private Button buttonAddHS;
        private ListView listViewHonorByS;
        private ListView listViewStudentsH;
    }
}
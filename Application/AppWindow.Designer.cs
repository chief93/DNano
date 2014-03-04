namespace IDE
{
    partial class AppWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitSolutionDevelopment = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SplitCodeBuild = new System.Windows.Forms.SplitContainer();
            this.WorkingFiles = new System.Windows.Forms.TabControl();
            this.SampleWorkingFile = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Logs = new System.Windows.Forms.TabControl();
            this.BuildLog = new System.Windows.Forms.TabPage();
            this.SearchLog = new System.Windows.Forms.TabPage();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileItemSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСуществующийПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьПроектToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСуществующийПроектToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.построениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перестроитьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьРешениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.построитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перестроитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVersionControl = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuService = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BuildingProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.показатьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зафиксироватьИзмененияИОтправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диспетчерПакетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеDNanoIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitSolutionDevelopment)).BeginInit();
            this.SplitSolutionDevelopment.Panel1.SuspendLayout();
            this.SplitSolutionDevelopment.Panel2.SuspendLayout();
            this.SplitSolutionDevelopment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCodeBuild)).BeginInit();
            this.SplitCodeBuild.Panel1.SuspendLayout();
            this.SplitCodeBuild.Panel2.SuspendLayout();
            this.SplitCodeBuild.SuspendLayout();
            this.WorkingFiles.SuspendLayout();
            this.SampleWorkingFile.SuspendLayout();
            this.Logs.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitSolutionDevelopment
            // 
            this.SplitSolutionDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitSolutionDevelopment.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitSolutionDevelopment.Location = new System.Drawing.Point(1, 26);
            this.SplitSolutionDevelopment.Name = "SplitSolutionDevelopment";
            // 
            // SplitSolutionDevelopment.Panel1
            // 
            this.SplitSolutionDevelopment.Panel1.Controls.Add(this.treeView1);
            // 
            // SplitSolutionDevelopment.Panel2
            // 
            this.SplitSolutionDevelopment.Panel2.Controls.Add(this.SplitCodeBuild);
            this.SplitSolutionDevelopment.Size = new System.Drawing.Size(1007, 514);
            this.SplitSolutionDevelopment.SplitterDistance = 230;
            this.SplitSolutionDevelopment.SplitterWidth = 2;
            this.SplitSolutionDevelopment.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(227, 514);
            this.treeView1.TabIndex = 0;
            // 
            // SplitCodeBuild
            // 
            this.SplitCodeBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitCodeBuild.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitCodeBuild.Location = new System.Drawing.Point(0, 0);
            this.SplitCodeBuild.Name = "SplitCodeBuild";
            this.SplitCodeBuild.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitCodeBuild.Panel1
            // 
            this.SplitCodeBuild.Panel1.AutoScroll = true;
            this.SplitCodeBuild.Panel1.Controls.Add(this.WorkingFiles);
            // 
            // SplitCodeBuild.Panel2
            // 
            this.SplitCodeBuild.Panel2.Controls.Add(this.Logs);
            this.SplitCodeBuild.Size = new System.Drawing.Size(775, 514);
            this.SplitCodeBuild.SplitterDistance = 396;
            this.SplitCodeBuild.SplitterWidth = 2;
            this.SplitCodeBuild.TabIndex = 0;
            this.SplitCodeBuild.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // WorkingFiles
            // 
            this.WorkingFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkingFiles.Controls.Add(this.SampleWorkingFile);
            this.WorkingFiles.Location = new System.Drawing.Point(0, 0);
            this.WorkingFiles.Name = "WorkingFiles";
            this.WorkingFiles.SelectedIndex = 0;
            this.WorkingFiles.ShowToolTips = true;
            this.WorkingFiles.Size = new System.Drawing.Size(775, 395);
            this.WorkingFiles.TabIndex = 0;
            // 
            // SampleWorkingFile
            // 
            this.SampleWorkingFile.Controls.Add(this.richTextBox1);
            this.SampleWorkingFile.Location = new System.Drawing.Point(4, 22);
            this.SampleWorkingFile.Name = "SampleWorkingFile";
            this.SampleWorkingFile.Padding = new System.Windows.Forms.Padding(3);
            this.SampleWorkingFile.Size = new System.Drawing.Size(767, 369);
            this.SampleWorkingFile.TabIndex = 0;
            this.SampleWorkingFile.Text = "main.d";
            this.SampleWorkingFile.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(767, 369);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // Logs
            // 
            this.Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logs.Controls.Add(this.BuildLog);
            this.Logs.Controls.Add(this.SearchLog);
            this.Logs.Location = new System.Drawing.Point(1, 2);
            this.Logs.Name = "Logs";
            this.Logs.SelectedIndex = 0;
            this.Logs.Size = new System.Drawing.Size(775, 113);
            this.Logs.TabIndex = 0;
            // 
            // BuildLog
            // 
            this.BuildLog.Location = new System.Drawing.Point(4, 22);
            this.BuildLog.Name = "BuildLog";
            this.BuildLog.Padding = new System.Windows.Forms.Padding(3);
            this.BuildLog.Size = new System.Drawing.Size(767, 87);
            this.BuildLog.TabIndex = 0;
            this.BuildLog.Text = "Вывод";
            this.BuildLog.UseVisualStyleBackColor = true;
            // 
            // SearchLog
            // 
            this.SearchLog.Location = new System.Drawing.Point(4, 22);
            this.SearchLog.Name = "SearchLog";
            this.SearchLog.Padding = new System.Windows.Forms.Padding(3);
            this.SearchLog.Size = new System.Drawing.Size(767, 87);
            this.SearchLog.TabIndex = 1;
            this.SearchLog.Text = "Результаты поиска";
            this.SearchLog.UseVisualStyleBackColor = true;
            // 
            // MenuBar
            // 
            this.MenuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.построениеToolStripMenuItem,
            this.MenuVersionControl,
            this.MenuService,
            this.MenuHelp});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuBar.Size = new System.Drawing.Size(1008, 24);
            this.MenuBar.TabIndex = 2;
            this.MenuBar.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileItemSolution,
            this.MenuFileSeparator,
            this.MenuFileItemSaveAll,
            this.MenuFileItemExit});
            this.MenuFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(48, 21);
            this.MenuFile.Text = "Файл";
            // 
            // MenuFileItemSolution
            // 
            this.MenuFileItemSolution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПроектToolStripMenuItem,
            this.добавитьСуществующийПроектToolStripMenuItem,
            this.toolStripSeparator1,
            this.создатьПроектToolStripMenuItem1,
            this.добавитьСуществующийПроектToolStripMenuItem1});
            this.MenuFileItemSolution.Name = "MenuFileItemSolution";
            this.MenuFileItemSolution.Size = new System.Drawing.Size(153, 22);
            this.MenuFileItemSolution.Text = "Решение";
            // 
            // создатьПроектToolStripMenuItem
            // 
            this.создатьПроектToolStripMenuItem.Name = "создатьПроектToolStripMenuItem";
            this.создатьПроектToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.создатьПроектToolStripMenuItem.Text = "Создать решение";
            // 
            // добавитьСуществующийПроектToolStripMenuItem
            // 
            this.добавитьСуществующийПроектToolStripMenuItem.Name = "добавитьСуществующийПроектToolStripMenuItem";
            this.добавитьСуществующийПроектToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.добавитьСуществующийПроектToolStripMenuItem.Text = "Открыть решение";
            this.добавитьСуществующийПроектToolStripMenuItem.Click += new System.EventHandler(this.добавитьСуществующийПроектToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // создатьПроектToolStripMenuItem1
            // 
            this.создатьПроектToolStripMenuItem1.Name = "создатьПроектToolStripMenuItem1";
            this.создатьПроектToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.создатьПроектToolStripMenuItem1.Text = "Создать проект";
            // 
            // добавитьСуществующийПроектToolStripMenuItem1
            // 
            this.добавитьСуществующийПроектToolStripMenuItem1.Name = "добавитьСуществующийПроектToolStripMenuItem1";
            this.добавитьСуществующийПроектToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.добавитьСуществующийПроектToolStripMenuItem1.Text = "Добавить существующий проект";
            // 
            // MenuFileSeparator
            // 
            this.MenuFileSeparator.Name = "MenuFileSeparator";
            this.MenuFileSeparator.Size = new System.Drawing.Size(150, 6);
            // 
            // MenuFileItemSaveAll
            // 
            this.MenuFileItemSaveAll.Name = "MenuFileItemSaveAll";
            this.MenuFileItemSaveAll.Size = new System.Drawing.Size(153, 22);
            this.MenuFileItemSaveAll.Text = "Сохранить всё";
            // 
            // MenuFileItemExit
            // 
            this.MenuFileItemExit.Name = "MenuFileItemExit";
            this.MenuFileItemExit.Size = new System.Drawing.Size(153, 22);
            this.MenuFileItemExit.Text = "Выход";
            // 
            // построениеToolStripMenuItem
            // 
            this.построениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.очиститьРешениеToolStripMenuItem,
            this.перестроитьРешениеToolStripMenuItem,
            this.очиститьРешениеToolStripMenuItem1,
            this.toolStripSeparator2,
            this.построитьПроектToolStripMenuItem,
            this.перестроитьПроектToolStripMenuItem,
            this.очиститьПроектToolStripMenuItem});
            this.построениеToolStripMenuItem.Name = "построениеToolStripMenuItem";
            this.построениеToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.построениеToolStripMenuItem.Text = "Построение";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem1.Text = "Очистить и перестроить решение";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // очиститьРешениеToolStripMenuItem
            // 
            this.очиститьРешениеToolStripMenuItem.Name = "очиститьРешениеToolStripMenuItem";
            this.очиститьРешениеToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.очиститьРешениеToolStripMenuItem.Text = "Построить решение";
            // 
            // перестроитьРешениеToolStripMenuItem
            // 
            this.перестроитьРешениеToolStripMenuItem.Name = "перестроитьРешениеToolStripMenuItem";
            this.перестроитьРешениеToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.перестроитьРешениеToolStripMenuItem.Text = "Перестроить решение";
            // 
            // очиститьРешениеToolStripMenuItem1
            // 
            this.очиститьРешениеToolStripMenuItem1.Name = "очиститьРешениеToolStripMenuItem1";
            this.очиститьРешениеToolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.очиститьРешениеToolStripMenuItem1.Text = "Очистить решение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // построитьПроектToolStripMenuItem
            // 
            this.построитьПроектToolStripMenuItem.Name = "построитьПроектToolStripMenuItem";
            this.построитьПроектToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.построитьПроектToolStripMenuItem.Text = "Построить проект";
            // 
            // перестроитьПроектToolStripMenuItem
            // 
            this.перестроитьПроектToolStripMenuItem.Name = "перестроитьПроектToolStripMenuItem";
            this.перестроитьПроектToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.перестроитьПроектToolStripMenuItem.Text = "Перестроить проект";
            // 
            // очиститьПроектToolStripMenuItem
            // 
            this.очиститьПроектToolStripMenuItem.Name = "очиститьПроектToolStripMenuItem";
            this.очиститьПроектToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.очиститьПроектToolStripMenuItem.Text = "Очистить проект";
            // 
            // MenuVersionControl
            // 
            this.MenuVersionControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьИзмененияToolStripMenuItem,
            this.зафиксироватьИзмененияИОтправитьToolStripMenuItem,
            this.toolStripSeparator4,
            this.настройкаToolStripMenuItem});
            this.MenuVersionControl.Name = "MenuVersionControl";
            this.MenuVersionControl.Size = new System.Drawing.Size(114, 20);
            this.MenuVersionControl.Text = "Контроль версий";
            // 
            // MenuService
            // 
            this.MenuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диспетчерПакетовToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.MenuService.Name = "MenuService";
            this.MenuService.Size = new System.Drawing.Size(59, 20);
            this.MenuService.Text = "Сервис";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСправкиToolStripMenuItem,
            this.оПрограммеDNanoIDEToolStripMenuItem});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(65, 20);
            this.MenuHelp.Text = "Справка";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.BuildingProgress});
            this.StatusBar.Location = new System.Drawing.Point(0, 540);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusBar.Size = new System.Drawing.Size(1008, 22);
            this.StatusBar.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Готово";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // BuildingProgress
            // 
            this.BuildingProgress.Name = "BuildingProgress";
            this.BuildingProgress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.BuildingProgress.Size = new System.Drawing.Size(100, 16);
            this.BuildingProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.BuildingProgress.Visible = false;
            // 
            // показатьИзмененияToolStripMenuItem
            // 
            this.показатьИзмененияToolStripMenuItem.Name = "показатьИзмененияToolStripMenuItem";
            this.показатьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.показатьИзмененияToolStripMenuItem.Text = "Показать изменения";
            // 
            // зафиксироватьИзмененияИОтправитьToolStripMenuItem
            // 
            this.зафиксироватьИзмененияИОтправитьToolStripMenuItem.Name = "зафиксироватьИзмененияИОтправитьToolStripMenuItem";
            this.зафиксироватьИзмененияИОтправитьToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.зафиксироватьИзмененияИОтправитьToolStripMenuItem.Text = "Зафиксировать изменения и отправить";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(288, 6);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // диспетчерПакетовToolStripMenuItem
            // 
            this.диспетчерПакетовToolStripMenuItem.Name = "диспетчерПакетовToolStripMenuItem";
            this.диспетчерПакетовToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.диспетчерПакетовToolStripMenuItem.Text = "Диспетчер пакетов";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // просмотрСправкиToolStripMenuItem
            // 
            this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
            this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.просмотрСправкиToolStripMenuItem.Text = "Просмотр справки";
            // 
            // оПрограммеDNanoIDEToolStripMenuItem
            // 
            this.оПрограммеDNanoIDEToolStripMenuItem.Name = "оПрограммеDNanoIDEToolStripMenuItem";
            this.оПрограммеDNanoIDEToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.оПрограммеDNanoIDEToolStripMenuItem.Text = "О программе DNano IDE";
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.SplitSolutionDevelopment);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "AppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sample project - DNano IDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SplitSolutionDevelopment.Panel1.ResumeLayout(false);
            this.SplitSolutionDevelopment.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitSolutionDevelopment)).EndInit();
            this.SplitSolutionDevelopment.ResumeLayout(false);
            this.SplitCodeBuild.Panel1.ResumeLayout(false);
            this.SplitCodeBuild.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitCodeBuild)).EndInit();
            this.SplitCodeBuild.ResumeLayout(false);
            this.WorkingFiles.ResumeLayout(false);
            this.SampleWorkingFile.ResumeLayout(false);
            this.Logs.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitSolutionDevelopment;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer SplitCodeBuild;
        private System.Windows.Forms.TabControl Logs;
        private System.Windows.Forms.TabPage BuildLog;
        private System.Windows.Forms.TabPage SearchLog;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileItemSolution;
        private System.Windows.Forms.ToolStripMenuItem создатьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСуществующийПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem создатьПроектToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСуществующийПроектToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator;
        private System.Windows.Forms.ToolStripMenuItem MenuFileItemSaveAll;
        private System.Windows.Forms.ToolStripMenuItem MenuFileItemExit;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar BuildingProgress;
        private System.Windows.Forms.ToolStripMenuItem MenuVersionControl;
        private System.Windows.Forms.ToolStripMenuItem MenuService;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.TabControl WorkingFiles;
        private System.Windows.Forms.TabPage SampleWorkingFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem построениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem очиститьРешениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перестроитьРешениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьРешениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem построитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перестроитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зафиксироватьИзмененияИОтправитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диспетчерПакетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеDNanoIDEToolStripMenuItem;
    }
}


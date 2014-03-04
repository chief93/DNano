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
            this.SolutionExplorer = new System.Windows.Forms.TreeView();
            this.SplitCodeBuild = new System.Windows.Forms.SplitContainer();
            this.WorkingFiles = new System.Windows.Forms.TabControl();
            this.SampleWorkingFile = new System.Windows.Forms.TabPage();
            this.Editor = new System.Windows.Forms.RichTextBox();
            this.Logs = new System.Windows.Forms.TabControl();
            this.BuildLog = new System.Windows.Forms.TabPage();
            this.SearchLog = new System.Windows.Forms.TabPage();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSolutionCleanAndRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildSolutionBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSolutionRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSolutionClean = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildProjectBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildProjectRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildProjectClean = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVCS = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVCSDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVCSCommit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVCSSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuVCSSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuService = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServicePacMan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServiceSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.MenuFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileAddExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileSaveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSaveCurrentAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildProjectCleanAndRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildOrder = new System.Windows.Forms.ToolStripMenuItem();
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
            this.SplitSolutionDevelopment.Panel1.Controls.Add(this.SolutionExplorer);
            // 
            // SplitSolutionDevelopment.Panel2
            // 
            this.SplitSolutionDevelopment.Panel2.Controls.Add(this.SplitCodeBuild);
            this.SplitSolutionDevelopment.Size = new System.Drawing.Size(1007, 514);
            this.SplitSolutionDevelopment.SplitterDistance = 230;
            this.SplitSolutionDevelopment.SplitterWidth = 2;
            this.SplitSolutionDevelopment.TabIndex = 1;
            // 
            // SolutionExplorer
            // 
            this.SolutionExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolutionExplorer.Location = new System.Drawing.Point(0, 0);
            this.SolutionExplorer.Name = "SolutionExplorer";
            this.SolutionExplorer.Size = new System.Drawing.Size(227, 514);
            this.SolutionExplorer.TabIndex = 0;
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
            this.SplitCodeBuild.SplitterDistance = 338;
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
            this.WorkingFiles.Size = new System.Drawing.Size(775, 337);
            this.WorkingFiles.TabIndex = 0;
            // 
            // SampleWorkingFile
            // 
            this.SampleWorkingFile.Controls.Add(this.Editor);
            this.SampleWorkingFile.Location = new System.Drawing.Point(4, 22);
            this.SampleWorkingFile.Name = "SampleWorkingFile";
            this.SampleWorkingFile.Padding = new System.Windows.Forms.Padding(3);
            this.SampleWorkingFile.Size = new System.Drawing.Size(767, 311);
            this.SampleWorkingFile.TabIndex = 0;
            this.SampleWorkingFile.Text = "main.d";
            this.SampleWorkingFile.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            this.Editor.AcceptsTab = true;
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.AutoWordSelection = true;
            this.Editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Editor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editor.Location = new System.Drawing.Point(0, 0);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(767, 311);
            this.Editor.TabIndex = 0;
            this.Editor.TabStop = false;
            this.Editor.Text = "";
            // 
            // Logs
            // 
            this.Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logs.Controls.Add(this.BuildLog);
            this.Logs.Controls.Add(this.SearchLog);
            this.Logs.Location = new System.Drawing.Point(1, 3);
            this.Logs.Name = "Logs";
            this.Logs.SelectedIndex = 0;
            this.Logs.Size = new System.Drawing.Size(775, 170);
            this.Logs.TabIndex = 0;
            // 
            // BuildLog
            // 
            this.BuildLog.Location = new System.Drawing.Point(4, 22);
            this.BuildLog.Name = "BuildLog";
            this.BuildLog.Padding = new System.Windows.Forms.Padding(3);
            this.BuildLog.Size = new System.Drawing.Size(767, 144);
            this.BuildLog.TabIndex = 0;
            this.BuildLog.Text = "Вывод";
            this.BuildLog.UseVisualStyleBackColor = true;
            // 
            // SearchLog
            // 
            this.SearchLog.Location = new System.Drawing.Point(4, 22);
            this.SearchLog.Name = "SearchLog";
            this.SearchLog.Padding = new System.Windows.Forms.Padding(3);
            this.SearchLog.Size = new System.Drawing.Size(767, 84);
            this.SearchLog.TabIndex = 1;
            this.SearchLog.Text = "Результаты поиска";
            this.SearchLog.UseVisualStyleBackColor = true;
            // 
            // MenuBar
            // 
            this.MenuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuBuild,
            this.MenuVCS,
            this.MenuService,
            this.MenuHelp});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuBar.Size = new System.Drawing.Size(1008, 24);
            this.MenuBar.TabIndex = 2;
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileCreate,
            this.MenuFileOpen,
            this.MenuFileSeparator1,
            this.MenuFileAddExisting,
            this.MenuFileSeparator2,
            this.MenuFileSaveCurrent,
            this.MenuFileSaveCurrentAs,
            this.MenuFileItemSaveAll,
            this.MenuFileSeparator3,
            this.MenuFileExit});
            this.MenuFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(48, 21);
            this.MenuFile.Text = "Файл";
            // 
            // MenuFileSeparator2
            // 
            this.MenuFileSeparator2.Name = "MenuFileSeparator2";
            this.MenuFileSeparator2.Size = new System.Drawing.Size(316, 6);
            // 
            // MenuFileItemSaveAll
            // 
            this.MenuFileItemSaveAll.Name = "MenuFileItemSaveAll";
            this.MenuFileItemSaveAll.Size = new System.Drawing.Size(319, 22);
            this.MenuFileItemSaveAll.Text = "Сохранить всё";
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.Size = new System.Drawing.Size(319, 22);
            this.MenuFileExit.Text = "Выход";
            // 
            // MenuBuild
            // 
            this.MenuBuild.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBuildSolutionCleanAndRebuild,
            this.MenuBuildProjectCleanAndRebuild,
            this.MenuBuildSeparator1,
            this.MenuBuildSolutionBuild,
            this.MenuBuildSolutionRebuild,
            this.MenuBuildSolutionClean,
            this.MenuBuildSeparator2,
            this.MenuBuildProjectBuild,
            this.MenuBuildProjectRebuild,
            this.MenuBuildProjectClean,
            this.MenuBuildSeparator3,
            this.MenuBuildOrder});
            this.MenuBuild.Name = "MenuBuild";
            this.MenuBuild.Size = new System.Drawing.Size(86, 20);
            this.MenuBuild.Text = "Построение";
            // 
            // MenuBuildSolutionCleanAndRebuild
            // 
            this.MenuBuildSolutionCleanAndRebuild.Name = "MenuBuildSolutionCleanAndRebuild";
            this.MenuBuildSolutionCleanAndRebuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildSolutionCleanAndRebuild.Text = "Очистить и перестроить решение";
            // 
            // MenuBuildSeparator1
            // 
            this.MenuBuildSeparator1.Name = "MenuBuildSeparator1";
            this.MenuBuildSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // MenuBuildSolutionBuild
            // 
            this.MenuBuildSolutionBuild.Name = "MenuBuildSolutionBuild";
            this.MenuBuildSolutionBuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildSolutionBuild.Text = "Построить решение";
            // 
            // MenuBuildSolutionRebuild
            // 
            this.MenuBuildSolutionRebuild.Name = "MenuBuildSolutionRebuild";
            this.MenuBuildSolutionRebuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildSolutionRebuild.Text = "Перестроить решение";
            // 
            // MenuBuildSolutionClean
            // 
            this.MenuBuildSolutionClean.Name = "MenuBuildSolutionClean";
            this.MenuBuildSolutionClean.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildSolutionClean.Text = "Очистить решение";
            // 
            // MenuBuildSeparator2
            // 
            this.MenuBuildSeparator2.Name = "MenuBuildSeparator2";
            this.MenuBuildSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // MenuBuildProjectBuild
            // 
            this.MenuBuildProjectBuild.Name = "MenuBuildProjectBuild";
            this.MenuBuildProjectBuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildProjectBuild.Text = "Построить проект";
            // 
            // MenuBuildProjectRebuild
            // 
            this.MenuBuildProjectRebuild.Name = "MenuBuildProjectRebuild";
            this.MenuBuildProjectRebuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildProjectRebuild.Text = "Перестроить проект";
            // 
            // MenuBuildProjectClean
            // 
            this.MenuBuildProjectClean.Name = "MenuBuildProjectClean";
            this.MenuBuildProjectClean.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildProjectClean.Text = "Очистить проект";
            // 
            // MenuVCS
            // 
            this.MenuVCS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVCSDiff,
            this.MenuVCSCommit,
            this.MenuVCSSeparator1,
            this.MenuVCSSetup});
            this.MenuVCS.Name = "MenuVCS";
            this.MenuVCS.Size = new System.Drawing.Size(114, 20);
            this.MenuVCS.Text = "Контроль версий";
            // 
            // MenuVCSDiff
            // 
            this.MenuVCSDiff.Name = "MenuVCSDiff";
            this.MenuVCSDiff.Size = new System.Drawing.Size(291, 22);
            this.MenuVCSDiff.Text = "Показать изменения";
            // 
            // MenuVCSCommit
            // 
            this.MenuVCSCommit.Name = "MenuVCSCommit";
            this.MenuVCSCommit.Size = new System.Drawing.Size(291, 22);
            this.MenuVCSCommit.Text = "Зафиксировать изменения и отправить";
            // 
            // MenuVCSSeparator1
            // 
            this.MenuVCSSeparator1.Name = "MenuVCSSeparator1";
            this.MenuVCSSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // MenuVCSSetup
            // 
            this.MenuVCSSetup.Name = "MenuVCSSetup";
            this.MenuVCSSetup.Size = new System.Drawing.Size(291, 22);
            this.MenuVCSSetup.Text = "Настройка";
            // 
            // MenuService
            // 
            this.MenuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuServicePacMan,
            this.MenuServiceSettings});
            this.MenuService.Name = "MenuService";
            this.MenuService.Size = new System.Drawing.Size(59, 20);
            this.MenuService.Text = "Сервис";
            // 
            // MenuServicePacMan
            // 
            this.MenuServicePacMan.Name = "MenuServicePacMan";
            this.MenuServicePacMan.Size = new System.Drawing.Size(179, 22);
            this.MenuServicePacMan.Text = "Диспетчер пакетов";
            // 
            // MenuServiceSettings
            // 
            this.MenuServiceSettings.Name = "MenuServiceSettings";
            this.MenuServiceSettings.Size = new System.Drawing.Size(179, 22);
            this.MenuServiceSettings.Text = "Параметры";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpContents,
            this.MenuHelpAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(65, 20);
            this.MenuHelp.Text = "Справка";
            // 
            // MenuHelpContents
            // 
            this.MenuHelpContents.Name = "MenuHelpContents";
            this.MenuHelpContents.Size = new System.Drawing.Size(209, 22);
            this.MenuHelpContents.Text = "Просмотр справки";
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(209, 22);
            this.MenuHelpAbout.Text = "О программе DNano IDE";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarStatus,
            this.StatusBarProgress});
            this.StatusBar.Location = new System.Drawing.Point(0, 540);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusBar.Size = new System.Drawing.Size(1008, 22);
            this.StatusBar.TabIndex = 3;
            // 
            // StatusBarStatus
            // 
            this.StatusBarStatus.Name = "StatusBarStatus";
            this.StatusBarStatus.Size = new System.Drawing.Size(45, 17);
            this.StatusBarStatus.Text = "Готово";
            this.StatusBarStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // StatusBarProgress
            // 
            this.StatusBarProgress.Name = "StatusBarProgress";
            this.StatusBarProgress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.StatusBarProgress.Size = new System.Drawing.Size(100, 16);
            this.StatusBarProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.StatusBarProgress.Visible = false;
            // 
            // MenuFileCreate
            // 
            this.MenuFileCreate.Name = "MenuFileCreate";
            this.MenuFileCreate.Size = new System.Drawing.Size(319, 22);
            this.MenuFileCreate.Text = "Создать...";
            this.MenuFileCreate.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(319, 22);
            this.MenuFileOpen.Text = "Открыть...";
            // 
            // MenuFileSeparator1
            // 
            this.MenuFileSeparator1.Name = "MenuFileSeparator1";
            this.MenuFileSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // MenuFileAddExisting
            // 
            this.MenuFileAddExisting.Name = "MenuFileAddExisting";
            this.MenuFileAddExisting.Size = new System.Drawing.Size(319, 22);
            this.MenuFileAddExisting.Text = "Добавить существующий проект в решение";
            // 
            // MenuFileSeparator3
            // 
            this.MenuFileSeparator3.Name = "MenuFileSeparator3";
            this.MenuFileSeparator3.Size = new System.Drawing.Size(316, 6);
            // 
            // MenuFileSaveCurrent
            // 
            this.MenuFileSaveCurrent.Name = "MenuFileSaveCurrent";
            this.MenuFileSaveCurrent.Size = new System.Drawing.Size(319, 22);
            this.MenuFileSaveCurrent.Text = "Сохранить";
            // 
            // MenuFileSaveCurrentAs
            // 
            this.MenuFileSaveCurrentAs.Name = "MenuFileSaveCurrentAs";
            this.MenuFileSaveCurrentAs.Size = new System.Drawing.Size(319, 22);
            this.MenuFileSaveCurrentAs.Text = "Сохранить как...";
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditUndo,
            this.MenuEditRedo,
            this.MenuEditSeparator1,
            this.MenuEditCut,
            this.MenuEditCopy,
            this.MenuEditPaste,
            this.MenuEditDelete,
            this.MenuEditSeparator2,
            this.MenuEditSelectAll,
            this.MenuEditSeparator3,
            this.MenuEditFind,
            this.MenuEditReplace});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(59, 20);
            this.MenuEdit.Text = "Правка";
            // 
            // MenuEditUndo
            // 
            this.MenuEditUndo.Name = "MenuEditUndo";
            this.MenuEditUndo.Size = new System.Drawing.Size(152, 22);
            this.MenuEditUndo.Text = "Отменить";
            // 
            // MenuEditRedo
            // 
            this.MenuEditRedo.Name = "MenuEditRedo";
            this.MenuEditRedo.Size = new System.Drawing.Size(152, 22);
            this.MenuEditRedo.Text = "Вернуть";
            // 
            // MenuEditSeparator1
            // 
            this.MenuEditSeparator1.Name = "MenuEditSeparator1";
            this.MenuEditSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuEditCut
            // 
            this.MenuEditCut.Name = "MenuEditCut";
            this.MenuEditCut.Size = new System.Drawing.Size(152, 22);
            this.MenuEditCut.Text = "Вырезать";
            // 
            // MenuEditCopy
            // 
            this.MenuEditCopy.Name = "MenuEditCopy";
            this.MenuEditCopy.Size = new System.Drawing.Size(152, 22);
            this.MenuEditCopy.Text = "Копировать";
            // 
            // MenuEditPaste
            // 
            this.MenuEditPaste.Name = "MenuEditPaste";
            this.MenuEditPaste.Size = new System.Drawing.Size(152, 22);
            this.MenuEditPaste.Text = "Вставить";
            // 
            // MenuEditDelete
            // 
            this.MenuEditDelete.Name = "MenuEditDelete";
            this.MenuEditDelete.Size = new System.Drawing.Size(152, 22);
            this.MenuEditDelete.Text = "Удалить";
            // 
            // MenuEditSeparator2
            // 
            this.MenuEditSeparator2.Name = "MenuEditSeparator2";
            this.MenuEditSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuEditFind
            // 
            this.MenuEditFind.Name = "MenuEditFind";
            this.MenuEditFind.Size = new System.Drawing.Size(152, 22);
            this.MenuEditFind.Text = "Найти...";
            // 
            // MenuEditReplace
            // 
            this.MenuEditReplace.Name = "MenuEditReplace";
            this.MenuEditReplace.Size = new System.Drawing.Size(152, 22);
            this.MenuEditReplace.Text = "Заменить...";
            // 
            // MenuEditSelectAll
            // 
            this.MenuEditSelectAll.Name = "MenuEditSelectAll";
            this.MenuEditSelectAll.Size = new System.Drawing.Size(152, 22);
            this.MenuEditSelectAll.Text = "Выделить всё";
            // 
            // MenuEditSeparator3
            // 
            this.MenuEditSeparator3.Name = "MenuEditSeparator3";
            this.MenuEditSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuBuildProjectCleanAndRebuild
            // 
            this.MenuBuildProjectCleanAndRebuild.Name = "MenuBuildProjectCleanAndRebuild";
            this.MenuBuildProjectCleanAndRebuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildProjectCleanAndRebuild.Text = "Очистить и перестроить проект";
            // 
            // MenuBuildSeparator3
            // 
            this.MenuBuildSeparator3.Name = "MenuBuildSeparator3";
            this.MenuBuildSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // MenuBuildOrder
            // 
            this.MenuBuildOrder.Name = "MenuBuildOrder";
            this.MenuBuildOrder.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildOrder.Text = "Порядок построения";
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
        private System.Windows.Forms.TreeView SolutionExplorer;
        private System.Windows.Forms.SplitContainer SplitCodeBuild;
        private System.Windows.Forms.TabControl Logs;
        private System.Windows.Forms.TabPage BuildLog;
        private System.Windows.Forms.TabPage SearchLog;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuFileItemSaveAll;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExit;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarStatus;
        private System.Windows.Forms.ToolStripProgressBar StatusBarProgress;
        private System.Windows.Forms.ToolStripMenuItem MenuVCS;
        private System.Windows.Forms.ToolStripMenuItem MenuService;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.TabControl WorkingFiles;
        private System.Windows.Forms.TabPage SampleWorkingFile;
        private System.Windows.Forms.RichTextBox Editor;
        private System.Windows.Forms.ToolStripMenuItem MenuBuild;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildSolutionCleanAndRebuild;
        private System.Windows.Forms.ToolStripSeparator MenuBuildSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildSolutionBuild;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildSolutionRebuild;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildSolutionClean;
        private System.Windows.Forms.ToolStripSeparator MenuBuildSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildProjectBuild;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildProjectRebuild;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildProjectClean;
        private System.Windows.Forms.ToolStripMenuItem MenuVCSDiff;
        private System.Windows.Forms.ToolStripMenuItem MenuVCSCommit;
        private System.Windows.Forms.ToolStripSeparator MenuVCSSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuVCSSetup;
        private System.Windows.Forms.ToolStripMenuItem MenuServicePacMan;
        private System.Windows.Forms.ToolStripMenuItem MenuServiceSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpContents;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuFileCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuFileAddExisting;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSaveCurrent;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSaveCurrentAs;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuEditRedo;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCut;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuEditDelete;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuEditFind;
        private System.Windows.Forms.ToolStripMenuItem MenuEditReplace;
        private System.Windows.Forms.ToolStripMenuItem MenuEditSelectAll;
        private System.Windows.Forms.ToolStripSeparator MenuEditSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildProjectCleanAndRebuild;
        private System.Windows.Forms.ToolStripSeparator MenuBuildSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuBuildOrder;
    }
}


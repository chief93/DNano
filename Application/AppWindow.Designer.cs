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
            this.components = new System.ComponentModel.Container();
            this.SolutionExplorerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SolutionExplorerContextMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuOpenOut = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SolutionExplorerContextMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuСut = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SolutionExplorerContextMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuAddSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SolutionExplorerContextMenuAddElement = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuDeleteRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuDeleteDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SolutionExplorerContextMenuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitSolutionDevelopment = new System.Windows.Forms.SplitContainer();
            this.SolutionExplorer = new System.Windows.Forms.TreeView();
            this.SplitCodeBuild = new System.Windows.Forms.SplitContainer();
            this.WorkingFiles = new System.Windows.Forms.TabControl();
            this.Logs = new System.Windows.Forms.TabControl();
            this.BuildLog = new System.Windows.Forms.TabPage();
            this.IDE = new System.Windows.Forms.TabPage();
            this.SearchLog = new System.Windows.Forms.TabPage();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileAddExisting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileSaveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSolutionRun = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSolutionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSolutionSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSolutionProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSolutionCleanAndRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildProjectCleanAndRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildSolutionBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSolutionRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSolutionClean = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildProjectBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildProjectRebuild = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildProjectClean = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuildSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBuildOrder = new System.Windows.Forms.ToolStripMenuItem();
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
            this.WorkingFilesTabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WorkingFilesTabContextMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkingFilesTabContextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.WorkingFilesTabContextMenuCloseLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkingFilesTabContextMenuCloseRight = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkingFilesTabContextMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.WorkingFilesTabContextMenuCloseAllExceptThat = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkingFilesTabContextMenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SolutionExplorerContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitSolutionDevelopment)).BeginInit();
            this.SplitSolutionDevelopment.Panel1.SuspendLayout();
            this.SplitSolutionDevelopment.Panel2.SuspendLayout();
            this.SplitSolutionDevelopment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCodeBuild)).BeginInit();
            this.SplitCodeBuild.Panel1.SuspendLayout();
            this.SplitCodeBuild.Panel2.SuspendLayout();
            this.SplitCodeBuild.SuspendLayout();
            this.Logs.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.WorkingFilesTabContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolutionExplorerContextMenu
            // 
            this.SolutionExplorerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SolutionExplorerContextMenuOpen,
            this.SolutionExplorerContextMenuOpenOut,
            this.SolutionExplorerContextMenuSeparator1,
            this.SolutionExplorerContextMenuCopy,
            this.SolutionExplorerContextMenuСut,
            this.SolutionExplorerContextMenuPaste,
            this.SolutionExplorerContextMenuRename,
            this.SolutionExplorerContextMenuSeparator2,
            this.SolutionExplorerContextMenuAdd,
            this.SolutionExplorerContextMenuDelete,
            this.SolutionExplorerContextMenuSeparator3,
            this.SolutionExplorerContextMenuProperties});
            this.SolutionExplorerContextMenu.Name = "ProjectItemsContextMenu";
            this.SolutionExplorerContextMenu.Size = new System.Drawing.Size(203, 220);
            // 
            // SolutionExplorerContextMenuOpen
            // 
            this.SolutionExplorerContextMenuOpen.Name = "SolutionExplorerContextMenuOpen";
            this.SolutionExplorerContextMenuOpen.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuOpen.Text = "Открыть";
            this.SolutionExplorerContextMenuOpen.Click += new System.EventHandler(this.ProjectItemsContextMenuOpen_Click);
            // 
            // SolutionExplorerContextMenuOpenOut
            // 
            this.SolutionExplorerContextMenuOpenOut.Name = "SolutionExplorerContextMenuOpenOut";
            this.SolutionExplorerContextMenuOpenOut.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuOpenOut.Text = "Открыть вне редактора";
            this.SolutionExplorerContextMenuOpenOut.Click += new System.EventHandler(this.ProjectItemsContextMenuOpenOut_Click);
            // 
            // SolutionExplorerContextMenuSeparator1
            // 
            this.SolutionExplorerContextMenuSeparator1.Name = "SolutionExplorerContextMenuSeparator1";
            this.SolutionExplorerContextMenuSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // SolutionExplorerContextMenuCopy
            // 
            this.SolutionExplorerContextMenuCopy.Name = "SolutionExplorerContextMenuCopy";
            this.SolutionExplorerContextMenuCopy.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuCopy.Text = "Копировать";
            // 
            // SolutionExplorerContextMenuСut
            // 
            this.SolutionExplorerContextMenuСut.Name = "SolutionExplorerContextMenuСut";
            this.SolutionExplorerContextMenuСut.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuСut.Text = "Вырезать";
            // 
            // SolutionExplorerContextMenuPaste
            // 
            this.SolutionExplorerContextMenuPaste.Name = "SolutionExplorerContextMenuPaste";
            this.SolutionExplorerContextMenuPaste.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuPaste.Text = "Вставить";
            // 
            // SolutionExplorerContextMenuRename
            // 
            this.SolutionExplorerContextMenuRename.Name = "SolutionExplorerContextMenuRename";
            this.SolutionExplorerContextMenuRename.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuRename.Text = "Переименовать...";
            this.SolutionExplorerContextMenuRename.Click += new System.EventHandler(this.SolutionExplorerContextMenuRename_Click);
            // 
            // SolutionExplorerContextMenuSeparator2
            // 
            this.SolutionExplorerContextMenuSeparator2.Name = "SolutionExplorerContextMenuSeparator2";
            this.SolutionExplorerContextMenuSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // SolutionExplorerContextMenuAdd
            // 
            this.SolutionExplorerContextMenuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SolutionExplorerContextMenuAddElement,
            this.SolutionExplorerContextMenuAddSeparator1,
            this.SolutionExplorerContextMenuAddFolder,
            this.SolutionExplorerContextMenuAddFile});
            this.SolutionExplorerContextMenuAdd.Name = "SolutionExplorerContextMenuAdd";
            this.SolutionExplorerContextMenuAdd.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuAdd.Text = "Добавить";
            // 
            // SolutionExplorerContextMenuAddFile
            // 
            this.SolutionExplorerContextMenuAddFile.Name = "SolutionExplorerContextMenuAddFile";
            this.SolutionExplorerContextMenuAddFile.Size = new System.Drawing.Size(130, 22);
            this.SolutionExplorerContextMenuAddFile.Text = "Файл";
            // 
            // SolutionExplorerContextMenuAddFolder
            // 
            this.SolutionExplorerContextMenuAddFolder.Name = "SolutionExplorerContextMenuAddFolder";
            this.SolutionExplorerContextMenuAddFolder.Size = new System.Drawing.Size(152, 22);
            this.SolutionExplorerContextMenuAddFolder.Text = "Папка";
            this.SolutionExplorerContextMenuAddFolder.Click += new System.EventHandler(this.SolutionExplorerContextMenuAddFolder_Click);
            // 
            // SolutionExplorerContextMenuAddSeparator1
            // 
            this.SolutionExplorerContextMenuAddSeparator1.Name = "SolutionExplorerContextMenuAddSeparator1";
            this.SolutionExplorerContextMenuAddSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // SolutionExplorerContextMenuAddElement
            // 
            this.SolutionExplorerContextMenuAddElement.Name = "SolutionExplorerContextMenuAddElement";
            this.SolutionExplorerContextMenuAddElement.Size = new System.Drawing.Size(130, 22);
            this.SolutionExplorerContextMenuAddElement.Text = "Элемент...";
            // 
            // SolutionExplorerContextMenuDelete
            // 
            this.SolutionExplorerContextMenuDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SolutionExplorerContextMenuDeleteRemove,
            this.SolutionExplorerContextMenuDeleteDelete});
            this.SolutionExplorerContextMenuDelete.Name = "SolutionExplorerContextMenuDelete";
            this.SolutionExplorerContextMenuDelete.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuDelete.Text = "Удалить";
            // 
            // SolutionExplorerContextMenuDeleteRemove
            // 
            this.SolutionExplorerContextMenuDeleteRemove.Name = "SolutionExplorerContextMenuDeleteRemove";
            this.SolutionExplorerContextMenuDeleteRemove.Size = new System.Drawing.Size(199, 22);
            this.SolutionExplorerContextMenuDeleteRemove.Text = "Исключить из проекта";
            // 
            // SolutionExplorerContextMenuDeleteDelete
            // 
            this.SolutionExplorerContextMenuDeleteDelete.Name = "SolutionExplorerContextMenuDeleteDelete";
            this.SolutionExplorerContextMenuDeleteDelete.Size = new System.Drawing.Size(199, 22);
            this.SolutionExplorerContextMenuDeleteDelete.Text = "Удалить физически";
            // 
            // SolutionExplorerContextMenuSeparator3
            // 
            this.SolutionExplorerContextMenuSeparator3.Name = "SolutionExplorerContextMenuSeparator3";
            this.SolutionExplorerContextMenuSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // SolutionExplorerContextMenuProperties
            // 
            this.SolutionExplorerContextMenuProperties.Name = "SolutionExplorerContextMenuProperties";
            this.SolutionExplorerContextMenuProperties.Size = new System.Drawing.Size(202, 22);
            this.SolutionExplorerContextMenuProperties.Text = "Свойства";
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
            this.SolutionExplorer.AllowDrop = true;
            this.SolutionExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolutionExplorer.HideSelection = false;
            this.SolutionExplorer.LabelEdit = true;
            this.SolutionExplorer.Location = new System.Drawing.Point(0, 0);
            this.SolutionExplorer.Name = "SolutionExplorer";
            this.SolutionExplorer.PathSeparator = "/";
            this.SolutionExplorer.Size = new System.Drawing.Size(227, 514);
            this.SolutionExplorer.TabIndex = 0;
            this.SolutionExplorer.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.SolutionExplorer_ItemDrag);
            this.SolutionExplorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SolutionExplorer_NodeMouseClick);
            this.SolutionExplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SolutionExplorer_NodeMouseDoubleClick);
            this.SolutionExplorer.DragDrop += new System.Windows.Forms.DragEventHandler(this.SolutionExplorer_DragDrop);
            this.SolutionExplorer.DragEnter += new System.Windows.Forms.DragEventHandler(this.SolutionExplorer_DragEnter);
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
            this.SplitCodeBuild.SplitterDistance = 350;
            this.SplitCodeBuild.SplitterWidth = 2;
            this.SplitCodeBuild.TabIndex = 0;
            // 
            // WorkingFiles
            // 
            this.WorkingFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkingFiles.Location = new System.Drawing.Point(0, 0);
            this.WorkingFiles.Name = "WorkingFiles";
            this.WorkingFiles.SelectedIndex = 0;
            this.WorkingFiles.ShowToolTips = true;
            this.WorkingFiles.Size = new System.Drawing.Size(775, 349);
            this.WorkingFiles.TabIndex = 0;
            this.WorkingFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this._tabMouseClick);
            // 
            // Logs
            // 
            this.Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logs.Controls.Add(this.BuildLog);
            this.Logs.Controls.Add(this.IDE);
            this.Logs.Controls.Add(this.SearchLog);
            this.Logs.Location = new System.Drawing.Point(1, 3);
            this.Logs.Name = "Logs";
            this.Logs.SelectedIndex = 0;
            this.Logs.Size = new System.Drawing.Size(775, 158);
            this.Logs.TabIndex = 0;
            // 
            // BuildLog
            // 
            this.BuildLog.Location = new System.Drawing.Point(4, 22);
            this.BuildLog.Name = "BuildLog";
            this.BuildLog.Padding = new System.Windows.Forms.Padding(3);
            this.BuildLog.Size = new System.Drawing.Size(767, 132);
            this.BuildLog.TabIndex = 0;
            this.BuildLog.Text = "Вывод";
            this.BuildLog.UseVisualStyleBackColor = true;
            // 
            // IDE
            // 
            this.IDE.Location = new System.Drawing.Point(4, 22);
            this.IDE.Name = "IDE";
            this.IDE.Padding = new System.Windows.Forms.Padding(3);
            this.IDE.Size = new System.Drawing.Size(767, 134);
            this.IDE.TabIndex = 2;
            this.IDE.Text = "Среда";
            this.IDE.UseVisualStyleBackColor = true;
            // 
            // SearchLog
            // 
            this.SearchLog.Location = new System.Drawing.Point(4, 22);
            this.SearchLog.Name = "SearchLog";
            this.SearchLog.Padding = new System.Windows.Forms.Padding(3);
            this.SearchLog.Size = new System.Drawing.Size(767, 134);
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
            this.MenuSolution,
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
            this.MenuFileItemSaveAll,
            this.MenuFileSeparator3,
            this.MenuFileExit});
            this.MenuFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, -1);
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(48, 21);
            this.MenuFile.Text = "Файл";
            // 
            // MenuFileCreate
            // 
            this.MenuFileCreate.Name = "MenuFileCreate";
            this.MenuFileCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuFileCreate.Size = new System.Drawing.Size(319, 22);
            this.MenuFileCreate.Text = "Создать...";
            this.MenuFileCreate.Click += new System.EventHandler(this.MenuFileCreate_Click);
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuFileOpen.Size = new System.Drawing.Size(319, 22);
            this.MenuFileOpen.Text = "Открыть...";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
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
            // MenuFileSeparator2
            // 
            this.MenuFileSeparator2.Name = "MenuFileSeparator2";
            this.MenuFileSeparator2.Size = new System.Drawing.Size(316, 6);
            // 
            // MenuFileSaveCurrent
            // 
            this.MenuFileSaveCurrent.Name = "MenuFileSaveCurrent";
            this.MenuFileSaveCurrent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuFileSaveCurrent.Size = new System.Drawing.Size(319, 22);
            this.MenuFileSaveCurrent.Text = "Сохранить";
            this.MenuFileSaveCurrent.Click += new System.EventHandler(this.MenuFileSaveCurrent_Click);
            // 
            // MenuFileItemSaveAll
            // 
            this.MenuFileItemSaveAll.Name = "MenuFileItemSaveAll";
            this.MenuFileItemSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuFileItemSaveAll.Size = new System.Drawing.Size(319, 22);
            this.MenuFileItemSaveAll.Text = "Сохранить всё";
            this.MenuFileItemSaveAll.Click += new System.EventHandler(this.MenuFileItemSaveAll_Click);
            // 
            // MenuFileSeparator3
            // 
            this.MenuFileSeparator3.Name = "MenuFileSeparator3";
            this.MenuFileSeparator3.Size = new System.Drawing.Size(316, 6);
            // 
            // MenuFileExit
            // 
            this.MenuFileExit.Name = "MenuFileExit";
            this.MenuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuFileExit.Size = new System.Drawing.Size(319, 22);
            this.MenuFileExit.Text = "Выход";
            this.MenuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
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
            this.MenuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuEditUndo.Size = new System.Drawing.Size(169, 22);
            this.MenuEditUndo.Text = "Отменить";
            // 
            // MenuEditRedo
            // 
            this.MenuEditRedo.Name = "MenuEditRedo";
            this.MenuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuEditRedo.Size = new System.Drawing.Size(169, 22);
            this.MenuEditRedo.Text = "Вернуть";
            // 
            // MenuEditSeparator1
            // 
            this.MenuEditSeparator1.Name = "MenuEditSeparator1";
            this.MenuEditSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuEditCut
            // 
            this.MenuEditCut.Name = "MenuEditCut";
            this.MenuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuEditCut.Size = new System.Drawing.Size(181, 22);
            this.MenuEditCut.Text = "Вырезать";
            // 
            // MenuEditCopy
            // 
            this.MenuEditCopy.Name = "MenuEditCopy";
            this.MenuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuEditCopy.Size = new System.Drawing.Size(181, 22);
            this.MenuEditCopy.Text = "Копировать";
            // 
            // MenuEditPaste
            // 
            this.MenuEditPaste.Name = "MenuEditPaste";
            this.MenuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuEditPaste.Size = new System.Drawing.Size(181, 22);
            this.MenuEditPaste.Text = "Вставить";
            // 
            // MenuEditDelete
            // 
            this.MenuEditDelete.Name = "MenuEditDelete";
            this.MenuEditDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MenuEditDelete.Size = new System.Drawing.Size(181, 22);
            this.MenuEditDelete.Text = "Удалить";
            // 
            // MenuEditSeparator2
            // 
            this.MenuEditSeparator2.Name = "MenuEditSeparator2";
            this.MenuEditSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuEditSelectAll
            // 
            this.MenuEditSelectAll.Name = "MenuEditSelectAll";
            this.MenuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuEditSelectAll.Size = new System.Drawing.Size(190, 22);
            this.MenuEditSelectAll.Text = "Выделить всё";
            // 
            // MenuEditSeparator3
            // 
            this.MenuEditSeparator3.Name = "MenuEditSeparator3";
            this.MenuEditSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuEditFind
            // 
            this.MenuEditFind.Name = "MenuEditFind";
            this.MenuEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MenuEditFind.Size = new System.Drawing.Size(190, 22);
            this.MenuEditFind.Text = "Найти...";
            // 
            // MenuEditReplace
            // 
            this.MenuEditReplace.Name = "MenuEditReplace";
            this.MenuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.MenuEditReplace.Size = new System.Drawing.Size(190, 22);
            this.MenuEditReplace.Text = "Заменить...";
            // 
            // MenuSolution
            // 
            this.MenuSolution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSolutionRun,
            this.MenuSolutionTest,
            this.MenuSolutionSeparator1,
            this.MenuSolutionProperties});
            this.MenuSolution.Name = "MenuSolution";
            this.MenuSolution.Size = new System.Drawing.Size(69, 20);
            this.MenuSolution.Text = "Решение";
            // 
            // MenuSolutionRun
            // 
            this.MenuSolutionRun.Name = "MenuSolutionRun";
            this.MenuSolutionRun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.MenuSolutionRun.Size = new System.Drawing.Size(185, 22);
            this.MenuSolutionRun.Text = "Запуск";
            // 
            // MenuSolutionTest
            // 
            this.MenuSolutionTest.Name = "MenuSolutionTest";
            this.MenuSolutionTest.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F5)));
            this.MenuSolutionTest.Size = new System.Drawing.Size(185, 22);
            this.MenuSolutionTest.Text = "Тест...";
            // 
            // MenuSolutionSeparator1
            // 
            this.MenuSolutionSeparator1.Name = "MenuSolutionSeparator1";
            this.MenuSolutionSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // MenuSolutionProperties
            // 
            this.MenuSolutionProperties.Name = "MenuSolutionProperties";
            this.MenuSolutionProperties.Size = new System.Drawing.Size(125, 22);
            this.MenuSolutionProperties.Text = "Свойства";
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
            this.MenuBuildSolutionCleanAndRebuild.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.MenuBuildSolutionCleanAndRebuild.Size = new System.Drawing.Size(307, 22);
            this.MenuBuildSolutionCleanAndRebuild.Text = "Очистить и перестроить решение";
            // 
            // MenuBuildProjectCleanAndRebuild
            // 
            this.MenuBuildProjectCleanAndRebuild.Name = "MenuBuildProjectCleanAndRebuild";
            this.MenuBuildProjectCleanAndRebuild.Size = new System.Drawing.Size(261, 22);
            this.MenuBuildProjectCleanAndRebuild.Text = "Очистить и перестроить проект";
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
            this.MenuServiceSettings.Click += new System.EventHandler(this.MenuServiceSettings_Click);
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
            this.MenuHelpContents.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.MenuHelpContents.Size = new System.Drawing.Size(225, 22);
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
            // 
            // StatusBarProgress
            // 
            this.StatusBarProgress.Name = "StatusBarProgress";
            this.StatusBarProgress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.StatusBarProgress.Size = new System.Drawing.Size(100, 16);
            this.StatusBarProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.StatusBarProgress.Visible = false;
            // 
            // WorkingFilesTabContextMenu
            // 
            this.WorkingFilesTabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkingFilesTabContextMenuClose,
            this.WorkingFilesTabContextMenuSeparator1,
            this.WorkingFilesTabContextMenuCloseLeft,
            this.WorkingFilesTabContextMenuCloseRight,
            this.WorkingFilesTabContextMenuSeparator2,
            this.WorkingFilesTabContextMenuCloseAllExceptThat,
            this.WorkingFilesTabContextMenuCloseAll});
            this.WorkingFilesTabContextMenu.Name = "WorkingFilesTabContextMenu";
            this.WorkingFilesTabContextMenu.Size = new System.Drawing.Size(211, 126);
            // 
            // WorkingFilesTabContextMenuClose
            // 
            this.WorkingFilesTabContextMenuClose.Name = "WorkingFilesTabContextMenuClose";
            this.WorkingFilesTabContextMenuClose.Size = new System.Drawing.Size(210, 22);
            this.WorkingFilesTabContextMenuClose.Text = "Закрыть";
            this.WorkingFilesTabContextMenuClose.Click += new System.EventHandler(this.WorkingFilesTabContextMenuClose_Click);
            // 
            // WorkingFilesTabContextMenuSeparator1
            // 
            this.WorkingFilesTabContextMenuSeparator1.Name = "WorkingFilesTabContextMenuSeparator1";
            this.WorkingFilesTabContextMenuSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // WorkingFilesTabContextMenuCloseLeft
            // 
            this.WorkingFilesTabContextMenuCloseLeft.Name = "WorkingFilesTabContextMenuCloseLeft";
            this.WorkingFilesTabContextMenuCloseLeft.Size = new System.Drawing.Size(210, 22);
            this.WorkingFilesTabContextMenuCloseLeft.Text = "Закрыть слева";
            this.WorkingFilesTabContextMenuCloseLeft.Click += new System.EventHandler(this.WorkingFilesTabContextMenuCloseLeft_Click);
            // 
            // WorkingFilesTabContextMenuCloseRight
            // 
            this.WorkingFilesTabContextMenuCloseRight.Name = "WorkingFilesTabContextMenuCloseRight";
            this.WorkingFilesTabContextMenuCloseRight.Size = new System.Drawing.Size(210, 22);
            this.WorkingFilesTabContextMenuCloseRight.Text = "Закрыть справа";
            this.WorkingFilesTabContextMenuCloseRight.Click += new System.EventHandler(this.WorkingFilesTabContextMenuCloseRight_Click);
            // 
            // WorkingFilesTabContextMenuSeparator2
            // 
            this.WorkingFilesTabContextMenuSeparator2.Name = "WorkingFilesTabContextMenuSeparator2";
            this.WorkingFilesTabContextMenuSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // WorkingFilesTabContextMenuCloseAllExceptThat
            // 
            this.WorkingFilesTabContextMenuCloseAllExceptThat.Name = "WorkingFilesTabContextMenuCloseAllExceptThat";
            this.WorkingFilesTabContextMenuCloseAllExceptThat.Size = new System.Drawing.Size(210, 22);
            this.WorkingFilesTabContextMenuCloseAllExceptThat.Text = "Закрыть все, кроме этой";
            this.WorkingFilesTabContextMenuCloseAllExceptThat.Click += new System.EventHandler(this.WorkingFilesTabContextMenuCloseAllExceptThat_Click);
            // 
            // WorkingFilesTabContextMenuCloseAll
            // 
            this.WorkingFilesTabContextMenuCloseAll.Name = "WorkingFilesTabContextMenuCloseAll";
            this.WorkingFilesTabContextMenuCloseAll.Size = new System.Drawing.Size(210, 22);
            this.WorkingFilesTabContextMenuCloseAll.Text = "Закрыть все";
            this.WorkingFilesTabContextMenuCloseAll.Click += new System.EventHandler(this.WorkingFilesTabContextMenuCloseAll_Click);
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
            this.SolutionExplorerContextMenu.ResumeLayout(false);
            this.SplitSolutionDevelopment.Panel1.ResumeLayout(false);
            this.SplitSolutionDevelopment.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitSolutionDevelopment)).EndInit();
            this.SplitSolutionDevelopment.ResumeLayout(false);
            this.SplitCodeBuild.Panel1.ResumeLayout(false);
            this.SplitCodeBuild.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitCodeBuild)).EndInit();
            this.SplitCodeBuild.ResumeLayout(false);
            this.Logs.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.WorkingFilesTabContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem MenuSolution;
        private System.Windows.Forms.ToolStripMenuItem MenuSolutionRun;
        private System.Windows.Forms.ToolStripMenuItem MenuSolutionTest;
        private System.Windows.Forms.ToolStripSeparator MenuSolutionSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuSolutionProperties;
        private System.Windows.Forms.ContextMenuStrip SolutionExplorerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuOpenOut;
        private System.Windows.Forms.ToolStripSeparator SolutionExplorerContextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuRename;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuDelete;
        private System.Windows.Forms.ToolStripSeparator SolutionExplorerContextMenuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuProperties;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuDeleteRemove;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuDeleteDelete;
        private System.Windows.Forms.TabPage IDE;
        private System.Windows.Forms.ContextMenuStrip WorkingFilesTabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem WorkingFilesTabContextMenuClose;
        private System.Windows.Forms.ToolStripSeparator WorkingFilesTabContextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem WorkingFilesTabContextMenuCloseLeft;
        private System.Windows.Forms.ToolStripMenuItem WorkingFilesTabContextMenuCloseRight;
        private System.Windows.Forms.ToolStripSeparator WorkingFilesTabContextMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem WorkingFilesTabContextMenuCloseAllExceptThat;
        private System.Windows.Forms.ToolStripMenuItem WorkingFilesTabContextMenuCloseAll;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuСut;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuAdd;
        private System.Windows.Forms.ToolStripSeparator SolutionExplorerContextMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuAddFolder;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuAddFile;
        private System.Windows.Forms.ToolStripSeparator SolutionExplorerContextMenuAddSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SolutionExplorerContextMenuAddElement;
    }
}


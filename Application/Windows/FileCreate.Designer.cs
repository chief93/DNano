namespace IDE.Windows
{
    partial class FileCreate
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Проекты", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Файлы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("D");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Установленные", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("В интернете");
            this.FileCreateDialogSelectedGroupItems = new System.Windows.Forms.ListView();
            this.ColumnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileCreateDialogFieldName = new System.Windows.Forms.TextBox();
            this.FileCreateDialogFieldLocation = new System.Windows.Forms.TextBox();
            this.FileCreateDialogDesciprionLabel = new System.Windows.Forms.Label();
            this.FileCreateDialogButtonCancel = new System.Windows.Forms.Button();
            this.FileCreateDialogButtonCreate = new System.Windows.Forms.Button();
            this.FileCreateDialogTargetPath = new System.Windows.Forms.Label();
            this.FileCreateDialogLabelName = new System.Windows.Forms.Label();
            this.FileCreateDialogLabelLocation = new System.Windows.Forms.Label();
            this.FileCreateDialogDescription = new System.Windows.Forms.Label();
            this.FileCreateDialogLabelResultPath = new System.Windows.Forms.Label();
            this.FileCreateDialogButtonBrowse = new System.Windows.Forms.Button();
            this.FileCreateDialogTemplates = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // FileCreateDialogSelectedGroupItems
            // 
            this.FileCreateDialogSelectedGroupItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTitle,
            this.ColumnExtension});
            listViewGroup1.Header = "Проекты";
            listViewGroup1.Name = "ProjectTypes";
            listViewGroup2.Header = "Файлы";
            listViewGroup2.Name = "GroupFileSystem";
            this.FileCreateDialogSelectedGroupItems.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.FileCreateDialogSelectedGroupItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FileCreateDialogSelectedGroupItems.Location = new System.Drawing.Point(170, 0);
            this.FileCreateDialogSelectedGroupItems.MultiSelect = false;
            this.FileCreateDialogSelectedGroupItems.Name = "FileCreateDialogSelectedGroupItems";
            this.FileCreateDialogSelectedGroupItems.Size = new System.Drawing.Size(344, 372);
            this.FileCreateDialogSelectedGroupItems.TabIndex = 1;
            this.FileCreateDialogSelectedGroupItems.TileSize = new System.Drawing.Size(200, 30);
            this.FileCreateDialogSelectedGroupItems.UseCompatibleStateImageBehavior = false;
            this.FileCreateDialogSelectedGroupItems.View = System.Windows.Forms.View.Details;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.Text = "Тип";
            this.ColumnTitle.Width = 200;
            // 
            // ColumnExtension
            // 
            this.ColumnExtension.Text = "Расширение";
            this.ColumnExtension.Width = 100;
            // 
            // FileCreateDialogFieldName
            // 
            this.FileCreateDialogFieldName.Location = new System.Drawing.Point(91, 378);
            this.FileCreateDialogFieldName.Name = "FileCreateDialogFieldName";
            this.FileCreateDialogFieldName.Size = new System.Drawing.Size(601, 20);
            this.FileCreateDialogFieldName.TabIndex = 2;
            // 
            // FileCreateDialogFieldLocation
            // 
            this.FileCreateDialogFieldLocation.Location = new System.Drawing.Point(91, 404);
            this.FileCreateDialogFieldLocation.Name = "FileCreateDialogFieldLocation";
            this.FileCreateDialogFieldLocation.Size = new System.Drawing.Size(520, 20);
            this.FileCreateDialogFieldLocation.TabIndex = 3;
            // 
            // FileCreateDialogDesciprionLabel
            // 
            this.FileCreateDialogDesciprionLabel.AutoSize = true;
            this.FileCreateDialogDesciprionLabel.Location = new System.Drawing.Point(520, 9);
            this.FileCreateDialogDesciprionLabel.Name = "FileCreateDialogDesciprionLabel";
            this.FileCreateDialogDesciprionLabel.Size = new System.Drawing.Size(60, 13);
            this.FileCreateDialogDesciprionLabel.TabIndex = 4;
            this.FileCreateDialogDesciprionLabel.Text = "Описание:";
            // 
            // FileCreateDialogButtonCancel
            // 
            this.FileCreateDialogButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FileCreateDialogButtonCancel.Location = new System.Drawing.Point(617, 439);
            this.FileCreateDialogButtonCancel.Name = "FileCreateDialogButtonCancel";
            this.FileCreateDialogButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.FileCreateDialogButtonCancel.TabIndex = 5;
            this.FileCreateDialogButtonCancel.Text = "Отмена";
            this.FileCreateDialogButtonCancel.UseVisualStyleBackColor = true;
            // 
            // FileCreateDialogButtonCreate
            // 
            this.FileCreateDialogButtonCreate.Location = new System.Drawing.Point(536, 439);
            this.FileCreateDialogButtonCreate.Name = "FileCreateDialogButtonCreate";
            this.FileCreateDialogButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.FileCreateDialogButtonCreate.TabIndex = 6;
            this.FileCreateDialogButtonCreate.Text = "Создать";
            this.FileCreateDialogButtonCreate.UseVisualStyleBackColor = true;
            // 
            // FileCreateDialogTargetPath
            // 
            this.FileCreateDialogTargetPath.AutoSize = true;
            this.FileCreateDialogTargetPath.Location = new System.Drawing.Point(88, 439);
            this.FileCreateDialogTargetPath.Name = "FileCreateDialogTargetPath";
            this.FileCreateDialogTargetPath.Size = new System.Drawing.Size(80, 13);
            this.FileCreateDialogTargetPath.TabIndex = 7;
            this.FileCreateDialogTargetPath.Text = "/home/projects";
            // 
            // FileCreateDialogLabelName
            // 
            this.FileCreateDialogLabelName.AutoSize = true;
            this.FileCreateDialogLabelName.Location = new System.Drawing.Point(12, 381);
            this.FileCreateDialogLabelName.Name = "FileCreateDialogLabelName";
            this.FileCreateDialogLabelName.Size = new System.Drawing.Size(32, 13);
            this.FileCreateDialogLabelName.TabIndex = 8;
            this.FileCreateDialogLabelName.Text = "Имя:";
            // 
            // FileCreateDialogLabelLocation
            // 
            this.FileCreateDialogLabelLocation.AutoSize = true;
            this.FileCreateDialogLabelLocation.Location = new System.Drawing.Point(12, 407);
            this.FileCreateDialogLabelLocation.Name = "FileCreateDialogLabelLocation";
            this.FileCreateDialogLabelLocation.Size = new System.Drawing.Size(51, 13);
            this.FileCreateDialogLabelLocation.TabIndex = 9;
            this.FileCreateDialogLabelLocation.Text = "Каталог:";
            // 
            // FileCreateDialogDescription
            // 
            this.FileCreateDialogDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileCreateDialogDescription.AutoEllipsis = true;
            this.FileCreateDialogDescription.AutoSize = true;
            this.FileCreateDialogDescription.Location = new System.Drawing.Point(520, 35);
            this.FileCreateDialogDescription.MaximumSize = new System.Drawing.Size(190, 0);
            this.FileCreateDialogDescription.Name = "FileCreateDialogDescription";
            this.FileCreateDialogDescription.Size = new System.Drawing.Size(179, 26);
            this.FileCreateDialogDescription.TabIndex = 10;
            this.FileCreateDialogDescription.Text = "Текстовое описание выбранного элемента";
            // 
            // FileCreateDialogLabelResultPath
            // 
            this.FileCreateDialogLabelResultPath.AutoSize = true;
            this.FileCreateDialogLabelResultPath.Location = new System.Drawing.Point(12, 439);
            this.FileCreateDialogLabelResultPath.Name = "FileCreateDialogLabelResultPath";
            this.FileCreateDialogLabelResultPath.Size = new System.Drawing.Size(62, 13);
            this.FileCreateDialogLabelResultPath.TabIndex = 11;
            this.FileCreateDialogLabelResultPath.Text = "Результат:";
            // 
            // FileCreateDialogButtonBrowse
            // 
            this.FileCreateDialogButtonBrowse.Location = new System.Drawing.Point(617, 402);
            this.FileCreateDialogButtonBrowse.Name = "FileCreateDialogButtonBrowse";
            this.FileCreateDialogButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.FileCreateDialogButtonBrowse.TabIndex = 12;
            this.FileCreateDialogButtonBrowse.Text = "Обзор";
            this.FileCreateDialogButtonBrowse.UseVisualStyleBackColor = true;
            // 
            // FileCreateDialogTemplates
            // 
            this.FileCreateDialogTemplates.Location = new System.Drawing.Point(0, 0);
            this.FileCreateDialogTemplates.Name = "FileCreateDialogTemplates";
            treeNode1.Name = "InstalledDLang";
            treeNode1.Text = "D";
            treeNode2.Name = "Installed";
            treeNode2.Text = "Установленные";
            treeNode3.Name = "Download";
            treeNode3.Text = "В интернете";
            this.FileCreateDialogTemplates.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.FileCreateDialogTemplates.Size = new System.Drawing.Size(164, 372);
            this.FileCreateDialogTemplates.TabIndex = 13;
            // 
            // FileCreate
            // 
            this.AcceptButton = this.FileCreateDialogButtonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FileCreateDialogButtonCancel;
            this.ClientSize = new System.Drawing.Size(704, 474);
            this.Controls.Add(this.FileCreateDialogTemplates);
            this.Controls.Add(this.FileCreateDialogButtonBrowse);
            this.Controls.Add(this.FileCreateDialogLabelResultPath);
            this.Controls.Add(this.FileCreateDialogDescription);
            this.Controls.Add(this.FileCreateDialogLabelLocation);
            this.Controls.Add(this.FileCreateDialogLabelName);
            this.Controls.Add(this.FileCreateDialogTargetPath);
            this.Controls.Add(this.FileCreateDialogButtonCreate);
            this.Controls.Add(this.FileCreateDialogButtonCancel);
            this.Controls.Add(this.FileCreateDialogDesciprionLabel);
            this.Controls.Add(this.FileCreateDialogFieldLocation);
            this.Controls.Add(this.FileCreateDialogFieldName);
            this.Controls.Add(this.FileCreateDialogSelectedGroupItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileCreate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Создать";
            this.Shown += new System.EventHandler(this.FileCreate_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FileCreateDialogSelectedGroupItems;
        private System.Windows.Forms.TextBox FileCreateDialogFieldName;
        private System.Windows.Forms.TextBox FileCreateDialogFieldLocation;
        private System.Windows.Forms.Label FileCreateDialogDesciprionLabel;
        private System.Windows.Forms.Button FileCreateDialogButtonCancel;
        private System.Windows.Forms.Button FileCreateDialogButtonCreate;
        private System.Windows.Forms.Label FileCreateDialogTargetPath;
        private System.Windows.Forms.Label FileCreateDialogLabelName;
        private System.Windows.Forms.Label FileCreateDialogLabelLocation;
        private System.Windows.Forms.Label FileCreateDialogDescription;
        private System.Windows.Forms.Label FileCreateDialogLabelResultPath;
        private System.Windows.Forms.Button FileCreateDialogButtonBrowse;
        private System.Windows.Forms.ColumnHeader ColumnTitle;
        private System.Windows.Forms.ColumnHeader ColumnExtension;
        private System.Windows.Forms.TreeView FileCreateDialogTemplates;
    }
}
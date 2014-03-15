namespace IDE.Windows
{
    partial class ServiceSettings
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
            this.SettingsDialogButtonSave = new System.Windows.Forms.Button();
            this.SettingsDialogButtonCancel = new System.Windows.Forms.Button();
            this.SettingsDialogTabs = new System.Windows.Forms.TabControl();
            this.SettingsDialogTabCommon = new System.Windows.Forms.TabPage();
            this.SettingsDialogTabBuilding = new System.Windows.Forms.TabPage();
            this.SettingsDialogBuildingCompilerBrowse = new System.Windows.Forms.Button();
            this.SettingsDialogBuildingCompilerPathLabel = new System.Windows.Forms.Label();
            this.SettingsDialogBuildingCompilerPath = new System.Windows.Forms.TextBox();
            this.SettingsDialogTabs.SuspendLayout();
            this.SettingsDialogTabBuilding.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsDialogButtonSave
            // 
            this.SettingsDialogButtonSave.Location = new System.Drawing.Point(270, 287);
            this.SettingsDialogButtonSave.Name = "SettingsDialogButtonSave";
            this.SettingsDialogButtonSave.Size = new System.Drawing.Size(85, 23);
            this.SettingsDialogButtonSave.TabIndex = 1;
            this.SettingsDialogButtonSave.Text = "Сохранить";
            this.SettingsDialogButtonSave.UseVisualStyleBackColor = true;
            this.SettingsDialogButtonSave.Click += new System.EventHandler(this.SettingsDialogButtonSave_Click);
            // 
            // SettingsDialogButtonCancel
            // 
            this.SettingsDialogButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SettingsDialogButtonCancel.Location = new System.Drawing.Point(361, 287);
            this.SettingsDialogButtonCancel.Name = "SettingsDialogButtonCancel";
            this.SettingsDialogButtonCancel.Size = new System.Drawing.Size(91, 23);
            this.SettingsDialogButtonCancel.TabIndex = 2;
            this.SettingsDialogButtonCancel.Text = "Отмена";
            this.SettingsDialogButtonCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsDialogTabs
            // 
            this.SettingsDialogTabs.Controls.Add(this.SettingsDialogTabCommon);
            this.SettingsDialogTabs.Controls.Add(this.SettingsDialogTabBuilding);
            this.SettingsDialogTabs.Location = new System.Drawing.Point(0, 2);
            this.SettingsDialogTabs.Name = "SettingsDialogTabs";
            this.SettingsDialogTabs.SelectedIndex = 0;
            this.SettingsDialogTabs.Size = new System.Drawing.Size(466, 279);
            this.SettingsDialogTabs.TabIndex = 3;
            // 
            // SettingsDialogTabCommon
            // 
            this.SettingsDialogTabCommon.Location = new System.Drawing.Point(4, 22);
            this.SettingsDialogTabCommon.Name = "SettingsDialogTabCommon";
            this.SettingsDialogTabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsDialogTabCommon.Size = new System.Drawing.Size(458, 253);
            this.SettingsDialogTabCommon.TabIndex = 0;
            this.SettingsDialogTabCommon.Text = "Общее";
            this.SettingsDialogTabCommon.UseVisualStyleBackColor = true;
            // 
            // SettingsDialogTabBuilding
            // 
            this.SettingsDialogTabBuilding.Controls.Add(this.SettingsDialogBuildingCompilerBrowse);
            this.SettingsDialogTabBuilding.Controls.Add(this.SettingsDialogBuildingCompilerPathLabel);
            this.SettingsDialogTabBuilding.Controls.Add(this.SettingsDialogBuildingCompilerPath);
            this.SettingsDialogTabBuilding.Location = new System.Drawing.Point(4, 22);
            this.SettingsDialogTabBuilding.Name = "SettingsDialogTabBuilding";
            this.SettingsDialogTabBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsDialogTabBuilding.Size = new System.Drawing.Size(458, 253);
            this.SettingsDialogTabBuilding.TabIndex = 1;
            this.SettingsDialogTabBuilding.Text = "Компиляция";
            this.SettingsDialogTabBuilding.UseVisualStyleBackColor = true;
            // 
            // SettingsDialogBuildingCompilerBrowse
            // 
            this.SettingsDialogBuildingCompilerBrowse.Location = new System.Drawing.Point(373, 23);
            this.SettingsDialogBuildingCompilerBrowse.Name = "SettingsDialogBuildingCompilerBrowse";
            this.SettingsDialogBuildingCompilerBrowse.Size = new System.Drawing.Size(75, 23);
            this.SettingsDialogBuildingCompilerBrowse.TabIndex = 2;
            this.SettingsDialogBuildingCompilerBrowse.Text = "Обзор";
            this.SettingsDialogBuildingCompilerBrowse.UseVisualStyleBackColor = true;
            // 
            // SettingsDialogBuildingCompilerPathLabel
            // 
            this.SettingsDialogBuildingCompilerPathLabel.AutoSize = true;
            this.SettingsDialogBuildingCompilerPathLabel.Location = new System.Drawing.Point(8, 28);
            this.SettingsDialogBuildingCompilerPathLabel.Name = "SettingsDialogBuildingCompilerPathLabel";
            this.SettingsDialogBuildingCompilerPathLabel.Size = new System.Drawing.Size(72, 13);
            this.SettingsDialogBuildingCompilerPathLabel.TabIndex = 1;
            this.SettingsDialogBuildingCompilerPathLabel.Text = "Компилятор:";
            // 
            // SettingsDialogBuildingCompilerPath
            // 
            this.SettingsDialogBuildingCompilerPath.Location = new System.Drawing.Point(86, 25);
            this.SettingsDialogBuildingCompilerPath.Name = "SettingsDialogBuildingCompilerPath";
            this.SettingsDialogBuildingCompilerPath.Size = new System.Drawing.Size(281, 20);
            this.SettingsDialogBuildingCompilerPath.TabIndex = 0;
            // 
            // ServiceSettings
            // 
            this.AcceptButton = this.SettingsDialogButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SettingsDialogButtonCancel;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.SettingsDialogButtonSave);
            this.Controls.Add(this.SettingsDialogTabs);
            this.Controls.Add(this.SettingsDialogButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.SettingsDialogTabs.ResumeLayout(false);
            this.SettingsDialogTabBuilding.ResumeLayout(false);
            this.SettingsDialogTabBuilding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SettingsDialogButtonSave;
        private System.Windows.Forms.Button SettingsDialogButtonCancel;
        private System.Windows.Forms.TabControl SettingsDialogTabs;
        private System.Windows.Forms.TabPage SettingsDialogTabCommon;
        private System.Windows.Forms.TabPage SettingsDialogTabBuilding;
        private System.Windows.Forms.Label SettingsDialogBuildingCompilerPathLabel;
        private System.Windows.Forms.TextBox SettingsDialogBuildingCompilerPath;
        private System.Windows.Forms.Button SettingsDialogBuildingCompilerBrowse;
    }
}
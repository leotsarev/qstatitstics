namespace QStatitstics
{
    partial class MatchesListForm
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
            this.components = new System.ComponentModel.Container();
            this.MatchesGrid = new System.Windows.Forms.DataGridView();
            this.ByTeamsCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterDropDown = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QStatitstics.Appcode.DataSet1();
            this.teamsTableAdapter = new QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.chooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MatchesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MatchesGrid
            // 
            this.MatchesGrid.AllowUserToAddRows = false;
            this.MatchesGrid.AllowUserToDeleteRows = false;
            this.MatchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchesGrid.Location = new System.Drawing.Point(12, 12);
            this.MatchesGrid.Name = "MatchesGrid";
            this.MatchesGrid.ReadOnly = true;
            this.MatchesGrid.Size = new System.Drawing.Size(669, 494);
            this.MatchesGrid.TabIndex = 0;
            // 
            // ByTeamsCheckBox
            // 
            this.ByTeamsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ByTeamsCheckBox.AutoSize = true;
            this.ByTeamsCheckBox.Location = new System.Drawing.Point(12, 526);
            this.ByTeamsCheckBox.Name = "ByTeamsCheckBox";
            this.ByTeamsCheckBox.Size = new System.Drawing.Size(136, 17);
            this.ByTeamsCheckBox.TabIndex = 9;
            this.ByTeamsCheckBox.Text = "Фильтр по командам";
            this.ByTeamsCheckBox.UseVisualStyleBackColor = true;
            this.ByTeamsCheckBox.CheckedChanged += new System.EventHandler(this.ByTeamsCheckBox_CheckedChanged);
            // 
            // FilterDropDown
            // 
            this.FilterDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterDropDown.DataSource = this.teamsBindingSource;
            this.FilterDropDown.DisplayMember = "Name";
            this.FilterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterDropDown.Enabled = false;
            this.FilterDropDown.FormattingEnabled = true;
            this.FilterDropDown.Location = new System.Drawing.Point(154, 522);
            this.FilterDropDown.Name = "FilterDropDown";
            this.FilterDropDown.Size = new System.Drawing.Size(175, 21);
            this.FilterDropDown.TabIndex = 8;
            this.FilterDropDown.ValueMember = "TeamId";
            this.FilterDropDown.SelectedIndexChanged += new System.EventHandler(this.FilterDropDown_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(458, 520);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(108, 23);
            this.ViewButton.TabIndex = 10;
            this.ViewButton.Text = "Просмотр";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(572, 520);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(335, 522);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(117, 23);
            this.btnSaveAll.TabIndex = 12;
            this.btnSaveAll.Text = "Сохранить в папку";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.Description = "Папка для сохранения протоколв";
            // 
            // MatchesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 555);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ByTeamsCheckBox);
            this.Controls.Add(this.FilterDropDown);
            this.Controls.Add(this.MatchesGrid);
            this.MaximizeBox = false;
            this.Name = "MatchesListForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Матчи";
            this.Load += new System.EventHandler(this.MatchesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatchesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatchesGrid;
        private System.Windows.Forms.CheckBox ByTeamsCheckBox;
        private System.Windows.Forms.ComboBox FilterDropDown;
        private QStatitstics.Appcode.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.FolderBrowserDialog chooseFolder;


    }
}
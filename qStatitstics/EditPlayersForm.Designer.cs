using System;
using QStatitstics.Appcode;

namespace QStatitstics;

partial class EditPlayersForm
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        this.CloseButton = new System.Windows.Forms.Button();
        this.SaveButton = new System.Windows.Forms.Button();
        this.PlayersGrid = new System.Windows.Forms.DataGridView();
        this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.dataSet1 = new QStatitstics.Appcode.DataSet1();
        this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.playersTableAdapter = new QStatitstics.Appcode.DataSet1TableAdapters.PlayersTableAdapter();
        this.teamsTableAdapter = new QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter();
        this.FilterDropDown = new System.Windows.Forms.ComboBox();
        this.ByTeamsCheckBox = new System.Windows.Forms.CheckBox();
        this.LoadPlayers = new System.Windows.Forms.Button();
        this.CsvFileDialog = new System.Windows.Forms.OpenFileDialog();
        this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Team = new System.Windows.Forms.DataGridViewComboBoxColumn();
        this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Sex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.Seeker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.PlayersGrid)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
        this.SuspendLayout();
        // 
        // CloseButton
        // 
        this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.CloseButton.Location = new System.Drawing.Point(93, 368);
        this.CloseButton.Name = "CloseButton";
        this.CloseButton.Size = new System.Drawing.Size(75, 23);
        this.CloseButton.TabIndex = 5;
        this.CloseButton.Text = "Отмена";
        this.CloseButton.UseVisualStyleBackColor = true;
        this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
        // 
        // SaveButton
        // 
        this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.SaveButton.Location = new System.Drawing.Point(12, 368);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(75, 23);
        this.SaveButton.TabIndex = 4;
        this.SaveButton.Text = "Сохранить";
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
        // 
        // PlayersGrid
        // 
        this.PlayersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.PlayersGrid.AutoGenerateColumns = false;
        this.PlayersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.PlayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.PlayersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.playerIdDataGridViewTextBoxColumn,
        this.nameDataGridViewTextBoxColumn,
        this.nicknameDataGridViewTextBoxColumn,
        this.Team,
        this.numberDataGridViewTextBoxColumn,
        this.Sex,
        this.Seeker});
        this.PlayersGrid.DataSource = this.playersBindingSource;
        this.PlayersGrid.Location = new System.Drawing.Point(12, 12);
        this.PlayersGrid.Name = "PlayersGrid";
        this.PlayersGrid.Size = new System.Drawing.Size(744, 350);
        this.PlayersGrid.TabIndex = 3;
        this.PlayersGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PlayersGrid_RowValidating);
        this.PlayersGrid.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.PlayersGrid_DefaultValuesNeeded);
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
        // playersBindingSource
        // 
        this.playersBindingSource.DataMember = "Players";
        this.playersBindingSource.DataSource = this.dataSet1;
        // 
        // playersTableAdapter
        // 
        this.playersTableAdapter.ClearBeforeFill = true;
        // 
        // teamsTableAdapter
        // 
        this.teamsTableAdapter.ClearBeforeFill = true;
        // 
        // FilterDropDown
        // 
        this.FilterDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.FilterDropDown.DataSource = this.teamsBindingSource;
        this.FilterDropDown.DisplayMember = "Name";
        this.FilterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.FilterDropDown.Enabled = false;
        this.FilterDropDown.FormattingEnabled = true;
        this.FilterDropDown.Location = new System.Drawing.Point(316, 368);
        this.FilterDropDown.Name = "FilterDropDown";
        this.FilterDropDown.Size = new System.Drawing.Size(121, 21);
        this.FilterDropDown.TabIndex = 6;
        this.FilterDropDown.ValueMember = "TeamId";
        this.FilterDropDown.SelectedIndexChanged += new System.EventHandler(this.FilterDropDown_SelectedIndexChanged);
        // 
        // ByTeamsCheckBox
        // 
        this.ByTeamsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.ByTeamsCheckBox.AutoSize = true;
        this.ByTeamsCheckBox.Location = new System.Drawing.Point(174, 372);
        this.ByTeamsCheckBox.Name = "ByTeamsCheckBox";
        this.ByTeamsCheckBox.Size = new System.Drawing.Size(136, 17);
        this.ByTeamsCheckBox.TabIndex = 7;
        this.ByTeamsCheckBox.Text = "Фильтр по командам";
        this.ByTeamsCheckBox.UseVisualStyleBackColor = true;
        this.ByTeamsCheckBox.CheckedChanged += new System.EventHandler(this.ByTeamsCheckBox_CheckedChanged);
        // 
        // LoadPlayers
        // 
        this.LoadPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.LoadPlayers.Enabled = false;
        this.LoadPlayers.Location = new System.Drawing.Point(443, 368);
        this.LoadPlayers.Name = "LoadPlayers";
        this.LoadPlayers.Size = new System.Drawing.Size(163, 23);
        this.LoadPlayers.TabIndex = 8;
        this.LoadPlayers.Text = "Загрузить заявку (.CSV)..";
        this.LoadPlayers.UseVisualStyleBackColor = true;
        this.LoadPlayers.Click += new System.EventHandler(this.LoadPlayers_Click);
        // 
        // CsvFileDialog
        // 
        this.CsvFileDialog.Filter = "CSV files|*csv|All Files|*.*";
        this.CsvFileDialog.ReadOnlyChecked = true;
        this.CsvFileDialog.Title = "Выберите заявку для загрузки";
        // 
        // playerIdDataGridViewTextBoxColumn
        // 
        this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
        this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
        this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
        this.playerIdDataGridViewTextBoxColumn.Visible = false;
        this.playerIdDataGridViewTextBoxColumn.Width = 70;
        // 
        // nameDataGridViewTextBoxColumn
        // 
        this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        this.nameDataGridViewTextBoxColumn.HeaderText = "Имя Фамилия";
        this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        this.nameDataGridViewTextBoxColumn.Width = 97;
        // 
        // nicknameDataGridViewTextBoxColumn
        // 
        this.nicknameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
        this.nicknameDataGridViewTextBoxColumn.HeaderText = "Ник";
        this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
        this.nicknameDataGridViewTextBoxColumn.Width = 52;
        // 
        // Team
        // 
        this.Team.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.Team.DataPropertyName = "Team";
        this.Team.DataSource = this.teamsBindingSource;
        this.Team.DisplayMember = "Name";
        this.Team.HeaderText = "Команда";
        this.Team.Name = "Team";
        this.Team.ValueMember = "TeamId";
        this.Team.Width = 58;
        // 
        // numberDataGridViewTextBoxColumn
        // 
        this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
        dataGridViewCellStyle1.Format = "N0";
        dataGridViewCellStyle1.NullValue = null;
        this.numberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
        this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
        this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
        this.numberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        this.numberDataGridViewTextBoxColumn.Width = 66;
        // 
        // Sex
        // 
        this.Sex.DataPropertyName = "Sex";
        this.Sex.HeaderText = "Женщина?";
        this.Sex.Name = "Sex";
        this.Sex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        this.Sex.Width = 69;
        // 
        // Seeker
        // 
        this.Seeker.DataPropertyName = "Seeker";
        this.Seeker.HeaderText = "Ловец?";
        this.Seeker.Name = "Seeker";
        this.Seeker.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        this.Seeker.Width = 51;
        // 
        // EditPlayersForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(768, 403);
        this.Controls.Add(this.LoadPlayers);
        this.Controls.Add(this.ByTeamsCheckBox);
        this.Controls.Add(this.FilterDropDown);
        this.Controls.Add(this.CloseButton);
        this.Controls.Add(this.SaveButton);
        this.Controls.Add(this.PlayersGrid);
        this.Name = "EditPlayersForm";
        this.Text = "Управление игроками";
        this.Load += new System.EventHandler(this.EditPlayersForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.PlayersGrid)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    

    #endregion

    private System.Windows.Forms.Button CloseButton;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.DataGridView PlayersGrid;
    private DataSet1 dataSet1;
    private System.Windows.Forms.BindingSource playersBindingSource;
    private Appcode.DataSet1TableAdapters.PlayersTableAdapter playersTableAdapter;
    private System.Windows.Forms.BindingSource teamsBindingSource;
    private Appcode.DataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter;
    private System.Windows.Forms.ComboBox FilterDropDown;
    private System.Windows.Forms.CheckBox ByTeamsCheckBox;
    private System.Windows.Forms.Button LoadPlayers;
    private System.Windows.Forms.OpenFileDialog CsvFileDialog;
    private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn Team;
    private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Sex;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Seeker;
}
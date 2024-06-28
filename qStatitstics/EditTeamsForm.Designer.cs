namespace QStatitstics;

partial class EditTeamsForm
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
        this.TeamsGrid = new System.Windows.Forms.DataGridView();
        this.SaveButton = new System.Windows.Forms.Button();
        this.CloseButton = new System.Windows.Forms.Button();
        this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.Data = new QStatitstics.Appcode.DataSet1();
        this.teamsTableAdapter = new QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter();
        this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.TeamsGrid)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
        this.SuspendLayout();
        // 
        // TeamsGrid
        // 
        this.TeamsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.TeamsGrid.AutoGenerateColumns = false;
        this.TeamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.TeamsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.teamIdDataGridViewTextBoxColumn,
        this.nameDataGridViewTextBoxColumn,
        this.cityDataGridViewTextBoxColumn,
        this.Status});
        this.TeamsGrid.DataSource = this.teamsBindingSource;
        this.TeamsGrid.Location = new System.Drawing.Point(12, 12);
        this.TeamsGrid.Name = "TeamsGrid";
        this.TeamsGrid.Size = new System.Drawing.Size(443, 280);
        this.TeamsGrid.TabIndex = 0;
        this.TeamsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.TeamsGrid_UserDeletingRow);
        this.TeamsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TeamsGrid_RowValidating);
        // 
        // SaveButton
        // 
        this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.SaveButton.Location = new System.Drawing.Point(12, 301);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(75, 23);
        this.SaveButton.TabIndex = 1;
        this.SaveButton.Text = "Сохранить";
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
        // 
        // CloseButton
        // 
        this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.CloseButton.Location = new System.Drawing.Point(93, 301);
        this.CloseButton.Name = "CloseButton";
        this.CloseButton.Size = new System.Drawing.Size(75, 23);
        this.CloseButton.TabIndex = 2;
        this.CloseButton.Text = "Отмена";
        this.CloseButton.UseVisualStyleBackColor = true;
        // 
        // teamsBindingSource
        // 
        this.teamsBindingSource.DataMember = "Teams";
        this.teamsBindingSource.DataSource = this.Data;
        // 
        // Data
        // 
        this.Data.DataSetName = "DataSet1";
        this.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // teamsTableAdapter
        // 
        this.teamsTableAdapter.ClearBeforeFill = true;
        // 
        // teamIdDataGridViewTextBoxColumn
        // 
        this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
        this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
        this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
        this.teamIdDataGridViewTextBoxColumn.Visible = false;
        // 
        // nameDataGridViewTextBoxColumn
        // 
        this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        this.nameDataGridViewTextBoxColumn.HeaderText = "Название команды";
        this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        this.nameDataGridViewTextBoxColumn.Width = 150;
        // 
        // cityDataGridViewTextBoxColumn
        // 
        this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
        this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
        this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
        this.cityDataGridViewTextBoxColumn.Width = 150;
        // 
        // Status
        // 
        this.Status.DataPropertyName = "Status";
        this.Status.HeaderText = "Действующая?";
        this.Status.Name = "Status";
        // 
        // EditTeamsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(467, 333);
        this.Controls.Add(this.CloseButton);
        this.Controls.Add(this.SaveButton);
        this.Controls.Add(this.TeamsGrid);
        this.Name = "EditTeamsForm";
        this.Text = "Управление командами";
        this.Load += new System.EventHandler(this.EditTeamsForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.TeamsGrid)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView TeamsGrid;
    private QStatitstics.Appcode.DataSet1 Data;
    private System.Windows.Forms.BindingSource teamsBindingSource;
    private QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Button CloseButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
}
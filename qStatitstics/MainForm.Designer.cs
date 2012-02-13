namespace QStatitstics
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BeginMatchButton = new System.Windows.Forms.Button();
            this.HomeTeamDropDown = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new QStatitstics.Appcode.DataSet1();
            this.VisitorsTeamDropDown = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter();
            this.охотникиВратариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.playersToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.manageToolStripMenuItem.Text = "Управление";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teamsToolStripMenuItem.Text = "Команды";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playersToolStripMenuItem.Text = "Игроки";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchesToolStripMenuItem,
            this.playersToolStripMenuItem1,
            this.охотникиВратариToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.viewToolStripMenuItem.Text = "Просмотр";
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.matchesToolStripMenuItem.Text = "Матчи";
            this.matchesToolStripMenuItem.Click += new System.EventHandler(this.matchesToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem1
            // 
            this.playersToolStripMenuItem1.Name = "playersToolStripMenuItem1";
            this.playersToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.playersToolStripMenuItem1.Text = "Ловцы";
            this.playersToolStripMenuItem1.Click += new System.EventHandler(this.playersToolStripMenuItem1_Click);
            // 
            // BeginMatchButton
            // 
            this.BeginMatchButton.Location = new System.Drawing.Point(12, 90);
            this.BeginMatchButton.Name = "BeginMatchButton";
            this.BeginMatchButton.Size = new System.Drawing.Size(170, 23);
            this.BeginMatchButton.TabIndex = 1;
            this.BeginMatchButton.Text = "Начать матч";
            this.BeginMatchButton.UseVisualStyleBackColor = true;
            this.BeginMatchButton.Click += new System.EventHandler(this.BeginMatchButton_Click);
            // 
            // HomeTeamDropDown
            // 
            this.HomeTeamDropDown.DataSource = this.teamsBindingSource;
            this.HomeTeamDropDown.DisplayMember = "Name";
            this.HomeTeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HomeTeamDropDown.FormattingEnabled = true;
            this.HomeTeamDropDown.Location = new System.Drawing.Point(12, 36);
            this.HomeTeamDropDown.Name = "HomeTeamDropDown";
            this.HomeTeamDropDown.Size = new System.Drawing.Size(170, 21);
            this.HomeTeamDropDown.TabIndex = 2;
            this.HomeTeamDropDown.ValueMember = "TeamId";
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
            // VisitorsTeamDropDown
            // 
            this.VisitorsTeamDropDown.DataSource = this.teamsBindingSource1;
            this.VisitorsTeamDropDown.DisplayMember = "Name";
            this.VisitorsTeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisitorsTeamDropDown.FormattingEnabled = true;
            this.VisitorsTeamDropDown.Location = new System.Drawing.Point(12, 63);
            this.VisitorsTeamDropDown.Name = "VisitorsTeamDropDown";
            this.VisitorsTeamDropDown.Size = new System.Drawing.Size(170, 21);
            this.VisitorsTeamDropDown.TabIndex = 3;
            this.VisitorsTeamDropDown.ValueMember = "TeamId";
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.dataSet1;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // охотникиВратариToolStripMenuItem
            // 
            this.охотникиВратариToolStripMenuItem.Name = "охотникиВратариToolStripMenuItem";
            this.охотникиВратариToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.охотникиВратариToolStripMenuItem.Text = "Охотники/Вратари";
            this.охотникиВратариToolStripMenuItem.Click += new System.EventHandler(this.охотникиВратариToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.VisitorsTeamDropDown);
            this.Controls.Add(this.HomeTeamDropDown);
            this.Controls.Add(this.BeginMatchButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Статистика квиддича";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.Button BeginMatchButton;
        private System.Windows.Forms.ComboBox HomeTeamDropDown;
        private System.Windows.Forms.ComboBox VisitorsTeamDropDown;
        private QStatitstics.Appcode.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private QStatitstics.Appcode.DataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem охотникиВратариToolStripMenuItem;
    }
}


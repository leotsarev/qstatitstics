namespace QStatitstics
{
    partial class MatchForm
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
            this.HomeLabel = new System.Windows.Forms.Label();
            this.VisitorsLabel = new System.Windows.Forms.Label();
            this.HomeGrid = new System.Windows.Forms.DataGridView();
            this.VisitorsGrid = new System.Windows.Forms.DataGridView();
            this.EventsGrid = new System.Windows.Forms.DataGridView();
            this.EventTypeBox = new System.Windows.Forms.ListBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.VisitorsButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.EventTypeLabel = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.MatchTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BeginMatch = new System.Windows.Forms.Button();
            this.TechStop = new System.Windows.Forms.Button();
            this.DeleteLastButton = new System.Windows.Forms.Button();
            this.SnitchFlyingLabel = new System.Windows.Forms.Label();
            this.CorrectTime = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.OpenScoreFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HomeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeLabel.Location = new System.Drawing.Point(30, 26);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(208, 25);
            this.HomeLabel.TabIndex = 1;
            this.HomeLabel.Text = "Команда Хозяев";
            // 
            // VisitorsLabel
            // 
            this.VisitorsLabel.AutoSize = true;
            this.VisitorsLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitorsLabel.Location = new System.Drawing.Point(852, 26);
            this.VisitorsLabel.Name = "VisitorsLabel";
            this.VisitorsLabel.Size = new System.Drawing.Size(204, 25);
            this.VisitorsLabel.TabIndex = 15;
            this.VisitorsLabel.Text = "Команда Гостей";
            // 
            // HomeGrid
            // 
            this.HomeGrid.AllowUserToAddRows = false;
            this.HomeGrid.AllowUserToDeleteRows = false;
            this.HomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HomeGrid.Location = new System.Drawing.Point(12, 67);
            this.HomeGrid.Name = "HomeGrid";
            this.HomeGrid.ReadOnly = true;
            this.HomeGrid.RowHeadersWidth = 4;
            this.HomeGrid.Size = new System.Drawing.Size(360, 421);
            this.HomeGrid.TabIndex = 18;
            this.HomeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomeGrid_CellClick);
            // 
            // VisitorsGrid
            // 
            this.VisitorsGrid.AllowUserToAddRows = false;
            this.VisitorsGrid.AllowUserToDeleteRows = false;
            this.VisitorsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsGrid.Location = new System.Drawing.Point(814, 67);
            this.VisitorsGrid.Name = "VisitorsGrid";
            this.VisitorsGrid.ReadOnly = true;
            this.VisitorsGrid.RowHeadersWidth = 4;
            this.VisitorsGrid.Size = new System.Drawing.Size(360, 421);
            this.VisitorsGrid.TabIndex = 19;
            this.VisitorsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitorsGrid_CellClick);
            // 
            // EventsGrid
            // 
            this.EventsGrid.AllowUserToAddRows = false;
            this.EventsGrid.AllowUserToDeleteRows = false;
            this.EventsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EventsGrid.Location = new System.Drawing.Point(378, 67);
            this.EventsGrid.Name = "EventsGrid";
            this.EventsGrid.ReadOnly = true;
            this.EventsGrid.RowHeadersWidth = 4;
            this.EventsGrid.Size = new System.Drawing.Size(430, 421);
            this.EventsGrid.TabIndex = 20;
            this.EventsGrid.TabStop = false;
            this.EventsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventsGrid_CellContentDoubleClick);
            // 
            // EventTypeBox
            // 
            this.EventTypeBox.Enabled = false;
            this.EventTypeBox.FormattingEnabled = true;
            this.EventTypeBox.Location = new System.Drawing.Point(152, 499);
            this.EventTypeBox.Name = "EventTypeBox";
            this.EventTypeBox.Size = new System.Drawing.Size(120, 147);
            this.EventTypeBox.TabIndex = 21;
            this.EventTypeBox.SelectedIndexChanged += new System.EventHandler(this.EventTypeBox_SelectedIndexChanged);
            // 
            // HomeButton
            // 
            this.HomeButton.Enabled = false;
            this.HomeButton.Location = new System.Drawing.Point(296, 512);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(181, 23);
            this.HomeButton.TabIndex = 22;
            this.HomeButton.Text = "Хозяева (Z)";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // VisitorsButton
            // 
            this.VisitorsButton.Enabled = false;
            this.VisitorsButton.Location = new System.Drawing.Point(296, 541);
            this.VisitorsButton.Name = "VisitorsButton";
            this.VisitorsButton.Size = new System.Drawing.Size(181, 23);
            this.VisitorsButton.TabIndex = 23;
            this.VisitorsButton.Text = "Гости (X)";
            this.VisitorsButton.UseVisualStyleBackColor = true;
            this.VisitorsButton.Click += new System.EventHandler(this.VisitorsButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(32, 659);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 23);
            this.TimeLabel.TabIndex = 24;
            this.TimeLabel.Text = "---";
            // 
            // EventTypeLabel
            // 
            this.EventTypeLabel.AutoSize = true;
            this.EventTypeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventTypeLabel.Location = new System.Drawing.Point(148, 659);
            this.EventTypeLabel.Name = "EventTypeLabel";
            this.EventTypeLabel.Size = new System.Drawing.Size(0, 23);
            this.EventTypeLabel.TabIndex = 25;
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamLabel.Location = new System.Drawing.Point(415, 662);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(0, 23);
            this.TeamLabel.TabIndex = 26;
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPlayerLabel.Location = new System.Drawing.Point(635, 662);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(0, 23);
            this.FirstPlayerLabel.TabIndex = 27;
            // 
            // MatchTimeLabel
            // 
            this.MatchTimeLabel.AutoSize = true;
            this.MatchTimeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatchTimeLabel.Location = new System.Drawing.Point(542, 9);
            this.MatchTimeLabel.Name = "MatchTimeLabel";
            this.MatchTimeLabel.Size = new System.Drawing.Size(67, 23);
            this.MatchTimeLabel.TabIndex = 29;
            this.MatchTimeLabel.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BeginMatch
            // 
            this.BeginMatch.Location = new System.Drawing.Point(488, 38);
            this.BeginMatch.Name = "BeginMatch";
            this.BeginMatch.Size = new System.Drawing.Size(174, 23);
            this.BeginMatch.TabIndex = 30;
            this.BeginMatch.Text = "Начать Матч!";
            this.BeginMatch.UseVisualStyleBackColor = true;
            this.BeginMatch.Click += new System.EventHandler(this.BeginMatch_Click);
            // 
            // TechStop
            // 
            this.TechStop.Enabled = false;
            this.TechStop.Location = new System.Drawing.Point(1004, 499);
            this.TechStop.Name = "TechStop";
            this.TechStop.Size = new System.Drawing.Size(170, 23);
            this.TechStop.TabIndex = 31;
            this.TechStop.Text = "ПАУЗА";
            this.TechStop.UseVisualStyleBackColor = true;
            this.TechStop.Click += new System.EventHandler(this.TechStop_Click);
            // 
            // DeleteLastButton
            // 
            this.DeleteLastButton.Enabled = false;
            this.DeleteLastButton.Location = new System.Drawing.Point(523, 541);
            this.DeleteLastButton.Name = "DeleteLastButton";
            this.DeleteLastButton.Size = new System.Drawing.Size(101, 23);
            this.DeleteLastButton.TabIndex = 32;
            this.DeleteLastButton.Text = "C — Отменить";
            this.DeleteLastButton.UseVisualStyleBackColor = true;
            this.DeleteLastButton.Click += new System.EventHandler(this.DeleteLastButton_Click);
            // 
            // SnitchFlyingLabel
            // 
            this.SnitchFlyingLabel.AutoSize = true;
            this.SnitchFlyingLabel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnitchFlyingLabel.ForeColor = System.Drawing.Color.Red;
            this.SnitchFlyingLabel.Location = new System.Drawing.Point(518, 507);
            this.SnitchFlyingLabel.Name = "SnitchFlyingLabel";
            this.SnitchFlyingLabel.Size = new System.Drawing.Size(201, 26);
            this.SnitchFlyingLabel.TabIndex = 33;
            this.SnitchFlyingLabel.Text = "СНИТЧ ЛЕТАЕТ";
            this.SnitchFlyingLabel.Visible = false;
            // 
            // CorrectTime
            // 
            this.CorrectTime.Location = new System.Drawing.Point(1004, 528);
            this.CorrectTime.Name = "CorrectTime";
            this.CorrectTime.Size = new System.Drawing.Size(170, 23);
            this.CorrectTime.TabIndex = 34;
            this.CorrectTime.Text = "Исправить часы";
            this.CorrectTime.UseVisualStyleBackColor = true;
            this.CorrectTime.Click += new System.EventHandler(this.CorrectTime_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.Enabled = false;
            this.SaveDataButton.Location = new System.Drawing.Point(1004, 623);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(170, 23);
            this.SaveDataButton.TabIndex = 36;
            this.SaveDataButton.Text = "Сохранить и выйти";
            this.SaveDataButton.UseVisualStyleBackColor = true;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // OpenScoreFormButton
            // 
            this.OpenScoreFormButton.Location = new System.Drawing.Point(1004, 557);
            this.OpenScoreFormButton.Name = "OpenScoreFormButton";
            this.OpenScoreFormButton.Size = new System.Drawing.Size(170, 23);
            this.OpenScoreFormButton.TabIndex = 37;
            this.OpenScoreFormButton.Text = "Открыть форму";
            this.OpenScoreFormButton.UseVisualStyleBackColor = true;
            this.OpenScoreFormButton.Click += new System.EventHandler(this.OpenScoreFormButton_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 712);
            this.Controls.Add(this.OpenScoreFormButton);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.CorrectTime);
            this.Controls.Add(this.SnitchFlyingLabel);
            this.Controls.Add(this.DeleteLastButton);
            this.Controls.Add(this.TechStop);
            this.Controls.Add(this.BeginMatch);
            this.Controls.Add(this.MatchTimeLabel);
            this.Controls.Add(this.FirstPlayerLabel);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.EventTypeLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.VisitorsButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.EventTypeBox);
            this.Controls.Add(this.EventsGrid);
            this.Controls.Add(this.VisitorsGrid);
            this.Controls.Add(this.HomeGrid);
            this.Controls.Add(this.VisitorsLabel);
            this.Controls.Add(this.HomeLabel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            this.Load += new System.EventHandler(this.MatchForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MatchForm_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatchForm_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HomeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label VisitorsLabel;
        private System.Windows.Forms.DataGridView HomeGrid;
        private System.Windows.Forms.DataGridView VisitorsGrid;
        private System.Windows.Forms.DataGridView EventsGrid;
        private System.Windows.Forms.ListBox EventTypeBox;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button VisitorsButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label EventTypeLabel;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label FirstPlayerLabel;
        private System.Windows.Forms.Label MatchTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BeginMatch;
        private System.Windows.Forms.Button TechStop;
        private System.Windows.Forms.Button DeleteLastButton;
        private System.Windows.Forms.Label SnitchFlyingLabel;
        private System.Windows.Forms.Button CorrectTime;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button OpenScoreFormButton;
    }
}
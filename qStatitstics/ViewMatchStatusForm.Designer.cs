namespace QStatitstics
{
    partial class ViewMatchStatusForm
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
            VisitorsScoreLabel = new LabelWithFontScaling();
            HomeScoreLabel = new LabelWithFontScaling();
            StatusLabel = new LabelWithFontScaling();
            TimerLabel = new LabelWithFontScaling();
            SuspendLayout();
            // 
            // VisitorsScoreLabel
            // 
            VisitorsScoreLabel.BackColor = System.Drawing.SystemColors.Window;
            VisitorsScoreLabel.Font = new System.Drawing.Font("Verdana", 170.21904F, System.Drawing.FontStyle.Bold);
            VisitorsScoreLabel.Location = new System.Drawing.Point(0, 0);
            VisitorsScoreLabel.Name = "VisitorsScoreLabel";
            VisitorsScoreLabel.Size = new System.Drawing.Size(643, 338);
            VisitorsScoreLabel.TabIndex = 5;
            VisitorsScoreLabel.Text = "000";
            // 
            // HomeScoreLabel
            // 
            HomeScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            HomeScoreLabel.BackColor = System.Drawing.SystemColors.Window;
            HomeScoreLabel.Font = new System.Drawing.Font("Verdana", 167.243042F, System.Drawing.FontStyle.Bold);
            HomeScoreLabel.Location = new System.Drawing.Point(552, 0);
            HomeScoreLabel.Name = "HomeScoreLabel";
            HomeScoreLabel.Size = new System.Drawing.Size(627, 338);
            HomeScoreLabel.TabIndex = 6;
            HomeScoreLabel.Text = "000";
            HomeScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StatusLabel
            // 
            StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            StatusLabel.Font = new System.Drawing.Font("Verdana", 77.61314F, System.Drawing.FontStyle.Bold);
            StatusLabel.Location = new System.Drawing.Point(0, 626);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(1179, 159);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Матч не начался";
            // 
            // TimerLabel
            // 
            TimerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            TimerLabel.Font = new System.Drawing.Font("Verdana", 80.0734558F, System.Drawing.FontStyle.Bold);
            TimerLabel.Location = new System.Drawing.Point(0, 467);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new System.Drawing.Size(1179, 159);
            TimerLabel.TabIndex = 8;
            TimerLabel.Text = "00:00";
            TimerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewMatchStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(125F, 241F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1179, 785);
            Controls.Add(TimerLabel);
            Controls.Add(StatusLabel);
            Controls.Add(HomeScoreLabel);
            Controls.Add(VisitorsScoreLabel);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 159.75F, System.Drawing.FontStyle.Bold);
            Margin = new System.Windows.Forms.Padding(55, 60, 55, 60);
            Name = "ViewMatchStatusForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ShowScoreForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosed += ViewMatchStatusForm_FormClosed;
            Resize += ViewMatchStatusForm_Resize;
            ResumeLayout(false);
        }

        #endregion
        private LabelWithFontScaling VisitorsScoreLabel;
        private LabelWithFontScaling HomeScoreLabel;
        private LabelWithFontScaling StatusLabel;
        private LabelWithFontScaling TimerLabel;
    }
}
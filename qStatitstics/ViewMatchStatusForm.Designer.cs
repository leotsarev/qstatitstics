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
            this.VisitorsScoreLabel = new QStatitstics.LabelWithFontScaling();
            this.HomeScoreLabel = new QStatitstics.LabelWithFontScaling();
            this.StatusLabel = new QStatitstics.LabelWithFontScaling();
            this.SuspendLayout();
            // 
            // VisitorsScoreLabel
            // 
            this.VisitorsScoreLabel.BackColor = System.Drawing.SystemColors.Window;
            this.VisitorsScoreLabel.Font = new System.Drawing.Font("Verdana", 170.2191F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VisitorsScoreLabel.Location = new System.Drawing.Point(0, 0);
            this.VisitorsScoreLabel.Name = "VisitorsScoreLabel";
            this.VisitorsScoreLabel.Size = new System.Drawing.Size(643, 338);
            this.VisitorsScoreLabel.TabIndex = 5;
            this.VisitorsScoreLabel.Text = "000";
            // 
            // HomeScoreLabel
            // 
            this.HomeScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeScoreLabel.BackColor = System.Drawing.SystemColors.Window;
            this.HomeScoreLabel.Font = new System.Drawing.Font("Verdana", 167.243F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeScoreLabel.Location = new System.Drawing.Point(552, 0);
            this.HomeScoreLabel.Name = "HomeScoreLabel";
            this.HomeScoreLabel.Size = new System.Drawing.Size(627, 338);
            this.HomeScoreLabel.TabIndex = 6;
            this.HomeScoreLabel.Text = "000";
            this.HomeScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 77.61314F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(0, 626);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(1179, 159);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Матч не начался";
            // 
            // ViewMatchStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(125F, 241F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 785);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.HomeScoreLabel);
            this.Controls.Add(this.VisitorsScoreLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 159.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(55, 60, 55, 60);
            this.Name = "ViewMatchStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowScoreForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.ViewMatchStatusForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private LabelWithFontScaling VisitorsScoreLabel;
        private LabelWithFontScaling HomeScoreLabel;
        private LabelWithFontScaling StatusLabel;
    }
}
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
            this.HomeScoreLabel = new System.Windows.Forms.Label();
            this.VisitorsScoreLabel = new System.Windows.Forms.Label();
            this.HomeEventLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.VisitorsEventLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeScoreLabel
            // 
            this.HomeScoreLabel.AutoSize = true;
            this.HomeScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeScoreLabel.Location = new System.Drawing.Point(588, 9);
            this.HomeScoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HomeScoreLabel.Name = "HomeScoreLabel";
            this.HomeScoreLabel.Size = new System.Drawing.Size(664, 302);
            this.HomeScoreLabel.TabIndex = 0;
            this.HomeScoreLabel.Text = "XXX";
            this.HomeScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisitorsScoreLabel
            // 
            this.VisitorsScoreLabel.AutoSize = true;
            this.VisitorsScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitorsScoreLabel.Location = new System.Drawing.Point(9, 9);
            this.VisitorsScoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.VisitorsScoreLabel.Name = "VisitorsScoreLabel";
            this.VisitorsScoreLabel.Size = new System.Drawing.Size(664, 302);
            this.VisitorsScoreLabel.TabIndex = 1;
            this.VisitorsScoreLabel.Text = "XXX";
            this.VisitorsScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeEventLabel
            // 
            this.HomeEventLabel.AutoSize = true;
            this.HomeEventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeEventLabel.ForeColor = System.Drawing.Color.Red;
            this.HomeEventLabel.Location = new System.Drawing.Point(630, 338);
            this.HomeEventLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HomeEventLabel.Name = "HomeEventLabel";
            this.HomeEventLabel.Size = new System.Drawing.Size(540, 243);
            this.HomeEventLabel.TabIndex = 2;
            this.HomeEventLabel.Text = "√ŒÀ";
            this.HomeEventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeEventLabel.Visible = false;
            this.HomeEventLabel.Click += new System.EventHandler(this.HomeEventLabel_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(23, 641);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(1273, 181);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "99 ’’’’’’’’’";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Visible = false;
            // 
            // VisitorsEventLabel
            // 
            this.VisitorsEventLabel.AutoSize = true;
            this.VisitorsEventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitorsEventLabel.ForeColor = System.Drawing.Color.Red;
            this.VisitorsEventLabel.Location = new System.Drawing.Point(19, 338);
            this.VisitorsEventLabel.Margin = new System.Windows.Forms.Padding(0);
            this.VisitorsEventLabel.Name = "VisitorsEventLabel";
            this.VisitorsEventLabel.Size = new System.Drawing.Size(540, 243);
            this.VisitorsEventLabel.TabIndex = 3;
            this.VisitorsEventLabel.Text = "√ŒÀ";
            this.VisitorsEventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VisitorsEventLabel.Visible = false;
            // 
            // ViewMatchStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(125F, 241F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 785);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.VisitorsEventLabel);
            this.Controls.Add(this.HomeEventLabel);
            this.Controls.Add(this.VisitorsScoreLabel);
            this.Controls.Add(this.HomeScoreLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 159.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(55, 60, 55, 60);
            this.Name = "ViewMatchStatusForm";
            this.Text = "ShowScoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeScoreLabel;
        private System.Windows.Forms.Label VisitorsScoreLabel;
        private System.Windows.Forms.Label HomeEventLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label VisitorsEventLabel;
    }
}
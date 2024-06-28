namespace QStatitstics;

partial class CorrectTime
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
        this.OldTimeLabel = new System.Windows.Forms.Label();
        this.NewTimeTextBox = new System.Windows.Forms.MaskedTextBox();
        this.OldTimeTextBox = new System.Windows.Forms.MaskedTextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.OKButton = new System.Windows.Forms.Button();
        this.CancButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // OldTimeLabel
        // 
        this.OldTimeLabel.AutoSize = true;
        this.OldTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.OldTimeLabel.Location = new System.Drawing.Point(12, 12);
        this.OldTimeLabel.Name = "OldTimeLabel";
        this.OldTimeLabel.Size = new System.Drawing.Size(150, 13);
        this.OldTimeLabel.TabIndex = 0;
        this.OldTimeLabel.Text = "Старое значение часов:";
        // 
        // NewTimeTextBox
        // 
        this.NewTimeTextBox.Location = new System.Drawing.Point(168, 44);
        this.NewTimeTextBox.Mask = "0:00:00";
        this.NewTimeTextBox.Name = "NewTimeTextBox";
        this.NewTimeTextBox.Size = new System.Drawing.Size(56, 20);
        this.NewTimeTextBox.TabIndex = 1;
        // 
        // OldTimeTextBox
        // 
        this.OldTimeTextBox.Enabled = false;
        this.OldTimeTextBox.Location = new System.Drawing.Point(168, 9);
        this.OldTimeTextBox.Mask = "0:00:00";
        this.OldTimeTextBox.Name = "OldTimeTextBox";
        this.OldTimeTextBox.Size = new System.Drawing.Size(56, 20);
        this.OldTimeTextBox.TabIndex = 2;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(12, 47);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(145, 13);
        this.label1.TabIndex = 3;
        this.label1.Text = "Новое значение часов:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.ForeColor = System.Drawing.Color.Red;
        this.label2.Location = new System.Drawing.Point(12, 79);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(426, 13);
        this.label2.TabIndex = 4;
        this.label2.Text = "Внимание! Исправлять часы разрешается только по указанию судей!";
        // 
        // OKButton
        // 
        this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.OKButton.Location = new System.Drawing.Point(15, 96);
        this.OKButton.Name = "OKButton";
        this.OKButton.Size = new System.Drawing.Size(75, 23);
        this.OKButton.TabIndex = 5;
        this.OKButton.Text = "OK";
        this.OKButton.UseVisualStyleBackColor = true;
        this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
        // 
        // CancButton
        // 
        this.CancButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.CancButton.Location = new System.Drawing.Point(149, 96);
        this.CancButton.Name = "CancButton";
        this.CancButton.Size = new System.Drawing.Size(75, 23);
        this.CancButton.TabIndex = 6;
        this.CancButton.Text = "Отмена";
        this.CancButton.UseVisualStyleBackColor = true;
        // 
        // CorrectTime
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(440, 131);
        this.Controls.Add(this.CancButton);
        this.Controls.Add(this.OKButton);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.OldTimeTextBox);
        this.Controls.Add(this.NewTimeTextBox);
        this.Controls.Add(this.OldTimeLabel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "CorrectTime";
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Исправить часы";
        this.Load += new System.EventHandler(this.CorrectTime_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label OldTimeLabel;
    private System.Windows.Forms.MaskedTextBox NewTimeTextBox;
    private System.Windows.Forms.MaskedTextBox OldTimeTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Button CancButton;
}
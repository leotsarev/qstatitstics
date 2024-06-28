namespace QStatitstics;

partial class SetupRosterForm
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
        this.lbNotSet = new System.Windows.Forms.ListBox();
        this.lbChasers = new System.Windows.Forms.ListBox();
        this.lbBeaters = new System.Windows.Forms.ListBox();
        this.lbKeepers = new System.Windows.Forms.ListBox();
        this.lbSeekers = new System.Windows.Forms.ListBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.OkButton = new System.Windows.Forms.Button();
        this.btnAddChaser = new System.Windows.Forms.Button();
        this.btnRemoveChaser = new System.Windows.Forms.Button();
        this.btnRemoveBeater = new System.Windows.Forms.Button();
        this.btnAddBeater = new System.Windows.Forms.Button();
        this.btnRemoveKeeper = new System.Windows.Forms.Button();
        this.btnAddKeeper = new System.Windows.Forms.Button();
        this.btnRemoveSeeker = new System.Windows.Forms.Button();
        this.btnAddSeeker = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // lbNotSet
        // 
        this.lbNotSet.FormattingEnabled = true;
        this.lbNotSet.Location = new System.Drawing.Point(12, 25);
        this.lbNotSet.Name = "lbNotSet";
        this.lbNotSet.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lbNotSet.Size = new System.Drawing.Size(141, 472);
        this.lbNotSet.TabIndex = 0;
        // 
        // lbChasers
        // 
        this.lbChasers.FormattingEnabled = true;
        this.lbChasers.Location = new System.Drawing.Point(207, 25);
        this.lbChasers.Name = "lbChasers";
        this.lbChasers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lbChasers.Size = new System.Drawing.Size(141, 121);
        this.lbChasers.TabIndex = 1;
        this.lbChasers.DoubleClick += new System.EventHandler(this.lbChasers_DoubleClick);
        // 
        // lbBeaters
        // 
        this.lbBeaters.FormattingEnabled = true;
        this.lbBeaters.Location = new System.Drawing.Point(207, 165);
        this.lbBeaters.Name = "lbBeaters";
        this.lbBeaters.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lbBeaters.Size = new System.Drawing.Size(141, 121);
        this.lbBeaters.TabIndex = 2;
        // 
        // lbKeepers
        // 
        this.lbKeepers.FormattingEnabled = true;
        this.lbKeepers.Location = new System.Drawing.Point(207, 305);
        this.lbKeepers.Name = "lbKeepers";
        this.lbKeepers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lbKeepers.Size = new System.Drawing.Size(141, 82);
        this.lbKeepers.TabIndex = 3;
        this.lbKeepers.DoubleClick += new System.EventHandler(this.lbKeepers_DoubleClick);
        // 
        // lbSeekers
        // 
        this.lbSeekers.FormattingEnabled = true;
        this.lbSeekers.Location = new System.Drawing.Point(207, 406);
        this.lbSeekers.Name = "lbSeekers";
        this.lbSeekers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lbSeekers.Size = new System.Drawing.Size(141, 95);
        this.lbSeekers.TabIndex = 4;
        this.lbSeekers.DoubleClick += new System.EventHandler(this.lbSeekers_DoubleClick);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(207, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(55, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Охотники";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(207, 149);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(64, 13);
        this.label2.TabIndex = 6;
        this.label2.Text = "Загонщики";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(207, 289);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(49, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Вратари";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(204, 390);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(41, 13);
        this.label4.TabIndex = 8;
        this.label4.Text = "Ловцы";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(12, 9);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(64, 13);
        this.label5.TabIndex = 9;
        this.label5.Text = "Все игроки";
        // 
        // OkButton
        // 
        this.OkButton.Location = new System.Drawing.Point(354, 25);
        this.OkButton.Name = "OkButton";
        this.OkButton.Size = new System.Drawing.Size(75, 23);
        this.OkButton.TabIndex = 10;
        this.OkButton.Text = "ОК";
        this.OkButton.UseVisualStyleBackColor = true;
        this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
        // 
        // btnAddChaser
        // 
        this.btnAddChaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnAddChaser.Location = new System.Drawing.Point(159, 35);
        this.btnAddChaser.Name = "btnAddChaser";
        this.btnAddChaser.Size = new System.Drawing.Size(24, 23);
        this.btnAddChaser.TabIndex = 11;
        this.btnAddChaser.Text = ">";
        this.btnAddChaser.UseVisualStyleBackColor = true;
        this.btnAddChaser.Click += new System.EventHandler(this.btnAddChaser_Click);
        // 
        // btnRemoveChaser
        // 
        this.btnRemoveChaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnRemoveChaser.Location = new System.Drawing.Point(159, 64);
        this.btnRemoveChaser.Name = "btnRemoveChaser";
        this.btnRemoveChaser.Size = new System.Drawing.Size(24, 23);
        this.btnRemoveChaser.TabIndex = 12;
        this.btnRemoveChaser.Text = "<";
        this.btnRemoveChaser.UseVisualStyleBackColor = true;
        this.btnRemoveChaser.Click += new System.EventHandler(this.btnRemoveChaser_Click);
        // 
        // btnRemoveBeater
        // 
        this.btnRemoveBeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnRemoveBeater.Location = new System.Drawing.Point(159, 227);
        this.btnRemoveBeater.Name = "btnRemoveBeater";
        this.btnRemoveBeater.Size = new System.Drawing.Size(24, 23);
        this.btnRemoveBeater.TabIndex = 14;
        this.btnRemoveBeater.Text = "<";
        this.btnRemoveBeater.UseVisualStyleBackColor = true;
        this.btnRemoveBeater.Click += new System.EventHandler(this.btnRemoveBeater_Click);
        // 
        // btnAddBeater
        // 
        this.btnAddBeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnAddBeater.Location = new System.Drawing.Point(159, 198);
        this.btnAddBeater.Name = "btnAddBeater";
        this.btnAddBeater.Size = new System.Drawing.Size(24, 23);
        this.btnAddBeater.TabIndex = 13;
        this.btnAddBeater.Text = ">";
        this.btnAddBeater.UseVisualStyleBackColor = true;
        this.btnAddBeater.Click += new System.EventHandler(this.btnAddBeater_Click);
        // 
        // btnRemoveKeeper
        // 
        this.btnRemoveKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnRemoveKeeper.Location = new System.Drawing.Point(159, 345);
        this.btnRemoveKeeper.Name = "btnRemoveKeeper";
        this.btnRemoveKeeper.Size = new System.Drawing.Size(24, 23);
        this.btnRemoveKeeper.TabIndex = 16;
        this.btnRemoveKeeper.Text = "<";
        this.btnRemoveKeeper.UseVisualStyleBackColor = true;
        this.btnRemoveKeeper.Click += new System.EventHandler(this.btnRemoveKeeper_Click);
        // 
        // btnAddKeeper
        // 
        this.btnAddKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnAddKeeper.Location = new System.Drawing.Point(159, 316);
        this.btnAddKeeper.Name = "btnAddKeeper";
        this.btnAddKeeper.Size = new System.Drawing.Size(24, 23);
        this.btnAddKeeper.TabIndex = 15;
        this.btnAddKeeper.Text = ">";
        this.btnAddKeeper.UseVisualStyleBackColor = true;
        this.btnAddKeeper.Click += new System.EventHandler(this.btnAddKeeper_Click);
        // 
        // btnRemoveSeeker
        // 
        this.btnRemoveSeeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnRemoveSeeker.Location = new System.Drawing.Point(159, 461);
        this.btnRemoveSeeker.Name = "btnRemoveSeeker";
        this.btnRemoveSeeker.Size = new System.Drawing.Size(24, 23);
        this.btnRemoveSeeker.TabIndex = 18;
        this.btnRemoveSeeker.Text = "<";
        this.btnRemoveSeeker.UseVisualStyleBackColor = true;
        this.btnRemoveSeeker.Click += new System.EventHandler(this.btnRemoveSeeker_Click);
        // 
        // btnAddSeeker
        // 
        this.btnAddSeeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btnAddSeeker.Location = new System.Drawing.Point(159, 432);
        this.btnAddSeeker.Name = "btnAddSeeker";
        this.btnAddSeeker.Size = new System.Drawing.Size(24, 23);
        this.btnAddSeeker.TabIndex = 17;
        this.btnAddSeeker.Text = ">";
        this.btnAddSeeker.UseVisualStyleBackColor = true;
        this.btnAddSeeker.Click += new System.EventHandler(this.btnAddSeeker_Click);
        // 
        // SetupRosterForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(437, 510);
        this.Controls.Add(this.btnRemoveSeeker);
        this.Controls.Add(this.btnAddSeeker);
        this.Controls.Add(this.btnRemoveKeeper);
        this.Controls.Add(this.btnAddKeeper);
        this.Controls.Add(this.btnRemoveBeater);
        this.Controls.Add(this.btnAddBeater);
        this.Controls.Add(this.btnRemoveChaser);
        this.Controls.Add(this.btnAddChaser);
        this.Controls.Add(this.OkButton);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.lbSeekers);
        this.Controls.Add(this.lbKeepers);
        this.Controls.Add(this.lbBeaters);
        this.Controls.Add(this.lbChasers);
        this.Controls.Add(this.lbNotSet);
        this.Name = "SetupRosterForm";
        this.Text = "SetupRosterForm";
        this.Load += new System.EventHandler(this.SetupRosterForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbNotSet;
    private System.Windows.Forms.ListBox lbChasers;
    private System.Windows.Forms.ListBox lbBeaters;
    private System.Windows.Forms.ListBox lbKeepers;
    private System.Windows.Forms.ListBox lbSeekers;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button OkButton;
    private System.Windows.Forms.Button btnAddChaser;
    private System.Windows.Forms.Button btnRemoveChaser;
    private System.Windows.Forms.Button btnRemoveBeater;
    private System.Windows.Forms.Button btnAddBeater;
    private System.Windows.Forms.Button btnRemoveKeeper;
    private System.Windows.Forms.Button btnAddKeeper;
    private System.Windows.Forms.Button btnRemoveSeeker;
    private System.Windows.Forms.Button btnAddSeeker;
}
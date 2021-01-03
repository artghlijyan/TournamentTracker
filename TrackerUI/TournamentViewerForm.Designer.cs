
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.lb_Header = new System.Windows.Forms.Label();
            this.lb_TournamentName = new System.Windows.Forms.Label();
            this.lb_Round = new System.Windows.Forms.Label();
            this.dd_Round = new System.Windows.Forms.ComboBox();
            this.checkb_UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listB_Matchup = new System.Windows.Forms.ListBox();
            this.lb_TeamOne = new System.Windows.Forms.Label();
            this.lb_TeamOneScore = new System.Windows.Forms.Label();
            this.textB_TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.textB_TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.lb_TeamTwoScore = new System.Windows.Forms.Label();
            this.lb_TeamTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Header.CausesValidation = false;
            this.lb_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Header.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Header.ForeColor = System.Drawing.Color.Orange;
            this.lb_Header.Location = new System.Drawing.Point(164, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(191, 30);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Tournament:";
            this.lb_Header.Click += new System.EventHandler(this.lb_Header_Click);
            // 
            // lb_TournamentName
            // 
            this.lb_TournamentName.AutoSize = true;
            this.lb_TournamentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_TournamentName.CausesValidation = false;
            this.lb_TournamentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_TournamentName.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lb_TournamentName.ForeColor = System.Drawing.Color.Orange;
            this.lb_TournamentName.Location = new System.Drawing.Point(354, 9);
            this.lb_TournamentName.Name = "lb_TournamentName";
            this.lb_TournamentName.Size = new System.Drawing.Size(107, 30);
            this.lb_TournamentName.TabIndex = 1;
            this.lb_TournamentName.Text = "<none>";
            this.lb_TournamentName.Click += new System.EventHandler(this.lb_TournamentName_Click);
            // 
            // lb_Round
            // 
            this.lb_Round.AutoSize = true;
            this.lb_Round.CausesValidation = false;
            this.lb_Round.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lb_Round.ForeColor = System.Drawing.Color.Orange;
            this.lb_Round.Location = new System.Drawing.Point(33, 61);
            this.lb_Round.Name = "lb_Round";
            this.lb_Round.Size = new System.Drawing.Size(85, 32);
            this.lb_Round.TabIndex = 2;
            this.lb_Round.Text = "Round:";
            // 
            // dd_Round
            // 
            this.dd_Round.BackColor = System.Drawing.Color.DimGray;
            this.dd_Round.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd_Round.ForeColor = System.Drawing.Color.Black;
            this.dd_Round.FormattingEnabled = true;
            this.dd_Round.Location = new System.Drawing.Point(135, 72);
            this.dd_Round.Name = "dd_Round";
            this.dd_Round.Size = new System.Drawing.Size(180, 21);
            this.dd_Round.TabIndex = 3;
            // 
            // checkb_UnplayedOnly
            // 
            this.checkb_UnplayedOnly.AutoSize = true;
            this.checkb_UnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkb_UnplayedOnly.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.checkb_UnplayedOnly.ForeColor = System.Drawing.Color.Orange;
            this.checkb_UnplayedOnly.Location = new System.Drawing.Point(144, 99);
            this.checkb_UnplayedOnly.Name = "checkb_UnplayedOnly";
            this.checkb_UnplayedOnly.Size = new System.Drawing.Size(117, 24);
            this.checkb_UnplayedOnly.TabIndex = 4;
            this.checkb_UnplayedOnly.Text = "Unplayed Only";
            this.checkb_UnplayedOnly.UseVisualStyleBackColor = true;
            this.checkb_UnplayedOnly.CheckedChanged += new System.EventHandler(this.checkb_UnplayedOnly_CheckedChanged);
            // 
            // listB_Matchup
            // 
            this.listB_Matchup.BackColor = System.Drawing.Color.DimGray;
            this.listB_Matchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listB_Matchup.FormattingEnabled = true;
            this.listB_Matchup.Location = new System.Drawing.Point(20, 129);
            this.listB_Matchup.Name = "listB_Matchup";
            this.listB_Matchup.Size = new System.Drawing.Size(295, 158);
            this.listB_Matchup.TabIndex = 5;
            // 
            // lb_TeamOne
            // 
            this.lb_TeamOne.AutoSize = true;
            this.lb_TeamOne.CausesValidation = false;
            this.lb_TeamOne.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lb_TeamOne.ForeColor = System.Drawing.Color.Orange;
            this.lb_TeamOne.Location = new System.Drawing.Point(321, 139);
            this.lb_TeamOne.Name = "lb_TeamOne";
            this.lb_TeamOne.Size = new System.Drawing.Size(143, 32);
            this.lb_TeamOne.TabIndex = 6;
            this.lb_TeamOne.Text = "<team one>";
            // 
            // lb_TeamOneScore
            // 
            this.lb_TeamOneScore.AutoSize = true;
            this.lb_TeamOneScore.CausesValidation = false;
            this.lb_TeamOneScore.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lb_TeamOneScore.ForeColor = System.Drawing.Color.Orange;
            this.lb_TeamOneScore.Location = new System.Drawing.Point(466, 129);
            this.lb_TeamOneScore.Name = "lb_TeamOneScore";
            this.lb_TeamOneScore.Size = new System.Drawing.Size(42, 19);
            this.lb_TeamOneScore.TabIndex = 7;
            this.lb_TeamOneScore.Text = "Score";
            // 
            // textB_TeamOneScoreValue
            // 
            this.textB_TeamOneScoreValue.BackColor = System.Drawing.Color.DimGray;
            this.textB_TeamOneScoreValue.Location = new System.Drawing.Point(470, 151);
            this.textB_TeamOneScoreValue.Name = "textB_TeamOneScoreValue";
            this.textB_TeamOneScoreValue.Size = new System.Drawing.Size(100, 22);
            this.textB_TeamOneScoreValue.TabIndex = 8;
            // 
            // textB_TeamTwoScoreValue
            // 
            this.textB_TeamTwoScoreValue.BackColor = System.Drawing.Color.DimGray;
            this.textB_TeamTwoScoreValue.Location = new System.Drawing.Point(470, 219);
            this.textB_TeamTwoScoreValue.Name = "textB_TeamTwoScoreValue";
            this.textB_TeamTwoScoreValue.Size = new System.Drawing.Size(100, 22);
            this.textB_TeamTwoScoreValue.TabIndex = 11;
            // 
            // lb_TeamTwoScore
            // 
            this.lb_TeamTwoScore.AutoSize = true;
            this.lb_TeamTwoScore.CausesValidation = false;
            this.lb_TeamTwoScore.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lb_TeamTwoScore.ForeColor = System.Drawing.Color.Orange;
            this.lb_TeamTwoScore.Location = new System.Drawing.Point(466, 197);
            this.lb_TeamTwoScore.Name = "lb_TeamTwoScore";
            this.lb_TeamTwoScore.Size = new System.Drawing.Size(42, 19);
            this.lb_TeamTwoScore.TabIndex = 10;
            this.lb_TeamTwoScore.Text = "Score";
            // 
            // lb_TeamTwo
            // 
            this.lb_TeamTwo.AutoSize = true;
            this.lb_TeamTwo.CausesValidation = false;
            this.lb_TeamTwo.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lb_TeamTwo.ForeColor = System.Drawing.Color.Orange;
            this.lb_TeamTwo.Location = new System.Drawing.Point(323, 207);
            this.lb_TeamTwo.Name = "lb_TeamTwo";
            this.lb_TeamTwo.Size = new System.Drawing.Size(141, 32);
            this.lb_TeamTwo.TabIndex = 9;
            this.lb_TeamTwo.Text = "<team two>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(367, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "-VS-";
            // 
            // btn_Score
            // 
            this.btn_Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Score.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_Score.Location = new System.Drawing.Point(470, 257);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(100, 30);
            this.btn_Score.TabIndex = 13;
            this.btn_Score.Text = "Score";
            this.btn_Score.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(589, 305);
            this.Controls.Add(this.btn_Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_TeamTwoScoreValue);
            this.Controls.Add(this.lb_TeamTwoScore);
            this.Controls.Add(this.lb_TeamTwo);
            this.Controls.Add(this.textB_TeamOneScoreValue);
            this.Controls.Add(this.lb_TeamOneScore);
            this.Controls.Add(this.lb_TeamOne);
            this.Controls.Add(this.listB_Matchup);
            this.Controls.Add(this.checkb_UnplayedOnly);
            this.Controls.Add(this.dd_Round);
            this.Controls.Add(this.lb_Round);
            this.Controls.Add(this.lb_TournamentName);
            this.Controls.Add(this.lb_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.Label lb_TournamentName;
        private System.Windows.Forms.Label lb_Round;
        private System.Windows.Forms.ComboBox dd_Round;
        private System.Windows.Forms.CheckBox checkb_UnplayedOnly;
        private System.Windows.Forms.ListBox listB_Matchup;
        private System.Windows.Forms.Label lb_TeamOne;
        private System.Windows.Forms.Label lb_TeamOneScore;
        private System.Windows.Forms.TextBox textB_TeamOneScoreValue;
        private System.Windows.Forms.TextBox textB_TeamTwoScoreValue;
        private System.Windows.Forms.Label lb_TeamTwoScore;
        private System.Windows.Forms.Label lb_TeamTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Score;
    }
}


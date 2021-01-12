
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.lb_EntryFee = new System.Windows.Forms.Label();
            this.textB_TournamentNameValue = new System.Windows.Forms.TextBox();
            this.textB_EntryFeeValue = new System.Windows.Forms.TextBox();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.lb_SelectTeam = new System.Windows.Forms.Label();
            this.dd_SelectTeam = new System.Windows.Forms.ComboBox();
            this.link_CreateNew = new System.Windows.Forms.LinkLabel();
            this.btn_CratePrize = new System.Windows.Forms.Button();
            this.listB_TournamentPlayers = new System.Windows.Forms.ListBox();
            this.lbl_TeamPlayers = new System.Windows.Forms.Label();
            this.listB_Prizes = new System.Windows.Forms.ListBox();
            this.btn_DeleteSelectedPlayers = new System.Windows.Forms.Button();
            this.lbl_Prizes = new System.Windows.Forms.Label();
            this.btn_DeleteSelectedPrize = new System.Windows.Forms.Button();
            this.btn_CreateTournament = new System.Windows.Forms.Button();
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
            this.lb_Header.Location = new System.Drawing.Point(26, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(294, 30);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Create Tournament";
            // 
            // lb_TournamentName
            // 
            this.lb_TournamentName.AutoSize = true;
            this.lb_TournamentName.CausesValidation = false;
            this.lb_TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lb_TournamentName.ForeColor = System.Drawing.Color.Orange;
            this.lb_TournamentName.Location = new System.Drawing.Point(12, 67);
            this.lb_TournamentName.Name = "lb_TournamentName";
            this.lb_TournamentName.Size = new System.Drawing.Size(202, 32);
            this.lb_TournamentName.TabIndex = 6;
            this.lb_TournamentName.Text = "Tournament Name";
            // 
            // lb_EntryFee
            // 
            this.lb_EntryFee.AutoSize = true;
            this.lb_EntryFee.CausesValidation = false;
            this.lb_EntryFee.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lb_EntryFee.ForeColor = System.Drawing.Color.Orange;
            this.lb_EntryFee.Location = new System.Drawing.Point(36, 143);
            this.lb_EntryFee.Name = "lb_EntryFee";
            this.lb_EntryFee.Size = new System.Drawing.Size(72, 21);
            this.lb_EntryFee.TabIndex = 7;
            this.lb_EntryFee.Text = "Entry Fee";
            // 
            // textB_TournamentNameValue
            // 
            this.textB_TournamentNameValue.BackColor = System.Drawing.Color.DimGray;
            this.textB_TournamentNameValue.Location = new System.Drawing.Point(40, 102);
            this.textB_TournamentNameValue.Name = "textB_TournamentNameValue";
            this.textB_TournamentNameValue.Size = new System.Drawing.Size(289, 22);
            this.textB_TournamentNameValue.TabIndex = 8;
            // 
            // textB_EntryFeeValue
            // 
            this.textB_EntryFeeValue.BackColor = System.Drawing.Color.DimGray;
            this.textB_EntryFeeValue.Location = new System.Drawing.Point(129, 143);
            this.textB_EntryFeeValue.Name = "textB_EntryFeeValue";
            this.textB_EntryFeeValue.Size = new System.Drawing.Size(100, 22);
            this.textB_EntryFeeValue.TabIndex = 11;
            this.textB_EntryFeeValue.Text = "0";
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_AddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_AddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_AddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTeam.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_AddTeam.Location = new System.Drawing.Point(40, 219);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(100, 30);
            this.btn_AddTeam.TabIndex = 13;
            this.btn_AddTeam.Text = "Add team";
            this.btn_AddTeam.UseVisualStyleBackColor = false;
            // 
            // lb_SelectTeam
            // 
            this.lb_SelectTeam.AutoSize = true;
            this.lb_SelectTeam.CausesValidation = false;
            this.lb_SelectTeam.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lb_SelectTeam.ForeColor = System.Drawing.Color.Orange;
            this.lb_SelectTeam.Location = new System.Drawing.Point(36, 182);
            this.lb_SelectTeam.Name = "lb_SelectTeam";
            this.lb_SelectTeam.Size = new System.Drawing.Size(87, 21);
            this.lb_SelectTeam.TabIndex = 14;
            this.lb_SelectTeam.Text = "Select Team";
            // 
            // dd_SelectTeam
            // 
            this.dd_SelectTeam.BackColor = System.Drawing.Color.DimGray;
            this.dd_SelectTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd_SelectTeam.ForeColor = System.Drawing.Color.Black;
            this.dd_SelectTeam.FormattingEnabled = true;
            this.dd_SelectTeam.Location = new System.Drawing.Point(129, 182);
            this.dd_SelectTeam.Name = "dd_SelectTeam";
            this.dd_SelectTeam.Size = new System.Drawing.Size(200, 21);
            this.dd_SelectTeam.TabIndex = 15;
            // 
            // link_CreateNew
            // 
            this.link_CreateNew.AutoSize = true;
            this.link_CreateNew.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.link_CreateNew.LinkColor = System.Drawing.Color.Orange;
            this.link_CreateNew.Location = new System.Drawing.Point(251, 160);
            this.link_CreateNew.Name = "link_CreateNew";
            this.link_CreateNew.Size = new System.Drawing.Size(78, 19);
            this.link_CreateNew.TabIndex = 16;
            this.link_CreateNew.TabStop = true;
            this.link_CreateNew.Text = "Create new";
            // 
            // btn_CratePrize
            // 
            this.btn_CratePrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CratePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CratePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CratePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CratePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CratePrize.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_CratePrize.Location = new System.Drawing.Point(202, 219);
            this.btn_CratePrize.Name = "btn_CratePrize";
            this.btn_CratePrize.Size = new System.Drawing.Size(127, 30);
            this.btn_CratePrize.TabIndex = 17;
            this.btn_CratePrize.Text = "Create Prize";
            this.btn_CratePrize.UseVisualStyleBackColor = false;
            // 
            // listB_TournamentPlayers
            // 
            this.listB_TournamentPlayers.BackColor = System.Drawing.Color.DimGray;
            this.listB_TournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listB_TournamentPlayers.FormattingEnabled = true;
            this.listB_TournamentPlayers.Location = new System.Drawing.Point(380, 102);
            this.listB_TournamentPlayers.Name = "listB_TournamentPlayers";
            this.listB_TournamentPlayers.Size = new System.Drawing.Size(163, 106);
            this.listB_TournamentPlayers.TabIndex = 18;
            // 
            // lbl_TeamPlayers
            // 
            this.lbl_TeamPlayers.AutoSize = true;
            this.lbl_TeamPlayers.CausesValidation = false;
            this.lbl_TeamPlayers.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_TeamPlayers.ForeColor = System.Drawing.Color.Orange;
            this.lbl_TeamPlayers.Location = new System.Drawing.Point(383, 67);
            this.lbl_TeamPlayers.Name = "lbl_TeamPlayers";
            this.lbl_TeamPlayers.Size = new System.Drawing.Size(160, 32);
            this.lbl_TeamPlayers.TabIndex = 19;
            this.lbl_TeamPlayers.Text = "Team / Players";
            // 
            // listB_Prizes
            // 
            this.listB_Prizes.BackColor = System.Drawing.Color.DimGray;
            this.listB_Prizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listB_Prizes.FormattingEnabled = true;
            this.listB_Prizes.Location = new System.Drawing.Point(568, 102);
            this.listB_Prizes.Name = "listB_Prizes";
            this.listB_Prizes.Size = new System.Drawing.Size(163, 106);
            this.listB_Prizes.TabIndex = 21;
            // 
            // btn_DeleteSelectedPlayers
            // 
            this.btn_DeleteSelectedPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeleteSelectedPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_DeleteSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_DeleteSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSelectedPlayers.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_DeleteSelectedPlayers.Location = new System.Drawing.Point(411, 219);
            this.btn_DeleteSelectedPlayers.Name = "btn_DeleteSelectedPlayers";
            this.btn_DeleteSelectedPlayers.Size = new System.Drawing.Size(100, 30);
            this.btn_DeleteSelectedPlayers.TabIndex = 20;
            this.btn_DeleteSelectedPlayers.Text = "Delete";
            this.btn_DeleteSelectedPlayers.UseVisualStyleBackColor = false;
            // 
            // lbl_Prizes
            // 
            this.lbl_Prizes.AutoSize = true;
            this.lbl_Prizes.CausesValidation = false;
            this.lbl_Prizes.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_Prizes.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Prizes.Location = new System.Drawing.Point(571, 67);
            this.lbl_Prizes.Name = "lbl_Prizes";
            this.lbl_Prizes.Size = new System.Drawing.Size(160, 32);
            this.lbl_Prizes.TabIndex = 22;
            this.lbl_Prizes.Text = "Team / Players";
            // 
            // btn_DeleteSelectedPrize
            // 
            this.btn_DeleteSelectedPrize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_DeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_DeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSelectedPrize.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_DeleteSelectedPrize.Location = new System.Drawing.Point(568, 219);
            this.btn_DeleteSelectedPrize.Name = "btn_DeleteSelectedPrize";
            this.btn_DeleteSelectedPrize.Size = new System.Drawing.Size(163, 30);
            this.btn_DeleteSelectedPrize.TabIndex = 23;
            this.btn_DeleteSelectedPrize.Text = "Delete Selected";
            this.btn_DeleteSelectedPrize.UseVisualStyleBackColor = false;
            // 
            // btn_CreateTournament
            // 
            this.btn_CreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTournament.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_CreateTournament.Location = new System.Drawing.Point(307, 275);
            this.btn_CreateTournament.Name = "btn_CreateTournament";
            this.btn_CreateTournament.Size = new System.Drawing.Size(204, 30);
            this.btn_CreateTournament.TabIndex = 24;
            this.btn_CreateTournament.Text = "Create Tournament";
            this.btn_CreateTournament.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(769, 338);
            this.Controls.Add(this.btn_CreateTournament);
            this.Controls.Add(this.btn_DeleteSelectedPrize);
            this.Controls.Add(this.lbl_Prizes);
            this.Controls.Add(this.listB_Prizes);
            this.Controls.Add(this.btn_DeleteSelectedPlayers);
            this.Controls.Add(this.lbl_TeamPlayers);
            this.Controls.Add(this.listB_TournamentPlayers);
            this.Controls.Add(this.btn_CratePrize);
            this.Controls.Add(this.link_CreateNew);
            this.Controls.Add(this.dd_SelectTeam);
            this.Controls.Add(this.lb_SelectTeam);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.textB_EntryFeeValue);
            this.Controls.Add(this.textB_TournamentNameValue);
            this.Controls.Add(this.lb_EntryFee);
            this.Controls.Add(this.lb_TournamentName);
            this.Controls.Add(this.lb_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.Label lb_TournamentName;
        private System.Windows.Forms.Label lb_EntryFee;
        private System.Windows.Forms.TextBox textB_TournamentNameValue;
        private System.Windows.Forms.TextBox textB_EntryFeeValue;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Label lb_SelectTeam;
        private System.Windows.Forms.ComboBox dd_SelectTeam;
        private System.Windows.Forms.LinkLabel link_CreateNew;
        private System.Windows.Forms.Button btn_CratePrize;
        private System.Windows.Forms.ListBox listB_TournamentPlayers;
        private System.Windows.Forms.Label lbl_TeamPlayers;
        private System.Windows.Forms.ListBox listB_Prizes;
        private System.Windows.Forms.Button btn_DeleteSelectedPlayers;
        private System.Windows.Forms.Label lbl_Prizes;
        private System.Windows.Forms.Button btn_DeleteSelectedPrize;
        private System.Windows.Forms.Button btn_CreateTournament;
    }
}


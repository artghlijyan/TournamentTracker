
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.textB_TeamNameValue = new System.Windows.Forms.TextBox();
            this.lb_TeamName = new System.Windows.Forms.Label();
            this.dd_SelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lb_SelectTeamMember = new System.Windows.Forms.Label();
            this.btn_AddTeamMember = new System.Windows.Forms.Button();
            this.groupB_AddNewMember = new System.Windows.Forms.GroupBox();
            this.textB_FirstNameValue = new System.Windows.Forms.TextBox();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_Cellphone = new System.Windows.Forms.Label();
            this.btn_CreateMember = new System.Windows.Forms.Button();
            this.listB_TeamMembers = new System.Windows.Forms.ListBox();
            this.btn_DeleteSelectedMember = new System.Windows.Forms.Button();
            this.btn_CreateTournament = new System.Windows.Forms.Button();
            this.groupB_AddNewMember.SuspendLayout();
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
            this.lb_Header.Location = new System.Drawing.Point(344, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(196, 30);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Create Team";
            this.lb_Header.Click += new System.EventHandler(this.lb_Header_Click);
            // 
            // textB_TeamNameValue
            // 
            this.textB_TeamNameValue.BackColor = System.Drawing.Color.DimGray;
            this.textB_TeamNameValue.Location = new System.Drawing.Point(57, 101);
            this.textB_TeamNameValue.Name = "textB_TeamNameValue";
            this.textB_TeamNameValue.Size = new System.Drawing.Size(289, 22);
            this.textB_TeamNameValue.TabIndex = 10;
            // 
            // lb_TeamName
            // 
            this.lb_TeamName.AutoSize = true;
            this.lb_TeamName.CausesValidation = false;
            this.lb_TeamName.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lb_TeamName.ForeColor = System.Drawing.Color.Orange;
            this.lb_TeamName.Location = new System.Drawing.Point(29, 66);
            this.lb_TeamName.Name = "lb_TeamName";
            this.lb_TeamName.Size = new System.Drawing.Size(135, 32);
            this.lb_TeamName.TabIndex = 9;
            this.lb_TeamName.Text = "Team Name";
            // 
            // dd_SelectTeamMember
            // 
            this.dd_SelectTeamMember.BackColor = System.Drawing.Color.DimGray;
            this.dd_SelectTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd_SelectTeamMember.ForeColor = System.Drawing.Color.Black;
            this.dd_SelectTeamMember.FormattingEnabled = true;
            this.dd_SelectTeamMember.Location = new System.Drawing.Point(206, 140);
            this.dd_SelectTeamMember.Name = "dd_SelectTeamMember";
            this.dd_SelectTeamMember.Size = new System.Drawing.Size(140, 21);
            this.dd_SelectTeamMember.TabIndex = 18;
            // 
            // lb_SelectTeamMember
            // 
            this.lb_SelectTeamMember.AutoSize = true;
            this.lb_SelectTeamMember.CausesValidation = false;
            this.lb_SelectTeamMember.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lb_SelectTeamMember.ForeColor = System.Drawing.Color.Orange;
            this.lb_SelectTeamMember.Location = new System.Drawing.Point(53, 137);
            this.lb_SelectTeamMember.Name = "lb_SelectTeamMember";
            this.lb_SelectTeamMember.Size = new System.Drawing.Size(147, 21);
            this.lb_SelectTeamMember.TabIndex = 17;
            this.lb_SelectTeamMember.Text = "Select Team Member";
            // 
            // btn_AddTeamMember
            // 
            this.btn_AddTeamMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_AddTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_AddTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_AddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTeamMember.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_AddTeamMember.Location = new System.Drawing.Point(227, 180);
            this.btn_AddTeamMember.Name = "btn_AddTeamMember";
            this.btn_AddTeamMember.Size = new System.Drawing.Size(119, 30);
            this.btn_AddTeamMember.TabIndex = 16;
            this.btn_AddTeamMember.Text = "Add Member";
            this.btn_AddTeamMember.UseVisualStyleBackColor = false;
            // 
            // groupB_AddNewMember
            // 
            this.groupB_AddNewMember.Controls.Add(this.btn_CreateMember);
            this.groupB_AddNewMember.Controls.Add(this.textBox3);
            this.groupB_AddNewMember.Controls.Add(this.lbl_Cellphone);
            this.groupB_AddNewMember.Controls.Add(this.textBox2);
            this.groupB_AddNewMember.Controls.Add(this.lbl_Email);
            this.groupB_AddNewMember.Controls.Add(this.textBox1);
            this.groupB_AddNewMember.Controls.Add(this.lbl_LastName);
            this.groupB_AddNewMember.Controls.Add(this.textB_FirstNameValue);
            this.groupB_AddNewMember.Controls.Add(this.lb_FirstName);
            this.groupB_AddNewMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupB_AddNewMember.ForeColor = System.Drawing.Color.Orange;
            this.groupB_AddNewMember.Location = new System.Drawing.Point(57, 228);
            this.groupB_AddNewMember.Name = "groupB_AddNewMember";
            this.groupB_AddNewMember.Size = new System.Drawing.Size(289, 198);
            this.groupB_AddNewMember.TabIndex = 19;
            this.groupB_AddNewMember.TabStop = false;
            this.groupB_AddNewMember.Text = "Add New Member";
            // 
            // textB_FirstNameValue
            // 
            this.textB_FirstNameValue.BackColor = System.Drawing.Color.DimGray;
            this.textB_FirstNameValue.Location = new System.Drawing.Point(92, 39);
            this.textB_FirstNameValue.Name = "textB_FirstNameValue";
            this.textB_FirstNameValue.Size = new System.Drawing.Size(191, 29);
            this.textB_FirstNameValue.TabIndex = 13;
            this.textB_FirstNameValue.Text = "<none>";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.CausesValidation = false;
            this.lb_FirstName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lb_FirstName.ForeColor = System.Drawing.Color.Orange;
            this.lb_FirstName.Location = new System.Drawing.Point(6, 36);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(80, 21);
            this.lb_FirstName.TabIndex = 12;
            this.lb_FirstName.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(92, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 29);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "<none>";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.CausesValidation = false;
            this.lbl_LastName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbl_LastName.ForeColor = System.Drawing.Color.Orange;
            this.lbl_LastName.Location = new System.Drawing.Point(6, 64);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(80, 21);
            this.lbl_LastName.TabIndex = 14;
            this.lbl_LastName.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(92, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 29);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "<none>";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.CausesValidation = false;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbl_Email.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Email.Location = new System.Drawing.Point(6, 92);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 21);
            this.lbl_Email.TabIndex = 16;
            this.lbl_Email.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DimGray;
            this.textBox3.Location = new System.Drawing.Point(92, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 29);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "<none>";
            // 
            // lbl_Cellphone
            // 
            this.lbl_Cellphone.AutoSize = true;
            this.lbl_Cellphone.CausesValidation = false;
            this.lbl_Cellphone.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbl_Cellphone.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Cellphone.Location = new System.Drawing.Point(6, 120);
            this.lbl_Cellphone.Name = "lbl_Cellphone";
            this.lbl_Cellphone.Size = new System.Drawing.Size(78, 21);
            this.lbl_Cellphone.TabIndex = 18;
            this.lbl_Cellphone.Text = "Cellphone";
            // 
            // btn_CreateMember
            // 
            this.btn_CreateMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateMember.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_CreateMember.Location = new System.Drawing.Point(137, 158);
            this.btn_CreateMember.Name = "btn_CreateMember";
            this.btn_CreateMember.Size = new System.Drawing.Size(146, 30);
            this.btn_CreateMember.TabIndex = 20;
            this.btn_CreateMember.Text = "Create Member";
            this.btn_CreateMember.UseVisualStyleBackColor = false;
            // 
            // listB_TeamMembers
            // 
            this.listB_TeamMembers.BackColor = System.Drawing.Color.DimGray;
            this.listB_TeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listB_TeamMembers.FormattingEnabled = true;
            this.listB_TeamMembers.Location = new System.Drawing.Point(364, 105);
            this.listB_TeamMembers.Name = "listB_TeamMembers";
            this.listB_TeamMembers.Size = new System.Drawing.Size(274, 275);
            this.listB_TeamMembers.TabIndex = 20;
            // 
            // btn_DeleteSelectedMember
            // 
            this.btn_DeleteSelectedMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_DeleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_DeleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSelectedMember.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_DeleteSelectedMember.Location = new System.Drawing.Point(475, 386);
            this.btn_DeleteSelectedMember.Name = "btn_DeleteSelectedMember";
            this.btn_DeleteSelectedMember.Size = new System.Drawing.Size(163, 30);
            this.btn_DeleteSelectedMember.TabIndex = 24;
            this.btn_DeleteSelectedMember.Text = "Delete Selected";
            this.btn_DeleteSelectedMember.UseVisualStyleBackColor = false;
            // 
            // btn_CreateTournament
            // 
            this.btn_CreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTournament.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_CreateTournament.Location = new System.Drawing.Point(285, 446);
            this.btn_CreateTournament.Name = "btn_CreateTournament";
            this.btn_CreateTournament.Size = new System.Drawing.Size(141, 30);
            this.btn_CreateTournament.TabIndex = 25;
            this.btn_CreateTournament.Text = "Create Team";
            this.btn_CreateTournament.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(685, 488);
            this.Controls.Add(this.btn_CreateTournament);
            this.Controls.Add(this.btn_DeleteSelectedMember);
            this.Controls.Add(this.listB_TeamMembers);
            this.Controls.Add(this.groupB_AddNewMember);
            this.Controls.Add(this.dd_SelectTeamMember);
            this.Controls.Add(this.lb_SelectTeamMember);
            this.Controls.Add(this.btn_AddTeamMember);
            this.Controls.Add(this.textB_TeamNameValue);
            this.Controls.Add(this.lb_TeamName);
            this.Controls.Add(this.lb_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.groupB_AddNewMember.ResumeLayout(false);
            this.groupB_AddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.TextBox textB_TeamNameValue;
        private System.Windows.Forms.Label lb_TeamName;
        private System.Windows.Forms.ComboBox dd_SelectTeamMember;
        private System.Windows.Forms.Label lb_SelectTeamMember;
        private System.Windows.Forms.Button btn_AddTeamMember;
        private System.Windows.Forms.GroupBox groupB_AddNewMember;
        private System.Windows.Forms.Button btn_CreateMember;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_Cellphone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.TextBox textB_FirstNameValue;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.ListBox listB_TeamMembers;
        private System.Windows.Forms.Button btn_DeleteSelectedMember;
        private System.Windows.Forms.Button btn_CreateTournament;
    }
}


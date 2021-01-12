
namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.lb_LoadExistingTournament = new System.Windows.Forms.Label();
            this.btn_LoadTournament = new System.Windows.Forms.Button();
            this.dd_ExistingTournament = new System.Windows.Forms.ComboBox();
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
            this.lb_Header.Location = new System.Drawing.Point(76, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(346, 30);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Tournament Dashboard";
            // 
            // lb_LoadExistingTournament
            // 
            this.lb_LoadExistingTournament.AutoSize = true;
            this.lb_LoadExistingTournament.CausesValidation = false;
            this.lb_LoadExistingTournament.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lb_LoadExistingTournament.ForeColor = System.Drawing.Color.Orange;
            this.lb_LoadExistingTournament.Location = new System.Drawing.Point(147, 55);
            this.lb_LoadExistingTournament.Name = "lb_LoadExistingTournament";
            this.lb_LoadExistingTournament.Size = new System.Drawing.Size(181, 21);
            this.lb_LoadExistingTournament.TabIndex = 12;
            this.lb_LoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // btn_LoadTournament
            // 
            this.btn_LoadTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_LoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_LoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_LoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadTournament.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_LoadTournament.Location = new System.Drawing.Point(37, 130);
            this.btn_LoadTournament.Name = "btn_LoadTournament";
            this.btn_LoadTournament.Size = new System.Drawing.Size(177, 30);
            this.btn_LoadTournament.TabIndex = 25;
            this.btn_LoadTournament.Text = "Load Tournament";
            this.btn_LoadTournament.UseVisualStyleBackColor = false;
            // 
            // dd_ExistingTournament
            // 
            this.dd_ExistingTournament.BackColor = System.Drawing.Color.DimGray;
            this.dd_ExistingTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd_ExistingTournament.ForeColor = System.Drawing.Color.Black;
            this.dd_ExistingTournament.FormattingEnabled = true;
            this.dd_ExistingTournament.Location = new System.Drawing.Point(151, 91);
            this.dd_ExistingTournament.Name = "dd_ExistingTournament";
            this.dd_ExistingTournament.Size = new System.Drawing.Size(177, 21);
            this.dd_ExistingTournament.TabIndex = 28;
            // 
            // btn_CreateTournament
            // 
            this.btn_CreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_CreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTournament.Font = new System.Drawing.Font("Algerian", 12F);
            this.btn_CreateTournament.Location = new System.Drawing.Point(248, 130);
            this.btn_CreateTournament.Name = "btn_CreateTournament";
            this.btn_CreateTournament.Size = new System.Drawing.Size(190, 30);
            this.btn_CreateTournament.TabIndex = 29;
            this.btn_CreateTournament.Text = "Create Tournament";
            this.btn_CreateTournament.UseVisualStyleBackColor = false;
            // 
            // TounramentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(459, 186);
            this.Controls.Add(this.btn_CreateTournament);
            this.Controls.Add(this.dd_ExistingTournament);
            this.Controls.Add(this.btn_LoadTournament);
            this.Controls.Add(this.lb_Header);
            this.Controls.Add(this.lb_LoadExistingTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "TounramentDashboard";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.Label lb_LoadExistingTournament;
        private System.Windows.Forms.Button btn_LoadTournament;
        private System.Windows.Forms.ComboBox dd_ExistingTournament;
        private System.Windows.Forms.Button btn_CreateTournament;
    }
}


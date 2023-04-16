namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExcistingTournamentValue = new System.Windows.Forms.ComboBox();
            this.loadExcistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(12, 28);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(385, 50);
            this.tournamentDashboardLabel.TabIndex = 4;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExcistingTournamentValue
            // 
            this.loadExcistingTournamentValue.FormattingEnabled = true;
            this.loadExcistingTournamentValue.Location = new System.Drawing.Point(21, 161);
            this.loadExcistingTournamentValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadExcistingTournamentValue.Name = "loadExcistingTournamentValue";
            this.loadExcistingTournamentValue.Size = new System.Drawing.Size(384, 38);
            this.loadExcistingTournamentValue.TabIndex = 18;
            // 
            // loadExcistingTournamentLabel
            // 
            this.loadExcistingTournamentLabel.AutoSize = true;
            this.loadExcistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExcistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadExcistingTournamentLabel.Location = new System.Drawing.Point(14, 120);
            this.loadExcistingTournamentLabel.Name = "loadExcistingTournamentLabel";
            this.loadExcistingTournamentLabel.Size = new System.Drawing.Size(334, 37);
            this.loadExcistingTournamentLabel.TabIndex = 17;
            this.loadExcistingTournamentLabel.Text = "Load Excisting Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadTournamentButton.Location = new System.Drawing.Point(86, 238);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(226, 58);
            this.loadTournamentButton.TabIndex = 27;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentButton.Location = new System.Drawing.Point(73, 323);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(249, 81);
            this.createTournamentButton.TabIndex = 28;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 524);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExcistingTournamentValue);
            this.Controls.Add(this.loadExcistingTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.ComboBox loadExcistingTournamentValue;
        private System.Windows.Forms.Label loadExcistingTournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
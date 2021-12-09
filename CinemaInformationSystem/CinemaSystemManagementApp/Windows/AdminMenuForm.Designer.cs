
namespace CinemaSystemManagementApp
{
    partial class AdminMenuForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowSessionsPanelButton = new System.Windows.Forms.Button();
            this.ShowTicketsPanelButton = new System.Windows.Forms.Button();
            this.ShowMoviesPanelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoBackButton = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.MinimumSize = new System.Drawing.Size(500, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(525, 519);
            this.MainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.ShowSessionsPanelButton);
            this.panel1.Controls.Add(this.ShowTicketsPanelButton);
            this.panel1.Controls.Add(this.ShowMoviesPanelButton);
            this.panel1.Location = new System.Drawing.Point(23, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 336);
            this.panel1.TabIndex = 1;
            // 
            // ShowSessionsPanelButton
            // 
            this.ShowSessionsPanelButton.AutoSize = true;
            this.ShowSessionsPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShowSessionsPanelButton.FlatAppearance.BorderSize = 0;
            this.ShowSessionsPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ShowSessionsPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.ShowSessionsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSessionsPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSessionsPanelButton.Location = new System.Drawing.Point(143, 115);
            this.ShowSessionsPanelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowSessionsPanelButton.Name = "ShowSessionsPanelButton";
            this.ShowSessionsPanelButton.Size = new System.Drawing.Size(185, 38);
            this.ShowSessionsPanelButton.TabIndex = 6;
            this.ShowSessionsPanelButton.Text = "Наша сеансы";
            this.ShowSessionsPanelButton.UseVisualStyleBackColor = false;
            this.ShowSessionsPanelButton.Click += new System.EventHandler(this.ShowSessionsPanelButton_Click);
            // 
            // ShowTicketsPanelButton
            // 
            this.ShowTicketsPanelButton.AutoSize = true;
            this.ShowTicketsPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShowTicketsPanelButton.FlatAppearance.BorderSize = 0;
            this.ShowTicketsPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ShowTicketsPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.ShowTicketsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTicketsPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTicketsPanelButton.Location = new System.Drawing.Point(143, 177);
            this.ShowTicketsPanelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowTicketsPanelButton.Name = "ShowTicketsPanelButton";
            this.ShowTicketsPanelButton.Size = new System.Drawing.Size(185, 38);
            this.ShowTicketsPanelButton.TabIndex = 5;
            this.ShowTicketsPanelButton.Text = "Билеты";
            this.ShowTicketsPanelButton.UseVisualStyleBackColor = false;
            this.ShowTicketsPanelButton.Click += new System.EventHandler(this.ShowTicketsPanelButton_Click);
            // 
            // ShowMoviesPanelButton
            // 
            this.ShowMoviesPanelButton.AutoSize = true;
            this.ShowMoviesPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShowMoviesPanelButton.FlatAppearance.BorderSize = 0;
            this.ShowMoviesPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ShowMoviesPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.ShowMoviesPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMoviesPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowMoviesPanelButton.Location = new System.Drawing.Point(143, 51);
            this.ShowMoviesPanelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowMoviesPanelButton.Name = "ShowMoviesPanelButton";
            this.ShowMoviesPanelButton.Size = new System.Drawing.Size(185, 38);
            this.ShowMoviesPanelButton.TabIndex = 4;
            this.ShowMoviesPanelButton.Text = "Наши фильмы";
            this.ShowMoviesPanelButton.UseVisualStyleBackColor = false;
            this.ShowMoviesPanelButton.Click += new System.EventHandler(this.ShowMoviesPanelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.GoBackButton);
            this.panel2.Controls.Add(this.HeadPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 145);
            this.panel2.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.AutoSize = true;
            this.GoBackButton.BackColor = System.Drawing.Color.Black;
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.ForeColor = System.Drawing.Color.White;
            this.GoBackButton.Location = new System.Drawing.Point(482, 9);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(30, 29);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "X";
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            this.GoBackButton.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.GoBackButton.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.Black;
            this.HeadPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadPanel.ForeColor = System.Drawing.Color.White;
            this.HeadPanel.Location = new System.Drawing.Point(-11, 0);
            this.HeadPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(538, 145);
            this.HeadPanel.TabIndex = 0;
            this.HeadPanel.Text = "Администратор - ";
            this.HeadPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 519);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintFilms";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GoBackButton;
        private System.Windows.Forms.Label HeadPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowMoviesPanelButton;
        private System.Windows.Forms.Button ShowSessionsPanelButton;
        private System.Windows.Forms.Button ShowTicketsPanelButton;
    }
}
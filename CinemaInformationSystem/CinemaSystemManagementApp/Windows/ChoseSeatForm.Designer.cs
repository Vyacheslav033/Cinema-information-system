
namespace CinemaSystemManagementApp
{
    partial class ChoseSeatForm
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
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.SetSeatButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Label();
            this.ReservedSeatColorPanel = new System.Windows.Forms.Panel();
            this.FreeSeatColorPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedSeatColorPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ScreenPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.Maroon;
            this.MainPanel.Location = new System.Drawing.Point(56, 176);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(211, 203);
            this.MainPanel.TabIndex = 5;
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.AutoSize = true;
            this.ScreenPanel.BackColor = System.Drawing.Color.Maroon;
            this.ScreenPanel.Controls.Add(this.label1);
            this.ScreenPanel.Location = new System.Drawing.Point(56, 96);
            this.ScreenPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(211, 57);
            this.ScreenPanel.TabIndex = 6;
            // 
            // SetSeatButton
            // 
            this.SetSeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetSeatButton.Location = new System.Drawing.Point(56, 403);
            this.SetSeatButton.Name = "SetSeatButton";
            this.SetSeatButton.Size = new System.Drawing.Size(229, 43);
            this.SetSeatButton.TabIndex = 8;
            this.SetSeatButton.Text = "Выбрать место";
            this.SetSeatButton.UseVisualStyleBackColor = true;
            this.SetSeatButton.Click += new System.EventHandler(this.SetSeatButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.AutoSize = true;
            this.GoBackButton.BackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.ForeColor = System.Drawing.Color.White;
            this.GoBackButton.Location = new System.Drawing.Point(984, 12);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(30, 29);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.Text = "X";
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ReservedSeatColorPanel
            // 
            this.ReservedSeatColorPanel.Location = new System.Drawing.Point(6, 18);
            this.ReservedSeatColorPanel.Name = "ReservedSeatColorPanel";
            this.ReservedSeatColorPanel.Size = new System.Drawing.Size(28, 26);
            this.ReservedSeatColorPanel.TabIndex = 10;
            // 
            // FreeSeatColorPanel
            // 
            this.FreeSeatColorPanel.Location = new System.Drawing.Point(337, 18);
            this.FreeSeatColorPanel.Name = "FreeSeatColorPanel";
            this.FreeSeatColorPanel.Size = new System.Drawing.Size(28, 26);
            this.FreeSeatColorPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Забронированные места";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(394, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Свободные места";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(663, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выбранное место";
            // 
            // SelectedSeatColorPanel
            // 
            this.SelectedSeatColorPanel.Location = new System.Drawing.Point(617, 18);
            this.SelectedSeatColorPanel.Name = "SelectedSeatColorPanel";
            this.SelectedSeatColorPanel.Size = new System.Drawing.Size(28, 26);
            this.SelectedSeatColorPanel.TabIndex = 14;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.SelectedSeatColorPanel);
            this.InfoPanel.Controls.Add(this.ReservedSeatColorPanel);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.FreeSeatColorPanel);
            this.InfoPanel.Location = new System.Drawing.Point(56, 12);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(898, 64);
            this.InfoPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Экран";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoseSeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(1019, 475);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.SetSeatButton);
            this.Controls.Add(this.ScreenPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChoseSeatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditBD";
            this.ScreenPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ScreenPanel;
        private System.Windows.Forms.Button SetSeatButton;
        private System.Windows.Forms.Label GoBackButton;
        private System.Windows.Forms.Panel ReservedSeatColorPanel;
        private System.Windows.Forms.Panel FreeSeatColorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SelectedSeatColorPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label1;
    }
}
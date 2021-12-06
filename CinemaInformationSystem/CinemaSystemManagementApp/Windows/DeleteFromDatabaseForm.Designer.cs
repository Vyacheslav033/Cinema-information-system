
namespace CinemaSystemManagementApp
{
    partial class DeleteFromDatabaseForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.InputPanelTitle = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RecordNumberBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(360, 395);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.RecordNumberBox);
            this.panel1.Location = new System.Drawing.Point(53, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 194);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.InputPanelTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 43);
            this.panel3.TabIndex = 17;
            // 
            // InputPanelTitle
            // 
            this.InputPanelTitle.BackColor = System.Drawing.Color.Tomato;
            this.InputPanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanelTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPanelTitle.ForeColor = System.Drawing.Color.White;
            this.InputPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.InputPanelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputPanelTitle.Name = "InputPanelTitle";
            this.InputPanelTitle.Size = new System.Drawing.Size(257, 43);
            this.InputPanelTitle.TabIndex = 18;
            this.InputPanelTitle.Text = "Номер";
            this.InputPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InputPanelTitle.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.YellowGreen;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(69, 120);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 42);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RecordNumberBox
            // 
            this.RecordNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordNumberBox.Location = new System.Drawing.Point(42, 68);
            this.RecordNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecordNumberBox.Name = "RecordNumberBox";
            this.RecordNumberBox.Size = new System.Drawing.Size(169, 27);
            this.RecordNumberBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.HeaderPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 145);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(326, 9);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Black;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(360, 145);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.Text = "Удалить";
            this.HeaderPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Black;
            this.panelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHead.ForeColor = System.Drawing.Color.White;
            this.panelHead.Location = new System.Drawing.Point(-3, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(365, 397);
            this.panelHead.TabIndex = 1;
            this.panelHead.Text = "Leviafan";
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelHead.UseMnemonic = false;
            // 
            // DeleteFromDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 395);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteFromDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Films";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label HeaderPanel;
        private System.Windows.Forms.TextBox RecordNumberBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label InputPanelTitle;
        private System.Windows.Forms.Label panelHead;
    }
}
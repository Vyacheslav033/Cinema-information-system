
namespace CinemaSystemManagementApp
{
    partial class DataForUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.ValueForSearchBox = new System.Windows.Forms.TextBox();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
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
            this.MainPanel.Size = new System.Drawing.Size(1380, 950);
            this.MainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.UpdateDataButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.ValueForSearchBox);
            this.panel1.Controls.Add(this.BackToMenu);
            this.panel1.Controls.Add(this.DataTable);
            this.panel1.Location = new System.Drawing.Point(23, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 769);
            this.panel1.TabIndex = 1;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.AutoSize = true;
            this.UpdateDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpdateDataButton.FlatAppearance.BorderSize = 0;
            this.UpdateDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.UpdateDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.UpdateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDataButton.Location = new System.Drawing.Point(718, 30);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(121, 38);
            this.UpdateDataButton.TabIndex = 7;
            this.UpdateDataButton.Text = "Обновить";
            this.UpdateDataButton.UseVisualStyleBackColor = false;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::CinemaSystemManagementApp.Properties.Resources.search;
            this.SearchButton.Location = new System.Drawing.Point(876, 30);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(61, 38);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.TabStop = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ValueForSearchBox
            // 
            this.ValueForSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueForSearchBox.Location = new System.Drawing.Point(945, 30);
            this.ValueForSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValueForSearchBox.Name = "ValueForSearchBox";
            this.ValueForSearchBox.Size = new System.Drawing.Size(356, 38);
            this.ValueForSearchBox.TabIndex = 2;
            // 
            // BackToMenu
            // 
            this.BackToMenu.AutoSize = true;
            this.BackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackToMenu.FlatAppearance.BorderSize = 0;
            this.BackToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BackToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenu.Location = new System.Drawing.Point(28, 30);
            this.BackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(122, 38);
            this.BackToMenu.TabIndex = 1;
            this.BackToMenu.Text = "Назад";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(28, 92);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.Size = new System.Drawing.Size(1273, 613);
            this.DataTable.TabIndex = 0;
            this.DataTable.DoubleClick += new System.EventHandler(this.DataTable_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.panelHead);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1380, 145);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1329, 29);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Black;
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHead.ForeColor = System.Drawing.Color.White;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1380, 145);
            this.panelHead.TabIndex = 0;
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataForUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 950);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataForUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintFilms";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label panelHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.TextBox ValueForSearchBox;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button UpdateDataButton;
    }
}
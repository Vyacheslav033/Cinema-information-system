
namespace CinemaSystemManagementApp
{
    partial class EditDatabaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeadPanel = new System.Windows.Forms.Label();
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.EditEntryButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.ValueForSearchBox = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.Black;
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadPanel.ForeColor = System.Drawing.Color.White;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(1687, 145);
            this.HeadPanel.TabIndex = 0;
            this.HeadPanel.Text = "Редактирование афиши";
            this.HeadPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.AutoSize = true;
            this.AddEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddEntryButton.FlatAppearance.BorderSize = 0;
            this.AddEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AddEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.AddEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEntryButton.Location = new System.Drawing.Point(28, 46);
            this.AddEntryButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(112, 38);
            this.AddEntryButton.TabIndex = 1;
            this.AddEntryButton.Text = "Добавить";
            this.AddEntryButton.UseVisualStyleBackColor = false;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(28, 106);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.Size = new System.Drawing.Size(1314, 597);
            this.DataTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.UpdateDataButton);
            this.panel1.Controls.Add(this.DeleteEntryButton);
            this.panel1.Controls.Add(this.EditEntryButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.ValueForSearchBox);
            this.panel1.Controls.Add(this.AddEntryButton);
            this.panel1.Controls.Add(this.DataTable);
            this.panel1.Location = new System.Drawing.Point(63, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 728);
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
            this.UpdateDataButton.Location = new System.Drawing.Point(814, 43);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(121, 38);
            this.UpdateDataButton.TabIndex = 6;
            this.UpdateDataButton.Text = "Обновить";
            this.UpdateDataButton.UseVisualStyleBackColor = false;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.AutoSize = true;
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteEntryButton.FlatAppearance.BorderSize = 0;
            this.DeleteEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DeleteEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.DeleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEntryButton.Location = new System.Drawing.Point(343, 46);
            this.DeleteEntryButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(121, 38);
            this.DeleteEntryButton.TabIndex = 5;
            this.DeleteEntryButton.Text = "Удалить";
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // EditEntryButton
            // 
            this.EditEntryButton.AutoSize = true;
            this.EditEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditEntryButton.FlatAppearance.BorderSize = 0;
            this.EditEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.EditEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.EditEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditEntryButton.Location = new System.Drawing.Point(164, 46);
            this.EditEntryButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditEntryButton.Name = "EditEntryButton";
            this.EditEntryButton.Size = new System.Drawing.Size(159, 38);
            this.EditEntryButton.TabIndex = 4;
            this.EditEntryButton.Text = "Редактировать";
            this.EditEntryButton.UseVisualStyleBackColor = false;
            this.EditEntryButton.Click += new System.EventHandler(this.EditEntryButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Image = global::CinemaSystemManagementApp.Properties.Resources.search;
            this.SearchButton.Location = new System.Drawing.Point(990, 43);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(37, 34);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.TabStop = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ValueForSearchBox
            // 
            this.ValueForSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueForSearchBox.Location = new System.Drawing.Point(1049, 43);
            this.ValueForSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValueForSearchBox.Name = "ValueForSearchBox";
            this.ValueForSearchBox.Size = new System.Drawing.Size(293, 38);
            this.ValueForSearchBox.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1687, 927);
            this.MainPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.HeadPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1687, 145);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1418, 22);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 927);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditBD";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeadPanel;
        private System.Windows.Forms.Button AddEntryButton;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditEntryButton;
        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.TextBox ValueForSearchBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.Button UpdateDataButton;
    }
}
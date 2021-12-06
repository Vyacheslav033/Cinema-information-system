﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeadPanel = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BtnRef = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(28, 46);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(112, 38);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.BtnRef);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.DataTable);
            this.panel1.Location = new System.Drawing.Point(63, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 728);
            this.panel1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(334, 46);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 38);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BtnRef
            // 
            this.BtnRef.AutoSize = true;
            this.BtnRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnRef.FlatAppearance.BorderSize = 0;
            this.BtnRef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.BtnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRef.Location = new System.Drawing.Point(173, 46);
            this.BtnRef.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRef.Name = "BtnRef";
            this.BtnRef.Size = new System.Drawing.Size(121, 38);
            this.BtnRef.TabIndex = 4;
            this.BtnRef.Text = "Обновить";
            this.BtnRef.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaSystemManagementApp.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(990, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSearch.Location = new System.Drawing.Point(1049, 43);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(293, 38);
            this.textSearch.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeadPanel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRef;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button DeleteButton;
    }
}
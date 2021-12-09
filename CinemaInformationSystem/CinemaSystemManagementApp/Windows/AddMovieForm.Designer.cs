
namespace CinemaSystemManagementApp
{
    partial class AddMovieForm
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
            this.panelHead = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllowedAgeBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlError = new System.Windows.Forms.Label();
            this.MovieDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddOrUpdateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieCountryBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenresBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieProduceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieDurationBox = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.MovieNameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panelHead.Size = new System.Drawing.Size(608, 944);
            this.panelHead.TabIndex = 1;
            this.panelHead.Text = "Leviafan";
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(608, 931);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.AllowedAgeBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.MovieDatePicker);
            this.panel1.Controls.Add(this.AddOrUpdateButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MovieCountryBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GenresBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MovieProduceBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MovieDurationBox);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.MovieNameBox);
            this.panel1.Location = new System.Drawing.Point(37, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 711);
            this.panel1.TabIndex = 1;
            // 
            // AllowedAgeBox
            // 
            this.AllowedAgeBox.FormattingEnabled = true;
            this.AllowedAgeBox.Items.AddRange(new object[] {
            "0+",
            "6+",
            "12+",
            "14+",
            "16+",
            "18+"});
            this.AllowedAgeBox.Location = new System.Drawing.Point(47, 574);
            this.AllowedAgeBox.Name = "AllowedAgeBox";
            this.AllowedAgeBox.Size = new System.Drawing.Size(161, 24);
            this.AllowedAgeBox.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlError);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 43);
            this.panel3.TabIndex = 17;
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Tomato;
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlError.ForeColor = System.Drawing.Color.White;
            this.pnlError.Location = new System.Drawing.Point(0, 0);
            this.pnlError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(539, 43);
            this.pnlError.TabIndex = 18;
            this.pnlError.Text = "Информация о фильме";
            this.pnlError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlError.Visible = false;
            // 
            // MovieDatePicker
            // 
            this.MovieDatePicker.CustomFormat = "yyyy-MM-dd";
            this.MovieDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovieDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MovieDatePicker.Location = new System.Drawing.Point(45, 271);
            this.MovieDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDatePicker.MaxDate = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            this.MovieDatePicker.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.MovieDatePicker.Name = "MovieDatePicker";
            this.MovieDatePicker.Size = new System.Drawing.Size(265, 27);
            this.MovieDatePicker.TabIndex = 16;
            this.MovieDatePicker.Value = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            // 
            // AddOrUpdateButton
            // 
            this.AddOrUpdateButton.AutoSize = true;
            this.AddOrUpdateButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AddOrUpdateButton.FlatAppearance.BorderSize = 0;
            this.AddOrUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AddOrUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.AddOrUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrUpdateButton.Location = new System.Drawing.Point(198, 626);
            this.AddOrUpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrUpdateButton.Name = "AddOrUpdateButton";
            this.AddOrUpdateButton.Size = new System.Drawing.Size(112, 42);
            this.AddOrUpdateButton.TabIndex = 14;
            this.AddOrUpdateButton.Text = "Добавить";
            this.AddOrUpdateButton.UseVisualStyleBackColor = false;
            this.AddOrUpdateButton.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 554);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Возрастное ограничение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 486);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Страна";
            // 
            // MovieCountryBox
            // 
            this.MovieCountryBox.Location = new System.Drawing.Point(47, 510);
            this.MovieCountryBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieCountryBox.Name = "MovieCountryBox";
            this.MovieCountryBox.Size = new System.Drawing.Size(441, 22);
            this.MovieCountryBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Жанр";
            // 
            // GenresBox
            // 
            this.GenresBox.CheckOnClick = true;
            this.GenresBox.FormattingEnabled = true;
            this.GenresBox.Items.AddRange(new object[] {
            "Мелодрамма",
            "Комедия",
            "Фантастика",
            "Боевик",
            "Приключение",
            "Драма",
            "Триллер",
            "Ужасы",
            "Детектив",
            "Ужасы",
            "Фэнтези",
            "Мультфильм",
            "Мюзикл",
            "Мистика",
            "Фильм-катастрофа",
            "Семейный",
            "Преступление",
            "Военный"});
            this.GenresBox.Location = new System.Drawing.Point(45, 345);
            this.GenresBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenresBox.MultiColumn = true;
            this.GenresBox.Name = "GenresBox";
            this.GenresBox.Size = new System.Drawing.Size(467, 106);
            this.GenresBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата выхода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Режиссер";
            // 
            // MovieProduceBox
            // 
            this.MovieProduceBox.Location = new System.Drawing.Point(44, 203);
            this.MovieProduceBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieProduceBox.Name = "MovieProduceBox";
            this.MovieProduceBox.Size = new System.Drawing.Size(441, 22);
            this.MovieProduceBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Продолжительность";
            // 
            // MovieDurationBox
            // 
            this.MovieDurationBox.Location = new System.Drawing.Point(44, 148);
            this.MovieDurationBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDurationBox.Name = "MovieDurationBox";
            this.MovieDurationBox.Size = new System.Drawing.Size(441, 22);
            this.MovieDurationBox.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(39, 64);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(127, 17);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Название фильма";
            // 
            // MovieNameBox
            // 
            this.MovieNameBox.Location = new System.Drawing.Point(44, 87);
            this.MovieNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieNameBox.Name = "MovieNameBox";
            this.MovieNameBox.Size = new System.Drawing.Size(441, 22);
            this.MovieNameBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.HeaderLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 145);
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
            this.Exit.Location = new System.Drawing.Point(565, 9);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.Black;
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(608, 145);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Добавить фильм";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 944);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMovieForm";
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

        private System.Windows.Forms.Label panelHead;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox MovieNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MovieProduceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieDurationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MovieCountryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddOrUpdateButton;
        private System.Windows.Forms.DateTimePicker MovieDatePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pnlError;
        private System.Windows.Forms.CheckedListBox GenresBox;
        private System.Windows.Forms.ComboBox AllowedAgeBox;
    }
}

namespace CinemaSystemManagementApp
{
    partial class AddSessionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.HallNameBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlError = new System.Windows.Forms.Label();
            this.MovieDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddOrUpdateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoviePriceBox = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.MovieIdBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
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
            this.MainPanel.Size = new System.Drawing.Size(608, 704);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HallNameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MovieTimePicker);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.MovieDatePicker);
            this.panel1.Controls.Add(this.AddOrUpdateButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MoviePriceBox);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.MovieIdBox);
            this.panel1.Location = new System.Drawing.Point(37, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 464);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Зал";
            // 
            // HallNameBox
            // 
            this.HallNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HallNameBox.FormattingEnabled = true;
            this.HallNameBox.Items.AddRange(new object[] {
            "Комфорт 1",
            "Комфорт 2",
            "Премиум",
            "ВИП"});
            this.HallNameBox.Location = new System.Drawing.Point(42, 331);
            this.HallNameBox.Name = "HallNameBox";
            this.HallNameBox.Size = new System.Drawing.Size(200, 28);
            this.HallNameBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Время сеанса";
            // 
            // MovieTimePicker
            // 
            this.MovieTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovieTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MovieTimePicker.Location = new System.Drawing.Point(42, 267);
            this.MovieTimePicker.Name = "MovieTimePicker";
            this.MovieTimePicker.Size = new System.Drawing.Size(200, 27);
            this.MovieTimePicker.TabIndex = 20;
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
            this.pnlError.Text = "Информация о сеансе";
            this.pnlError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlError.Visible = false;
            // 
            // MovieDatePicker
            // 
            this.MovieDatePicker.CustomFormat = "yyyy-MM-dd";
            this.MovieDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovieDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MovieDatePicker.Location = new System.Drawing.Point(42, 204);
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
            this.AddOrUpdateButton.Location = new System.Drawing.Point(195, 383);
            this.AddOrUpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrUpdateButton.Name = "AddOrUpdateButton";
            this.AddOrUpdateButton.Size = new System.Drawing.Size(112, 42);
            this.AddOrUpdateButton.TabIndex = 14;
            this.AddOrUpdateButton.Text = "Добавить";
            this.AddOrUpdateButton.UseVisualStyleBackColor = false;
            this.AddOrUpdateButton.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата сеанса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // MoviePriceBox
            // 
            this.MoviePriceBox.Location = new System.Drawing.Point(42, 147);
            this.MoviePriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviePriceBox.Name = "MoviePriceBox";
            this.MoviePriceBox.Size = new System.Drawing.Size(441, 22);
            this.MoviePriceBox.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(39, 64);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(106, 17);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Номер фильма";
            // 
            // MovieIdBox
            // 
            this.MovieIdBox.Location = new System.Drawing.Point(44, 87);
            this.MovieIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieIdBox.Name = "MovieIdBox";
            this.MovieIdBox.Size = new System.Drawing.Size(441, 22);
            this.MovieIdBox.TabIndex = 0;
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
            this.HeaderLabel.Text = "Добавить Сеанс";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelHead.Size = new System.Drawing.Size(608, 704);
            this.panelHead.TabIndex = 1;
            this.panelHead.Text = "Leviafan";
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 704);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSessionForm";
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
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox MovieIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoviePriceBox;
        private System.Windows.Forms.Button AddOrUpdateButton;
        private System.Windows.Forms.DateTimePicker MovieDatePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pnlError;
        private System.Windows.Forms.DateTimePicker MovieTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HallNameBox;
        private System.Windows.Forms.Label panelHead;
    }
}
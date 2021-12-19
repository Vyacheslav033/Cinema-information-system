
namespace CinemaSystemManagementApp
{
    partial class BookTicketForm
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
            this.SetSeatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentTypeBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlError = new System.Windows.Forms.Label();
            this.AddOrUpdateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Label();
            this.SeatInfoLabel = new System.Windows.Forms.Label();
            this.SessionNumberLabel = new System.Windows.Forms.Label();
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
            this.MainPanel.Size = new System.Drawing.Size(608, 594);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.SessionNumberLabel);
            this.panel1.Controls.Add(this.SeatInfoLabel);
            this.panel1.Controls.Add(this.SetSeatButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PaymentTypeBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AddOrUpdateButton);
            this.panel1.Location = new System.Drawing.Point(37, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 400);
            this.panel1.TabIndex = 1;
            // 
            // SetSeatButton
            // 
            this.SetSeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetSeatButton.Location = new System.Drawing.Point(183, 183);
            this.SetSeatButton.Name = "SetSeatButton";
            this.SetSeatButton.Size = new System.Drawing.Size(185, 38);
            this.SetSeatButton.TabIndex = 26;
            this.SetSeatButton.Text = "Выбрать место";
            this.SetSeatButton.UseVisualStyleBackColor = true;
            this.SetSeatButton.Click += new System.EventHandler(this.SetSeatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Тип оплаты";
            // 
            // PaymentTypeBox
            // 
            this.PaymentTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentTypeBox.FormattingEnabled = true;
            this.PaymentTypeBox.Items.AddRange(new object[] {
            "Наличная",
            "Безналичная"});
            this.PaymentTypeBox.Location = new System.Drawing.Point(135, 265);
            this.PaymentTypeBox.Name = "PaymentTypeBox";
            this.PaymentTypeBox.Size = new System.Drawing.Size(265, 28);
            this.PaymentTypeBox.TabIndex = 22;
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
            this.pnlError.Text = "Информация о билете";
            this.pnlError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlError.Visible = false;
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
            this.AddOrUpdateButton.Location = new System.Drawing.Point(192, 317);
            this.AddOrUpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrUpdateButton.Name = "AddOrUpdateButton";
            this.AddOrUpdateButton.Size = new System.Drawing.Size(162, 42);
            this.AddOrUpdateButton.TabIndex = 14;
            this.AddOrUpdateButton.Text = "Забронировать";
            this.AddOrUpdateButton.UseVisualStyleBackColor = false;
            this.AddOrUpdateButton.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.HeaderLabel.Text = "Забронировать билет";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Black;
            this.panelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHead.ForeColor = System.Drawing.Color.White;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(608, 598);
            this.panelHead.TabIndex = 1;
            this.panelHead.Text = "Leviafan";
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeatInfoLabel
            // 
            this.SeatInfoLabel.AutoSize = true;
            this.SeatInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeatInfoLabel.Location = new System.Drawing.Point(159, 130);
            this.SeatInfoLabel.Name = "SeatInfoLabel";
            this.SeatInfoLabel.Size = new System.Drawing.Size(0, 29);
            this.SeatInfoLabel.TabIndex = 27;
            // 
            // SessionNumberLabel
            // 
            this.SessionNumberLabel.AutoSize = true;
            this.SessionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionNumberLabel.Location = new System.Drawing.Point(159, 79);
            this.SessionNumberLabel.Name = "SessionNumberLabel";
            this.SessionNumberLabel.Size = new System.Drawing.Size(195, 29);
            this.SessionNumberLabel.TabIndex = 28;
            this.SessionNumberLabel.Text = "Номер сеанса - ";
            // 
            // BookTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 594);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookTicketForm";
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
        private System.Windows.Forms.Button AddOrUpdateButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pnlError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaymentTypeBox;
        private System.Windows.Forms.Label panelHead;
        private System.Windows.Forms.Button SetSeatButton;
        private System.Windows.Forms.Label SeatInfoLabel;
        private System.Windows.Forms.Label SessionNumberLabel;
    }
}
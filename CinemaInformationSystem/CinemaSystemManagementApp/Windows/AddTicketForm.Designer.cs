
namespace CinemaSystemManagementApp
{
    partial class AddTicketForm
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
            this.PaymentTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlError = new System.Windows.Forms.Label();
            this.TicketDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlaceNumberBox = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.RowNumberBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SessionNumberBox = new System.Windows.Forms.TextBox();
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
            this.MainPanel.Size = new System.Drawing.Size(608, 776);
            this.MainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmployeeIdBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SessionNumberBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PaymentTypeBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TicketTimePicker);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TicketDatePicker);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PlaceNumberBox);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.RowNumberBox);
            this.panel1.Location = new System.Drawing.Point(37, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 586);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 311);
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
            this.PaymentTypeBox.Location = new System.Drawing.Point(136, 331);
            this.PaymentTypeBox.Name = "PaymentTypeBox";
            this.PaymentTypeBox.Size = new System.Drawing.Size(265, 28);
            this.PaymentTypeBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Время покупки";
            // 
            // TicketTimePicker
            // 
            this.TicketTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TicketTimePicker.Location = new System.Drawing.Point(136, 267);
            this.TicketTimePicker.Name = "TicketTimePicker";
            this.TicketTimePicker.Size = new System.Drawing.Size(265, 27);
            this.TicketTimePicker.TabIndex = 20;
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
            // TicketDatePicker
            // 
            this.TicketDatePicker.CustomFormat = "yyyy-MM-dd";
            this.TicketDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TicketDatePicker.Location = new System.Drawing.Point(136, 204);
            this.TicketDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TicketDatePicker.MaxDate = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            this.TicketDatePicker.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.TicketDatePicker.Name = "TicketDatePicker";
            this.TicketDatePicker.Size = new System.Drawing.Size(265, 27);
            this.TicketDatePicker.TabIndex = 16;
            this.TicketDatePicker.Value = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(215, 512);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(112, 42);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата покупки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер места";
            // 
            // PlaceNumberBox
            // 
            this.PlaceNumberBox.Location = new System.Drawing.Point(136, 147);
            this.PlaceNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlaceNumberBox.Name = "PlaceNumberBox";
            this.PlaceNumberBox.Size = new System.Drawing.Size(265, 22);
            this.PlaceNumberBox.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(133, 64);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(87, 17);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Номер ряда";
            // 
            // RowNumberBox
            // 
            this.RowNumberBox.Location = new System.Drawing.Point(138, 87);
            this.RowNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.RowNumberBox.Name = "RowNumberBox";
            this.RowNumberBox.Size = new System.Drawing.Size(263, 22);
            this.RowNumberBox.TabIndex = 0;
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
            this.HeaderLabel.Text = "Добавить Билет";
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
            this.panelHead.Size = new System.Drawing.Size(608, 776);
            this.panelHead.TabIndex = 1;
            this.panelHead.Text = "Leviafan";
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Номер сотрудника";
            // 
            // EmployeeIdBox
            // 
            this.EmployeeIdBox.Location = new System.Drawing.Point(134, 460);
            this.EmployeeIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeIdBox.Name = "EmployeeIdBox";
            this.EmployeeIdBox.Size = new System.Drawing.Size(267, 22);
            this.EmployeeIdBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Номер сеанса";
            // 
            // SessionNumberBox
            // 
            this.SessionNumberBox.Location = new System.Drawing.Point(136, 400);
            this.SessionNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.SessionNumberBox.Name = "SessionNumberBox";
            this.SessionNumberBox.Size = new System.Drawing.Size(265, 22);
            this.SessionNumberBox.TabIndex = 24;
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 776);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTicketForm";
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
        private System.Windows.Forms.TextBox RowNumberBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlaceNumberBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DateTimePicker TicketDatePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pnlError;
        private System.Windows.Forms.DateTimePicker TicketTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaymentTypeBox;
        private System.Windows.Forms.Label panelHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmployeeIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SessionNumberBox;
    }
}
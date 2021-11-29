
namespace CinemaSystemManagementApp
{
    partial class MenuForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EnterAdm = new System.Windows.Forms.Label();
            this.BtnPrintAll = new System.Windows.Forms.Button();
            this.BuyPlace = new System.Windows.Forms.Button();
            this.PrintSeans = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Violet;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.MainPanel.Controls.Add(this.EnterAdm);
            this.MainPanel.Controls.Add(this.BtnPrintAll);
            this.MainPanel.Controls.Add(this.BuyPlace);
            this.MainPanel.Controls.Add(this.PrintSeans);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(439, 489);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // EnterAdm
            // 
            this.EnterAdm.AutoSize = true;
            this.EnterAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterAdm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EnterAdm.Location = new System.Drawing.Point(76, 439);
            this.EnterAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterAdm.Name = "EnterAdm";
            this.EnterAdm.Size = new System.Drawing.Size(277, 27);
            this.EnterAdm.TabIndex = 5;
            this.EnterAdm.Text = "Войти как администратор";
            this.EnterAdm.Click += new System.EventHandler(this.EnterAdm_Click);
            this.EnterAdm.MouseEnter += new System.EventHandler(this.EnterAdm_MouseEnter);
            this.EnterAdm.MouseLeave += new System.EventHandler(this.EnterAdm_MouseLeave);
            // 
            // BtnPrintAll
            // 
            this.BtnPrintAll.AutoSize = true;
            this.BtnPrintAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPrintAll.FlatAppearance.BorderSize = 0;
            this.BtnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(2)))), ((int)(((byte)(15)))));
            this.BtnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrintAll.Location = new System.Drawing.Point(20, 186);
            this.BtnPrintAll.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrintAll.Name = "BtnPrintAll";
            this.BtnPrintAll.Size = new System.Drawing.Size(406, 53);
            this.BtnPrintAll.TabIndex = 4;
            this.BtnPrintAll.Text = "Фильмы";
            this.BtnPrintAll.UseVisualStyleBackColor = false;
            this.BtnPrintAll.Click += new System.EventHandler(this.BtnPrintAll_Click);
            // 
            // BuyPlace
            // 
            this.BuyPlace.AutoSize = true;
            this.BuyPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BuyPlace.FlatAppearance.BorderSize = 0;
            this.BuyPlace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(2)))), ((int)(((byte)(15)))));
            this.BuyPlace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BuyPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyPlace.Location = new System.Drawing.Point(20, 340);
            this.BuyPlace.Margin = new System.Windows.Forms.Padding(4);
            this.BuyPlace.Name = "BuyPlace";
            this.BuyPlace.Size = new System.Drawing.Size(407, 53);
            this.BuyPlace.TabIndex = 3;
            this.BuyPlace.Text = "Забронировать место";
            this.BuyPlace.UseVisualStyleBackColor = false;
            // 
            // PrintSeans
            // 
            this.PrintSeans.AutoSize = true;
            this.PrintSeans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrintSeans.FlatAppearance.BorderSize = 0;
            this.PrintSeans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(2)))), ((int)(((byte)(15)))));
            this.PrintSeans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.PrintSeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintSeans.Location = new System.Drawing.Point(20, 264);
            this.PrintSeans.Margin = new System.Windows.Forms.Padding(4);
            this.PrintSeans.Name = "PrintSeans";
            this.PrintSeans.Size = new System.Drawing.Size(407, 53);
            this.PrintSeans.TabIndex = 2;
            this.PrintSeans.Text = "Сеансы";
            this.PrintSeans.UseVisualStyleBackColor = false;
            this.PrintSeans.Click += new System.EventHandler(this.PrintSeans_Click);
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
            this.panel2.Size = new System.Drawing.Size(439, 145);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(396, 9);
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
            this.panelHead.Size = new System.Drawing.Size(439, 145);
            this.panelHead.TabIndex = 0;
            this.panelHead.Text = "Меню";
            this.panelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 489);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "A";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label panelHead;
        private System.Windows.Forms.Button BuyPlace;
        private System.Windows.Forms.Button PrintSeans;
        private System.Windows.Forms.Button BtnPrintAll;
        private System.Windows.Forms.Label EnterAdm;
    }
}
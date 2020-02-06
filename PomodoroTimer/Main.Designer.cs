namespace PomodoroTimer
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormClose = new System.Windows.Forms.Button();
            this.BorderRight = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.LabelPomodoroTimer = new System.Windows.Forms.Label();
            this.LabelByWildu = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormClose
            // 
            this.FormClose.BackColor = System.Drawing.Color.Transparent;
            this.FormClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.FormClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormClose.Location = new System.Drawing.Point(466, 12);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(22, 22);
            this.FormClose.TabIndex = 0;
            this.FormClose.Text = "X";
            this.FormClose.UseVisualStyleBackColor = false;
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click);
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.Black;
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(499, 0);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(1, 320);
            this.BorderRight.TabIndex = 1;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.Black;
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 319);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(499, 1);
            this.BorderBottom.TabIndex = 2;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.Black;
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(1, 319);
            this.BorderLeft.TabIndex = 3;
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.Black;
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(1, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(498, 1);
            this.BorderTop.TabIndex = 4;
            // 
            // LabelPomodoroTimer
            // 
            this.LabelPomodoroTimer.AutoSize = true;
            this.LabelPomodoroTimer.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPomodoroTimer.Location = new System.Drawing.Point(279, 268);
            this.LabelPomodoroTimer.Name = "LabelPomodoroTimer";
            this.LabelPomodoroTimer.Size = new System.Drawing.Size(192, 30);
            this.LabelPomodoroTimer.TabIndex = 5;
            this.LabelPomodoroTimer.Text = "PomodoroTimer";
            // 
            // LabelByWildu
            // 
            this.LabelByWildu.AutoSize = true;
            this.LabelByWildu.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelByWildu.Location = new System.Drawing.Point(433, 298);
            this.LabelByWildu.Name = "LabelByWildu";
            this.LabelByWildu.Size = new System.Drawing.Size(55, 13);
            this.LabelByWildu.TabIndex = 6;
            this.LabelByWildu.Text = "by Wildu";
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Segoe UI Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelTimer.Location = new System.Drawing.Point(145, 108);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(219, 89);
            this.LabelTimer.TabIndex = 7;
            this.LabelTimer.Text = "00:00";
            this.LabelTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer_MouseDown);
            // 
            // FormMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(61)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.ControlBox = false;
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.LabelByWildu);
            this.Controls.Add(this.LabelPomodoroTimer);
            this.Controls.Add(this.BorderTop);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.FormClose);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "PomodoroTimer - by Wildu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormClose;
        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Label LabelPomodoroTimer;
        private System.Windows.Forms.Label LabelByWildu;
        private System.Windows.Forms.Label LabelTimer;

    }
}


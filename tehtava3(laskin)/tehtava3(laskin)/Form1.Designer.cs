namespace tehtava3_laskin_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LukuYksiTB = new TextBox();
            LukuKaksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            SuspendLayout();
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 16F);
            LukuYksiTB.Location = new Point(0, 3);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(100, 36);
            LukuYksiTB.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 16F);
            LukuKaksiTB.Location = new Point(154, 2);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(100, 36);
            LukuKaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 16F);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(106, 0);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(42, 38);
            LaskutoimitusCB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(260, 3);
            label1.Name = "label1";
            label1.Size = new Size(28, 30);
            label1.TabIndex = 4;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F);
            VastausLB.Location = new Point(294, 6);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(26, 30);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "X";
            VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 16F);
            LaskeBT.Location = new Point(343, 0);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(96, 38);
            LaskeBT.TabIndex = 6;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LukuYksiTB);
            Name = "Form1";
            Text = "Yksinkertainen nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuYksiTB;
        private TextBox LukuKaksiTB;
        private ComboBox LaskutoimitusCB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}

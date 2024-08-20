namespace Tehtava2
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
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaTB = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16F);
            OtsikkoLB.Location = new Point(0, 0);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(293, 35);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16F);
            TulostusLB.Location = new Point(0, 35);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(91, 35);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16F);
            ViestiTB.Location = new Point(299, 0);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(227, 36);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaTB
            // 
            TulostaTB.FlatStyle = FlatStyle.System;
            TulostaTB.Location = new Point(451, 47);
            TulostaTB.Name = "TulostaTB";
            TulostaTB.Size = new Size(75, 23);
            TulostaTB.TabIndex = 3;
            TulostaTB.Text = "Tulosta teksti";
            TulostaTB.UseVisualStyleBackColor = true;
            TulostaTB.Click += TulostaTB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaTB);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Form1";
            Text = "Harjoitus2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaTB;
    }
}

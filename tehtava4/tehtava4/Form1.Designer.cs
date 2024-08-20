namespace tehtava4
{
    partial class Ikalaskuri
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
            SyntymaAikaDT = new DateTimePicker();
            LaskeikaBT = new Button();
            VuosinaLB = new Label();
            KuukausinaLB = new Label();
            PaivinaLB = new Label();
            TunteinaLB = new Label();
            MinuutteinaLB = new Label();
            SekunteinaLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Location = new Point(37, 40);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(222, 23);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeikaBT
            // 
            LaskeikaBT.Location = new Point(298, 40);
            LaskeikaBT.Name = "LaskeikaBT";
            LaskeikaBT.Size = new Size(75, 23);
            LaskeikaBT.TabIndex = 1;
            LaskeikaBT.Text = "Laske ikä";
            LaskeikaBT.UseVisualStyleBackColor = true;
            LaskeikaBT.Click += LaskeikaBT_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Location = new Point(37, 95);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(49, 15);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuosina";
            VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Location = new Point(37, 126);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(68, 15);
            KuukausinaLB.TabIndex = 3;
            KuukausinaLB.Text = "Kuukausina";
            KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Location = new Point(37, 159);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(45, 15);
            PaivinaLB.TabIndex = 4;
            PaivinaLB.Text = "Päivinä";
            PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Location = new Point(237, 95);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(53, 15);
            TunteinaLB.TabIndex = 5;
            TunteinaLB.Text = "Tunteina";
            TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Location = new Point(237, 126);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(72, 15);
            MinuutteinaLB.TabIndex = 6;
            MinuutteinaLB.Text = "Minuutteina";
            MinuutteinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Location = new Point(237, 159);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(65, 15);
            SekunteinaLB.TabIndex = 7;
            SekunteinaLB.Text = "Sekunteina";
            SekunteinaLB.Visible = false;
            // 
            // Ikalaskuri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 266);
            Controls.Add(SekunteinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(LaskeikaBT);
            Controls.Add(SyntymaAikaDT);
            Name = "Ikalaskuri";
            Text = "Form1";
            Load += Ikälaskuri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeikaBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekunteinaLB;
    }
}

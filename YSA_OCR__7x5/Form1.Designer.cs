namespace YSA_OCR__7x5
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
            panel1 = new Panel();
            btnEgit = new Button();
            btnTanimla = new Button();
            btnTemizle = new Button();
            lblHataOrani = new Label();
            lblOutputA = new Label();
            btnCizgileriKaldir = new Button();
            lblOutputB = new Label();
            lblOutputC = new Label();
            lblOutputD = new Label();
            lblOutputE = new Label();
            numHiddenNeurons = new NumericUpDown();
            label1 = new Label();
            txtLearningRate = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numHiddenNeurons).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 320);
            panel1.TabIndex = 0;
            // 
            // btnEgit
            // 
            btnEgit.Location = new Point(260, 30);
            btnEgit.Name = "btnEgit";
            btnEgit.Size = new Size(100, 40);
            btnEgit.TabIndex = 1;
            btnEgit.Text = "Eğit";
            btnEgit.UseVisualStyleBackColor = true;
            btnEgit.Click += btnEgit_Click;
            // 
            // btnTanimla
            // 
            btnTanimla.Location = new Point(260, 80);
            btnTanimla.Name = "btnTanimla";
            btnTanimla.Size = new Size(100, 40);
            btnTanimla.TabIndex = 2;
            btnTanimla.Text = "Tanımla";
            btnTanimla.UseVisualStyleBackColor = true;
            btnTanimla.Click += btnTanimla_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(260, 130);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(100, 40);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblHataOrani
            // 
            lblHataOrani.AutoSize = true;
            lblHataOrani.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHataOrani.Location = new Point(260, 230);
            lblHataOrani.Name = "lblHataOrani";
            lblHataOrani.Size = new Size(126, 28);
            lblHataOrani.TabIndex = 4;
            lblHataOrani.Text = "Hata Oranı: 0";
            // 
            // lblOutputA
            // 
            lblOutputA.AutoSize = true;
            lblOutputA.Location = new Point(260, 280);
            lblOutputA.Name = "lblOutputA";
            lblOutputA.Size = new Size(34, 20);
            lblOutputA.TabIndex = 5;
            lblOutputA.Text = "A: 0";
            // 
            // btnCizgileriKaldir
            // 
            btnCizgileriKaldir.Location = new Point(260, 180);
            btnCizgileriKaldir.Name = "btnCizgileriKaldir";
            btnCizgileriKaldir.Size = new Size(157, 40);
            btnCizgileriKaldir.TabIndex = 6;
            btnCizgileriKaldir.Text = "Çizgileri Kaldır";
            btnCizgileriKaldir.UseVisualStyleBackColor = true;
            btnCizgileriKaldir.Click += btnCizgileriKaldir_Click;
            // 
            // lblOutputB
            // 
            lblOutputB.AutoSize = true;
            lblOutputB.Location = new Point(327, 280);
            lblOutputB.Name = "lblOutputB";
            lblOutputB.Size = new Size(33, 20);
            lblOutputB.TabIndex = 7;
            lblOutputB.Text = "B: 0";
            // 
            // lblOutputC
            // 
            lblOutputC.AutoSize = true;
            lblOutputC.Location = new Point(402, 280);
            lblOutputC.Name = "lblOutputC";
            lblOutputC.Size = new Size(33, 20);
            lblOutputC.TabIndex = 8;
            lblOutputC.Text = "C: 0";
            // 
            // lblOutputD
            // 
            lblOutputD.AutoSize = true;
            lblOutputD.Location = new Point(472, 280);
            lblOutputD.Name = "lblOutputD";
            lblOutputD.Size = new Size(35, 20);
            lblOutputD.TabIndex = 9;
            lblOutputD.Text = "D: 0";
            // 
            // lblOutputE
            // 
            lblOutputE.AutoSize = true;
            lblOutputE.Location = new Point(544, 280);
            lblOutputE.Name = "lblOutputE";
            lblOutputE.Size = new Size(32, 20);
            lblOutputE.TabIndex = 10;
            lblOutputE.Text = "E: 0";
            // 
            // numHiddenNeurons
            // 
            numHiddenNeurons.Location = new Point(20, 360);
            numHiddenNeurons.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHiddenNeurons.Name = "numHiddenNeurons";
            numHiddenNeurons.Size = new Size(100, 27);
            numHiddenNeurons.TabIndex = 11;
            numHiddenNeurons.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 360);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 12;
            label1.Text = "Gizli Nöron Sayısı";
            // 
            // txtLearningRate
            // 
            txtLearningRate.Location = new Point(20, 415);
            txtLearningRate.Name = "txtLearningRate";
            txtLearningRate.Size = new Size(100, 27);
            txtLearningRate.TabIndex = 13;
            txtLearningRate.Text = "0,1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 418);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 14;
            label2.Text = "Öğrenme Oranı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 741);
            Controls.Add(label2);
            Controls.Add(txtLearningRate);
            Controls.Add(label1);
            Controls.Add(numHiddenNeurons);
            Controls.Add(lblOutputE);
            Controls.Add(lblOutputD);
            Controls.Add(lblOutputC);
            Controls.Add(lblOutputB);
            Controls.Add(btnCizgileriKaldir);
            Controls.Add(lblOutputA);
            Controls.Add(lblHataOrani);
            Controls.Add(btnTemizle);
            Controls.Add(btnTanimla);
            Controls.Add(btnEgit);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numHiddenNeurons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnEgit;
        private Button btnTanimla;
        private Button btnTemizle;
        private Label lblHataOrani;
        private Label lblOutputA;
        private Button btnCizgileriKaldir;
        private Label lblOutputB;
        private Label lblOutputC;
        private Label lblOutputD;
        private Label lblOutputE;
        private NumericUpDown numHiddenNeurons;
        private Label label1;
        private TextBox txtLearningRate;
        private Label label2;
    }
}

namespace Ozan_kumbara1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbParaSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKumbarayaAt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbKatla = new System.Windows.Forms.CheckBox();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbParaSec
            // 
            this.cmbParaSec.FormattingEnabled = true;
            this.cmbParaSec.Items.AddRange(new object[] {
            "5 kr",
            "10 kr",
            "25 kr",
            "50 kr",
            "1 TL",
            "5 TL",
            "10 TL",
            "20 TL",
            "50 TL",
            "100 TL"});
            this.cmbParaSec.Location = new System.Drawing.Point(63, 62);
            this.cmbParaSec.Name = "cmbParaSec";
            this.cmbParaSec.Size = new System.Drawing.Size(244, 24);
            this.cmbParaSec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(536, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // btnKumbarayaAt
            // 
            this.btnKumbarayaAt.Location = new System.Drawing.Point(63, 175);
            this.btnKumbarayaAt.Name = "btnKumbarayaAt";
            this.btnKumbarayaAt.Size = new System.Drawing.Size(244, 63);
            this.btnKumbarayaAt.TabIndex = 4;
            this.btnKumbarayaAt.Text = "KUMBARAYA AT";
            this.btnKumbarayaAt.UseVisualStyleBackColor = true;
            this.btnKumbarayaAt.Click += new System.EventHandler(this.btnKumbarayaAt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(541, 420);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 164);
            this.listBox1.TabIndex = 5;
            // 
            // cbKatla
            // 
            this.cbKatla.AutoSize = true;
            this.cbKatla.Location = new System.Drawing.Point(63, 111);
            this.cbKatla.Name = "cbKatla";
            this.cbKatla.Size = new System.Drawing.Size(74, 21);
            this.cbKatla.TabIndex = 6;
            this.cbKatla.Text = "KATLA";
            this.cbKatla.UseVisualStyleBackColor = true;
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(63, 286);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(244, 76);
            this.btnSalla.TabIndex = 7;
            this.btnSalla.Text = "SALLA";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnKir
            // 
            this.btnKir.Location = new System.Drawing.Point(63, 396);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(244, 76);
            this.btnKir.TabIndex = 8;
            this.btnKir.Text = "KUMBARAYI KIR";
            this.btnKir.UseVisualStyleBackColor = true;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(63, 508);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(244, 76);
            this.btnYapistir.TabIndex = 9;
            this.btnYapistir.Text = "KUMBARAYI YAPIŞTIR";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 599);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.cbKatla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKumbarayaAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbParaSec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbParaSec;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Button btnKumbarayaAt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cbKatla;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.Button btnYapistir;
    }
}


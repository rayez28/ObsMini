namespace OBSMini
{
    partial class FormOgretmen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.btnOgrenciNotlari = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(12, 293);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(92, 45);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(12, 22);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(121, 24);
            this.cmbOgrenciler.TabIndex = 2;
            // 
            // btnOgrenciNotlari
            // 
            this.btnOgrenciNotlari.Location = new System.Drawing.Point(328, 22);
            this.btnOgrenciNotlari.Name = "btnOgrenciNotlari";
            this.btnOgrenciNotlari.Size = new System.Drawing.Size(102, 45);
            this.btnOgrenciNotlari.TabIndex = 3;
            this.btnOgrenciNotlari.Text = "Notlar";
            this.btnOgrenciNotlari.UseVisualStyleBackColor = true;
            this.btnOgrenciNotlari.Click += new System.EventHandler(this.btnOgrenciNotlari_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Devamsızlık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOgrenciNotlari);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Name = "FormOgretmen";
            this.Text = "FormOgretmen";
            this.Load += new System.EventHandler(this.FormOgretmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.Button btnOgrenciNotlari;
        private System.Windows.Forms.Button button1;
    }
}
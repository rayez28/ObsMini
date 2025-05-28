namespace OBSMini
{
    partial class FormDevamOgrt
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
            this.dataGridViewDevamsizlik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.comboBoxDurum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevamsizlik)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevamsizlik
            // 
            this.dataGridViewDevamsizlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevamsizlik.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDevamsizlik.Name = "dataGridViewDevamsizlik";
            this.dataGridViewDevamsizlik.RowHeadersWidth = 51;
            this.dataGridViewDevamsizlik.RowTemplate.Height = 24;
            this.dataGridViewDevamsizlik.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewDevamsizlik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(799, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ders::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1015, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durum::";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(804, 248);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(114, 45);
            this.buttonEkle.TabIndex = 5;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(804, 206);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTarih.TabIndex = 6;
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Location = new System.Drawing.Point(804, 55);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(179, 37);
            this.comboBoxDersler.TabIndex = 7;
            this.comboBoxDersler.SelectedIndexChanged += new System.EventHandler(this.comboBoxDersler_SelectedIndexChanged);
            // 
            // comboBoxDurum
            // 
            this.comboBoxDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDurum.FormattingEnabled = true;
            this.comboBoxDurum.Location = new System.Drawing.Point(1010, 55);
            this.comboBoxDurum.Name = "comboBoxDurum";
            this.comboBoxDurum.Size = new System.Drawing.Size(148, 37);
            this.comboBoxDurum.TabIndex = 8;
            // 
            // FormDevamOgrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 535);
            this.Controls.Add(this.comboBoxDurum);
            this.Controls.Add(this.comboBoxDersler);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDevamsizlik);
            this.Name = "FormDevamOgrt";
            this.Text = "FormDevamOgrt";
            this.Load += new System.EventHandler(this.FormDevamOgrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevamsizlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevamsizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.ComboBox comboBoxDersler;
        private System.Windows.Forms.ComboBox comboBoxDurum;
    }
}
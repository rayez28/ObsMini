namespace OBSMini
{
    partial class FormNotlarOgrt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNotGuncelle_Click = new System.Windows.Forms.Button();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNotGuncelle_Click
            // 
            this.btnNotGuncelle_Click.Location = new System.Drawing.Point(649, 23);
            this.btnNotGuncelle_Click.Name = "btnNotGuncelle_Click";
            this.btnNotGuncelle_Click.Size = new System.Drawing.Size(109, 45);
            this.btnNotGuncelle_Click.TabIndex = 1;
            this.btnNotGuncelle_Click.Text = "Düzenle";
            this.btnNotGuncelle_Click.UseVisualStyleBackColor = true;
            this.btnNotGuncelle_Click.Click += new System.EventHandler(this.btnNotGuncelle_Click_Click);
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(635, 328);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(109, 45);
            this.btnNotEkle.TabIndex = 2;
            this.btnNotEkle.Text = "Ders Notu Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // txtVize
            // 
            this.txtVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVize.Location = new System.Drawing.Point(723, 201);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(123, 34);
            this.txtVize.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFinal.Location = new System.Drawing.Point(723, 254);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(123, 34);
            this.txtFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(646, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vize::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(646, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Final::";
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Location = new System.Drawing.Point(888, 209);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDersler.TabIndex = 7;
            this.comboBoxDersler.SelectedIndexChanged += new System.EventHandler(this.comboBoxDersler_SelectedIndexChanged);
            // 
            // FormNotlarOgrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 597);
            this.Controls.Add(this.comboBoxDersler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.btnNotGuncelle_Click);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormNotlarOgrt";
            this.Text = "FormNotlarOgrt";
            this.Load += new System.EventHandler(this.FormNotlarOgrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNotGuncelle_Click;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDersler;
    }
}
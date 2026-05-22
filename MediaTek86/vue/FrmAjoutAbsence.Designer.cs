namespace MediaTek86.vue
{
    partial class FrmAjoutAbsence
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPersonnel = new System.Windows.Forms.ComboBox();
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif";
            // 
            // cmbPersonnel
            // 
            this.cmbPersonnel.FormattingEnabled = true;
            this.cmbPersonnel.Location = new System.Drawing.Point(390, 104);
            this.cmbPersonnel.Name = "cmbPersonnel";
            this.cmbPersonnel.Size = new System.Drawing.Size(160, 24);
            this.cmbPersonnel.TabIndex = 4;
            // 
            // dtDebut
            // 
            this.dtDebut.Location = new System.Drawing.Point(345, 216);
            this.dtDebut.Name = "dtDebut";
            this.dtDebut.Size = new System.Drawing.Size(260, 22);
            this.dtDebut.TabIndex = 5;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(345, 273);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(260, 22);
            this.dtFin.TabIndex = 6;
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(390, 156);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(160, 24);
            this.cmbMotif.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(279, 341);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(160, 35);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmAjoutAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbMotif);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtDebut);
            this.Controls.Add(this.cmbPersonnel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmAjoutAbsence";
            this.Text = "FrmAjoutAbsence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPersonnel;
        private System.Windows.Forms.DateTimePicker dtDebut;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.Button btnAjouter;
    }
}
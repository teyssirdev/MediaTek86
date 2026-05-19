namespace MediaTek86.vue
{
    partial class FrmAjoutPersonnel
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(385, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(127, 22);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(385, 139);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(127, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(385, 187);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(127, 22);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(385, 233);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(127, 22);
            this.txtMail.TabIndex = 8;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(385, 282);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(127, 24);
            this.cmbService.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(286, 362);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(126, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmAjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutPersonnel";
            this.Text = "FrmAjoutPersonnel";
            this.Load += new System.EventHandler(this.FrmAjoutPersonnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Button btnAjouter;
    }
}
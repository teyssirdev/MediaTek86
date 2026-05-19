namespace MediaTek86.vue
{
    partial class FrmAccueil
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
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MediaTek86 - Gestion du personnel";
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Location = new System.Drawing.Point(53, 88);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(173, 23);
            this.btnPersonnel.TabIndex = 1;
            this.btnPersonnel.Text = "Gestion du personnel\r\n";
            this.btnPersonnel.UseVisualStyleBackColor = true;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(332, 88);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(189, 23);
            this.btnAbsences.TabIndex = 2;
            this.btnAbsences.Text = "Gestion des absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(623, 88);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.label1);
            this.Name = "FrmAccueil";
            this.Text = "FrmAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnQuitter;
    }
}
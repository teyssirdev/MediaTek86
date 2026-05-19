namespace MediaTek86.vue
{
    partial class FrmConnexion
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(208, 143);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login\r\n";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(208, 205);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(89, 16);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Mot de passe";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(356, 143);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(356, 199);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(276, 277);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(86, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion\r\n";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLogin);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnConnexion;
    }
}
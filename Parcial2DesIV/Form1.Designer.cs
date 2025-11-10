namespace Parcial2DesIV
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dgtPrueba = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(271, 321);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(271, 367);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 22);
            this.txtContrasena.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(429, 347);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dgtPrueba
            // 
            this.dgtPrueba.AllowUserToAddRows = false;
            this.dgtPrueba.AllowUserToDeleteRows = false;
            this.dgtPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtPrueba.Location = new System.Drawing.Point(86, 33);
            this.dgtPrueba.Name = "dgtPrueba";
            this.dgtPrueba.ReadOnly = true;
            this.dgtPrueba.RowHeadersWidth = 51;
            this.dgtPrueba.RowTemplate.Height = 24;
            this.dgtPrueba.Size = new System.Drawing.Size(622, 282);
            this.dgtPrueba.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgtPrueba);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Text = "Pruebas";
            ((System.ComponentModel.ISupportInitialize)(this.dgtPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dgtPrueba;
    }
}


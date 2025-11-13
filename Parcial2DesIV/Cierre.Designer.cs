namespace Parcial2DesIV
{
    partial class Cierre
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
            this.lblCerrarSesionMensaje = new System.Windows.Forms.Label();
            this.btnCerrarSesionSi = new System.Windows.Forms.Button();
            this.btnCerrarSesionNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCerrarSesionMensaje
            // 
            this.lblCerrarSesionMensaje.AutoSize = true;
            this.lblCerrarSesionMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesionMensaje.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesionMensaje.Location = new System.Drawing.Point(136, 59);
            this.lblCerrarSesionMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesionMensaje.Name = "lblCerrarSesionMensaje";
            this.lblCerrarSesionMensaje.Size = new System.Drawing.Size(239, 25);
            this.lblCerrarSesionMensaje.TabIndex = 0;
            this.lblCerrarSesionMensaje.Text = "MensajeCerrarSesion";
            // 
            // btnCerrarSesionSi
            // 
            this.btnCerrarSesionSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesionSi.Location = new System.Drawing.Point(93, 208);
            this.btnCerrarSesionSi.Name = "btnCerrarSesionSi";
            this.btnCerrarSesionSi.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesionSi.TabIndex = 1;
            this.btnCerrarSesionSi.Text = "Si";
            this.btnCerrarSesionSi.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesionNo
            // 
            this.btnCerrarSesionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesionNo.Location = new System.Drawing.Point(334, 208);
            this.btnCerrarSesionNo.Name = "btnCerrarSesionNo";
            this.btnCerrarSesionNo.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesionNo.TabIndex = 2;
            this.btnCerrarSesionNo.Text = "No";
            this.btnCerrarSesionNo.UseVisualStyleBackColor = true;
            // 
            // Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnCerrarSesionNo);
            this.Controls.Add(this.btnCerrarSesionSi);
            this.Controls.Add(this.lblCerrarSesionMensaje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cierre";
            this.Text = "Cierre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCerrarSesionMensaje;
        private System.Windows.Forms.Button btnCerrarSesionSi;
        private System.Windows.Forms.Button btnCerrarSesionNo;
    }
}
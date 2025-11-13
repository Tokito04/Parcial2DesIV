namespace Parcial2DesIV
{
    partial class FinalForm
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
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.Location = new System.Drawing.Point(48, 35);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(138, 28);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Destinatario: ";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(48, 74);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(159, 28);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto Enviado: ";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(48, 115);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(155, 28);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Cuenta Origen: ";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(48, 159);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(188, 28);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Cuenta de destino: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(48, 199);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 28);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha: ";
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblDestinatario);
            this.Name = "FinalForm";
            this.Text = "ResultadoTransaccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblFecha;
    }
}
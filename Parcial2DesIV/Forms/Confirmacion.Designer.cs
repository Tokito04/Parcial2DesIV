namespace Parcial2DesIV
{
    partial class Confirmacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumeroCuentaOrigen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumeroCuentaDestino = new System.Windows.Forms.Label();
            this.lblMontoEnviar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto a enviar";
            // 
            // lblNumeroCuentaOrigen
            // 
            this.lblNumeroCuentaOrigen.AutoSize = true;
            this.lblNumeroCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuentaOrigen.Location = new System.Drawing.Point(20, 121);
            this.lblNumeroCuentaOrigen.Name = "lblNumeroCuentaOrigen";
            this.lblNumeroCuentaOrigen.Size = new System.Drawing.Size(236, 20);
            this.lblNumeroCuentaOrigen.TabIndex = 4;
            this.lblNumeroCuentaOrigen.Text = "Placeholder numero de cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmación de Transferencia";
            // 
            // lblNumeroCuentaDestino
            // 
            this.lblNumeroCuentaDestino.AutoSize = true;
            this.lblNumeroCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuentaDestino.Location = new System.Drawing.Point(332, 121);
            this.lblNumeroCuentaDestino.Name = "lblNumeroCuentaDestino";
            this.lblNumeroCuentaDestino.Size = new System.Drawing.Size(255, 20);
            this.lblNumeroCuentaDestino.TabIndex = 6;
            this.lblNumeroCuentaDestino.Text = "Place holder numero de cuenta 2";
            // 
            // lblMontoEnviar
            // 
            this.lblMontoEnviar.AutoSize = true;
            this.lblMontoEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoEnviar.Location = new System.Drawing.Point(20, 226);
            this.lblMontoEnviar.Name = "lblMontoEnviar";
            this.lblMontoEnviar.Size = new System.Drawing.Size(148, 20);
            this.lblMontoEnviar.TabIndex = 7;
            this.lblMontoEnviar.Text = "Placeholder monto";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(25, 389);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 34);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Editar datos";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(200, 389);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 34);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2DesIV.Properties.Resources.bobcholos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 492);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMontoEnviar);
            this.Controls.Add(this.lblNumeroCuentaDestino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumeroCuentaOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Confirmacion";
            this.Text = "Confirmación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumeroCuentaOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumeroCuentaDestino;
        private System.Windows.Forms.Label lblMontoEnviar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
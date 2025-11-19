namespace Parcial2DesIV
{
    partial class Transacción
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
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnSiguienteConfirmacion = new System.Windows.Forms.Button();
            this.lblSimboloDolar = new System.Windows.Forms.Label();
            this.cmbCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaDestino.Location = new System.Drawing.Point(37, 197);
            this.txtCuentaDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.Size = new System.Drawing.Size(345, 28);
            this.txtCuentaDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el numero de la cuenta a la que quiere enviar";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(31, 277);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(300, 25);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Ingrese el monto que desa enviar";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(71, 329);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(311, 28);
            this.txtMonto.TabIndex = 4;
            // 
            // btnSiguienteConfirmacion
            // 
            this.btnSiguienteConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteConfirmacion.Location = new System.Drawing.Point(37, 405);
            this.btnSiguienteConfirmacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguienteConfirmacion.Name = "btnSiguienteConfirmacion";
            this.btnSiguienteConfirmacion.Size = new System.Drawing.Size(135, 37);
            this.btnSiguienteConfirmacion.TabIndex = 5;
            this.btnSiguienteConfirmacion.Text = "Siguiente";
            this.btnSiguienteConfirmacion.UseVisualStyleBackColor = true;
            // 
            // lblSimboloDolar
            // 
            this.lblSimboloDolar.AutoSize = true;
            this.lblSimboloDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloDolar.Location = new System.Drawing.Point(37, 329);
            this.lblSimboloDolar.Name = "lblSimboloDolar";
            this.lblSimboloDolar.Size = new System.Drawing.Size(32, 24);
            this.lblSimboloDolar.TabIndex = 7;
            this.lblSimboloDolar.Text = "B./";
            // 
            // cmbCuentaOrigen
            // 
            this.cmbCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCuentaOrigen.FormattingEnabled = true;
            this.cmbCuentaOrigen.Location = new System.Drawing.Point(36, 93);
            this.cmbCuentaOrigen.Name = "cmbCuentaOrigen";
            this.cmbCuentaOrigen.Size = new System.Drawing.Size(346, 30);
            this.cmbCuentaOrigen.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la cuenta de Origen";
            // 
            // Transacción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2DesIV.Properties.Resources.fondoPasaplata;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 615);
            this.Controls.Add(this.cmbCuentaOrigen);
            this.Controls.Add(this.lblSimboloDolar);
            this.Controls.Add(this.btnSiguienteConfirmacion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuentaDestino);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transacción";
            this.Text = "Transacción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnSiguienteConfirmacion;
        private System.Windows.Forms.Label lblSimboloDolar;
        private System.Windows.Forms.ComboBox cmbCuentaOrigen;
        private System.Windows.Forms.Label label2;
    }
}
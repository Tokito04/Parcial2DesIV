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
            this.lblCuentaOrigen = new System.Windows.Forms.Label();
            this.cboCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnSiguienteConfirmacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCuentaOrigen
            // 
            this.lblCuentaOrigen.AutoSize = true;
            this.lblCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaOrigen.Location = new System.Drawing.Point(43, 27);
            this.lblCuentaOrigen.Name = "lblCuentaOrigen";
            this.lblCuentaOrigen.Size = new System.Drawing.Size(143, 29);
            this.lblCuentaOrigen.TabIndex = 0;
            this.lblCuentaOrigen.Text = "Seleccione cuenta origen:";
            // 
            // cboCuentaOrigen
            // 
            this.cboCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCuentaOrigen.FormattingEnabled = true;
            this.cboCuentaOrigen.Location = new System.Drawing.Point(48, 63);
            this.cboCuentaOrigen.Name = "cboCuentaOrigen";
            this.cboCuentaOrigen.Size = new System.Drawing.Size(388, 34);
            this.cboCuentaOrigen.TabIndex = 11;
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaDestino.Location = new System.Drawing.Point(48, 184);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.Size = new System.Drawing.Size(388, 32);
            this.txtCuentaDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el numero de la cuenta a la que quiere enviar";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(43, 248);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(370, 29);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Ingrese el monto que desa enviar";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(48, 295);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(388, 32);
            this.txtMonto.TabIndex = 4;
            // 
            // btnSiguienteConfirmacion
            // 
            this.btnSiguienteConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteConfirmacion.Location = new System.Drawing.Point(48, 354);
            this.btnSiguienteConfirmacion.Name = "btnSiguienteConfirmacion";
            this.btnSiguienteConfirmacion.Size = new System.Drawing.Size(151, 46);
            this.btnSiguienteConfirmacion.TabIndex = 5;
            this.btnSiguienteConfirmacion.Text = "Siguiente";
            this.btnSiguienteConfirmacion.UseVisualStyleBackColor = true;
            // 
            // Transacción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2DesIV.Properties.Resources.fondoPasaplata;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.btnSiguienteConfirmacion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuentaDestino);
            this.Controls.Add(this.cboCuentaOrigen);
            this.Controls.Add(this.lblCuentaOrigen);
            this.Name = "Transacción";
            this.Text = "Transacción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuentaOrigen;
        private System.Windows.Forms.ComboBox cboCuentaOrigen;
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnSiguienteConfirmacion;
    }
}
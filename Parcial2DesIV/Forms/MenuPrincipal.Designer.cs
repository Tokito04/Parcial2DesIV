namespace Parcial2DesIV
{
    partial class MenuPrincipal
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(45, 42);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(124, 29);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Placeholder";
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaccion.Location = new System.Drawing.Point(37, 381);
            this.btnTransaccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(153, 44);
            this.btnTransaccion.TabIndex = 1;
            this.btnTransaccion.Text = "Transacciones";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(209, 382);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(97, 44);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.Location = new System.Drawing.Point(335, 381);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(175, 44);
            this.btnCerrarSesión.TabIndex = 3;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(33, 92);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.RowTemplate.Height = 24;
            this.dgvCuentas.Size = new System.Drawing.Size(630, 267);
            this.dgvCuentas.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2DesIV.Properties.Resources.fondoMenu;
            this.ClientSize = new System.Drawing.Size(777, 483);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.lblNombreUsuario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.DataGridView dgvCuentas;
    }
}
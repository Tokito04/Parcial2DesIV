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
            this.cboCuentas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(34, 34);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(100, 23);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Placeholder";
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaccion.Location = new System.Drawing.Point(25, 169);
            this.btnTransaccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(115, 36);
            this.btnTransaccion.TabIndex = 1;
            this.btnTransaccion.Text = "Transacciones";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(154, 170);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(73, 36);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.Location = new System.Drawing.Point(248, 169);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(131, 36);
            this.btnCerrarSesión.TabIndex = 3;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // cboCuentas
            // 
            this.cboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboCuentas.FormattingEnabled = true;
            this.cboCuentas.Location = new System.Drawing.Point(25, 79);
            this.cboCuentas.Margin = new System.Windows.Forms.Padding(2);
            this.cboCuentas.Name = "cboCuentas";
            this.cboCuentas.Size = new System.Drawing.Size(291, 24);
            this.cboCuentas.TabIndex = 4;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial2DesIV.Properties.Resources.fondoMenu;
            this.ClientSize = new System.Drawing.Size(583, 237);
            this.Controls.Add(this.cboCuentas);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.lblNombreUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.ComboBox cboCuentas;
    }
}
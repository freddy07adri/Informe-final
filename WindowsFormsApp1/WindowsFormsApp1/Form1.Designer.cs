namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.grpInstrucciones = new System.Windows.Forms.GroupBox();
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInst1 = new System.Windows.Forms.Label();
            this.lblInst2 = new System.Windows.Forms.Label();
            this.lblInst3 = new System.Windows.Forms.Label();
            this.grpPieDePagina = new System.Windows.Forms.GroupBox();
            this.lblFirma = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblCom2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpInstrucciones.SuspendLayout();
            this.grpDetalles.SuspendLayout();
            this.grpPieDePagina.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::WindowsFormsApp1.Properties.Resources.Captura_de_pantalla_2024_10_29_195128;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(538, 344);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(766, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Factura";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSubtitulo.Location = new System.Drawing.Point(757, 57);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(135, 24);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Copia Cliente";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblID.Location = new System.Drawing.Point(584, 134);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(626, 134);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFecha.Location = new System.Drawing.Point(573, 185);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha :";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(645, 181);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 22);
            this.txtFecha.TabIndex = 6;
            // 
            // grpInstrucciones
            // 
            this.grpInstrucciones.Controls.Add(this.lblInst3);
            this.grpInstrucciones.Controls.Add(this.lblInst2);
            this.grpInstrucciones.Controls.Add(this.lblInst1);
            this.grpInstrucciones.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInstrucciones.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpInstrucciones.Location = new System.Drawing.Point(506, 209);
            this.grpInstrucciones.Name = "grpInstrucciones";
            this.grpInstrucciones.Size = new System.Drawing.Size(547, 126);
            this.grpInstrucciones.TabIndex = 7;
            this.grpInstrucciones.TabStop = false;
            this.grpInstrucciones.Text = "Instrucciones";
            this.grpInstrucciones.Enter += new System.EventHandler(this.grpInstrucciones_Enter);
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.btnCerrar);
            this.grpDetalles.Controls.Add(this.btnLimpiar);
            this.grpDetalles.Controls.Add(this.btnCalcular);
            this.grpDetalles.Controls.Add(this.lblIVA);
            this.grpDetalles.Controls.Add(this.txtTotal);
            this.grpDetalles.Controls.Add(this.lblTotal);
            this.grpDetalles.Controls.Add(this.txtIva);
            this.grpDetalles.Controls.Add(this.txtMonto);
            this.grpDetalles.Controls.Add(this.lblMonto);
            this.grpDetalles.Controls.Add(this.txtNombre);
            this.grpDetalles.Controls.Add(this.lblNombre);
            this.grpDetalles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpDetalles.Location = new System.Drawing.Point(12, 373);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(538, 308);
            this.grpDetalles.TabIndex = 8;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombre.Location = new System.Drawing.Point(40, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(309, 42);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(50, 16);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto :";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(366, 41);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(359, 95);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 22);
            this.txtIva.TabIndex = 5;
            this.txtIva.TextChanged += new System.EventHandler(this.txtsubTotal_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(309, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(359, 158);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(309, 95);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(34, 16);
            this.lblIVA.TabIndex = 8;
            this.lblIVA.Text = "IVA :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(43, 158);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInst1
            // 
            this.lblInst1.AutoSize = true;
            this.lblInst1.Location = new System.Drawing.Point(11, 18);
            this.lblInst1.Name = "lblInst1";
            this.lblInst1.Size = new System.Drawing.Size(430, 16);
            this.lblInst1.TabIndex = 0;
            this.lblInst1.Text = "Los metodos de pago aceptados son: por efectivo tarjetas o transferencia";
            // 
            // lblInst2
            // 
            this.lblInst2.AutoSize = true;
            this.lblInst2.Location = new System.Drawing.Point(11, 34);
            this.lblInst2.Name = "lblInst2";
            this.lblInst2.Size = new System.Drawing.Size(442, 16);
            this.lblInst2.TabIndex = 1;
            this.lblInst2.Text = "Los rembolsos solo se efectuaran en un limite de 24h, con factura en mano";
            this.lblInst2.Click += new System.EventHandler(this.lblInst2_Click);
            // 
            // lblInst3
            // 
            this.lblInst3.AutoSize = true;
            this.lblInst3.Location = new System.Drawing.Point(6, 50);
            this.lblInst3.Name = "lblInst3";
            this.lblInst3.Size = new System.Drawing.Size(466, 16);
            this.lblInst3.TabIndex = 2;
            this.lblInst3.Text = "Se llega a tener un percanse en su servicio tiene el derecho de hacer una queja";
            // 
            // grpPieDePagina
            // 
            this.grpPieDePagina.Controls.Add(this.lblCom2);
            this.grpPieDePagina.Controls.Add(this.lblCom);
            this.grpPieDePagina.Controls.Add(this.txtComentario);
            this.grpPieDePagina.Controls.Add(this.lblComentario);
            this.grpPieDePagina.Controls.Add(this.txtFirma);
            this.grpPieDePagina.Controls.Add(this.lblFirma);
            this.grpPieDePagina.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPieDePagina.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpPieDePagina.Location = new System.Drawing.Point(577, 387);
            this.grpPieDePagina.Name = "grpPieDePagina";
            this.grpPieDePagina.Size = new System.Drawing.Size(476, 293);
            this.grpPieDePagina.TabIndex = 9;
            this.grpPieDePagina.TabStop = false;
            this.grpPieDePagina.Text = ".";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(13, 66);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(48, 16);
            this.lblFirma.TabIndex = 0;
            this.lblFirma.Text = "Firma: ";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(68, 60);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(100, 22);
            this.txtFirma.TabIndex = 1;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(234, 66);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(81, 16);
            this.lblComentario.TabIndex = 2;
            this.lblComentario.Text = "Comentario :";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(321, 60);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(100, 22);
            this.txtComentario.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(43, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(43, 253);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(13, 150);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(412, 16);
            this.lblCom.TabIndex = 4;
            this.lblCom.Text = "\"Atorizo al emisor a pagar el total indicado en esta segun el contrato \"";
            // 
            // lblCom2
            // 
            this.lblCom2.AutoSize = true;
            this.lblCom2.Location = new System.Drawing.Point(41, 176);
            this.lblCom2.Name = "lblCom2";
            this.lblCom2.Size = new System.Drawing.Size(339, 16);
            this.lblCom2.TabIndex = 5;
            this.lblCom2.Text = "\"que regula el uso ya sea de tarjetas o dinero en efectivo\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1072, 703);
            this.Controls.Add(this.grpPieDePagina);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpInstrucciones);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpInstrucciones.ResumeLayout(false);
            this.grpInstrucciones.PerformLayout();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.grpPieDePagina.ResumeLayout(false);
            this.grpPieDePagina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox grpInstrucciones;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblInst1;
        private System.Windows.Forms.Label lblInst2;
        private System.Windows.Forms.Label lblInst3;
        private System.Windows.Forms.GroupBox grpPieDePagina;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCom2;
        private System.Windows.Forms.Label lblCom;
    }
}


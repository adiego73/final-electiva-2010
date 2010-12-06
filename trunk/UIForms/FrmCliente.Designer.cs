namespace UIForms
{
    partial class FrmCliente
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
            this.dniLB = new System.Windows.Forms.Label();
            this.nombreLB = new System.Windows.Forms.Label();
            this.apellidoLB = new System.Windows.Forms.Label();
            this.direccionLB = new System.Windows.Forms.Label();
            this.telefonoLB = new System.Windows.Forms.Label();
            this.ciudadLB = new System.Windows.Forms.Label();
            this.ProvinciaLB = new System.Windows.Forms.Label();
            this.MailLB = new System.Windows.Forms.Label();
            this.abmClienteLB = new System.Windows.Forms.Label();
            this.dniTX = new System.Windows.Forms.TextBox();
            this.nombreTX = new System.Windows.Forms.TextBox();
            this.apellidoTX = new System.Windows.Forms.TextBox();
            this.direccionTX = new System.Windows.Forms.TextBox();
            this.telefonoTX = new System.Windows.Forms.TextBox();
            this.ciudadTX = new System.Windows.Forms.TextBox();
            this.provinciaTX = new System.Windows.Forms.TextBox();
            this.mailTX = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.tipoClienteGB = new System.Windows.Forms.GroupBox();
            this.especialRB = new System.Windows.Forms.RadioButton();
            this.comunRB = new System.Windows.Forms.RadioButton();
            this.bVerificar = new System.Windows.Forms.Button();
            this.errNombreLB = new System.Windows.Forms.Label();
            this.errApellidoLB = new System.Windows.Forms.Label();
            this.errDireccionLB = new System.Windows.Forms.Label();
            this.errTelefonoLB = new System.Windows.Forms.Label();
            this.errCiudadLB = new System.Windows.Forms.Label();
            this.errProvinciaLB = new System.Windows.Forms.Label();
            this.errDniLB = new System.Windows.Forms.Label();
            this.tipoClienteGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dniLB
            // 
            this.dniLB.AutoSize = true;
            this.dniLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dniLB.Location = new System.Drawing.Point(8, 79);
            this.dniLB.Name = "dniLB";
            this.dniLB.Size = new System.Drawing.Size(30, 13);
            this.dniLB.TabIndex = 0;
            this.dniLB.Text = "Dni:";
            // 
            // nombreLB
            // 
            this.nombreLB.AutoSize = true;
            this.nombreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nombreLB.Location = new System.Drawing.Point(8, 107);
            this.nombreLB.Name = "nombreLB";
            this.nombreLB.Size = new System.Drawing.Size(54, 13);
            this.nombreLB.TabIndex = 1;
            this.nombreLB.Text = "Nombre:";
            // 
            // apellidoLB
            // 
            this.apellidoLB.AutoSize = true;
            this.apellidoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.apellidoLB.Location = new System.Drawing.Point(8, 134);
            this.apellidoLB.Name = "apellidoLB";
            this.apellidoLB.Size = new System.Drawing.Size(56, 13);
            this.apellidoLB.TabIndex = 2;
            this.apellidoLB.Text = "Apellido:";
            // 
            // direccionLB
            // 
            this.direccionLB.AutoSize = true;
            this.direccionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.direccionLB.Location = new System.Drawing.Point(8, 160);
            this.direccionLB.Name = "direccionLB";
            this.direccionLB.Size = new System.Drawing.Size(65, 13);
            this.direccionLB.TabIndex = 3;
            this.direccionLB.Text = "Dirección:";
            // 
            // telefonoLB
            // 
            this.telefonoLB.AutoSize = true;
            this.telefonoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.telefonoLB.Location = new System.Drawing.Point(8, 186);
            this.telefonoLB.Name = "telefonoLB";
            this.telefonoLB.Size = new System.Drawing.Size(61, 13);
            this.telefonoLB.TabIndex = 4;
            this.telefonoLB.Text = "Teléfono:";
            // 
            // ciudadLB
            // 
            this.ciudadLB.AutoSize = true;
            this.ciudadLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ciudadLB.Location = new System.Drawing.Point(8, 212);
            this.ciudadLB.Name = "ciudadLB";
            this.ciudadLB.Size = new System.Drawing.Size(50, 13);
            this.ciudadLB.TabIndex = 5;
            this.ciudadLB.Text = "Ciudad:";
            // 
            // ProvinciaLB
            // 
            this.ProvinciaLB.AutoSize = true;
            this.ProvinciaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinciaLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProvinciaLB.Location = new System.Drawing.Point(8, 238);
            this.ProvinciaLB.Name = "ProvinciaLB";
            this.ProvinciaLB.Size = new System.Drawing.Size(64, 13);
            this.ProvinciaLB.TabIndex = 6;
            this.ProvinciaLB.Text = "Provincia:";
            // 
            // MailLB
            // 
            this.MailLB.AutoSize = true;
            this.MailLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MailLB.Location = new System.Drawing.Point(8, 264);
            this.MailLB.Name = "MailLB";
            this.MailLB.Size = new System.Drawing.Size(34, 13);
            this.MailLB.TabIndex = 7;
            this.MailLB.Text = "Mail:";
            // 
            // abmClienteLB
            // 
            this.abmClienteLB.AutoSize = true;
            this.abmClienteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abmClienteLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.abmClienteLB.Location = new System.Drawing.Point(104, 10);
            this.abmClienteLB.Name = "abmClienteLB";
            this.abmClienteLB.Size = new System.Drawing.Size(108, 20);
            this.abmClienteLB.TabIndex = 8;
            this.abmClienteLB.Text = "ABM Cliente";
            // 
            // dniTX
            // 
            this.dniTX.Location = new System.Drawing.Point(81, 79);
            this.dniTX.Name = "dniTX";
            this.dniTX.Size = new System.Drawing.Size(140, 20);
            this.dniTX.TabIndex = 9;
            // 
            // nombreTX
            // 
            this.nombreTX.Location = new System.Drawing.Point(81, 105);
            this.nombreTX.Name = "nombreTX";
            this.nombreTX.Size = new System.Drawing.Size(224, 20);
            this.nombreTX.TabIndex = 10;
            // 
            // apellidoTX
            // 
            this.apellidoTX.Location = new System.Drawing.Point(81, 130);
            this.apellidoTX.Name = "apellidoTX";
            this.apellidoTX.Size = new System.Drawing.Size(224, 20);
            this.apellidoTX.TabIndex = 11;
            // 
            // direccionTX
            // 
            this.direccionTX.Location = new System.Drawing.Point(81, 156);
            this.direccionTX.Name = "direccionTX";
            this.direccionTX.Size = new System.Drawing.Size(224, 20);
            this.direccionTX.TabIndex = 12;
            // 
            // telefonoTX
            // 
            this.telefonoTX.Location = new System.Drawing.Point(81, 182);
            this.telefonoTX.Name = "telefonoTX";
            this.telefonoTX.Size = new System.Drawing.Size(224, 20);
            this.telefonoTX.TabIndex = 13;
            // 
            // ciudadTX
            // 
            this.ciudadTX.Location = new System.Drawing.Point(81, 208);
            this.ciudadTX.Name = "ciudadTX";
            this.ciudadTX.Size = new System.Drawing.Size(224, 20);
            this.ciudadTX.TabIndex = 14;
            // 
            // provinciaTX
            // 
            this.provinciaTX.Location = new System.Drawing.Point(81, 234);
            this.provinciaTX.Name = "provinciaTX";
            this.provinciaTX.Size = new System.Drawing.Size(224, 20);
            this.provinciaTX.TabIndex = 15;
            // 
            // mailTX
            // 
            this.mailTX.Location = new System.Drawing.Point(81, 260);
            this.mailTX.Name = "mailTX";
            this.mailTX.Size = new System.Drawing.Size(224, 20);
            this.mailTX.TabIndex = 16;
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bGuardar.Location = new System.Drawing.Point(146, 286);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 17;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bCancelar.Location = new System.Drawing.Point(233, 286);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 18;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // tipoClienteGB
            // 
            this.tipoClienteGB.Controls.Add(this.especialRB);
            this.tipoClienteGB.Controls.Add(this.comunRB);
            this.tipoClienteGB.Location = new System.Drawing.Point(11, 32);
            this.tipoClienteGB.Name = "tipoClienteGB";
            this.tipoClienteGB.Size = new System.Drawing.Size(297, 39);
            this.tipoClienteGB.TabIndex = 20;
            this.tipoClienteGB.TabStop = false;
            // 
            // especialRB
            // 
            this.especialRB.AutoSize = true;
            this.especialRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialRB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.especialRB.Location = new System.Drawing.Point(145, 14);
            this.especialRB.Name = "especialRB";
            this.especialRB.Size = new System.Drawing.Size(116, 17);
            this.especialRB.TabIndex = 1;
            this.especialRB.Text = "Cliente Especial";
            this.especialRB.UseVisualStyleBackColor = true;
            // 
            // comunRB
            // 
            this.comunRB.AutoSize = true;
            this.comunRB.Checked = true;
            this.comunRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comunRB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comunRB.Location = new System.Drawing.Point(30, 14);
            this.comunRB.Name = "comunRB";
            this.comunRB.Size = new System.Drawing.Size(106, 17);
            this.comunRB.TabIndex = 0;
            this.comunRB.TabStop = true;
            this.comunRB.Text = "Cliente Común";
            this.comunRB.UseVisualStyleBackColor = true;
            // 
            // bVerificar
            // 
            this.bVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerificar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bVerificar.Location = new System.Drawing.Point(227, 77);
            this.bVerificar.Name = "bVerificar";
            this.bVerificar.Size = new System.Drawing.Size(81, 23);
            this.bVerificar.TabIndex = 19;
            this.bVerificar.Text = "Verificar";
            this.bVerificar.UseVisualStyleBackColor = true;
            this.bVerificar.Click += new System.EventHandler(this.bVerificar_Click);
            // 
            // errNombreLB
            // 
            this.errNombreLB.AutoSize = true;
            this.errNombreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errNombreLB.ForeColor = System.Drawing.Color.Red;
            this.errNombreLB.Location = new System.Drawing.Point(312, 107);
            this.errNombreLB.Name = "errNombreLB";
            this.errNombreLB.Size = new System.Drawing.Size(15, 13);
            this.errNombreLB.TabIndex = 22;
            this.errNombreLB.Text = "X";
            this.errNombreLB.Visible = false;
            // 
            // errApellidoLB
            // 
            this.errApellidoLB.AutoSize = true;
            this.errApellidoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errApellidoLB.ForeColor = System.Drawing.Color.Red;
            this.errApellidoLB.Location = new System.Drawing.Point(312, 133);
            this.errApellidoLB.Name = "errApellidoLB";
            this.errApellidoLB.Size = new System.Drawing.Size(15, 13);
            this.errApellidoLB.TabIndex = 23;
            this.errApellidoLB.Text = "X";
            this.errApellidoLB.Visible = false;
            // 
            // errDireccionLB
            // 
            this.errDireccionLB.AutoSize = true;
            this.errDireccionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDireccionLB.ForeColor = System.Drawing.Color.Red;
            this.errDireccionLB.Location = new System.Drawing.Point(312, 159);
            this.errDireccionLB.Name = "errDireccionLB";
            this.errDireccionLB.Size = new System.Drawing.Size(15, 13);
            this.errDireccionLB.TabIndex = 24;
            this.errDireccionLB.Text = "X";
            this.errDireccionLB.Visible = false;
            // 
            // errTelefonoLB
            // 
            this.errTelefonoLB.AutoSize = true;
            this.errTelefonoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errTelefonoLB.ForeColor = System.Drawing.Color.Red;
            this.errTelefonoLB.Location = new System.Drawing.Point(312, 185);
            this.errTelefonoLB.Name = "errTelefonoLB";
            this.errTelefonoLB.Size = new System.Drawing.Size(15, 13);
            this.errTelefonoLB.TabIndex = 25;
            this.errTelefonoLB.Text = "X";
            this.errTelefonoLB.Visible = false;
            // 
            // errCiudadLB
            // 
            this.errCiudadLB.AutoSize = true;
            this.errCiudadLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCiudadLB.ForeColor = System.Drawing.Color.Red;
            this.errCiudadLB.Location = new System.Drawing.Point(312, 211);
            this.errCiudadLB.Name = "errCiudadLB";
            this.errCiudadLB.Size = new System.Drawing.Size(15, 13);
            this.errCiudadLB.TabIndex = 26;
            this.errCiudadLB.Text = "X";
            this.errCiudadLB.Visible = false;
            // 
            // errProvinciaLB
            // 
            this.errProvinciaLB.AutoSize = true;
            this.errProvinciaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errProvinciaLB.ForeColor = System.Drawing.Color.Red;
            this.errProvinciaLB.Location = new System.Drawing.Point(312, 237);
            this.errProvinciaLB.Name = "errProvinciaLB";
            this.errProvinciaLB.Size = new System.Drawing.Size(15, 13);
            this.errProvinciaLB.TabIndex = 27;
            this.errProvinciaLB.Text = "X";
            this.errProvinciaLB.Visible = false;
            // 
            // errDniLB
            // 
            this.errDniLB.AutoSize = true;
            this.errDniLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDniLB.ForeColor = System.Drawing.Color.Red;
            this.errDniLB.Location = new System.Drawing.Point(312, 82);
            this.errDniLB.Name = "errDniLB";
            this.errDniLB.Size = new System.Drawing.Size(15, 13);
            this.errDniLB.TabIndex = 28;
            this.errDniLB.Text = "X";
            this.errDniLB.Visible = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(335, 318);
            this.Controls.Add(this.errDniLB);
            this.Controls.Add(this.errProvinciaLB);
            this.Controls.Add(this.errCiudadLB);
            this.Controls.Add(this.errTelefonoLB);
            this.Controls.Add(this.errDireccionLB);
            this.Controls.Add(this.errApellidoLB);
            this.Controls.Add(this.errNombreLB);
            this.Controls.Add(this.tipoClienteGB);
            this.Controls.Add(this.bVerificar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.mailTX);
            this.Controls.Add(this.provinciaTX);
            this.Controls.Add(this.ciudadTX);
            this.Controls.Add(this.telefonoTX);
            this.Controls.Add(this.direccionTX);
            this.Controls.Add(this.apellidoTX);
            this.Controls.Add(this.nombreTX);
            this.Controls.Add(this.dniTX);
            this.Controls.Add(this.abmClienteLB);
            this.Controls.Add(this.MailLB);
            this.Controls.Add(this.ProvinciaLB);
            this.Controls.Add(this.ciudadLB);
            this.Controls.Add(this.telefonoLB);
            this.Controls.Add(this.direccionLB);
            this.Controls.Add(this.apellidoLB);
            this.Controls.Add(this.nombreLB);
            this.Controls.Add(this.dniLB);
            this.Name = "FrmCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tipoClienteGB.ResumeLayout(false);
            this.tipoClienteGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dniLB;
        private System.Windows.Forms.Label nombreLB;
        private System.Windows.Forms.Label apellidoLB;
        private System.Windows.Forms.Label direccionLB;
        private System.Windows.Forms.Label telefonoLB;
        private System.Windows.Forms.Label ciudadLB;
        private System.Windows.Forms.Label ProvinciaLB;
        private System.Windows.Forms.Label MailLB;
        private System.Windows.Forms.Label abmClienteLB;
        private System.Windows.Forms.TextBox dniTX;
        private System.Windows.Forms.TextBox nombreTX;
        private System.Windows.Forms.TextBox apellidoTX;
        private System.Windows.Forms.TextBox direccionTX;
        private System.Windows.Forms.TextBox telefonoTX;
        private System.Windows.Forms.TextBox ciudadTX;
        private System.Windows.Forms.TextBox provinciaTX;
        private System.Windows.Forms.TextBox mailTX;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.GroupBox tipoClienteGB;
        private System.Windows.Forms.RadioButton especialRB;
        private System.Windows.Forms.RadioButton comunRB;
        private System.Windows.Forms.Button bVerificar;
        private System.Windows.Forms.Label errNombreLB;
        private System.Windows.Forms.Label errApellidoLB;
        private System.Windows.Forms.Label errDireccionLB;
        private System.Windows.Forms.Label errTelefonoLB;
        private System.Windows.Forms.Label errCiudadLB;
        private System.Windows.Forms.Label errProvinciaLB;
        private System.Windows.Forms.Label errDniLB;
    }
}
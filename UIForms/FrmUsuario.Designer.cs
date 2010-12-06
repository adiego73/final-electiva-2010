namespace UIForms
{
    partial class FrmUsuario
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
            this.tituloLB = new System.Windows.Forms.Label();
            this.errContraseniaLB = new System.Windows.Forms.Label();
            this.errUsuarioLB = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.contraseniaTX = new System.Windows.Forms.TextBox();
            this.usuarioTX = new System.Windows.Forms.TextBox();
            this.contraseniaLB = new System.Windows.Forms.Label();
            this.usuarioLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLB
            // 
            this.tituloLB.AutoSize = true;
            this.tituloLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tituloLB.Location = new System.Drawing.Point(68, 9);
            this.tituloLB.Name = "tituloLB";
            this.tituloLB.Size = new System.Drawing.Size(199, 20);
            this.tituloLB.TabIndex = 9;
            this.tituloLB.Text = "Nuevo Usuario Especial";
            // 
            // errContraseniaLB
            // 
            this.errContraseniaLB.AutoSize = true;
            this.errContraseniaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContraseniaLB.ForeColor = System.Drawing.Color.Red;
            this.errContraseniaLB.Location = new System.Drawing.Point(311, 72);
            this.errContraseniaLB.Name = "errContraseniaLB";
            this.errContraseniaLB.Size = new System.Drawing.Size(15, 13);
            this.errContraseniaLB.TabIndex = 35;
            this.errContraseniaLB.Text = "X";
            this.errContraseniaLB.Visible = false;
            // 
            // errUsuarioLB
            // 
            this.errUsuarioLB.AutoSize = true;
            this.errUsuarioLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errUsuarioLB.ForeColor = System.Drawing.Color.Red;
            this.errUsuarioLB.Location = new System.Drawing.Point(311, 46);
            this.errUsuarioLB.Name = "errUsuarioLB";
            this.errUsuarioLB.Size = new System.Drawing.Size(15, 13);
            this.errUsuarioLB.TabIndex = 34;
            this.errUsuarioLB.Text = "X";
            this.errUsuarioLB.Visible = false;
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bCancelar.Location = new System.Drawing.Point(251, 98);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 33;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bGuardar.Location = new System.Drawing.Point(164, 98);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 32;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // contraseniaTX
            // 
            this.contraseniaTX.Location = new System.Drawing.Point(80, 69);
            this.contraseniaTX.Name = "contraseniaTX";
            this.contraseniaTX.Size = new System.Drawing.Size(224, 20);
            this.contraseniaTX.TabIndex = 31;
            // 
            // usuarioTX
            // 
            this.usuarioTX.Location = new System.Drawing.Point(80, 43);
            this.usuarioTX.Name = "usuarioTX";
            this.usuarioTX.Size = new System.Drawing.Size(224, 20);
            this.usuarioTX.TabIndex = 30;
            // 
            // contraseniaLB
            // 
            this.contraseniaLB.AutoSize = true;
            this.contraseniaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseniaLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.contraseniaLB.Location = new System.Drawing.Point(7, 73);
            this.contraseniaLB.Name = "contraseniaLB";
            this.contraseniaLB.Size = new System.Drawing.Size(75, 13);
            this.contraseniaLB.TabIndex = 29;
            this.contraseniaLB.Text = "Contraseña:";
            // 
            // usuarioLB
            // 
            this.usuarioLB.AutoSize = true;
            this.usuarioLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.usuarioLB.Location = new System.Drawing.Point(7, 47);
            this.usuarioLB.Name = "usuarioLB";
            this.usuarioLB.Size = new System.Drawing.Size(54, 13);
            this.usuarioLB.TabIndex = 28;
            this.usuarioLB.Text = "Usuario:";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 129);
            this.Controls.Add(this.errContraseniaLB);
            this.Controls.Add(this.errUsuarioLB);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.contraseniaTX);
            this.Controls.Add(this.usuarioTX);
            this.Controls.Add(this.contraseniaLB);
            this.Controls.Add(this.usuarioLB);
            this.Controls.Add(this.tituloLB);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLB;
        private System.Windows.Forms.Label errContraseniaLB;
        private System.Windows.Forms.Label errUsuarioLB;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox contraseniaTX;
        private System.Windows.Forms.TextBox usuarioTX;
        private System.Windows.Forms.Label contraseniaLB;
        private System.Windows.Forms.Label usuarioLB;
    }
}
namespace UIForms
{
    partial class FrmCompra
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.clienteTX = new System.Windows.Forms.TextBox();
            this.fechaLB = new System.Windows.Forms.Label();
            this.codigoLB1 = new System.Windows.Forms.Label();
            this.clienteLB = new System.Windows.Forms.Label();
            this.nuevaCompraLB = new System.Windows.Forms.Label();
            this.importeTX = new System.Windows.Forms.TextBox();
            this.importeLB = new System.Windows.Forms.Label();
            this.errImporteLB = new System.Windows.Forms.Label();
            this.errFechaLB = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.codigoLB2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bCancelar.Location = new System.Drawing.Point(205, 145);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 39;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bGuardar.Location = new System.Drawing.Point(117, 145);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 38;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // clienteTX
            // 
            this.clienteTX.Location = new System.Drawing.Point(63, 62);
            this.clienteTX.Name = "clienteTX";
            this.clienteTX.Size = new System.Drawing.Size(217, 20);
            this.clienteTX.TabIndex = 35;
            // 
            // fechaLB
            // 
            this.fechaLB.AutoSize = true;
            this.fechaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fechaLB.Location = new System.Drawing.Point(7, 92);
            this.fechaLB.Name = "fechaLB";
            this.fechaLB.Size = new System.Drawing.Size(46, 13);
            this.fechaLB.TabIndex = 34;
            this.fechaLB.Text = "Fecha:";
            // 
            // codigoLB1
            // 
            this.codigoLB1.AutoSize = true;
            this.codigoLB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLB1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.codigoLB1.Location = new System.Drawing.Point(7, 42);
            this.codigoLB1.Name = "codigoLB1";
            this.codigoLB1.Size = new System.Drawing.Size(50, 13);
            this.codigoLB1.TabIndex = 33;
            this.codigoLB1.Text = "Código:";
            // 
            // clienteLB
            // 
            this.clienteLB.AutoSize = true;
            this.clienteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clienteLB.Location = new System.Drawing.Point(7, 64);
            this.clienteLB.Name = "clienteLB";
            this.clienteLB.Size = new System.Drawing.Size(50, 13);
            this.clienteLB.TabIndex = 32;
            this.clienteLB.Text = "Cliente:";
            // 
            // nuevaCompraLB
            // 
            this.nuevaCompraLB.AutoSize = true;
            this.nuevaCompraLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaCompraLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nuevaCompraLB.Location = new System.Drawing.Point(91, 9);
            this.nuevaCompraLB.Name = "nuevaCompraLB";
            this.nuevaCompraLB.Size = new System.Drawing.Size(126, 20);
            this.nuevaCompraLB.TabIndex = 31;
            this.nuevaCompraLB.Text = "Nueva Compra";
            // 
            // importeTX
            // 
            this.importeTX.Location = new System.Drawing.Point(63, 114);
            this.importeTX.Name = "importeTX";
            this.importeTX.Size = new System.Drawing.Size(217, 20);
            this.importeTX.TabIndex = 41;
            // 
            // importeLB
            // 
            this.importeLB.AutoSize = true;
            this.importeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.importeLB.Location = new System.Drawing.Point(7, 118);
            this.importeLB.Name = "importeLB";
            this.importeLB.Size = new System.Drawing.Size(53, 13);
            this.importeLB.TabIndex = 40;
            this.importeLB.Text = "Importe:";
            // 
            // errImporteLB
            // 
            this.errImporteLB.AutoSize = true;
            this.errImporteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errImporteLB.ForeColor = System.Drawing.Color.Red;
            this.errImporteLB.Location = new System.Drawing.Point(286, 118);
            this.errImporteLB.Name = "errImporteLB";
            this.errImporteLB.Size = new System.Drawing.Size(15, 13);
            this.errImporteLB.TabIndex = 59;
            this.errImporteLB.Text = "X";
            this.errImporteLB.Visible = false;
            // 
            // errFechaLB
            // 
            this.errFechaLB.AutoSize = true;
            this.errFechaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFechaLB.ForeColor = System.Drawing.Color.Red;
            this.errFechaLB.Location = new System.Drawing.Point(286, 92);
            this.errFechaLB.Name = "errFechaLB";
            this.errFechaLB.Size = new System.Drawing.Size(15, 13);
            this.errFechaLB.TabIndex = 60;
            this.errFechaLB.Text = "X";
            this.errFechaLB.Visible = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(63, 88);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(217, 20);
            this.dtFecha.TabIndex = 61;
            // 
            // codigoLB2
            // 
            this.codigoLB2.AutoSize = true;
            this.codigoLB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLB2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.codigoLB2.Location = new System.Drawing.Point(123, 42);
            this.codigoLB2.Name = "codigoLB2";
            this.codigoLB2.Size = new System.Drawing.Size(50, 13);
            this.codigoLB2.TabIndex = 62;
            this.codigoLB2.Text = "Código:";
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 188);
            this.Controls.Add(this.codigoLB2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.errFechaLB);
            this.Controls.Add(this.errImporteLB);
            this.Controls.Add(this.importeTX);
            this.Controls.Add(this.importeLB);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.clienteTX);
            this.Controls.Add(this.fechaLB);
            this.Controls.Add(this.codigoLB1);
            this.Controls.Add(this.clienteLB);
            this.Controls.Add(this.nuevaCompraLB);
            this.Name = "FrmCompra";
            this.Text = "FrmNuevaCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox clienteTX;
        private System.Windows.Forms.Label fechaLB;
        private System.Windows.Forms.Label codigoLB1;
        private System.Windows.Forms.Label clienteLB;
        private System.Windows.Forms.Label nuevaCompraLB;
        private System.Windows.Forms.TextBox importeTX;
        private System.Windows.Forms.Label importeLB;
        private System.Windows.Forms.Label errImporteLB;
        private System.Windows.Forms.Label errFechaLB;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label codigoLB2;
    }
}
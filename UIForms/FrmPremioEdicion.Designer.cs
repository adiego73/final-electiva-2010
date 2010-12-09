namespace UIForms
{
    partial class FrmPremioEdicion
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
            this.abmPremioLB = new System.Windows.Forms.Label();
            this.codigoLB2 = new System.Windows.Forms.Label();
            this.codigoLB1 = new System.Windows.Forms.Label();
            this.errDescripcionLB = new System.Windows.Forms.Label();
            this.errCantidadPuntosLB = new System.Windows.Forms.Label();
            this.errCantidadStockLB = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.cantidadStockTX = new System.Windows.Forms.TextBox();
            this.cantidadPuntosTX = new System.Windows.Forms.TextBox();
            this.descripcionTX = new System.Windows.Forms.TextBox();
            this.cantidadStockLB = new System.Windows.Forms.Label();
            this.cantidadPuntosLB = new System.Windows.Forms.Label();
            this.descripcionLB = new System.Windows.Forms.Label();
            this.bajaCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // abmPremioLB
            // 
            this.abmPremioLB.AutoSize = true;
            this.abmPremioLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abmPremioLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.abmPremioLB.Location = new System.Drawing.Point(121, 9);
            this.abmPremioLB.Name = "abmPremioLB";
            this.abmPremioLB.Size = new System.Drawing.Size(107, 20);
            this.abmPremioLB.TabIndex = 10;
            this.abmPremioLB.Text = "ABM Premio";
            // 
            // codigoLB2
            // 
            this.codigoLB2.AutoSize = true;
            this.codigoLB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLB2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.codigoLB2.Location = new System.Drawing.Point(137, 39);
            this.codigoLB2.Name = "codigoLB2";
            this.codigoLB2.Size = new System.Drawing.Size(78, 13);
            this.codigoLB2.TabIndex = 38;
            this.codigoLB2.Text = "Descripción:";
            // 
            // codigoLB1
            // 
            this.codigoLB1.AutoSize = true;
            this.codigoLB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLB1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.codigoLB1.Location = new System.Drawing.Point(12, 39);
            this.codigoLB1.Name = "codigoLB1";
            this.codigoLB1.Size = new System.Drawing.Size(50, 13);
            this.codigoLB1.TabIndex = 37;
            this.codigoLB1.Text = "Código:";
            // 
            // errDescripcionLB
            // 
            this.errDescripcionLB.AutoSize = true;
            this.errDescripcionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDescripcionLB.ForeColor = System.Drawing.Color.Red;
            this.errDescripcionLB.Location = new System.Drawing.Point(318, 65);
            this.errDescripcionLB.Name = "errDescripcionLB";
            this.errDescripcionLB.Size = new System.Drawing.Size(15, 13);
            this.errDescripcionLB.TabIndex = 49;
            this.errDescripcionLB.Text = "X";
            this.errDescripcionLB.Visible = false;
            // 
            // errCantidadPuntosLB
            // 
            this.errCantidadPuntosLB.AutoSize = true;
            this.errCantidadPuntosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCantidadPuntosLB.ForeColor = System.Drawing.Color.Red;
            this.errCantidadPuntosLB.Location = new System.Drawing.Point(318, 90);
            this.errCantidadPuntosLB.Name = "errCantidadPuntosLB";
            this.errCantidadPuntosLB.Size = new System.Drawing.Size(15, 13);
            this.errCantidadPuntosLB.TabIndex = 48;
            this.errCantidadPuntosLB.Text = "X";
            this.errCantidadPuntosLB.Visible = false;
            // 
            // errCantidadStockLB
            // 
            this.errCantidadStockLB.AutoSize = true;
            this.errCantidadStockLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCantidadStockLB.ForeColor = System.Drawing.Color.Red;
            this.errCantidadStockLB.Location = new System.Drawing.Point(318, 117);
            this.errCantidadStockLB.Name = "errCantidadStockLB";
            this.errCantidadStockLB.Size = new System.Drawing.Size(15, 13);
            this.errCantidadStockLB.TabIndex = 47;
            this.errCantidadStockLB.Text = "X";
            this.errCantidadStockLB.Visible = false;
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bCancelar.Location = new System.Drawing.Point(234, 162);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 46;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bGuardar.Location = new System.Drawing.Point(153, 162);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 45;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // cantidadStockTX
            // 
            this.cantidadStockTX.Location = new System.Drawing.Point(140, 113);
            this.cantidadStockTX.Name = "cantidadStockTX";
            this.cantidadStockTX.Size = new System.Drawing.Size(169, 20);
            this.cantidadStockTX.TabIndex = 44;
            // 
            // cantidadPuntosTX
            // 
            this.cantidadPuntosTX.Location = new System.Drawing.Point(140, 87);
            this.cantidadPuntosTX.Name = "cantidadPuntosTX";
            this.cantidadPuntosTX.Size = new System.Drawing.Size(169, 20);
            this.cantidadPuntosTX.TabIndex = 43;
            // 
            // descripcionTX
            // 
            this.descripcionTX.Location = new System.Drawing.Point(140, 62);
            this.descripcionTX.Name = "descripcionTX";
            this.descripcionTX.Size = new System.Drawing.Size(169, 20);
            this.descripcionTX.TabIndex = 42;
            // 
            // cantidadStockLB
            // 
            this.cantidadStockLB.AutoSize = true;
            this.cantidadStockLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadStockLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cantidadStockLB.Location = new System.Drawing.Point(12, 117);
            this.cantidadStockLB.Name = "cantidadStockLB";
            this.cantidadStockLB.Size = new System.Drawing.Size(116, 13);
            this.cantidadStockLB.TabIndex = 41;
            this.cantidadStockLB.Text = "Cantidad de Stock:";
            // 
            // cantidadPuntosLB
            // 
            this.cantidadPuntosLB.AutoSize = true;
            this.cantidadPuntosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadPuntosLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cantidadPuntosLB.Location = new System.Drawing.Point(12, 90);
            this.cantidadPuntosLB.Name = "cantidadPuntosLB";
            this.cantidadPuntosLB.Size = new System.Drawing.Size(122, 13);
            this.cantidadPuntosLB.TabIndex = 40;
            this.cantidadPuntosLB.Text = "Cantidad de Puntos:";
            // 
            // descripcionLB
            // 
            this.descripcionLB.AutoSize = true;
            this.descripcionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.descripcionLB.Location = new System.Drawing.Point(12, 64);
            this.descripcionLB.Name = "descripcionLB";
            this.descripcionLB.Size = new System.Drawing.Size(78, 13);
            this.descripcionLB.TabIndex = 39;
            this.descripcionLB.Text = "Descripción:";
            // 
            // bajaCB
            // 
            this.bajaCB.AutoSize = true;
            this.bajaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaCB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bajaCB.Location = new System.Drawing.Point(216, 139);
            this.bajaCB.Name = "bajaCB";
            this.bajaCB.Size = new System.Drawing.Size(93, 17);
            this.bajaCB.TabIndex = 58;
            this.bajaCB.Text = "Dar de Baja";
            this.bajaCB.UseVisualStyleBackColor = true;
            // 
            // FrmPremioEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 193);
            this.Controls.Add(this.bajaCB);
            this.Controls.Add(this.errDescripcionLB);
            this.Controls.Add(this.errCantidadPuntosLB);
            this.Controls.Add(this.errCantidadStockLB);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cantidadStockTX);
            this.Controls.Add(this.cantidadPuntosTX);
            this.Controls.Add(this.descripcionTX);
            this.Controls.Add(this.cantidadStockLB);
            this.Controls.Add(this.cantidadPuntosLB);
            this.Controls.Add(this.descripcionLB);
            this.Controls.Add(this.codigoLB2);
            this.Controls.Add(this.codigoLB1);
            this.Controls.Add(this.abmPremioLB);
            this.Name = "FrmPremioEdicion";
            this.Text = "FrmPremioEdicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abmPremioLB;
        private System.Windows.Forms.Label codigoLB2;
        private System.Windows.Forms.Label codigoLB1;
        private System.Windows.Forms.Label errDescripcionLB;
        private System.Windows.Forms.Label errCantidadPuntosLB;
        private System.Windows.Forms.Label errCantidadStockLB;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox cantidadStockTX;
        private System.Windows.Forms.TextBox cantidadPuntosTX;
        private System.Windows.Forms.TextBox descripcionTX;
        private System.Windows.Forms.Label cantidadStockLB;
        private System.Windows.Forms.Label cantidadPuntosLB;
        private System.Windows.Forms.Label descripcionLB;
        private System.Windows.Forms.CheckBox bajaCB;
    }
}
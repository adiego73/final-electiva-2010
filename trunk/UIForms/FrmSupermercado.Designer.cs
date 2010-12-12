namespace UIForms
{
    partial class FrmSupermercado
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.nCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.nUsuarioEspecial = new System.Windows.Forms.ToolStripMenuItem();
            this.nPremio = new System.Windows.Forms.ToolStripMenuItem();
            this.nCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.vaciar = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.lClientesActivos = new System.Windows.Forms.ToolStripMenuItem();
            this.lClientesInactivos = new System.Windows.Forms.ToolStripMenuItem();
            this.lPremio = new System.Windows.Forms.ToolStripMenuItem();
            this.lCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.lCompraTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.lCompraCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.canjesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCanjesTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.lCanjesCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDG = new System.Windows.Forms.DataGridView();
            this.lTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.listarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo,
            this.cerrar,
            this.vaciar});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            // 
            // nuevo
            // 
            this.nuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCliente,
            this.nUsuarioEspecial,
            this.nPremio,
            this.nCompra});
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(109, 22);
            this.nuevo.Text = "Nuevo";
            // 
            // nCliente
            // 
            this.nCliente.Name = "nCliente";
            this.nCliente.Size = new System.Drawing.Size(159, 22);
            this.nCliente.Text = "Cliente";
            this.nCliente.Click += new System.EventHandler(this.nCliente_Click);
            // 
            // nUsuarioEspecial
            // 
            this.nUsuarioEspecial.Name = "nUsuarioEspecial";
            this.nUsuarioEspecial.Size = new System.Drawing.Size(159, 22);
            this.nUsuarioEspecial.Text = "Usuario Especial";
            this.nUsuarioEspecial.Click += new System.EventHandler(this.nUsuarioEspecial_Click);
            // 
            // nPremio
            // 
            this.nPremio.Name = "nPremio";
            this.nPremio.Size = new System.Drawing.Size(159, 22);
            this.nPremio.Text = "Premio";
            this.nPremio.Click += new System.EventHandler(this.nPremio_Click);
            // 
            // nCompra
            // 
            this.nCompra.Name = "nCompra";
            this.nCompra.Size = new System.Drawing.Size(159, 22);
            this.nCompra.Text = "Compra";
            this.nCompra.Click += new System.EventHandler(this.nCompra_Click);
            // 
            // cerrar
            // 
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(109, 22);
            this.cerrar.Text = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // vaciar
            // 
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(109, 22);
            this.vaciar.Text = "Vaciar";
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lCliente,
            this.lPremio,
            this.lCompra,
            this.canjesToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // lCliente
            // 
            this.lCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lClientesActivos,
            this.lClientesInactivos});
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(152, 22);
            this.lCliente.Text = "Clientes";
            // 
            // lClientesActivos
            // 
            this.lClientesActivos.Name = "lClientesActivos";
            this.lClientesActivos.Size = new System.Drawing.Size(152, 22);
            this.lClientesActivos.Text = "Activos";
            this.lClientesActivos.Click += new System.EventHandler(this.lClientesActivos_Click);
            // 
            // lClientesInactivos
            // 
            this.lClientesInactivos.Name = "lClientesInactivos";
            this.lClientesInactivos.Size = new System.Drawing.Size(152, 22);
            this.lClientesInactivos.Text = "Inactivos";
            this.lClientesInactivos.Click += new System.EventHandler(this.lClientesInactivos_Click);
            // 
            // lPremio
            // 
            this.lPremio.Name = "lPremio";
            this.lPremio.Size = new System.Drawing.Size(152, 22);
            this.lPremio.Text = "Premios";
            this.lPremio.Click += new System.EventHandler(this.lPremio_Click);
            // 
            // lCompra
            // 
            this.lCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lCompraTodas,
            this.lCompraCliente});
            this.lCompra.Name = "lCompra";
            this.lCompra.Size = new System.Drawing.Size(152, 22);
            this.lCompra.Text = "Compras";
            // 
            // lCompraTodas
            // 
            this.lCompraTodas.Name = "lCompraTodas";
            this.lCompraTodas.Size = new System.Drawing.Size(132, 22);
            this.lCompraTodas.Text = "Todas";
            this.lCompraTodas.Click += new System.EventHandler(this.lCompraTodas_Click);
            // 
            // lCompraCliente
            // 
            this.lCompraCliente.Name = "lCompraCliente";
            this.lCompraCliente.Size = new System.Drawing.Size(132, 22);
            this.lCompraCliente.Text = "Por Cliente";
            this.lCompraCliente.Click += new System.EventHandler(this.lCompraCliente_Click);
            // 
            // canjesToolStripMenuItem
            // 
            this.canjesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lCanjesTodos,
            this.lCanjesCliente});
            this.canjesToolStripMenuItem.Name = "canjesToolStripMenuItem";
            this.canjesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.canjesToolStripMenuItem.Text = "Canjes";
            // 
            // lCanjesTodos
            // 
            this.lCanjesTodos.Name = "lCanjesTodos";
            this.lCanjesTodos.Size = new System.Drawing.Size(132, 22);
            this.lCanjesTodos.Text = "Todos";
            this.lCanjesTodos.Click += new System.EventHandler(this.lCanjesTodos_Click);
            // 
            // lCanjesCliente
            // 
            this.lCanjesCliente.Name = "lCanjesCliente";
            this.lCanjesCliente.Size = new System.Drawing.Size(132, 22);
            this.lCanjesCliente.Text = "Por Cliente";
            this.lCanjesCliente.Click += new System.EventHandler(this.lCanjesCliente_Click);
            // 
            // listadoDG
            // 
            this.listadoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDG.Location = new System.Drawing.Point(12, 67);
            this.listadoDG.Name = "listadoDG";
            this.listadoDG.Size = new System.Drawing.Size(751, 301);
            this.listadoDG.TabIndex = 1;
            this.listadoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDG_CellContentClick);
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lTitulo.Location = new System.Drawing.Point(244, 34);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(287, 20);
            this.lTitulo.TabIndex = 2;
            this.lTitulo.Text = "Seleccione Algún Listado Para Ver";
            // 
            // FrmSupermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 380);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.listadoDG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSupermercado";
            this.Text = "Supermercado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCliente;
        private System.Windows.Forms.DataGridView listadoDG;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.ToolStripMenuItem nCliente;
        private System.Windows.Forms.ToolStripMenuItem nUsuarioEspecial;
        private System.Windows.Forms.ToolStripMenuItem lPremio;
        private System.Windows.Forms.ToolStripMenuItem nPremio;
        private System.Windows.Forms.ToolStripMenuItem nCompra;
        private System.Windows.Forms.ToolStripMenuItem cerrar;
        private System.Windows.Forms.ToolStripMenuItem lCompra;
        private System.Windows.Forms.ToolStripMenuItem vaciar;
        private System.Windows.Forms.ToolStripMenuItem lCompraTodas;
        private System.Windows.Forms.ToolStripMenuItem lCompraCliente;
        private System.Windows.Forms.ToolStripMenuItem canjesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCanjesTodos;
        private System.Windows.Forms.ToolStripMenuItem lCanjesCliente;
        private System.Windows.Forms.ToolStripMenuItem lClientesActivos;
        private System.Windows.Forms.ToolStripMenuItem lClientesInactivos;
    }
}

namespace SistemaLojaCosmeticosInfo43
{
    partial class formPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lb_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lb_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_principal = new System.Windows.Forms.Timer(this.components);
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuVendas,
            this.menuConsultas,
            this.menuRelatorios,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(739, 40);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadCategorias,
            this.menuCadCargos,
            this.menuCadClientes,
            this.marcasToolStripMenuItem,
            this.menuCadProdutos,
            this.menuCadFuncionarios});
            this.menuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastros.Image")));
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(119, 36);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuCadCategorias
            // 
            this.menuCadCategorias.Name = "menuCadCategorias";
            this.menuCadCategorias.Size = new System.Drawing.Size(181, 38);
            this.menuCadCategorias.Text = "Categorias";
            // 
            // menuCadCargos
            // 
            this.menuCadCargos.Name = "menuCadCargos";
            this.menuCadCargos.Size = new System.Drawing.Size(181, 38);
            this.menuCadCargos.Text = "Cargos";
            // 
            // menuCadClientes
            // 
            this.menuCadClientes.Image = ((System.Drawing.Image)(resources.GetObject("menuCadClientes.Image")));
            this.menuCadClientes.Name = "menuCadClientes";
            this.menuCadClientes.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuCadClientes.Size = new System.Drawing.Size(181, 38);
            this.menuCadClientes.Text = "Clientes";
            this.menuCadClientes.Click += new System.EventHandler(this.menuCadClientes_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // menuCadProdutos
            // 
            this.menuCadProdutos.Name = "menuCadProdutos";
            this.menuCadProdutos.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuCadProdutos.Size = new System.Drawing.Size(181, 38);
            this.menuCadProdutos.Text = "Produtos";
            // 
            // menuCadFuncionarios
            // 
            this.menuCadFuncionarios.Name = "menuCadFuncionarios";
            this.menuCadFuncionarios.Size = new System.Drawing.Size(181, 38);
            this.menuCadFuncionarios.Text = "Funcionários";
            // 
            // menuVendas
            // 
            this.menuVendas.Image = ((System.Drawing.Image)(resources.GetObject("menuVendas.Image")));
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(101, 36);
            this.menuVendas.Text = "Vendas";
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClienteToolStripMenuItem});
            this.menuConsultas.Image = ((System.Drawing.Image)(resources.GetObject("menuConsultas.Image")));
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(118, 36);
            this.menuConsultas.Text = "Consultas";
            // 
            // consultaClienteToolStripMenuItem
            // 
            this.consultaClienteToolStripMenuItem.Name = "consultaClienteToolStripMenuItem";
            this.consultaClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.consultaClienteToolStripMenuItem.Text = "Consulta Cliente";
            this.consultaClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaClienteToolStripMenuItem_Click);
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.menuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("menuRelatorios.Image")));
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(122, 36);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuSair
            // 
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(79, 36);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(638, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(101, 448);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 15);
            this.toolStripLabel1.Text = "CADASTROS";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(98, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 67);
            this.toolStripButton1.Text = "CLIENTES";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(98, 67);
            this.toolStripButton2.Text = "FUNCIONARIOS";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(98, 67);
            this.toolStripButton3.Text = "VENDAS";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(98, 67);
            this.toolStripButton4.Text = "SAIR";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lb_data,
            this.status_lb_hora,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_lb_data
            // 
            this.status_lb_data.Name = "status_lb_data";
            this.status_lb_data.Size = new System.Drawing.Size(31, 17);
            this.status_lb_data.Text = "Data";
            // 
            // status_lb_hora
            // 
            this.status_lb_hora.Name = "status_lb_hora";
            this.status_lb_hora.Size = new System.Drawing.Size(33, 17);
            this.status_lb_hora.Text = "Hora";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo ao Sistema";
            // 
            // timer_principal
            // 
            this.timer_principal.Enabled = true;
            this.timer_principal.Tick += new System.EventHandler(this.timer_principal_Tick);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "formPrincipal";
            this.Text = "Sistema Loja Cosméticos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuCadCargos;
        private System.Windows.Forms.ToolStripMenuItem menuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuCadFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_lb_data;
        private System.Windows.Forms.ToolStripStatusLabel status_lb_hora;
        private System.Windows.Forms.Timer timer_principal;
        private System.Windows.Forms.ToolStripMenuItem consultaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}


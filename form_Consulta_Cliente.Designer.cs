namespace SistemaLojaCosmeticosInfo43
{
    partial class form_Consulta_Cliente
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
            this.gb_consulta = new System.Windows.Forms.GroupBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.gb_pesquisa = new System.Windows.Forms.GroupBox();
            this.rb_contem = new System.Windows.Forms.RadioButton();
            this.rb_inicio = new System.Windows.Forms.RadioButton();
            this.gb_sexo = new System.Windows.Forms.GroupBox();
            this.rb_sexo_m = new System.Windows.Forms.RadioButton();
            this.rb_sexo_f = new System.Windows.Forms.RadioButton();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_status_inatv = new System.Windows.Forms.RadioButton();
            this.rb_status_atv = new System.Windows.Forms.RadioButton();
            this.gb_cpf = new System.Windows.Forms.GroupBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.gb_consulta.SuspendLayout();
            this.gb_pesquisa.SuspendLayout();
            this.gb_sexo.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.gb_cpf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_consulta
            // 
            this.gb_consulta.Controls.Add(this.txt_nome);
            this.gb_consulta.Controls.Add(this.cmb_tipo);
            this.gb_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_consulta.Location = new System.Drawing.Point(13, 12);
            this.gb_consulta.Name = "gb_consulta";
            this.gb_consulta.Size = new System.Drawing.Size(630, 74);
            this.gb_consulta.TabIndex = 0;
            this.gb_consulta.TabStop = false;
            this.gb_consulta.Text = "Selecione um Tipo de Consulta:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(158, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(455, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(13, 35);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(139, 24);
            this.cmb_tipo.TabIndex = 0;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // gb_pesquisa
            // 
            this.gb_pesquisa.Controls.Add(this.rb_contem);
            this.gb_pesquisa.Controls.Add(this.rb_inicio);
            this.gb_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_pesquisa.Location = new System.Drawing.Point(661, 12);
            this.gb_pesquisa.Name = "gb_pesquisa";
            this.gb_pesquisa.Size = new System.Drawing.Size(151, 74);
            this.gb_pesquisa.TabIndex = 1;
            this.gb_pesquisa.TabStop = false;
            this.gb_pesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rb_contem
            // 
            this.rb_contem.AutoSize = true;
            this.rb_contem.Location = new System.Drawing.Point(72, 38);
            this.rb_contem.Name = "rb_contem";
            this.rb_contem.Size = new System.Drawing.Size(74, 21);
            this.rb_contem.TabIndex = 1;
            this.rb_contem.TabStop = true;
            this.rb_contem.Text = "Contém";
            this.rb_contem.UseVisualStyleBackColor = true;
            // 
            // rb_inicio
            // 
            this.rb_inicio.AutoSize = true;
            this.rb_inicio.Location = new System.Drawing.Point(13, 38);
            this.rb_inicio.Name = "rb_inicio";
            this.rb_inicio.Size = new System.Drawing.Size(58, 21);
            this.rb_inicio.TabIndex = 0;
            this.rb_inicio.TabStop = true;
            this.rb_inicio.Text = "Inicio";
            this.rb_inicio.UseVisualStyleBackColor = true;
            // 
            // gb_sexo
            // 
            this.gb_sexo.Controls.Add(this.rb_sexo_m);
            this.gb_sexo.Controls.Add(this.rb_sexo_f);
            this.gb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_sexo.Location = new System.Drawing.Point(13, 99);
            this.gb_sexo.Name = "gb_sexo";
            this.gb_sexo.Size = new System.Drawing.Size(211, 73);
            this.gb_sexo.TabIndex = 2;
            this.gb_sexo.TabStop = false;
            this.gb_sexo.Text = "Sexo:";
            // 
            // rb_sexo_m
            // 
            this.rb_sexo_m.AutoSize = true;
            this.rb_sexo_m.Location = new System.Drawing.Point(101, 39);
            this.rb_sexo_m.Name = "rb_sexo_m";
            this.rb_sexo_m.Size = new System.Drawing.Size(89, 21);
            this.rb_sexo_m.TabIndex = 1;
            this.rb_sexo_m.TabStop = true;
            this.rb_sexo_m.Text = "Masculino";
            this.rb_sexo_m.UseVisualStyleBackColor = true;
            // 
            // rb_sexo_f
            // 
            this.rb_sexo_f.AutoSize = true;
            this.rb_sexo_f.Location = new System.Drawing.Point(12, 39);
            this.rb_sexo_f.Name = "rb_sexo_f";
            this.rb_sexo_f.Size = new System.Drawing.Size(83, 21);
            this.rb_sexo_f.TabIndex = 0;
            this.rb_sexo_f.TabStop = true;
            this.rb_sexo_f.Text = "Feminino";
            this.rb_sexo_f.UseVisualStyleBackColor = true;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_status_inatv);
            this.gb_status.Controls.Add(this.rb_status_atv);
            this.gb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_status.Location = new System.Drawing.Point(288, 99);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(147, 73);
            this.gb_status.TabIndex = 3;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status:";
            // 
            // rb_status_inatv
            // 
            this.rb_status_inatv.AutoSize = true;
            this.rb_status_inatv.Location = new System.Drawing.Point(74, 39);
            this.rb_status_inatv.Name = "rb_status_inatv";
            this.rb_status_inatv.Size = new System.Drawing.Size(67, 21);
            this.rb_status_inatv.TabIndex = 1;
            this.rb_status_inatv.TabStop = true;
            this.rb_status_inatv.Text = "Inativo";
            this.rb_status_inatv.UseVisualStyleBackColor = true;
            // 
            // rb_status_atv
            // 
            this.rb_status_atv.AutoSize = true;
            this.rb_status_atv.Location = new System.Drawing.Point(6, 39);
            this.rb_status_atv.Name = "rb_status_atv";
            this.rb_status_atv.Size = new System.Drawing.Size(57, 21);
            this.rb_status_atv.TabIndex = 0;
            this.rb_status_atv.TabStop = true;
            this.rb_status_atv.Text = "Ativo";
            this.rb_status_atv.UseVisualStyleBackColor = true;
            // 
            // gb_cpf
            // 
            this.gb_cpf.Controls.Add(this.msk_cpf);
            this.gb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cpf.Location = new System.Drawing.Point(488, 105);
            this.gb_cpf.Name = "gb_cpf";
            this.gb_cpf.Size = new System.Drawing.Size(155, 67);
            this.gb_cpf.TabIndex = 4;
            this.gb_cpf.TabStop = false;
            this.gb_cpf.Text = "CPF:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(20, 33);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(117, 23);
            this.msk_cpf.TabIndex = 0;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.Location = new System.Drawing.Point(661, 92);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(109, 55);
            this.bt_pesquisar.TabIndex = 5;
            this.bt_pesquisar.Text = "PESQUISAR";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(661, 168);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(109, 49);
            this.bt_sair.TabIndex = 6;
            this.bt_sair.Text = "SAIR";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Para Alterar ou excluir um cliente, selecione na grid!!!";
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToResizeColumns = false;
            this.datagrid.AllowUserToResizeRows = false;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 233);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(795, 475);
            this.datagrid.TabIndex = 8;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            this.datagrid.DoubleClick += new System.EventHandler(this.datagrid_DoubleClick);
            // 
            // form_Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 732);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_pesquisar);
            this.Controls.Add(this.gb_cpf);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.gb_sexo);
            this.Controls.Add(this.gb_pesquisa);
            this.Controls.Add(this.gb_consulta);
            this.Name = "form_Consulta_Cliente";
            this.Text = "form_Consulta_Cliente";
            this.Load += new System.EventHandler(this.form_Consulta_Cliente_Load);
            this.gb_consulta.ResumeLayout(false);
            this.gb_consulta.PerformLayout();
            this.gb_pesquisa.ResumeLayout(false);
            this.gb_pesquisa.PerformLayout();
            this.gb_sexo.ResumeLayout(false);
            this.gb_sexo.PerformLayout();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.gb_cpf.ResumeLayout(false);
            this.gb_cpf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_consulta;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.GroupBox gb_pesquisa;
        private System.Windows.Forms.RadioButton rb_contem;
        private System.Windows.Forms.RadioButton rb_inicio;
        private System.Windows.Forms.GroupBox gb_sexo;
        private System.Windows.Forms.RadioButton rb_sexo_m;
        private System.Windows.Forms.RadioButton rb_sexo_f;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_status_inatv;
        private System.Windows.Forms.RadioButton rb_status_atv;
        private System.Windows.Forms.GroupBox gb_cpf;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid;
    }
}
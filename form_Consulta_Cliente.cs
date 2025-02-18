using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojaCosmeticosInfo43
{
    public partial class form_Consulta_Cliente : Form
    {
        public form_Consulta_Cliente()
        {
            InitializeComponent();

            
        }

        private void form_Consulta_Cliente_Load(object sender, EventArgs e)
        {
            //CARREGAR AS OPÇOES DE PESQUISA

            cmb_tipo.Items.Add("CPF");
            cmb_tipo.Items.Add("Nome");
            cmb_tipo.Items.Add("Sexo");
            cmb_tipo.Items.Add("Status");
            //DEIXAR A OPÇÃO NOME SELECIONADA
            cmb_tipo.SelectedIndex = 1;
            txt_nome.Focus();
            //DEIXAR OS RADIO BUTTON PRÉ SELECIONADOS
            rb_contem.Checked = true;
            rb_sexo_f.Checked = true;
            rb_status_atv.Checked = true;

        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ATIVAR E DESATIVAR OS ELEMENTOS CONFORME A ESCOLHA DO USUARIO
            //CPF
            if (cmb_tipo.SelectedIndex == 0)
            {
                txt_nome.Enabled = false;
                gb_pesquisa.Enabled = false;
                gb_sexo.Enabled = false;
                gb_status.Enabled = false;

                gb_cpf.Enabled = true;
                msk_cpf.Focus();
            }
            
            //NOME
            if (cmb_tipo.SelectedIndex == 1)
            {
                gb_sexo.Enabled = false;
                gb_status.Enabled = false;
                gb_cpf.Enabled = false;

                txt_nome.Enabled = true;
                txt_nome.Focus();
                gb_pesquisa.Enabled = true;
            }
            
            //SEXO
            if (cmb_tipo.SelectedIndex == 2)
            {

                txt_nome.Enabled = false;
                gb_pesquisa.Enabled = false;
                gb_status.Enabled = false;
                gb_cpf.Enabled = false;

                gb_sexo.Enabled = true;
            }          
            //STATUS
            if (cmb_tipo.SelectedIndex == 3)
            {

                txt_nome.Enabled = false;
                gb_pesquisa.Enabled = false;
                gb_sexo.Enabled = false;
                gb_cpf.Enabled = false;

                gb_status.Enabled = true;
            }
            




        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            //instanciar a classe cliente para usar os métodos de consulta

            classCliente cCliente = new classCliente();

            //criar uma variável para receber a opção escolhida pelo usuário na combo

            string consulta = cmb_tipo.SelectedItem.ToString();

            switch (consulta)
            {
                case "Nome":                   
                    if (txt_nome.Text == "") //campos pesquisar validação
                    {
                        MessageBox.Show("Favor informar um Nome", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {                     
                        if (rb_inicio.Checked == true)
                        {
                            datagrid.DataSource = cCliente.ConsultaClienteNomeInicio(txt_nome.Text);
                        }
                        else
                        {
                            datagrid.DataSource = cCliente.ConsultaClienteNomeContem(txt_nome.Text);
                        }
                    }
                    break;


                case "CPF":                                       
                    if(msk_cpf.Text == "     .   .   -")                     
                    {
                        MessageBox.Show("Favor informar um CPF", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        datagrid.DataSource = cCliente.ConsultaClienteCPF(msk_cpf.Text);
                        
                    }
                    break;

                case "Sexo":
                    if (rb_sexo_f.Checked == true)
                    {
                        datagrid.DataSource = cCliente.ConsultaClienteSexo("Feminino");

                    }
                    else
                    {
                        datagrid.DataSource = cCliente.ConsultaClienteSexo("Masculino");

                    }
                    break;

                case "Status":
                    if (rb_status_atv.Checked == true)
                    {
                        datagrid.DataSource = cCliente.ConsultaClienteStatus(1);
                    }
                    else
                    {
                        datagrid.DataSource = cCliente.ConsultaClienteStatus(0);
                    }
                    break;




            }







        }
        //clicar na grid de clientes e editar ou excluir um cliente
        //usar o evento CellClick ou DoubleClick 
        //usando o evento 
        private void datagrid_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o cliente selecionado?","Sistema loja cosméticos",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //instanciar a classe cleitnte para usar os metodos e propriedaddes
                classCliente cCliente = new classCliente();

                //instanciar o formulario de cadastro/atualização de cliente para usar os constroles do form
                form_cliente formCliente = new form_cliente();
                //pegar o codigo do cliente selecionado pelo usuario na grid
                cCliente.ConsultarCliente(Convert.ToInt32(datagrid.SelectedRows[0].Cells[0].Value));

                //passar os dados do BD para os controles do form de clientes
                formCliente.txt_cod_cliente.Text = cCliente.CodigoCliente.ToString();
                formCliente.datacad = cCliente.DataCadastro; // passar a variavel global criada no form de cadastro
                formCliente.txt_nome.Text = cCliente.NomeCliente.ToString();
                formCliente.msk_rg.Text = cCliente.CPF.ToString();
                formCliente.msk_cpf.Text = cCliente.CPF.ToString();
                formCliente.msk_nascimento.Text = cCliente.DataNascimento.ToString();
                formCliente.txt_endereco.Text = cCliente.Rua.ToString();
                formCliente.txt_numero.Text = cCliente.Numero.ToString();
                formCliente.txt_complemento.Text = cCliente.Complemento.ToString();
                formCliente.txt_bairro.Text = cCliente.Complemento.ToString();
                formCliente.txt_cidade.Text = cCliente.Cidade.ToString();
                formCliente.estado = cCliente.Estado.ToString(); // (Combo) passar a variavel global declarada no formulario
                formCliente.msk_cep.Text = cCliente.CEP.ToString();
                formCliente.txt_email.Text = cCliente.Email.ToString();
                formCliente.msk_telefone.Text = cCliente.TelefoneResidencial.ToString();
                formCliente.msk_celular.Text = cCliente.TelefoneCelular.ToString();

                if (cCliente.Sexo == "Feminino")
                {
                    formCliente.radio_feminino.Checked = true;
                }
                else
                {
                    formCliente.radio_masculino.Checked = true;
                }

                if (cCliente.Status == 1)
                {
                    formCliente.ckCadastro.Checked = true;
                }
                else 
                {
                    formCliente.ckCadastro.Checked = false;

                }

                // mandar a informação de update
                formCliente.tipo = "Atualização";
                // abrir o formulario de cadastro em modo exclusivo
                formCliente.ShowDialog();
                // chamar o método de pesquisa
                bt_pesquisar_Click(this, new EventArgs());


            }





        }

        private void bt_sair_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

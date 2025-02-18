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
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();
        }

        //variavel TIPO: guardar como o formulario deve ser aberto se para cadastro atualização ou exclusão
        //variavel ESTADO: informação é mostrada em uma combo
        public string tipo, estado;
        //variavel DATACAD: mostrar informaçao guardada no banco de dados e nao data atual como programado no load do form
        public DateTime datacad;
        private void limpar()
        {
            txt_nome.Clear();
            msk_cpf.Clear();
            msk_rg.Clear();
            msk_nascimento.Clear();
            txt_email.Clear();
            msk_telefone.Clear();
            msk_celular.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            msk_cep.Clear();
            txt_complemento.Clear();

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS UM TELEFONE

            if (txt_nome.Text != "" && msk_cpf.Text != "   .   .   -" && msk_nascimento.Text != "  /  /" && txt_endereco.Text !="" && txt_numero.Text !="" && txt_email.Text != "" && (msk_telefone.Text != "(  )     -" || msk_celular.Text != "(  )      -"))
            {
                //PASSAR PARA AS PROPRIEDADAES DA CLASSE AS INFORMAÇÕES DIGITADAS PELO USUARIO NO FORMULÁRIO 

                classCliente cCliente = new classCliente();
                cCliente.NomeCliente = txt_nome.Text;
                cCliente.CPF = msk_cpf.Text;
                cCliente.DataNascimento = Convert.ToDateTime(msk_nascimento.Text);
                cCliente.Rua = txt_endereco.Text;
                cCliente.Numero = Convert.ToInt32(txt_numero.Text);
                cCliente.Complemento = txt_complemento.Text;
                cCliente.Bairro = txt_bairro.Text;
                cCliente.Cidade = txt_cidade.Text;
                cCliente.Estado = combo_estado.SelectedItem.ToString();
                cCliente.Email = txt_email.Text;

                //RADIOBUTTON
                if (radio_feminino.Checked == true)
                {
                    cCliente.Sexo = "Feminino";
                    
                }
                else
                {
                    cCliente.Sexo = "Masculino";
                }

                //MASCARAS QUE NAO SAO OBRIGATÓRIAS

                //RG
                if (msk_rg.Text != "   .   .   -")
                {
                    cCliente.RG = msk_rg.Text;
                }
                else
                {
                    cCliente.RG = "";
                }

                //CEP

                if (msk_cep.Text != "    -")
                {
                    cCliente.CEP = msk_cep.Text;
                }
                else
                {
                    cCliente.CEP = "";
                }

                //TELEFONE

                if (msk_telefone.Text != "(  )     -")
                {
                    cCliente.TelefoneResidencial = msk_telefone.Text;
                }
                else
                {
                    cCliente.TelefoneResidencial = "";
                }

                //CELULAR
                if (msk_celular.Text != "(  )      -")
                {
                    cCliente.TelefoneCelular = msk_celular.Text;
                }
                else
                {
                    cCliente.TelefoneCelular = "";
                }
                //CHAMAR O MÉTODO CADASTRAR DA CLASSE CLIENTE
                int resp = cCliente.CadastroCliente();

                //EXEBIR MENSAGEM DE CADASTRO REALIZADO 
                if (resp == 1)
                {
                    MessageBox.Show("Cliente: " + cCliente.NomeCliente + " Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Realizar o cadastro", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else //VALIDAÇÃO CAMPOS OBRIGATORIOS - SE O USUARIO NÃO PREENCHER TODOS OS CAMPOS OBRIGATÓRIOS
            {
                //MOSTRAR MENSAGEM PARA O USUARIO
                MessageBox.Show("PREENCHER TODOS OS CAMPOS OBRIGATORIOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txt_nome.BackColor = Color.LemonChiffon;
                msk_cpf.BackColor = Color.LemonChiffon;
                msk_nascimento.BackColor = Color.LemonChiffon;
                txt_endereco.BackColor = Color.LemonChiffon;
                txt_numero.BackColor = Color.LemonChiffon;
                txt_email.BackColor = Color.LemonChiffon;
                msk_telefone.BackColor = Color.LightSteelBlue;
                msk_celular.BackColor = Color.LightSteelBlue;
                txt_nome.Focus();
            }






        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            // instanciar a classe cliente para usar métodos e propriedades
            classCliente cCliente = new classCliente();

            // verificar campos obrigatórios (validando pelo menos um telefone)

            if (txt_nome.Text != "" && msk_cpf.Text != "   .   .   -" && msk_nascimento.Text != "  /  /" && txt_endereco.Text != "" && txt_numero.Text != "" && txt_email.Text != "" && (msk_telefone.Text != "(  )     -" || msk_celular.Text != "(  )      -"))
            {

                // passar para as propriedades o conetudo do formulário
                // todos os campos que o usuario vai preencher
                cCliente.NomeCliente = txt_nome.Text;
                cCliente.CPF = msk_cpf.Text;
                cCliente.DataNascimento = Convert.ToDateTime(msk_nascimento.Text);
                cCliente.Rua = txt_endereco.Text;
                cCliente.Numero = Convert.ToInt32(txt_numero.Text);
                cCliente.Complemento = txt_complemento.Text;
                cCliente.Bairro = txt_bairro.Text;
                cCliente.Cidade = txt_cidade.Text;
                cCliente.Estado = combo_estado.SelectedItem.ToString();
                cCliente.Email = txt_email.Text;

                //RADIOBUTTON
                if (radio_feminino.Checked == true)
                {
                    cCliente.Sexo = "Feminino";

                }
                else
                {
                    cCliente.Sexo = "Masculino";
                }

                //MASCARAS QUE NAO SAO OBRIGATÓRIAS

                //RG
                if (msk_rg.Text != "   .   .   -")
                {
                    cCliente.RG = msk_rg.Text;
                }
                else
                {
                    cCliente.RG = "";
                }

                //CEP

                if (msk_cep.Text != "    -")
                {
                    cCliente.CEP = msk_cep.Text;
                }
                else
                {
                    cCliente.CEP = "";
                }

                //TELEFONE

                if (msk_telefone.Text != "(  )     -")
                {
                    cCliente.TelefoneResidencial = msk_telefone.Text;
                }
                else
                {
                    cCliente.TelefoneResidencial = "";
                }

                //CELULAR
                if (msk_celular.Text != "(  )      -")
                {
                    cCliente.TelefoneCelular = msk_celular.Text;
                }
                else
                {
                    cCliente.TelefoneCelular = "";
                }

                // status 
                if (ckCadastro.Checked == true)
                {
                    cCliente.Status = 1;
                }
                else
                {
                    cCliente.Status = 0;

                }

                cCliente.CodigoCliente = Convert.ToInt32(txt_cod_cliente.Text);


                // chamar o método Atualizar cliente
                bool resp = cCliente.UpdateCliente();


                if (resp)
                {
                    MessageBox.Show("Cliente: " + cCliente.NomeCliente + " Atualizado com Sucesso.", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Erro ao Realizar o cada", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }












            }
            else //VALIDAÇÃO CAMPOS OBRIGATORIOS - SE O USUARIO NÃO PREENCHER TODOS OS CAMPOS OBRIGATÓRIOS
            {
                //MOSTRAR MENSAGEM PARA O USUARIO
                MessageBox.Show("PREENCHER TODOS OS CAMPOS OBRIGATORIOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txt_nome.BackColor = Color.LemonChiffon;
                msk_cpf.BackColor = Color.LemonChiffon;
                msk_nascimento.BackColor = Color.LemonChiffon;
                txt_endereco.BackColor = Color.LemonChiffon;
                txt_numero.BackColor = Color.LemonChiffon;
                txt_email.BackColor = Color.LemonChiffon;
                msk_telefone.BackColor = Color.LightSteelBlue;
                msk_celular.BackColor = Color.LightSteelBlue;
                txt_nome.Focus();
            }

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Cliente?","Sistema Loja de Cosméticos",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                classCliente cCliente = new classCliente();

                cCliente.CodigoCliente = Convert.ToInt32(txt_cod_cliente.Text);

                bool resp = cCliente.DeleteCliente();

                if (resp)
                {
                    MessageBox.Show("Cliente: " + cCliente.NomeCliente + " Excluido com Sucesso.","Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este cliente não pode ser excluido, há registros em outras tabelas.", "Sistema Loja Cosméticos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }








            }





        }

        private void form_cliente_Load(object sender, EventArgs e)
        {
            //carregar data na label
            lb_data_cad.Text = DateTime.Now.ToShortDateString();

            //carregar combo de estado
            combo_estado.Items.Add("AC");
            combo_estado.Items.Add("AL");
            combo_estado.Items.Add("AP");
            combo_estado.Items.Add("AM");
            combo_estado.Items.Add("BA");
            combo_estado.Items.Add("CE");
            combo_estado.Items.Add("DF");
            combo_estado.Items.Add("ES");
            combo_estado.Items.Add("GO");
            combo_estado.Items.Add("MA");
            combo_estado.Items.Add("MS");
            combo_estado.Items.Add("MT");
            combo_estado.Items.Add("MG");
            combo_estado.Items.Add("PA");
            combo_estado.Items.Add("PB");
            combo_estado.Items.Add("PR");
            combo_estado.Items.Add("PE");
            combo_estado.Items.Add("PI");
            combo_estado.Items.Add("RJ");
            combo_estado.Items.Add("RN");
            combo_estado.Items.Add("RS");
            combo_estado.Items.Add("RO");
            combo_estado.Items.Add("RR");
            combo_estado.Items.Add("SC");
            combo_estado.Items.Add("SP");
            combo_estado.Items.Add("SE");
            combo_estado.Items.Add("TO");
            combo_estado.SelectedItem = "SP";


            //Quando abrir o formulario para atualizar/excluir

            if(tipo == "Atualização")
            {
                lb_cliente.Text = "Atualização Cliente";
                ckCadastro.Enabled = true;
                bt_cadastrar.Enabled = false;
                bt_atualizar.Enabled = true;
                bt_excluir.Enabled = true;

                combo_estado.SelectedItem = estado;
                lb_data_cad.Text = datacad.ToString();

            }

            else
            {
                bt_atualizar.Enabled = false;
                bt_excluir.Enabled = false;
                ckCadastro.Enabled = false;

            }
            
        }
    }
}

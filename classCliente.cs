using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaLojaCosmeticosInfo43
{
    class classCliente
    {
        //MÉTODO CONSTRUTOR DA CLASSE

        //SERVE PARA INICILIZAR TODAS AS VARIAVEIS E PROPRIEDADES
        //PRECISA TER O MESMO NOME DA CLASSE
        public classCliente()
        {
            CodigoCliente = 0;
            DataCadastro = DateTime.Now;
            NomeCliente = null;
            RG = null;
            CPF = null;
            DataNascimento = DateTime.Now;
            Sexo = null;
            Rua = null;
            Numero = 0;
            Complemento = null;
            Bairro = null;
            Cidade = null;
            Estado = null;
            CEP = null;
            Email = null;
            TelefoneResidencial = null;
            TelefoneCelular = null;
            Status = 0;

        }

        //PROPRIEDADES

        //SERVE PARA LER E "GRAVAR" AS INFORMAÇÕES
        //ATALHO PARA CRIAR AS PROPRIEDADES - PROP TAB TAB
        public int CodigoCliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NomeCliente { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public int Status { get; set; }

        //CRIAÇÃO DOS MÉTODOS (FUNCIONALIDADES DO SISTEMA)
        //CADASTRO - CONSULTA - ATUALIZAÇÃO - EXCLUSÃO
        //MÉTODO: TIPO MÉTODO TIPO RETORNO NOME MÉTODO PARÂMETROS

        //MÉTODO CADASTRAR CLIENTE
        public int CadastroCliente()
        {
            string query = "INSERT INTO cliente VALUES(0,now(),'" + NomeCliente + "','" + RG + "','" + CPF + "', '" + DataNascimento.ToString("yyyy-MM-dd") + "','" + Sexo + "','" + Rua + "', " + Numero + ", '" + Complemento + "', '" + Bairro + "', '" + Cidade + "','" + Estado + "', '" + CEP + "', '" + Email + "', '" + TelefoneResidencial + "','" + TelefoneCelular + "', 1)";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        //MÉTODOS DE CONSULTA
        //CONSULTA DE CLIENTE POR NOME(INÍCIO E CONTÊM), CPF, SEXO, STATUS
        //CAMPOS EXIBIDOS NA CONSULTA: COF, NOME, CPF, DATA NASCIMENTO, SEXO E TELEFONE

        //CONSULTA DE CLIENTE POR NOME (INÍCIO)

        public DataTable ConsultaClienteNomeInicio(string nomei)
        {
            string query = "SELECT CodigoCliente, NomeCliente, CPF, DataNascimento,Sexo ,TelefoneCelular FROM cliente WHERE Status = 1 AND NomeCliente LIKE '" + nomei + "%' ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        //CONSULTA DE CLIENTE POR NOME (Contêm)
        public DataTable ConsultaClienteNomeContem(string nomec)
        {
            string query = "SELECT CodigoCliente, NomeCliente, CPF, DataNascimento,Sexo ,TelefoneCelular FROM cliente WHERE Status = 1 AND NomeCliente LIKE '%" + nomec + "%' ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //CONSULTA DE CLIENTE POR SEXO
        public DataTable ConsultaClienteSexo(string sexo)
        {
            string query = "SELECT CodigoCliente, NomeCliente, CPF, DataNascimento,Sexo ,TelefoneCelular FROM cliente WHERE Status = 1 AND Sexo = '" + sexo + "' ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //CONSULTA DE CLIENTE POR CPF
        public DataTable ConsultaClienteCPF(string cpf)
        {
            string query = "SELECT CodigoCliente, NomeCliente, CPF, DataNascimento,Sexo ,TelefoneCelular FROM cliente WHERE Status = 1 AND CPF = '" + cpf + "' ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        //CONSULTA DE CLIENTE POR STATUS
        public DataTable ConsultaClienteStatus(int status)
        {
            string query = "SELECT CodigoCliente, NomeCliente, CPF, DataNascimento,Sexo ,TelefoneCelular FROM cliente WHERE Status = " + status + " ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //MÉTODO PARA RETORNAR OS DADOS DO BANCO
        public bool ConsultarCliente(int cod)
        {
            string query = "SELECT * FROM Cliente WHERE CodigoCliente = " + cod + "";
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDataTable(query);

            if (dt.Rows.Count > 0)
            {
                CodigoCliente = Convert.ToInt32(dt.Rows[0]["CodigoCliente"]);
                DataCadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"]);
                NomeCliente = dt.Rows[0]["NomeCliente"].ToString();
                RG = dt.Rows[0]["RG"].ToString();
                CPF = dt.Rows[0]["CPF"].ToString();
                DataNascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"]);
                Sexo = dt.Rows[0]["Sexo"].ToString();
                Rua = dt.Rows[0]["Rua"].ToString();
                Numero = Convert.ToInt32(dt.Rows[0]["Numero"]);
                Complemento = dt.Rows[0]["Complemento"].ToString();
                Bairro = dt.Rows[0]["Bairro"].ToString();
                Cidade = dt.Rows[0]["Cidade"].ToString();
                Estado = dt.Rows[0]["Estado"].ToString();
                CEP = dt.Rows[0]["Cep"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                TelefoneResidencial = dt.Rows[0]["TelefoneResidencial"].ToString();
                TelefoneCelular = dt.Rows[0]["TelefoneCelular"].ToString();
                Status = Convert.ToInt32(dt.Rows[0]["Status"]);

                return true;

            }
            else
            {

                return false;

            }



        }

        //MÉTODO UPDATE

        public bool UpdateCliente()
        {
            string query = "UPDATE Cliente SET NomeCliente = '" + NomeCliente + "',RG = '" + RG + "',CPF = '" + CPF + "',DataNascimento = '" + DataNascimento.ToString("yyyy-MM-dd") + "',Sexo = '" + Sexo + "',Rua = '" + Rua + "',Numero = " + Numero + ",Complemento = '" + Complemento + "',Bairro = '" + Bairro + "',Cidade = '" + Cidade + "',Estado ='" + Estado + "',CEP = '" + CEP + "',Email = '" + Email + "',Status = " + Status + ",TelefoneResidencial = '" + TelefoneResidencial + "',TelefoneCelular = '" + TelefoneCelular + "' WHERE CodigoCliente = '" + CodigoCliente + "'";

            classConexao cConexao = new classConexao();
            int resp = cConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;

            }
            else
            {

                return false;
            }




        }
        //MÉTODO DELETE
        public bool DeleteCliente()
        {
            string query = "DELETE FROM Cliente WHERE CodigoCliente = " + CodigoCliente + "";

            classConexao cConexao = new classConexao();
            int resp = cConexao.ExecutaQuery(query);


            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //MÉTODOS RELATÓRIO
        public DataTable BuscarCidade()
        {
            string query = "SELECT DISTINCT Cidade FROM cliente WHERE Status = 1 ORDER BY Cidade;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }
        
        //RELATÓRIO DE CLIENTE POR IDADE (INTERVALO)
        public DataTable RelatorioClienteIdade(int idade1, int idade2)
        {
            string query = "SELECT nomecliente, CPF, DataNascimento, Cidade, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 AND timestampdiff(YEAR, DataNascimento, now()) BETWEEN "+ idade1 +" AND " + idade2 +" ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RELATÓRIO DE CLIENTE POR MAIORES DE
        public DataTable RelatorioClienteMaioresDe(int idade)
        {
            string query = "SELECT nomecliente, CPF, DataNascimento, Cidade, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 AND timestampdiff(YEAR, DataNascimento, now()) > " + idade + " ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

        //RELATÓRIO DE CLIENTE POR CIDADE
        public DataTable RelatorioClienteCidade(string cidade)
        {
            string query = "SELECT nomecliente, CPF, DataNascimento, Cidade, Sexo, TelefoneCelular FROM cliente WHERE Status = 1 AND Cidade = '" + cidade + "' ORDER BY NomeCliente;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);
        }

    }
}

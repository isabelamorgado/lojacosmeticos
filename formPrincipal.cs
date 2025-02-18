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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void menuCadClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cliente>().Count() > 0)
            {
                MessageBox.Show("O formulario cliente ja está aberto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);





            }
            else
            {

                form_cliente fcliente = new form_cliente();
                fcliente.MdiParent = this;
                fcliente.Show();


            }

            



        }

        private void menuSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes) 
            {
                Application.Exit();


            }




        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();


            }
        }

        private void timer_principal_Tick(object sender, EventArgs e)
        {

            status_lb_data.Text = DateTime.Now.ToShortDateString();
            status_lb_hora.Text = DateTime.Now.ToShortTimeString();



        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_Consulta_Cliente>().Count() > 0)
            {
                MessageBox.Show("O formulario cliente ja está aberto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);





            }
            else
            {

                form_Consulta_Cliente fconsultacliente = new form_Consulta_Cliente();
                fconsultacliente.MdiParent = this;
                fconsultacliente.Show();


            }


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelClientes43>().Count() > 0)
            {
                MessageBox.Show("O formulario relatório de cliente ja está aberto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {

                formRelClientes43 frelatoriocliente = new formRelClientes43();
                frelatoriocliente.MdiParent = this;
                frelatoriocliente.Show();

            }
        }
    }
}

using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_CSharp
{
    public partial class FrmAviso : Form
    {
        public FrmAviso()
        {
            InitializeComponent();
            textAviso.Text = "";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAviso_Load(object sender, EventArgs e)
        {
            string cont = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int contador;
            String contadores;
            int controle = cont.Length;
            //MessageBox.Show(controle.ToString());
            for (int i = 0; i < 26; i++)
            {
                textAviso.Text += '═';
            }
            textAviso.Text += "Avisos de Funcionamento";
            for (int i = 0; i < 26; i++)
            {
                textAviso.Text += '═';
            }
            textAviso.Text += "\n";
            textAviso.Text += "       Tenha Certeza que antes de Rodar o Código você ativou as seguintes funções:     \n";


            contadores = "Ligar o Xampp";
            contador = controle - contadores.Length;
            for(int i = 0;i < contador;i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Ligar o Xampp";
            textAviso.Text += "\n";


            contadores = "Reinstalar o NuGet";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Reinstalar o NuGet";
            textAviso.Text += "\n";

            contadores = "Executou o DataBase";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Executou o DataBase";
            textAviso.Text += "\n";

            contadores = "Executou os Dados da DataBase";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Executou os Dados da DataBase";
            textAviso.Text += "\n";

            contadores = "Clonou toda as pastas";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Clonou toda as pastas";
            textAviso.Text += "\n";

            contadores = "Otimizou o Computador";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Otimizou o Computador";
            textAviso.Text += "\n";
        }
    }
}

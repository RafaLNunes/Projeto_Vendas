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
    public partial class HomePrincipal : Form
    {
        bool sidebarexpacao;
        public HomePrincipal()
        {
            InitializeComponent();
        }

        private void HomePrincipal_Load(object sender, EventArgs e)
        {



        }


        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpacao)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarexpacao = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarexpacao = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }


    }
}

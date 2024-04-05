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
    public partial class FrmExplicacaoprincipal : Form
    {
        bool SideBarExpacao;
        bool homeretrair;
        bool vendaratrair;
        public FrmExplicacaoprincipal()
        {
            InitializeComponent();
        }

        private void FrmExplicacaoprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (SideBarExpacao)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    SideBarExpacao = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    SideBarExpacao = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeretrair)
            {
                homepainel.Height += 10;
                if (homepainel.Height == homepainel.MaximumSize.Height)
                {
                    homeretrair = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                homepainel.Height -= 10;
                if (homepainel.Height == homepainel.MinimumSize.Height)
                {
                    homeretrair = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void VendaTimer_Tick(object sender, EventArgs e)
        {
            if (vendaratrair)
            {
                vendapainel.Height += 10;
                if (vendapainel.Height == vendapainel.MaximumSize.Height)
                {
                    vendaratrair = false;
                    VendaTimer.Stop();
                }
            }
            else
            {
                vendapainel.Height -= 10;
                if (vendapainel.Height == vendapainel.MinimumSize.Height)
                {
                    vendaratrair = true;
                    VendaTimer.Stop();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VendaTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHomePrincipal hm = new FrmHomePrincipal();
            this.Hide();
            hm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmExplicacaoprincipal exp = new FrmExplicacaoprincipal();
            this.Hide();
            exp.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSoftware soft = new FrmSoftware();
            this.Hide();
            soft.ShowDialog();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            FrmRedes rede = new FrmRedes();
            this.Hide();
            rede.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHardware hard = new FrmHardware();
            this.Hide();
            hard.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmNuvem nuvem = new FrmNuvem();
            this.Hide();
            nuvem.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUserPrincipal user = new FrmUserPrincipal();
            this.Hide();
            user.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmconfig confg = new Frmconfig();
            this.Hide();
            confg.ShowDialog();
        }
    }
}

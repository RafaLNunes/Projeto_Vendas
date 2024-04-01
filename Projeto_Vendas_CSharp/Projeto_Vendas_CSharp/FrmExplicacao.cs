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
    public partial class FrmExplicacao : Form
    {
        bool SideBarExpacao;
        bool homeretrair;
        public FrmExplicacao()
        {
            InitializeComponent();
        }

        private void FrmExplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SideBar_Tick(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            FrmExplicacao exp = new FrmExplicacao();
            this.Hide();
            exp.ShowDialog();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHomeInicial innst = new FrmHomeInicial();
            this.Hide();
            innst.ShowDialog();
        }

        private void FrmExplicacao_Load(object sender, EventArgs e)
        {

        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            FrmUserInicial user = new FrmUserInicial();
            this.Hide();
            user.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmHomeInicial inst = new FrmHomeInicial();
            this.Hide();
            inst.ShowDialog();
        }

        private void homebutton_Click_1(object sender, EventArgs e)
        {
            FrmUserInicial user = new FrmUserInicial();
            this.Hide();
            user.ShowDialog();
        }
    }
}

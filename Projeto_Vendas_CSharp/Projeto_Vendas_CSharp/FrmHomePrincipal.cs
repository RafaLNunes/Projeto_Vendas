﻿using System;
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
    public partial class FrmHomePrincipal : Form
    {
        bool SideBarExpacao;
        bool homeretrair;
        bool vendaratrair;
        public FrmHomePrincipal()
        {
            InitializeComponent();
        }

        private void HomePrincipal_Load(object sender, EventArgs e)
        {



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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
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

        private void button4_Click(object sender, EventArgs e)
        {
            VendaTimer.Start();
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

        private void FrmHomePrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vendapainel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmNuvem nvu = new FrmNuvem();
            this.Hide();
            nvu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHomePrincipal inst = new FrmHomePrincipal();
            this.Hide();
            inst.ShowDialog();
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
            FrmHardware hdw = new FrmHardware();
            this.Hide();
            hdw.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            VendaTimer.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmHomePrincipal hm = new FrmHomePrincipal();
            this.Hide();
            hm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FrmExplicacaoprincipal exp = new FrmExplicacaoprincipal();
            this.Hide();
            exp.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FrmSoftware sof = new FrmSoftware();
            this.Hide(); sof.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            FrmRedes rede = new FrmRedes();
            this.Hide(); rede.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            FrmHardware hard = new FrmHardware();
            this.Hide(); hard.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            FrmNuvem nuvem = new FrmNuvem();
            this.Hide(); nuvem.ShowDialog();
        }
    }
}

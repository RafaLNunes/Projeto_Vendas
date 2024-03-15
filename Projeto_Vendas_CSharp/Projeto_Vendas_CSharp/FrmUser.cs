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
    public partial class FrmUser : Form
    {

        bool SideBarExpacao;
        bool UserRetrair;


        public FrmUser()
        {
            InitializeComponent();
            visibleImage.Image = visiblePassWord.Images[0];
        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            if (UserRetrair)
            {
                homebar.Height += 10;
                if (homebar.Height == homebar.MaximumSize.Height)
                {
                    UserRetrair = false;
                    UserTimer.Stop();
                }
            }
            else
            {
                homebar.Height -= 10;
                if (homebar.Height == homebar.MinimumSize.Height)
                {
                    UserRetrair = true;
                    UserTimer.Stop();
                }
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
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

        private void homebutton_Click(object sender, EventArgs e)
        {
            UserTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '•')
            {
                visibleImage.Image = visiblePassWord.Images[1];
                txtPassWord.PasswordChar = '\0';
            }
            else if (txtPassWord.PasswordChar != '•')
            {
                visibleImage.Image = visiblePassWord.Images[0];
                txtPassWord.PasswordChar = '•';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

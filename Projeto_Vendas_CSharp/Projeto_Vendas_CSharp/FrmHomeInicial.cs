using System.Threading;

namespace Projeto_Vendas_CSharp
{
    public partial class FrmHomeInicial : Form
    {
        bool SideBarExpacao;
        bool homeretrair;
        bool userretrair;
        public FrmHomeInicial()
        {
            InitializeComponent();
            FrmAviso avi = new FrmAviso();
            avi.ShowDialog();
        }

        private void HomeInicial_Load(object sender, EventArgs e)
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



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            FrmUserInicial u = new FrmUserInicial();
            this.Hide();
            u.ShowDialog();


        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHomeInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void HomeTimer_Tick_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmHomeInicial i = new FrmHomeInicial();
            this.Hide();
            i.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmExplicacao et = new FrmExplicacao();
            this.Hide();
            et.ShowDialog();
        }


        private void UserTimer_Tick(object sender, EventArgs e)
        {
            if (userretrair)
            {
                UserBar.Height += 10;
                if (UserBar.Height == UserBar.MaximumSize.Height)
                {
                    userretrair = false;
                    UserTimer.Stop();
                }
            }
            else
            {
                UserBar.Height -= 10;
                if (UserBar.Height == UserBar.MinimumSize.Height)
                {
                    userretrair = true;
                    UserTimer.Stop();
                }
            }
        }
    }
}

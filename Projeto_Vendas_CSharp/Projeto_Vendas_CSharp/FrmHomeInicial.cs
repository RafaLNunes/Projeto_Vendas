using System.Threading;

namespace Projeto_Vendas_CSharp
{
    public partial class FrmHomeInicial : Form
    {
        bool SideBarExpacao;
        public FrmHomeInicial()
        {
            InitializeComponent();
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

            FrmUser u = new FrmUser();
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
    }
}

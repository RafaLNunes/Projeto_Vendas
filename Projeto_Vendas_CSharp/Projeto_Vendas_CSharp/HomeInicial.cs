namespace Projeto_Vendas_CSharp
{
    public partial class HomeInicial : Form
    {
        bool sidebarexpacao;
        public HomeInicial()
        {
            InitializeComponent();
        }

        private void HomeInicial_Load(object sender, EventArgs e)
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



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }
    }
}

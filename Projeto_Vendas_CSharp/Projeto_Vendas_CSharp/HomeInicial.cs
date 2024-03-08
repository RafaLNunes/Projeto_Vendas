namespace Projeto_Vendas_CSharp
{
    public partial class HomeInicial : Form
    {
        bool sidebarexpacao;
        bool homeretro;
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

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeretro)
            {
                homebar.Height += 10;
                if (homebar.Height == homebar.MaximumSize.Height)
                {
                    homeretro = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                homebar.Height -= 10;
                if (homebar.Height == homebar.MinimumSize.Height)
                {
                    homeretro = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

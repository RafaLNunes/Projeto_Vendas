namespace Projeto_Vendas_CSharp
{
    partial class FrmHomeInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeInicial));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            SideBar = new FlowLayoutPanel();
            homepainel = new Panel();
            panel8 = new Panel();
            button6 = new Button();
            panel7 = new Panel();
            button5 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            homebar = new Panel();
            panel6 = new Panel();
            button4 = new Button();
            panel5 = new Panel();
            homebutton = new Button();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            HomeTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SideBar.SuspendLayout();
            homepainel.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            homebar.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 75);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 7;
            label1.Text = "Menu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.wired_lineal_1326_command_window_line__1_;
            pictureBox2.Location = new Point(9, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(189, 217, 223);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(homepainel);
            SideBar.Controls.Add(homebar);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(236, 621);
            SideBar.MinimumSize = new Size(61, 621);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(236, 621);
            SideBar.TabIndex = 0;
            SideBar.Paint += SideBar_Paint;
            // 
            // homepainel
            // 
            homepainel.Controls.Add(panel8);
            homepainel.Controls.Add(panel7);
            homepainel.Controls.Add(panel3);
            homepainel.Location = new Point(3, 84);
            homepainel.MaximumSize = new Size(233, 142);
            homepainel.MinimumSize = new Size(233, 56);
            homepainel.Name = "homepainel";
            homepainel.Size = new Size(233, 56);
            homepainel.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(189, 217, 223);
            panel8.Controls.Add(button6);
            panel8.ForeColor = Color.Transparent;
            panel8.Location = new Point(0, 99);
            panel8.Name = "panel8";
            panel8.Size = new Size(233, 42);
            panel8.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(182, 205, 209);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = Properties.Resources.system_regular_34_code;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, -29);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 0, 0);
            button6.Size = new Size(233, 99);
            button6.TabIndex = 2;
            button6.Text = "           Explicações";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(189, 217, 223);
            panel7.Controls.Add(button5);
            panel7.ForeColor = Color.Transparent;
            panel7.Location = new Point(0, 1);
            panel7.MinimumSize = new Size(233, 56);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 56);
            panel7.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(189, 217, 223);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = Properties.Resources.wired_lineal_63_home__1_;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-11, -21);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(281, 99);
            button5.TabIndex = 2;
            button5.Text = "           Home";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(189, 217, 223);
            panel3.Controls.Add(button2);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(0, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 42);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(182, 205, 209);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.system_regular_28_info1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, -29);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(233, 99);
            button2.TabIndex = 2;
            button2.Text = "           Sobre nós";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // homebar
            // 
            homebar.BackColor = Color.FromArgb(101, 15, 43);
            homebar.Controls.Add(panel6);
            homebar.Controls.Add(panel5);
            homebar.Location = new Point(3, 146);
            homebar.MaximumSize = new Size(233, 98);
            homebar.MinimumSize = new Size(233, 56);
            homebar.Name = "homebar";
            homebar.Size = new Size(233, 56);
            homebar.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.ForeColor = Color.Transparent;
            panel6.Location = new Point(0, 57);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 41);
            panel6.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(101, 15, 43);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.system_regular_63_settings_cog__1_;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-12, -31);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(281, 99);
            button4.TabIndex = 2;
            button4.Text = "          Configurações";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(101, 15, 43);
            panel5.Controls.Add(homebutton);
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 56);
            panel5.TabIndex = 3;
            // 
            // homebutton
            // 
            homebutton.BackColor = Color.FromArgb(189, 217, 223);
            homebutton.FlatStyle = FlatStyle.Flat;
            homebutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            homebutton.Image = Properties.Resources.wired_lineal_21_avatar;
            homebutton.ImageAlign = ContentAlignment.MiddleLeft;
            homebutton.Location = new Point(-12, -23);
            homebutton.Name = "homebutton";
            homebutton.Padding = new Padding(15, 0, 0, 0);
            homebutton.Size = new Size(281, 99);
            homebutton.TabIndex = 2;
            homebutton.Text = "           User";
            homebutton.TextAlign = ContentAlignment.MiddleLeft;
            homebutton.UseVisualStyleBackColor = false;
            homebutton.Click += button1_Click;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 5;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // HomeTimer
            // 
            HomeTimer.Interval = 5;
            HomeTimer.Tick += HomeTimer_Tick_1;
            // 
            // FrmHomeInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = Properties.Resources.Bem_vindos__nós_somos_a_TUTS__1_1;
            ClientSize = new Size(969, 621);
            Controls.Add(SideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHomeInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosed += FrmHomeInicial_FormClosed;
            Load += HomeInicial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            SideBar.ResumeLayout(false);
            homepainel.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            homebar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel SideBar;
        private System.Windows.Forms.Timer SideBarTimer;
        private Panel panel5;
        private Button homebutton;
        private Panel panel6;
        private Button button4;
        private Panel homebar;
        private Panel homepainel;
        private Panel panel8;
        private Button button6;
        private Panel panel7;
        private Button button5;
        private Panel panel3;
        private Button button2;
        private System.Windows.Forms.Timer HomeTimer;
    }
}

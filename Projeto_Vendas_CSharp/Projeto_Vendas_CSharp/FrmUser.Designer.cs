namespace Projeto_Vendas_CSharp
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            SideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button2 = new Button();
            homebar = new Panel();
            panel6 = new Panel();
            button4 = new Button();
            panel5 = new Panel();
            homebutton = new Button();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            UserTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            visibleImage = new PictureBox();
            visiblePassWord = new ImageList(components);
            SideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            homebar.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visibleImage).BeginInit();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(189, 217, 223);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(panel3);
            SideBar.Controls.Add(homebar);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(236, 581);
            SideBar.MinimumSize = new Size(63, 581);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(236, 581);
            SideBar.TabIndex = 1;
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
            label1.Location = new Point(60, 30);
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
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(189, 217, 223);
            panel3.Controls.Add(button2);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(3, 84);
            panel3.MinimumSize = new Size(233, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 56);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(189, 217, 223);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.wired_lineal_63_home__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-12, -22);
            button2.MaximumSize = new Size(281, 99);
            button2.MinimumSize = new Size(281, 99);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(281, 99);
            button2.TabIndex = 2;
            button2.Text = "          Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // homebar
            // 
            homebar.BackColor = Color.FromArgb(189, 217, 223);
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
            button4.BackColor = Color.FromArgb(182, 205, 209);
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
            homebutton.Text = "          User";
            homebutton.TextAlign = ContentAlignment.MiddleLeft;
            homebutton.UseVisualStyleBackColor = false;
            homebutton.Click += homebutton_Click;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 2;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // UserTimer
            // 
            UserTimer.Interval = 2;
            UserTimer.Tick += UserTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 251);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "PassWord";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(513, 248);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '•';
            txtPassWord.Size = new Size(159, 23);
            txtPassWord.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(513, 212);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(159, 23);
            txtUserName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 215);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "UserName";
            // 
            // visibleImage
            // 
            visibleImage.Location = new Point(678, 251);
            visibleImage.Name = "visibleImage";
            visibleImage.Size = new Size(30, 30);
            visibleImage.SizeMode = PictureBoxSizeMode.AutoSize;
            visibleImage.TabIndex = 9;
            visibleImage.TabStop = false;
            visibleImage.Click += pictureBox1_Click;
            // 
            // visiblePassWord
            // 
            visiblePassWord.ColorDepth = ColorDepth.Depth8Bit;
            visiblePassWord.ImageStream = (ImageListStreamer)resources.GetObject("visiblePassWord.ImageStream");
            visiblePassWord.TransparentColor = Color.Transparent;
            visiblePassWord.Images.SetKeyName(0, "visivel.png");
            visiblePassWord.Images.SetKeyName(1, "olho.png");
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 581);
            Controls.Add(visibleImage);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(txtPassWord);
            Controls.Add(SideBar);
            Controls.Add(label2);
            Name = "FrmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUser";
            FormClosed += FrmUser_FormClosed;
            Load += FrmUser_Load;
            SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            homebar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visibleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel SideBar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button button2;
        private Panel homebar;
        private Panel panel6;
        private Button button4;
        private Panel panel5;
        private Button homebutton;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Timer UserTimer;
        private Label label2;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Label label3;
        private PictureBox visibleImage;
        private ImageList visiblePassWord;
    }
}
namespace Projeto_Vendas_CSharp
{
    partial class HomePrincipal
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
            SideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            SideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(101, 15, 43);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(panel3);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(panel4);
            SideBar.Controls.Add(panel5);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(236, 581);
            SideBar.MinimumSize = new Size(67, 581);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(236, 581);
            SideBar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 75);
            panel1.TabIndex = 3;
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
            panel3.Controls.Add(button2);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(3, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 56);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(101, 15, 43);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.wired_lineal_63_home__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-11, -21);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(281, 99);
            button2.TabIndex = 2;
            button2.Text = "          Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(3, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 56);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(101, 15, 43);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.system_regular_63_settings_cog;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -21);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(281, 99);
            button1.TabIndex = 2;
            button1.Text = "          Vendas";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(3, 208);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 56);
            panel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(101, 15, 43);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.wired_lineal_21_avatar;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-11, -23);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(281, 99);
            button3.TabIndex = 2;
            button3.Text = "          User";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(3, 270);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 56);
            panel5.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(101, 15, 43);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.wired_lineal_153_bar_chart;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-11, -23);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(281, 99);
            button4.TabIndex = 2;
            button4.Text = "          Vendas";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 5;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // HomePrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 581);
            Controls.Add(SideBar);
            Name = "HomePrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePrincipal";
            Load += HomePrincipal_Load;
            SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel SideBar;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer SideBarTimer;
    }
}
namespace Projeto_Vendas_CSharp
{
    partial class FrmAviso
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            textAviso = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(textAviso);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 410);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // textAviso
            // 
            textAviso.AutoSize = true;
            textAviso.BackColor = Color.Transparent;
            textAviso.FlatStyle = FlatStyle.Popup;
            textAviso.Location = new Point(3, 0);
            textAviso.Name = "textAviso";
            textAviso.Size = new Size(50, 20);
            textAviso.TabIndex = 0;
            textAviso.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(296, 85);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 88);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(305, 3);
            button2.Name = "button2";
            button2.Size = new Size(300, 85);
            button2.TabIndex = 2;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmAviso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 504);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(618, 551);
            MinimumSize = new Size(618, 551);
            Name = "FrmAviso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAviso";
            Load += FrmAviso_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label textAviso;
        private Button button1;
        private Panel panel1;
        private Button button2;
    }
}
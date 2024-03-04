namespace Projeto_Vendas_CSharp
{
    partial class Armazem_de_dados_Extras
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
            panel2 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(284, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 56);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 169, 130);
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.wired_lineal_63_home__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -22);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(281, 99);
            button1.TabIndex = 2;
            button1.Text = "          Vendas";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Armazem_de_dados_Extras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "Armazem_de_dados_Extras";
            Text = "Armazem_de_dados_Extras";
            Load += Armazem_de_dados_Extras_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
    }
}
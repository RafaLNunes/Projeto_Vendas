﻿using System;
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
    public partial class FrmExplicacao : Form
    {
        public FrmExplicacao()
        {
            InitializeComponent();
        }

        private void FrmExplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

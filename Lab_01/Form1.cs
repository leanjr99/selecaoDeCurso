﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class Lab01Form : Form
    {
        public Lab01Form()
        {
            InitializeComponent();
        }

        private void exibirButton_Click(object sender, EventArgs e)
        {
            mensagemLabel.Text = "Olá, " + nomeTextBox.Text.ToUpper() + "\nBem vindo(a)" +
                " ao curso de " + cursoComboBox.Text;
        }
    }
}

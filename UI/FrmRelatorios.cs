﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apBiblioteca_22132_22148.BLL;
using apBiblioteca_22132_22148.DTO;

namespace apBiblioteca_22132_22148.UI
{
    public partial class FrmRelatorios : Form
    {
        public string banco, usuario, senha;

        public FrmRelatorios(string banco, string usuario, string senha)
        {
            InitializeComponent();
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;

            LivroBLL livroBLL = new LivroBLL(banco, usuario, senha);
            //lbQtosLivros.Text = livroBLL;
            //lbQtsLivrosEmprestados.Text = livroBLL.
            //lbQtosLivrosDevolvidos.Text = livroBLL.
        }
    }
}

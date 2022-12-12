using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace apBiblioteca_22132_22148.UI
{
    public partial class FrmPrincipal : Form
    {

        FrmLivro frmLivro = null;
        FrmLeitor frmLeitor = null;
        FrmOperacoes frmOperacoes = null;

        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmLivro = new FrmLivro(txtBanco.Text, txtUsuario.Text, txtSenha.Text); 
                frmLivro.Show();
            }
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmLeitor = new FrmLeitor(txtBanco.Text, txtUsuario.Text, txtSenha.Text);
               /* frmLeitor.banco = txtBanco.Text;
                frmLeitor.usuario = txtUsuario.Text;
                frmLeitor.senha = txtSenha.Text;*/
                frmLeitor.Show();
            }
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha os dados de conexão!");
            else
            {
                frmOperacoes = new FrmOperacoes(txtBanco.Text, txtUsuario.Text, txtSenha.Text);
                frmOperacoes.Show();
            }
        }
    }
}

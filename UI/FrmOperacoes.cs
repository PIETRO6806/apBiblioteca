using System;
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
    public partial class FrmOperacoes : Form
    {
        public string banco, usuario, senha;

        public FrmOperacoes(string banco, string usuario, string senha)
        {
            InitializeComponent();
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now.Date;
            DateTime devPrevista = DateTime.Now.AddDays(14).Date;

            txtDataDeEmprestimo.Text = hoje.ToString();
            txtDataDeDevolucaoPrevista.Text = devPrevista.ToString();
            var emprestimo = new Emprestimo(int.Parse(txtIdEmprestimo.Text),
                int.Parse(txtIdLivro.Text), int.Parse(txtIdLeitor.Text),
                hoje, devPrevista, devPrevista);
            try
            {
                var bll = new EmprestimoBLL(banco, usuario, senha);
                bll.IncluirEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}

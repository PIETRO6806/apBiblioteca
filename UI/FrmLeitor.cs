using apBiblioteca_22132_22148.BLL;
using apBiblioteca_22132_22148.DTO;
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
    public partial class FrmLeitor : Form
    {
        public string banco, usuario, senha;

        public FrmLeitor(string banco, string usuario, string senha)
        {
            InitializeComponent();
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var leitor = new Leitor(int.Parse(txtIdLeitor.Text), txtNomeLeitor.Text, txtTelefoneLeitor.Text,
            txtEmailLeitor.Text, txtEnderecoLeitor.Text);

            try
            {
                var bll = new LeitorBLL(banco, usuario, senha);
                bll.AlterarLeitor(leitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var leitor = new Leitor(int.Parse(txtIdLeitor.Text), "", "", "", "");
            try
            {
                var bll = new LeitorBLL(banco, usuario, senha);
                bll.ExcluirLeitor(leitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new LeitorBLL(banco, usuario, senha);
                dgvLeitor.DataSource = bll.SelecionarLeitores();
                dgvLeitor.Columns[0].HeaderText = "Identificação";
                dgvLeitor.Columns[1].HeaderText = "Nome";
                dgvLeitor.Columns[2].HeaderText = "Telefone";
                dgvLeitor.Columns[3].HeaderText = "Email";
                dgvLeitor.Columns[4].HeaderText = "Endereço";

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string id = txtIdLeitor.Text;
            var leitor = new Leitor(0, id, "", "", "");
            try
            {
                var bll = new LeitorBLL(banco, usuario, senha);
                leitor = bll.ListarLeitorPorId(int.Parse(id));
                txtIdLeitor.Text = leitor.IdLeitor.ToString();
                txtNomeLeitor.Text = leitor.NomeLeitor;
                txtTelefoneLeitor.Text = leitor.TelefoneLeitor;
                txtEmailLeitor.Text = leitor.EmailLeitor;
                txtEnderecoLeitor.Text = leitor.EnderecoLeitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var leitor = new Leitor(int.Parse(txtIdLeitor.Text), txtNomeLeitor.Text, txtTelefoneLeitor.Text, txtEmailLeitor.Text, 
                                    txtEnderecoLeitor.Text);
            try
            {
                var bll = new LeitorBLL(banco, usuario, senha);
                bll.IncluirLeitor(leitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }
        }
    }
}

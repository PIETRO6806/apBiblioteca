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
    }
}

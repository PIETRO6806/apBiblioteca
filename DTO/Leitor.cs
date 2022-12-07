using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca_22132_22148
{
    class Leitor
    {
        const int tamanhoLeitor = 50;
        const int tamanhoTelefone = 20;
        const int tamanhoEmail = 50;
        const int tamanhoEndereco = 100;
        int idLeitor;
        string nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor;

        public int IdLeitor
        {
            get => idLeitor;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLeitor = value;
            }
        }

        public string NomeLeitor
        {
            get => nomeLeitor;
            set
            {
                value = value.Remove(tamanhoLeitor);
                value = value.PadLeft(tamanhoLeitor, '0');
                nomeLeitor = value;
            }
        }

        public string TelefoneLeitor
        {
            get => telefoneLeitor;
            set
            {
                value = value.Remove(tamanhoTelefone);
                value = value.PadLeft(tamanhoTelefone, ' ');
                telefoneLeitor = value;
            }
        }

        public string EmailLeitor
        {
            get => emailLeitor;
            set
            {
                value = value.Remove(tamanhoEmail);
                value = value.PadLeft(tamanhoEmail, ' ');
                emailLeitor = value;
            }
        }

        public string EnderecoLeitor
        {
            get => enderecoLeitor;
            set
            {
                value = value.Remove(tamanhoEndereco);
                value = value.PadLeft(tamanhoEndereco, ' ');
                enderecoLeitor = value;
            }
        }

        public Leitor(int id, string nome, string telefone, string email, string endereco)
        {
            IdLeitor = id;
            NomeLeitor = nome;
            TelefoneLeitor = telefone;
            EmailLeitor = email;
            EnderecoLeitor = endereco;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca_22132_22148.DTO
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
                if (value.Length > tamanhoLeitor)
                {
                    value = value.Remove(tamanhoLeitor);
                }
                nomeLeitor = value;
            }
        }

        public string TelefoneLeitor
        {
            get => telefoneLeitor;
            set
            {
                if (value.Length > tamanhoTelefone)
                {
                    value = value.Remove(tamanhoTelefone);
                }
                telefoneLeitor = value;
            }
        }

        public string EmailLeitor
        {
            get => emailLeitor;
            set
            {
                if (value.Length > tamanhoEmail)
                {
                    value = value.Remove(tamanhoEmail);
                }
                emailLeitor = value;
            }
        }

        public string EnderecoLeitor
        {
            get => enderecoLeitor;
            set
            {
                if (value.Length > tamanhoEndereco)
                {
                    value = value.Remove(tamanhoEndereco);
                }
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

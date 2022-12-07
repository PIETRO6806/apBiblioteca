using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca_22132_22148.DTO
{
    class Emprestimo
    {
        int idEmprestimo, idLivro, idLeitor;
        DateTime dataEmprestimo, dataDevolucaoPrevista, dataDevolucaoReal;

        public int IdEmprestimo
        {
            get => idEmprestimo;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idEmprestimo = value;
            }
        }

        public int IdLivro
        {
            get => idLivro;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLivro = value;
            }
        }

        public int IdLeitor
        {
            get => idLeitor;
            set
            {
                if (value < 0)
                    throw new Exception("Id negativo é inválido!");
                idLivro = value;
            }
        }

        public DateTime DataEmprestimo
        {
            get => dataEmprestimo;
            set
            {
                dataEmprestimo = value;
            }
        }

        public DateTime DataDevolucaoPrevista
        {
            get => dataDevolucaoPrevista;
            set
            {
                dataDevolucaoPrevista = value;
            }
        }

        public DateTime DataDevolucaoReal
        {
            get => dataDevolucaoReal;
            set
            {
                dataDevolucaoReal = value;
            }
        }

        public Emprestimo(int emprestimo, int livro, int leitor,
                          DateTime data, DateTime dataDevolucaoPrevista,
                          DateTime dataDevolucaoReal)
        {
            IdEmprestimo = emprestimo;
            IdLivro = livro;
            IdLeitor = leitor;
            DataEmprestimo = data;
            DataDevolucaoPrevista = dataDevolucaoPrevista;
            DataDevolucaoReal = dataDevolucaoReal;
        }
    }
}

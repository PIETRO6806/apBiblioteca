using System;
using System.Collections.Generic;
using System.Data;
using apBiblioteca_22132_22148.DAL;
using apBiblioteca_22132_22148.DTO;
namespace apBiblioteca_22132_22148.BLL
{
    class EmprestimoBLL
    {
        public string banco, usuario, senha;
        EmprestimoDAL dal = null;
        public EmprestimoBLL(string banco, string usuario, string senha)
        {
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }
        public DataTable SelecionarEmprestimos()
        {
            {
                DataTable tb = new DataTable();
                try
                {
                    dal = new EmprestimoDAL(banco, usuario, senha);
                    tb = dal.SelectEmprestimos();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return tb;
            }
        }
        public void IncluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                LivroDAL livroDal = new LivroDAL(banco, usuario, senha);
                if(livroDal.SelectLivroById(emprestimo.IdLivro) == null)  //se o livro não existir, não se pode emprestá-lo
                {
                    throw new Exception("Não é possível emprestar um livro que não existe!");
                }

                LeitorDAL leitorDal = new LeitorDAL(banco, usuario, senha); //se o leitor não existir, não se pode emprestar livros para ele
                if(leitorDal.SelectLeitorById(emprestimo.IdLeitor) == null)
                {
                    throw new Exception("Não é póssível emprestar um livro para alguém que não existe!");
                }

                dal = new EmprestimoDAL(banco, usuario, senha);
                if(dal.SelectCountEmprestimosByIdLeitor(emprestimo.IdLeitor) >= 5)  //se o leitor já tiver 5 empréstimos, ele não pode
                {                                                                   //emprestar mais até devolver algum
                    throw new Exception("Não é possível emprestar mais livros para o Leitor, pois ele já tem 5 empréstimos pendentes!");
                }
                dal.InsertEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AlterarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                dal.UpdateEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                dal.DeleteEmprestimo(emprestimo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Emprestimo> ListarEmprestimos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectListEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Emprestimo ListarEmprestimoPorId(int id)
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                return dal.SelectEmprestimoById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QuantosEmprestimosPorIdLeitor(int idLeitor)
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                return dal.SelectCountEmprestimosByIdLeitor(idLeitor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int QuantosEmprestimosPorIdLivro(int idLivro)
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                return dal.SelectCountEmprestimosByIdLivro(idLivro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QuantosEmprestimos()
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                return dal.SelectCountEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int QuantosLeitoresComEmprestimos()
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                return dal.SelectCountLeitoresWithEmprestimos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectLivroComMaiorDemanda()
        {
            try
            {
                dal = new EmprestimoDAL(banco, usuario, senha);
                return dal.SelectTop1CountLivrosWithEmprestimo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

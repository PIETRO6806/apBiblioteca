using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    class LivroBLL
    {
        public string banco, usuario, senha;
        LivroDAL dal = null;
        public LivroBLL(string banco, string usuario, string senha)
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
                    dal = new DAL.EmprestimoDAL(banco, usuario, senha);
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
                dal = new DAL.LivroDAL(banco, usuario, senha);
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
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
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
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
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
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectEmprestimoByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Emprestimo ListarEmprestimoPorCodigo(string codigo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
                return dal.SelectEmprestimoByCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

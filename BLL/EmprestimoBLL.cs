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
                dal = new DAL.EmprestimoDAL(banco, usuario, senha);
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
                return dal.SelectEmprestimoById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /*public Emprestimo ListarEmprestimoPorCodigo(string codigo)
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
        }*/
    }
}

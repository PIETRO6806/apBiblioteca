using System;
using System.Collections.Generic;
using System.Data;
using apBiblioteca_22132_22148.DAL;
using apBiblioteca_22132_22148.DTO;
namespace apBiblioteca_22132_22148.BLL
{
    class LeitorBLL
    {
        public string banco, usuario, senha;
        LeitorDAL dal = null;
        public LeitorBLL(string banco, string usuario, string senha)
        {
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }
        public DataTable SelecionarLeitores()
        {
            {
                DataTable tb = new DataTable();
                try
                {
                    dal = new LeitorDAL(banco, usuario, senha);
                    tb = dal.SelectLeitores();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return tb;
            }
        }
        public void IncluirLeitor(Leitor leitor)
        {
            try
            {
                dal = new LeitorDAL(banco, usuario, senha);
                dal.InsertLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AlterarLeitor(Leitor leitor)
        {
            try
            {
                dal = new LeitorDAL(banco, usuario, senha);
                dal.UpdateLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirLeitor(Leitor leitor)
        {
            try
            {
                EmprestimoDAL dalEmprestimo = new EmprestimoDAL(banco, usuario, senha);
                if (dalEmprestimo.SelectEmprestimoByIdLivro(leitor.IdLeitor) != null) //se o leitor tiver pendências com a Biblioteca ainda,
                {                                                                     //ele não pode ser excluído
                    throw new Exception("Não é possível excluir o Leitor, pois há emprestimos com ele!");
                }
                    dal = new LeitorDAL(banco, usuario, senha);
                    dal.DeleteLeitor(leitor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Leitor> ListarLeitores()
        {
            try
            {
                dal = new LeitorDAL(banco, usuario, senha);
                return dal.SelectListLeitores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Leitor ListarLeitorPorId(int id)
        {
            try
            {
                dal = new LeitorDAL(banco, usuario, senha);
                return dal.SelectLeitorById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

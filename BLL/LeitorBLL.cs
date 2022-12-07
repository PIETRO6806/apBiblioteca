using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    class LeitorBLL
    {
        public string banco, usuario, senha;
        LivroDAL dal = null;
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
                    dal = new DAL.LeitorDAL(banco, usuario, senha);
                    tb = dal.SelectLeitor();
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
                dal = new DAL.LeitorDAL(banco, usuario, senha);
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
                dal = new DAL.LeitorDAL(banco, usuario, senha);
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
                dal = new DAL.LeitorDAL(banco, usuario, senha);
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
                dal = new DAL.LeitorDAL(banco, usuario, senha);
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
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectLeitorByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Leitor ListarLeitorPorCodigo(string codigo)
        {
            try
            {
                dal = new DAL.LeitorDAL(banco, usuario, senha);
                return dal.SelectLeitorByCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

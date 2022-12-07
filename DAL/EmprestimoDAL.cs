using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using apBiblioteca_22132_22148.DTO;

namespace apBiblioteca_22132_22148.DAL
{
    class EmprestimoDAL
    {
        string _conexaoSQLServer = "";
        SqlConnection _conexao = null;

        public EmprestimoDAL(string banco, string usuario, string senha)
        {
            _conexaoSQLServer =
                $"Data Source=regulus.cotuca.unicamp.br; Initial Catalog={banco};" +
                $"User id={usuario}; Password={senha}";
            _conexao = new SqlConnection(_conexaoSQLServer);
        }
        public List<Emprestimo> SelectListEmprestimos()
        {
            try
            {
                var cmd = new SqlCommand("Select * from bibEmprestimo", _conexao);
                _conexao.Open();
                var listaEmprestimos = new List<Emprestimo>();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                    (int)dr["idLivro"]/* + ""*/,
                    (int)dr["idLeitor"] /*+ ""*/,
                    (DateTime)dr["dataEmprestimo"] /*+ ""*/,
                    (DateTime)dr["dataDevolucaoPrevista"] /*= ""*/,
                    (DateTime)dr["dataDevolucaoReal"] /*= ""*/
                    );
                    listaEmprestimos.Add(emprestimo);
                }
                _conexao.Close();
                return listaEmprestimos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar emprestimo " + ex.Message);
            }
        }
        public DataTable SelectEmprestimos()
        {
            {
                try
                {
                    string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo" +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo";
                    SqlCommand cmd = new SqlCommand(sql, _conexao);
                    _conexao.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    _conexao.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public Emprestimo SelectEmprestimoById(int idDesejado)
        {
            try
            {
                string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo" +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo" +
                        "WHERE idEmprestimo = @id";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;
                if (dr.Read())
                {
                    emprestimo = new Emprestimo(Convert.ToInt32(dr["idEmprestimo"]),
                    Convert.ToInt32(dr["idLivro"].ToString()),
                    Convert.ToInt32(dr["idLeitor"].ToString()),
                    Convert.ToDateTime(dr["dataEmprestimo"].ToString()),
                    Convert.ToDateTime(dr["dataDevolucaoPrevista"].ToString()),
                    Convert.ToDateTime(dr["dataDevolucaoReal"].ToString()));

                }
                _conexao.Close();
                return emprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       /* public Emprestimo SelectEmprestimoByCodigo(string codigoDesejado)
        {
            try
            {
                string sql = " SELECT idLivro, codigoLivro, tituloLivro, autorLivro " +
                " FROM bibLivro WHERE codigoLivro = @codigo";
                var cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Livro livro = null;
                if (dr.Read())
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                    dr["codigoLivro"].ToString(),
                    dr["tituloLivro"].ToString(),
                    dr["autoroLIvro"].ToString());

                _conexao.Close();
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                string sql = "INSERT INTO bibEmprestimo " +
                " (idLivro, idLeitor, dataEmprestimo, dataDevolucaoPrevista, datDevolucaoReal) " +
                " VALUES (@livro,@leitor, @data, @dataDevolucaoPrevista, @dataDevolucaoReal) ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@livro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@leitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@data", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dataDevolucaoReal", qualEmprestimo.DataDevolucaoReal);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }
        public void DeleteEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "DELETE FROM bibEmprestimo WHERE idEmprestimo = @idEmprestimo ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idEmprestimo", qualEmprestimo.IdEmprestimo);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }
        public void UpdateEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                string sql = "UPDATE bibEmprestimo " +
                " SET idLivro= @livro, idLeitor=@leitor," +
                " dataEmprestimo=@data, dataDevolucaoPrevista=@dataDevolucaoPrevista," +
                "dataDevolucaoReal=@dataDevolucaoReal" +
                " WHERE idEmprestimo = @idEmprestimo ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idEmprestimo", qualEmprestimo.IdEmprestimo);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@data", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dataDevolucaoReal", qualEmprestimo.DataDevolucaoReal);
                _conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexao.Close();
            }
        }
    }
}


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
                    (int)dr["idLivro"],
                    (int)dr["idLeitor"],
                    (DateTime)dr["dataEmprestimo"],
                    (DateTime)dr["dataDevolucaoPrevista"],
                    (DateTime)dr["dataDevolucaoReal"]
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
                    string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo," +
                        "dataDevolucaoPrevista FROM bibEmprestimo WHERE dataDevolucaoReal = '9999-12-31'"; //valor do DateTime.MaxValue, quer dizer que ainda não foi devolvido
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

        public DataTable SelectDevolucoes()
        {
            {
                try
                {
                    string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo," +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo WHERE dataDevolucaoReal != '9999-12-31'";
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
                string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo," +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo" +
                        " WHERE idEmprestimo = @id";
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
        public Emprestimo SelectEmprestimoByIdLivro(int idDesejado)
        {
            try
            {
                string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo," +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo" +
                        " WHERE idLivro = @id";
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

        public Emprestimo SelectEmprestimoByIdLeitor(int idDesejado)
        {
            try
            {
                string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo," +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo" +
                        " WHERE idLeitor = @id";
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

        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                string sql = "INSERT INTO bibEmprestimo " +
                 " (idLivro, idLeitor, dataEmprestimo, dataDevolucaoPrevista, dataDevolucaoReal) " +
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
                string sql = "DELETE FROM bibEmprestimo WHERE idEmprestimo = @idEmprestimo ";
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
                " SET idLivro= @idLivro, idLeitor=@idLeitor," +
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

        public int SelectCountEmprestimosByIdLeitor(int idLeitor)
        {
            try
            {
                string sql = "SELECT COUNT(*) AS 'quantos' FROM bibEmprestimo WHERE idLeitor = @id AND dataDevolucaoReal = '9999-12-31'";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idLeitor);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantosEmprestimosByIdLeitor = 0;
                if (dr.Read())
                {
                    quantosEmprestimosByIdLeitor = int.Parse(dr["quantos"].ToString());
                }
                _conexao.Close();
                return quantosEmprestimosByIdLeitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectCountEmprestimosByIdLivro(int idLivro)
        {
            try
            {
                string sql = "SELECT COUNT(*) AS 'quantos' FROM bibEmprestimo WHERE idLivro = @id AND dataDevolucaoReal = '9999-12-31'";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idLivro);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantosEmprestimosByIdLivro = 0;
                if (dr.Read())
                {
                    quantosEmprestimosByIdLivro = int.Parse(dr["quantos"].ToString());
                }
                _conexao.Close();
                return quantosEmprestimosByIdLivro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectCountEmprestimos()
        {
            try
            {
                string sql = "SELECT COUNT(*) AS 'quantos' FROM bibEmprestimo WHERE dataDevolucaoReal = '9999-12-31'";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantosEmprestimos= 0;
                if (dr.Read())
                {
                    quantosEmprestimos = int.Parse(dr["quantos"].ToString());
                }
                _conexao.Close();
                return quantosEmprestimos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectCountLeitoresWithEmprestimos()
        {
            try
            {
                string sql = "SELECT COUNT(DISTINCT idLeitor) AS 'quantos' FROM bibEmprestimo WHERE dataDevolucaoReal = '9999-12-31'";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantosLeitoresComEmprestimo = 0;
                if (dr.Read())
                {
                    quantosLeitoresComEmprestimo = int.Parse(dr["quantos"].ToString());
                }
                _conexao.Close();
                return quantosLeitoresComEmprestimo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectTop1CountLivrosWithEmprestimo()
        {
            try
            {
                string sql = "SELECT TOP 1 idLivro  FROM bibEmprestimo WHERE dataDevolucaoReal = '9999-12-31' GROUP BY IdLivro ORDER BY COUNT(idLivro) DESC";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantosEmprestimos = 0;
                if (dr.Read())
                {
                    quantosEmprestimos = int.Parse(dr["idLivro"].ToString());
                }
                _conexao.Close();
                return quantosEmprestimos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectCountDevolucoes()
        {
            try
            {
                string sql = "SELECT COUNT(*) AS 'quantos' FROM bibEmprestimo WHERE dataDevolucaoReal != '9999-12-31'";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantasDevolucoes = 0;
                if (dr.Read())
                {
                    quantasDevolucoes = int.Parse(dr["quantos"].ToString());
                }
                _conexao.Close();
                return quantasDevolucoes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean EhDevolucao (int idDesejado)
        {
            try
            {
                string sql = "SELECT idEmprestimo,idLivro,idLeitor,dataEmprestimo," +
                        "dataDevolucaoPrevista, dataDevolucaoReal FROM bibEmprestimo" +
                        " WHERE idEmprestimo = @id";
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
                if(emprestimo.DataDevolucaoReal != DateTime.MaxValue)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}


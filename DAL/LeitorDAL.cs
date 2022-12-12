using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using apBiblioteca_22132_22148.DTO;

namespace apBiblioteca_22132_22148.DAL
{
    class LeitorDAL
    {
        string _conexaoSQLServer = "";
        SqlConnection _conexao = null;

        public LeitorDAL(string banco, string usuario, string senha)
        {
            _conexaoSQLServer =
                $"Data Source=regulus.cotuca.unicamp.br; Initial Catalog={banco};" +
                $"User id={usuario}; Password={senha}";
            _conexao = new SqlConnection(_conexaoSQLServer);
        }
        public List<Leitor> SelectListLeitores()
        {
            try
            {
                var cmd = new SqlCommand("Select * from bibLeitor", _conexao);
                _conexao.Open();
                var listaLeitores = new List<Leitor>();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var leitor = new Leitor((int)dr["idLeitor"],
                    dr["nomeLeitor"] + "",
                    dr["telefoneLeitor"] + "",
                    dr["emailLeitor"] + "",
                    dr["enderecoLeitor"] + ""
                    );
                    listaLeitores.Add(leitor);
                }
                _conexao.Close();
                return listaLeitores;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar leitor " + ex.Message);
            }
        }
        public DataTable SelectLeitores()
        {
            {
                try
                {
                    string sql = "SELECT idLeitor,nomeLeitor,telefoneLeitor,emailLeitor,enderecoLeitor FROM bibLeitor";
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
        public Leitor SelectLeitorById(int idDesejado)
        {
            try
            {
                string sql = "SELECT idLeitor,nomeLeitor,telefoneLeitor,emailLeitor,enderecoLeitor " +
                " FROM bibLeitor WHERE idLeitor = @id";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                    dr["nomeLeitor"].ToString(),
                    dr["telefoneLeitor"].ToString(),
                    dr["emailLeitor"].ToString(),
                    dr["enderecoLeitor"].ToString()
                    );

                }
                _conexao.Close();
                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Leitor SelectLeitorByNomeLeitor(string nomeDesejado)
        {
            try
            {
                string sql = "SELECT idLeitor,nomeLeitor,telefoneLeitor,emailLeitor,enderecoLeitor " +
                " FROM bibLeitor WHERE nomeLeitor = @nome";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@nome", nomeDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                    dr["nomeLeitor"].ToString(),
                    dr["telefoneLeitor"].ToString(),
                    dr["emailLeitor"].ToString(),
                    dr["enderecoLeitor"].ToString()
                    );

                }
                _conexao.Close();
                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertLeitor(Leitor qualLeitor)
        {
            try
            {
                string sql = "INSERT INTO bibLeitor " +
                " (idLeitor,nomeLeitor, telefoneLeitor, emailLeitor, enderecoLeitor) " +
                " VALUES (@id,@nome,@telefone, @email, @endereco) ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);
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
        public void DeleteLeitor(Leitor qualLeitor)
        {
            try
            {
                string sql = "DELETE FROM bibLeitor WHERE idLeitor = @idLeitor ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLeitor", qualLeitor.IdLeitor);
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
        public void UpdateLeitor(Leitor qualLeitor)
        {
            try
            {
                string sql = "UPDATE bibLeitor " +
                " SET nomeLeitor= @nome, telefoneLeitor=@tel," +
                " emailLeitor=@email, enderecoLeitor=@ender " +
                " WHERE idLeitor = @id ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@tel", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@ender", qualLeitor.EnderecoLeitor);
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

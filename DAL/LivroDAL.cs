﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using apBiblioteca_22132_22148.DTO;

namespace apBiblioteca_22132_22148.DAL
{
    class LivroDAL
    {
        string _conexaoSQLServer = "";
        SqlConnection _conexao = null;

        public LivroDAL(string banco, string usuario, string senha)
        {
            _conexaoSQLServer =
                $"Data Source=regulus.cotuca.unicamp.br; Initial Catalog={banco};" +
                $"User id={usuario}; Password={senha}";
            _conexao = new SqlConnection(_conexaoSQLServer);
        }
        public List<Livro> SelectListLivros()
        {
            try
            {
                var cmd = new SqlCommand("Select * from bibLivro", _conexao);
                _conexao.Open();
                var listaLivros = new List<Livro>();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var livro = new Livro((int)dr["idLivro"],
                    dr["codigoLivro"] + "",
                    dr["tituloLivro"] + "",
                    dr["autorLivro"] + ""
                    );
                    listaLivros.Add(livro);
                }
                _conexao.Close();
                return listaLivros;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar livro " + ex.Message);
            }
        }
        public DataTable SelectLivros()
        {
            {
                try
                {
                    string sql = "SELECT idLivro,codigoLivro,tituloLivro,autorLivro FROM bibLivro";
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
        public Livro SelectLivroById(int idDesejado)
        {
            try
            {
                string sql = "SELECT idLivro, codigoLivro, tituloLivro, autorLivro " +
                " FROM bibLivro WHERE idLivro = @id";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", idDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Livro livro = null;
                if (dr.Read())
                {
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                    dr["codigoLivro"].ToString(),
                    dr["tituloLivro"].ToString(),
                    dr["autorLIvro"].ToString());

                }
                _conexao.Close();
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Livro SelectLivroByCodigo(string codigoDesejado)
        {
            try
            {
                string sql = " SELECT idLivro, codigoLivro, tituloLivro, autorLivro " +
                " FROM bibLivro WHERE codigoLivro = @codigo";
                var cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@codigo", codigoDesejado);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Livro livro = null;
                if (dr.Read())
                    livro = new Livro(Convert.ToInt32(dr["idLivro"]),
                    dr["codigoLivro"].ToString(),
                    dr["tituloLivro"].ToString(),
                    dr["autorLIvro"].ToString());

                _conexao.Close();
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertLivro(Livro qualLivro)
        {
            try
            {
                string sql = "INSERT INTO bibLivro " +
                " (idLivro, codigoLivro, tituloLivro, autorLivro) " +
                " VALUES (@id,@codigo,@titulo, @autor) ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@id", qualLivro.IdLivro);
                cmd.Parameters.AddWithValue("@codigo", qualLivro.CodigoLivro);
                cmd.Parameters.AddWithValue("@titulo", qualLivro.TituloLivro);
                cmd.Parameters.AddWithValue("@autor", qualLivro.AutorLivro);
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
        public void DeleteLivro(Livro qualLivro)
        {
            try
            {
                String sql = "DELETE FROM bibLivro WHERE idLivro = @idLivro ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualLivro.IdLivro);
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
        public void UpdateLivro(Livro qualLivro)
        {
            try
            {
                string sql = "UPDATE bibLivro " +
                " SET tituloLivro= @titulo, codigoLivro=@codigo," +
                " autorLivro=@autor " +
                " WHERE idLivro = @idLivro ";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualLivro.IdLivro);
                cmd.Parameters.AddWithValue("@codigo", qualLivro.CodigoLivro);
                cmd.Parameters.AddWithValue("@titulo", qualLivro.TituloLivro);
                cmd.Parameters.AddWithValue("@autor", qualLivro.AutorLivro);
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

        public int SelectCountLivros()
        {
            try
            {
                string sql = "SELECT COUNT(*) AS 'quantos' FROM bibLivro";
                SqlCommand cmd = new SqlCommand(sql, _conexao);
                _conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int quantosLivros = 0;
                if (dr.Read())
                {
                    quantosLivros = int.Parse(dr["quantos"].ToString());
                }
                _conexao.Close();
                return quantosLivros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

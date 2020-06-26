using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.DAL
{
    public class CadastroProd
    {
        private string strCon = Conexao.getConexao();

        //Método para recuperar Dados da Tabela de CadastroProd
        public List<MODEL.CadastroProd> Select()
        {
            List<MODEL.CadastroProd> lstCadastroProd = new List<MODEL.CadastroProd>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestCadastroProd;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
                while (dados.Read())
                {
                    MODEL.CadastroProd cadastroProd = new MODEL.CadastroProd();
                    cadastroProd.id = Convert.ToInt32(dados["id"].ToString());
                    cadastroProd.tipo = dados["tipo"].ToString();
                    cadastroProd.preco = Convert.ToSingle(dados["preco"].ToString());
                    cadastroProd.desconto = Convert.ToSingle(dados["desconto"].ToString());
                    cadastroProd.observacao = dados["observacao"].ToString();
                    cadastroProd.categoriaId = Convert.ToInt32(dados["categoriaId"].ToString());

                    lstCadastroProd.Add(cadastroProd);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Cadastro de Produto...");
            }
            finally
            {
                conexao.Close();
            }

            return lstCadastroProd;
        }
        public MODEL.CadastroProd SelectByID(int id)
        {
            MODEL.CadastroProd cadastroProd = new MODEL.CadastroProd();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestCadastroProd WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    cadastroProd.id = Convert.ToInt32(dados["id"].ToString());
                    cadastroProd.tipo = dados["tipo"].ToString();
                    cadastroProd.preco = Convert.ToSingle(dados["preco"].ToString());
                    cadastroProd.desconto = Convert.ToSingle(dados["desconto"].ToString());
                    cadastroProd.observacao = dados["observacao"].ToString();
                    cadastroProd.categoriaId = Convert.ToInt32(dados["categoriaId"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Cadastro Produto por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return cadastroProd;
        }
        public MODEL.CadastroProd SelectByTipo(string tipo)
        {
            MODEL.CadastroProd cadastroProd = new MODEL.CadastroProd();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestCadastroProd WHERE (tipo LIKE @tipo)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@tipo", "%" + tipo.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    cadastroProd.id = Convert.ToInt32(dados["id"].ToString());
                    cadastroProd.tipo = dados["tipo"].ToString();
                    cadastroProd.preco = Convert.ToSingle(dados["preco"].ToString());
                    cadastroProd.desconto = Convert.ToSingle(dados["desconto"].ToString());
                    cadastroProd.observacao = dados["observacao"].ToString();
                    cadastroProd.categoriaId = Convert.ToInt32(dados["categoriaId"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Cadastro de Produtos por Tipo...");
            }
            finally
            {
                conexao.Close();
            }

            return cadastroProd;
        }


        //Método para Inserir dados na tabela de CadastroProd
        public void Insert(MODEL.CadastroProd cadastroProd)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO RestCadastroProd VALUES (@tipo, @preco, @desconto, @observacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@tipo", cadastroProd.tipo);
            cmd.Parameters.AddWithValue("@preco", cadastroProd.preco);
            cmd.Parameters.AddWithValue("@desconto", cadastroProd.desconto);
            cmd.Parameters.AddWithValue("@observacao", cadastroProd.observacao);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Cadastro de Produto...");
            }
            finally
            {
                conexao.Close();
            }
        }
        //Método para Atualizar dados na tabela de CadastroProd
        public void Update(MODEL.CadastroProd cadastroProd)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE RestCadastroProd SET tipo=@tipo, preco=@preco, desconto=@desconto, observacao=@observacao";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@tipo", cadastroProd.tipo);
            cmd.Parameters.AddWithValue("@preco", cadastroProd.preco);
            cmd.Parameters.AddWithValue("@desconto", cadastroProd.desconto);
            cmd.Parameters.AddWithValue("@observacao", cadastroProd.observacao);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Cadastro de Produto...");
            }
            finally
            {
                conexao.Close();
            }
        }

        //Método para remover CadastroProd
        public void Delete(int idCadastroProd)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM RestCadastroProd WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCadastroProd);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Cadastro de Prod...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

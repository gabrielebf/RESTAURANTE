using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.DAL
{
    public class Categoria
    {
        private string strCon = Conexao.getConexao();

        //Método para recuperar Dados da Tabela de Clientes
        public List<MODEL.Categoria> Select()
        {
            List<MODEL.Categoria> lstCategoria = new List<MODEL.Categoria>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestCategoria;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dados.Read())
                {
                    MODEL.Categoria categoria = new MODEL.Categoria();
                    categoria.id = Convert.ToInt32(dados["id"].ToString());
                    categoria.categoria = dados["categoria"].ToString();

                    lstCategoria.Add(categoria);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Categoria...");
            }
            finally
            {
                conexao.Close();
            }
            return lstCategoria;
        }
        
        public MODEL.Categoria SelectByID(int id)
        {
            MODEL.Categoria categoria = new MODEL.Categoria();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestCategoria WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    categoria.id = Convert.ToInt32(dados["id"].ToString());
                    categoria.categoria = dados["categoria"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Categoria por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return categoria;
        }

        //Método para Inserir dados na tabela de categoria
        public void Insert(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO RestCategoria VALUES (@categoria);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@categoria", categoria.categoria);
            

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de categoria...");
            }
            finally
            {
                conexao.Close();
            }
        }
        //Método para Atualizar dados na tabela de categoria
        public void Update(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE RestCategoria SET categoria=@categoria";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@categoria", categoria.categoria);
            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de categoria...");
            }
            finally
            {
                conexao.Close();
            }
        }

        //Método para remover categoria
        public void Delete(int idCategoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM RestCategoria WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCategoria);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Categoria...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

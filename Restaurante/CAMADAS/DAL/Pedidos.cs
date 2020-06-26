using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.DAL
{
    public class Pedidos
    {
        private string strCon = Conexao.getConexao();

        //Método para recuperar Dados da Tabela de Clientes
        public List<MODEL.Pedidos> Select()
        {
            List<MODEL.Pedidos> lstPedidos = new List<MODEL.Pedidos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestPedido;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Pedidos pedidos = new MODEL.Pedidos();
                    pedidos.id = Convert.ToInt32(dados["id"].ToString());
                    pedidos.descricao = dados["descricao"].ToString();
                    pedidos.pedido = dados["pedido"].ToString();
                    pedidos.bebidas = dados["bebida"].ToString();
                    pedidos.endereco = dados["endereco"].ToString();
                    pedidos.valor = Convert.ToSingle(dados["valor"].ToString());
                    pedidos.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    pedidos.clienteId = Convert.ToInt32(dados["clienteId"].ToString());

                    lstPedidos.Add(pedidos);

                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta no Pedidos...");
            }
            finally
            {
                conexao.Close();
            }

            return lstPedidos;
        }
        public MODEL.Pedidos SelectById(int id)
        {
            MODEL.Pedidos pedidos = new MODEL.Pedidos();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestPedidos WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    pedidos.id = Convert.ToInt32(dados["id"].ToString());
                    pedidos.descricao = dados["descricao"].ToString();
                    pedidos.pedido = dados["pedido"].ToString();
                    pedidos.bebidas = dados["bebidas"].ToString();
                    pedidos.endereco = dados["endereco"].ToString();
                    pedidos.valor = Convert.ToSingle(dados["valor"].ToString());
                    pedidos.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    pedidos.clienteId = Convert.ToInt32(dados["clienteId"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Pedidos por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return pedidos;
        }

        //Método para Inserir dados na tabela de CadastroProd
        public void Insert(MODEL.Pedidos pedidos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO RestPedidos VALUES (@descricao, @pedido, @bebida, @endereco, @valor, @quantidade, @clienteId);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", pedidos.descricao);
            cmd.Parameters.AddWithValue("@pedido", pedidos.pedido);
            cmd.Parameters.AddWithValue("@bebida", pedidos.bebidas);
            cmd.Parameters.AddWithValue("@endereco", pedidos.endereco);
            cmd.Parameters.AddWithValue("@valor", pedidos.valor);
            cmd.Parameters.AddWithValue("@quantidade", pedidos.quantidade);
            cmd.Parameters.AddWithValue("@clienteId", pedidos.clienteId);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Pedidos...");
            }
            finally
            {
                conexao.Close();
            }
        }
        //Método para Atualizar dados na tabela de pedidos
        public void Update(MODEL.Pedidos pedidos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE RestPedidos SET descricao=@descricao, pedido=@pedido, bebida=@bebida, endereco=@endereco, valor=@valor, quantidade=@quantidade, clienteId=@clienteId";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", pedidos.descricao);
            cmd.Parameters.AddWithValue("@pedido", pedidos.pedido);
            cmd.Parameters.AddWithValue("@bebida", pedidos.bebidas);
            cmd.Parameters.AddWithValue("@endereco", pedidos.endereco);
            cmd.Parameters.AddWithValue("@valor", pedidos.valor);
            cmd.Parameters.AddWithValue("@quantidade", pedidos.quantidade);
            cmd.Parameters.AddWithValue("@clienteId", pedidos.clienteId);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Pedidos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        //Método para remover Pedidos
        public void Delete(int idPedidos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM RestPedidos WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idPedidos);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Pedidos...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}


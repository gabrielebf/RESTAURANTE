using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Restaurante.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        //Método para recuperar Dados da Tabela de Clientes
        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestClientes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes clientes = new MODEL.Clientes();
                    clientes.id = Convert.ToInt32(dados["id"].ToString());
                    clientes.nome = dados["nome"].ToString();
                    clientes.telefone = dados["telefone"].ToString();
                    clientes.estado = dados["estado"].ToString();
                    clientes.cidade = dados["cidade"].ToString();
                    clientes.endereco = dados["endereco"].ToString();
                    clientes.numero = dados["numero"].ToString();//qdo for float: Convert.ToSingle(dados[numero].ToString());

                    lstClientes.Add(clientes);

                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de Clientes...");
            }
            finally
            {
                conexao.Close();
            }

            return lstClientes;
        }


        public MODEL.Clientes SelectByID(int id)
        {
            MODEL.Clientes clientes = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestClientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    clientes.id = Convert.ToInt32(dados["id"].ToString());
                    clientes.nome = dados["nome"].ToString();
                    clientes.telefone = dados["telefone"].ToString();
                    clientes.estado = dados["estado"].ToString();
                    clientes.cidade = dados["cidade"].ToString();
                    clientes.endereco = dados["endereco"].ToString();
                    clientes.numero = dados["numero"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return clientes;
        }

        public MODEL.Clientes SelectByNome(string nome)
        {
            MODEL.Clientes clientes = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM RestClientes WHERE(nome LIKE @nome)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    clientes.id = Convert.ToInt32(dados["id"].ToString());
                    clientes.nome = dados["nome"].ToString();
                    clientes.telefone = dados["telefone"].ToString();
                    clientes.estado = dados["estado"].ToString();
                    clientes.cidade = dados["cidade"].ToString();
                    clientes.endereco = dados["endereco"].ToString();
                    clientes.numero = dados["numero"].ToString();
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes por Nome...");
            }
            finally
            {
                conexao.Close();
            }

            return clientes;
        }


        //Método para Inserir dados na tabela de clientes
        public void Insert(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO RestClientes VALUES (@nome, @telefone, @estado, @cidade, @endereco, @numero);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
        //Método para Atualizar dados na tabela de clientes
        public void Update(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE RestClientes SET nome=@nome, telefone=@telefone, estado=@estado, cidade=@cidade, endereco=@endereco, numero=@numero";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
           

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        //Método para remover Cliente
        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM RestClientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

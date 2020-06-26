using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.CAMADAS;

namespace Restaurante.RELATORIOS
{
    public class RelGerais
    {
        public static void relClientes()
        {
            CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> lstCli = new List<CAMADAS.MODEL.Clientes>();
            lstCli = bllCli.Select();

            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelCliente_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                             "content='text/html; charset=utf-8'/>");
                sw.WriteLine(@"<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='ha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Produtos</h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<table class='table table-striped'>");
                //Cabeçalho da tabela
                sw.WriteLine("<tr>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("NOME");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("TELEFONE");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("ESTADO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("CIDADE");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("ENDERECO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='180px'>");
                sw.WriteLine("NUMERO");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");

                int cont = 0;

                foreach (CAMADAS.MODEL.Clientes cliente in lstCli.OrderBy(o => o.id))
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='left' width='180px'>");
                    sw.WriteLine(cliente.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='180px'>");
                    sw.WriteLine(cliente.nome);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='180px'>");
                    sw.WriteLine(cliente.telefone);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='180px'>");
                    sw.WriteLine(cliente.estado);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='180px'>");
                    sw.WriteLine(cliente.cidade);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='180px'>");
                    sw.WriteLine(cliente.endereco);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='300px'>");
                    sw.WriteLine(cliente.numero);
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h3>");
                sw.WriteLine("Total de Clientes Cadastrados: " + cont.ToString());
                sw.WriteLine("</h3>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }




        public static void relPedido()
        {
            CAMADAS.BLL.Pedidos bllPed = new CAMADAS.BLL.Pedidos();
            List<CAMADAS.MODEL.Pedidos> lstPed = new List<CAMADAS.MODEL.Pedidos>();
            lstPed = bllPed.Select();

            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelPedidos_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";
            string arquivoPDF = pasta + @"\RelPedidos_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".pdf";


            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Pedidos</h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr align='right'>");
                sw.WriteLine("<th align='right' width='30px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("DESCRIÇÃO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("PEDIDO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("BEBIDA");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("ENDEREÇO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='60px'>");
                sw.WriteLine("VALOR");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='60px'>");
                sw.WriteLine("QUANTIDADE");
                sw.WriteLine("</tr>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float soma = 0;
                foreach (CAMADAS.MODEL.Pedidos pedido in lstPed.OrderBy(o => o.quantidade))
                {

                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='30px'>");
                    sw.WriteLine(pedido.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(pedido.descricao);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(pedido.pedido);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(pedido.bebidas);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(pedido.endereco);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(string.Format("{0:C2}", pedido.valor));
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(string.Format("{0:C2}", pedido.quantidade));
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    soma = soma + pedido.valor;
                    cont++;
                }



                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<h2>");
                sw.WriteLine("Total de Registros Impressos: " + cont.ToString());
                sw.WriteLine("</br>");
                sw.WriteLine("Valor total dos Pedidos R$: " + string.Format("{0:#.#,00}", soma));
                sw.WriteLine("</body>");
                sw.WriteLine("</h2>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);


        }
    }
}

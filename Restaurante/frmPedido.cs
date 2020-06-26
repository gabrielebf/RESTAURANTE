using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void HabilitarBotoes(bool status)
        {
            cmbCliente.Enabled = !status;
            cmbPedido.Enabled = !status;
            txtBebida.Enabled = !status;
            txtObservacao.Enabled = !status;
            txtQuantidade.Enabled = !status;

            btnNovo.Enabled = status;
            btnGravar.Enabled = !status;

        }
        private void LimparCampos()
        {
            txtObservacao.Text = "";
            txtQuantidade.Text = "";
            txtTotal.Text = "";
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            HabilitarBotoes(true);

            CAMADAS.BLL.Pedidos bllPedidos = new CAMADAS.BLL.Pedidos();
            dgvPedidos.DataSource = "";
            dgvPedidos.DataSource = bllPedidos.Select();

            CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCli.Select();

            CAMADAS.BLL.CadastroProd bllCadP = new CAMADAS.BLL.CadastroProd();
            cmbPedido.DisplayMember = "descricao";
            cmbPedido.ValueMember = "id";
            cmbPedido.DataSource = bllCadP.Select();
        }

        private void limparVenda()
        {
            lblID.Text = "0";
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Pedidos pedidos = new CAMADAS.MODEL.Pedidos();
            pedidos.clienteId = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
            pedidos.pedido = cmbPedido.SelectedValue.ToString();
            pedidos.quantidade = Convert.ToInt32(txtQuantidade.Text);

            CAMADAS.BLL.Pedidos bllPed = new CAMADAS.BLL.Pedidos();
            bllPed.Insert(pedidos);

            MessageBox.Show("Pedido inserido com sucesso", "Pedido inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvPedidos.DataSource = "";
            dgvPedidos.DataSource = bllPed.Select();
            HabilitarBotoes(true);
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarBotoes(false);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

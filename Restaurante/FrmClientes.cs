using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.CAMADAS
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void habilitaControles(bool status)
        {
            txtNome.Enabled = status;
            txtTelefone.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtEndereco.Enabled = status;
            txtNumero.Enabled = status;
        }

        private void habilitaBotoes(bool status)
        {
            btnInserir.Enabled = status;
            btnRemover.Enabled = status;
            btnEditar.Enabled = status;
            btnCancelar.Enabled = !status;
            btnGravar.Enabled = !status;
        }
        private void limparControle()
        {
            lblID.Text = "0";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparControle();
            habilitaControles(true);
            habilitaBotoes(false);
            txtNome.Focus();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            dgvClientes.DataSource = bllClientes.Select();
            habilitaBotoes(true);
            habilitaControles(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "0")
            {
                habilitaControles(true);
                habilitaBotoes(false);
                txtNome.Focus();
            }
            else MessageBox.Show("Não há dados para atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();

            if (lblID.Text != "0")
            {
                string msg = "Deseja remover o atual fornecedor?";
                DialogResult resposta = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int idFornecedor = Convert.ToInt32(lblID.Text);
                    bllClientes.Delete(idFornecedor);
                }
            }
            else MessageBox.Show("Não há dados para remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllClientes.Select();
            limparControle();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparControle();
            habilitaControles(false);
            habilitaBotoes(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            string msg = "";
            if (lblID.Text == "0")
                msg = "Deseja inserir um novo cliente?";
            else msg = "Deseja alterar o cliente atual?";
            DialogResult resposta = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Clientes clientes = new CAMADAS.MODEL.Clientes();
                clientes.nome = txtNome.Text;
                clientes.telefone = txtTelefone.Text;
                clientes.cidade = txtCidade.Text;
                clientes.estado = txtEstado.Text;
                clientes.endereco = txtEndereco.Text;
                clientes.numero = txtNumero.Text;

                if (lblID.Text == "0")
                     bllCli.Insert(clientes);
                else bllCli.Update(clientes);

                MessageBox.Show("Dados Gravados", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Dados Não Gravados", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();

            limparControle();
            habilitaControles(false);
            habilitaBotoes(true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
            CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
            lstClientes = bllCli.Select();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = lstClientes;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
            lstClientes = bllClientes.Select();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = lstClientes;
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o ID: ";
            txtFiltro.Text = "";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o Nome";
            txtFiltro.Text = string.Empty;
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            List<CAMADAS.MODEL.Clientes> lstCli = new List<CAMADAS.MODEL.Clientes>();
            if (rdbTodos.Checked)
                lstCli = bllClientes.Select();
            else if (rdbNome.Checked)
                lstCli.Add(bllClientes.SelectByNome(txtFiltro.Text));
            else
            {
                int id = Convert.ToInt32(txtFiltro.Text);
                lstCli.Add(bllClientes.SelectByID(id));
            }

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = lstCli;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
            txtCidade.Text = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
            txtEstado.Text = dgvClientes.SelectedRows[0].Cells["estado"].Value.ToString();
            txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereço"].Value.ToString();
            txtNumero.Text = dgvClientes.SelectedRows[0].Cells["numero"].Value.ToString();
        }
        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                lblID.Text = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(lblID.Text);
                CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
                CAMADAS.MODEL.Clientes cliente = dalCli.SelectByID(id);
                txtNome.Text = cliente.nome;
                txtTelefone.Text = Convert.ToString(cliente.telefone);
                txtCidade.Text = cliente.cidade;
                txtEstado.Text = cliente.estado;
                txtEstado.Text = cliente.estado;
                txtEndereco.Text = cliente.endereco;
                txtNumero.Text = Convert.ToString(cliente.numero);
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

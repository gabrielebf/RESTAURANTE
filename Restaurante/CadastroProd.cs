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
    public partial class CadastroProd : Form
    {
        public CadastroProd()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
            CAMADAS.BLL.CadastroProd bllCadP = new CAMADAS.BLL.CadastroProd();
            List<CAMADAS.MODEL.CadastroProd> lstCadastroProd = new List<CAMADAS.MODEL.CadastroProd>();
            lstCadastroProd = bllCadP.Select();
            dgvCadastroProd.DataSource = "";
            dgvCadastroProd.DataSource = lstCadastroProd;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o ID: ";
            txtFiltro.Text = "";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe a Tipo";
            txtFiltro.Text = string.Empty;
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Focus();
        }

        private void CadastroProd_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            habilitaBotoes(true);
            CAMADAS.BLL.Pedidos bllPedido = new CAMADAS.BLL.Pedidos();

            CAMADAS.BLL.CadastroProd bllCadastroProd = new CAMADAS.BLL.CadastroProd();
            //cmbCategoria.DisplayMember = "tipo";
            //cmbCategoria.ValueMember = "id";
            //cmbCategoria.DataSource = bllCadastroProd.Select();*/

            dgvCadastroProd.DataSource = "";
            dgvCadastroProd.DataSource = bllCadastroProd.Select();
            limparControle();
        }

        private void habilitaControles(bool status)
        {
            txtTipo.Enabled = status;
            txtValor.Enabled = status;
            //txtDesconto.Enabled = status;
            txtObs.Enabled = status;
            //cmbCategoria.Enabled = status;
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
            txtTipo.Text = "";
            txtValor.Text = "";
            //txtDesconto.Text = null;
            txtObs.Text = "";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparControle();
            habilitaControles(true);
            habilitaBotoes(false);
            txtTipo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "0")
            { 
            habilitaControles(true);
            habilitaBotoes(false);
            txtTipo.Focus();
            }
            else MessageBox.Show("Não há dados para atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.CadastroProd bllCadP = new CAMADAS.BLL.CadastroProd();

            if (lblID.Text != "0")
            {
                string msg = "Deseja remover o atual produto?";
                DialogResult resposta = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int idCadastroProd = Convert.ToInt32(lblID.Text);
                    bllCadP.Delete(idCadastroProd);
                }
            }
            else MessageBox.Show("Não há dados para remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            dgvCadastroProd.DataSource = "";
            dgvCadastroProd.DataSource = bllCadP.Select();
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
            CAMADAS.BLL.CadastroProd bllCadP = new CAMADAS.BLL.CadastroProd();
            string msg = "";
            if (lblID.Text == "0")
                msg = "Deseja inserir um novo produto?";
            else msg = "Deseja alterar o produto atual?";
            DialogResult resposta = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.CadastroProd cadastroProd = new CAMADAS.MODEL.CadastroProd();
                cadastroProd.id = Convert.ToInt32(lblID.Text);
                cadastroProd.tipo = txtTipo.Text;
                cadastroProd.preco = Convert.ToSingle(txtValor.Text);
                //cadastroProd.desconto = Convert.ToSingle(txtDesconto.Text);
                cadastroProd.observacao = txtObs.Text;
                //cadastroProd.categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
                bllCadP.Insert(cadastroProd);
               /* if (lblID.Text == "0")
                    bllCadP.Insert(cadastroProd);
                else bllCadP.Update(cadastroProd);*/

                MessageBox.Show("Dados Gravados", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Dados Não Gravados", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dgvCadastroProd.DataSource = "";
            dgvCadastroProd.DataSource = bllCadP.Select();

            limparControle();
            habilitaControles(false);
            habilitaBotoes(true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void gpbPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.CadastroProd bllCadP = new CAMADAS.BLL.CadastroProd();
            List<CAMADAS.MODEL.CadastroProd> lstCadastroProd = new List<CAMADAS.MODEL.CadastroProd>();
            if (rdbTodos.Checked)
                lstCadastroProd = bllCadP.Select();
            else if (rdbTipo.Checked)
                lstCadastroProd.Add(bllCadP.SelectByTipo(txtFiltro.Text));
            else
            {
                int id = Convert.ToInt32(txtFiltro.Text);
                lstCadastroProd.Add(bllCadP.SelectByID(id));
            }

            dgvCadastroProd.DataSource = "";
            dgvCadastroProd.DataSource = lstCadastroProd;
        }
    }
}

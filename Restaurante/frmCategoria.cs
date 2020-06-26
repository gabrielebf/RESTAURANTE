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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            habilitaBotoes(true);
            CAMADAS.BLL.Categoria bllCategoria = new CAMADAS.BLL.Categoria();

            dgvCategoria.DataSource = "";
            dgvCategoria.DataSource = bllCategoria.Select();
            limparControle();
        }
        private void limparControle()
        {
            lblID.Text = "0";
            txtCategoria.Text = string.Empty;
        }

        private void habilitaControles(bool status)
        {
            txtCategoria.Enabled = status;
        }

        private void habilitaBotoes(bool status)
        {
            btnInserir.Enabled = status;
            btnRemover.Enabled = status;
            btnEditar.Enabled = status;
            btnCancelar.Enabled = !status;
            btnGravar.Enabled = !status;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limparControle();
            habilitaControles(true);
            habilitaBotoes(false);
            txtCategoria.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "0")
            {
                habilitaControles(true);
                habilitaBotoes(false);
                txtCategoria.Focus();
            }
            else MessageBox.Show("Não há dados para atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Categoria bllCategoria = new CAMADAS.BLL.Categoria();

            if (lblID.Text != "0")
            {
                string msg = "Deseja remover a atual categoria?";
                DialogResult resposta = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    bllCategoria.Delete(id);
                }
            }
            else MessageBox.Show("Não há dados para remover", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            dgvCategoria.DataSource = "";
            dgvCategoria.DataSource = bllCategoria.Select();
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
            CAMADAS.BLL.Categoria bllCategoria = new CAMADAS.BLL.Categoria();
            string msg = "";
            if (lblID.Text == "0")
                msg = "Deseja inserir uma novo categoria?";
            else msg = "Deseja alterar a categoria atual?";
            DialogResult resposta = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Categoria categoria = new CAMADAS.MODEL.Categoria();
                categoria.id = Convert.ToInt32(lblID.Text);
                categoria.categoria = txtCategoria.Text;
                bllCategoria.Insert(categoria);
                /*if (lblID.Text == "0")
                    bllCategoria.Insert(categoria);
                else bllCategoria.Update(categoria);*/

                MessageBox.Show("Dados Gravados", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Dados Não Gravados", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dgvCategoria.DataSource = "";
            dgvCategoria.DataSource = bllCategoria.Select();

            limparControle();
            habilitaControles(false);
            habilitaBotoes(true);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            lblID.Text = dgvCategoria.SelectedRows[0].Cells["id"].Value.ToString();
            txtCategoria.Text = dgvCategoria.SelectedRows[0].Cells["descricao"].Value.ToString();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using Restaurante.CAMADAS;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            // dataGridView1.DataSource = dalCli.Select();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre formSb = new FrmSobre();
            formSb.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();//fecha aplicação
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProd frmCadP = new CadastroProd();
            frmCadP.MdiParent = this;
            frmCadP.Show();

        }

        private void dadosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelGerais.relClientes();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelGerais.relPedido();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

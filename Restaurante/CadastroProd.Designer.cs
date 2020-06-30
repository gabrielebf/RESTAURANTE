namespace Restaurante
{
    partial class CadastroProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCadastroProd = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProd)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observação";
            // 
            // dgvCadastroProd
            // 
            this.dgvCadastroProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProd.Location = new System.Drawing.Point(12, 298);
            this.dgvCadastroProd.Name = "dgvCadastroProd";
            this.dgvCadastroProd.Size = new System.Drawing.Size(776, 150);
            this.dgvCadastroProd.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(41, 260);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(89, 32);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(251, 260);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(89, 32);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(356, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(461, 260);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(89, 32);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(146, 260);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 32);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(566, 260);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 32);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(671, 260);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 32);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(204, 199);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(190, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 14;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(190, 86);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(245, 26);
            this.txtTipo.TabIndex = 15;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(190, 128);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 16;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(190, 170);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(245, 26);
            this.txtObs.TabIndex = 18;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.BackColor = System.Drawing.SystemColors.Menu;
            this.gpbPesquisa.Controls.Add(this.txtFiltro);
            this.gpbPesquisa.Controls.Add(this.lblFiltrar);
            this.gpbPesquisa.Controls.Add(this.rdbTipo);
            this.gpbPesquisa.Controls.Add(this.rdbID);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Controls.Add(this.btnFiltrar);
            this.gpbPesquisa.Location = new System.Drawing.Point(485, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(289, 228);
            this.gpbPesquisa.TabIndex = 19;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Filtrar Dados";
            this.gpbPesquisa.Enter += new System.EventHandler(this.gpbPesquisa_Enter);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(12, 159);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(245, 26);
            this.txtFiltro.TabIndex = 19;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Location = new System.Drawing.Point(15, 123);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(100, 23);
            this.lblFiltrar.TabIndex = 17;
            this.lblFiltrar.Click += new System.EventHandler(this.lblFiltrar_Click);
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTipo.Location = new System.Drawing.Point(18, 98);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(55, 22);
            this.rdbTipo.TabIndex = 16;
            this.rdbTipo.TabStop = true;
            this.rdbTipo.Text = "&Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbID.Location = new System.Drawing.Point(18, 64);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(40, 22);
            this.rdbID.TabIndex = 15;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "&ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(18, 30);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(69, 22);
            this.rdbTodos.TabIndex = 14;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "&Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CadastroProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvCadastroProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroProd";
            this.Text = " Cadastro Produto";
            this.Load += new System.EventHandler(this.CadastroProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProd)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCadastroProd;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}
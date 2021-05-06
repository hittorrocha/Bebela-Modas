
namespace Bebela.Modas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSituação = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dudQuantidade = new System.Windows.Forms.DomainUpDown();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(151, 44);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(466, 23);
            this.cbxCliente.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(657, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(328, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 29);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Bebela Modas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxSituação);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.dudQuantidade);
            this.groupBox1.Controls.Add(this.cbxProduto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Situação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor R$:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto:";
            // 
            // cbxSituação
            // 
            this.cbxSituação.FormattingEnabled = true;
            this.cbxSituação.Location = new System.Drawing.Point(486, 46);
            this.cbxSituação.Name = "cbxSituação";
            this.cbxSituação.Size = new System.Drawing.Size(156, 23);
            this.cbxSituação.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(358, 46);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 2;
            // 
            // dudQuantidade
            // 
            this.dudQuantidade.Items.Add("1");
            this.dudQuantidade.Items.Add("2");
            this.dudQuantidade.Items.Add("3");
            this.dudQuantidade.Items.Add("4");
            this.dudQuantidade.Items.Add("5");
            this.dudQuantidade.Items.Add("6");
            this.dudQuantidade.Items.Add("7");
            this.dudQuantidade.Items.Add("8");
            this.dudQuantidade.Items.Add("9");
            this.dudQuantidade.Items.Add("10");
            this.dudQuantidade.Location = new System.Drawing.Point(254, 47);
            this.dudQuantidade.Name = "dudQuantidade";
            this.dudQuantidade.Size = new System.Drawing.Size(72, 23);
            this.dudQuantidade.TabIndex = 1;
            this.dudQuantidade.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(6, 47);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(229, 23);
            this.cbxProduto.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 198);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(831, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(663, 45);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(137, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar Compra";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(663, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbxCliente);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 81);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown dudQuantidade;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSituação;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


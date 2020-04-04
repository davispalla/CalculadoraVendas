namespace CalculadoraVendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Custo = new System.Windows.Forms.TextBox();
            this.txt_Lucro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Venda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.cmb_Produtos = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de Vendas";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(12, 81);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(182, 13);
            this.lbl_Valor.TabIndex = 1;
            this.lbl_Valor.Text = "VALOR DE CUSTO..........................:";
            // 
            // txt_Custo
            // 
            this.txt_Custo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Custo.Location = new System.Drawing.Point(199, 78);
            this.txt_Custo.MaxLength = 10;
            this.txt_Custo.Name = "txt_Custo";
            this.txt_Custo.ShortcutsEnabled = false;
            this.txt_Custo.Size = new System.Drawing.Size(109, 21);
            this.txt_Custo.TabIndex = 2;
            this.txt_Custo.TextChanged += new System.EventHandler(this.txt_Custo_TextChanged);
            this.txt_Custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Custo_KeyPress);
            // 
            // txt_Lucro
            // 
            this.txt_Lucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lucro.Location = new System.Drawing.Point(199, 117);
            this.txt_Lucro.MaxLength = 10;
            this.txt_Lucro.Name = "txt_Lucro";
            this.txt_Lucro.Size = new System.Drawing.Size(109, 21);
            this.txt_Lucro.TabIndex = 3;
            this.txt_Lucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lucro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LUCRO EM %...................................:";
            // 
            // txt_Venda
            // 
            this.txt_Venda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Venda.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Venda.Location = new System.Drawing.Point(199, 154);
            this.txt_Venda.Name = "txt_Venda";
            this.txt_Venda.ReadOnly = true;
            this.txt_Venda.Size = new System.Drawing.Size(109, 23);
            this.txt_Venda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VALOR SUGERIDO PARA VENDA: ";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(152, 183);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "&Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(233, 183);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // cmb_Produtos
            // 
            this.cmb_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Produtos.ItemHeight = 15;
            this.cmb_Produtos.Items.AddRange(new object[] {
            "Ovos",
            "Arroz",
            "Refrigerante Coca-Cola"});
            this.cmb_Produtos.Location = new System.Drawing.Point(15, 38);
            this.cmb_Produtos.Name = "cmb_Produtos";
            this.cmb_Produtos.Size = new System.Drawing.Size(293, 23);
            this.cmb_Produtos.TabIndex = 1;
            this.cmb_Produtos.Tag = "Produtos Cadastrados";
            this.cmb_Produtos.SelectedIndexChanged += new System.EventHandler(this.cmb_Produtos_SelectedIndexChanged);
            this.cmb_Produtos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Produtos_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Maroon;
            this.imageList1.Images.SetKeyName(0, "arroz.png");
            this.imageList1.Images.SetKeyName(1, "coca-cola.png");
            this.imageList1.Images.SetKeyName(2, "ovos.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "FOTO PRODUTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "* Imagem ilustrativa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CalculadoraVendas.Properties.Resources.inicio;
            this.pictureBox1.Location = new System.Drawing.Point(351, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_Produtos);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Venda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lucro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Custo);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox txt_Custo;
        private System.Windows.Forms.TextBox txt_Lucro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.ComboBox cmb_Produtos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


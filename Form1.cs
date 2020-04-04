using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;


namespace CalculadoraVendas
{
    public partial class Form1 : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int WParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public Form1()
        {
            InitializeComponent();

            cmb_Produtos.Text = "-- SELECIONE O PRODUTO --";
            SendMessage(txt_Custo.Handle, EM_SETCUEBANNER, 0, "R$");
            SendMessage(txt_Lucro.Handle, EM_SETCUEBANNER, 0, "Ex: 0,1");
            pictureBox1.Image = Properties.Resources.inicio;

            //Fonte: https://www.fluxbytes.com/csharp/set-placeholder-text-for-textbox-cue-text/

        }


        private void txt_Custo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Custo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Somente números separados por virgula!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_Lucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Somente números separados por virgula!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Produtos.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o produto!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox1.Image = Properties.Resources.inicio;
                }
                else
                {
                    double valorCompra = Convert.ToDouble(txt_Custo.Text);
                    double lucro = Convert.ToDouble(txt_Lucro.Text);
                    double totalGeral = valorCompra + (valorCompra * lucro);

                    txt_Venda.Text = "R$ " + totalGeral.ToString();
                    MessageBox.Show(
                        $"Valor de Custo...:{valorCompra,10:c}" +
                        $"\n\nMargem de Lucro...:{lucro,10:p}" +
                        $"\n\nValor Sug. Venda...:{totalGeral,10:c}" +
                        $"\n\nProduto...: {cmb_Produtos.SelectedItem}"
                        , "RESULTADO");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Certifique se todos os campos estão preenchidos!", "Ops!");
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Custo.Clear();
            txt_Lucro.Clear();
            txt_Venda.Clear();
            cmb_Produtos.Text = "-- SELECIONE O PRODUTO --";
            cmb_Produtos.Focus();
            pictureBox1.Image = Properties.Resources.inicio;

        }

        private void cmb_Produtos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Produtos.SelectedItem)
            {
                case "Ovos":
                    pictureBox1.Image = Properties.Resources.ovos;
                    break;
                case "Arroz":
                    pictureBox1.Image = Properties.Resources.arroz;
                    break;
                case "Refrigerante Coca-Cola":
                    pictureBox1.Image = Properties.Resources.coca_cola;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.inicio;
                    break;
            }
        }
    }
}

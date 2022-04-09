using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlinhoDeEstoquinho
{
    public partial class formProduto : Form
    {
        public formProduto()
        {
            InitializeComponent();
            CarregarGrid();

            IdInput.Enabled = false;
            nomeInput.Enabled = false;
            qtdInput.Enabled = false;
            marcaInput.Enabled = false;
            precoInput.Enabled = false;

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void CarregarGrid()
        {
            Model model = new Model();
            List<DtoProduto> lista = model.GetProdutos();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void clean()
        {
            IdInput.Enabled = false;
            nomeInput.Enabled = false;
            qtdInput.Enabled = false;
            marcaInput.Enabled = false;
            precoInput.Enabled = false;

            IdInput.Text = string.Empty;
            nomeInput.Text = string.Empty;
            qtdInput.Text = string.Empty;
            marcaInput.Text = string.Empty;
            precoInput.Text = string.Empty;

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            error.Text = string.Empty;
        }

        //Salvar
        private void button2_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            DtoProduto u = new DtoProduto();
            u.nome = nomeInput.Text;
            u.quantidade = int.Parse(qtdInput.Text);
            u.marca = marcaInput.Text;
            u.preco = decimal.Parse(precoInput.Text);

            if(IdInput.Text == String.Empty)
            {
                model.setProduto(u);
            }
            else
            {
                u.id = int.Parse(IdInput.Text);
                model.EditProduto(u);
            }
            
            CarregarGrid();
            clean();

        }

        //Novo
        private void button1_Click(object sender, EventArgs e)
        {
            clean();
            IdInput.Enabled = false;
            IdInput.Text = string.Empty;
            nomeInput.Enabled = true;
            qtdInput.Enabled = true;
            marcaInput.Enabled = true;
            precoInput.Enabled = true;

            button2.Enabled = true;
            button3.Enabled = true;
        }

        //Cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.DeletarProduto(int.Parse(IdInput.Text));
            clean();
            CarregarGrid();
        }

        private void bababuya(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            Model model = new Model();
            DtoProduto u = model.GetProdutosId(id);

            DtoVenda v = model.GetVendaId(id);

            if (v != null)
            {
                button4.Enabled = false;
                error.Text = "Venda pendente de produto";
            }
            else
            {
                button4.Enabled = true;
            }

            nomeInput.Enabled = true;
            qtdInput.Enabled = true;
            marcaInput.Enabled = true;
            precoInput.Enabled = true;

            IdInput.Text = u.id.ToString();
            nomeInput.Text = u.nome;
            qtdInput.Text = u.quantidade.ToString();
            marcaInput.Text = u.marca;
            precoInput.Text = u.preco.ToString();

            button2.Enabled = true;
            button3.Enabled = true;
            

        }

        private void back(object sender, EventArgs e)
        {
            this.Hide();
            Inicio f = new Inicio();
            f.Show();
        }
    }
}

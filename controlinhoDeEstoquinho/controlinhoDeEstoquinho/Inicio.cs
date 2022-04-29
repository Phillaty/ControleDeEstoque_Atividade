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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            Model model = new Model();
            List<DtoVenda> lista = model.GetVenda();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
            this.dataGridView1.Columns["idproduto"].Visible = false;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["valorcusto"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUsuario f = new formUsuario();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formProduto f = new formProduto();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formEntrada f = new formEntrada();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formSaida f = new formSaida();
            this.Hide();
            f.Show();
        }
    }
}

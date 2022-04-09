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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUsuario f = new formUsuario();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formProduto f = new formProduto();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formEntrada f = new formEntrada();
            f.Show();
        }
    }
}

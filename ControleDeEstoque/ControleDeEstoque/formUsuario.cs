using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            Model model = new Model();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            DtoUsuario u = new DtoUsuario();
            u.Name= nomeInput.Text; 
            u.login= loginInput.Text;
            u.senha= senhaInput.Text;

            if(idInput.Text == string.Empty)
            {
                model.setUsuario(u);
            }
            else
            {

            }

            label5.Text = "ACONTECE NADA";

        }
    }
}

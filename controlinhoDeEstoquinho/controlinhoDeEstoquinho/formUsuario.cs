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
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
            CarregarGrid();

            nomeInput.Enabled = false;
            loginInput.Enabled = false;
            senhaInput.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            IdInput.Enabled = false;
        }

        private void CarregarGrid()
        {
            Model model = new Model();
            List<DtoUsuario> lista = model.GetUsuarios();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void Clean()
        {
            nomeInput.Enabled = false;
            loginInput.Enabled = false;
            senhaInput.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;

            nomeInput.Text = string.Empty;
            loginInput.Text = string.Empty;
            senhaInput.Text = string.Empty;
            IdInput.Text = string.Empty;
        }

        //Salvar
        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            DtoUsuario u = new DtoUsuario();
            u.nome = nomeInput.Text;
            u.login = loginInput.Text;
            u.senha = senhaInput.Text;

            if(IdInput.Text == string.Empty)
            {
                model.setUsuario(u);
            }
            else
            {
                u.id = int.Parse(IdInput.Text);
                model.EditUsuario(u);
            }
            

            CarregarGrid();
            Clean();
        }

        //Novo
        private void button2_Click(object sender, EventArgs e)
        {
            nomeInput.Enabled = true;
            loginInput.Enabled = true;
            senhaInput.Enabled = true;
            button5.Enabled = true;
            button1.Enabled=true;
        }

        //Cancelar
        private void button5_Click(object sender, EventArgs e)
        {
            Clean();
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            Model model = new Model();
            DtoUsuario u = model.GetUsuariosId(id);
            IdInput.Text = u.id.ToString();
            nomeInput.Text = u.nome;
            loginInput.Text = u.login;

            nomeInput.Enabled = true;
            loginInput.Enabled = true;
            senhaInput.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(IdInput.Text != string.Empty)
            {
                Model model = new Model();
                model.DeletarUsuario(int.Parse(IdInput.Text));
                Clean();
                CarregarGrid();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio f = new Inicio();
            f.Show();
        }
    }
}

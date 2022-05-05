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
    public partial class formSaida : Form
    {
        public formSaida()
        {
            InitializeComponent();
            CarregarGrid();

            nomeIn.Enabled = false;
            precoIn.Enabled = false;
            restoIn.Enabled = false;
        }

        private void CarregarGrid()
        {
            Model model = new Model();
            List<DtoVenda> lista = model.GetVenda();

            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void clear()
        {
            idIn.Text = string.Empty;
            qtdRetIn.Text = string.Empty;

            nomeIn.Text = string.Empty;
            precoIn.Text = string.Empty;
            restoIn.Text = string.Empty;
        }

        private void clearParcial()
        {
            qtdRetIn.Text = string.Empty;
            nomeIn.Text = string.Empty;
            precoIn.Text = string.Empty;
            restoIn.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(idIn.Text != String.Empty)
            {
                Model model = new Model();
                int id = int.Parse(idIn.Text);
                DtoVenda v = model.GetVendaIdV(id);
                DtoVenda u = new DtoVenda();

                if(v != null)
                if (qtdRetIn.Text != String.Empty && idIn.Text != String.Empty)
                {
                    if(v.quantidade - int.Parse(qtdRetIn.Text) <= 0)
                    {
                            if(v.quantidade - int.Parse(qtdRetIn.Text) == 0)
                            {
                                //deleta
                                model.DeletarVenda(id);
                                clear();
                                CarregarGrid();
                                error.Text = String.Empty;
                            }
                            else
                            {
                                error.Text = "Quantidade indisponivel";
                            }
                           
                    }
                    else
                    {
                        //edita
                        u = v;
                        u.quantidade = v.quantidade - int.Parse(qtdRetIn.Text);

                        model.EditVenda(u);
                        searchV();
                        CarregarGrid();
                        error.Text = String.Empty;
                        }
                    }
                    else {
                        error.Text = "Nenhuma venda selecionada";
                    }
                else
                    error.Text = "Nenhuma venda selecionada";
            }
            else
            {
                error.Text = "Nenhuma venda selecionada";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void searchV()
        {
            Model model = new Model();
            if (idIn.Text != String.Empty)
            {
                int id = int.Parse(idIn.Text);
                DtoVenda v = model.GetVendaIdV(id);

                if (v != null)
                {
                    nomeIn.Text = v.nome;
                    precoIn.Text = v.valorvenda.ToString();
                    restoIn.Text = v.quantidade.ToString();
                }
                else
                {
                    clearParcial();
                }

            }
            else
            {
                clear();
            }
        }

        private void pickpickpick(object sender, EventArgs e)
        {
            searchV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio f = new Inicio();
            f.Show();
        }

        private void gridDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            Model model = new Model();

            DtoVenda v = model.GetVendaIdV(id);


            if(v != null)
            {
                idIn.Text = v.id.ToString();
            }
            else
            {
                error.Text = "Erro...";
            }
            
        }
    }
}

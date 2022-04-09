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
    public partial class formEntrada : Form
    {
        public formEntrada()
        {
            InitializeComponent();
            CarregarGrid();

            nomeInput.Enabled = false;
            valorCustoInput.Enabled = false;
            qtdEstoqueInput.Enabled = false;
        }

        private void CarregarGrid()
        {
            Model model = new Model();
            List<DtoProduto> lista = model.GetProdutos();
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void clear()
        {
            nomeInput.Text = string.Empty;
            valorCustoInput.Text = string.Empty;
            qtdEstoqueInput.Text = string.Empty;
        }

        private void clearAll()
        {
            IdInput.Text = string.Empty;
            nomeInput.Text = string.Empty;
            valorCustoInput.Text = string.Empty;
            qtdEstoqueInput.Text = string.Empty;
            valorVendaInput.Text = string.Empty;
            qtdEntradaInput.Text = string.Empty;
        }

        private void clearInput()
        {
            qtdEntradaInput.Text = string.Empty;
            valorVendaInput.Text = string.Empty;
        }


        //Salvar
        private void button2_Click(object sender, EventArgs e)
        {
            if(IdInput.Text != string.Empty)
            {
                Model model = new Model();
                DtoVenda u = new DtoVenda();

                int id = int.Parse(IdInput.Text);
                DtoVenda a = model.GetVendaId(id);
                DtoProduto p = model.GetProdutosId(id);

                if(a != null)
                {
                    u = a;
                }
                
                u.valorvenda = decimal.Parse(valorVendaInput.Text);
                p.quantidade = p.quantidade - int.Parse(qtdEntradaInput.Text);


                if (a != null)
                {
                    if (p.quantidade > int.Parse(qtdEntradaInput.Text))
                    {
                        u.quantidade = a.quantidade + int.Parse(qtdEntradaInput.Text);
                        model.EditVenda(u);
                        model.EditQtdProduto(p);
                        clearInput();
                        searchP();
                        CarregarGrid();
                    }
                    else
                    {
                        erro.Text = "quantidade de entrada maior que o limite";
                    }
                }
                else
                {
                    if (p != null)
                    {
                        if(p.quantidade > int.Parse(qtdEntradaInput.Text))
                        {
                            u.quantidade = int.Parse(qtdEntradaInput.Text);
                            u.idproduto = int.Parse(IdInput.Text);
                            model.setVenda(u);
                            model.EditQtdProduto(p);
                            clearInput();
                            searchP();
                            CarregarGrid();
                        }
                        else
                        {
                            erro.Text = "quantidade de entrada maior que o limite";
                        }
                        
                    }
                    else
                    {
                        erro.Text = "Nenhum produto selecionado";
                    }

                }
            }
            
        }

        //Cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void searchP()
        {
            Model model = new Model();
            if (IdInput.Text != String.Empty)
            {
                int id = int.Parse(IdInput.Text);
                DtoProduto u = model.GetProdutosId(id);
                DtoVenda v = model.GetVendaId(id);
                if (u != null)
                {
                    nomeInput.Text = u.nome;
                    valorCustoInput.Text = u.preco.ToString();
                    qtdEstoqueInput.Text = u.quantidade.ToString();

                    if(v != null)
                    {
                        valorVendaInput.Text = v.valorvenda.ToString();
                    }
                }
                else
                {
                    clear();
                }
            }
            else
            {
                clear();
            }
        }

        //Procurar
        private void searchProduct(object sender, EventArgs e)
        {
            searchP();
        }

        private void selectProduct(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            Model model = new Model();
            DtoProduto u = model.GetProdutosId(id);
            IdInput.Text = u.id.ToString();
            nomeInput.Text = u.nome;
            valorCustoInput.Text = u.preco.ToString();
            qtdEstoqueInput.Text = u.quantidade.ToString();
        }
    }
}

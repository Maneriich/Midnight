using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midnight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        //altera opções de entrada de produtos 
        //remove a caixa de texto e apresenta uma caixa de seleção com itens pre definidos
        //(tbpProdutos)
        private void ckbTipoProduto_CheckedChanged(object sender, EventArgs e)
        {
            cbxTipoProduto.Visible = false;
            txtTipoProduto.Visible = true;
            ckbSelecionarProdP.Visible = true;
            ckbAdicionarProdP.Visible = false;
        }

        //função que fecha a tela ao clicar no (x)
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //altera entre adicionar e visualizar cadastro do estabelecimento 
        //chama a EditEForm para edição do cadastro
        //pede confirmação de login
        //(tbpEstabelecimento)
        private void cbxOpcoesE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOpcoesE.SelectedIndex == 1) {
                Form f1 = FindForm();
                EditEForm f2 = new EditEForm();
                f2.Show();
                f1.Hide();
            }
        }

        //altera entre adicionar e visualizar cadastro de produtos
        //chama EdidPForm
        //(tbpProdutos)
        private void cbxOpcoesP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOpcoesP.SelectedIndex == 1) {
                Form f1 = FindForm();
                EditPForm f2 = new EditPForm();
                f2.Show();
                f1.Hide();
            }
        }

        //altera a opção de entrada de tipo de produtos para o controle de estoque
        //remove a caixa de seleção e apressenta uma caixa de texto para digitar um tipo de produto novo
        //(tbpEstoque)
        private void ckbAdicionarP_CheckedChanged(object sender, EventArgs e)
        {
            cbxProtudos.Visible = false;
            txtProduto.Visible = true;
            ckbSelecionarProdE.Visible = true;
            ckbAdicionarProdE.Visible = false;
        }

        //adiciona um novo registro de produto a base de dados
        //limpa as caixas de entrada
        //(tbpProdutos)
        private void btnAdicionar_Click(object sender, EventArgs e)
        {            
            ckbAdicionarProdP.Visible = true;
            cbxTipoProduto.Visible = true;
            ckbSelecionarProdP.Visible = false;
            txtTipoProduto.Visible = false; 
            txtTipoProduto.Text = "";
            cbxTipoProduto.Text = "";
            txtDescricaoP.Text = "";
            txtPrecoP.Text = "";
        }

        //altera a opção de entrada de tipo de produto no controle de estoque 
        //remove a caixa de texto e apresenta uma caixa de seleção com opções pre definidas
        //(tbpEstoque)
        private void ckbSelecionarP_CheckedChanged(object sender, EventArgs e)
        {
            ckbAdicionarProdE.Visible = true;
            ckbSelecionarProdE.Visible = false;
            cbxProtudos.Visible = true;
            txtProduto.Visible = false;

        }

        //altera a opção de entrada do tipo de produto 
        //remove a caixa de seleção e apresenta uma caixa de texto para adicionar um produto novo
        //(tbpProduto)
        private void ckbSelecionarProdP_CheckedChanged(object sender, EventArgs e)
        {
            cbxTipoProduto.Visible = true;
            txtTipoProduto.Visible = false;
            ckbAdicionarProdP.Visible = true;
            ckbSelecionarProdP.Visible = false;

        
        }

        //faz o controle da lista de itens durante a realização de uma venda
        //calcula o subtotal da venda
        //(tbpVenda)
        private void btnAdicionarProdV_Click(object sender, EventArgs e)
        {
            lbxProduto.Items.Add(cbxProdutoV.SelectedItem);
            lbxQuantidade.Items.Add(txtQuantidadeV.Text);           
            int qtd = int.Parse(txtQuantidadeV.Text);
            double preco = double.Parse(txtPrecoV.Text);
            lbxPreco.Items.Add(qtd*preco);
            double subtotal = double.Parse(txtSubtotal.Text);
            subtotal += (qtd * preco);
            txtSubtotal.Text = Convert.ToString(subtotal);

            cbxProdutoV.Text = "";
            txtQuantidadeV.Text = "";
            txtPrecoV.Text = "";
        }

        //altera entre visualizar e alterar horario de funcionamento
        //(tbpEstabelecimento)
        private void btnAlteraH_Click(object sender, EventArgs e)
        {
            gbxAlteraH.Visible = true;
            gbxVizualizaH.Visible = false; 
        }

        //atualiza as informacoes de horario de funcionamento
        //retorna a tela de visualizar informações
        //(tbpEstabelecimento)
        private void btnAtualizaH_Click(object sender, EventArgs e)
        {

        }

        //atualiza o controle de estoque na base de dados
        //limpa os campos de entrada 
        //(tbpEstoque)
        private void btnAtualizarE_Click(object sender, EventArgs e)
        {
            cbxProtudos.Visible = true;
            ckbAdicionarProdE.Visible = true;
            txtProduto.Visible = false;
            ckbSelecionarProdE.Visible = false;
            txtProduto.Text = "";
            cbxProtudos.Text = "";
            txtQtdEstoque.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TCC
{
    public partial class frmGeracao : Form
    {

        public List<Variaveis> variaveis = new List<Variaveis>();

        public frmGeracao()
        {
            InitializeComponent();
        }

        private void btnGerarCombinacao_Click(object sender, EventArgs e)
        {
            MostraGif();
        }

        private void btnAdicionaVariavel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeVar.Text))
                {
                    throw new Exception("O nome da variável deve ser informado.");
                }
                //If para verificar se os valores informados pelo usuário são válidos
                //Ou seja: não vazio e possui barra (/)
                if (!string.IsNullOrEmpty(txtValoresPossiveis.Text) && txtValoresPossiveis.Text.Contains("/"))
                {
                    //Mensagem para confirmar se o usuário deseja adicionar a variável informada e os valores possíveis
                    if (MessageBox.Show("Deseja realmente adicionar a variável " + txtNomeVar.Text +
                                       "\nCom os valores possíveis:\n" + txtValoresPossiveis.Text + " ?", "Confirmar",
                                       MessageBoxButtons.OKCancel,
                                       MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Variaveis novo = new Variaveis();
                        novo.Nome = txtNomeVar.Text;
                        //If para verificar se o último caracter informado é ponto e virgula
                        if (txtValoresPossiveis.Text.Substring(txtValoresPossiveis.Text.Length - 1, 1) == "/")
                        {
                            //Se for verdadeiro, o ultimo caracter é removido antes de realizar o split para não adicionar vazio na lista de valores possíveis
                            novo.ValoresPossiveis = txtValoresPossiveis.Text.Remove(txtValoresPossiveis.Text.Length - 1, 1).Split('/').ToList();
                        }
                        //Se falso, é realizado apenas o split
                        else
                        {
                            novo.ValoresPossiveis = txtValoresPossiveis.Text.Split('/').ToList();
                        }

                        novo.QtdeValores = novo.ValoresPossiveis.Count;

                        string[] var = new string[]
                        {
                            novo.Nome,
                            txtValoresPossiveis.Text,
                            novo.QtdeValores.ToString()
                        };

                        variaveis.Add(novo);
                        ListViewItem novoItem = new ListViewItem(var);
                        lstVariaveis.Items.Add(novoItem);

                        txtNomeVar.Text = "";
                        txtValoresPossiveis.Text = "";
                    }
                }
                else
                {
                    throw new Exception("O campo \"Valores Possíveis\" não está no formato correto!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Funções

        //Função para esconder os componentes e mostrar o gif e mensagem para o usuário.
        public void MostraGif()
        {
            pctGif.Visible = true;
            pnlMensagem.Visible = true;
            lblMensagem.Visible = true;
            btnGerarCombinacao.Visible = false;
            txtNomeVar.Visible = false;
            txtValoresPossiveis.Visible = false;
            lblInstrucao.Visible = false;
            lblNomeVar.Visible = false;
            lblValoresPossiveis.Visible = false;
            btnAdicionaVariavel.Visible = false;
            lblLista.Visible = false;
            lstVariaveis.Visible = false;
        }
    }
}

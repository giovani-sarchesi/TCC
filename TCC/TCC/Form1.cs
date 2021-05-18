using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TCC
{
    public partial class frmGeracao : Form
    {
        public TimeSpan horaInicio;
        public TimeSpan horaFinal;
        public TimeSpan tempoGasto;
        public List<Variaveis> variaveis = new List<Variaveis>();

        public frmGeracao()
        {
            InitializeComponent();
        }

        private void btnGerarCombinacao_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificação de quantas variáveis foram informadas, se menos que 2, uma exceção é enviada.
                if (variaveis.Count < 2)
                {
                    throw new Exception("Pelo menos 2 variáveis devem ser informadas para gerar combinações.");
                }
                //Verificação se o nome do arquivo foi informado, se não, uma exceção é enviada.
                else if (string.IsNullOrEmpty(txtNomeArquivo.Text))
                {
                    throw new Exception("O nome para o arquivo deve ser informado");
                }
                //Se os dois não gerar exceção, é iniciada a lógica para montagem das combinações
                else
                {
                    //Estrutura de repetição que preencherá a coluna referente a quantidade de combinações
                    //Levando em consideração que a 1ª variável já tem a informação preenchida, o loop é iniciado na pos 1 e não na 0
                    for (int i = 1; i < variaveis.Count; i++)
                    {
                        variaveis[i].QtdeCombinacoes = variaveis[i].QtdeValores * variaveis[i - 1].QtdeCombinacoes;
                    }

                    //Estrutura de repetição que preencherá a coluna referente a quantidade de repetições
                    //Levando em consideração a conta que deve ser feita, o loop é iniciado do fim para o começo
                    //e o numerador é travado através do código 'variaveis[variaveis.Count - 1].QtdeCombinacoes' e apenas 
                    //o denomidor é modificado pelo for.
                    for (int i = variaveis.Count - 1; i > -1; i--)
                    {
                        variaveis[i].QtdeRepeticoes = variaveis[variaveis.Count - 1].QtdeCombinacoes / variaveis[i].QtdeCombinacoes;
                    }

                    GerarArquivo(variaveis, txtNomeArquivo.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    if (MessageBox.Show("Deseja realmente adicionar a variável:\n" + txtNomeVar.Text +
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

                        if (variaveis.Count == 0)
                        {
                            novo.QtdeCombinacoes = novo.QtdeValores;
                        }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Funções

        //Função para gerar arquivo
        public void GerarArquivo(List<Variaveis> dados, string nomeArquivo)
        {
            try
            {
                string caminho = "C:\\Combinacoes\\";

                //Verificação se já existe um arquivo com o nome informado, com opção para o usuário escolher
                //caso exista, se deseja subtituir seu conteúdo ou se deseja informar outro nome
                if (File.Exists(caminho + nomeArquivo + ".xlsx"))
                {
                    if (MessageBox.Show("Já existe um arquivo com o nome especificado, deseja substituir o arquivo antigo? Se não, informe outro nome e gere novamente.",
                                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CriaConteudoArquivo(dados, nomeArquivo, caminho);
                    }
                }
                else
                {
                    CriaConteudoArquivo(dados, nomeArquivo, caminho);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Função para transforma a lista dos valores possíveis em uma string
        public string FormataValoresPossiveis(List<string> valores)
        {
            string formata = "";

            foreach (string vlr in valores)
            {
                formata += vlr + "/";
            }

            return formata;
        }

        public void CriaConteudoArquivo(List<Variaveis> dados, string nomeArquivo, string caminho)
        {
            horaInicio = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //Criação do datatable para setar os dados do cabeçalho
            DataTable dtCabecalho = new DataTable();

            //Adicionando as colunas no datatable
            dtCabecalho.Columns.AddRange(new DataColumn[5]
            {
                            new DataColumn("Nome variáveis", typeof(string)),
                            new DataColumn("Valores pos.", typeof(string)),
                            new DataColumn("Qntde val.", typeof(int)),
                            new DataColumn("Qntde com.", typeof(int)),
                            new DataColumn("Qntde rep.", typeof(int)),
            });

            //Adicionando as linhas com os respectivos dados das variáveis informadas
            foreach (Variaveis dd in dados)
            {
                dtCabecalho.Rows.Add(dd.Nome,
                                 FormataValoresPossiveis(dd.ValoresPossiveis),
                                 dd.QtdeValores,
                                 dd.QtdeCombinacoes,
                                 dd.QtdeRepeticoes);
            }

            //Contagem das linhas utilizadas para criação do cabeçalho
            int comecaComb = dtCabecalho.Rows.Count + 3;

            //Criação do datatable que receberá as combinações
            DataTable dtCombinacoes = new DataTable();

            //Adicionando as colunas no datatable, primeiro a "Entrada/Ações" depois
            //as referente ao numeros de combinações geradas
            dtCombinacoes.Columns.Add(new DataColumn("Entradas/Ações", typeof(string)));

            for (int i = 1; i <= variaveis[variaveis.Count - 1].QtdeCombinacoes; i++)
            {
                dtCombinacoes.Columns.Add(new DataColumn(("Combinação " + i), typeof(string)));
            }

            //Foreach pelas variaveis informadas para gerar as combinações
            //Adicionando em cada linha a quantidade que cada variável deve ser repetida
            foreach (Variaveis var in variaveis)
            {
                //Criando a nova linha que receberá os dados referentes a var
                string[] novaLinha = new string[variaveis[variaveis.Count - 1].QtdeCombinacoes + 1];
                //Setando a primeira coluna da linha com o nome da variável
                novaLinha[0] = var.Nome;

                //For que controla para que as variáveis sejam repetidas de acordo com quantas combinações serão formadas
                for (int j = 0; j < variaveis[variaveis.Count - 1].QtdeCombinacoes;)
                {
                    //Foreach que passa pelos valores possíveis que compõe a var atual
                    foreach (string vlr in var.ValoresPossiveis)
                    {
                        //For que controla quantas vezes cada variável deve ser repetida na linha
                        for (int i = 0; i < var.QtdeRepeticoes; i++)
                        {
                            novaLinha[j + 1] = vlr.ToString();
                            j++;
                        }
                    }
                }

                //Adiciona a nova linha no datatable das combinações
                dtCombinacoes.Rows.Add(novaLinha);
            }

            //Verifica se o caminho já existe na máquina, senão, cria o caminho para salvar o arquivo
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            //Instância de um XLWorkbook
            var wb = new XLWorkbook();

            //Adicionando o cabeçalho na worksheet
            var wsvar = wb.Worksheets.Add(dtCabecalho, "Combinações");

            //Adicionando as combinações na worksheet, setando o inicio abaixo do cabeçalho
            //através da variável comecaComb
            wb.Worksheet("Combinações").Cell(comecaComb, 1).InsertTable(dtCombinacoes);

            //Ajustando as colunas de acordo com os valores
            wsvar.Columns().AdjustToContents();

            //Salvando o arquivo no caminho criado
            wb.SaveAs(caminho + nomeArquivo + ".xlsx");

            horaFinal = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            tempoGasto = horaFinal.Subtract(horaInicio);
            //Mensagem para confirmar que o arquivo foi gerado
            MessageBox.Show("Arquivo gerado com sucesso." +
                            "\nCaminho: " + caminho +
                            "\nArquivo: " + nomeArquivo +
                            "\nTempo gasto: " + tempoGasto.ToString(),
                            "Sucesso",
                            MessageBoxButtons.OK);

            //Limpando as listas de variáveis 
            lstVariaveis.Items.Clear();
            variaveis.Clear();
            //Limpando o campo onde é informado o nome do arquivo
            txtNomeArquivo.Text = "";
        }

        //Função implementada no campo onde é infomado o nome do arquivo
        //Criada para impedir que o usuário digite caracteres que possam gerar problemas no windows
        private void txtNomeArquivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Setando quais caracteres são permitidos
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_ÇÃÕÊÉÍÓÌÀ";

            //If para verificar se a tecla apertada pelo usuário faz parte da string de caracteres permitidos
            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())) && !char.IsControl(e.KeyChar))
            {
                //Mensagem para informar que o caracter clicado é inválido
                MessageBox.Show("Caracter " + e.KeyChar + " não permitido para nome de arquivo.");
                e.Handled = true;
            }

        }
    }
}

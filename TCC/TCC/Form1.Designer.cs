namespace TCC
{
    partial class frmGeracao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarCombinacao = new System.Windows.Forms.Button();
            this.lblNomeVar = new System.Windows.Forms.Label();
            this.lblValoresPossiveis = new System.Windows.Forms.Label();
            this.txtNomeVar = new System.Windows.Forms.TextBox();
            this.txtValoresPossiveis = new System.Windows.Forms.TextBox();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnAdicionaVariavel = new System.Windows.Forms.Button();
            this.lstVariaveis = new System.Windows.Forms.ListView();
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnVlrPossiveis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnQtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLista = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarCombinacao
            // 
            this.btnGerarCombinacao.Location = new System.Drawing.Point(12, 557);
            this.btnGerarCombinacao.Name = "btnGerarCombinacao";
            this.btnGerarCombinacao.Size = new System.Drawing.Size(517, 23);
            this.btnGerarCombinacao.TabIndex = 1;
            this.btnGerarCombinacao.Text = "Gerar Combinação";
            this.btnGerarCombinacao.UseVisualStyleBackColor = true;
            this.btnGerarCombinacao.Click += new System.EventHandler(this.btnGerarCombinacao_Click);
            // 
            // lblNomeVar
            // 
            this.lblNomeVar.AutoSize = true;
            this.lblNomeVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVar.Location = new System.Drawing.Point(15, 15);
            this.lblNomeVar.Name = "lblNomeVar";
            this.lblNomeVar.Size = new System.Drawing.Size(100, 17);
            this.lblNomeVar.TabIndex = 3;
            this.lblNomeVar.Text = "Nome Variável";
            // 
            // lblValoresPossiveis
            // 
            this.lblValoresPossiveis.AutoSize = true;
            this.lblValoresPossiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoresPossiveis.Location = new System.Drawing.Point(15, 63);
            this.lblValoresPossiveis.Name = "lblValoresPossiveis";
            this.lblValoresPossiveis.Size = new System.Drawing.Size(118, 17);
            this.lblValoresPossiveis.TabIndex = 4;
            this.lblValoresPossiveis.Text = "Valores possíveis";
            // 
            // txtNomeVar
            // 
            this.txtNomeVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVar.Location = new System.Drawing.Point(12, 36);
            this.txtNomeVar.Name = "txtNomeVar";
            this.txtNomeVar.Size = new System.Drawing.Size(517, 23);
            this.txtNomeVar.TabIndex = 5;
            // 
            // txtValoresPossiveis
            // 
            this.txtValoresPossiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValoresPossiveis.Location = new System.Drawing.Point(12, 84);
            this.txtValoresPossiveis.Name = "txtValoresPossiveis";
            this.txtValoresPossiveis.Size = new System.Drawing.Size(517, 23);
            this.txtValoresPossiveis.TabIndex = 6;
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.Location = new System.Drawing.Point(139, 67);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(253, 13);
            this.lblInstrucao.TabIndex = 7;
            this.lblInstrucao.Text = "(Separe os valores com barra lateral (/). Ex: A/B/C/)";
            // 
            // btnAdicionaVariavel
            // 
            this.btnAdicionaVariavel.Location = new System.Drawing.Point(12, 113);
            this.btnAdicionaVariavel.Name = "btnAdicionaVariavel";
            this.btnAdicionaVariavel.Size = new System.Drawing.Size(517, 23);
            this.btnAdicionaVariavel.TabIndex = 8;
            this.btnAdicionaVariavel.Text = "Adicionar Variável";
            this.btnAdicionaVariavel.UseVisualStyleBackColor = true;
            this.btnAdicionaVariavel.Click += new System.EventHandler(this.btnAdicionaVariavel_Click);
            // 
            // lstVariaveis
            // 
            this.lstVariaveis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnNome,
            this.clnVlrPossiveis,
            this.clnQtde});
            this.lstVariaveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVariaveis.HideSelection = false;
            this.lstVariaveis.Location = new System.Drawing.Point(12, 162);
            this.lstVariaveis.Name = "lstVariaveis";
            this.lstVariaveis.Size = new System.Drawing.Size(517, 342);
            this.lstVariaveis.TabIndex = 9;
            this.lstVariaveis.UseCompatibleStateImageBehavior = false;
            this.lstVariaveis.View = System.Windows.Forms.View.Details;
            // 
            // clnNome
            // 
            this.clnNome.Text = "Nome Variável";
            this.clnNome.Width = 140;
            // 
            // clnVlrPossiveis
            // 
            this.clnVlrPossiveis.Text = "Valores Possíveis";
            this.clnVlrPossiveis.Width = 300;
            // 
            // clnQtde
            // 
            this.clnQtde.Text = "Qtde.";
            this.clnQtde.Width = 70;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(191, 142);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(159, 17);
            this.lblLista.TabIndex = 10;
            this.lblLista.Text = "Variáveis já informadas:";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeArquivo.Location = new System.Drawing.Point(12, 528);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(517, 23);
            this.txtNomeArquivo.TabIndex = 12;
            this.txtNomeArquivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeArquivo_KeyPress);
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.Location = new System.Drawing.Point(15, 507);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(97, 17);
            this.lblNomeArquivo.TabIndex = 11;
            this.lblNomeArquivo.Text = "Nome Arquivo";
            // 
            // frmGeracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(541, 589);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lstVariaveis);
            this.Controls.Add(this.btnAdicionaVariavel);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.txtValoresPossiveis);
            this.Controls.Add(this.txtNomeVar);
            this.Controls.Add(this.lblValoresPossiveis);
            this.Controls.Add(this.lblNomeVar);
            this.Controls.Add(this.btnGerarCombinacao);
            this.Name = "frmGeracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Combinações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerarCombinacao;
        private System.Windows.Forms.Label lblNomeVar;
        private System.Windows.Forms.Label lblValoresPossiveis;
        private System.Windows.Forms.TextBox txtNomeVar;
        private System.Windows.Forms.TextBox txtValoresPossiveis;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Button btnAdicionaVariavel;
        private System.Windows.Forms.ListView lstVariaveis;
        private System.Windows.Forms.ColumnHeader clnNome;
        private System.Windows.Forms.ColumnHeader clnVlrPossiveis;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ColumnHeader clnQtde;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
    }
}


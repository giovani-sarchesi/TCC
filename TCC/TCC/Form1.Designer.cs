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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeracao));
            this.pctGif = new System.Windows.Forms.PictureBox();
            this.btnGerarCombinacao = new System.Windows.Forms.Button();
            this.pnlMensagem = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblNomeVar = new System.Windows.Forms.Label();
            this.lblValoresPossiveis = new System.Windows.Forms.Label();
            this.txtNomeVar = new System.Windows.Forms.TextBox();
            this.txtValoresPossiveis = new System.Windows.Forms.TextBox();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnAdicionaVariavel = new System.Windows.Forms.Button();
            this.lstVariaveis = new System.Windows.Forms.ListView();
            this.clnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnVlrPossiveis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLista = new System.Windows.Forms.Label();
            this.clnQtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pctGif)).BeginInit();
            this.pnlMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctGif
            // 
            this.pctGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctGif.Image = ((System.Drawing.Image)(resources.GetObject("pctGif.Image")));
            this.pctGif.Location = new System.Drawing.Point(0, 0);
            this.pctGif.Name = "pctGif";
            this.pctGif.Size = new System.Drawing.Size(541, 583);
            this.pctGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctGif.TabIndex = 0;
            this.pctGif.TabStop = false;
            this.pctGif.Visible = false;
            // 
            // btnGerarCombinacao
            // 
            this.btnGerarCombinacao.Location = new System.Drawing.Point(12, 510);
            this.btnGerarCombinacao.Name = "btnGerarCombinacao";
            this.btnGerarCombinacao.Size = new System.Drawing.Size(517, 23);
            this.btnGerarCombinacao.TabIndex = 1;
            this.btnGerarCombinacao.Text = "Gerar Combinação";
            this.btnGerarCombinacao.UseVisualStyleBackColor = true;
            this.btnGerarCombinacao.Click += new System.EventHandler(this.btnGerarCombinacao_Click);
            // 
            // pnlMensagem
            // 
            this.pnlMensagem.Controls.Add(this.lblMensagem);
            this.pnlMensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMensagem.Location = new System.Drawing.Point(0, 539);
            this.pnlMensagem.Name = "pnlMensagem";
            this.pnlMensagem.Size = new System.Drawing.Size(541, 44);
            this.pnlMensagem.TabIndex = 2;
            this.pnlMensagem.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(106, 11);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(329, 24);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Gerando combinações, aguarde...";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
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
            // clnQtde
            // 
            this.clnQtde.Text = "Qtde.";
            this.clnQtde.Width = 70;
            // 
            // frmGeracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(541, 583);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lstVariaveis);
            this.Controls.Add(this.btnAdicionaVariavel);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.txtValoresPossiveis);
            this.Controls.Add(this.txtNomeVar);
            this.Controls.Add(this.lblValoresPossiveis);
            this.Controls.Add(this.lblNomeVar);
            this.Controls.Add(this.pnlMensagem);
            this.Controls.Add(this.btnGerarCombinacao);
            this.Controls.Add(this.pctGif);
            this.Name = "frmGeracao";
            this.Text = "Gerador de Combinações";
            ((System.ComponentModel.ISupportInitialize)(this.pctGif)).EndInit();
            this.pnlMensagem.ResumeLayout(false);
            this.pnlMensagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctGif;
        private System.Windows.Forms.Button btnGerarCombinacao;
        private System.Windows.Forms.Panel pnlMensagem;
        private System.Windows.Forms.Label lblMensagem;
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
    }
}


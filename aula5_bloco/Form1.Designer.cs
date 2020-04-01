namespace blocoNotas2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.mnuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuFormatar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcNovo,
            this.opcAbrir,
            this.opcSalvar,
            this.toolStripMenuItem1,
            this.opcSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // opcNovo
            // 
            this.opcNovo.Name = "opcNovo";
            this.opcNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.opcNovo.Size = new System.Drawing.Size(180, 22);
            this.opcNovo.Text = "Novo";
            this.opcNovo.ToolTipText = "Novo arquivo texto";
            // 
            // opcAbrir
            // 
            this.opcAbrir.Name = "opcAbrir";
            this.opcAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opcAbrir.Size = new System.Drawing.Size(180, 22);
            this.opcAbrir.Text = "Abrir";
            this.opcAbrir.ToolTipText = "Abrir um arquivo texto";
            // 
            // opcSalvar
            // 
            this.opcSalvar.Name = "opcSalvar";
            this.opcSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.opcSalvar.Size = new System.Drawing.Size(180, 22);
            this.opcSalvar.Text = "Gravar";
            this.opcSalvar.ToolTipText = "Gravar arquivo texto";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // opcSair
            // 
            this.opcSair.Name = "opcSair";
            this.opcSair.Size = new System.Drawing.Size(180, 22);
            this.opcSair.Text = "Sair";
            this.opcSair.ToolTipText = "Sair do aplicativo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnAbrir,
            this.btnGravar,
            this.toolStripSeparator1,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "toolStripButton1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(23, 22);
            this.btnAbrir.Text = "toolStripButton1";
            // 
            // btnGravar
            // 
            this.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(23, 22);
            this.btnGravar.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "toolStripButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(103, 17);
            this.lblMensagem.Text = "Nome do arquivo:";
            // 
            // txtTexto
            // 
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Location = new System.Drawing.Point(0, 49);
            this.txtTexto.MaxLength = 32000;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(484, 390);
            this.txtTexto.TabIndex = 3;
            this.txtTexto.Text = "";
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "txt";
            this.dlgAbrir.FileName = "Nome do arquivo";
            this.dlgAbrir.Filter = "Arquivo texto|*.txt ";
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.DefaultExt = "txt";
            this.dlgSalvar.FileName = "Nome do arquivo ";
            this.dlgSalvar.Filter = "Arquivo texto|*.txt ";
            // 
            // mnuFormatar
            // 
            this.mnuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcLetra});
            this.mnuFormatar.Name = "mnuFormatar";
            this.mnuFormatar.Size = new System.Drawing.Size(67, 20);
            this.mnuFormatar.Text = "&Formatar";
            // 
            // opcLetra
            // 
            this.opcLetra.Name = "opcLetra";
            this.opcLetra.Size = new System.Drawing.Size(180, 22);
            this.opcLetra.Text = "Letra";
            this.opcLetra.ToolTipText = "Formatar letra/Caractere ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor simplificado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem opcNovo;
        private System.Windows.Forms.ToolStripMenuItem opcAbrir;
        private System.Windows.Forms.ToolStripMenuItem opcSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatar;
        private System.Windows.Forms.ToolStripMenuItem opcLetra;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
    }
}


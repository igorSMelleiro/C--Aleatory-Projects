namespace pedraPapelTesoura
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdpedra = new System.Windows.Forms.RadioButton();
            this.rdpapel = new System.Windows.Forms.RadioButton();
            this.rdtesoura = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblresposta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha um elemento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.rdtesoura);
            this.groupBox1.Controls.Add(this.rdpapel);
            this.groupBox1.Controls.Add(this.rdpedra);
            this.groupBox1.Location = new System.Drawing.Point(35, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementos";
            // 
            // rdpedra
            // 
            this.rdpedra.AutoSize = true;
            this.rdpedra.Location = new System.Drawing.Point(22, 39);
            this.rdpedra.Name = "rdpedra";
            this.rdpedra.Size = new System.Drawing.Size(53, 17);
            this.rdpedra.TabIndex = 0;
            this.rdpedra.TabStop = true;
            this.rdpedra.Text = "Pedra";
            this.rdpedra.UseVisualStyleBackColor = true;
            // 
            // rdpapel
            // 
            this.rdpapel.AutoSize = true;
            this.rdpapel.Location = new System.Drawing.Point(22, 75);
            this.rdpapel.Name = "rdpapel";
            this.rdpapel.Size = new System.Drawing.Size(52, 17);
            this.rdpapel.TabIndex = 1;
            this.rdpapel.TabStop = true;
            this.rdpapel.Text = "Papel";
            this.rdpapel.UseVisualStyleBackColor = true;
            // 
            // rdtesoura
            // 
            this.rdtesoura.AutoSize = true;
            this.rdtesoura.Location = new System.Drawing.Point(22, 115);
            this.rdtesoura.Name = "rdtesoura";
            this.rdtesoura.Size = new System.Drawing.Size(64, 17);
            this.rdtesoura.TabIndex = 2;
            this.rdtesoura.TabStop = true;
            this.rdtesoura.Text = "Tesoura";
            this.rdtesoura.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(163, 130);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblresposta
            // 
            this.lblresposta.AutoSize = true;
            this.lblresposta.Location = new System.Drawing.Point(32, 246);
            this.lblresposta.Name = "lblresposta";
            this.lblresposta.Size = new System.Drawing.Size(0, 13);
            this.lblresposta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblresposta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rdtesoura;
        private System.Windows.Forms.RadioButton rdpapel;
        private System.Windows.Forms.RadioButton rdpedra;
        private System.Windows.Forms.Label lblresposta;
        private System.Windows.Forms.Label label2;
    }
}


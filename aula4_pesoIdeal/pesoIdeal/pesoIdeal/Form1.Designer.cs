namespace pesoIdeal
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
            this.lbl_altura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_masc = new System.Windows.Forms.RadioButton();
            this.rdb_fem = new System.Windows.Forms.RadioButton();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(224, 70);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(37, 13);
            this.lbl_altura.TabIndex = 0;
            this.lbl_altura.Text = "Altura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_masc);
            this.groupBox1.Controls.Add(this.rdb_fem);
            this.groupBox1.Location = new System.Drawing.Point(28, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdb_masc
            // 
            this.rdb_masc.AutoSize = true;
            this.rdb_masc.Location = new System.Drawing.Point(23, 60);
            this.rdb_masc.Name = "rdb_masc";
            this.rdb_masc.Size = new System.Drawing.Size(73, 17);
            this.rdb_masc.TabIndex = 1;
            this.rdb_masc.TabStop = true;
            this.rdb_masc.Text = "Masculino";
            this.rdb_masc.UseVisualStyleBackColor = true;
            this.rdb_masc.CheckedChanged += new System.EventHandler(this.rbn_masc_CheckedChanged);
            // 
            // rdb_fem
            // 
            this.rdb_fem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_fem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdb_fem.Location = new System.Drawing.Point(23, 30);
            this.rdb_fem.Name = "rdb_fem";
            this.rdb_fem.Size = new System.Drawing.Size(104, 24);
            this.rdb_fem.TabIndex = 0;
            this.rdb_fem.TabStop = true;
            this.rdb_fem.Text = "Feminino";
            this.rdb_fem.UseVisualStyleBackColor = true;
            this.rdb_fem.CheckedChanged += new System.EventHandler(this.rbn_masc_CheckedChanged);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(227, 97);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(133, 20);
            this.txtaltura.TabIndex = 2;
            this.txtaltura.TextChanged += new System.EventHandler(this.txtaltura_TextChanged);
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(98, 178);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(57, 13);
            this.lbl_peso.TabIndex = 3;
            this.lbl_peso.Text = "Peso Ideal";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BackColor = System.Drawing.Color.Silver;
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(189, 177);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(126, 23);
            this.lbl_resultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 234);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_altura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_masc;
        private System.Windows.Forms.RadioButton rdb_fem;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_resultado;
    }
}


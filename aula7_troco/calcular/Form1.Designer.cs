namespace calcular
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltroco = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmoeda1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmoeda050 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblmoeda025 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblmoeda010 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblmoeda005 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblmoeda001 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Pago em dinheiro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do Troco:";
            // 
            // lbltroco
            // 
            this.lbltroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltroco.Location = new System.Drawing.Point(178, 133);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(100, 18);
            this.lbltroco.TabIndex = 3;
            this.lbltroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Moedas para o troco";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmoeda1
            // 
            this.lblmoeda1.AutoSize = true;
            this.lblmoeda1.Location = new System.Drawing.Point(9, 69);
            this.lblmoeda1.Name = "lblmoeda1";
            this.lblmoeda1.Size = new System.Drawing.Size(13, 13);
            this.lblmoeda1.TabIndex = 5;
            this.lblmoeda1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Moedas de R$1,00";
            // 
            // lblmoeda050
            // 
            this.lblmoeda050.AutoSize = true;
            this.lblmoeda050.Location = new System.Drawing.Point(9, 118);
            this.lblmoeda050.Name = "lblmoeda050";
            this.lblmoeda050.Size = new System.Drawing.Size(13, 13);
            this.lblmoeda050.TabIndex = 7;
            this.lblmoeda050.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Moedas de R$0,50";
            // 
            // lblmoeda025
            // 
            this.lblmoeda025.AutoSize = true;
            this.lblmoeda025.Location = new System.Drawing.Point(9, 163);
            this.lblmoeda025.Name = "lblmoeda025";
            this.lblmoeda025.Size = new System.Drawing.Size(13, 13);
            this.lblmoeda025.TabIndex = 9;
            this.lblmoeda025.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Moedas de R$0,25";
            // 
            // lblmoeda010
            // 
            this.lblmoeda010.AutoSize = true;
            this.lblmoeda010.Location = new System.Drawing.Point(9, 209);
            this.lblmoeda010.Name = "lblmoeda010";
            this.lblmoeda010.Size = new System.Drawing.Size(13, 13);
            this.lblmoeda010.TabIndex = 11;
            this.lblmoeda010.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Moedas de R$0,10";
            // 
            // lblmoeda005
            // 
            this.lblmoeda005.AutoSize = true;
            this.lblmoeda005.Location = new System.Drawing.Point(9, 254);
            this.lblmoeda005.Name = "lblmoeda005";
            this.lblmoeda005.Size = new System.Drawing.Size(13, 13);
            this.lblmoeda005.TabIndex = 13;
            this.lblmoeda005.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Moedas de R$0,05";
            // 
            // lblmoeda001
            // 
            this.lblmoeda001.AutoSize = true;
            this.lblmoeda001.Location = new System.Drawing.Point(9, 299);
            this.lblmoeda001.Name = "lblmoeda001";
            this.lblmoeda001.Size = new System.Drawing.Size(13, 13);
            this.lblmoeda001.TabIndex = 15;
            this.lblmoeda001.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Moedas de R$0,01";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblmoeda1);
            this.panel1.Controls.Add(this.lblmoeda001);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblmoeda050);
            this.panel1.Controls.Add(this.lblmoeda005);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblmoeda025);
            this.panel1.Controls.Add(this.lblmoeda010);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(48, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 332);
            this.panel1.TabIndex = 17;
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(178, 34);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(100, 20);
            this.txtcompra.TabIndex = 18;
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Location = new System.Drawing.Point(178, 81);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(100, 20);
            this.txtdinheiro.TabIndex = 19;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(126, 183);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 587);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.txtcompra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmoeda1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblmoeda050;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblmoeda025;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblmoeda010;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblmoeda005;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblmoeda001;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Button btnCalcular;
    }
}


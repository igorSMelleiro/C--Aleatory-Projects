using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3_escolaNatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtUltimoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);

            if(idade > 17)
            {
                lblCategoria.Text = "Adulto";
            }

            else if (idade > 13)
            {
                lblCategoria.Text = "Juvenil B";
            }

            else if (idade > 10)
            {
                lblCategoria.Text = "Juvenil A";
            }

            else if (idade > 7)
            {
                lblCategoria.Text = "Infantil A";
            }

            else if (idade >=5)
            {
                lblCategoria.Text = "Infantil B";
            }

            else 
            {
                lblCategoria.Text = "Não existe categoria.";
            }
        }

        private void txtUltimoAniversario_TextChanged(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso digitar o Ano de Nascimento com 4 digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }

        }
        private void txtUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if(Convert.ToInt32(txtUltimoAniversario.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
            {
                MessageBox.Show("O Ano do Ultimo Aniversário deve ser superior ao do Ano de Nascimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}

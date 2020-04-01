using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocoNotas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sair()
        {
            if (txtTexto.Modified)

                bool resposta = (MessageBox.Show("O arquivo foi alterado, deseja salvar antes??", "***Finalizando o aplicativo***",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);

            if (resposta == true)
            {
                dlgSalvar.ShowDialog();
                System.IO.StreamWriter salvar =
                          new System.IOStreamWriter(dlgSalvar.FileName)
            salvar.Write(txtTexto.Text);
                salvar.Close();
                this.Close();
            }
            else
                this.Close();
        }
        else
    }
    this.Close();
}
    
    private void Novo()
    {
        if

    }

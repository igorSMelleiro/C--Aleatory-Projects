using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocoNota
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
            {
                bool resposta = (MessageBox.Show("O Arquivo foi alterado, deseja salvar antes?", "***Finalizando o Aplicativo***", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                if (resposta == true)
                {
                    dlgSalvar.ShowDialog();
                    System.IO.StreamWriter salvar = new System.IO.StreamWriter(dlgSalvar.FileName);
                    salvar.Write(txtTexto.Text);
                    salvar.Close();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }
        private void Novo()
        {

            if (txtTexto.Modified)
            {
                if (MessageBox.Show("O Arquivo foi alterado, deseja salvar antes?", "***Finalizando o Aplicativo***", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dlgSalvar.ShowDialog();
                }
                if (dlgSalvar.FileName != "")
                {

                    System.IO.StreamWriter salvar = new System.IO.StreamWriter(dlgSalvar.FileName);
                    salvar.Write(txtTexto.Text);
                    salvar.Close();

                }
                txtTexto.Rtf = string.Empty;
            }
            txtTexto.Clear();
            lblMensagem.Text = "Nome do Arquivo :";
        }

        private void Abrir()
        {

            if (txtTexto.Modified || txtTexto.Text != "")
            {
                bool resposta = (MessageBox.Show("O Arquivo foi alterado, deseja salvar antes?", "***Finalizando o Aplicativo***", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                if (resposta == true)
                {
                    dlgSalvar.ShowDialog();
                    System.IO.StreamWriter salvar = new System.IO.StreamWriter(dlgSalvar.FileName);
                    salvar.Write(txtTexto.Text);
                    salvar.Close();
                    //this.Close();
                    txtTexto.Rtf = string.Empty;
                }
            }
            else
                {
                    this.dlgAbrir.Multiselect = true;
                    this.dlgAbrir.Title = "Selecionar Arquivo";
                    dlgAbrir.InitialDirectory = @"C:\Dados\";
                    dlgAbrir.Filter = "Textos (*TXT)|*.TXT|" + "All Files (*.*)|*.*";
                    dlgAbrir.CheckFileExists = true;
                    dlgAbrir.CheckPathExists = true;
                    dlgAbrir.FilterIndex = 1;
                    dlgAbrir.RestoreDirectory = true;
                    dlgAbrir.ReadOnlyChecked = true;
                    dlgAbrir.ShowReadOnly = true;

                    DialogResult dr = this.dlgAbrir.ShowDialog();
                    if(dr == DialogResult.OK)
                    {
                        try
                        {
                            FileStream fs = new FileStream(dlgAbrir.FileName, FileMode.Open, FileAccess.Read);
                            StreamReader m_StreamReader = new StreamReader(fs);
                            //Lê o Arquivo Usando a Classe Stream Reader
                            m_StreamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                            this.txtTexto.Text = "";
                            string strLine = m_StreamReader.ReadLine();
                            while(strLine != null)
                            {
                                this.txtTexto.Text += strLine + "\n";
                                strLine = m_StreamReader.ReadLine();
                            }
                            m_StreamReader.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            
        }
        private void Salvar()
        {
            dlgSalvar.ShowDialog();
            if (dlgSalvar.FileName !="")
            {
                StreamWriter salvar = new StreamWriter(dlgSalvar.FileName);
                salvar.Write(txtTexto.Text);
                salvar.Close();
            }
            txtTexto.Rtf = string.Empty;
            txtTexto.Clear();
            lblMensagem.Text = "Nome do Arquivo:";
        }
        private void Letra()
        {
            DialogResult fonte = dlgFonte.ShowDialog();
            if (fonte == DialogResult.OK)
            {
                if (txtTexto.SelectionFont != null)
                {
                    txtTexto.SelectionFont = dlgFonte.Font;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void opcNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void opcAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void opcSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void opcSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void opcLetra_Click(object sender, EventArgs e)
        {
            Letra();
        }
    }
}

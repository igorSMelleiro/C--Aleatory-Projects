using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesoIdeal
{
    public partial class Form1 : Form
    {
        RadioButton rdbSelecionado = null;
        private RadioButton rbnSelecionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbn_masc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }

        }

        private void SetPesoIdeal()
        {

            try

            {
                double altura = Convert.ToDouble(txtaltura.Text);

                double PesoIdeal;

                if (rdbSelecionado.Text.Equals("Masculino"))

                    PesoIdeal = (72.7 * altura) -58;
                else

                    PesoIdeal = (62.1 * altura) -44.7;

                lbl_resultado.Text = PesoIdeal.ToString("N");

            }

            catch (Exception e)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);


            }


        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }
}
    

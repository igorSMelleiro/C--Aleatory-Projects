using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InverterValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtV1.Text;
            txtV1.Text = txtV2.Text;
            txtV2.Text = auxiliar;
            MessageBox.Show("Troca de Valores concluída", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

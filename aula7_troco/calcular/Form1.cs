using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular
{ 
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }
        private void Calcular()
        {
            //definir variaveis e inicializar

            decimal valorCompra = 0;
            decimal valorPago = 0;
            decimal resto = 0;

            //Converter valores para os tipos correspondentes das variavies

            valorCompra = Convert.ToDecimal(txtcompra.Text);
            valorPago = Convert.ToDecimal(txtdinheiro.Text);

            //calcular a diferença devolvida(troco)
            resto = valorPago - valorCompra;

            //Definir e atribuir o calculo de moedas a variável 1,0

            int moedas1 = (int)(resto /1);
            resto= resto % 1;
            lblmoeda1.Text = moedas1.ToString();

            //Definir e atribuir o calculo de moedas a variável 0,50

            int moedas050 = (int)(resto / 0.50m);
            resto = resto % 0.50m;
            lblmoeda050.Text = moedas050.ToString();

            //Definir e atribuir o calculo de moedas a variável 0,25

            int moedas025 = (int)(resto / 0.25m);
            resto = resto % 0.25m;
            lblmoeda025.Text = moedas025.ToString();

            //Definir e atribuir o calculo de moedas a variável 0,10

            int moedas010 = (int)(resto / 0.10m);
            resto = resto % 0.10m;
            lblmoeda010.Text = moedas010.ToString();

            //Definir e atribuir o calculo de moedas a variável 0,05

            int moedas005 = (int)(resto /0.05m);
            resto = resto % 0.05m;
            lblmoeda005.Text = moedas005.ToString();

            //Definir e atribuir o calculo de moedas a variável 0,01

            int moedas001 = (int)(resto / 0.01m);
            resto = resto % 0.01m;
            lblmoeda001.Text = moedas001.ToString();


            //Somar os resultados para a verificação e exibir em tela em formato monetario com duas casas pós-virgula(C2)
            lbltroco.Text = (moedas1+
                             moedas050 *0.50m+
                             moedas025*0.25m+
                             moedas010*0.10m+
                             moedas005*0.05m+
                             moedas001*0.01m).ToString("C2");
          

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}

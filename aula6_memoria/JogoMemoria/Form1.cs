using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class JogodaMemoria : Form
    {
        // firstClicked aponta para o primeiro controle Label que o jogador clica, mas será nulo se o jogador não clicou em uma etiqueta ainda
        Label firstClicked = null;
        // secondClicker aponta para o segundo controle Label que o jogador clica
        Label secondeClicked = null;


        //use este objeto aleatório para escolher ícones aleatórios para as labels
        Random random = new Random();
        // cada uma dessas letras é um ícone na fonte weddings,
        // e cada  ícone aparece duas vezes nesta lista
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z"
        };

        // atribui cada ícone da lista de ícones em um quadrado aleatório

            private void AtribuirIcones()
        {
            // o TableLayoutPanel tem 16 rótulos
            // e a lista de ícones tem 16 ícones
            // então um ícone é retirado aleatoriamente da lista
            // e adicionado a cada label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if  (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        public JogodaMemoria()
        {
            InitializeComponent();
            AtribuirIcones();
        }

        private void JogodaMemoria_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;



            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // se um rótulo clicado for preto, o jogador clicou um ícone qwue ja foi revelado - ignorar o clique
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                // se firstClicked for null, este é o primeiro ícone no par em que  o jogador clicou, então defina firstClicked para o rótulo que o jogador clicado, muda sua cor para preto e retorne
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
                // se o jogador chegar até aqui, o timer nao está rodando e firstClicked não é nulo então esse deve ser o segundo ícone em que o jogador clicou
                // defina sua cor para o preto
                secondeClicked = clickedLabel;
                secondeClicked.ForeColor = Color.Black;

                vericarGanhou();

                if(firstClicked.Text == secondeClicked.Text)
                {
                    firstClicked = null;
                    secondeClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pare o temporizador
            timer1.Stop();

            //ocultar os dois ícones
            firstClicked.ForeColor = firstClicked.BackColor;
            secondeClicked.ForeColor = secondeClicked.BackColor;
            //redefinir firstClicked e secondClicked então, da próxima vez que um rótulo for clicado, o programa sabe que é o primeiro clique
            firstClicked = null;
            secondeClicked = null;
        }

        private void vericarGanhou()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if(iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Você conseguiu!", "Parabéns");
            Close();
        }
    }


    
}

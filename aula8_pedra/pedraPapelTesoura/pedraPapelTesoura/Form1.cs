using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pedraPapelTesoura
{
    public partial class Form1 : Form
    {


        private int intPontosUsuario, intPontosComputador;
        public Form1()
        {
            InitializeComponent();
            intPontosComputador = 0;
            intPontosUsuario = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //variaveis 
            string varComputador = "";
            int elemJogador = 0, elemComputador = 0;
            Random rndElementoComputador;
            //definir o que o jogador escolheu
            if(rdpedra.Checked)
            {
                //escolheu pedra
                elemJogador = 0;
            }

            if (rdpapel.Checked)
            {
                //escolheu papel 
                elemJogador = 1;
            }

            if(rdtesoura.Checked)
            {
                elemJogador = 2;
            }

            //definir a escolha do computador 

            rndElementoComputador = new Random();
            elemComputador = rndElementoComputador.Next(0, 3);


            if (elemComputador == 0) //pedra
                varComputador = "pedra";
            if (elemComputador == 1) //papel
                varComputador = "papel";
            if (elemComputador == 2) //tesoura
                varComputador = "tesoura";

            //mostra ao usuario a escolha do computador
            lblresposta.Text = "O computador escolheu " + varComputador;

            //descobrir quem venceu e contar os pontos 
        if (elemJogador==0)
        { 
            if(elemComputador==0)//pedra
            {
                label2.Text = " Houve Empate.";
            }
            if (elemComputador == 1)//papel
            {
                label2.Text = "Papel embrulha pedra. O computador ganhou.";
                intPontosComputador++;
            }
            if (elemComputador == 2)//tesoura
            {
                label2.Text = "Pedra quebra tesoura. Você ganhou.";
                intPontosUsuario++;
            }

         }


          if (elemJogador == 1) //papel 
            {

                if (elemComputador == 0)//pedra
                {
                    label2.Text = " Papel embrulha pedra. Você ganhou";
                    intPontosUsuario++;
                }
                if (elemComputador == 1)//papel
                {
                    label2.Text = "Houve empate";
             
                }
                if (elemComputador == 2)//tesoura
                {
                    label2.Text = "Tesoura corta papel. O computador ganhou.";
                    intPontosComputador++;
                }


            }


            if (elemJogador == 2) //Tesoura 
            {

                if (elemComputador == 0)//pedra
                {
                    label2.Text = "Pedra quebra tesoura. O computador ganhou.";
               
                    intPontosComputador++;
                }
                if (elemComputador == 1)//papel
                {
                    label2.Text = "Tesoura corta papel. Você ganhou.";

                    intPontosUsuario++;

                }
                if (elemComputador == 2)//tesoura
                {
                    label2.Text = "Houve empate";
                    intPontosComputador++;
                }


            }


        }
    }
}

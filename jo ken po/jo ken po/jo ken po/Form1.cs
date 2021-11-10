using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jo_ken_po
{
    public partial class Form1 : Form
    {
        Image[] imgCPU = new Image[]
        {
            Properties.Resources.pedraE,
            Properties.Resources.papelE,
            Properties.Resources.tesouraE
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void clickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            pictureJogador.Image = bt.BackgroundImage;
            Jogada jogadaJogador = RetornaJogadadoJogador(Convert.ToInt32(bt.Tag));
            Jogada jogadaAdversario = RetornaJogadadoAdversario();
            Resultado resultado = retornaGanhador(jogadaJogador, jogadaAdversario);
            
            if(resultado== Resultado.VitoriaCpu)
            {
                ptCpu.Text = (int.Parse(ptCpu.Text) + 1).ToString();
            }
            else if (resultado == Resultado.VitoriaJogador)
            {
                ptJogador.Text = (int.Parse(ptJogador.Text) + 1).ToString();
            }

            if(int.Parse(ptCpu.Text)==20)
            {
                MessageBox.Show("CPU ganhou!");
                ptCpu.Text = 0.ToString();
                ptJogador.Text = 0.ToString();
            }
            else if (int.Parse(ptJogador.Text) == 20)
            {
                MessageBox.Show("Jogador ganhou!");
                ptCpu.Text = 0.ToString();
                ptJogador.Text = 0.ToString();
            }
        }

        enum Jogada
        {
            Pedra=0,
            Papel=1,
            Tesoura=2
        }

        enum Resultado
        {
            VitoriaJogador,
            VitoriaCpu,
            Empate
        }

        private Resultado retornaGanhador(Jogada jogador, Jogada adversario)
        {
            if(jogador== Jogada.Pedra) {
                if(adversario == Jogada.Papel){
                    return Resultado.VitoriaCpu;
                } else if(adversario== Jogada.Tesoura){
                    return Resultado.VitoriaJogador;}
            }

            else if (jogador == Jogada.Papel)
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }
                else if (adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCpu;
                }
            }

            else
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaCpu;
                }
                else if (adversario == Jogada.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }
            return Resultado.Empate;
        }

        private Jogada RetornaJogadadoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadadoAdversario()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            pictureCpu.Image = imgCPU[escolha];
            return (Jogada)escolha;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace KIngME_
{
    public partial class Jogabilidade : Form
    {
        Form1 form1 = new Form1();

        int idpartida;
        string[] id_senha_jogador;

        public Jogabilidade()
        {   
            InitializeComponent();
            this.idpartida = form1.idpartida;
            this.id_senha_jogador = form1.idSenhaJogadorEnviar;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            lblFavoritos.Text = Jogo.ListarCartas(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1]);
        }

        private void btnPosicionar_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(id_senha_jogador[0]);
            string senhaJogador = id_senha_jogador[1];
            int setor = Convert.ToInt32(txtSetor.Text);
            string colocar = Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, txtPosicionarPersonagem.Text);
            if (setor == null || txtPosicionarPersonagem.Text == "\0")
            {
                lblErroposicao.Text = colocar;
            }
            if (colocar.Substring(0, 4) == "ERRO")
            {
                lblErroposicao.Text = colocar;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string verificar = Jogo.VerificarVez(idpartida);
            string[] jogadorrr = verificar.Split('n');

            string[] idarray = jogadorrr[0].Split(',');
            string id = idarray[0];
            lblJogadorDaVez.Text = idarray[0];

            string ListadeJogadores = Jogo.ListarJogadores(idpartida);
            ListadeJogadores = ListadeJogadores.Replace("\r", "");
            string[] jogadores = ListadeJogadores.Split('\n');

            for (int i = 0; i < jogadores.Length; i++)
            {
                int virgula = jogadores[i].IndexOf(',');
                if (virgula == -1) continue; // Se não encontrar vírgula, pula para o próximo
                string antesVirgula = jogadores[i].Substring(0, virgula);

                if (id == antesVirgula)
                {
                    string[] dadosJogador = jogadores[i].Split(',');
                    label19.Text = dadosJogador[1]; // Nome do jogador

                }
            }


            // label19.Text = jogadores[1];

            // if (jogadorVez[1].ContainsKey(verificar))
            //{

            // }
        }
    }
}

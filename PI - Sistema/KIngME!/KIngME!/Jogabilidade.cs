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
        int contador = 1;
        public int idpartida { get; set; }
        public string[] id_senha_jogador { get; set; }

        public Jogabilidade()
        {   
            InitializeComponent();
            
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
                int virgula = jogadores[i].IndexOf(','); //buscar primeira virgula no array
                if (virgula == -1) continue; // Se não encontrar vírgula, pula para o próximo
                string antesVirgula = jogadores[i].Substring(0, virgula);

                if (id == antesVirgula)
                {
                    string[] dadosJogador = jogadores[i].Split(',');
                    label19.Text = dadosJogador[1]; // Nome do jogador

                }
            }
            string[] verificar_setor = verificar.Split('\n');
            //verificar_setor = verificar_setor.Replace("\r", "");
            for(int i = contador; i < verificar_setor.Length; i++)
            {
                verificar_setor = verificar_setor[i].Split(',');
                int setor = Convert.ToInt32(verificar_setor[0]);
                string personagem = verificar_setor[1];
            }
            contador++;
            
            /*Receber o setor, verificar qual personagem se encontra neste setor
              Criar 1 panel para cada setor
              Se a posição x1 y1 ja esta ocupada, adicionar personagem na posição x1+40 y1+40 e assim vai dobrando
              Como verificar o personagem naquele Setor, com a label do mesmo ?
              Switch case para verificar qual setor esta selecionado   
              variavel.location para receber e comparar cm aquela q deseja entrar.
             */

            // label19.Text = jogadores[1];

            // if (jogadorVez[1].ContainsKey(verificar))
            //{

            // }
        }

        private void Jogabilidade_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            lblPersonagemA.Location = new Point(-300, 0); // Colocar os labels para fora do panel(isso deixa eles "invisiveis")
            lblPersonagemB.Location = new Point(-300, 0);
            lblPersonagemC.Location = new Point(-300, 0);
            lblPersonagemD.Location = new Point(-300, 0);
            lblPersonagemE.Location = new Point(-300, 0);
            lblPersonagemG.Location = new Point(-300, 0);
            lblPersonagemH.Location = new Point(-300, 0);
            lblPersonagemK.Location = new Point(-300, 0);
            lblPersonagemL.Location = new Point(-300, 0);
            lblPersonagemM.Location = new Point(-300, 0);
            lblPersonagemQ.Location = new Point(-300, 0);
            lblPersonagemR.Location = new Point(-300, 0);
            lblPersonagemT.Location = new Point(-300, 0);
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

            bool[,] setor_disponivel = new bool[,] { // Inicializa uma matriz de booleano para saber qual posição está ocupada
                { false, false, false, false },
                { false, false, false, false },
                { false, false, false, false },
                { false, false, false, false },
                { false, false, false, false },
                { false, false, false, false }
            };

            for (int i = 1; i < verificar_setor.Length; i++)
            {
                verificar_setor = verificar_setor[i].Split(',');
                int setor = Convert.ToInt32(verificar_setor[0]);
                string personagem = verificar_setor[1];
                int x = 0;
                int y = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (setor_disponivel[setor, j] == false)
                    {
                        setor_disponivel[setor, j] = true;
                        x = j * 116;
                        y = 600 - (setor * 120);
                        break;
                    }
                }

                switch (personagem)
                {
                    case "A\r":
                        lblPersonagemA.Location = new Point(x, y);
                        break;
                    case "B\r":
                        lblPersonagemB.Location = new Point(x, y);
                        break;
                    case "C\r":
                        lblPersonagemC.Location = new Point(x, y);
                        break;
                    case "D\r":
                        lblPersonagemD.Location = new Point(x, y);
                        break;
                    case "E\r":
                        lblPersonagemE.Location = new Point(x, y);
                        break;
                    case "G\r":
                        lblPersonagemG.Location = new Point(x, y);
                        break;
                    case "H\r":
                        lblPersonagemH.Location = new Point(x, y);
                        break;
                    case "K\r":
                        lblPersonagemK.Location = new Point(x, y);
                        break;
                    case "L\r":
                        lblPersonagemL.Location = new Point(x, y);
                        break;
                    case "M\r":
                        lblPersonagemM.Location = new Point(x, y);
                        break;
                    case "Q\r":
                        lblPersonagemQ.Location = new Point(x, y);
                        break;
                    case "R\r":
                        lblPersonagemR.Location = new Point(x, y);
                        break;
                    case "T\r":
                        lblPersonagemT.Location = new Point(x, y);
                        break;
                    default:
                        break;
                }
                verificar_setor = verificar.Split('\n');
            }

            
            /*Receber o setor, verificar qual personagem se encontra neste setor
              Criar 1 panel para cada setor
              Se a posição x1 y1 ja esta ocupada, adicionar personagem na posição x1+40 y1+40 e assim vai dobrando
              Como verificar o personagem naquele Setor, com a label do mesmo ?
              Switch case para verificar qual setor esta selecionado   
              variavel.location para receber e comparar cm aquela q deseja entrar.
             */

        }

        private void Jogabilidade_Load(object sender, EventArgs e)
        {

        }

        private void lblPersonagemL_Click(object sender, EventArgs e)
        {

        }
    }
}

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
           coordenadasPersonagens();
        }
        public void coordenadasPersonagens()
        {
            picPersonagemA.Location = new Point(-300, 0); // Colocar os labels para fora do panel(isso deixa eles "invisiveis")
            picPersonagemB.Location = new Point(-300, 0);
            picPersonagemC.Location = new Point(-300, 0);
            picPersonagemD.Location = new Point(-300, 0);
            picPersonagemE.Location = new Point(-300, 0);
            picPersonagemG.Location = new Point(-300, 0);
            picPersonagemH.Location = new Point(-300, 0);
            picPersonagemK.Location = new Point(-300, 0);
            picPersonagemL.Location = new Point(-300, 0);
            picPersonagemM.Location = new Point(-300, 0);
            picPersonagemQ.Location = new Point(-300, 0);
            picPersonagemR.Location = new Point(-300, 0);
            picPersonagemT.Location = new Point(-300, 0);
        }
        public void verificarVez()
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
                { false, false, false, false },
                { false, false, false, false }
            };

            for (int i = 1; i < verificar_setor.Length; i++)
            {
                verificar_setor = verificar_setor[i].Split(',');
                if (verificar_setor[0] == "") return;
                int setor = Convert.ToInt32(verificar_setor[0]);
                string personagem = verificar_setor[1];
                int x = 0;
                int y = 0;

                for (int j = 0; j < 4; j++) // Verificação do espaço disponível para o personagem no setor 
                {                           // e determinação das coordenadas onde o label irá
                    if (setor == 10)
                    {
                        setor_disponivel[6, j] = true;
                        x = j * 116;
                        y = 720 - (6 * 120);
                        break;
                    }
                    else if (setor_disponivel[setor, j] == false && setor != 10)
                    {
                        setor_disponivel[setor, j] = true;
                        x = j * 116;
                        y = 720 - (setor * 120);
                        break;
                    }

                }

                switch (personagem) // Qual label será posicionado nessas coordenadas
                {
                    case "A\r":
                        picPersonagemA.Location = new Point(x, y);
                        break;
                    case "B\r":
                        picPersonagemB.Location = new Point(x, y);
                        break;
                    case "C\r":
                        picPersonagemC.Location = new Point(x, y);
                        break;
                    case "D\r":
                        picPersonagemD.Location = new Point(x, y);
                        break;
                    case "E\r":
                        picPersonagemE.Location = new Point(x, y);
                        break;
                    case "G\r":
                        picPersonagemG.Location = new Point(x, y);
                        break;
                    case "H\r":
                        picPersonagemH.Location = new Point(x, y);
                        break;
                    case "K\r":
                        picPersonagemK.Location = new Point(x, y);
                        break;
                    case "L\r":
                        picPersonagemL.Location = new Point(x, y);
                        break;
                    case "M\r":
                        picPersonagemM.Location = new Point(x, y);
                        break;
                    case "Q\r":
                        picPersonagemQ.Location = new Point(x, y);
                        break;
                    case "R\r":
                        picPersonagemR.Location = new Point(x, y);
                        break;
                    case "T\r":
                        picPersonagemT.Location = new Point(x, y);
                        break;
                    default:
                        break;
                }

                verificar_setor = verificar.Split('\n');
            }
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
            verificarVez();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verificarVez();
        }

        private void Jogabilidade_Load(object sender, EventArgs e)
        {

        }

        

        private void btnPromover_Click(object sender, EventArgs e)
        {
            Jogo.Promover(int.Parse(id_senha_jogador[0]), id_senha_jogador[1], txtPosicionarPersonagem.Text);
            verificarVez();
        }

        int votosN = 3;
        private void btnVotar_Click(object sender, EventArgs e) {
            if (txtVoto.Text == "N" && votosN > 0)
            {
                votosN--;
                Jogo.Votar(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1], txtVoto.Text);
                coordenadasPersonagens();
                verificarVez();
            }      
            else 
            {
                Jogo.Votar(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1], txtVoto.Text);
                coordenadasPersonagens();
                verificarVez();
            }
        }
    }
}

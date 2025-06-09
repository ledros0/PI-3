using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using manager;
namespace KIngME_
{
    public partial class Jogabilidade : Form
    {   
        Form1 form1 = new Form1();
        int contador = 1;
        public int idpartida { get; set; }
        public string[] idESenhaJogador { get; set; }
        faseSetup setup;
        public string favoritos;
        criarVotacao votar;
        verificarVezes verificarVezes;
        int qntdVotosNao = 3;
        Estrategia estrategia;


        public Jogabilidade()
        {   
            InitializeComponent();
            EsconderPersonagens();
            ContagemDeVotos();
            timerVerificarVez.Enabled = true;
        }
        public void jogadoresEmPartida()
        {
            string[] jogadores = Jogo.ListarJogadores(idpartida).Replace("\r","").Split('\n');
            lbListarJogadores.Items.Clear();
            for(int i = 0; i < jogadores.Length; i++)
            {
                lbListarJogadores.Items.Add(jogadores[i]);
            }
        }
        public void EsconderPersonagens()
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

        public void PosicionarPersonagens()
        {
            string[] setorPersonagem = Manager.matrizVerificarVez(idpartida);

            bool[,] setorEstaDisponivel = new bool[,] { // Inicializa uma matriz de booleano para saber qual posição está disponivel
                { true, true, true, true },
                { true, true, true, true },
                { true, true, true, true },
                { true, true, true, true },
                { true, true, true, true },
                { true, true, true, true },
                { true, false, false, false }
            };

            for (int i = 1; i < setorPersonagem.Length; i++)
            {
                string [] setorPersonagemSeparados = setorPersonagem[i].Split(',');
                
                if (setorPersonagemSeparados[0] == "") return; // Caso nenhuma jogada tenha sido feita
                
                int setor = Convert.ToInt32(setorPersonagemSeparados[0]);
                string personagem = setorPersonagemSeparados[1];

                int x = 0;
                int y = 0;         
                
                for (int j = 0; j < 4; j++) // Verificação do espaço disponível para o personagem no setor 
                {                           // e determinação das coordenadas onde o label irá
                    if (setor == 10)
                    {
                        setorEstaDisponivel[6, j] = false;
                        x = j * 116;
                        y = 720 - (setor * 120);
                        break;
                    }
                    else if (setorEstaDisponivel[setor, j] == true)
                    {
                        setorEstaDisponivel[setor, j] = false;
                        x = j * 116;
                        y = 720 - (setor * 120);
                        break;
                    }
                }

                switch (personagem) // Qual imagem será posicionada nessas coordenadas
                {
                    case "A":
                        picPersonagemA.Location = new Point(x, y);
                        break;
                    case "B":
                        picPersonagemB.Location = new Point(x, y);
                        break;
                    case "C":
                        picPersonagemC.Location = new Point(x, y);
                        break;
                    case "D":
                        picPersonagemD.Location = new Point(x, y);
                        break;
                    case "E":
                        picPersonagemE.Location = new Point(x, y);
                        break;
                    case "G":
                        picPersonagemG.Location = new Point(x, y);
                        break;
                    case "H":
                        picPersonagemH.Location = new Point(x, y);
                        break;
                    case "K":
                        picPersonagemK.Location = new Point(x, y);
                        break;
                    case "L":
                        picPersonagemL.Location = new Point(x, y);
                        break;
                    case "M":
                        picPersonagemM.Location = new Point(x, y);
                        break;
                    case "Q":
                        picPersonagemQ.Location = new Point(x, y);
                        break;
                    case "R":
                        picPersonagemR.Location = new Point(x, y);
                        break;
                    case "T":
                        picPersonagemT.Location = new Point(x, y);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ContagemDeVotos()
        {
            qntdVotosNao = Manager.ContarVotos(idpartida);    
        }

        private void Jogabilidade_Load(object sender, EventArgs e)
        {
            jogadoresEmPartida();
            setup = new faseSetup(idESenhaJogador, idpartida);

            estrategia = new Estrategia(Convert.ToInt32(idESenhaJogador[0]), "", idESenhaJogador[1], "", idpartida);

            favoritos = Jogo.ListarCartas(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1]);
            lblFavs.Text = favoritos.ToString(); 
            string[] letras = {"A","B","C","D","E","G","H","K","L","M","Q","R","T"};
            string naoFav = "";
            for (int i = 0; i < 13; i++)
            {
                if (favoritos.Contains(letras[i]))//Isso aq ta estranho.Poderia ser apenas um not
                {
                    continue;
                }
                else
                {
                    naoFav += Convert.ToString(letras[i]);
                }

            }
            qntdVotosNao = Manager.ContarVotos(idpartida);
            estrategia.AtualizarFavoritos(favoritos);

            estrategia.AtualizarNaoFav(naoFav);

            votar = new criarVotacao(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1], qntdVotosNao, favoritos, idpartida);

            verificarVezes = new verificarVezes();

            lblF.Text = Jogo.ListarCartas(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1]);
            lblvotosN.Text = qntdVotosNao.ToString();
        }
        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {
            string verificarFase = verificarVezes.verificarFaseDaPartida(idpartida);
            timerVerificarVez.Enabled = false;

            lblJogadorDaVez.Text = Manager.verificarNomeJogadorVez(idpartida);
            label19.Text = Manager.VerificarID(idpartida);

            int jogador = Convert.ToInt32(Manager.VerificarID(idpartida));
            if (jogador == Convert.ToInt32(idESenhaJogador[0]))
            {
                switch (verificarFase)
                {
                    case "S":
                        setup.posicionarPersonagem();
                        break;

                    case "P":
                        estrategia.NumeroJogadores();
                        break;

                    case "V":
                        setup.removerTodaLista();
                        votar.Voto();
                        setup.reescreverLista();
                        EsconderPersonagens();
                       // favoritos = Jogo.ListarCartas(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1]);
                        lblFavs.Text = favoritos.ToString();
                        lblvotosN.Text = votar.qntdVotosNao.ToString() ;
                        break;
                    case "E":
                        lblfim.Text = "Fim de jogo";
                        break;
                }
            }
            jogadoresEmPartida();
            EsconderPersonagens();
            PosicionarPersonagens();
            timerVerificarVez.Enabled = true; 
        }

        private void lblvotosN_Click(object sender, EventArgs e)
        {

        }
    }
}

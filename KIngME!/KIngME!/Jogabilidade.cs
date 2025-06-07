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
        public int idDaPartida { get; set; }
        public string[] idESenhaJogador { get; set; }
        int contador = 1;
        public string favoritos;
        int qntdVotosNao = 3;

        faseSetup setup;
        fasePromocao promocao;     
        criarVotacao votar;   
        Estrategia estrategia;


        public Jogabilidade()
        {   
            InitializeComponent();
            coordenadasPersonagens();
        
            timerVerificarVez.Enabled = true;
        }
        public void jogadoresEmPartida()
        {
            string[] jogadores = Jogo.ListarJogadores(idDaPartida).Replace("\r","").Split('\n');
            lbListarJogadores.Items.Clear();
            for(int i = 0; i < jogadores.Length; i++)
            {
                lbListarJogadores.Items.Add(jogadores[i]);
            }
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
            lblJogadorDaVez.Text = Manager.verificarNomeJogadorVez(idDaPartida);
            label19.Text = Manager.VerificarID(idDaPartida);

            string verificar = Jogo.VerificarVez(idDaPartida).Replace("\r", "");
            string[] verificar_setor = verificar.Split('\n');
            //
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
                        y = 720 - (setor * 120);
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
                verificar_setor = verificar.Split('\n');
            }
        }
        public void ContagemDeVotos()
        {
            qntdVotosNao = Manager.ContarVotos(idDaPartida);    
            lblvotosN.Text = qntdVotosNao.ToString();
        }

        private void Jogabilidade_Load(object sender, EventArgs e)
        {
            ContagemDeVotos();
            jogadoresEmPartida();
            setup = new faseSetup(idESenhaJogador, idDaPartida);

            estrategia = new Estrategia(Convert.ToInt32(idESenhaJogador[0]), "", idESenhaJogador[1], "", idDaPartida);

            favoritos = Jogo.ListarCartas(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1]);

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
            estrategia.AtualizarFavoritos(favoritos);

            estrategia.AtualizarNaoFav(naoFav);

            votar = new criarVotacao(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1], qntdVotosNao, favoritos, idDaPartida);


            lblF.Text = Jogo.ListarCartas(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1]);
        }
        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {

            string verificarFase = Manager.VerificarFaseDaPartida(idDaPartida);
            
            //listaPersonagem.contains(nomeDaVariavel)
            timerVerificarVez.Enabled = false;
            
            int jogador = Convert.ToInt32(Manager.VerificarID(idDaPartida));
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
                        coordenadasPersonagens();
                        lblvotosN.Text = votar.QvotosN.ToString();
                        break;
                    case "E":
                        lblfim.Text = "Fim de jogo";
                        break;
                }
            }
            jogadoresEmPartida();
            coordenadasPersonagens();
            verificarVez();
            timerVerificarVez.Enabled = true; 
        }

        private void lblvotosN_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace KIngME_
{
    public partial class Jogabilidade : Form
    {   
        Form1 form1 = new Form1();
        int contador = 1;
        public int idpartida { get; set; }
        public string[] id_senha_jogador { get; set; }
        faseSetup setup;
        fasePromocao promocao;
        public string favoritos;
        criarVotacao votar;
        verificarVezes verificarVezes;
        int votosN = 3;
        Estrategia estrategia;


        public Jogabilidade()
        {   
            InitializeComponent();
            coordenadasPersonagens();
            ContagemDeVotos();
            timerVerificarVez.Enabled = true;
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
            lblJogadorDaVez.Text = verificarVezes.verificarNomeJogadorVez(idpartida);
            label19.Text = verificarVezes.verificarGlobal(idpartida);

            string verificar = Jogo.VerificarVez(idpartida);
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
        public void ContagemDeVotos()
        {
            string listaDeJogadores = Jogo.ListarJogadores(idpartida).Replace("\r","");
            string[] lista = listaDeJogadores.Split('\n');
            switch (lista.Length)
            {
                case 3:
                    votosN = 4;
                    break;
                case 4:
                    votosN = 3;
                    break;
            }      
        }

        private void Jogabilidade_Load(object sender, EventArgs e)
        {
            setup = new faseSetup(id_senha_jogador, idpartida);

            estrategia = new Estrategia(Convert.ToInt32(id_senha_jogador[0]), "", id_senha_jogador[1], "", idpartida);

            favoritos = Jogo.ListarCartas(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1]);

            string[] letras = {"A","B","C","D","E","G","H","K","L","M","Q","R","T"};
            string naoFav = "";
            for (int i = 0; i < 13; i++)
            {
                if (favoritos.Contains(letras[i]))
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

            votar = new criarVotacao(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1], votosN, favoritos, idpartida);

            verificarVezes = new verificarVezes();

            lblF.Text = Jogo.ListarCartas(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1]);
        }
        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {
            string[] verificarLinhaUm = Jogo.VerificarVez(idpartida).Replace("\r","").Split('\n') ;

            string[] verificarFase = verificarLinhaUm[0].Split(',');
            
            //listaPersonagem.contains(nomeDaVariavel)
            timerVerificarVez.Enabled = false;
            string[] jogadorDaVez = Jogo.VerificarVez(idpartida).Split(',');
            int jogador = Convert.ToInt32(jogadorDaVez[0]);
            if (jogador == Convert.ToInt32(id_senha_jogador[0]))
            {
                switch (verificarFase[3])
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
                        break;
                    case "E":
                        lblfim.Text = "Fim de jogo";
                        break;
                }
            }
            coordenadasPersonagens();
            verificarVez();
            timerVerificarVez.Enabled = true; 
        }

        private void lblvotosN_Click(object sender, EventArgs e)
        {

        }
    }
}

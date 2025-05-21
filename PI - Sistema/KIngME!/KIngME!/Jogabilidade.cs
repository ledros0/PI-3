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

        List<string> listaPersonagens = new List<string>(){
            "A", "B", "C", "D", "E", "G", "H", "K", "L", "M", "Q", "R", "T"
        };

        faseSetup setup;
        fasePromocao promocao;
        verificarVezes verificarVezes;
        public string favoritos;
        votacao votoo;
        int votosN = 3;

        public Jogabilidade()
        {   
            InitializeComponent();
           coordenadasPersonagens();
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


            promocao = new fasePromocao(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1], "");

            favoritos = Jogo.ListarCartas(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1]);

            promocao.AtualizarFavoritos(favoritos);

            votoo = new votacao(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1], votosN, favoritos, idpartida);
            
            verificarVezes = new verificarVezes();

            lblF.Text = Jogo.ListarCartas(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1]);

        }
        public string listarNovosFavoritos()
        {
            favoritos = Jogo.ListarCartas(Convert.ToInt32(id_senha_jogador[0]), id_senha_jogador[1]);
            return favoritos;
        }
       
        private void timerVerificarVez_Tick(object sender, EventArgs e)
        {
            if (listaPersonagens.Count == 0)
                return;

            Random r = new Random();
            int setorAleatorio = r.Next(1, 5);
            int personagemAleatorio = r.Next(0, listaPersonagens.Count);
            
            //listaPersonagem.contains(nomeDaVariavel)
            timerVerificarVez.Enabled = false;

            int idJogador = Convert.ToInt32(id_senha_jogador[0]);
            string[] jogadorDaVez = Jogo.VerificarVez(idpartida).Split(',');

            int jogador = Convert.ToInt32(jogadorDaVez[0]);
            string senhaJogador = id_senha_jogador[1];

            string[] verificarFase = verificarLinhaUm[0].Split(',');

            int fase = 1;
            int faseAtual = verificarVezes.verificarFaseDaPartida(idpartida);

          

            //listaPersonagem.contains(nomeDaVariavel)
            timerVerificarVez.Enabled = false;

            int jogador = Convert.ToInt32(verificarVezes.verificarGlobal(idpartida)) ;


            if (jogador == Convert.ToInt32(id_senha_jogador[0]))
            {   
                Jogo.ColocarPersonagem(idJogador, senhaJogador, setorAleatorio,
                Convert.ToString(listaPersonagens[personagemAleatorio]));
                listaPersonagens.Remove(listaPersonagens[personagemAleatorio]);            
            }

            string[] verificarPersonagemTabuleiro = Jogo.VerificarVez(idpartida).Replace("\r", "").Split('\n');

            if (verificarPersonagemTabuleiro[0] == "") return;
            for (int i = 1; i < verificarPersonagemTabuleiro.Length; i++)
            {
                string[] siglaPersonagem = verificarPersonagemTabuleiro[i].Split(',');
                if (listaPersonagens.Contains(siglaPersonagem[0]))
                {

                    listaPersonagens.Remove(siglaPersonagem[0]);

                    case "S":
                        setup.posicionarPersonagem();
                        break;

                    case "P":
                        promocao.posicionar();
                        break;

                    case "V":
                        setup.removerTodaLista();
                        votoo.Voto();
                        setup.reescreverLista();
                        break;
                    case "E":
                        lblfim.Text = "Fim de jogo";
                        break;

                }

            }

            verificarVez();
            timerVerificarVez.Enabled = true;
            /* Precisamos receber jogo.verificarVez.
               Ignoramos a primeira linha e pegamos o segundo de cada linha poterior
                Exemplo:
                    123,J,S,
                    4.A
                    4.E
                    3.B 
                *Precisamos das letras*
                
                Após isso removemos da listaPersonagens o que ja foi colocado no tabuleiro.
                               
              */
            
        }
    }
}

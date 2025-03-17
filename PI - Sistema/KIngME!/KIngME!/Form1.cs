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

    public partial class btnfavoritos : Form
    {
        string[] Id_Senha_Jogador;
        string[] jogadorrr;
        int n;
        string grupo = "Copistas de Durham";

        public btnfavoritos()
        {
            InitializeComponent();
            cbListarOpcoes.SelectedIndex = 0;
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string RetornoPartidas = cbListarOpcoes.SelectedItem.ToString();

            switch (RetornoPartidas)
            {
                case "Todos":
                    RetornoPartidas = Jogo.ListarPartidas("T");
                    break;
                case "Abertas":
                    RetornoPartidas = Jogo.ListarPartidas("A");
                    break;
                case "Jogando":
                    RetornoPartidas = Jogo.ListarPartidas("J");
                    break;
                case "Encerradas":
                    RetornoPartidas = Jogo.ListarPartidas("E");
                    break;

            }


            RetornoPartidas = RetornoPartidas.Replace("\r", "");
            RetornoPartidas = RetornoPartidas.Substring(0, RetornoPartidas.Length - 1);
            string[] Partidas = RetornoPartidas.Split('\n');

            lbPartidasListadas.Items.Clear();

            for (int i = 0; i < Partidas.Length; i++)
            {
                lbPartidasListadas.Items.Add(Partidas[i]); //Mostrar Partidas Criadas
            }
            lblgrupo.Text = Jogo.versao;
            lblversao.Text = grupo;
        }
        private void lbPartidasListadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Partida = lbPartidasListadas.SelectedItem.ToString();
            string[] DivisaoPartida = Partida.Split(','); //Divide os dados da partida e os separa num Array de String

            int idPartida = Convert.ToInt32(DivisaoPartida[0]);
            string nomePartida = DivisaoPartida[1];

            lblidPartida.Text = idPartida.ToString();
            lblNomePartida.Text = nomePartida;

            string ListaDeJogadores = Jogo.ListarJogadores(idPartida);

            if (ListaDeJogadores.Length >= 4 && ListaDeJogadores.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Houve um Problema: \n" + ListaDeJogadores);
                return;
            }

            ListaDeJogadores = ListaDeJogadores.Replace("\r", "");

            string[] jogadores = ListaDeJogadores.Split('\n');

            lbListarJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lbListarJogadores.Items.Add(jogadores[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text, grupo));
            lblNomeGrupo.Text = grupo;
            lblPartida.Text = Convert.ToString(n);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarNaPartida_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txtIdPartida.Text);

            string Jogador = Jogo.Entrar(idPartida, txtJogadorNome.Text, txtSenhaEntrarPartida.Text);

            Id_Senha_Jogador = Jogador.Split(',');
            //int ID_Jogador = Convert.ToInt32(Id_Senha_Jogador);
            if (Jogador.Substring(0,4)=="ERRO")
            {
                lblerros.Text = Jogador;
            }
            else
            {
                lblIdJogador.Text = Id_Senha_Jogador[0];
                lblSenhaJogador.Text = Id_Senha_Jogador[1];
            }
            
        }
        private void lblIdJogador_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Entrar_IdJogador = Convert.ToInt32(Id_Senha_Jogador[0]);

            string jogo_Iniciar = Jogo.Iniciar(Entrar_IdJogador, Id_Senha_Jogador[1]);
            //if (jogo_Iniciar.Substring(0, 4) == "ERRO")
           // {
            //    lblErroIniciar.Text = Jogo.ListarCartas(Entrar_IdJogador, Id_Senha_Jogador[1]);
            //}
           // else
           // {/
               
           // }


        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblFavoritos_Click(object sender, EventArgs e)
        {

        }

        private void lbListarPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jogo.ListarPersonagens();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPosicionar_Click(object sender, EventArgs e)
        {
         
            int idJogador = Convert.ToInt32(Id_Senha_Jogador[0]);
            string senhaJogador = Id_Senha_Jogador[1];
            int setor = Convert.ToInt32(txtSetor.Text);
           string colocar = Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, txtPosicionarPersonagem.Text);
            if(setor == null || txtPosicionarPersonagem.Text == "\0")
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
            string verificar = Jogo.VerificarVez(n);
            jogadorrr = verificar.Split('n');

            string [] idarray = jogadorrr[0].Split(',');
            string id = idarray[0];
            lblJogadorDaVez.Text = idarray[0];

           string ListadeJogadores = Jogo.ListarJogadores(n);
           ListadeJogadores = ListadeJogadores.Replace("\r", "");
           string []jogadores = ListadeJogadores.Split('\n');      

            for (int i = 0; i < jogadores.Length; i++)
            {
                int virgula = jogadores[i].IndexOf(',');

                if (virgula == -1) continue; // Se não encontrar vírgula, pula para o próximo

                string antesVirgula = jogadores[i].Substring(0, virgula);

                if (id == antesVirgula)
                {
                    string[] dadosJogador = jogadores[i].Split(','); 
                    if (dadosJogador.Length > 1) // Evita erro caso a linha esteja errada
                    {
                        label19.Text = dadosJogador[1]; // Nome do jogador
                    }
                }
            }


            // label19.Text = jogadores[1];

            // if (jogadorVez[1].ContainsKey(verificar))
            //{

            // }

        }

        private void button4_Click(object sender, EventArgs e)
        {
          lblFavoritos.Text=  Jogo.ListarCartas(Convert.ToInt32(Id_Senha_Jogador[0]), Id_Senha_Jogador[1]);
        }
    }
}
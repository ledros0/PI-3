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
using manager;

namespace KIngME_
{

    public partial class Form1 : Form
    {
        verificarVezes verificarVezes;
        
        string[] idESenhaJogador;
        
        int idDaPartida; 

        public string grupo = "Copistas de Durham";

       
       
        public Form1()
        {
            InitializeComponent();
            ListarPartidas();
            cbListarOpcoes.SelectedIndex = 0;
            
        }

        public void ListarPartidas()
        {
            string[] Partidas = Manager.ListaDePartida();

            lbPartidasListadas.Items.Clear();

            for (int i = 0; i < Partidas.Length; i++)
            {
                lbPartidasListadas.Items.Add(Partidas[i]); //Mostrar Partidas Criadas
            }
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
            string[] jogadores = ListaDeJogadores.Replace("\r","").Split('\n');

            lbListarJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lbListarJogadores.Items.Add(jogadores[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            idDaPartida = Convert.ToInt32(Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text, grupo));
            lblNomeGrupo.Text = grupo;
            lblPartida.Text = Convert.ToString(idDaPartida);
            txtIdPartida.Text = Convert.ToString(idDaPartida);
            txtSenhaEntrarPartida.Text = txtSenhaPartida.Text;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarNaPartida_Click(object sender, EventArgs e)
        {
            idDaPartida = Convert.ToInt32(txtIdPartida.Text);
            //int idPartida = Convert.ToInt32(txtIdPartida.Text);
            
            string Jogador = Jogo.Entrar(idDaPartida, txtJogadorNome.Text, txtSenhaEntrarPartida.Text);

            idESenhaJogador = Jogador.Split(',');
            //int ID_Jogador = Convert.ToInt32(Id_Senha_Jogador);
            if (Jogador.Substring(0,4)=="ERRO")
            {
                lblerros.Text = Jogador;
            }
            else
            {
                lblIdJogador.Text = idESenhaJogador[0];
                lblSenhaJogador.Text = idESenhaJogador[1];
            }
            
        }
        private void lblIdJogador_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Entrar_IdJogador = Convert.ToInt32(idESenhaJogador[0]);

            string jogo_Iniciar = Jogo.Iniciar(Entrar_IdJogador, idESenhaJogador[1]);

            Jogabilidade jogar = new Jogabilidade();
            jogar.idDaPartida = this.idDaPartida;
            jogar.idESenhaJogador = this.idESenhaJogador;
            jogar.Show();
            timer1.Stop();
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
            verificarVezes = new verificarVezes();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bool trocarJanela = Manager.DeveMudarTela(idDaPartida);
            if (trocarJanela) {
                string jogo_Iniciar = Jogo.Iniciar(Convert.ToInt32(idESenhaJogador[0]), idESenhaJogador[1]);

                Jogabilidade jogar = new Jogabilidade();
                jogar.idDaPartida = this.idDaPartida;
                jogar.idESenhaJogador = this.idESenhaJogador;
                jogar.Show();

                timer1.Stop();
               
            }
            

        }

        private void lblgrupo_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
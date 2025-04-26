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
    public partial class Lobby : Form
    {
        string nomeGrupo = "Copistas de Durham";
        int idPartida;
        int idJogador;
        string senhaJogador; 
        
        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text += Jogo.versao;
            lblNomeGrupo.Text = nomeGrupo;
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtNomePartida.Text;
            string senhaPartida = txtSenhaPartida.Text;

            txtIdPartida.Text = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string statusPartidas = cbStatusPartidas.SelectedItem.ToString();

            switch (statusPartidas)
            {
                case "Todos":
                    statusPartidas = Jogo.ListarPartidas("T");
                    break;
                case "Abertas":
                    statusPartidas = Jogo.ListarPartidas("A");
                    break;
                case "Jogando":
                    statusPartidas = Jogo.ListarPartidas("J");
                    break;
                case "Encerradas":
                    statusPartidas = Jogo.ListarPartidas("E");
                    break;
            }

            statusPartidas = statusPartidas.Replace("\r", "").Substring(0, statusPartidas.Length - 1);
            
            string[] partidas = statusPartidas.Split('\n');

            lbPartidas.Items.Clear();

            for (int i = 0; i < partidas.Length; i++)
                lbPartidas.Items.Add(partidas[i]);
        }

        private void lbPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dadosPartidaSelecionada = lbPartidas.SelectedItem.ToString().Split(',');
            int idPartidaSelecionada = Convert.ToInt32(dadosPartidaSelecionada[0]);
            string nomePartidaSelecionada = dadosPartidaSelecionada[1];

            txtNomePartida.Text = nomePartidaSelecionada;
            txtIdPartida.Text = idPartidaSelecionada.ToString();
            
            string jogadoresPartida = Jogo.ListarJogadores(idPartidaSelecionada);

            if (jogadoresPartida.Length >= 4 && jogadoresPartida.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Houve um Problema: \n" + jogadoresPartida);
                return;
            }

            jogadoresPartida = jogadoresPartida.Replace("\r", "");

            string[] jogadores = jogadoresPartida.Split('\n');

            lbJogadores.Items.Clear();

            for (int i = 0; i < jogadores.Length; i++)
                lbJogadores.Items.Add(jogadores[i]);
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            idPartida = Convert.ToInt32(txtIdPartida.Text);

            string[] dadosJogador = Jogo.Entrar(idPartida, txtNomeJogador.Text, txtSenhaPartida.Text).Split(',');

            if (dadosJogador[0].Substring(0, 4) == "ERRO")
                lblErros.Text = dadosJogador[0];
            else
            {
                idJogador = Convert.ToInt32(dadosJogador[0]);
                senhaJogador = dadosJogador[1];
                lblIdJogador.Text = $"Seu ID\r{idJogador}";
                lblSenhaJogador.Text = $"Sua senha\r{senhaJogador}";
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

            Jogo.Iniciar(idJogador, senhaJogador);

            Jogabilidade jogar = new Jogabilidade();

            jogar.idpartida = this.idPartida;
            jogar.id_senha_jogador = this.senhaJogador;
            jogar.Show();
        }
    }
}

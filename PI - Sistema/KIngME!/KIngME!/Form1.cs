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
    
    public partial class Form1 : Form
    {
        string grupo = "Copistas de Durham";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string RetornoPartidas = Jogo.ListarPartidas("T");

            RetornoPartidas = RetornoPartidas.Replace("\r", "");
            RetornoPartidas = RetornoPartidas.Substring(0, RetornoPartidas.Length-1);
            string[] Partidas = RetornoPartidas.Split('\n');

            lbPartidasListadas.Items.Clear();
            for (int i = 0; i < Partidas.Length ; i++)
            {
                lbPartidasListadas.Items.Add(Partidas[i]); //Mostrar Partidas Criadas
            }
            lblgrupo.Text = Jogo.versao;
            lblversao.Text = grupo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text, grupo);
            lblNomeGrupo.Text = grupo;
           
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

            if(ListaDeJogadores.Length >= 4 && ListaDeJogadores.Substring(0,4) == "ERRO")
            {
                MessageBox.Show("Houve um Problema: \n" + ListaDeJogadores);
                return;
            }
           
            ListaDeJogadores = ListaDeJogadores.Replace("\r", "");

            string[] jogadores = ListaDeJogadores.Split('\n');
    
            lbListarJogadores.Items.Clear();
            for(int i = 0; i < jogadores.Length; i++)
            {
                lbListarJogadores.Items.Add(jogadores[i]);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

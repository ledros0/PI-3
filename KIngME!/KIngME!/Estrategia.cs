using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIngME_
{
    public class Estrategia
    {
        private int idJogador;
        private string favoritos;
        private string senhaJogador;
        private string naoFavoritos;
        private int idPartida;

        public Estrategia(int idJogador, string favoritos, string senhaJogador, string naoFavoritos, int idPartida)
        {
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.idPartida = idPartida;
        }
        public void AtualizarFavoritos(string favsNovos) => this.favoritos = favsNovos;
        public void AtualizarNaoFav(string Nfavs) => this.naoFavoritos = Nfavs;

        public void NumeroJogadores()
        {
            string listaDeJogadores = Jogo.ListarJogadores(idPartida).Replace("\r", "");
            string[] lista = listaDeJogadores.Split('\n');
            
            if(lista.Length > 0)
            {
                PartidaNormal();
            }
            else
            {
                PartidaAprimorada();
            }
        }
        public void PartidaNormal()
        {
            Random r = new Random();
            string[] letrasFavoritos = favoritos.Select(c => c.ToString()).ToArray();
            int i = r.Next(0, letrasFavoritos.Length);
            Jogo.Promover(idJogador, senhaJogador, letrasFavoritos[i]);
        }
        public void PartidaAprimorada()
        {

        }
    }
}
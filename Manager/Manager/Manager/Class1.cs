using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using KingMeServer;

namespace manager
{
    public static class Manager
    {
        /*Resumo:
         *      Metodo para verificar o id do jogador da vez
         *   Devolução:
         *      Retorna o id do jogador da vez
         * 
         * 
         */
        public static string VerificarID(int idPartida) //Retorna id do Jogador da vez
        {
            string verificar = Jogo.VerificarVez(idPartida);
            string[] jogadorrr = verificar.Split('\n');
            string[] idarray = jogadorrr[0].Split(',');
            string id = idarray[0];
            return idarray[0];
        }
        /*Resumo:
         *  Verifica o nome do jogador da vez
         *  metodo feito para saber o nome do jogador da vez
         *  Devolução: 
         *      Nome do jogador da vez
         */
        public static string verificarNomeJogadorVez(int idPartida)
        {
            string id = VerificarID(idPartida);
            string ListadeJogadores = Jogo.ListarJogadores(idPartida);
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
                    return dadosJogador[1]; // Nome do jogador
                }
                continue;
            }
            return "\0";
        }
        /*Resumo:
         *   Metodo feito para verificar a fase atual da partida
         *   para automação
         *   
         *   Devoluções:
         *      S -> fase de setup
         *      P -> Promoção
         *      V -> Voto
         */
        public static string VerificarFaseDaPartida(int idPartida)
        {
            string verificar = Jogo.VerificarVez(idPartida);
            string[] procuraFase = verificar.Replace("\r", "").Split('\n');
            string[] fase = procuraFase[0].Split(',');
            return fase[3];
        }
        //Resumo:
        //    retorna para o form1 se a partida começou ou não
        /*Devolução:
         * True: Partida começou
         * False: Partida não começou
         */
        public static bool DeveMudarTela(int id)
        {
            string[] listaDePartidas = Jogo.ListarPartidas("T").Replace("\r", "").Split('\n');
            for (int i = 0; i < listaDePartidas.Length - 1; i++)
            {
                string[] procurandoStatusPartida = listaDePartidas[i].Split(',');
                if (id == Convert.ToInt32(procurandoStatusPartida[0]) && procurandoStatusPartida[3] == "J")
                {
                    return true;
                }
            }
            return false;
        }

        public static int ContarVotos(int id)
        {
            string listaDeJogadores = Jogo.ListarJogadores(id).Replace("\r", "");
            string[] lista = listaDeJogadores.Split('\n');
            switch (lista.Length)
            {
                case 3:
                    return 4;
                case 4:
                    return 3;
            }
            return 0;
        }

        public static string[] ListaDePartida()
        {
            string RetornoPartidas = Jogo.ListarPartidas("T");
            RetornoPartidas = RetornoPartidas.Replace("\r", "");
            RetornoPartidas = RetornoPartidas.Substring(0, RetornoPartidas.Length - 1);
            string[] Partidas = RetornoPartidas.Split('\n');
            return Partidas;
        }
    }
}

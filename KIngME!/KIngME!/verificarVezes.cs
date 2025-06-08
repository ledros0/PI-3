using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;
public class verificarVezes
{
    public string verificarGlobal(int idPartida) //Retorna
    {
        string verificar = Jogo.VerificarVez(idPartida);
        string[] jogadorrr = verificar.Split('\n');
        string[] idarray = jogadorrr[0].Split(',');
        string id = idarray[0];
        return idarray[0];
    }
    public string verificarNomeJogadorVez(int idPartida)
    {
        string id = verificarGlobal(idPartida);

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
    public string verificarFaseDaPartida(int idPartida)
    {
        string verificar = Jogo.VerificarVez(idPartida);
        string[] procuraFase = verificar.Replace("\r", "").Split('\n');

        string[] fase = procuraFase[0].Split(',');
        return (fase[3]);
    }
    public bool deveMudarTela(int id)
    {
        string[] listaDePartidas = Jogo.ListarPartidas("T").Replace("\r","").Split('\n');
       
        for(int i = 0; i < listaDePartidas.Length-1; i++)
        {
            string[] procurandoStatusPartida = listaDePartidas[i].Split(',') ;
            if (id == Convert.ToInt32(procurandoStatusPartida[0]) && procurandoStatusPartida[3] == "J")
            {
                return true;
            }          
        }
        return false;
    }

}
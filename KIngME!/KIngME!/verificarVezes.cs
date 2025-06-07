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
        string[] idJogador = verificar.Split('\n');
        string[] idJogadorArray = idJogador[0].Split(',');
        string id = idJogadorArray[0];
        return idJogadorArray[0];
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
    public int verificarFaseDaPartida(int idPartida)
    {
        string verificar = Jogo.VerificarVez(idPartida);
        string[] procuraFase = verificar.Replace("\r", "").Split('\n');

        string[] fase = procuraFase[0].Split(',');
        return Convert.ToInt32(fase[2]);
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

    public (int x, int y) coordenadasXY(int idpartida)
    {
        int X = 0 ;
        int Y = 0;
        string verificar = Jogo.VerificarVez(idpartida).Replace("\r", "");
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
            if (verificar_setor[0] == "") return (0,0);
            int setor = Convert.ToInt32(verificar_setor[0]);
            for (int j = 0; j < 4; j++) // Verificação do espaço disponível para o personagem no setor 
            {                           // e determinação das coordenadas onde o label irá
                if (setor == 10)
                {
                    setor_disponivel[6, j] = true;
                    X = j * 116;
                    Y = 720 - (setor * 120);
                    break;
                }
                else if (setor_disponivel[setor, j] == false && setor != 10)
                {
                    setor_disponivel[setor, j] = true;
                    X = j * 116;
                    Y = 720 - (setor * 120);
                    break;
                    
                }

            }
        }
        return (X, Y);
    }

}
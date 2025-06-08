using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace KIngME_
{
    public class criarVotacao
    {
        int QvotosN;
        int idPartida;
        string senhaJogador;
        string favoritos;
        int idJogador;
        public criarVotacao(int idJogador, string senhaJogador, int qvotosN, string favoritos, int idPartida)
        {
            this.QvotosN = qvotosN;
            this.idPartida = idPartida;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.favoritos = favoritos;
        }

        public void Voto()
        {
            string estadoJogo = Jogo.VerificarVez(idPartida);
            string[] linhas = estadoJogo.Replace("\r", "").Split('\n');

            if (linhas.Length < 2)
            {
                Jogo.Votar(idJogador, senhaJogador, "S");
                return;
            }

            string[] dadosRei = linhas[linhas.Length - 2].Split(',').Select(x => x.Trim()).ToArray();

            if (dadosRei.Length < 2)
            {
                Jogo.Votar(idJogador, senhaJogador, "S");
                return;
            }

            string reiAtual = dadosRei[1];
            string[] meusFavoritos = favoritos.Split(',');

            bool deveVotarNao = meusFavoritos.Contains(reiAtual) &&
                              ObterPosicaoPersonagem(reiAtual) >= 3 &&
                              QvotosN > 0;

            string voto = deveVotarNao ? "N" : "S";
            Jogo.Votar(idJogador, senhaJogador, voto);

            if (deveVotarNao) QvotosN--;
        }

        private int ObterPosicaoPersonagem(string personagem)
        {
            string estado = Jogo.VerificarVez(idPartida);
            string[] linhas = estado.Replace("\r", "").Split('\n');

            for (int i = 1; i < linhas.Length - 1; i++)
            {
                string[] dados = linhas[i].Split(',').Select(x => x.Trim()).ToArray();
                if (dados.Length >= 2 && dados[1] == personagem)
                {
                    return Convert.ToInt32(dados[0]);
                }
            }
            return -1;
        }
    }
}

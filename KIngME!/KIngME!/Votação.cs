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
       public int qntdVotosNao;
        int idPartida;
        string senhaJogador;
        string favoritos;
        int idJogador;
        public criarVotacao(int idJogador, string senhaJogador, int qvotosN, string favoritos, int idPartida)
        {
            this.qntdVotosNao = qvotosN;
            this.idPartida = idPartida;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.favoritos = favoritos;
        }

        public void Voto()
        {
            string estadoJogo = Jogo.VerificarVez(idPartida);
            string[] linhas = estadoJogo.Split('\n');

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
            string[] meusFavoritos = favoritos.Split(',').Select(x => x.Trim()).ToArray();

            bool deveVotarNao = !meusFavoritos.Contains(reiAtual) && ObterPosicaoPersonagem(reiAtual) >= 3 && qntdVotosNao > 0;

            string voto = deveVotarNao ? "N" : "S";
            Jogo.Votar(idJogador, senhaJogador, voto);

            if (deveVotarNao)
            {
                qntdVotosNao--;
            }
        }

        private int ObterPosicaoPersonagem(string personagem)
        {
            string estado = Jogo.VerificarVez(idPartida);
            string[] linhas = estado.Split('\n');

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(',').Select(x => x.Trim()).ToArray();
                if (dados.Length >= 2 && dados[1] == personagem)
                {
                    if (int.TryParse(dados[0], out int posicao))
                    {
                        return posicao;
                    }
                    return -1;
                }
            }
            return -1;
        }
    }
}

using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace KIngME_
{
    public class votacao : fasePromocao
    {
        int QvotosN;
        string Rei;
        int idPartida;
        public votacao(int idJogador, string senhaJogador, int qvotosN, string favoritos,int idPartida) : base(idJogador,senhaJogador, favoritos)
        {
            QvotosN = qvotosN;
            this.idPartida = idPartida;
        }

        public void Voto()
        {
            string verificarRei = Jogo.VerificarVez(idPartida);
            string[] rei = verificarRei.Replace("\r", "").Split('\n');

            string[] dadosRei = rei[rei.Length - 2].Split(',');

            string[] dadosCorretos = dadosRei.Select(x => x.Trim()).ToArray();
            string[] letrasFavoritos = favoritos.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < letrasFavoritos.Length - 2; i++) 
            {
                if (QvotosN > 0)
                {
                    if (dadosCorretos[1] == letrasFavoritos[i])
                    {
                        Jogo.Votar(Convert.ToInt32(idJogador), senhaJogador, "S");                  
                        break;
                    }
                    else if (i == letrasFavoritos.Length - 3)
                    {
                        QvotosN--;
                        Jogo.Votar(Convert.ToInt32(idJogador), senhaJogador, "N");
                        QvotosN -= 1;
                        break;
                    }
                }
                else
                {
                     Jogo.Votar(Convert.ToInt32(idJogador), senhaJogador, "S");
                    break;  
                }
            }
        }
    }
}

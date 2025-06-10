using KingMeServer;
using manager;
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
        private string[] colocacao = new string[7];
        private string letra;
        public List<string> listaFavoritos = new List<string>();

        public Estrategia(int idJogador, string favoritos, string senhaJogador, string naoFavoritos, int idPartida)
        {
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.idPartida = idPartida;
            this.favoritos = favoritos ?? "";
            this.naoFavoritos = naoFavoritos ?? "";
        }

        public void AtualizarFavoritos(string favsNovos) => this.favoritos = favsNovos;
        public void AtualizarNaoFav(string Nfavs) => this.naoFavoritos = Nfavs;

        public void AlimentarLista()
        {
            string[] favoritosConvertidos = new string[7];
            char[] favoritosArray = favoritos.ToCharArray();

            for (int i = 0; i < favoritosArray.Length && i < 7; i++)
            {
                favoritosConvertidos[i] = Convert.ToString(favoritosArray[i]);
            }

            listaFavoritos.Clear();

            for (int i = 0; i < favoritosArray.Length && i < 7; i++)
            {
                if (favoritosConvertidos[i] != null)
                {
                    listaFavoritos.Add(favoritosConvertidos[i]);
                }
            }
        }
        public void NumeroJogadores()
        {
            string listaDeJogadores = Jogo.ListarJogadores(idPartida).Replace("\r", "");
            string[] lista = listaDeJogadores.Split('\n');
            
            if(lista.Length <= 2)
            {
                PromocaoNormal();
            }
            else
            {
                PromocaoAprimorada();
            }
        }

        public void PromocaoNormal()
        {
            Random r = new Random();
            string[] letrasFavoritos = favoritos.Select(c => c.ToString()).ToArray();
            int i = r.Next(0, letrasFavoritos.Length);
            Jogo.Promover(idJogador, senhaJogador, letrasFavoritos[i]);
        }

        public void Instanciar()
        {
            for (int i = 0; i < 7; i++)
            {
                colocacao[i] = null;
            }
            AlimentarLista();
        }

        public void PegarMatriz()
        {
            string[] matriz = Manager.matrizVerificarVez(idPartida);

            for (int i = 1; i < matriz.Length; i++)
            {
                string matrizDividida = matriz[i];
                string[] partes = matrizDividida.Split(',');

                if (partes.Length < 2 || string.IsNullOrEmpty(partes[0]))
                {
                    continue;
                }

                if (int.TryParse(partes[0], out int j))
                {
                    if (j >= 0 && j <= 6)
                    {
                        string letra = partes[1];
                        colocacao[j] += letra;
                    }
                }
            }
        }

        public void PromocaoAprimorada()
        {
            string[] letrasFavoritasNaPosicao = new string[4];
            string[] naoFavoritosNaPosicao = new string[4];

            Instanciar();
            PegarMatriz();

            int count = 0;
            while (count != 3)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (!string.IsNullOrEmpty(colocacao[i]) && colocacao[i].Any(letra => naoFavoritos.Contains(letra)))
                    {
                        count++;
                        var nFavs = colocacao[i].First(letra => naoFavoritos.Contains(letra.ToString()));

                        Jogo.Promover(idJogador, senhaJogador, nFavs.ToString());
                        return;
                    }
                }
            }
            for (int i = 0; i <= 5; i++)
            {
                if (!string.IsNullOrEmpty(colocacao[i]) && colocacao[i].Any(letra => favoritos.Contains(letra)))
                {
                    var letrasArray = colocacao[i].First(letra => favoritos.Contains(letra.ToString()));

                    Jogo.Promover(idJogador, senhaJogador, letrasArray.ToString());
                    return;                  
                }
            }
            for (int i = 0; i <= 5; i++)
            {
                if (!string.IsNullOrEmpty(colocacao[i]) && colocacao[i].Any(letra => naoFavoritos.Contains(letra)))
                {
                    var nFavs = colocacao[i].First(letra => naoFavoritos.Contains(letra.ToString()));

                    Jogo.Promover(idJogador, senhaJogador, nFavs.ToString());
                    return;
                }
            }
        }
    }
}

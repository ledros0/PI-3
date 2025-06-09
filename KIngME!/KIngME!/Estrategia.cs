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
        int count = 0;
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
            
            if(lista.Length < 0)
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
        //13 personagens;
        public void PegarMatriz()
        {

            string[] matriz = Manager.matrizVerificarVez(idPartida);

            for (int i = 1; i < matriz.Length - 1; i++)
            {
                string matrizDividida = matriz[i];
                string[] partes = matrizDividida.Split(',');

                letra = partes[1];
                colocacao[Convert.ToInt32(partes[0])] += letra;
            }
        }
        public void PromocaoAprimorada()
        {
            string[] letrasFavoritasNaPosicao = new string[4];
            string[] naoFavoritosNaPosicao = new string[4];

            Instanciar();
            PegarMatriz();

            if (count < 5) 
            {
                int startIndex = count < 2 ? 4 : 5; 

                for (int i = startIndex; i >= 0; i--)
                {
                    if (colocacao[i] != null && listaFavoritos.Any(letra => colocacao[i].Contains(letra)))
                    {
                        var letrasArray = colocacao[i].Where(letra => favoritos.Contains(letra)).ToArray();

                        if (letrasArray.Length > 0)
                        {
                            Jogo.Promover(idJogador, senhaJogador, letrasArray[0].ToString());
                            count++;
                            return;
                        }
                    }
                }
            }

            for (int i = 0; i <= 5; i++)
            {
                if (colocacao[i] != null && colocacao[i].Contains(naoFavoritos))
                {
                    var nFavs = colocacao[i].Where(letra => naoFavoritos.Contains(letra)).ToArray();

                    if (nFavs.Length > 0)
                    {
                        Jogo.Promover(idJogador, senhaJogador, nFavs[0].ToString());
                        return;
                    }
                }
            }
        }
    }
}
using System;
using BlbliotecaDeJogos.Classes;
using System.Collections.Generic;

namespace BlbliotecaDeJogos.Classes
{

    static class GameMenu
    {
        // Should use HashSet or some structure that has UID to avoid duplicates
        static private List<Jogo> listaJogos = new List<Jogo>();

        static public Jogo buildGame() {
            var nome = "";
            while (String.IsNullOrEmpty(nome))
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }

            Console.Write("Lançamento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();
            Console.Write("Max. de Jogadores: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());

            Jogo jogo = new Jogo(nome, ano, genero, max, metacritic);
            return jogo;
        }

        static public void AdicionarJogo()
        {
            Console.WriteLine("ADICIONAR JOGO\n");

            try
            {
                var game = GameMenu.buildGame();
                GameMenu.listaJogos.Add(game);
            }
            catch
            {
                Console.WriteLine("Erro");
            }
        }

        static public void Listar()
        {
            Console.WriteLine("JOGOS ADICIONADOS");
            Console.WriteLine(Environment.NewLine);

            var arrayListaJogos = GameMenu.listaJogos.ConvertAll<string>(
                (Jogo jogo) => jogo.toString()
            );
            var list = String.Join("\n\n-------------\n\n", arrayListaJogos);
            Console.WriteLine(list);
        }

        static public void Deletar()
        {
            Console.WriteLine("Nome do jogo para ser deletado: ");
            var nome = Console.ReadLine();
            Jogo foundGame = GameMenu.listaJogos.Find(jogo => jogo.getTitulo() == nome);
            GameMenu.listaJogos.Remove(foundGame);

            Console.Clear();
        }
    
        static public void Modificar() {
            Console.WriteLine("Nome do jogo para ser modificado: ");
            var nome = Console.ReadLine();
            int foundIndex = GameMenu.listaJogos.FindIndex(jogo => jogo.getTitulo() == nome);

            try {
                if (foundIndex != -1) GameMenu.listaJogos[foundIndex] = buildGame();
            } catch {
                Console.WriteLine("Erro");
            }
        }
    }

}
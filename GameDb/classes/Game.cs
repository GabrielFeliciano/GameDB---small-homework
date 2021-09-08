using System;
using System.Collections.Generic;
using System.Text;

namespace BlbliotecaDeJogos.Classes
{
    class Jogo
    {
        private string titulo;
        private int ano;
        private string genero;
        private int maxJogadores;
        private int metaCritic;

        public Jogo (string titulo, int ano, string genero, int maxJogadores, int metaCritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metaCritic = metaCritic;
        }

        public string toString() {
            return String.Join(
                Environment.NewLine,

                $"Título: {this.titulo}",
                $"Lançamento: {this.ano}",
                $"Gênero: {this.genero}",
                $"Max. de Jogadores: {this.maxJogadores}",
                $"Metacritic: {this.metaCritic}"
            );
        }

        //Setters (could use c# setters)
        public void setTitulo (string titulo)
        {
            this.titulo = titulo;
        }

        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public void setMaxJogadores (int maxJogadores)
        {
            this.maxJogadores = maxJogadores;
        }

        public void setMetaCritic (int metaCritic)
        {
            this.metaCritic = metaCritic;
        }

        //Getters (could use c# getters)
        public string getTitulo ()
        {
            return this.titulo;
        }

        public int getAno ()
        {
            return this.ano;
        }
    }
}
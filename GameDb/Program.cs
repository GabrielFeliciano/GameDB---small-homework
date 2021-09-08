﻿using System;
using BlbliotecaDeJogos.Classes;
using System.Collections.Generic;

/* Nota
Não sei pq mas o console n limpa depois que os metodos dos game menu rodam...
*/

namespace BlbliotecaDeJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine(
                    String.Join(
                        Environment.NewLine,

                        "##### - BIBLIOTECA DE JOGOS - #####",
                        "",
                        "1- Adicionar um Jogo",
                        "2- Listar os Jogos",
                        "3- Atualizar um Jogo",
                        "4- Deletar um Jogo",
                        "5- Clear"
                    )
                );
                Console.Write(" > ");

                var opcao = Convert.ToInt16(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        GameMenu.AdicionarJogo();
                        break;

                    case 2:
                        GameMenu.Listar();
                        break;

                    case 3:
                        GameMenu.Modificar();
                        break;

                    case 4:
                        GameMenu.Deletar();
                        break;

                    case 5:
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.Beep();
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadLine();
                Console.Clear();
            }            
        }
    }
}
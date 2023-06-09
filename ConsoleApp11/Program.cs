﻿using System.Runtime.CompilerServices;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] vect = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados? ");
            int q = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= q; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + " : " + vect[i]);
                }
            }
        }
    }
}
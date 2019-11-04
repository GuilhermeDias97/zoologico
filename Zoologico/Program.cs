using System;
using System.Collections.Generic;
using Zoologico.Entidade;

namespace Zoologico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Console.WriteLine("===========Cadastro do ZooLogico==================");
            zoo.Cadastro();


            do {
                Console.Clear();
                Console.WriteLine($"============ZooLogico {zoo.Nome} =================");
                Console.WriteLine("1 - Cadastrar Animal");
                Console.WriteLine("2 - Cadastrar Tratador");
                Console.WriteLine("3 - Exibir dados Zoologico");
                Console.WriteLine("4 - Exibir dados Animais");
                Console.WriteLine("5 - Exibir Tratador");
                Console.WriteLine("9 - Sair");
                Console.WriteLine("Escolha uma opção");

                int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao) {
                    case 1:
                        Animal animal = new Animal(zoo.Tratadores);
                        animal.Cadastro();
                        if (!string.IsNullOrWhiteSpace(animal.Nome))//Só vai adicionar na lista quando um animal estiver com nome
                            zoo.CadastraAnimail(animal);
                        break;
                    case 2:
                        Tratador tratador = new Tratador();
                        tratador.Cadastro();
                        zoo.Tratadores.Add(tratador);
                        break;
                    case 3:
                        Console.WriteLine(zoo);
                        Console.WriteLine("Aperte enter para voltar para o menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 9:
                        Console.WriteLine("Volte sempre");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);

        }

    }
}

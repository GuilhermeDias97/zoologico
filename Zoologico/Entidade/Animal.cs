using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico.Entidade
{
    public class Animal : Base 
    {
        private readonly List<Tratador> _tratadors;

        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Especie { get; set; }
        public double Peso { get; set; }
        public Tratador Tratador { get; set; }

        
        public Animal(List<Tratador> tratadors)
        {
            _tratadors = tratadors;
        }

        public override void Cadastro()
        {
            

            Console.Clear();
            Console.WriteLine("====================Cadastro do Animal==============");

            //Validar se existe tratador no sistema
            //Para cadastrar um animal deve existir pelo menos 1 trator
            if (_tratadors.Count == 0) {
                Console.WriteLine("Não existe tratador, cadastre pelo menos 1");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Lista de tratadores");
            _tratadors.ForEach(t => {
                Console.WriteLine(t);
            });

            Tratador tratador = _tratadors.Find(t => t.Id == int.Parse(Console.ReadLine()));
            Tratador = tratador;

            Console.Write("Digite o Nome:");
            Nome = Console.ReadLine();

            Console.Write($"Digite a especie do {Nome}: ");            
            Especie = Console.ReadLine();

            Console.Write($"Digite a Peso do {Nome}: ");
            Peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a Idade do {Nome}: ");
            Idade = int.Parse(Console.ReadLine());

            Console.Write($"Digite o Sexo do {Nome}");
            Sexo = Console.ReadLine();
            Console.WriteLine("Cadastro Finalizado");
            Console.ReadKey();

        }

    }
}

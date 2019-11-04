using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico.Entidade
{
    public class Tratador : Base
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public override void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("====================Cadastro do Tratador==============");
            Console.Write("Digite o Nome:");
            Nome = Console.ReadLine();
            Console.Write($"Digite a idade do {Nome}: ");
            Idade = int.Parse(Console.ReadLine());
            Console.Write($"Digite o Sexo do {Nome}");
            Sexo = Console.ReadLine();
            Console.WriteLine("Cadastro Finalizado");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return $"Id:{Id} Nome:{Nome}";
        }

    }
}

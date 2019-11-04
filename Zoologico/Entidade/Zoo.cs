using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico.Entidade
{
    public class Zoo : Base
    {
        private string Endereco { get; set; }
        public string Nome { get; set; }
        private List<Animal> Animais { get; set; } = new List<Animal>();

        public List<Tratador> Tratadores { get; set; } = new List<Tratador>();

        public override void Cadastro()
        {
            Console.Write("Digite o Endereço do zoologico:");
            Endereco =  Console.ReadLine();

            Console.Write("Digite o Nome: ");
            Nome = Console.ReadLine();            
        }
        
        public void CadastraAnimail(Animal animal)
        {
            Animais.Add(animal);
        }

        public override string ToString()
        {
            return $"Id: {Id} \nCadastro{DataCadastro.ToString("dd/MM/yyyy")} \nNome: {Nome} \nEndereço: {Endereco}";
        }
    }
}

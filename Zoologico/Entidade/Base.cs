using System;
using System.Collections.Generic;
using System.Text;

namespace Zoologico.Entidade
{
   public abstract class Base
    {
        public int Id { get; private set; } = new Random().Next(1,500);
        protected DateTime DataCadastro { get; set; } = DateTime.Now;

        public abstract void Cadastro();
        
        
    }
}

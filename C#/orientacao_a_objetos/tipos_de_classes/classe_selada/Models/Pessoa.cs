using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_selada.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
        }
    }
}
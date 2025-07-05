using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Models
{
    public class Professor : Pessoa //Só é possível herdar uma classe
    {
        public decimal Salario { get; set; }
    }
}
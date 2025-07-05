using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Models
{
    public class Aluno : Pessoa //Só é possível herdar uma classe
    {
        public double Nota { get; set; }
    }
}
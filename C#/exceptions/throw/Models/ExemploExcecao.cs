using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exception.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {   
            //Exemplo de throw
            throw new Exception("Ocorreu uma exceção");
        }
    }
}
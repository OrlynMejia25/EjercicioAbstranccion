using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstranccion
{
    public abstract class Matematicas
    {
        public abstract double Potencia();
        public abstract double Raiz();
        public abstract double Logaritmo();
        public abstract double Seno();

        public void Imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}

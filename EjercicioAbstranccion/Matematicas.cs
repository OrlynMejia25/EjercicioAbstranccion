using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstranccion
{
    public abstract class Matematicas
    {
        public abstract double Suma();
        public abstract double Resta();
        public abstract double Multiplicacion();
        public abstract double Division();

        public void Imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}

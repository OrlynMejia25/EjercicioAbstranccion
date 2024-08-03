using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstranccion
{
    internal class OperacionesAbstractas : Matematicas
    {
        private double Numero1 { get; set; }
        private double Numero2 { get; set; }

        public OperacionesAbstractas (double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public override double Potencia()
        {
            return Math.Pow(Numero1, Numero2);
        }

        public override double Raiz()
        {
            return Math.Pow(Numero1, 1.0 / Numero2);
        }

        public override double Logaritmo()
        {
            return Math.Log(Numero1, Numero2);
        }

        public override double Seno()
        {
            return Math.Sin(Numero1);
        }

      
    }
}

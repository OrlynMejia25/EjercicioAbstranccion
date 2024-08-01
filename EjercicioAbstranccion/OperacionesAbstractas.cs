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

        public override double Suma()
        {
            return Numero1 + Numero2;
        }

        public override double Resta()
        {
            return Numero1 - Numero2;
        }

        public override double Multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public override double Division()
        {
            return Numero1 / Numero2;
        }
    }
}

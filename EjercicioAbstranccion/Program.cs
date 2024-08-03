using EjercicioAbstranccion;

Console.WriteLine("Ingrese el primer número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

OperacionesAbstractas opera = new OperacionesAbstractas(numero1,numero2);

double potencia = opera.Potencia();
double raiz = opera.Raiz();
double logaritmo = opera.Logaritmo();
double seno = opera.Seno();

opera.Imprimir($"Potencia: {potencia}");
opera.Imprimir($"Raiz: {raiz}");
opera.Imprimir($"Logaritmo: {logaritmo}");
opera.Imprimir($"Seno: {seno}");
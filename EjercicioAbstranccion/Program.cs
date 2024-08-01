using EjercicioAbstranccion;

Console.WriteLine("Ingrese el primer número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

OperacionesAbstractas opera = new OperacionesAbstractas(numero1,numero2);

double resta = opera.Resta();
double suma = opera.Suma();
double division = opera.Division();
double multiplicacion = opera.Multiplicacion();

opera.Imprimir($"Resta: {resta}");
opera.Imprimir($"Suma: {suma}");
opera.Imprimir($"Multiplicacion: {multiplicacion}");
opera.Imprimir($"Division: {division}");
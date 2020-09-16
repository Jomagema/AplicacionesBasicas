using System;

namespace AplicacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
              int opcion;
            do {
                opcion = 0;
                Console.Clear();
                Console.WriteLine("Bienvenido a Aplicaciones Básicas");
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Resta Positiva");
                Console.WriteLine("2. Cifras Num");
                Console.WriteLine("3. Fibonacci");
                Console.WriteLine("4. Sumar Cifras");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        int n1 = 0;
                        int n2 = 0;
                        Console.WriteLine("Introduzca el primer número");
                        n1 = SolicitarEntero(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo número");
                        n2 = SolicitarEntero(Console.ReadLine());
                        Console.WriteLine("El resultado es " + (n1 - n2));
                        Console.ReadKey();
                        break;
                    case 2:
                        int n;
                        Console.WriteLine("Introduzca el número");
                        n = SolicitarEntero(Console.ReadLine());
                        Console.WriteLine("El número tiene "+CuentaCifras(n)+" cifras.");
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Introduce el número");
                        Console.WriteLine("La suma es " +SumaCifras(int.Parse(Console.ReadLine())));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Hasta la próxima!!");
                        break;
                    default:
                        Console.WriteLine("No es una opción valida");
                        break;
                }
            } while (opcion != 5);
            
        }

        static int SolicitarEntero(String texto)
        {
            bool valido;
            int num;

            do
            {
                valido = int.TryParse(texto, out num);
                if (!valido)
                {
                    Console.WriteLine("Numero no valido");
                }
            } while (!valido);
            return num;
        }

        static int CuentaCifras(int n)
        {
            int i;
            for (i = 1; n > 10; i++)
            {
                n = n / 10;
            }
            return i;
        }

        static int Fibonacci(int n)
        {
            if ((n == 0)||(n == 1))
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n-2);
            }
        }

        static int SumaCifras(int n)
        {
            int suma = 0;
            int i, resto;
            for (i = 1; n > 0; i++)
            {
                resto = n % 10;
                n = n / 10;
                suma = suma + resto;

            }
            return suma;
        }
    }
}

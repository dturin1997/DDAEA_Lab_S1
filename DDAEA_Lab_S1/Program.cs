using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDAEA_Lab_S1
{
    internal class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Función para calcular la resta de 2 números enteros
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Función para calcular la multiplicacion de 2 números enteros
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la division de 2 números enteros
        static int Dividir(int a, int b)
        {
            return a / b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los diez primeros numeros primos");
                Console.WriteLine("[7] Convertir Farenheit a Celsius");
                Console.WriteLine("[8] Convertir Celsius a Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Resta de {0} y {1} es {2}", a1, b1, Resta(a1, b1));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", a2, b2, Multiplicar(a2, b2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", a3, b3, Dividir(a3, b3));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        int i = 1;
                        int limit = 0;
                        while (limit <= 10) {
                            int n = 1;
                            int cont = 0;
                            while (n <= i)
                            {
                                
                                if (i % n == 0)
                                {
                                    cont = cont + 1;

                                }
                            
                                n++;
                            }
                            if (cont <= 1) 
                            {
                                limit = limit + 1;
                            }
                            else if (cont <= 2)
                            {
                                Console.WriteLine(i);
                                limit = limit + 1;
                            }
                            
                            i++;
                        }
                        
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese los grados farenheit");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(5*(f-32)/9);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese los grados celsius");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(9 * c / 5 + 32);
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}

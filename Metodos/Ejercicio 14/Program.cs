using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Círculo");
            Console.WriteLine("2- Triángulo");
            Console.WriteLine("3- Cuadrado");
            Console.WriteLine("¿De qué figura quieres calcular el área (1, 2 o 3)?");

            int numeroFigura = Convert.ToInt32(Console.ReadLine());

            if (numeroFigura==1)
            {
                Console.WriteLine("Introduce el radio del círculo:");
                int radioCirculo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El área del círculo es: "+AreaCirculo(radioCirculo));
            }

            else if (numeroFigura == 2)
            {
                Console.WriteLine("Introduce la base del triángulo:");
                int baseTriangulo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la altura del triángulo:");
                int alturaTriangulo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El área del triángulo es "+AreaTriangulo(baseTriangulo,alturaTriangulo));
            }

            else if (numeroFigura == 3)
            {
                Console.WriteLine("Introduce la longitud del primer lado del cuadrado:");
                int lado1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la longitud del segundo lado del cuadrado:");
                int lado2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El área del cuadrado es: "+AreaCuadrado(lado1, lado2));

            }


        }

        public static double AreaCirculo (double radio)

        {
            double resultado;

            resultado = (Math.Pow(radio,2) * Math.PI);

            return resultado;
        }


        public static double AreaTriangulo (double bas, double altura)

        {
            double resultado;

            resultado = (bas*altura)/2;

            return resultado;

        }

        public static double AreaCuadrado (double lado1, double lado2)

        {
            double resultado;

            resultado = (lado1 * lado2);

            return resultado;

        }



    }
}

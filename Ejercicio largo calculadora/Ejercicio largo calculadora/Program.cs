using System;

namespace Ejercicio_largo_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //PRIMERA PARTE

            //int numOperacion;

            //do
            //{

            //    Console.WriteLine("*****************");
            //    Console.WriteLine("   Calculadora");
            //    Console.WriteLine("*****************");

            //    Console.WriteLine("1. Suma");
            //    Console.WriteLine("2. Resta");
            //    Console.WriteLine("3. Multiplicación");
            //    Console.WriteLine("4. Potencia");
            //    Console.WriteLine("5. División");
            //    Console.WriteLine("6. Raíz");
            //    Console.WriteLine("7. Salir" + "\n");


            //    Console.WriteLine("Introduce la opción deseada:");
            //    numOperacion = Convert.ToInt32(Console.ReadLine());
            //    double numero1;
            //    double numero2;

            //    switch (numOperacion)
            //    {
            //        case 1:
            //            Console.WriteLine("Introduce el primer número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Introduce el segundo número:");
            //            numero2 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Operación seleccionada: Suma");
            //            Console.WriteLine(numero1 + "+" + numero2 + "=" + (numero1 + numero2));
            //            break;

            //        case 2:

            //            Console.WriteLine("Introduce el primer número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Introduce el segundo número:");
            //            numero2 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Operación seleccionada: Resta");
            //            Console.WriteLine(numero1 + "-" + numero2 + "=" + (numero1 - numero2));
            //            break;


            //        case 3:

            //            Console.WriteLine("Introduce el primer número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Introduce el segundo número:");
            //            numero2 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Operación seleccionada: Multiplicación");
            //            Console.WriteLine(numero1 + "*" + numero2 + "=" + (numero1 * numero2));
            //            break;


            //        case 4:

            //            Console.WriteLine("Introduce el primer número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Introduce el segundo número:");
            //            numero2 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Operación seleccionada: Potencia");
            //            Console.WriteLine(numero1 + " elevado a " + numero2 + " = " + (Math.Pow(numero1, numero2)));
            //            break;

            //        case 5:

            //            Console.WriteLine("Introduce el primer número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Introduce el segundo número:");
            //            numero2 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Operación seleccionada: División");
            //            Console.WriteLine(numero1 + "/" + numero2 + "=" + (numero1 / numero2));
            //            break;


            //        case 6:

            //            Console.WriteLine("Introduce el número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());

            //            Console.WriteLine("Operación seleccionada: Raíz");
            //            Console.WriteLine("|" + numero1 + "=" + (Math.Sqrt(numero1)));
            //            break;

            //        case 7:
            //            Console.WriteLine("Hasta luego!");
            //            break;


            //        default:
            //            Console.WriteLine("Opción " + numOperacion + " no disponible, vuelva a intentarlo");
            //            break;
            //    }


            //} while (numOperacion != 7);


            //SEGUNDA PARTE



            bool salir = false;
            do
            {
                Console.WriteLine("Introduce una operación matemática:");
                string operacion = Console.ReadLine(); //300+200
                string simbolo = "";
                int posicionSimbolo;


                if (operacion.ToLower() == "q")
                {
                    salir = true;
                }

                else
                {


                    for (int i = 0; i < operacion.Length; i++)
                    {

                        if (!Char.IsDigit(Convert.ToChar(operacion.Substring(i, 1))))
                        {
                            simbolo = operacion.Substring(i, 1);
                        }

                    }

                    posicionSimbolo = operacion.IndexOf(simbolo);
                    double numero1 = Convert.ToDouble(operacion.Substring(0, posicionSimbolo));
                    double numero2 = Convert.ToDouble(operacion.Substring(posicionSimbolo + 1));
                    double resultado;
                    switch (simbolo)
                    {

                        case "+":
                            resultado = numero1 + numero2;
                            Console.WriteLine(resultado);
                            break;

                        case "-":
                            resultado = numero1 - numero2;
                            Console.WriteLine(resultado);
                            break;

                        case "*":
                            resultado = numero1 * numero2;
                            Console.WriteLine(resultado);
                            break;

                        case "/":
                            resultado = numero1 / numero2;
                            Console.WriteLine(resultado);
                            break;

                        default:
                            Console.WriteLine("Debes introducir una operación matemática: +, -, * o /.");
                            break;
                    }


                }

            } while (!salir);

        }
    }
}

            


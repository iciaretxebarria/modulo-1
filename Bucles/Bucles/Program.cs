using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1

            //int numero = 10;

            //while (numero <= 20)
            //{
            //    Console.WriteLine(numero++);
            //    Console.WriteLine();
            //}


            //Ejercicio 2

            //int numero = 20;

            //while (numero >= 10)
            //{
            //    Console.WriteLine(numero);
            //    Console.WriteLine();
            //    numero--;
            //}

            //for (int i = 20; i >= 10; i--)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();

            //}



            //Ejercicio 3

            //double suma = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Introduce un valor:");
            //    double valor = Convert.ToDouble(Console.ReadLine());
            //    suma = suma + valor;
            //}

            //Console.WriteLine("La media de tus números es: " + (suma / 10));


            //Ejercicio 4


            //int valor;
            //int suma = 0;

            //do
            //{
            //    Console.WriteLine("Introduce un valor:");
            //    valor = Convert.ToInt32(Console.ReadLine());

            //    if (valor < 0)
            //    {
            //        Console.WriteLine("Se ignoran los valores negativos");
            //    }

            //    else if (valor > 0)

            //    {
            //        suma += valor;
            //    }


            //} while (valor != 0);

            //Console.WriteLine("La suma de tus números es " + suma);



            //Ejercicio 5

            //Console.WriteLine("Introduce P para valores pares o I para valores impares");
            //string letra = (Console.ReadLine().ToLower());

            //while (letra != "p" && letra != "i")
            //{
            //    Console.WriteLine("El valor no es correcto. Introduce P o I:");
            //    letra = (Console.ReadLine().ToLower());
            //}


            //if (letra == "p")
            //{
            //    for (int i = 2; i <= 101; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //else if (letra == "i")
            //{
            //    for (int i = 1; i < 101; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}




            //Ejercicio 6

            //Console.WriteLine("¿Qué edad tienes?");
            //int edad = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < edad; i++)
            //{

            //    Console.WriteLine("Feliz cumpleaños");
            //}


            //Ejercicio 7

            //Console.WriteLine("Introduce un número");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string asterisco = "*";


            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(asterisco);
            //    asterisco = asterisco + "*";
            //}



            //Ejercicio 8

            //for (int i = 1; i < 13; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i+"   "+Math.Pow(i, 2));

            //    }

            //    else if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i+"   "+Math.Pow(i, 3));

            //    }
            //}


            //Ejercicio 9

            //int numero = 1;
            //for (int i = 1; i < 11; i++)

            //{
            //    Console.WriteLine(numero);
            //    numero = numero + 5;

            //}


            //Ejercicio 10

            //Console.WriteLine("Introduce un número:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int suma = 0;

            //for (int i = 1; i <= num; i++)
            //{

            //    suma += i;

            //}

            //Console.WriteLine(suma);




            //Ejercicio 11

            //int num;

            //do
            //{
            //    Console.WriteLine("Introduce un número:");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    int suma = 0;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        suma += i;
            //    }
            //    Console.WriteLine(suma);


            //} while (num != 0);


            //Ejercicio 12 (profesora)


            bool correcto = false;
            bool numeroEncontrado = false;

            do
            {

                Console.WriteLine("Introduce una contraseña:");
                string pass = (Console.ReadLine());


                if (pass.Length < 8)
                {
                    Console.WriteLine("La contraseña debe tener como mínimo 8 caracteres.");

                }

                else
                {

                    for (int i = 0; i < pass.Length; i++)
                    {
                        if (char.IsDigit(Convert.ToChar(pass.Substring(i, 1))))
                        {
                            numeroEncontrado = true;
                        }
                    }

                    if (numeroEncontrado)
                    {

                        if (char.IsUpper(Convert.ToChar(pass.Substring(0,1))))
                        {
                            correcto = true;
                        }
                        else
                        {
                            Console.WriteLine("La primera letra debe ser mayúscula.");
                        }


                    }
                    else
                    {
                        Console.WriteLine("La contraseña debe tener como mínimo 1 número.");
                    }

                }

            } while (correcto==false);

            Console.WriteLine("Contraseña correcta.");



            //Ejercicio 13

            //Console.WriteLine("Introduce un número:");
            //string numero = (Console.ReadLine());

            //do
            //{




            //} while (numero!="0");




















        }
    }
}

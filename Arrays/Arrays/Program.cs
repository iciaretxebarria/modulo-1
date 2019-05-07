using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1

            //int[] numeros = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //Ejercicio 2

            //string[] palabras = new string[3];

            //for (int i = 0; i < palabras.Length; i++)
            //{
            //    Console.WriteLine("Introduce una palabra:");
            //    palabras[i] = Console.ReadLine();
            //}

            //Console.WriteLine(palabras[1]);
            //Console.WriteLine(palabras[2]);
            //Console.WriteLine(palabras[0]);



            //Ejercicio 3
            //int[] numeros = new int[10];
            //int resta = 20;

            //for (int i = 0; i < numeros.Length; i++)
            //{

            //    numeros[i] = resta;
            //    resta--;
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}


            //Ejercicio 4

            //int[] numeros = new int[3];


            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Introduce un valor:");
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}




            //Ejercicio 5

            //int[] numeros = new int[3];

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Introduce un valor:");
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //int smallestNumber = numeros[0];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (numeros[i] < smallestNumber)
            //    {
            //        smallestNumber = numeros[i];
            //    }

            //}

            //Console.WriteLine("The smallest number is " + smallestNumber);



            //Ejercicio 6

            //string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

            //Console.WriteLine("Introduce un número:");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //if (numero>=1&&numero<=12)
            //{
            //Console.WriteLine(meses[numero - 1]);

            //}

            //else
            //{
            //Console.WriteLine("El número introducido no corresponde a ningún mes.");

            //}



            //Ejercicio 7

            //int[] numeros = new int[10];
            //double suma = 0;


            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Introduce un valor:");
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    suma += numeros[i];
            //}


            //Console.WriteLine("La media de los números es: " + suma/numeros.Length);



            //Ejercicio 8

            //int[] numeros = new int[11];
            //int numero;

            //do
            //{
            //    Console.WriteLine("Introduce un número entre 0 y 10:");
            //    numero = Convert.ToInt32(Console.ReadLine());

            //    if (numero >= 0 && numero < numeros.Length)

            //    {
            //        numeros[numero]++;
            //    }



            //    if (numero < 0)

            //    {
            //        int posicion = 0;
            //        for (int i = 0; i < numeros.Length; i++)
            //        {
            //            Console.WriteLine(posicion + "\t" + numeros[i]);
            //            posicion++;
            //        }


            //    }

            //    if (numero > 10)
            //    {
            //        Console.WriteLine("El número es incorrecto.");

            //    }


            //} while ( numero >= 0);


            //Ejercicio 9


            //int[] numeros = new int[10];

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = 1;
            //}

            //int numero;
            //do
            //{
            //    Console.WriteLine("Introduce un número entre 0 y 9:");
            //    numero = Convert.ToInt32(Console.ReadLine());

            //    if (numero>=0&&numero<=9)
            //    {
            //        int valorNuevo = numeros[numero] * 2;
            //        Console.WriteLine(numeros[numero] + "x2=" + valorNuevo);
            //        numeros[numero] *= 2;
            //    }
            //    else if (numero>10)
            //    {
            //        Console.WriteLine("Número incorrecto. Introduce un número entre 0 y 9:");
            //    }

            //} while (numero>=0);




            //Ejercicio 10

            int[] edades = new int[3];
            int edad;
            int suma = 0;


            for (int i = 0; i < edades.Length; i++)
            {
                bool edadCorrecta = false;
                do
                {
                    Console.WriteLine("Introduce una edad (entre 18 y 35 años):");
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad < 18 || edad > 35)
                    {
                        Console.WriteLine("Número incorrecto. Introduce edades entre 18 y 35 años");
                    }
                    else
                    {
                        edadCorrecta = true;
                    }

                } while (!edadCorrecta);

                edades[i] = edad;

            }

            for (int i = 0; i < edades.Length; i++)
            {
                suma += edades[i];
            }

            Console.WriteLine("La media de las edades es " + suma / edades.Length);


            //LEVEL PRO

            //Ejercicio 11

            //int[] tabla = new int[20];
            //Random aleatorio = new Random();
            //int sumaPares = 0;
            //int productoImpares = 0;

            //for (int i = 0; i < tabla.Length; i++)
            //{
            //    tabla[i] = aleatorio.Next(1, 101);
            //}

            //for (int i = 0; i < tabla.Length; i++)
            //{
            //    if (tabla[i] % 2 == 0)
            //    {
            //        sumaPares += tabla[i];

            //    }

            //    else
            //    {
            //        productoImpares *= tabla[i];
            //    }
            //}

            //Console.WriteLine("La suma de los valores pares es " + sumaPares);
            //Console.WriteLine("El producto de los valores impares es " + productoImpares);


            //Ejercicio 12

            //string[] palabras = new string[5];

            //for (int i = 0; i < palabras.Length; i++)
            //{
            //    Console.WriteLine("Introduce una palabra:");
            //    palabras[i] = Console.ReadLine();

            //}

            //Array.Sort(palabras);

            //for (int i = 0; i < palabras.Length; i++)
            //{
            //    Console.WriteLine(palabras[i]);
            //}


            //Ejercicio 13

            //int[] tabla = new int[5];
            //Random aleatorio = new Random();

            //for (int i = 0; i < tabla.Length; i++)
            //{
            //    tabla[i] = aleatorio.Next(1, 10);

            //}

         


            //for (int i = 0; i < tabla.Length; i++)
            //{
            //    Console.WriteLine(tabla[i]);
            //}


        










        }
    }

}



using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            do
            {
                Console.WriteLine("Introduce un año:");
                year = Convert.ToInt32(Console.ReadLine());

                if (year!=0&&Bisiesto(year) == true)
                {

                    Console.WriteLine("El año " + year + " es bisiesto");
                }

                else if (year != 0 && Bisiesto(year) == false)
                {
                    Console.WriteLine("El año " + year + " NO es bisiesto");

                }

            } while (year!=0);
            
        }

        //¿No es mejor usar un while?Después de pedirle, mientras el valor sea distinto a cero, se repite. 

        public static bool Bisiesto(int numero)

        {
            if ((numero%4==0)&&(numero%100!=0||numero%400==0))
            {
                return true;
            }

            else
            {
                return false;
            }
             
        }
    }
}

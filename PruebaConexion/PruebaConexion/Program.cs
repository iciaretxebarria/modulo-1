using System;
using System.Data.SqlClient;

namespace PruebaConexion
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MGL0RVRN\\SQLEXPRESS;Initial Catalog=VARIOS;Integrated Security=True");
            //string query = "SELECT APELLIDO, OFICIO FROM EMPLE WHERE DEPT_NO = 20";

            //connection.Open();
            //SqlCommand comando = new SqlCommand(query,connection);

            //SqlDataReader registros = comando.ExecuteReader();

            //while (registros.Read())
            //{
            //    Console.WriteLine(registros[0].ToString() + " y el oficio es: " + registros[1].ToString());
            //}        
            //connection.Close();

            //1a parte

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MGL0RVRN\\SQLEXPRESS;" +
            //    "Initial Catalog=VARIOS;" +
            //    "Integrated Security=True");

            //Console.WriteLine("Introduce tu apellido:");
            //string apellido = Console.ReadLine();

            //Console.WriteLine("Introduce tu oficio:");
            //string oficio = Console.ReadLine();

            //Console.WriteLine("Introduce tu número de director:");
            //int dir = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Introduce tu salario:");
            //int salario = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Introduce tu comisión:");
            //int comision = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Introduce tu número de departamento (10, 20 o 30:");
            //int dep = Convert.ToInt32(Console.ReadLine());


            //string query = "INSERT INTO EMPLE VALUES " +
            //    "(7000,'" + apellido + "','" + oficio + "'," + dir + ",GETDATE()," + 
            //    salario + "," + comision + "," + dep + ")";

            //SqlCommand comando = new SqlCommand(query, connection);

            //connection.Open();

            //comando.ExecuteNonQuery();



            //2a parte

            //connection.Close();

            //Console.WriteLine("¿Qué salario quieres ganar");
            //int salario = Convert.ToInt32(Console.ReadLine());


            //string query = "UPDATE EMPLE SET SALARIO = '" + salario + "' WHERE EMP_NO = 7000";
            //SqlCommand comando = new SqlCommand(query, connection);

            //connection.Open();
            //comando.ExecuteNonQuery();
            //connection.Close();


            //3a parte

            string query2 = "SELECT* FROM EMPLE WHERE EMP_NO=7000";
            SqlCommand comando = new SqlCommand(query2, connection);

            connection.Open();
            SqlDataReader registros = comando.ExecuteReader();
            registros.Read();
            Console.WriteLine(registros[0].ToString());
            Console.WriteLine(registros[1].ToString());
            Console.WriteLine(registros[2].ToString());
            Console.WriteLine(registros[3].ToString());
            Console.WriteLine(registros[4].ToString());
            Console.WriteLine(registros[5].ToString());
            Console.WriteLine(registros[6].ToString());
            Console.WriteLine(registros[7].ToString());

            connection.Close();



















        }
    }
}

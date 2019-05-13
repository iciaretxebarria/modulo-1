using System;
using System.Data.SqlClient;

namespace PruebaConexion
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MGL0RVRN\\SQLEXPRESS;Initial Catalog=VARIOS;Integrated Security=True");
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

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MGL0RVRN\\SQLEXPRESS;" +
                "Initial Catalog=VARIOS;" +
                "Integrated Security=True");
            Console.WriteLine("Introduce tu apellido:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Introduce tu oficio:");
            string oficio = Console.ReadLine();

            Console.WriteLine("Introduce tu número de director:");
            int dir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce tu salario:");
            int salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce tu comisión:");
            int comision = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce tu número de departamento (10, 20 o 30:");
            int dep = Convert.ToInt32(Console.ReadLine());


            string query = "INSERT INTO EMPLE (EMP_NO, APELLIDO, OFICIO, DIR, FECHA_ALT, SALARIO, COMISION, DEPT_NO) " +
                "VALUES (7000,'" + apellido + "','" + oficio + "'," + dir + ",GETDATE()," + salario + "," + comision + "," + dep + ")";


            connection.Open();

            SqlCommand comando = new SqlCommand(query, connection);

            comando.ExecuteNonQuery();

            connection.Close();



            //2a parte

            Console.WriteLine("¿Qué salario quieres ganar");
            salario = Convert.ToInt32(Console.ReadLine());


            query = "UPDATE EMPLE SET SALARIO = '"+salario+"' WHERE EMP_NO = 7000";

            comando.ExecuteNonQuery


















        }
    }
}

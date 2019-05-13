using System;
using System.Data.SqlClient;

namespace Hotel
{
    class Program
    {

        static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MGL0RVRN\\SQLEXPRESS;" +
                "Initial Catalog=Hotel;" +
                "Integrated Security=True");

        static void Main(string[] args)
        {
            Console.WriteLine("1. Registrar cliente");
            Console.WriteLine("2. Editar cliente");
            Console.WriteLine("3. Check in");
            Console.WriteLine("4. Check out");
            Console.WriteLine("Selecciona la opción deseada");

            int numeroOperacion = Convert.ToInt32(Console.ReadLine());

            switch (numeroOperacion)
            {
                case 1:
                    RegistrarCliente();
                    break;

                case 2:
                    EditarCliente();
                    break;

                case 3:



                default:
                    Console.WriteLine("");
                    break;
            }



        }
        public static void RegistrarCliente()
        {
            Console.WriteLine("Introduce el nombre del cliente:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce el apellido del cliente:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Introduce el DNI del cliente:");
            string DNI = Console.ReadLine();

            string query = "INSERT INTO Clientes VALUES ('" + nombre + "','" + apellido + "','" + DNI + "')";

            SqlCommand comando = new SqlCommand(query, connection);
            connection.Open();
            comando.ExecuteNonQuery();
            Console.WriteLine("Datos insertados");
            connection.Close();
        }

        public static void EditarCliente()

        {
            bool encontrado = false;
            do

            {
                Console.WriteLine("Introduce el DNI:");
                string DNI = Console.ReadLine();

                string query = "select * from Clientes WHERE DNI='" + DNI + "'";
                SqlCommand comando = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader registros = comando.ExecuteReader();
                

                if (registros.Read())

                {
                    encontrado = true;
                    connection.Close();
                    connection.Open();
                    Console.WriteLine("Introduce el nombre nuevo:");
                    string nuevoNombre = Console.ReadLine();

                    Console.WriteLine("Introduce el apellido nuevo:");
                    string nuevoApellido = Console.ReadLine();

                   string queryUpdate = "UPDATE Clientes " +
                        "SET Nombre='" + nuevoNombre + "',Apellido='" + nuevoApellido + "'" +
                        "WHERE DNI='"+DNI+"'";

                   SqlCommand comandoUpdate = new SqlCommand(queryUpdate, connection);
                    comandoUpdate.ExecuteNonQuery();

                }
                else
                {
                    Console.WriteLine("El DNI no se ha encontrado.");
                }
                connection.Close();

            } while (encontrado==false);

        }


        public static void CheckIn()

        {
            bool encontrado = false;

            Console.WriteLine("Introduce el DNI:");
            string DNI = Console.ReadLine();
            string query = "select * from Clientes WHERE DNI='" + DNI + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                encontrado = true;



            }
            else
            {

            }




        }






    }







}

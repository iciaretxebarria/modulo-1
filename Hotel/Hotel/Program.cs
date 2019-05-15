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
            Console.WriteLine("5. Salir");
            Console.WriteLine("6. ");
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
                    CheckIn();
                    break;

                case 4:
                    CheckOut();
                    break;

                case 5:
                    break;

                case 6:
                    



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
                         "WHERE DNI='" + DNI + "'";

                    SqlCommand comandoUpdate = new SqlCommand(queryUpdate, connection);
                    comandoUpdate.ExecuteNonQuery();

                }
                else
                {
                    Console.WriteLine("El DNI no se ha encontrado.");
                }
                connection.Close();

            } while (encontrado == false);

        }


        public static void CheckIn()

        {
            Console.WriteLine("Introduce el DNI:");
            string DNI = Console.ReadLine();
            string query = "select * from Clientes WHERE DNI='" + DNI + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                connection.Close();
                query = "select * from Habitaciones";
                comando = new SqlCommand(query, connection);

                connection.Open();

                registros = comando.ExecuteReader();
                while (registros.Read())
                {
                    Console.WriteLine("Habitación " + registros[0].ToString() + ". Estado:" + registros[1].ToString());
                }

                int numHabitacion;

                do
                {
                    Console.WriteLine("Escoge la habitación deseada");
                    numHabitacion = Convert.ToInt32(Console.ReadLine());

                    if (numHabitacion <= 0 || numHabitacion > 8)
                    {
                        Console.WriteLine("El número de habitación no es correcto.");
                    }

                } while (numHabitacion <= 0 || numHabitacion > 8);

                connection.Close();

                query = "UPDATE Habitaciones SET Estado = 'Ocupado' WHERE ID = " + numHabitacion + "";
                comando = new SqlCommand(query, connection);
                connection.Open();
                comando.ExecuteNonQuery();

                Console.WriteLine("Habitación reservada correctamente.");
                connection.Close();

            }
            else
            {
                Console.WriteLine("El cliente no está registrado y por lo tanto no puede hacer una reserva.");
            }
        }


        public static void CheckOut()

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
                    string IDCliente = registros[0].ToString();

                    Console.WriteLine("Introduce el número de habitación");
                    string numHabitacion = Console.ReadLine();

                    connection.Close();
                    query = "SELECT ID from Habitaciones WHERE ID = " + numHabitacion + "";
                    comando = new SqlCommand(query, connection);
                    connection.Open();
                    registros = comando.ExecuteReader();
                    registros.Read();
                    string IDHab = registros[0].ToString();
                    connection.Close();


                    query = "INSERT INTO Reservas (IDCliente, IDHabitacion, FechaCheckOut) " +
                        "VALUES ("+IDCliente+","+IDHab+",GETDATE())";
                    comando = new SqlCommand(query, connection);
                    connection.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Fecha CheckOut actualizada.");
                    connection.Close();

                    query = "UPDATE Habitaciones SET Estado= 'Libre' WHERE ID= " + numHabitacion + "";
                    comando = new SqlCommand(query, connection);
                    connection.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Estado habitación actualizado.");
                    connection.Close();

                }

                else
                {
                    Console.WriteLine("El cliente no está registrado.");
                    connection.Close();
                }


            } while (encontrado==false);

        }


        public static void VerTodas()
        {
            string query = "SELECT Habitaciones.ID, Habitaciones.Estado, Clientes.Nombre FROM Habitaciones" +
                "INNER JOIN Reservas ON Habitaciones.ID = Reservas.IDHabitacion" +
                "INNER JOIN  Clientes ON Reservas.IDCliente = Clientes.ID" +
                "WHERE FechaCheckOut<GETDATE()";





        }

    }

}

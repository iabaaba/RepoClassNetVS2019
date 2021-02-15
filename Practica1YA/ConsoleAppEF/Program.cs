using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppEF.Modelo;
using System.Globalization;

namespace ConsoleAppEF
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "S";
            ConnectionDB conn = new ConnectionDB();
            string optionExit = "4";
            #region   Cliente

            try
            {
                List<tbCliente> listCliente = new List<tbCliente>();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Sistema de Registro Cliente");
                    Console.WriteLine("Ingrese la Opcion");
                    Console.WriteLine("1. Listar");
                    Console.WriteLine("2. Registrar");
                    Console.WriteLine("3. Editar");
                    Console.WriteLine("4. Salir");
                    string option = Console.ReadLine();
                    optionExit = option;
                    switch (option)
                    {
                        case "1": // Listar
                            using (var db = new ConnectionDB())
                            {
                                listCliente = db.tbCliente.ToList();
                            }
                            for (int i = 0; i < listCliente.Count; i++)
                            {
                                Console.WriteLine(listCliente[i].nombreCliente + " " + listCliente[i].apellidosCliente);
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "2": // Registrar
                            Console.WriteLine("Ingrese Nombre del Cliente");
                            string nombreCliente = Console.ReadLine();
                            tbCliente clienteBEAN = new tbCliente();
                            clienteBEAN.nombreCliente = Convert.ToString(nombreCliente);

                            Console.WriteLine("Ingrese Apellido del Cliente");
                            string apellidoCliente = Console.ReadLine();
                            clienteBEAN.apellidosCliente = apellidoCliente;

                            Console.WriteLine("Ingrese Fecha Nacimiento Cliente  MM/dd/YYYY");
                            string fechaString = Console.ReadLine();
                            string formato = "MM/dd/yyyy";
                            DateTime fechaNacimientoCliente = DateTime.ParseExact(fechaString, formato, CultureInfo.InvariantCulture);
                            clienteBEAN = new tbCliente { fechaNacimiento = fechaNacimientoCliente };

                            using (var db = new ConnectionDB())
                            {
                                db.tbCliente.Add(clienteBEAN);
                                db.SaveChanges();
                                listCliente = db.tbCliente.ToList();

                                for (int i = 0; i < listCliente.Count; i++)
                                {
                                    Console.WriteLine(listCliente[i].nombreCliente + " " + listCliente[i].apellidosCliente);
                                }
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "3": // Editar
                            using (var db = new ConnectionDB())
                            {
                                tbCliente client = new tbCliente();

                                Console.WriteLine("ingrese codigo a editar");
                                int idCliente = Convert.ToInt32(Console.ReadLine());
                                client = db.tbCliente.Find(idCliente);
                                Console.WriteLine("ingrese nuevo nombre");

                                string nombre = Console.ReadLine();
                                client.nombreCliente = nombre;
                                db.SaveChanges();
                            }

                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "4":  // Salir
                            Console.WriteLine("Salio del Menu");
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }

                } while (rpta == "s" || rpta == "S" || optionExit == "4");

                Console.WriteLine("Bye , presione X ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Error" + ex);
                throw;
            }
            #endregion

            #region  Tarjeta

            try
            {
                List<tbTarjeta> listTarjeta = new List<tbTarjeta>();
                List<tbCliente> listCliente = new List<tbCliente>();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Sistema de Registro Tarjeta");
                    Console.WriteLine("Ingrese la Opcion");
                    Console.WriteLine("1. Listar");
                    Console.WriteLine("2. Registrar");
                    Console.WriteLine("3. Editar");
                    Console.WriteLine("4. Salir");
                    string option = Console.ReadLine(); switch (option)
                    {
                        case "1": // Listar
                            using (var db = new ConnectionDB())
                            {
                                listTarjeta = db.tbTarjeta.ToList();
                            }
                            for (int i = 0; i < listTarjeta.Count; i++)
                            {
                                Console.WriteLine(listTarjeta[i].numeroTarjeta + " " + listTarjeta[i].tbCliente);
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "2": // Registrar Tarjeta
                            Console.WriteLine("Listando Clientes");
                            using (var db = new ConnectionDB())
                            {
                                listCliente = db.tbCliente.ToList();
                            }
                            
                            for (int i = 0; i < listCliente.Count; i++)
                            {
                                Console.WriteLine(listCliente[i].nombreCliente + " " + listCliente[i].apellidosCliente);
                            }
                            
                            Console.WriteLine("Ingrese Numero de Tarjeta");
                            string numeroTarjeta = Console.ReadLine();
                            tbTarjeta tarjetaBEAN = new tbTarjeta();
                            tarjetaBEAN.numeroTarjeta = Convert.ToString(numeroTarjeta);

                            Console.WriteLine("Ingrese ID del Cliente");
                            string idCliente = Console.ReadLine();
                            tarjetaBEAN.idCliente = Convert.ToInt32( idCliente);

                            using (var db = new ConnectionDB())
                            {
                                db.tbTarjeta.Add(tarjetaBEAN);
                                db.SaveChanges();
                                listTarjeta = db.tbTarjeta.ToList();

                                for (int i = 0; i < listTarjeta.Count; i++)
                                {
                                    Console.WriteLine(listTarjeta[i].numeroTarjeta + " " + listTarjeta[i].idCliente);
                                }
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "3": // Editar
                            using (var db = new ConnectionDB())
                            {
                                tbTarjeta tarjeta = new tbTarjeta();

                                Console.WriteLine("ingrese Id de Tarjeta");
                                int idTarjeta = Convert.ToInt32(Console.ReadLine());
                                tarjeta = db.tbTarjeta.Find(idTarjeta);
            
                                Console.WriteLine("ingrese nuevo Numero Tarjeta");
                                string nroTarjeta = Console.ReadLine();
                                tarjeta.numeroTarjeta = nroTarjeta;
                                db.SaveChanges();
                            }

                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "4":  // Salir
                            Console.WriteLine("Salio del Menu");
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }

                } while (rpta == "s" || rpta == "S" || optionExit == "4");
                Console.WriteLine("Bye , presione X ");

            }
            catch (Exception exTarjeta)
            {
                Console.WriteLine("Exception Error " + exTarjeta);
                throw;
            }
            #endregion

            #region Pais

            try
            {

                List<tbPais> listPais = new List<tbPais>();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Sistema de Registro Pais");
                    Console.WriteLine("Ingrese la Opcion");
                    Console.WriteLine("1. Listar");
                    Console.WriteLine("2. Registrar");
                    Console.WriteLine("3. Editar");
                    Console.WriteLine("4. Salir");
                    string option = Console.ReadLine();
                    optionExit = option;
                    switch (option)
                    {
                        case "1": // Listar
                            using (var db = new ConnectionDB())
                            {
                                listPais = db.tbPais.ToList();
                            }
                            for (int i = 0; i < listPais.Count; i++)
                            {
                                Console.WriteLine(listPais[i].codigoPais + " " + listPais[i].nombrePais);
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "2": // Registrar
                            Console.WriteLine("Ingrese Nombre del Pais");
                            string nombrePais = Console.ReadLine();
                            tbPais paisBEAN = new tbPais();
                            paisBEAN.nombrePais = Convert.ToString(nombrePais);

                            using (var db = new ConnectionDB())
                            {
                                db.tbPais.Add(paisBEAN);
                                db.SaveChanges();
                                listPais = db.tbPais.ToList();

                                for (int i = 0; i < listPais.Count; i++)
                                {
                                    Console.WriteLine(listPais[i].idPais + " " + listPais[i].nombrePais);
                                }
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "3": // Editar
                            using (var db = new ConnectionDB())
                            {
                                tbPais pais = new tbPais();

                                Console.WriteLine("ingrese codigo a editar");
                                int idPais = Convert.ToInt32(Console.ReadLine());
                                pais = db.tbPais.Find(idPais);
                                Console.WriteLine("ingrese nuevo nombre Pais");

                                string nombre = Console.ReadLine();
                                pais.nombrePais = nombre;
                                db.SaveChanges();

                            }

                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "4":  // Salir
                            Console.WriteLine("Salio del Menu");
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }

                } while (rpta == "s" || rpta == "S" || optionExit == "4");

                Console.WriteLine("Bye , presione X ");

            }
            catch (Exception exPais)
            {
                Console.WriteLine("Exception error" + exPais);
                throw;
            }
            #endregion
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEAN;
using DAO1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // RolDAO rolDAO = new RolDAO();
            // List<RolBEAN> lista = rolDAO.listaRoles();
            // Console.WriteLine("Lista de Roles");
            // Console.WriteLine("");
            // for (int i = 0; i < lista.Count; i++)
            // {
            //    Console.WriteLine(lista[i].idRol + " " +  lista[i].nombreRol);
            // }


            //ProductoDAO  productoDAO = new ProductoDAO();
            //List<ProductoBEAN> lista = productoDAO.listaProducto();
            //Console.WriteLine("Lista de Productos");
            //Console.WriteLine(" ");
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i].idProducto + " " + lista[i].nombreProducto);

            //}

            //ClienteDAO clienteDAO = new ClienteDAO();
            //Console.WriteLine("Ingrese DNI a Buscar");
            //string numDoc = Console.ReadLine();
            //List<ClienteBEAN> listaCli = clienteDAO.listaCliente(numDoc);
            //Console.WriteLine("Lista de Cliente");
            //for (int i = 0; i < listaCli.Count; i++)
            //{
            //    Console.WriteLine(listaCli[i].idCliente + "\t"
            //        + listaCli[i].nombreCliente
            //        + listaCli[i].apellidoCliente + "\t"
            //        + listaCli[i].numeroDocument + "\t"
            //        + listaCli[i].generoCliente + "\t"
            //        + listaCli[i].idCategoria + "\t"
            //        + listaCli[i].nombreCategoria + "\t"
            //        );

            //}
            //Console.ReadLine();

            //RolDAO rolDAO = new RolDAO();
            //RolBEAN rolBEAN = new RolBEAN();
            //Console.WriteLine("Ingrese el nombre del Rol");
            //rolBEAN.nombreRol = Console.ReadLine();
            //bool rpta = rolDAO.RegistroRol(rolBEAN);
            //if (rpta == true)
            //{
            //    Console.WriteLine("Registrado Correctamente");
            //}
            //else
            //{
            //    Console.WriteLine("No se registro informacion");
            //}
            //Console.ReadLine();


            RolDAO rolDAO = new RolDAO();
            RolBEAN rolBEAN = new RolBEAN();
            Console.WriteLine("Ingrese nombre del Rol");
            rolBEAN.nombreRol = Console.ReadLine();
            List<RolBEAN> lista = rolDAO.RegistroListaRol(rolBEAN);
            Console.WriteLine("Lista de Roles");
            Console.WriteLine("ID \t Nombre");
            Console.WriteLine("");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].idRol + " " + lista[i].nombreRol);
            }
            Console.ReadLine();
            /* Elaborar un CRUD para tabla ROL*/
            /* 
            1 Listar
            2. Registrar
            3. Actualizar
             */
            Console.WriteLine("CRUD para Tabla Rol");
            Console.WriteLine("1. Listar");
            Console.WriteLine("2. Registrar");
            Console.WriteLine("3. Actualizar");
            Console.WriteLine("Ingrese Opcion que desea ejecutar");
            string option = Console.ReadLine();
       //     RolDAO rolDAO = new RolDAO();
       /*     switch (option)
            {
                case "1":

                    List<RolBEAN> lista = rolDAO.listaRoles();
                    Console.WriteLine("Lista de Roles");
                    Console.WriteLine("");
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine(lista[i].idRol + " " + lista[i].nombreRol);
                    }
                    break;
                case "2":
                    RolBEAN rolBEAN = new RolBEAN();
                    Console.WriteLine("Ingrese el nombre del Rol");
                    rolBEAN.nombreRol=Console.ReadLine();
                    bool rpta = rolDAO.RegistroRol(rolBEAN);
                    if (rpta == true)
                    {
                        Console.WriteLine("Registrado Correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No se registro informacion");
                    }


                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;

            }
       */
            Console.ReadLine();
        }
    }
}

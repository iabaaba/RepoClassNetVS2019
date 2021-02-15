using BEAN;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "S";
            string optionExit = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Registro de Paises");
                Console.WriteLine("Ingrese la Opcion");
                Console.WriteLine("1. Listar");
                Console.WriteLine("2. Registrar");
                Console.WriteLine("3. Salir");
                string option = Console.ReadLine();
                optionExit = option;
                switch (option)
                {
                    case "1": // Listar
                        PaisDAO paisDAO = new PaisDAO();
                        List<PaisBEAN> lista = paisDAO.listaPaises();
                        Console.WriteLine("Lista de Paises");
                        Console.WriteLine("");
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i].idPais + " " + lista[i].nombrePais);
                        }
                        Console.WriteLine("Desea Continuar");
                        rpta = Console.ReadLine();
                        break;
                    case "2": // Registrar
                        paisDAO = new PaisDAO();
                        PaisBEAN paisBEAN = new PaisBEAN();
                        Console.WriteLine("Ingrese el nombre del Pais");
                        paisBEAN.nombrePais = Console.ReadLine();
                        bool rptaok = paisDAO.RegistroPais(paisBEAN);
                        if (rptaok == true)
                        {
                            Console.WriteLine("Registrado Correctamente");
                        }
                        else
                        {
                            Console.WriteLine("No se registro informacion");
                        }
                        Console.WriteLine("Desea Continuar");
                        rpta = Console.ReadLine();
                        break;
                    case "3":  // Salir
                        Console.WriteLine("Salio del Menu");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            } while (rpta == "s" || rpta == "S" || optionExit == "3");

            Console.WriteLine("Bye , Sali");

            Console.ReadLine();
        }
    }
}

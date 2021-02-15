using BEAN;
using ConsoleApp1.Modelo;
using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Programacion orientada a Objetos
            //Console.WriteLine("Ingrese su nombre");
            //string nombre = Console.ReadLine();
            // Console.WriteLine("Bienvenido a clase 1 de .Net " + nombre);
            //Console.ReadLine();
            PersonaDAO perDAO = new PersonaDAO();
            //perDAO.RegistroInformacion();
            //Console.WriteLine("\n");
            //perDAO.RegistroInformacion("Pocho", " Abarca");

            //PersonaBEAN perBEAN = new PersonaBEAN();
            //perBEAN.Nombre = "Yuri";
            //perBEAN.Apellido = "Abarca";
            //perBEAN.Carrera = "Computer Science";
            //Console.WriteLine("\n");
            //perDAO.RegistroInformacion(perBEAN);

            //PersonaBEAN perBEAN2 = new PersonaBEAN() { Nombre= "Maria", Apellido = "Del Pilar", Carrera="Teacher"};
            //perDAO.RegistroInformacion(perBEAN2);

            //Console.WriteLine("\n");
            //perDAO.RegistroInformacion(new PersonaBEAN() { Nombre = "Nueva", Apellido = "Instancia", Carrera = "Teacher2" });

            //Console.WriteLine("\n");
            //double promedio = perDAO.CalculoNotas(15.5, 13.9);
            //Console.WriteLine("el promedio otenido es: " + promedio);
            #endregion

            #region Colleccion de Datos
            /*
             Permite alnacenar elementos genericos, 
             No tiene limitaciones como los arreglos, pero genera mayor consumo de recursos
             Puede realizar operaciones de CRUD
             Los mas conocidos 
             List(listas)FIFO, Queue(colas), Stacks(pilas)LIFO, Dictionary(dictionarios)
             */
            //List<int> listaNumeros = new List<int>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    listaNumeros.Add(i); // Anade Informacion a la Lista
            //}
            //Console.WriteLine("\n Lista de Numeros con FOR");
            //for (int i = 0; i < listaNumeros.Count; i++)
            //{
            //    Console.WriteLine(listaNumeros[i]);
            //}
            //Console.WriteLine("\n Lista de Numeros con FOREACH");

            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            /*
             Elaborar programa que ingrese los valores: si es cero termina ejecucion y muestre los valore ingresados
             */
            //List<int> ListNumbers = new List<int>(); 
            //int typeNumber = 0;

            //do
            //{

            //    Console.WriteLine("\n Ingrese un Numero");
            //    typeNumber = Convert.ToInt32(Console.ReadLine());
            //    ListNumbers.Add(typeNumber);

            //} while (typeNumber != 0);

            //foreach (var item in ListNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            // Lista con Clases.

            //PersonaBEAN perBEAN = new PersonaBEAN();
            //perBEAN.Nombre = "Yuri";
            //perBEAN.Apellido = "Abarca";
            //perBEAN.Carrera = "Computer Science";
            //perBEAN.Edad = 30;
            //List<PersonaBEAN> listaPersona = new List<PersonaBEAN>();
            //listaPersona.Add(perBEAN);
            //listaPersona.Add(new PersonaBEAN { Nombre = "Pocho", Apellido = "Rojas", Edad = 25, Carrera="Ingenieria" });
            //Console.WriteLine("Listado con for");
            //for (int i = 0; i < listaPersona.Count; i++)
            //{
            //    Console.WriteLine(listaPersona[i].Nombre + " " + listaPersona[i].Apellido+ " "+ listaPersona[i].Edad + " " + listaPersona[i].Carrera );
            //}
            //Console.WriteLine("Listado con foreach");
            //foreach (var item in listaPersona)
            //{
            //    Console.WriteLine(item.Nombre + " " + item.Apellido + " " + item.Edad + " " + item.Carrera);

            //}


            // Diferencia entre List y ArrayList

            //var arrayList = new ArrayList();
            //arrayList.Add(1);      // puede contener numeros
            //arrayList.Add("dos");  // puede contener texto
            //arrayList.Add(false);  // puede contener booleam

            //var list = new List<int>();
            //list.Add(1);
            //list.Add("dos"); // invalido


            // Diccionario  usado mas en msg de error , validacion  

            //Dictionary<int, string> datos = new Dictionary<int, string>();
            //datos.Add(1, "Lunes");
            //datos.Add(2, "Martes");
            //datos.Add(3, "Miercoles");
            //datos.Add(4, "Jueves");
            //datos.Add(5, "Viernes");
            //datos.Add(6, "Sabado");
            //datos.Add(7, "Domingo");
            //for (int i = 1; i <= datos.Count; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}


            #endregion


            #region Entity Frameword

            //ConectionDB connDB = new ConectionDB();
            //List<tb_Categoria> listCategoria = new List<tb_Categoria>();
            //// USING: mantiene el grado de conexcion hasta que ha finalizado el bloque, abre y cierra la coneccion mietras
            //// realiza el proceso y es automatico
            //using (var db = new ConectionDB())
            //{ 
            //    listCategoria = db.tb_Categoria.ToList();
            //}
            //for (int i = 0; i < listCategoria.Count; i++)
            //{
            //    Console.WriteLine(listCategoria[i].idCategoria + " " + listCategoria[i].nombreCategoria);
            //}

            //Console.WriteLine("\n");
            //List<tb_Producto> ListaProducto = new List<tb_Producto>();
            //using (var db = new ConectionDB())
            //{
            //    ListaProducto = db.tb_Producto.ToList();
            //}
            //for (int i = 0; i < ListaProducto.Count; i++)
            //{
            //    Console.WriteLine(ListaProducto[i].idProducto + " " + ListaProducto[i].nombreProducto);
            //}


            //Console.WriteLine("Ingrese Nombre Categoria");
            //string nombreCategoria = Console.ReadLine();
            //tb_Categoria categoriaBEAN = new tb_Categoria { nombreCategoria = nombreCategoria};

            //using (var db = new ConectionDB())
            //{
            //    db.tb_Categoria.Add(categoriaBEAN);
            //    db.SaveChanges();  // Guarada Cambios.

            //    listCategoria = db.tb_Categoria.ToList();
            //}

            //for (int i = 0; i < listCategoria.Count; i++)
            //{
            //    Console.WriteLine(listCategoria[i].idCategoria + " " + listCategoria[i].nombreCategoria);
            //}

            // implementar un menu para realizar un CRUD
            // Sistema de Registro Categoria
            // 1. Listar  Desea Continuar Si regresa al menu
            // 2. Registrar
            // 3. Editar
            // 4. Eliminar
            // 5- Salir 

            string rpta = "S";

            try
            {
                ConectionDB connDB = new ConectionDB();
                List<tb_Categoria> listCategoria = new List<tb_Categoria>();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Sistema de Registro Categoria");
                    Console.WriteLine("Ingrese la Opcion");
                    Console.WriteLine("1. Listar");
                    Console.WriteLine("2. Registrar");
                    Console.WriteLine("3. Editar");
                    Console.WriteLine("4. Eliminar");
                    Console.WriteLine("5. Join SQL");
                    Console.WriteLine("6. Salir");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            using (var db = new ConectionDB())
                            {
                                listCategoria = db.tb_Categoria.ToList();// ToList() para cargar la lista
                            }
                            for (int i = 0; i < listCategoria.Count; i++)
                            {
                                Console.WriteLine(listCategoria[i].idCategoria + " " + listCategoria[i].nombreCategoria);
                            }
                            Console.WriteLine("Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "2":

                            Console.WriteLine("Ingrese Nombre Categoria");
                            string nombreCategoria = Console.ReadLine();
                            tb_Categoria categoriaBEAN = new tb_Categoria { nombreCategoria = nombreCategoria };

                            using (var db = new ConectionDB())
                            {
                                db.tb_Categoria.Add(categoriaBEAN); // para adicionar registro.
                                db.SaveChanges();  // Guarda Cambios.
                                Console.WriteLine("Categoria Ingresada Satisfactoriamente");
                            }
                            Console.WriteLine("\n Desea Continuar");
                            rpta = Console.ReadLine();
                            break;
                        case "3": // Editar
                            using (var db = new ConectionDB())
                            {
                                tb_Categoria cat = new tb_Categoria();

                                Console.WriteLine("ingrese codigo a editar");
                                int idCat = Convert.ToInt32(Console.ReadLine());
                                //td_categoria 
                                cat = db.tb_Categoria.Find(idCat);
                                Console.WriteLine("ingrese nuevo nombre");

                                string nombre = Console.ReadLine();
                                cat.nombreCategoria = nombre;
                                db.SaveChanges();
                            }
                            break;
                        case "4": // Eliminar
                            using (var db = new ConectionDB())
                            {
                                tb_Categoria cat = new tb_Categoria();

                                Console.WriteLine("Ingrese codigo a elimnar");
                                int cod = Convert.ToInt32(Console.ReadLine());
                                //td_categoria
                                //cat = new tb_Categoria();
                                cat.idCategoria = cod;
                                // db.tb_Categoria.Remove(db.tb_Categoria.Find(cat.idCategoria));
                                db.Entry(cat).State = EntityState.Deleted;// tambien elimina
                                db.SaveChanges();
                            }
                            break;
                        case "5"://join sql
                            using (var db = new ConectionDB())
                            {
                                var lista = from cc1 in db.tb_ContactoCliente
                                            join col1 in db.tb_Colaborador on cc1.idColaborador equals col1.idColaborador
                                            join col2 in db.tb_Cliente on cc1.idCliente equals col2.idCliente
                                            select new DatosContactoClienteBEAN
                                            {
                                                IdContabilidad = cc1.idContactabilidad,
                                                IdColaborador = cc1.idColaborador,
                                                IdCliente = col2.idCliente,
                                                 nombreCliente = col2.nombreCliente + " " + col2.apellidosCliente,
                                                NombreColaborador = col1.nombreColaborador + " " + col1.apellidoColaborador
                                            };
                                List<DatosContactoClienteBEAN> listaContacto = lista.ToList();
                                Console.WriteLine("Lista Contacto Cliente");
                                for (int i = 0; i < listaContacto.Count; i++)
                                {
                                    Console.WriteLine(listaContacto[i].IdContabilidad + " " +
                                        listaContacto[i].IdColaborador + " " +
                                        listaContacto[i].NombreColaborador + " " +
                                        listaContacto[i].IdCliente + " " +
                                        listaContacto[i].NombreColaborador);
                                }

                            }
                            break;
                        case "6":

                            Console.WriteLine("Salio del Menu");
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }

                } while (rpta == "s" || rpta == "S");
                Console.WriteLine("Bye , presione X ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }



            #endregion
            Console.ReadLine();
        }
    } 
    
}

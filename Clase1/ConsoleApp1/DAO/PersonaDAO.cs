using BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PersonaDAO
    {  /* mismo nombre de Metodo es la propiedad 
            Abstraccion : al crear los metodos del DAO, ver mundo real y que tiene estados comportamiento
            Encapsulamiento: crear atributos y metodos BEAN
            Herencia: al instanciar , hereda la informacion de la Clase
            Polimorfismo: Tener metodos mismo nombre con diferentes acciones de entrada o salida, metodo sobrecardago es decir con parametros  
        */

        public void RegistroInformacion()
        {
            Console.WriteLine("Se registro Correctamente");
        }
        public void RegistroInformacion( string nombre, string apellido )
        {
            Console.WriteLine("Se registro Correctamente la persona " + nombre + apellido);
        }
        public void RegistroInformacion(PersonaBEAN perBEAN)
        {
            Console.WriteLine("Se registro Correctamente la persona " + perBEAN.Nombre + " " + perBEAN.Apellido + " con la carrera "+ perBEAN.Carrera);
        }

        public double CalculoNotas( double nota1, double nota2)
        {
            double prom = (nota1 + nota2) / 2;
            return prom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAN
{
    public class PersonaBEAN
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public string Carrera { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
    }
}

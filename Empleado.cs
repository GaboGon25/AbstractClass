using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public abstract double CalcularSalario();


    }
}

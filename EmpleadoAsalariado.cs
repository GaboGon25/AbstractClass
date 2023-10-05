using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaProgra
{
    public class EmpleadoAsalariado : Empleado
    {
        public double SalarioMensual { get; set; }
        public EmpleadoAsalariado(string nombre, double salarioMensual) : base(nombre)
        {
            SalarioMensual = salarioMensual;
        }

        public override double CalcularSalario()
        {
            return SalarioMensual;
        }
    }
}

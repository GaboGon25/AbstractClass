using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra
{
    public class EmpleadoPorHora : Empleado
    {
        public double HorasTrabajadas { get; set; }
        public double TarifaPorHora { get; set; }
        public EmpleadoPorHora(string nombre, double horasTrabajadas, double tarifaPorHora) : base(nombre)
        {
            HorasTrabajadas = horasTrabajadas;
            TarifaPorHora = tarifaPorHora;
        }

        public override double CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}

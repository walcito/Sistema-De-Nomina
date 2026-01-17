using System;

namespace SISTEMADENOMINA
{
    //clase ´principal
    public abstract class Empleado
    {
        public string PrimerNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NumeroSeguroSocial { get; set; }

        // metodo para calcular pago
        public abstract double CalcularPago();

        public override string ToString()
        {
            return $"Empleado: {PrimerNombre} {ApellidoPaterno}\nNSS: {NumeroSeguroSocial}";
        }
    }

    // asalariadio
    public class EmpleadoAsalariado : Empleado
    {
        public double SalarioSemanal { get; set; }
        public override double CalcularPago() => SalarioSemanal;
    }

    // por horas
    public class EmpleadoPorHoras : Empleado
    {
        public double SueldoPorHora { get; set; }
        public double HorasTrabajadas { get; set; }

        public override double CalcularPago()
        {
            if (HorasTrabajadas <= 40)
                return SueldoPorHora * HorasTrabajadas;
            else
                return (40 * SueldoPorHora) + ((HorasTrabajadas - 40) * SueldoPorHora * 1.5);
        }
    }

    //comision
    public class EmpleadoComision : Empleado
    {
        public double VentasBrutas { get; set; }
        public double TarifaComision { get; set; }
        public override double CalcularPago() => VentasBrutas * TarifaComision;
    }

    //asalariado comision
    public class EmpleadoAsalariadoComision : EmpleadoComision
    {
        public double SalarioBase { get; set; }
        public override double CalcularPago()
        {
            return base.CalcularPago() + SalarioBase + (SalarioBase * 0.10);
        }
    }
}
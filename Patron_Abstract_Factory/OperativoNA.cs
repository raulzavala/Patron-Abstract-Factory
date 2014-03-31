using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Abstract_Factory
{
    public class OperativoNA: Operativo
    {
        //Constructor
        public OperativoNA(string EspR, int TiemR, string HabilR, string GradR, float SalarioR)
            : base(EspR, TiemR, HabilR, GradR, SalarioR) { }

        //Metodo override
        public override void Mostrar_Caract()
        {
            Console.WriteLine("\nEspecialidad: " + Especialidad);
            Console.WriteLine("Egresado en: " + Tiempo.ToString());
            Console.WriteLine("Habilidades: " + Habilidades);
            Console.WriteLine("Grado: " + Grado);
            Console.WriteLine("Salario: " + Salario.ToString());
        }
    }
}

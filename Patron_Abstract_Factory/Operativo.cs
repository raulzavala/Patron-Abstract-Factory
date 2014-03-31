using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Abstract_Factory
{
    //Producto abstracto 2
    public abstract class Operativo
    {
        protected string Especialidad;
        protected int Tiempo; //Tiempo de egresado
        protected string Habilidades;
        protected string Grado;
        protected float Salario;

        public Operativo(string EspR, int TiemR, string HabilR, string GradR, float SalarioR)
        {
            this.Especialidad = EspR;
            this.Tiempo = TiemR;
            this.Habilidades = HabilR;
            this.Grado = GradR;
            this.Salario = SalarioR;
        }

        public abstract void Mostrar_Caract();

           /* Console.Clear();
            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Tiempo: " + Tiempo.ToString());
            Console.WriteLine("Habilidades: " + Habilidades);
            Console.WriteLine("Grado: " + Grado);
            Console.WriteLine("\nPresione (ENTER) para continuar...");*/
        
    }
}

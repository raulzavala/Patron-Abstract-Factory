using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Abstract_Factory
{
    public class FabricaOutsourcingExp:FabricaOutsourcing
    {
        //Fabrica Concreta 1 - Con experiencia

        public Administrativo CreaAdministrativo(string Esp, int Tiemp, string Habil, string Grad, float salario)
        {
            return new AdministrativoExp(Esp,Tiemp,Habil,Grad,salario);
        }

        public Operativo CreaOperativo(string Esp, int Tiemp, string Habil, string Grad,float salario)
        {
            return new OperativoExp(Esp,Tiemp,Habil,Grad,salario);
        }

    }
}

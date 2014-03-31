using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Abstract_Factory
{
    public class FabricaOutsourcingNA:FabricaOutsourcing
    {
        //Fabrica concreta 2 - Sin experiencia

        public Administrativo CreaAdministrativo(string Esp, int Tiemp, string Habil, string Grad, float salario)
        {
            return new AdministrativoNA(Esp, Tiemp, Habil, Grad, salario);
        }

        public Operativo CreaOperativo(string Esp, int Tiemp, string Habil, string Grad, float salario)
        {
            return new OperativoNA(Esp,Tiemp,Habil,Grad,salario);
        }
    }
}

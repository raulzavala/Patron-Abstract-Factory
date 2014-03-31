using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Abstract_Factory
{
    //Interface que define la firma de los metodos que crean los productos
    public interface FabricaOutsourcing
    {
        //Metodos..

        //Administrativo
        Administrativo CreaAdministrativo(string Esp, int Tiemp, string Habil, string grado, float salario);

        //Operativo
        Operativo CreaOperativo(string Esp, int Tiemp, string Habil, string grado, float salario);

    }
}

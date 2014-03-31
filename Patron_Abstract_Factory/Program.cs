using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de la fabrica abstracta
            FabricaOutsourcing Fabrica;

            //En igual de arreglos (usamos listas)
            //Administrativos
            List<Administrativo> Administrativos = new List<Administrativo>();
            //Operativos
            List<Operativo> Operativos = new List<Operativo>();

            //Variables encargadas del menu
            byte opcion;

            try
            {
                //MENU DE OPCIONES
                do
                {
                    Console.Clear();
                    Console.WriteLine("--- MENU OUTSOURCING ---");
                    Console.WriteLine("1.- Tipo de personal");
                    Console.WriteLine("2.- Listar personal administrativo");
                    Console.WriteLine("3.- Listar personal operativo");
                    Console.WriteLine("4.- Salir del programa");
                    Console.Write("\nSeleccione (opción) a realizar: ");
                    opcion = Byte.Parse(Console.ReadLine());

                    //Switch
                    switch (opcion)
                    {
                        case 1:
                            opcion = 0;
                            Console.Clear();
                            Console.WriteLine("1.- Personal con experiencia");
                            Console.WriteLine("2.- Personal sin experiencia");
                            Console.Write("\nSeleccione (opción) a realizar: ");
                            opcion = Byte.Parse(Console.ReadLine());

                            if (opcion == 1)
                            {
                                do
                                {
                                    opcion = 0;
                                    Fabrica = new FabricaOutsourcingExp();
                                    Console.Clear();
                                    Console.WriteLine("\n1.- Administrativo");
                                    Console.WriteLine("2.- Operativo");
                                    Console.WriteLine("3.- Regresar al menu");
                                    Console.Write("\nSeleccione (opción) a realizar: ");
                                    opcion = Byte.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            Administrativos.Add(Fabrica.CreaAdministrativo("Administración de proyectos", 2014, "Manufactura", "Licenciatura", 10000));
                                            Console.WriteLine("\nPersonal implementado");
                                            Console.WriteLine("Presione (Enter) para continuar");
                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Operativos.Add(Fabrica.CreaOperativo("Programación de eventos", 2013, "Computación", "Comercio", 8000));
                                            Console.WriteLine("\nPersonal implementado");
                                            Console.WriteLine("Presione (Enter) para continuar");
                                            Console.ReadKey();
                                            break;

                                        case 3:
                                            //Salida
                                            break;

                                        default:
                                            Console.WriteLine("Opcion invalida!, intente otra opcion..");
                                            Console.ReadKey();
                                            break;
                                    }
                                } while (opcion != 3);
                            }
                            else
                            {
                                do
                                {
                                    opcion = 0;
                                    Fabrica = new FabricaOutsourcingNA();
                                    Console.Clear();
                                    Console.WriteLine("\n1.- Administrativo");
                                    Console.WriteLine("2.- Operativo");
                                    Console.WriteLine("3.- Regresar al menu");
                                    Console.Write("\nSeleccione (opción) a realizar: ");
                                    opcion = Byte.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            Administrativos.Add(Fabrica.CreaAdministrativo("Administración de proyectos", 12, "Manufactura", "Licenciatura", 22000));
                                            Console.WriteLine("\nPersonal implementado");
                                            Console.WriteLine("Presione (Enter) para continuar");
                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Operativos.Add(Fabrica.CreaOperativo("Programación de eventos", 15, "Computación", "Comercio", 18000));
                                            Console.WriteLine("\nPersonal implementado");
                                            Console.WriteLine("Presione (Enter) para continuar");
                                            Console.ReadKey();
                                            break;

                                        case 3:
                                            //Salida
                                            break;

                                        default:
                                            Console.WriteLine("Opcion invalida!, intente otra opcion..");
                                            Console.ReadKey();
                                            break;
                                    }
                                } while (opcion != 3);
                            }
                            break;

                        case 2:                           
                            // Ciclo de recorrido del arreglo
                            foreach (Administrativo Adm in Administrativos)
                            {
                                Adm.Mostrar_Caract();
                            }
                            Console.WriteLine("Presione (Enter) para continuar");
                            Console.ReadKey();
                            break;

                        case 3:
                            foreach (Operativo Ope in Operativos)
                            {
                                Ope.Mostrar_Caract();
                            }
                            Console.WriteLine("Presione (Enter) para continuar");
                            Console.ReadKey();
                            break;

                        case 4:
                            //Salida
                            break;

                        default:
                            Console.WriteLine("Opcion inválida!, intente otra opcion..");
                            Console.ReadKey();
                            break;

                    }
                } while (opcion != 4);
            }

            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Tipo de seleccion (entrada) inválida!");
                Console.ReadKey();
            }

        }
    }
}

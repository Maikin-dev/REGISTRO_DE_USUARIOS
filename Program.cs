using System.Collections.Generic;

namespace REGISTRO_DE_USUARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserRegistry registry = UserRegistry.Instance;

            Console.WriteLine("Este programa gestionara usuarios \n");

            bool activo = true;
            while (activo == true)
            {
                Console.WriteLine("\nSelecciona una opcion: \n");
                Console.WriteLine("1.Añadir usuario.");
                Console.WriteLine("2.Eliminar usuario.");
                Console.WriteLine("3.Mostrar cantidad de usuarios.");
                Console.WriteLine("4.Mostrar todos los usuarios.");
                Console.WriteLine("5.Salir del programa. \n");
                int opcion = Convert.ToInt32(Console.ReadLine());
                var validacion = false;

                while (!validacion)
                {
                    string Nombre;
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\nIntroduzca el nombre del usuario: ");
                            Nombre = Console.ReadLine();
                            registry.AddUser(Nombre); 
                            validacion = true;
                            activo = true;
                            break;

                        case 2:
                            Console.WriteLine("\nIntroduzca el nombre del usuario que desea eliminar. \nEsta es una lista de los usuarios guardados:  ");
                            registry.ListaUsuarios();
                            Nombre = Console.ReadLine();
                            registry.DelUser(Nombre);
                            validacion = true;
                            activo = true;
                            break;

                        case 3:
                            Console.WriteLine("\nEsta es la cantidad de usuarios actualmente: ");
                            registry.TotalUsuarios();
                            validacion = true;
                            activo = true;
                            break;

                        case 4:
                            Console.WriteLine("\nEsta es una lista de todos lo nombres: ");
                            registry.ListaUsuarios();
                            validacion = true;
                            activo = true;
                            break;

                        case 5:
                            Console.WriteLine("El programa ha finalizado. \n");
                            Console.WriteLine("El programa se debe acabar \n");
                            validacion = true;
                            activo = false;
                            break;

                        default:
                            Console.WriteLine("La tecla presionada no estaba en la lista de opciones, se deberia pedir la opcion nuevamente \n");
                            Console.WriteLine("Elige de nuevo: \n");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            activo = true;
                            break;

                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace REGISTRO_DE_USUARIO
{
    internal class UserRegistry
    {
        private List<string> Usuarios;
        private static UserRegistry instance = null;

        private UserRegistry()
        {
            Usuarios = new List<string>();
        }


        public static UserRegistry Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserRegistry();

                return instance;
            }
        }
        
        public void AddUser(string Nombre)
        {
             Usuarios.Add(Nombre);
             Repeticion(Nombre);
        }

        public void DelUser(string Nombre)
        {
            Usuarios.Remove(Nombre);
            Console.WriteLine($"El usuario {Nombre} ha sido eliminado \n");
        }

        public void TotalUsuarios()
        {
            Console.WriteLine($"{Usuarios.Count()}"); 
        }

        public void Repeticion(string Nombre)
        {
            for (int i = 0; i < Usuarios.Count; i++)
            {
                if (Usuarios[i].ToLower() == Nombre.ToLower()) 
                {           
                    int max = Usuarios.Count(); 
                    if (max > i + 1)
                    {
                        if (Usuarios[i].ToLower() == Nombre.ToLower())
                        {
                            Console.WriteLine("Este nombre es similar o ya existe en el listado,¿desea agregarlo de todos modos?\n Presione\n 1.Si \n 2.No");
                            int opcion = Convert.ToInt32(Console.ReadLine());
                            if (opcion == 1)
                            {
                                Console.WriteLine($"Cambio Guardado\n");
                            }
                            else
                            {
                                Usuarios.Remove(Nombre);
                                Console.WriteLine($"El nombre: {Nombre} ha sido eliminado del listado");
                            }
                        }   
                    }       
                }
            }
        }

        public void ListaUsuarios()
        {
            if (Usuarios.Count <= 0)
            {
                Console.WriteLine("No hay usuarios en el sistema");
            }
            else
            {
                foreach (var usuario in Usuarios)
                {
                    Console.WriteLine(usuario);
                }
            }
        }
    }
}

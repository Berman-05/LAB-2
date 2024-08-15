using LAB_2;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        Functions functions = new Functions();
        while (true)
        {
            try
            {Console.Clear();
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("\n1. Agregar habitación");
                Console.WriteLine("2. Asignar habitación.");
                Console.WriteLine("3. Borrar habitación.");
                Console.WriteLine("4. Liberar habitación.");
                Console.WriteLine("5. Mostrar todas las habitaciones.");
                Console.WriteLine("6. salir:");
                Console.Write("\nOpción:");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        functions.AddRoom();
                        break;
                    case 2:
                        functions.AssignRoom();
                        break;
                    case 3:
                        functions.DeleteRoom();
                        break;
                    case 4:
                        functions.FreeRoom();
                        break;
                    case 5:
                        functions.ShowAllRooms();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Elija una opción válida.");
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
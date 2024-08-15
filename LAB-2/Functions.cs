using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Functions
    {
        List<Room> roomList = new List<Room>();
        public virtual void AddRoom()
        {
            int NewRoomNUmber = 0; string newType = null; double newPrice = 0; bool newAvailable = true; string newClient = "Libre";
            bool newView = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el número de habitación:");
                NewRoomNUmber = int.Parse(Console.ReadLine());
                Room Search = roomList.Find(p => p.RoomNumber == NewRoomNUmber);
                if (Search != null)
                {
                    Console.WriteLine("La habitación ya fue fue creada.");
                }
                else { break; }
            }
            Console.WriteLine("Ingrese el tipo de habitación(básica,doble,suite,deluxe):");
            newType = Console.ReadLine().ToLower();
            switch (newType)
            {
                case "básica":
                    Console.WriteLine("Ingrese el número de camas:");
                    int newBeds = int.Parse(Console.ReadLine());
                    BasicRoom newBasicRoom = new BasicRoom(NewRoomNUmber, newType, newPrice, newAvailable, newClient, newBeds);
                    roomList.Add(newBasicRoom);
                    Console.WriteLine("Habitación creada, pulse enter para continuar.");
                    break;
                case "doble":
                    Console.WriteLine("Ingrese el número de camas:");
                    newBeds = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿La habitación tiene vista al mar? S/N");
                    string seaViewQuestion = Console.ReadLine().ToLower();
                    if (seaViewQuestion == "s") { newView = true; }
                    else { newView = false; }
                    DoubleRoom newDoubleRoom = new DoubleRoom(NewRoomNUmber, newType, newPrice, newAvailable, newClient, newBeds, newView);
                    roomList.Add(newDoubleRoom);
                    Console.WriteLine("Habitación creada, pulse enter para continuar.");
                    break;
                case "suite":
                    Console.WriteLine("Ingrese el número de camas:");
                    newBeds = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿La habitación tiene vista al mar? S/N");
                    seaViewQuestion = Console.ReadLine().ToLower();
                    if (seaViewQuestion == "s") { newView = true; }
                    else { newView = false; }
                    Console.WriteLine("¿Cuantas habitaciones tiene la suite?");
                    int newExtraRooms = int.Parse(Console.ReadLine());
                    Suite newSuite = new Suite(NewRoomNUmber, newType, newPrice, newAvailable, newClient, newBeds, newView, newExtraRooms);
                    roomList.Add(newSuite);
                    Console.WriteLine("Habitación creada, pulse enter para continuar.");
                    break;
                case "deluxe":
                    Console.WriteLine("Ingrese el número de camas:");
                    newBeds = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿La habitación tiene vista al mar? S/N");
                    seaViewQuestion = Console.ReadLine().ToLower();
                    if (seaViewQuestion == "s") { newView = true; }
                    else { newView = false; }
                    Console.WriteLine("¿Cuantas habitaciones tiene la suite?");
                    newExtraRooms = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese los servicios extra:");
                    string newExtraServices = Console.ReadLine();
                    DeluxeRoom newDeluxe = new DeluxeRoom(NewRoomNUmber, newType, newPrice, newAvailable, newClient, newBeds, newView, newExtraRooms, newExtraServices);
                    roomList.Add(newDeluxe);
                    Console.WriteLine("Habitación creada, pulse enter para continuar.");
                    break;
            }
        }
        public void DeleteRoom()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el número de habitación:");
                    int NewRoomNUmber = int.Parse(Console.ReadLine());
                    Room Search = roomList.Find(p => p.RoomNumber == NewRoomNUmber);
                    if (Search != null)
                    {
                        roomList.Remove(Search);
                        Console.WriteLine("Habitación eliminada.");
                        Console.ReadKey();
                        break;
                    }
                    else { Console.WriteLine("Habitación no encontrada"); break; }
                }catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        public void AssignRoom()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el número de habitación:");
                    int NewRoomNUmber = int.Parse(Console.ReadLine());
                    Room Search = roomList.Find(p => p.RoomNumber == NewRoomNUmber);
                    if (Search != null && Search.Available == true)
                    {
                        Console.WriteLine("Ingrese el nombre del cliente asignado:");
                        string newClient = Console.ReadLine();
                        Search.AssignedClient = newClient;
                        Search.Available = false;
                        Console.WriteLine("Cliente asignado...");
                        break;
                    }
                    else if (Search.Available == false)
                    {
                        Console.WriteLine("La habitación esta ocupada.");
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Habitación no encontrada.");
                        break;
                    }
                }catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
        public void FreeRoom()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el número de habitación:");
                    int NewRoomNUmber = int.Parse(Console.ReadLine());
                    Room Search = roomList.Find(p => p.RoomNumber == NewRoomNUmber);
                    if (Search != null && Search.Available == false)
                    {
                        Search.AssignedClient = "Libre";
                        Search.Available = true;
                        Console.WriteLine("Habitación liberada...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Habitación no encontrada.");
                        break;
                    }
                }catch(Exception e) { Console.WriteLine(e.Message) ; }
            }
        }
        public void ShowAllRooms()
        {
            Console.Clear();
            foreach (Room room in roomList)
            {
                Console.WriteLine("\nNumero de habitación:" + room.RoomNumber);
                Console.WriteLine("Tipo de habitación:" + room.Type);
                Console.WriteLine("Cliente asignado:"+ room.AssignedClient);

            }
        }
    }
}

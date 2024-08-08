using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class DeluxeRoom : Suite
    {
        public string ExtraServices { get; set; }
        public void AddRoom(ref List<DeluxeRoom> roomList)
        {
            string assignClient = ""; string newRoomType; double newPrice; bool newAvailable = true; string newCLient = "Libre"; int newBeds = 1; bool newSeaView = false; int newExtraRooms = 4; string newExtraServices = "Ninguno";

            Console.Clear();
            Console.WriteLine("Ingrese el numero de la nueva habitación:");
            int newRoomNumber = int.Parse(Console.ReadLine());
            DeluxeRoom searchRoom = roomList.Find(p => p.RoomNumber == newRoomNumber);
            if (searchRoom != null)
            {
                Console.WriteLine("La habitación ya fue registrada.");
            }
            else
            {
                Console.WriteLine("Ingrese el tipo de habitación");
                RoomMenu();
                int roomType = int.Parse(Console.ReadLine());
                switch (roomType)
                {
                    case 1:
                        Console.Clear();
                        newRoomType = "Básica."; newPrice = 100;
                        Console.WriteLine("Asignar un cliento (si/no)");
                        assignClient = Console.ReadLine().ToLower();
                        if (assignClient == "si")
                        {
                            Console.WriteLine("Ingrese el nombre del cliente:");
                            newCLient = Console.ReadLine();
                            newAvailable = false;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        newRoomType = "Doble."; newPrice = 200; newBeds = 2; newSeaView = true;
                        break;
                    case 3:
                        Console.Clear();
                        newRoomType = "Suite."; newPrice = 500; newBeds = 7; newSeaView = true;
                        break;
                    case 4:
                        Console.Clear();
                        newRoomType = "Suite Deluxe."; newPrice = 1000; newBeds = 10; newSeaView = true;
                        Console.WriteLine("¿Con qué servicios extras contará la habitación?");
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida."); break;
                        DeluxeRoom newRoom = new DeluxeRoom(newRoomNumber, newRoomType, newPrice, newAvailable, newCLient, newBeds, newSeaView, newExtraRooms, newExtraServices);
                        roomList.Add(newRoom);
                        Console.WriteLine("Habitación registrada, presione enter para continuar.");
                }
            }
        }
        public void Showinfo(ref List<DeluxeRoom> roomList)
        {
            foreach (DeluxeRoom room in roomList)
            {
                Console.Clear();
                Console.WriteLine("Número de habitación:" + room.RoomNumber);
                Console.WriteLine("Típo de habitación:" + room.Type);
                Console.WriteLine("Precio por noche: $" + room.NightPrice);
                Console.WriteLine("Disponibilidad:" + room.Available);
                Console.WriteLine("Cliente asignado:" + room.AssignedClient);
                Console.WriteLine("Camas:" + room.Beds);
                Console.WriteLine("Vista al mar:" + room.SeaView);
                Console.WriteLine("Instancias extra:" + room.ExtraRooms);
                Console.WriteLine("Servicios extra:" + room.ExtraServices);
                Console.WriteLine("");
            }
        }

        public void DeleteRoom(ref List<DeluxeRoom> roomList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de la habitación a eliminar:");
            int newRoomNumber = int.Parse(Console.ReadLine());
            DeluxeRoom searchRoom = roomList.Find(p => p.RoomNumber == newRoomNumber);
            if (searchRoom == null)
            {
                Console.WriteLine("La habitación no existe...");
            }
            else
            {
                roomList.Remove(searchRoom);
            }
        }
        public void Assign(ref List<DeluxeRoom> roomList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de la habitación a eliminar:");
            int newRoomNumber = int.Parse(Console.ReadLine());
            DeluxeRoom searchRoom = roomList.Find(p => p.RoomNumber == newRoomNumber);
            if (searchRoom == null)
            {
                Console.WriteLine("La habitación no existe.");
            }
            else
            {
                Console.WriteLine("Ingrese el nombre del cliente:");
                string assignCient = Console.ReadLine();
                searchRoom.AssignedClient = assignCient;
                searchRoom.Available = false;
            }
        }
        public void Free(ref List<DeluxeRoom> roomList)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de la habitación a liberar:");
            int newRoomNumber = int.Parse(Console.ReadLine());
            DeluxeRoom searchRoom = roomList.Find(p => p.RoomNumber == newRoomNumber);
            if (searchRoom == null)
            {
                Console.WriteLine("La habitación no existe.");
            }
            else
            {

                searchRoom.AssignedClient = "Libre";
                searchRoom.Available = true;
            }
        }
        public void RoomMenu()
        {
            Console.WriteLine("\n1. Habitación básica.");
            Console.WriteLine("2. Habitación doble.");
            Console.WriteLine("3. Suite.");
            Console.WriteLine("4. Suite deluxe.");
            Console.WriteLine("");
        }
        public DeluxeRoom(int roomNumber, string type, double nightPrice, bool available, string assignedClient, int beds, bool seaView, int extraRooms, string extraServices) : base(roomNumber, type, nightPrice, available, assignedClient, beds, seaView, extraRooms)
        {
            RoomNumber = roomNumber;
            Type = type;
            NightPrice = nightPrice;
            Available = available;
            AssignedClient = assignedClient;
            Beds = beds;
            SeaView = seaView;
            ExtraRooms = extraRooms;
            ExtraServices = extraServices;
        }
    }
}

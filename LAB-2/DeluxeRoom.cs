using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class DeluxeRoom:Suite
    {
        public string ExtraServices {  get; set; }

        public DeluxeRoom(int roomNumber, string nightPrice, bool available, string assignedClient, int beds, bool seaView, int extraRooms, string extraServices):base(roomNumber, nightPrice, available, assignedClient, beds, seaView,extraRooms)
        {
            RoomNumber = roomNumber;
            NightPrice = nightPrice;
            Available = available;
            AssignedClient = assignedClient;
            Beds = beds;
            SeaView = seaView;
            ExtraRooms = extraRooms;
            ExtraServices = extraServices;
        }


        public void AddRoom(ref List<DeluxeRoom> roomList)
        {

            Console.WriteLine("Ingrese el numero de la nueva habitación:");
            int newRoomNumber =int.Parse(Console.ReadLine());
            DeluxeRoom searchRoom = roomList.Find(p=>p.RoomNumber == newRoomNumber);
            if (searchRoom!=null )
            {
                
            }

        }
    }
}

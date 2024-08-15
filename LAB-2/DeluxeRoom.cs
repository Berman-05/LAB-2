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
        
        public DeluxeRoom(int roomNumber, string type, double nightPrice, bool available, string assignedClient, int beds, bool seaView, int extraRooms, string extraServices) : base(roomNumber, type, nightPrice, available, assignedClient, beds, seaView, extraRooms)
        {
            ExtraServices = extraServices;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public double NightPrice { get; set; }
        public bool Available { get; set; }
        public string AssignedClient {  get; set; }

        public Room(int roomNumber,string type, double nightPrice, bool available, string assignedClient)
        {
            RoomNumber = roomNumber;
            Type = type;
            NightPrice = nightPrice;
            Available = available;
            AssignedClient = assignedClient;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Suite:DoubleRoom
    {
        public int ExtraRooms { get; set; }

        public Suite(int roomNumber, string nightPrice, bool available, string assignedClient, int beds, bool seaView, int extraRooms): base(roomNumber, nightPrice, available, assignedClient, beds, seaView)
        {
            RoomNumber = roomNumber;
            NightPrice = nightPrice;
            Available = available;
            AssignedClient = assignedClient;
            Beds = beds;
            SeaView = seaView;
            ExtraRooms = extraRooms;
        }
    }
}

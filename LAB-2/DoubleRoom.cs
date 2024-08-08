using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class DoubleRoom: BasicRoom
    {
        public bool SeaView { get; set; }

        public DoubleRoom(int roomNumber, string nightPrice, bool available, string assignedClient, int beds, bool seaView): base(roomNumber, nightPrice, available, assignedClient,beds)
        {
            RoomNumber = roomNumber;
            NightPrice = nightPrice;
            Available = available;
            AssignedClient = assignedClient;
            Beds = beds;
            SeaView = seaView;
        }

    }

}

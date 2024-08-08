using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class BasicRoom:Room
    {
        public int Beds { get; set; }

        public BasicRoom(int roomNumber, string nightPrice, bool available, string assignedClient ,int beds) :base(roomNumber, nightPrice, available,assignedClient)
        {
            RoomNumber = roomNumber;
            NightPrice = nightPrice;
            Available = available;
            AssignedClient = assignedClient;
            Beds = beds;
        }
    }
}

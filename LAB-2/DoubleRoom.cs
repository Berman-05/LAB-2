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

        public DoubleRoom(int roomNumber,string type, double nightPrice, bool available, string assignedClient, int beds, bool seaView): base(roomNumber,type, nightPrice, available, assignedClient,beds)
        {
            SeaView = seaView;
        }

    }

}

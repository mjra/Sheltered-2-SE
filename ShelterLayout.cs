using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheltered_2_SE
{
    public class ShelterRoom
    {
        public string RoomType { get; set; }
        public string RoomMaterial { get; set; }
        public string PercentExcavated { get; set; }
        public string BypassRoomSpawn { get; set; }

        public static List<ShelterRoom>_shelterDesignerList;
    }


}

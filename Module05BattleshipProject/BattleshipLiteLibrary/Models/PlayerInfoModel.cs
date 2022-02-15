using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel
    {
        public string UsersName { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();
        
        //5x5 grid of all the shots they have done and could shoot
        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
    }
}

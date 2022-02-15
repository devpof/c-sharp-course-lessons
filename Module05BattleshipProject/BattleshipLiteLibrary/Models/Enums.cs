using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    /*
     * ENUM
     * Example: Status is int and the numbers represent each value
     * 0 = empty
     * 1 = ship (ShipLocation)
     * 2 = miss (Shotgrid)
     * 3 = hit (Shotgrid)
     * 4 = sunk (ShipLocation)
     * 
     * You can put it in another folder called Enums and create a file for each enums.
     * Design is up to you and what you prefer.
     * The instructor prefers to create an Enum class and add all enums in this class.
     * 
     * By default each enum you put contains a default value. It starts with 0 and increase by 1 for each.
     * We do not typically override it.
     * Example:
     * Empty = 5. This will override the Empty to be 5, 
     * if Ship has not assignment, Ship will contain number 6, Miss 7, Hit 8, Sunk 9
     * 
     * The only time you change the value is when there is a specific value for it. Example sound types.
     */
    public enum GridSpotStatus
    {
        Empty,
        Ship,
        Miss,
        Hit,
        Sunk
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Doda
{
    

    //enums
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        RoseWood,
        Veneer,
        Pine
    }
    public class Desk
    {
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;

        public decimal width { get; set; }
        public decimal depth { get; set; }
        public int numberOfDrawers { get; set; }
    }
}

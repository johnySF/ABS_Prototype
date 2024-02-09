using ABS_Prototype.Base;
using ABS_Prototype.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS_Prototype.Models
{
    internal class DrinkJuice : DrinkBase
    {
        public DrinkJuice () { }
        public JuiceFlavorEnum flavor;
        public CupTypeEnum cupType = CupTypeEnum.plastic;
        public CupSizeJuiceEnum cupSize;
    }
}

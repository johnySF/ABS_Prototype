using ABS_Prototype.Base;
using ABS_Prototype.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS_Prototype.Models
{
    internal class DrinkSoda : DrinkBase
    {
        public DrinkSoda() { }
        public SodaFlavorEnum flavor;
        public CupTypeEnum cupType = CupTypeEnum.paper;
        public CupSizeSodaEnum cupSize;
    }
}

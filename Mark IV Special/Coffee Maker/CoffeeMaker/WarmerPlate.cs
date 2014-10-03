using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class WarmerPlate
    {
        private IWarmerPlate _hardware;

        public WarmerPlate(IWarmerPlate hardware)
        {
            this._hardware = hardware;
        }
    }
}

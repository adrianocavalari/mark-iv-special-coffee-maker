using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class BrewButton
    {
        private IBrewButton _hardware;

        public BrewButton(IBrewButton hardware)
        {
            this._hardware = hardware;
        }
    }
}

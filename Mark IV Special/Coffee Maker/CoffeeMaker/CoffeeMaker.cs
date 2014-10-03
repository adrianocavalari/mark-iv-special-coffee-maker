using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class CoffeeMaker
    {
        private Boiler _boiler;
        private BrewButton _brewButton;
        private IndicatorLight _indicatorLight;
        private ReliefValve _pressureValve;
        private WarmerPlate _warmerPlate;
        private ICoffeeMakerAPI _hardware;

        public CoffeeMaker(ICoffeeMakerAPI hardware)
        {
            this._hardware = hardware;
            this._boiler = new Boiler(hardware);
            this._brewButton = new BrewButton(hardware);
            this._indicatorLight = new IndicatorLight(hardware);
            this._pressureValve = new ReliefValve(hardware);
            this._warmerPlate = new WarmerPlate(hardware);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public interface ICoffeeMakerAPI
    {
        /**
        * This function returns the status of the warmer-plate
        * sensor. This sensor detects the presence of the pot
        * and whether it has coffee in it.
        */
        Constants.WarmerState GetWarmerPlateStatus();

        /**
        * This function returns the status of the boiler switch.
        * The boiler switch is a float switch that detects if
        * there is more than 1/2 cup of water in the boiler.
        */
        Constants.BoilerState GetBoilerStatus();

        /**
        * This function returns the status of the brew button.
        * The brew button is a momentary switch that remembers
        * its state. Each call to this function returns the
        * remembered state and then resets that state to
        * BREW_BUTTON_NOT_PUSHED.
        *
        * Thus, even if this function is polled at a very slow
        * rate, it will still detect when the brew button is
        * pushed.
        */
        Constants.BrewButtonState GetBrewButtonStatus();

        /**
        * This function turns the heating element in the boiler
        * on or off.
        */
        void SetBoilerState(Constants.BoilerState boilerStatus);

        /**
        * This function turns the heating element in the warmer
        * plate on or off.
        */
        void SetWarmerState(Constants.WarmerState warmerState);

        /**
        * This function turns the indicator light on or off.
        * The indicator light should be turned on at the end
        * of the brewing cycle. It should be turned off when
        * the user presses the brew button.
        */
        void SetIndicatorState(Constants.IndicatorState indicatorState);

        /**
        * This function opens and closes the pressure-relief
        * valve. When this valve is closed, steam pressure in
        * the boiler will force hot water to spray out over
        * the coffee filter. When the valve is open, the steam
        * in the boiler escapes into the environment, and the
        * water in the boiler will not spray out over the filter.
        */
        void SetReliefValveState(Constants.ReliefValveState reliefValveState);
    }

    public static class Constants
    {
        public enum BrewButtonState
        {
            BREW_BUTTON_PUSHED = 0,
            BREW_BUTTON_NOT_PUSHED
        }

        public enum BoilerState
        {
            BOILER_ON = 0,
            BOILER_OFF
        }

        public enum WarmerState
        {
            WARMER_ON = 0,
            WARMER_OFF
        }

        public enum IndicatorState
        {
            INDICATOR_ON = 0,
            INDICATOR_OFF
        }

        public enum ReliefValveState
        {
            VALVE_OPEN = 0,
            VALVE_CLOSED
        }
    }
}

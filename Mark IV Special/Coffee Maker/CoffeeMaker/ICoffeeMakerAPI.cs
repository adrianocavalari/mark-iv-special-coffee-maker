﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public interface ICoffeeMakerAPI : IBoiler, IBrewButton, IIndicatorLight, IReliefValve, IWarmerPlate
    {
    }

    public interface IBoiler
    {
        /**
        * This function returns the status of the boiler switch.
        * The boiler switch is a float switch that detects if
        * there is more than 1/2 cup of water in the boiler.
        */
        BoilerStatus GetBoilerStatus();

        /**
        * This function turns the heating element in the boiler
        * on or off.
        */
        void SetBoilerState(BoilerState boilerState);
    }

    public interface IBrewButton
    {
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
        BrewButtonStatus GetBrewButtonStatus();
    }

    public interface IIndicatorLight
    {
        /**
        * This function turns the indicator light on or off.
        * The indicator light should be turned on at the end
        * of the brewing cycle. It should be turned off when
        * the user presses the brew button.
        */
        void SetIndicatorState(IndicatorState indicatorState);
    }

    public interface IReliefValve
    {
        /**
                * This function opens and closes the pressure-relief
                * valve. When this valve is closed, steam pressure in
                * the boiler will force hot water to spray out over
                * the coffee filter. When the valve is open, the steam
                * in the boiler escapes into the environment, and the
                * water in the boiler will not spray out over the filter.
                */
        void SetReliefValveState(ReliefValveState reliefValveState);
    }

    public interface IWarmerPlate
    {
        /**
        * This function returns the status of the warmer-plate
        * sensor. This sensor detects the presence of the pot
        * and whether it has coffee in it.
        */
        WarmerStatus GetWarmerPlateStatus();

        /**
        * This function turns the heating element in the warmer
        * plate on or off.
        */
        void SetWarmerState(WarmerState warmerState);
    }

    public enum BrewButtonStatus
    {
        BREW_BUTTON_PUSHED = 0,
        BREW_BUTTON_NOT_PUSHED
    }

    public enum BoilerStatus
    {
        BOILER_EMPTY = 0,
        BOILER_NOT_EMPTY
    }

    public enum BoilerState
    {
        BOILER_ON = 0,
        BOILER_OFF
    }

    public enum WarmerStatus
    {
        WARMER_EMPTY = 0,
        POT_EMPTY,
        POT_NOT_EMPTY
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

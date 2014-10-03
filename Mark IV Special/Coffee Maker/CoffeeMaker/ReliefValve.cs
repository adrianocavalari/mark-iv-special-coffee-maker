using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class ReliefValve
    {
        private IReliefValve _hardware;

        public ReliefValve(IReliefValve hardware)
        {
            this._hardware = hardware;
        }
    }
}

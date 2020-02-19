using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Chp_282pg_Base_sub_classes
{
    class Bee
    {
        const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        public Bee(double weightMg) { WeightMg = weightMg; }

        virtual public double HoneyConsumptionRate() { return WeightMg * HoneyUnitsConsumedPerMg; }

    }
}

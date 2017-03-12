using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Bulletlogic
{
    public class VehicleTelemetry
    {
        private TelemetryValue<int> stage;
        private TelemetryValue<float> trueAirspeed;
        private TelemetryValue<float> metersAboveSeaLevel;
    }
}

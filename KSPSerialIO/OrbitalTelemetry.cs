using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Bulletlogic
{
    public class OrbitalTelemetry
    {
        private TelemetryValue<float> eccentricity;
        private TelemetryValue<float> semiMajorAxis;
        private TelemetryValue<float> inclination;
        private TelemetryValue<float> ascendingNodeLongitude;
        private TelemetryValue<float> periapsis;
        private TelemetryValue<float> trueAnomaly;
    }
}

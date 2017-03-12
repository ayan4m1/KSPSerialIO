using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Bulletlogic
{
    class TelemetryValue<T>
    {
        private T val;

        public T Value { get; set; }
    }
}

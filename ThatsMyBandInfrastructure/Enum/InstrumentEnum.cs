using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Enum en multiple binaire car un musicien peut maîtriser plusieurs instruments
    /// </summary>
    public enum InstrumentEnum
    {
        None = 0,
        Vocals = 2,
        Drums = 4,
        Guitar = 8,
        Bass = 16
    }
}

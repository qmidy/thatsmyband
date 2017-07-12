using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThatsMyBandInfrastructure;

namespace ThatsMyBand.Models
{
    public class BandModel
    {
        #region Public Properties

        private Band _band;
        public Band Band
        {
            get
            {
                return _band;
            }
            set
            {
                if (value != _band)
                    _band = value;
            }
        }

        #endregion
    }
}
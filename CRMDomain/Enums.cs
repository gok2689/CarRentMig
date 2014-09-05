using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    #region Vehicle
    public enum VehicleStatus
    {
        [Description("Uygun")]
        Available =1,
        [Description("Uygun değil")]
        NonAvailable =2,
    }

    public enum FuelType
    {
        Benzin=1,
        Motorin=2,
        LPG=3,
        Dizel=4
    }
    #endregion


    #region Member
    public enum MemeberType
    {
        Admin=1,
        User=0
    }
    #endregion
}

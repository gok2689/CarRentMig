using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    public class Branch : TableEntity, ITableEntity
    {

        //----ForeignKeys--------

        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public Branch()
        {
            Vehicles = new HashSet<Vehicle>();

        }
    }
}

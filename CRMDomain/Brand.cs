using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    public class Brand : TableEntity, ITableEntity
    {

        public string Name { get; set; }


        //----ForeignKeys--------

        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public Brand()
        {
            Vehicles = new HashSet<Vehicle>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    public class Event : TableEntity, ITableEntity
    {
        public int MemberId { get; set; }
        public int VehicleId { get; set; }

        [Display(Name = "Başlangıç tarihi")]
        [DataType(DataType.DateTime)]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        [DataType(DataType.DateTime)]

        public System.DateTime EndDate { get; set; }
    }
}

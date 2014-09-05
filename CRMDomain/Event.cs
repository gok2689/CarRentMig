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
        [Display(Name="Kullanıcı")]
        [UIHint(CRMUIHints.DropDownList)]
        public int MemberId { get; set; }
        
        [Display(Name="Araç")]
        [UIHint(CRMUIHints.DropDownList)]
        public int VehicleId { get; set; }
        
        [UIHint(CRMUIHints.DateTime)]
        [Display(Name = "Başlangıç tarihi")]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        [UIHint(CRMUIHints.DateTime)]
        public System.DateTime EndDate { get; set; }
    }
}

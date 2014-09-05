using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    public class Vehicle : TableEntity, ITableEntity
    {
        [UIHint(CRMUIHints.Comment)]
        [Display(Name = "Plaka")]
        public string Plate { get; set; }
        [Display(Name = "Marka")]
        [UIHint(CRMUIHints.DropDownList)]
        public int BrandId { get; set; }
        [Display(Name="Model")]
        [UIHint(CRMUIHints.Comment)]
        public string Model { get; set; }
        [Display(Name = "Yakıt tipi")]
        [UIHint(CRMUIHints.Enum)]
        public FuelType FuelType { get; set; }
        [Display(Name = "Şube")]
        [UIHint(CRMUIHints.DropDownList)]
        public int BranchId { get; set; }
        [Display(Name = "Günlük kiralama bedeli")]
        [UIHint(CRMUIHints.Currency)]
        public decimal PricePerDay { get; set; }
        [Display(Name="Durum")]
        [UIHint(CRMUIHints.Enum)]
        public VehicleStatus Status { get; set; }


        //----ForeignKeys--------

        public virtual Brand Brand { get; set; }
        public virtual Branch Branch { get; set; }
        public ICollection<Event>  Events { get; set; }

        public Vehicle()
        {
            Events = new HashSet<Event>();
        }

    }
}

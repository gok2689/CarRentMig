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
        [Display(Name = "Plaka")]
        public string Plate { get; set; }
        [Display(Name = "Marka")]
        public int BrandId { get; set; }
        public string Model { get; set; }
        [Display(Name = "Yakıt tipi")]
        public string FuelType { get; set; }
        [Display(Name = "Şube")]
        public int BranchId { get; set; }
        [Display(Name = "Günlük kiralama bedeli")]
        public decimal PricePerDay { get; set; }
        public bool IsReserved { get; set; }

    }
}

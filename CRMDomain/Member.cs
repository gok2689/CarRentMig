using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDomain
{
    public class Member : TableEntity, ITableEntity
    {
        [Display(Name = "Ad Soyad")]
        public string NameSurName { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen bir email giriniz")]
        [EmailAddress]
        public string Email { get; set; }
        public int Type { get; set; }
    }
}

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
        [Required(ErrorMessage="Lütfen bir Ad Soyad giriniz")]
        [UIHint(CRMUIHints.Comment)]
        public string NameSurName { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre giriniz")]
        [Display(Name="Şifre")]
        [UIHint(CRMUIHints.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen bir email giriniz")]
        [UIHint(CRMUIHints.Email)]
        public string Email { get; set; }
        [Display(Name="Kullanıcı Tipi")]
        [UIHint(CRMUIHints.Enum)]
        public MemeberType Type { get; set; }
    }
}

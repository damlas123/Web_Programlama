using System.ComponentModel.DataAnnotations;

namespace Hafta7.Models
{
    public class User
    {
        [Display (Name ="Kullanıcı Adı")]
        public string username { get; set; }
        [Display(Name ="Parola")]
        public string password { get; set; }
        [Display (Name ="Renk Seçimi")]
        public string usercolorsettings { get; set; }

    }
}

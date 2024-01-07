using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KullaniciManager
    {

        public bool KullaniciEkle(string ad,string tel,string email)
        {
            //İş kurallarım mevcut çeşitli durumları göre false veya true döner eğer hepsi uyuyorsa true geçer
            //veritabanına kaydetmek için iş katmanından geçmeli

            if (ad.Length < 4) return false;
            if (!Regex.IsMatch(tel, "[0-9]")) return false;
            if (!email.Contains("@")) return false;

            return true;

        }


    }
}

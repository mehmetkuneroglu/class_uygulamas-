using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_uygulaması
{
    public class Cari
    {
        public string ad;
        public string soyad;
        public string tel;
        public string il;
        public string ilçe;
        public string adres;


    }
    public class Personel : Cari 
    {
        public string tc;
        public string email;
        public double maas;
        public DateTime dogumTarihi;
        public DateTime iseBaslamaTarihi;
        public DateTime istenAyrilmaTarihi; 
    }
    public class Musteri :Cari
    {
        public double alacak;
        
    }
    public class Tedarikci :Cari
    {
        public string ticariUnvan;
        public string website;
        public string email;
        public double borc;
        public string vd;
        public string vno;
    }
}

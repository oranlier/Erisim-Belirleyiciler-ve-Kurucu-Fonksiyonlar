using System;

namespace Sınıf_Nedir__Instance__Field__Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******1. çalışan*****************");
            Calisan calisan1 = new Calisan("Ayşe","Kara", 8459625, "İnsan Kaynakları");
            calisan1.calisanBilgileri();

            Console.WriteLine("*******2. çalışan*****************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Burak";
            calisan2.SoyAd="Yılmaz";
            calisan2.no=12345678;
            calisan2.departman="Satınalma";
            calisan2.calisanBilgileri();
            Console.WriteLine("***************");

            Console.WriteLine("*******3. çalışan*****************");
            Calisan calisan3 = new Calisan("Mehmet","Sozmez");
            calisan3.calisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int no;
        public string departman;
        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", SoyAd);
            Console.WriteLine("Çalışanın No: {0}", no);
            Console.WriteLine("Çalışanın Departmanı: {0}", departman);

        }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad=ad;
            this.SoyAd=soyad;
            this.no=no;
            this.departman=departman;
        }
        public Calisan(){}//kurucu metotlar overload edilebilir
        public Calisan(string ad, string soyad)//kurucu metotlar overload edilebilir
        {
            this.Ad=ad;
            this.SoyAd=soyad;
        }

    }
}

using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collectin.Generic
            //T=> OBJECT türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(13);
            sayiListesi.Add(26);
            sayiListesi.Add(39);
            sayiListesi.Add(52);
            sayiListesi.Add(65);
            sayiListesi.Add(7);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("mavi");
            renkListesi.Add("yeşil");
            renkListesi.Add("mor");
            renkListesi.Add("kırmızı");
            renkListesi.Add("turuncu");

            //count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // foreach ve list foreach

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
            //listeden eleman çıkarma
            sayiListesi.Remove(26);
            renkListesi.Remove("mor");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

             sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
             renkListesi.ForEach(renk=> Console.WriteLine(renk));
            // liste içinde arama yapma 

             if (sayiListesi.Contains(39))
                 Console.WriteLine("39 listede mevcuttur.");

            //eleman ile index'e erişme

            Console.WriteLine(renkListesi.BinarySearch("turuncu"));
            Console.WriteLine(sayiListesi.BinarySearch(39));
            

            // Dizi'yi List'e çevirme

            string[] hayvanlar = {"kedi","köpek","fil","inek"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanListesi.Clear();

            //liste içerisinde nesne tutmak
            List<Kulanıcılar> kullanıcıListesi = new List<Kulanıcılar>();
            Kulanıcılar kullanıcı1 = new Kulanıcılar();
            kullanıcı1.Isim = "Batuhan";
            kullanıcı1.Soyİsim = "ALTINEL";
            kullanıcı1.Yas = 29;

            Kulanıcılar kullanıcı2 = new Kulanıcılar();
            kullanıcı2.Isim ="Kamil";
            kullanıcı2.Soyİsim="Deli";
            kullanıcı2.Yas=60;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kulanıcılar> yeniListe = new List<Kulanıcılar>();
            yeniListe.Add(new Kulanıcılar(){
                Isim="Kim",
                Soyİsim="Bu",
                Yas=23   
            });

            foreach (Kulanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+ kullanıcı.Soyİsim);
                Console.WriteLine("Kullanıcı Yaşı: "+ kullanıcı.Yas);
            }

            kullanıcıListesi.Clear();

        }
    }

    public class Kulanıcılar{
        private string isim;
        private string soyİsim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}

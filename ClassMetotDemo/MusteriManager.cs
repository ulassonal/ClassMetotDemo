using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            
            Console.WriteLine("Müşteri ID : "+musteri.Id);
            Console.WriteLine("Müşteri Adı : " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Müşteri Doğum Tarihi : " + musteri.DogumTarihi);
            Console.WriteLine("Müşteri Eklendi.");

        }

        internal void Ekle()
        {
            throw new NotImplementedException();
        }
        public void Listeleme(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri ID : " + musteri.Id);
            Console.WriteLine("Müşteri Adı : " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Müşteri Doğum Tarihi : " + musteri.DogumTarihi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Silinmek İstenen Müşteri Adı :");
            Console.ReadLine();
            Console.WriteLine("Silinen Müşteri : "+musteri.Adi);
        }

        internal void Listeleme()
        {
            throw new NotImplementedException();
        }
    }
}

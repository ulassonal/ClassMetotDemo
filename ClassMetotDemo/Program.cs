
using ClassMetotDemo;

Musteri musteri1=new Musteri();
musteri1.Id = "1";
musteri1.Adi = "Ali";
musteri1.Soyadi = "Düz";
musteri1.DogumTarihi ="12/05/1998";

Musteri musteri2=new Musteri();
musteri2.Id = "2";
musteri2.Adi = "Mehmet";
musteri2.Soyadi = "Sarı";
musteri2.DogumTarihi = "02/08/1995";


MusteriManager musterimanager=new MusteriManager();
musterimanager.Ekle(musteri1);
Console.WriteLine("------------------------------------");

musterimanager.Ekle(musteri2);

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Müşteriler : ");
musterimanager.Listeleme(musteri1);
Console.WriteLine();
musterimanager.Listeleme(musteri2);

Console.WriteLine("---------------------------------------------------------------");

musterimanager.Silme(musteri1);



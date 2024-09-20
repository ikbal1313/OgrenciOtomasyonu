// ÖĞRENCİ KAYIT OTOMASYONU
//------------------------
// 1-Öğrenci Ekle
// 2- Öğrencileri Listele
// 3- Öğrencileri sil
// 4- Öğrencilerin Genel Not Ortalaması
// 5- Öğrencilerin Genel Yaş Ortalaması
// 6- Toplam Öğrenci Sayısı
// 0- Çıkış

using _170924_3;

ConsoleKey cevap;



do
{
    Console.Clear();
    Console.WriteLine("Öğrenci Kayıt Otomasyonu");
    Console.WriteLine("-----------------");
    Console.WriteLine("1-Öğrenci Ekle");
    Console.WriteLine("2- Öğrencileri Listele");
    Console.WriteLine("3- Öğrencileri sil");
    Console.WriteLine("4- Öğrencilerin Genel Not Ortalaması");
    Console.WriteLine("5- Öğrencilerin Genel Yaş Ortalaması");
    Console.WriteLine("6- Toplam Öğrenci Sayısı");
    Console.WriteLine("0- Çıkış");
    Console.Write("Hangi işlemi yapmak istersiniz?");
    cevap = Console.ReadKey().Key;
    Menu.Islemler(cevap);
    
} while (cevap !=ConsoleKey.NumPad0 && cevap != ConsoleKey.D0);


Console.Clear();
Console.WriteLine("Programı kapatmak için bir tuşa basınız");
Console.WriteLine("Hadi yallah..");
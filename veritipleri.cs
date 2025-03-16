namespace MerhabaDunya;

public class veritipleri
{
    public static void veritipi()
    {
        //Veri Tipleri
        int sayi = 10;	    //Tam sayı (32 bit)
        double pi = 3.14;	//Ondalıklı sayı (64 bit)
        float e = 3.14f;	//Küçük ondalıklı sayı (32 bit)
        char harf = 'A';	//Tek karakter
        string ad = "Elif";	//Metin verisi
        bool durum = true;	//Doğru/Yanlış
        var i = 5;	        //Türü otomatik belirler
            
        //Tamsayı & Ondalıklı Sayılar
        int yas = 23;
        double sicaklik = 36.5;
        float agirlik = 55.7f;  // Sonuna 'f' eklenmeli!
            
        //Karakter & String Kullanımı
        char harfim = 'E';
        string isim = "Elifcik";
            
        //Boolean Kullanımı
        bool ogrenciMi = true;
        bool kodlamaSeviyorMu = false;
			
        //Var kullanımı
        var sehir = "İstanbul";  // string olur
        var yil = 23;            // int olur

    }
}
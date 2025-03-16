namespace MerhabaDunya;

public class genelkavramlar
{
    public static void genelkavram()
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
            
            //*
            //Operatörler
            //+	int toplam = a + b;	Toplama
            // -	int fark = a - b;	Çıkarma
            // *	int carpim = a * b;	Çarpma
            // /	int bolum = a / b;	Bölme
            // %	int kalan = a % b;	Mod (Kalanı bulma)
            // *//
            
            int a = 10;
            int b = 3;
            Console.WriteLine(a + b);  // 13
            Console.WriteLine(a - b);  // 7
            Console.WriteLine(a * b);  // 30
            Console.WriteLine(a / b);  // 3
            Console.WriteLine(a % b);  // 1
            
            //*
            //Karşılaştırma Operatörleri
            //==	a == b	Eşit mi?
            // !=	a != b	Eşit değil mi?
            // >	a > b	Büyük mü?
            // <	a < b	Küçük mü?
            // >=	a >= b	Büyük veya eşit mi?
            // <=	a <= b	Küçük veya eşit mi?
            //  Karşılaştırma operatörleri true veya false döndürür ve genellikle koşul ifadelerinde (if blokları) kullanılır.*//
            
            int x = 5;
            int y = 10;

            Console.WriteLine(x == y);  // false
            Console.WriteLine(x != y);  // true
            Console.WriteLine(x > y);   // false
            Console.WriteLine(x < y);   // true
            
            //*
            //Mantıksal Operatörler
            //&&	a > 5 && b < 10	VE (AND) – İki koşul da doğruysa true
            // `		`
            // !	!(a > 5)	DEĞİL (NOT) – Sonucu tersine çevirir
            // Özet:
            // && (AND) → Her iki koşul da sağlanmalı
            // || (OR) → Koşullardan biri bile sağlansa yeterli
            // ! (NOT) → Sonucu tersine çevirir
            // *//
            
            bool sonuc1 = (5 > 3) && (10 > 8);  // true
            bool sonuc2 = (5 > 3) || (10 < 8);  // true
            bool sonuc3 = !(5 > 3);  // false
            
            //*
            //Atama Operatörleri
            //=	a = 10;	Atama
            // +=	a += 5;	a = a + 5;
            // -=	a -= 5;	a = a - 5;
            // *=	a *= 5;	a = a * 5;
            // /=	a /= 5;	a = a / 5;
            // %=	a %= 5;	a = a % 5;
            // *//
            
            int say = 10;
            say += 5;  // 15 olur
            say -= 2;  // 13 olur
            say *= 3;  // 39 olur
            say /= 3;  // 13 olur
            say %= 2;  // 1 olur
            
            //*
            //Karar Yapıları Nedir?
            // 📌 Programın, belirli bir duruma göre farklı yollar izlemesini sağlar.
            // 
            // ✅ if – Eğer bir koşul sağlanıyorsa çalışır.
            // ✅ else – Eğer yukarıdaki koşul sağlanmazsa çalışır.
            // ✅ else if – Birden fazla durum kontrol etmek için kullanılır.
            // ✅ switch – Çok sayıda olasılığı yönetmek için daha temiz bir yöntemdir.
            // 
            // 1 - if - else Yapısı
            // 📌 Mantık:
            // 
            // Eğer koşul sağlanıyorsa, {} içindeki kod çalışır.
            // Eğer sağlanmıyorsa, else bloğundaki kod çalışır.
            //
            // 2 - if - else if - else Yapısı
            // 📌 Mantık:
            // 
            // Birden fazla koşul kontrol etmek için kullanılır.
            // Eğer ilk koşul sağlanmazsa, ikinci koşula bakılır.
            //
            // 3 - switch Yapısı
            // 📌 Mantık:
            // 
            // Çok sayıda durum varsa, switch ile daha temiz kod yazabiliriz.
            // case ifadeleri ile seçenekleri tanımlarız.
            // break; komutu, işlem bitince kodun diğer seçeneklere bakmasını engeller.*//

            int age = 24;
            if (yas >= 25)
            {
	            Console.WriteLine("ehliyet alabilirsiniz.");
            }
            else
            {
	            Console.WriteLine("ehliyet alamazsınız.");
            }
            {
	            
            }
			
            int not = 75;

            if (not >= 85)
            {
	            Console.WriteLine("Pekiyi");
            }
            else if (not >= 70)
            {
	            Console.WriteLine("İyi");
            }
            else
            {
	            Console.WriteLine("Geçti");
            }
            
            int gun = 3;

            switch (gun)
            {
	            case 1:
		            Console.WriteLine("Pazartesi");
		            break;
	            case 2:
		            Console.WriteLine("Salı");
		            break;
	            case 3:
		            Console.WriteLine("Çarşamba");
		            break;
	            default:
		            Console.WriteLine("Geçersiz gün");
		            break;
            }
            
            //Bir kişinin yaşına göre "Çocuk" (0-12), "Genç" (13-18) ve "Yetişkin" (18+) yazdıran bir if-else yapısı yazar mısın?

            int yasim = 25;
            if (yasim<=12)
            {
	            Console.WriteLine("Çocuk");
            }
            else if (yasim <=18)
            {
	            Console.WriteLine("Genç");
            }
            else
            {
	            Console.WriteLine("Yetişkin");
            }

            
            








    }
}
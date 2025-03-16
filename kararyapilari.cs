namespace MerhabaDunya;

public class kararyapilari
{
    public static void kararkontrolleri()
    {
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
            if (age >= 25)
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
using System.Diagnostics;

namespace MerhabaDunya;

public class Operatorler
{
    public static void Prime()
    {
        int sayi = 23;
        bool asalMi = true;
        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                asalMi = false;
            }
        }
        // if asalmi=true is true if asalmi=false is false
        if (asalMi==true)
        {
            Console.WriteLine("ASALDIR");
        }
        else if (asalMi==false)
        {
            Console.WriteLine("ASAL DEĞİLDİR");
        }
    }

    public static void Multiply()
    {
        Console.WriteLine("Bir sayı giriniz");
        int sayi=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sayi%3==0 && sayi%5==0);
    }
    public static void Faktoriyel()
    {
        Console.WriteLine("bir sayı giriniz");
        int sayi=Convert.ToInt32(Console.ReadLine());

        long sonuc = 1;
        for (int i = 2; i <= sayi; i++)
        {
            sonuc = sonuc * i;
        }
        Console.WriteLine(sonuc);
    }

    public static void Islemler()
    {
        //Hesap Makinesi
        Console.WriteLine("Birinci sayı:");
        int birinci = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yapılacak işlem:");
        char islem = Console.ReadKey().KeyChar;
        Console.WriteLine("\nİkinci sayı:");
        int ikinci = Convert.ToInt32(Console.ReadLine());

        switch(islem)
        {
            case '+':
                Console.WriteLine(birinci+ikinci);
                break;
            case '-':
                Console.WriteLine(birinci-ikinci);
                break;
            case '*':
                Console.WriteLine(birinci*ikinci);
                break;
            case '/':
                Console.WriteLine(birinci/ikinci);
                break;
            default:
                Console.WriteLine("adamakılllı sayı gir lan!!!");
                break;
            
        }
        

        // Aritmetik Operatörler
        /*
        int a = 10;
        int b = 3;
        Console.WriteLine(a + b);  // 13
        Console.WriteLine(a - b);  // 7
        Console.WriteLine(a * b);  // 30
        Console.WriteLine(a / b);  // 3
        Console.WriteLine(a % b);  // 1

        // Karşılaştırma Operatörleri
        int x = 5;
        int y = 10;
        Console.WriteLine(x == y);  // false
        Console.WriteLine(x != y);  // true
        Console.WriteLine(x > y);   // false
        Console.WriteLine(x < y);   // true

        // Mantıksal Operatörler
        bool sonuc1 = (5 > 3) && (10 > 8);  // true
        bool sonuc2 = (5 > 3) || (10 < 8);  // true
        bool sonuc3 = !(5 > 3);  // false
        Console.WriteLine(sonuc1);
        Console.WriteLine(sonuc2);
        Console.WriteLine(sonuc3);

        // Atama Operatörleri
        int sayi = 10;
        sayi += 5;  // 15
        sayi -= 2;  // 13
        sayi *= 3;  // 39
        sayi /= 3;  // 13
        sayi %= 2;  // 1
        Console.WriteLine(sayi);
    }
}

*/
    }
}
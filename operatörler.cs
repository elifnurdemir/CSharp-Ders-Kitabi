namespace MerhabaDunya;

public class Operatorler
{
    public static void Islemler()
    {
        // Aritmetik Operatörler
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

class Program
{
    static void Main()
    {
        Operatorler.Islemler();  // Metodu çağırdık
    }
}
namespace MerhabaDunya;

public class giris
{
    public static void girdim()
    {
        Console.WriteLine("Hello, World!!!");
Console.Read();
 //* girdi komutları: Console.Read() , Console.ReadKey() , Console.Readline();

 //Console.Read():
 //-Kullanıcıdan tek bir karakter almak için kullanılır.
 //-Girilen karakterin kendisi değil ASCII kodu int veri tipinde tutulur.*//
 
 Console.WriteLine("Bir karakter giriniz:");
 int ch=Console.Read();
 Console.WriteLine("Girdiğiniz karakterin ASCII kodu: {0}", ch);
 
 //*Girilen karakterin ASCII kodunu değil de karakterin kendisini ekrana çıktılamak için int veri tipinde tutulan kullanıcı girdisi
 // Convert.ToChar() metoduyla char veri tipine çevrilmelidir.*//
 
 
Console.WriteLine("Bir karakter giriniz:");
 char ch2 =Convert.ToChar(Console.Read());
 Console.WriteLine("Girdiğiniz karakter:{0}",ch2);

//*Console.ReadKey()
//--Kullanıcıdan bir tuş verisi almak için kullanılır.
//--Genellikle programın yapacağı işler bittikten sonra programı sonlandırmak
// için kullanıcıdan bir tuşa basması istenir. Bu amaçla Console.ReadKey() metodu kullanılır.*//

Console.WriteLine("Bir Tuşa Basınız:");
ConsoleKeyInfo tus = Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Basılan tuş:"+tus.KeyChar);
Console.WriteLine("Programdan çıkmak için tuşa basın");
Console.ReadKey();

//*Console.ReadLine()
//--Kullanıcı Enter tuşuna basana kadar yazmış olduğu her şeyi alır ve string veri tipinde tutar.
//--Kullanıcıdan çok karakterli metin
// ve sayı istemek için genellikle Console.ReadLine() metodu kullanılır.*//

Console.WriteLine("Bir metin giriniz:");
string metin = Console.ReadLine();
Console.WriteLine("Girdiğiniz metin:{0}",metin);

//Console.ReadLine() metodu kullanıcı girdisini string veri tipinde tuttuğundan kullanıcıdan sayı girmesi istendiğinde girilen
// veri Convert metodu veya diğer veri tipi dönüşüm yöntemlerini kullanarak nümerik veri tiplerinden birine çevrilmelidir

//Aşağıda kullanıcıdan tam sayı girmesi istenmiş, Console.ReadLine() metoduyla alınan girdi Convert.ToInt32() metoduyla tam
//sayı (int) veri tipine çevrilmiş ve ekrana sayının karesi çıktılanmıştır.

 Console.WriteLine("Bir tam sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girdiğiniz sayının karesi: {0}", sayi * sayi);


    }
}
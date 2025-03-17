namespace MerhabaDunya;

public class genelkavramlar
{
    public static void genelkavram()
    {
        //Kullanıcıdan Girdi Alma
        Console.WriteLine("Adınızı Girin:");
        string isim = Console.ReadLine();
        Console.WriteLine("Yaşınızı Girin:");
        int yas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Merhaba,{isim}! Yaşınız: {yas}");
        //*
        //C# dilindeki anahtar kelimeler, programlama sırasında belirli işlevleri yerine getirmek için kullanılan ve dilin söz diziminde özel anlamı olan kelimelerdir. İşte C#'ta kullanılan anahtar kelimeler ve kısa açıklamaları:

        // Erişim Belirleyicileri (Access Modifiers)
        // private: Sadece tanımlandığı sınıf içinde erişilebilir.
        // protected: Tanımlandığı sınıf ve ondan türetilen sınıflar tarafından erişilebilir.
        // public: Her yerden erişilebilir.
        // internal: Aynı assembly (derleme) içindeki sınıflar tarafından erişilebilir.
        // protected internal: Hem türetilen sınıflar hem de aynı assembly içindeki sınıflar erişebilir.

        // Veri Türleri (Data Types)
        // bool: Doğru (true) veya yanlış (false) değerlerini tutar.
        // byte: 8 bitlik işaretsiz tam sayı (0 ile 255 arasında).
        // char: Tek bir karakteri tutar ('A', '1', vb.).
        // decimal: Hassasiyet gerektiren ondalıklı sayılar için kullanılır (finansal işlemler gibi).
        // double: Ondalıklı sayılar için kullanılır (64 bit).
        // float: Daha düşük hassasiyete sahip ondalıklı sayılar için kullanılır (32 bit).
        // int: 32 bitlik tam sayı.
        // long: 64 bitlik tam sayı.
        // sbyte: 8 bitlik işaretli tam sayı (-128 ile 127 arasında).
        // short: 16 bitlik tam sayı.
        // string: Metin ifadeleri tutar.
        // uint: 32 bitlik işaretsiz tam sayı (0 ve pozitif değerler).
        // ulong: 64 bitlik işaretsiz tam sayı.
        // ushort: 16 bitlik işaretsiz tam sayı.
        // object: Tüm veri türlerinin temel aldığı tür.
        // null: Bir değişkenin herhangi bir nesneye işaret etmediğini belirtir.
        // true / false: bool veri tipinin alabileceği iki değeri ifade eder.

        // Kontrol Yapıları (Control Statements)
        // if: Koşullu ifadeler için kullanılır.
        // else: if bloğu sağlanmazsa çalışacak alternatif kod bloğu.
        // switch: Bir değişkenin farklı değerlere göre farklı işlemler yapmasını sağlar.
        // case: switch içinde belirli bir değeri kontrol etmek için kullanılır.
        // default: switch içinde hiçbir case koşulu sağlanmazsa çalışır.
        // for: Sayaç bazlı döngü oluşturur.
        // foreach: Koleksiyon veya diziler üzerinde döngü kurar.
        // while: Belirtilen koşul true olduğu sürece döngü devam eder.
        // do: while gibi çalışır, ancak döngü bloğunu en az bir kez çalıştırır.
        // break: Döngüyü sonlandırır.
        // continue: Döngünün o anki yinelemesini atlayıp devam eder.
        // goto: Belirli bir kod satırına doğrudan atlamayı sağlar (genellikle önerilmez).
        // return: Bir metottan çıkışı sağlar ve varsa bir değer döndürür.
        // throw: Hata fırlatmak için kullanılır (exception handling).
        // try: Hata yönetimi için bir kod bloğu oluşturur.
        // catch: try bloğunda hata oluşursa çalışacak kod bloğudur.
        // finally: try-catch yapısında, hata olsun veya olmasın çalıştırılacak bloktur.

        // Sınıf ve Nesne Tabanlı Programlama (Object-Oriented Programming - OOP)
        // abstract: Soyut bir sınıf veya metod tanımlamak için kullanılır.
        // class: Yeni bir sınıf tanımlamak için kullanılır.
        // interface: Metot imzalarının belirtildiği bir yapı oluşturur.
        // struct: Değer tipi bir veri yapısı tanımlamak için kullanılır.
        // new: Yeni bir nesne örneği oluşturmak için kullanılır.
        // this: Mevcut sınıf örneğine referans verir.
        // base: Üst sınıfa erişmek için kullanılır.
        // namespace: İsim alanı tanımlamak için kullanılır.
        // sealed: Bir sınıfın başka sınıflar tarafından türetilmesini engeller.
        // static: Bir sınıf veya metodu nesne oluşturmadan erişilebilir hale getirir.
        // readonly: Bir değişkenin yalnızca tanımlandığı anda veya constructor içinde değiştirilebileceğini belirtir.
        // override: Üst sınıftan gelen bir metodu yeniden tanımlamak için kullanılır.

        // Diğer Anahtar Kelimeler
        // as: Tür dönüşümü yaparken kullanılır.
        // checked: Sayısal işlemlerde taşma olup olmadığını kontrol eder.
        // const: Sabit bir değişken tanımlamak için kullanılır.
        // delegate: Metotları temsil eden bir tür oluşturur.
        // enum: Sabit değerlerden oluşan bir veri tipi tanımlar.
        // event: Olay tabanlı programlama için kullanılır.
        // explicit: Açık tür dönüşümü tanımlamak için kullanılır.
        // extern: Harici bir metodu kullanmak için kullanılır (genellikle DLL bağlantılarında).
        // fixed: Bellekte bir değişkenin konumunu sabitler (unsafe kodlarda kullanılır).
        // implicit: Kapalı tür dönüşümünü tanımlamak için kullanılır.
        // in: Bir metot parametresinin yalnızca giriş olarak kullanılacağını belirtir.
        // lock: Çoklu iş parçacığında bir kaynağa aynı anda erişimi engellemek için kullanılır.
        // operator: Operatör aşırı yükleme (operator overloading) tanımlamak için kullanılır.
        // out: Bir metot parametresinin dışarıya bir değer döndürmesini sağlar.
        // params: Değişken sayıda parametre alan metodları belirtir.
        // sizeof: Bir veri tipinin bellekte kaç byte yer kapladığını hesaplar.
        // stackalloc: Stack üzerinde bellek tahsisi yapmak için kullanılır.
        // typeof: Bir nesnenin türünü almak için kullanılır.
        // unchecked: Sayısal işlemlerde taşma olup olmadığını kontrol etmez.
        // unsafe: Güvenli olmayan (pointer) kodları kullanmak için kullanılır.
        // using: Ad alanlarını (namespace) dahil etmek için kullanılır veya IDisposable nesneleri otomatik temizlemek için blok oluşturur.
        // virtual: Bir metodun alt sınıflarda yeniden yazılabilmesini sağlar.
        // void: Bir metodun değer döndürmediğini belirtir.
        // volatile: Çoklu iş parçacığı işlemlerinde değişkenin her defasında bellekte güncellenmesini sağlar.
        //
        // **C# Tanıtıcılar ve Değişkenler**
        // 
        // ### **Tanıtıcılar (Identifiers)**
        // 
        // Tanıtıcılar, programcı tarafından isimlendirilen ve program içindeki değişken, metod, sınıf gibi yapılara verilen adlardır. C# dili **büyük-küçük harfe duyarlıdır** (case-sensitive), yani `sayi` ve `Sayi` farklı değişkenlerdir.
        // 
        // #### **Tanıtıcı İsimlendirme Kuralları**
        // ✅ **Geçerli Kurallar:**
        // - Harf (`a-z, A-Z`), alt çizgi (`_`) veya Unicode karakterlerle başlayabilir.
        // - Sayılar, Türkçe karakterler ve Unicode karakterler içerebilir.
        // - Anlamlı ve açıklayıcı olmalıdır.
        // 
        // ❌ **Geçersiz Kullanımlar:**
        // - **Boşluk, tab, virgül veya semboller** (`#, $, %, &` vb.) içeremez.
        // - **Anahtar kelimeler** (`int, class, return` vb.) kullanılamaz.
        // - **Aynı isimli tanıtıcılar** aynı kod bloğunda birden fazla kez tanımlanamaz.
        // 
        // ✅ **Örnek Geçerli Tanıtıcılar:**
        // ```csharp
        // char karakter;
        // decimal odenenTutar;
        // long sayi1;
        // ```
        // ❌ **Örnek Geçersiz Tanıtıcılar:**
        // ```csharp
        // double 1odeme; // Geçersiz: Rakamla başlayamaz
        // uint fark#; // Geçersiz: Özel karakter içeremez
        // sbyte ogrenci No; // Geçersiz: Boşluk içeremez
        // ```
        // 
        // ### **Değişkenler (Variables)**
        // 
        // Değişkenler, program içinde kullanılacak verileri bellekte saklayan yapılardır. Bir değişkenin **veri tipi**, **ismi** ve **değeri** bulunur.
        // 
        // #### **Değişken Bildirimi ve Değer Atama**
        // C#’ta değişkenler üç farklı şekilde tanımlanabilir:
        // ```csharp
        // veri_tipi degisken_ismi; // Sadece değişken bildirimi
        // veri_tipi degisken_ismi = deger; // Bildirim ve atama
        // veri_tipi degisken_ismi = new veri_tipi(); // Nesne oluşturma
        // ```
        // ✅ **Geçerli Örnekler:**
        // ```csharp
        // int sonuc;
        // long hesap = new long();
        // string ogrenciAdi;
        // ogrenciAdi = "Ahmet";
        // long ogrenciID = 123456789;
        // bool ogrenciKayitDurumu = true;
        // ```
        // ❌ **Geçersiz Örnekler:**
        // ```csharp
        // int 26; // Geçersiz: Değişken ismi yok
        // fiyat = 26; // Geçersiz: Veri tipi belirtilmemiş
        // int return = 110; // Geçersiz: Anahtar kelime kullanılamaz
        // string 1dersAdi = "C#"; // Geçersiz: Rakamla başlayamaz
        // byte sayac degeri = 0; // Geçersiz: Boşluk içeremez
        // short kdvOrani% = 8; // Geçersiz: Özel karakter içeremez
        // ```
        // 
        // #### **Değişken Değerini Güncelleme**
        // Değişkenlerin değerleri sonradan değiştirilebilir:
        // ```csharp
        // sbyte dersKredi = 3;
        // dersKredi = 5;
        // Console.WriteLine(dersKredi); // Çıktı: 5
        // ```
        // 
        // #### **Atama Operatörü (`=`) Kullanımı**
        // Atama operatörü, değişkenin yeni bir değer almasını sağlar:
        // ```csharp
        // int x = 5;
        // x = x + 1; // x artık 6 olur
        // ```
        // Bu kodda, `x = x + 1;` ifadesinin çalışma mantığı:
        // 1. `x + 1` işlemi yapılır, yani `5 + 1 = 6` hesaplanır.
        // 2. Elde edilen `6` değeri `x` değişkenine atanır.
        // 
        // 
        // ### **Özet:**
        // - **Tanıtıcılar**, değişken, metod, sınıf gibi yapılara verilen isimlerdir.
        // - **C# büyük-küçük harfe duyarlıdır** (`sayi` ve `Sayi` farklıdır).
        // - **Tanıtıcılar:** Harf veya `_` ile başlamalı, özel karakter ve boşluk içermemelidir.
        // - **Değişkenler**, bellekte veri saklamak için kullanılır ve veri tipine uygun değer almalıdır.
        // - **Değişkenler atanabilir ve güncellenebilir.**
        // 
        // Bu bilgiler, **sınavda çıkabilecek temel kavramları hızlıca anlamanı sağlar**. Eğer belirli bir konu hakkında daha fazla açıklama istersen, haber ver! 📚🚀
        // 
        //
        // Erişim Belirleyiciler:
        // Program içinde bazı değişken, metod veya yapıları dış erişime kapatmak için erişim belirleyiciler kullanılır. C#’ta 6 farklı erişim belirleyici vardır:
        // 
        // public: Her yerden erişilebilir.
        // private: Sadece tanımlandığı sınıfta kullanılabilir.
        // protected: Tanımlandığı sınıf ve türetilmiş sınıflardan erişilebilir.
        // internal: Aynı derleme (assembly) içindeki kodlar tarafından erişilebilir.
        // protected internal: Aynı derleme veya başka bir derlemede türetilmiş sınıflar tarafından erişilebilir.
        // private protected: Aynı derlemedeki türetilmiş sınıflar tarafından erişilebilir.
        // Sabitler (const):
        // Değeri değişmeyen değişkenlerdir. const anahtar kelimesi ile tanımlanır ve bir kez atanır. Örneğin:
        // 
        // const double isikYili = 9.46E12;  
        // Sabit bir değere sonradan yeni bir değer atanamaz.
        // 
        // Değerler (Literals):
        // Değişkenlere atanan sayısal, karakter veya özel ifadeler değer (literal) olarak adlandırılır. Sayısal değerler ondalık, ikilik (0b), onaltılık (0x) tabanlarında tanımlanabilir. Örnek:
        // 
        // int ikilik = 0B1011;  
        // int onaltilik = 0x98A5F0;  
        // Ondalık ayıracı olarak . kullanılır. Büyük sayılar daha okunaklı olması için _ karakteri ile ayrılabilir:
        // 
        // long buyukSayi = 11_230_000_000L;
        // C#’ta sayısal değerlerin okunurluğunu artırmak için Convert.ToDecimal fonksiyonu kullanılabilir
        // *//

    }
}
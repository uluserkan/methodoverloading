internal class Program
{
    private static void Main(string[] args)
    {
        // Out Parametreler
        string sayi = "999";

        bool sonuc = int.TryParse(sayi, out int outsayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outsayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");

        }
        Metodlar instance = new Metodlar();
        instance.Topla(4,5,out int toplamSonuc);
        Console.WriteLine(toplamSonuc);

        //Metod Aşırı Yükleme - Overloading


        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Serkan ","Ulu");

        //Metod İmzası
        //metodAdı + parametre sayısı + parametre

    }
}
class Metodlar
{
    public void Topla(int a,int b, out int toplam)
    {
        toplam = a + b;
    }
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(string veri1,string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}

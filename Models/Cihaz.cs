using AkilliEvSistemi.Enums;

namespace AkilliEvSistemi.Models;

public class Cihaz
{
    public int Kimlik { get; }
    public string Ad { get; }
    public CihazTuru Tur { get; }
    public bool AcikMi { get; private set; }

    public Cihaz(int kimlik, string ad, CihazTuru tur)
    {
        Kimlik = kimlik;
        Ad = ad;
        Tur = tur;
        AcikMi = false;
    }

    public void Ac()
    {
        AcikMi = true;
        Console.WriteLine($"{Ad} cihazı açıldı.");
    }

    public void Kapat()
    {
        AcikMi = false;
        Console.WriteLine($"{Ad} cihazı kapatıldı.");
    }

    public void BilgileriGoster()
    {
        string durum = AcikMi ? "Açık" : "Kapalı";

        Console.WriteLine($"Kimlik: {Kimlik}");
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Tür: {Tur}");
        Console.WriteLine($"Durum: {durum}");
    }
}

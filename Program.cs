using AkilliEvSistemi.Enums;
using AkilliEvSistemi.Models;

List<Cihaz> cihazlar =
[
    new Cihaz(1, "Lamba", CihazTuru.Lamba),
    new Cihaz(2, "Klima", CihazTuru.Klima),
    new Cihaz(3, "Güvenlik Sistemi", CihazTuru.GuvenlikSistemi)
];

while (true)
{
    Console.WriteLine("\nAkıllı Ev Cihazları Yönetim Sistemi");
    Console.WriteLine("1. Cihazları Listele");
    Console.WriteLine("2. Yeni Cihaz Ekle");
    Console.WriteLine("3. Cihaz Aç");
    Console.WriteLine("4. Cihaz Kapat");
    Console.WriteLine("0. Çıkış");
    Console.Write("Seçiminiz: ");

    string? giris = Console.ReadLine();
    if (giris is null)
    {
        break;
    }

    if (!int.TryParse(giris, out int secim))
    {
        Console.WriteLine("Geçersiz seçim. Lütfen bir sayı girin.");
        continue;
    }

    switch (secim)
    {
        case 1:
            if (cihazlar.Count == 0)
            {
                Console.WriteLine("Kayıtlı cihaz bulunmuyor.");
                break;
            }

            foreach (Cihaz cihaz in cihazlar)
            {
                cihaz.BilgileriGoster();
                Console.WriteLine();
            }
            break;

        case 2:
            Console.Write("Kimlik: ");
            if (!int.TryParse(Console.ReadLine(), out int kimlik))
            {
                Console.WriteLine("Geçersiz kimlik. Kimlik sayı olmalıdır.");
                break;
            }

            if (cihazlar.Exists(cihaz => cihaz.Kimlik == kimlik))
            {
                Console.WriteLine("Bu kimlikte bir cihaz zaten mevcut.");
                break;
            }

            Console.Write("Ad: ");
            string? ad = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(ad))
            {
                Console.WriteLine("Cihaz adı boş olamaz.");
                break;
            }

            Console.WriteLine("Tür seçin: 1=Lamba, 2=Klima, 3=Güvenlik Sistemi");
            Console.Write("Tür: ");
            if (!int.TryParse(Console.ReadLine(), out int turSecimi))
            {
                Console.WriteLine("Geçersiz tür seçimi.");
                break;
            }

            if (turSecimi is < 1 or > 3)
            {
                Console.WriteLine("Tür 1, 2 veya 3 olmalıdır.");
                break;
            }

            CihazTuru tur = (CihazTuru)(turSecimi - 1);
            cihazlar.Add(new Cihaz(kimlik, ad, tur));
            Console.WriteLine("Cihaz başarıyla eklendi.");
            break;

        case 3:
        case 4:
            Console.Write("İşlem yapılacak cihazın kimliği: ");
            if (!int.TryParse(Console.ReadLine(), out int hedefKimlik))
            {
                Console.WriteLine("Geçersiz kimlik. Kimlik sayı olmalıdır.");
                break;
            }

            Cihaz? hedefCihaz = cihazlar.Find(cihaz => cihaz.Kimlik == hedefKimlik);
            if (hedefCihaz is null)
            {
                Console.WriteLine("Bu kimlikte bir cihaz bulunamadı.");
                break;
            }

            if (secim == 3)
            {
                hedefCihaz.Ac();
            }
            else
            {
                hedefCihaz.Kapat();
            }
            break;

        case 0:
            Console.WriteLine("Programdan çıkılıyor.");
            return;

        default:
            Console.WriteLine("Geçersiz menü seçimi.");
            break;
    }
}

# Akıllı Ev Cihazları Yönetim Sistemi

Bu proje, akıllı ev cihazlarını konsol üzerinden listelemek ve temel işlemlerini yönetmek için hazırlanmış bir C# Console Application uygulamasıdır.

## Projenin Amacı

Lamba, klima ve güvenlik sistemi gibi cihazları bir listede tutmak; cihaz bilgilerini görüntülemek ve cihazları kimlikleri üzerinden açıp kapatmaktır.

## Özellikler

- Başlangıçta lamba, klima ve güvenlik sistemi türlerinde üç cihaz bulunur.
- Cihazlar listelenebilir; kimlik, ad, tür ve açık/kapalı durumu gösterilir.
- Yeni cihaz; kimlik, ad ve tür bilgileriyle eklenebilir.
- Aynı kimliğe sahip cihazın eklenmesi engellenir.
- Cihazlar kimlikleri kullanılarak açılıp kapatılabilir.
- Sayısal seçimler ve boş cihaz adı gibi hatalı girişler kontrol edilir.
- Menü, kullanıcı çıkışı seçeneğini girene kadar tekrar gösterilir.

## Kullanılan Teknolojiler

- C#
- .NET 10
- .NET Console Application

## Proje Klasör Yapısı

```text
AkilliEvSistemi/
├── Enums/
│   └── CihazTuru.cs
├── Models/
│   └── Cihaz.cs
├── AkilliEvSistemi.csproj
├── Program.cs
└── README.md
```

## Kurulum ve Çalıştırma

Makinenizde .NET 10 SDK kurulu olmalıdır. Proje klasöründe terminal açıp şu komutu çalıştırın:

```bash
dotnet run
```

## Kullanım Menüsü

Uygulama çalıştığında aşağıdaki seçenekler gösterilir:

| Seçim | İşlem |
| --- | --- |
| `1` | Cihazları listele |
| `2` | Yeni cihaz ekle |
| `3` | Kimlik ile cihaz aç |
| `4` | Kimlik ile cihaz kapat |
| `0` | Uygulamadan çık |

Yeni cihaz eklerken kimlik ve ad girilir, ardından tür seçilir:

| Tür seçimi | Cihaz türü |
| --- | --- |
| `1` | Lamba |
| `2` | Klima |
| `3` | Güvenlik sistemi |

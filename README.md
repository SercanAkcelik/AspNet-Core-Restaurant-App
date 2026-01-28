# 🍔 LezzetBurger - Restoran Yönetim Sistemi (Showcase)

**Restoran yönetimi, dijital menü sunumu ve rezervasyon işlemleri için geliştirilmiş modern, full-stack ASP.NET Core MVC çözümü.**

> **Not:** Bu repo, projenin mimarisini, kodlama standartlarını ve yapısal kalitesini sergilemek amacıyla oluşturulmuş bir **Showcase (Vitrin)** çalışmasıdır. Fikri mülkiyet haklarını korumak adına tüm kaynak kodları paylaşılmamış, sadece projenin teknik yetkinliğini gösteren temel dosyalar eklenmiştir.

---

## 🚀 Proje Hakkında

Bu proje, restoran operasyonlarını dijitale taşıyan kapsamlı bir web uygulamasıdır. Müşteriler için şık ve kullanışlı bir menü ve rezervasyon arayüzü sunarken, işletme sahipleri için güçlü bir Yönetim Paneli sağlar.

### 🌟 Öne Çıkan Özellikler

*   **Müşteri Arayüzü (Public UI):**
    *   Kategori bazlı filtreleme özelliğine sahip Dinamik Dijital Menü.
    *   Hızlı ve kolay Online Masa Rezervasyonu.
    *   Mobil uyumlu, modern ve estetik tasarım.
*   **Yönetim Paneli (Admin & CMS):**
    *   Güvenli Kimlik Doğrulama (Authentication) ve Yetkilendirme.
    *   **Dashboard:** Anlık metrikler ve işletme özeti.
    *   **Menü Yönetimi:** Ürün ve Kategori ekleme, düzenleme, silme (CRUD).
    *   **Rezervasyon Yönetimi:** Gelen rezervasyonları görüntüleme ve onaylama.
*   **Mimari ve Teknik:**
    *   Katmanlı Mimari (N-Tier Architecture) yaklaşımı.
    *   Entity Framework Core ile Code-First veritabanı tasarımı.
    *   Dependency Injection ve Repository Pattern prensipleri.

---

## 🛠 Kullanılan Teknolojiler

*   **Backend:** ASP.NET Core MVC (.NET 6/7)
*   **Veritabanı:** MS SQL Server, Entity Framework Core
*   **Frontend:** HTML5, CSS3, JavaScript, Bootstrap/Tailwind
*   **Araçlar:** Visual Studio, Git, SSMS

---

## 📂 Örnek Kod İncelemesi

Bu repoda projenin kalitesini yansıtan şu dosyalar bulunmaktadır:

*   **`Program.cs`:** Uygulamanın giriş noktası. Servislerin (DI Container) ayarlandığı, veritabanı bağlantısının ve Middleware hattının konfigüre edildiği merkez.
*   **`Data/AppDbContext.cs`:** Veritabanı bağlamı (Context). Tabloların (DbSet) ve ilişkilerin tanımlandığı EF Core yapılandırması.
*   **`Areas/Admin/Controllers/ProductsController.cs`:** Admin panelinde ürün yönetimini sağlayan Controller. Asenkron programlama, dosya yükleme işlemleri ve hata yönetimi örnekleri içerir.
*   **`Models/Product.cs`:** Veritabanı varlık (Entity) modeli örneği. Data Annotations ile yapılan validasyon kurallarını gösterir.

---

## 👨‍💻 Geliştirici

**[Sercan Akçelik](https://linkedin.com/in/sercanakcelik)** tarafından geliştirilmiştir.
*Ölçeklenebilir, temiz ve verimli web çözümleri üzerine çalışıyorum.*

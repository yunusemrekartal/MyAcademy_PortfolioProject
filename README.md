# MyAcademy_PortfolioProject
Bu proje, dinamik bir portfolyo web sitesi ve yönetim panelinden oluşan **MVC** mimarisinde geliştirilmiş bir uygulamadır. Admin paneli sayesinde kullanıcı arayüzündeki tüm içerikler (projeler, deneyimler, hizmetler vb.) anlık ve dinamik olarak yönetilebilmektedir.
> *MY Akademi C# Full Stack Yazılım Geliştirme Eğitimi kapsamında geliştirilmiştir.*
## Kullanılan Teknolojiler
* **Backend:** ASP.NET Core MVC, Entity Framework Core
* **Veritabanı:** Microsoft SQL Server
* **Frontend:** Bootstrap, Tailwind CSS, HTML5, CSS3
## Özellikler
* **Dinamik Portfolyo Arayüzü:** Tek sayfa (Single Page) modern kullanıcı tasarımı
* **Yönetim Paneli (Admin Dashboard):** Banner, Hakkımda, Deneyim, Eğitim, Hizmetler, Projeler ve Referanslar bölümlerinin yönetimi
* **CRUD İşlemleri:** Tüm içerikler için ekleme, silme, güncelleme ve listeleme imkanı
* **Kimlik Doğrulama:** Cookie tabanlı güvenli admin girişi
* **Modüler Mimari:** ViewComponent kullanımı ile dinamik parça yönetimi
* **Veri Yönetimi:** ViewModel yapısı ile arayüze özgü veri modelleme
* **Mesajlaşma Sistemi:** Gelen mesajların filtrelenmesi ve detaylı okunma ekranı
## Kurulum ve Çalıştırma
* GitHub'dan projeyi bilgisayarınıza indirin.
* Portfolio/Data/Context/AppDbContext.cs dosyasındaki bağlantı dizesini kendi SQL Server ayarlarınıza göre değiştirin.
* Veritabanını yerel ortamınızda otomatik olarak oluşturmak (veya mevcut veritabanını güncellemek) için Proje klasöründe aşağıdaki komutu çalıştırın:
```
dotnet ef database update
```
* Uygulamayı çalıştırmak için aşağıdaki komutu çalıştırın:
```
dotnet run
```
> [!WARNING]
> Kurulumu yaptıktan sonra uygulamanın yönetici hesabını veri tabanındaki Admins tablosundan belirleyin.

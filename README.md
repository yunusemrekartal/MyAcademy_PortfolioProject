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

<img width="1897" height="902" alt="banner" src="https://github.com/user-attachments/assets/d341de51-b25f-4ea7-a775-64da02b613ac" />
<img width="1905" height="912" alt="about" src="https://github.com/user-attachments/assets/6a4e92a7-79cb-4c9d-b272-dd51f0fd480b" />
<img width="1897" height="909" alt="cv" src="https://github.com/user-attachments/assets/602efca1-8ddb-4927-b298-46b6c378ded3" />
<img width="1918" height="908" alt="admin1" src="https://github.com/user-attachments/assets/1c9eb4bc-2b86-467c-9aed-2520c52fd1a7" />
<img width="1918" height="908" alt="admin2" src="https://github.com/user-attachments/assets/cade8c43-d371-4aa9-b50c-67c56dc3e836" />
<img width="1919" height="909" alt="admin3" src="https://github.com/user-attachments/assets/cb772f8f-0609-4ad7-8ad8-3529d8568bee" />
<img width="1919" height="913" alt="admin4" src="https://github.com/user-attachments/assets/091cf358-f767-4424-b5a7-9a99cc88e201" />
<img width="1919" height="910" alt="admin5" src="https://github.com/user-attachments/assets/cdd6e5e7-d1e2-4379-9cd0-f45c527f81b8" />
<img width="485" height="515" alt="login" src="https://github.com/user-attachments/assets/5fab8bae-7a31-454d-ba1b-67c66f749f76" />


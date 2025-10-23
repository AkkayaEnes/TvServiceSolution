# 📺 TV Servis Takip Sistemi (C# WinForms + Entity Framework Code First)

Bu proje, **televizyon teknik servislerinde** müşteri, cihaz, teknisyen ve servis kayıtlarının takibini kolaylaştırmak amacıyla geliştirilmiştir.  
Projede **katmanlı mimari (N-Tier Architecture)** yapısı kullanılmıştır.  
Veritabanı işlemleri **Entity Framework Code First** yaklaşımıyla yönetilmektedir.

---

## 🧱 Proje Katmanları

### 1️⃣ **EntityLayer (Varlık Katmanı)**
- Uygulamanın veri modelleri burada tanımlanmıştır.
- Örnek sınıflar:  
  - `Customer`  
  - `Device`  
  - `Technician`  
  - `ServiceRecord`  
  - `City`

Her sınıf, veritabanındaki bir tabloyu temsil eder.

---

### 2️⃣ **DataAccessLayer (Veri Erişim Katmanı)**
- Entity Framework kullanılarak veritabanı işlemleri burada yapılır.  
- **Code First** yaklaşımıyla veritabanı otomatik oluşturulur.  
- İçeriği:
  - `TvServiceContext` → DbContext sınıfı (tablo bağlantıları)
  - `GenericRepository<T>` → Ortak CRUD işlemleri
  - `IGenericDal<T>` → Interface tanımı
  - `EfCustomerDal`, `EfDeviceDal`, `EfTechnicianDal`, `EfServiceRecordDal` → Her tabloya özel EF sınıfları

---

### 3️⃣ **BusinessLayer (İş Katmanı)**
- Uygulamanın iş mantığı burada yönetilir.  
- CRUD işlemleri, **manager sınıfları** aracılığıyla yapılır.
- Örnek sınıflar:
  - `CustomerManager`
  - `DeviceManager`
  - `TechnicianManager`
  - `ServiceRecordManager`

Her Manager sınıfı, kendi DAL sınıfını (örnek: `EfCustomerDal`) kullanır.

---

### 4️⃣ **PresentationLayer (Sunum Katmanı - WinForms)**
- Kullanıcı arayüzü bu katmandadır.
- Formlar:  
  - `FrmCustomer` → Müşteri ekleme, silme, güncelleme, listeleme  
  - `FrmDevice` (ileride eklenecek) → Cihaz ekleme ve arıza takibi  
  - `FrmTechnician` (ileride eklenecek) → Teknisyen yönetimi  
  - `FrmServiceRecord` (ileride eklenecek) → Servis işlemleri ve raporlar

Formlar **BusinessLayer** üzerinden veriye erişir;  
doğrudan veritabanına bağlanmaz.

---

## ⚙️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|------------|-----------|
| 💻 C# (.NET Framework 4.8) | Ana yazılım dili |
| 🧩 Entity Framework 6.4.4 | ORM (Code First yaklaşımı) |
| 🪶 WinForms | Arayüz |
| 🧠 N Katmanlı Mimari | Katmanlı proje yapısı |
| 🗄️ SQL Server | Veritabanı yönetimi |
| 🧰 Visual Studio 2022 | Geliştirme ortamı |

---

## 🧭 Çalışma Sırası

1. **EntityLayer** → Varlık sınıfları oluşturulur.  
2. **DataAccessLayer** → Context, Repository, DAL sınıfları tanımlanır.  
3. **BusinessLayer** → Manager ve Service yapısı oluşturulur.  
4. **PresentationLayer** → Form ekranları tasarlanır ve Manager üzerinden veri işlemleri yapılır.  
5. **Migration Komutları** (Code First):
   ```bash
   Enable-Migrations
   Add-Migration InitialCreate
   Update-Database


## 💡 Örnek: FrmCustomer Ekranı

**Yapabildikleri:**
- Müşteri ekleme  
- Müşteri silme  
- Müşteri güncelleme  
- Müşteri listeleme  
- Grid satırına tıklayınca TextBox alanlarının otomatik dolması  

**Kullanılan Nesneler:**

| Nesne | Tür | Açıklama |
|--------|------|-----------|
| `txtFullName` | TextBox | Müşteri adı ve soyadı |
| `txtCity` | TextBox | Müşteri şehir bilgisi |
| `txtPhone` | TextBox | Müşteri telefon numarası |
| `txtEmail` | TextBox | Müşteri e-posta adresi |
| `btnAdd` | Button | Yeni müşteri ekleme işlemi |
| `btnDelete` | Button | Seçilen müşteriyi silme işlemi |
| `btnUpdate` | Button | Seçilen müşteriyi güncelleme işlemi |
| `btnList` | Button | Tüm müşterileri listeleme işlemi |
| `dataGridView1` | DataGridView | Müşteri listesini tablo şeklinde gösterir |

**Ekran Özeti:**
- Kullanıcı yeni müşteri eklediğinde veritabanına kayıt edilir.  
- Güncelleme yapıldığında seçili satırın bilgileri güncellenir.  
- Silme işlemiyle birlikte kayıt veritabanından kaldırılır.  
- Listele butonu tüm kayıtları yeniler.  

---

## 🧾 Veritabanı Yapısı (Code First ile oluşur)

| Tablo | Açıklama |
|--------|-----------|
| **Customers** | Müşteri bilgilerini tutar (FullName, City, Phone, Email) |
| **Devices** | Servise gelen cihaz bilgileri (Marka, Model, SeriNo, Durum) |
| **Technicians** | Teknisyen bilgileri (Ad, Uzmanlık, Deneyim) |
| **ServiceRecords** | Servis kayıtları (Tarih, Müşteri, Cihaz, Teknisyen, Ücret) |
| **Cities** | Şehir listesi (isteğe bağlı tablo) |

**Migration Komutları:**
```bash
Enable-Migrations
Add-Migration InitialCreate
Update-Database

## Booking Api ile Otel Listeleme Projesi
🏨 Bu projede RapidApi üzerinde bulunan Booking API kullanılarak geliştirilmiş bir otel listeleme uygulamasıdır. Kullanıcıların belirlediği kriterlere uygun otelleri listeleme işlemi gerçekleştirilmiştir.

## 🌍 Ana Sayfa & Kullanıcı Deneyimi

- 🔎 Kullanıcılardan aşağıdaki bilgiler istenir:
- 📍 Şehir (Filtrelemek istedikleri konum)
- 📆 Giriş ve çıkış tarihleri
- 👥 Yetişkin kişi sayısı
- ✅ Belirtilen kriterlere uygun oteller liste halinde gösterilir.

## ℹ️ Kullanıcılar otellerin şu bilgilerine ulaşabilir:

- 🏢 Otel adı
- 💰 Gecelik konaklama ücreti
- ⭐ Otel puanı


## 🔧 Kullanılan Teknolojiler & Yapı

🖥️ ASP.NET Core 6.0 ile geliştirildi.
📌 Tek katmanlı mimari kullanıldı.
🌐 Booking API’nin iki farklı endpoint’i entegre edildi:
- 🔹 Search Hotel Destination Endpoint
  Kullanıcının girdiği şehir bilgisine uygun şehir ID’si alındı.
- 🔹 Search Hotels Endpoint
Elde edilen şehir ID’si ve diğer filtreleme kriterleri kullanılarak otel listesi getirildi.



## 🗂️ ViewModel Kullanımı

- API’den gelen JSON verileri, özel ViewModel yapıları ile yönetildi ve uygun modeller aracılığıyla işlendi.

## Proje Çıktıları

![1](https://github.com/user-attachments/assets/8140ab0f-e7a0-4c0c-87b1-e8320c41a0fe)
![4](https://github.com/user-attachments/assets/ea4d5d0b-b1f5-4384-bf2a-ebd9afc8f55a)
![5](https://github.com/user-attachments/assets/a61e7cef-e2f1-4f2e-8947-d42dfe35c1bd)


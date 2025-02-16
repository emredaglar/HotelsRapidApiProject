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

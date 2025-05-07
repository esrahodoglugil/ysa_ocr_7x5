# YSA_OCR__7x5
# YSA-OCR 7x5 (MLP ile Harf Tanıma)

Bu proje, **Yapay Sinir Ağları (ÇKA / MLP)** kullanılarak A-B-C-D-E harflerini tanıyabilen bir optik karakter tanıma (OCR) sistemidir. Proje, C# Windows Forms kullanılarak geliştirilmiş, tüm hesaplamalar sıfırdan manuel olarak kodlanmıştır. Herhangi bir hazır ML kütüphanesi **kullanılmamıştır**.

---

## 🧠 Kullanılan YSA Mimarisi

- **Giriş Katmanı**: 7x5 (35 adet nöron)
- **Gizli Katman**: Kullanıcı tarafından belirlenebilir (varsayılan 10)
- **Çıkış Katmanı**: 5 adet nöron (A-B-C-D-E harfleri için)
- **Aktivasyon Fonksiyonu**: Sigmoid
- **Öğrenme Metodu**: Backpropagation (geri yayılım)
- **Öğrenme Oranı**: Kullanıcı tarafından belirlenebilir

---

## 🖼️ Uygulama Arayüzü

Form arayüzü şunları içerir:

- ✅ 7x5 Matris: Tıklanarak harf çizimi yapılır
- ✅ `Eğit` butonu: Ağı eğitir
- ✅ `Tanımla` butonu: Giriş matrisini analiz eder
- ✅ `Temizle` butonu: Matrisi sıfırlar
- ✅ `Çizgileri Kaldır`: Estetik amaçlı kenarlıkları kaldırır
- ✅ `Gizli Nöron Sayısı`: Kullanıcıdan alınır
- ✅ `Öğrenme Oranı`: Kullanıcıdan alınır
- ✅ `Hata Oranı`: Eğitim sonucu gösterilir
- ✅ A-B-C-D-E Çıkış Skorları: Tahmin sonucu gösterilir (en yüksek değer yeşil renkle vurgulanır)

---

## 🎯 Eğitim Seti

Proje içerisine gömülü olarak gelen 5 harflik sabit eğitim seti:

| Harf | Matris (7x5) |
|------|---------------|
| A, B, C, D, E | Elle tanımlanmış sabit veriler

Her harf için çıkış vektörü:

A: [1, 0, 0, 0, 0]
B: [0, 1, 0, 0, 0]
C: [0, 0, 1, 0, 0]
D: [0, 0, 0, 1, 0]
E: [0, 0, 0, 0, 1]

---

## 🚀 Kullanım

1. Uygulamayı çalıştır
2. 7x5 matris alanına bir harf çiz
3. `Eğit` butonuna bas (ilk seferde ağı eğitir)
4. `Tanımla` butonuna basarak çizilen harfin tahminini gör
5. `Temizle` ile matrisi sıfırla, yeni giriş yap

---

## 📁 Proje Yapısı

YSA_OCR_7x5/ │ ├── Form1.cs → Ana arayüz kodu (matrix, eventler, YSA entegrasyonu) ├── Form1.Designer.cs → Form bileşenleri ├── NeuralNetwork.cs → Sıfırdan yazılmış MLP algoritması ├── Program.cs → Uygulama başlatıcısı

---

## 🎓 Geliştirici Bilgisi

- **Adı**: Esra Hodoğlugil

---

## 📌 Notlar

- Tüm sinir ağı mantığı sıfırdan kodlanmıştır.
- Hiçbir ML kütüphanesi (ML.NET, Accord.NET, vs.) **kullanılmamıştır**.
- Eğitim verileri `egitim[,]` dizisi olarak sabit tanımlanmıştır.
- Eğitim sonrası tahmin, %95+ doğrulukla çalışmaktadır.

---

## 🧩 Ekstra (İsteğe Bağlı Geliştirme Önerileri)

- Eğitim verilerini .txt dosyasından çekmek  
- Ağırlıkları kaydetme / yükleme fonksiyonu eklemek  
- Harf çizimini mouse ile yapmak  
- Eğitim hatasını grafikle göstermek  

---

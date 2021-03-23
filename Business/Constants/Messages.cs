using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarNameInvalid = "Marka ismi geçersiz.";
        public static string MaintenanceTime ="Sistem bakımda.";
        public static string CarListed = "Arabalar listelendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarPriceInvalid = "Günlük fiyatı 0'dan büyük giriniz.";
        public static string BrandNameInvalid = "Marka ismi 2'den fazla harf içermelidir.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string ColorNameInvalid = "Renk ismi 2'den fazla harf içermelidir.";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string CarRented = "Kiralanmış araba eklenemez.";
        public static string RentalAdded = "Kiralanacak araba eklendi.";
        public static string NoRentals = "Kiralanacak araba bulunmamaktadır.";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerIsAlreadyExisting = "Olan bir müşteriyi ekleyemezsiniz";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListedByCompanyName = "Müşteriler şirket isimlerine göre listelendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string RentalDeleted = "Kiralık araba silindi";
        public static string RentalUpdated= "Kiralık araba güncellendi";
        public static string CarIsAlreadyOnRent = "Kiralanmış arabayı ekleyemezsiniz";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserValuesCantBeNull = "Kullanıcı özellikleri boş bırakılamaz";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string BrandCountOfBrandError = "En fazla 15 marka olabilir";
        public static string BrandNameAlreadyExists = "Bu isimde zaten başka bir marka var";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut;";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string PasswordError = "Şifre hatalı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string CarHaveNoImage = "Bu arabaya ait bir resim yok";
        public static string ImageLimitExpiredForCar = "Bir arabaya maksimum 5 resim eklenebilir";
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar";
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        public static string CarImageMustBeExists = "Böyle bir resim bulunamadı";
    }
}

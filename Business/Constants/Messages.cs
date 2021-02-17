using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        internal static string CustomerAdded = "Müşteri eklendi";
        internal static string CustomerIsAlreadyExisting = "Olan bir müşteriyi ekleyemezsiniz";
        internal static string CustomerDeleted = "Müşteri silindi";
        internal static string CustomersListedByCompanyName = "Müşteriler şirket isimlerine göre listelendi.";
        internal static string CustomerUpdated = "Müşteri güncellendi.";
        internal static string RentalDeleted = "Kiralık araba silindi";
        internal static string RentalUpdated= "Kiralık araba güncellendi";
        internal static string CarIsAlreadyOnRent = "Kiralanmış arabayı ekleyemezsiniz";
        internal static string UserAdded = "Kullanıcı eklendi.";
        internal static string UserValuesCantBeNull = "Kullanıcı özellikleri boş bırakılamaz";
        internal static string UserDeleted = "Kullanıcı silindi";
        internal static string UserUpdated = "Kullanıcı güncellendi";



    }
}

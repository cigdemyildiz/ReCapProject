using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string InvalidBrandName = "Lütfen marka isminin uzunluğunu en az 2 karakter olacak şekilde giriniz.";
        public static string InvalidDailyPrice = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string CarListed="Araçlar listelendi.";
        public static string CarDeleted="Araç silindi.";
        public static string CarListedByDailyPrice="Günlük fiyata göre arabalar listelendi.";
        public static string CarUpdated="Araba güncellendi.";
        public static string BrandDeleted="Marka başarıyla silindi.";
        public static string BrandListed="Markalar listelendi.";
        public static string BrandUpdated="Marka başarıyla güncellendi.";
        public static string BrandAdded= "Marka başarıyla eklendi.";
        public static string ColorAdded= "Renk başarıyla eklendi.";
        public static string ColorDeleted="Renk başarıyla silindi.";
        public static string ColorListed="Renkler listelendi.";
        public static string UserAdded="Kullanıcı başarıyla eklendi.";
        public static string UserDeleted="Kullanıcı başarıyla silindi.";
        public static string UserUpdated="Kullanıcı başarıyla güncellendi.";
        public static string FailedRentalAdd= "Kiralama işlemi oluşturulamadı!";
        public static string RentalAdded= "Kiralama işlemi başarıyla oluşturuldu.";
        public static string RentalReturned="Kiralama dönüş tarihi!";
        public static string RentalUpdated="Kiralama işlemi başarıyla güncelleştirildi.";
        public static string RentalDeleted="Kiralama işlemi başarıyla silindi.";
    }
}

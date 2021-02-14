using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string InvalidDailyPrice = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";
        public static string MaintenanceTime="Sistem bakımda";
        public static string CarListed="Arabalar listelendi";
        public static string CarDeleted="Araba silindi";
        public static string CarListedByDailyPrice="Günlük fiyata göre arabalar listelendi";
        public static string CarUpdated="Araba güncellendi";
    }
}

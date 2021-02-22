using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";        
        public static string DailyPriceInvalid = "Günlük ücret 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araba eklendi";
        public static string CarUpdated = "Araba eklendi";
        public static string CarsListed = "Arabalar listelendi";
        
        public static string MaintananceTime = "Sistem bakımda";

        public static string BrandsListed = "Markalar listelendi";
        public static string BrandNameInvalid = "Marka adı en az 2 karakterden oluşmalıdır";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Renkler listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInvalid = "Geçersiz müşteri ismi";
        public static string CustomerUpdated= "Müşteri güncellendi";
        public static string CustomerDeleted= "Müşteri silindi";

        public static string UserAdded= "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string AddError = "Ekleme hatası";
        public static string RentalAdded = "Araç kiralandı";
        public static string RentalDeleted = "Araç kiralama iptal edildi";
        public static string RentalUpdated = "İşlem güncellendi";



    }
}

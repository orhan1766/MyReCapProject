using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Arac ismi gecersiz.";
        public static string MaintenanceTime = "Sistem bakimda.";
        public static string CarListed = "Araclar listelendi.";
        public static string CarDeleted = "Arac silindi.";
        public static string CarUpdated = "Arac guncellendi.";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk guncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka guncellendi";
        public static string AuthorizationDenied="yetkilendirme gecersiz";
    }
}

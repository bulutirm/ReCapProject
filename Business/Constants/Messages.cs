using System;
namespace Business.Constants
{
    public class Messages
    {
        //Rental Messages
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string RentalUpdatedReturnDate = "Araç teslim alındı";
        public static string RentalUpdateReturnDataError = "Araç zaten teslim alınmış";

        //CarMessages
        public static string CarAdded = "Araç kayıt işlemi başarılı";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";

        //ColorMessages
        public static string ColorAdded = "Renk kayıt işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut. Farklı bir renk giriniz";

        //BrandMessage
        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut. Farklı bir marka giriniz";

        //CustomerMessage
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı";

        //UserMessages
        public static string UserAdded = "Kullannıcı kayıt işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";
    }
}

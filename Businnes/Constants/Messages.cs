using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //ListedMessage
        public static string CarsListed = "Cars Listed";
        public static string BrandsListed = "Brands Listed";
        public static string ColorsListed = "Colors Listed";

        //CarMessages
        public static string CarAdded = "Car Adding Successful";
        public static string CarUptaded = "Car Uptaded Successful";
        public static string CarDeleted = "CarDeleted Successful";

        //ColorMessages
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";

        //BrandMessages
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";

        //CustomerMessages
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı";

        //Rental Messages
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi.";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi.";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = "Araç Zaten Teslim Alınmış.";

        //UserMessages
        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";

        //InvalidMessages
        public static string CarNameInvalid = "The car name must be a minimum of 2 characters";
        public static string DailyPriceInvalid = "Daily Price Must Be Greater Than 0";

        //MaintenanceMessages
        public static string MaintenanceTime= "System is in Maintenance";

        //ImageMessages
        public static string ImagesAdded = "resim eklendi";
        public static string CarImageLimitExceeded = "Resim limitine erişildi!";
        public static string AuthorizationDenied = "AuthorizationDenied";

        //


        public static string UserNotFound = "User not found";
        public static string PasswordError = "PasswordError";
        public static string SuccessfullLogin = "SuccessfullLogin";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string UserRegistered = "SuccessUserRegistered";
        public static string AccessTokenCreated = "Access token created";

    }
}

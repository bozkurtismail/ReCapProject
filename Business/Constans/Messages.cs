using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    //magic strings
   //sürekli new lemek yerine sabit kullanbilmek için static erişimi kullanıldı.    
  //uygulama süresince tek instance si oluşur.
    public static class Messages 
    { 
        public static string CarAdded       = "Araç Başarıyla Eklendi";
        public static string CarUpdated     = "Araç Başarıyla Güncellendi";
        public static string CarListed      = "Mevcut Araçlar Listeleniyor...";
        public static string CarDeleted     = "Araç silindi";
        public static string CarNameInvalid = "Araç ismi minimum 2 karakter olmalıdır";

        public static string BrandAdded     = "Marka Başarıyla Eklendi";
        public static string BrandUpdated   = "Marka Başarıyla Güncellendi";
        public static string BrandListed    = "Markalar Listeleniyor";
        public static string BrandDeleted   = "Marka Silindi";        

        public static string ColorAdded     = "Renk Başarıyla Eklendi";
        public static string ColorUpdated   = "Renk Başarıyla Güncellendi";
        public static string ColorListed    = "Renkler Listeleniyor";        
        public static string ColorDeleted   = "Renk Silindi";

        public static string UserAdded      = "Kullanıcı Başarıyla Eklendi";
        public static string UserUpdated    = "Kullanıcı Başarıyla Güncellendi";
        public static string UserListed     = "Mevcut Kullanıcılar Listeleniyor...";
        public static string UserDeleted    = "Kullanıcı Silindi";
        public static string UserNotDeleted = "HATA. Kullanıcı Silinemedi";       
        public static string FirstNameLastNameInvalid = "İsim veya Soyisim Girilmemiş";

        public static string CustomerAdded  = "Müşteri Başarıyla Eklendi";
        public static string CustomerUpdated = "Müşteri Başarıyla Güncellendi";
        public static string CustomerListed = "Müşteriler Listeleniyor...";
        public static string CustomerDeleted = "Müşteri Silindi";       
        public static string CustomerNotAdded = "HATA. Müşteri Eklenemedi";
        public static string CustomerNotDeleted = "HATA. Müşteri Silinemedi";

        public static string RentalAdded    = "Kiralama Bilgisi Başarıyla Eklendi";
        public static string RentalUpdated  = "Kiralama Bilgisi Başarıyla Güncellendi";
        public static string RentalListed   = "Kiralama Bilgileri Listeleniyor...";
        public static string RentalDeleted  = "Kiralama Bilgisi Silindi";
        public static string RentalUpdateReturnDate = "Araç Teslim Alındı";
        public static string RentalUpdateReturnDateError = "Araç Teslim Alınmış";       
        public static string RentalAddedError = "Araç teslim edilmediği için tekrar kiraya verilemez";



    }
}





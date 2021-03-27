using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        //dışardan gelen veriyi setter üzerinden kullanıcının isteğine göre değilde 
        //benim belirtmiş olduğum şekilde constractor üzerinden değer ataması sağlayacam
        public Result(bool success, string message):this(success)//eğer kullanıcı tek başarı durumu gönderirse tek parametreli constractor çalışır
        {                                                       //ama kullanıcı hem başarı hemde mesajı beraber gönderirse iki parametreli constractorun
            Message = message;                                 //yanında tek parametreli constractorunda çalıştırılmasını sağladım amaç iki parametreli
        }                                                     //constarctor içerisinden tekrardan başarı durumu değerlerinin eşitlenmesini tekrar etmek yerine
                                                             //kullandım.this() ise kendi classı içerisindeki constractor demek  
        public Result(bool success)//overload işlemi yapılarak constractora mesaj yerine sadece başarı durumunuda göndermek isteyebilirim
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }

        
    }
}

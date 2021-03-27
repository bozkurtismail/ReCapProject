using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult:Result //inheritance işlemi yapıldı
    {
        public SuccessResult(string message):base(true,message)//eğer mesaj verilmek isteniyorsa ve başarı durumunu kullanılacaksa
        {                                                      //base classın constractoruna parametreleri göndererek kullanabilirim

        }

        public SuccessResult():base(true)//eğer kullanıcıya mesaj verilmek istenmeyip sadece başarı durumu gönderilecekse
        {                               //base classın tek parametreli constractoru kullanılabilinir.
                                       //yapılan hareketlerle başarı durumu bu class içerisinde default olarak true verildi
        }
    }
}

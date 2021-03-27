using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)//eğer mesaj verilmek isteniyorsa ve başarı durumunu kullanılacaksa
        {                                                      //base classın constractoruna parametreleri göndererek kullanabilirim

        }

        public ErrorResult() : base(false)//eğer kullanıcıya mesaj verilmek istenmeyip sadece başarı durumu gönderilecekse
        {                               //base classın tek parametreli constractoru kullanılabilinir.
                                        //yapılan hareketlerle başarı durumu bu class içerisinde default olarak false verildi
        }
    }
}

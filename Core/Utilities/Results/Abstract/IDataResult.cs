using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T>:IResult //IResult içerisindeki başarı durumunu ve mesajı içerecek ayrıca veride lazım olduğu için
    {                                      //field olarak get ile erişilecek T için kısıtlama yazılmadı çünkü herşey olabilir ileride kullanabilmek için
        T Data { get; }
    }
}

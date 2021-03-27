using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        public SuccessDataResult(T data):base(data,true)
        {

        }
        public SuccessDataResult(string message):base(default,true,message)//default çalışılan T tinin defaultudur.
        {

        }
        public SuccessDataResult() : base(default, true) 
        {
                
        }
    }
}

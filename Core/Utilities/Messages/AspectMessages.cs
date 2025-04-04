using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Messages
{
    public static class AspectMessages
    {
        //const derleme zamanında(compile-time) değeri berirlenen ve değiştirilemez değişkenlerdir
        ///Sadece primitive türler (int , double ,string gibi) ve bellekte sabit olabilen değerler için kullanılır
        public const string WrongValidationType = "Wrong Validation Type";
        public const string WrongLoggerType = "Wrong Logger Type";
    }
}

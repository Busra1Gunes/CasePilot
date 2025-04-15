using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class CacheAttribute : Attribute
    {
        public int Duration { get; }

        public CacheAttribute(int duration = 60)
        {
            Duration = duration;
        }
    }
}



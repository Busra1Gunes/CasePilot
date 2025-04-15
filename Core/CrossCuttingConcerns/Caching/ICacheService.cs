using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheService
    {
        T GetOrAdd<T>(string key, Func<T> getItemCallback, TimeSpan duration);
        void Remove(string key);
    }
}

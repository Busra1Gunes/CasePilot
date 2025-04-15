using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheService
    {
        private readonly IMemoryCache _memoryCache;

        public MemoryCacheManager(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public T GetOrAdd<T>(string key, Func<T> getItemCallback, TimeSpan duration)
        {
            if (!_memoryCache.TryGetValue(key, out T value))
            {
                value = getItemCallback();
                _memoryCache.Set(key, value, duration);
            }

            return value;
        }
        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }
    }
}

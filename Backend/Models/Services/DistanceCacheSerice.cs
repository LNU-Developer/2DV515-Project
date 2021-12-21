using System;
using Microsoft.Extensions.Caching.Memory;
namespace Backend.Models.Services
{
    public class DistanceCacheService<T>
    {
        private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

        public T GetOrCreate(string key, Func<T> createItem)
        {
            T cacheEntry;
            if (!_cache.TryGetValue(key, out cacheEntry))
            {
                cacheEntry = createItem();
                _cache.Set(key, cacheEntry);
            }
            return cacheEntry;
        }
    }
}

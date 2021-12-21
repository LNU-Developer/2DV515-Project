using System;
using Microsoft.Extensions.Caching.Memory;
namespace Backend.Models.Services
{
    public class DistanceCacheService<T>
    {
        public DistanceCacheService(IMemoryCache memoryCache) => _cache = memoryCache;

        private readonly IMemoryCache _cache;

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

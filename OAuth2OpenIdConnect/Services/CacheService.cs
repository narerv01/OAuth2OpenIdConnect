

namespace OAuth2OpenIdConnect.Services
{
    public class CacheService
    {


        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();

        public void AddToCache(string key, string value)
        {
            _cache[key] = value;
        }

        public string GetFromCache(string key)
        {
            return _cache.TryGetValue(key, out string value) ? value : null;
        }
    }
}

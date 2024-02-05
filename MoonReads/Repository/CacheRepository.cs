using MoonReads.Interfaces;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace MoonReads.Repository;

public class CacheRepository : ICacheRepository
{
    private readonly IDatabase _cacheDb;

    public CacheRepository(IConfiguration configuration)
    {
        var redis = ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis")!);
        _cacheDb = redis.GetDatabase();
    }
    
    public T GetData<T>(string key) {
        var value = _cacheDb.StringGet(key);
        return !string.IsNullOrEmpty(value) ? JsonConvert.DeserializeObject<T>(value) : default;
    }
    
    public bool SetData<T>(string key, T value, DateTimeOffset expirationTime) {
        var expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
        return _cacheDb.StringSet(key, JsonConvert.SerializeObject(value), expiryTime);
    }
    
    public void RemoveData(string substring)
    {
        var keysToDelete = _cacheDb.Multiplexer.GetServer(_cacheDb.Multiplexer.GetEndPoints().First())
            .Keys(database: _cacheDb.Database, pattern: $"*{substring}*");

        foreach (var key in keysToDelete)
        {
            _cacheDb.KeyDelete(key);
        }
    }
}
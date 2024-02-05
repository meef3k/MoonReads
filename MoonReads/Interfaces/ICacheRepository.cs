namespace MoonReads.Interfaces;

public interface ICacheRepository
{
    T GetData<T>(string key);
    bool SetData<T>(string key, T value, DateTimeOffset expirationTime);
    void RemoveData(string substring);
}
namespace Proxy.Interfaces;

public interface IConfiguration
{
    void Init();
    void Update();
    void SetConfig(string key, string value);
    string GetConfig(string key);
}
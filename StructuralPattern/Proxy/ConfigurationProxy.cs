using Proxy.Interfaces;

namespace Proxy;

public class ConfigurationProxy : IConfiguration
{
    Configuration configuration = new();

    public string GetConfig(string key)
    {
        return configuration.GetConfig(key);
    }

    public void Init()
    {
        configuration.Init();
    }

    public void SetConfig(string key, string value)
    {
        configuration.SetConfig(key, value);
    }

    void IConfiguration.Update()
    {
        throw new NotImplementedException();
    }
}
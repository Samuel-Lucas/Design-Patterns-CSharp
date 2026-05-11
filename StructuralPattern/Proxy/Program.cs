using Proxy;

ConfigurationProxy configProxy = new();

configProxy.Init();
configProxy.SetConfig("key001", "test");
Console.WriteLine(configProxy.GetConfig("key001"));
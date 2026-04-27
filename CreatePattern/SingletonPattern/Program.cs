using SingletonPattern;

var log = LogSingleton.GetInstance;

log.Write("My log message");
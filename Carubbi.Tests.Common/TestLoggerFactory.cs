using Microsoft.Extensions.Logging;

namespace Carubbi.Tests.Common;

public class TestLoggerFactory(Mock<ILogger> loggerMock) : ILoggerFactory
{
    public void AddProvider(ILoggerProvider provider)
    {
       
    }

    public ILogger CreateLogger<T>()
    {
        return loggerMock.Object;
    }

    public ILogger CreateLogger(string categoryName)
    {
        return loggerMock.Object;
    }

    public void Dispose()
    {
        
    }
}

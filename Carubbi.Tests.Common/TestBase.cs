using Microsoft.Extensions.Logging;

namespace Carubbi.Tests.Common;

public abstract class TestBase<SUT> where SUT : class
{
    protected TestBase()
    {
        LoggerFactory = new TestLoggerFactory(LoggerMock);
        Sut = ArrangeSut();

    }

    protected SUT Sut { get; }

    protected abstract SUT ArrangeSut();

    protected TestLoggerFactory LoggerFactory { get; }

    protected Mock<ILogger> LoggerMock { get; } = new();

}

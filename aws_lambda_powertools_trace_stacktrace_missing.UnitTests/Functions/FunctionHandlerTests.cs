namespace aws_lambda_powertools_trace_stacktrace_missing.UnitTests.Functions;

using aws_lambda_powertools_trace_stacktrace_missing.Functions;
using Xunit;

public sealed class HelloWorldFunctionHandlerTests
{
    [Fact]
    public async Task BrokenStackTrace()
    {
        var handler = new HelloWorldFunctionHandler();

        await handler.Traced("whatever");
    }

    [Fact]
    public async Task OKStackTrace()
    {
        var handler = new HelloWorldFunctionHandler();

        await handler.NotTraced("whatever");
    }
}

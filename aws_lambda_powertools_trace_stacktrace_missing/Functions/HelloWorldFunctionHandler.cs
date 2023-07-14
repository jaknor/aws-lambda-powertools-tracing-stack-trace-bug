namespace aws_lambda_powertools_trace_stacktrace_missing.Functions;

using System.Globalization;
using AWS.Lambda.Powertools.Tracing;

public class HelloWorldFunctionHandler
{
    [Tracing]
    public async Task<string> Traced(string input)
    {
        ThisThrows();

        await Task.Delay(1);

        return input.ToUpper(CultureInfo.InvariantCulture);
    }

    public async Task<string> NotTraced(string input)
    {
        ThisThrows();

        await Task.Delay(1);

        return input.ToUpper(CultureInfo.InvariantCulture);
    }

    private void ThisThrows()
    {
        throw new NotImplementedException();
    }
}

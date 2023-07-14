namespace aws_lambda_powertools_trace_stacktrace_missing.Functions;

using Amazon.Lambda.Core;

public class HelloWorldFunction
{
    public async Task<string> FunctionHandler(string input, ILambdaContext context)
    {
        var handler = new HelloWorldFunctionHandler();

        return await handler.Traced(input);
    }
}

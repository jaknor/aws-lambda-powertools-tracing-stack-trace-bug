# Bug Reproduction
This repository reproduces an issue with AWS Lambda PowerTools Tracing in which the stack trace is lost for exceptions thrown in methods decorecated with the [Tracing] attribute.

To reproduce run the unit tests in the solution. 

If you look at the output for the unit test ´OKStackTrace´ which calls the method that is not traced you can see the expected stack trace.

![image](https://github.com/jaknor/aws-lambda-powertools-tracing-stack-trace-bug/assets/1318087/ca3702c1-6406-4e73-9586-574c7f2c4152)

If you look at the output for the unit test ´BrokenStackTrace´ which calls the method that is traced you can see that the real stack trace has been replaced by the tracing wrapper

![image](https://github.com/jaknor/aws-lambda-powertools-tracing-stack-trace-bug/assets/1318087/5b2feadc-583d-44cc-8ec9-95e7ccb8a0ec)

# Kata 003

## Summary
Covers brittle unit tests, code coverage, and cyclomatic complexity

## Pre-Reading
- [Understanding Cyclomatic Complexity](https://blog.ndepend.com/understanding-cyclomatic-complexity/)
- [Specification Pattern](https://enterprisecraftsmanship.com/2016/02/08/specification-pattern-c-implementation/)

## Discussion
- What is cyclomatic complexity and how is it measured?
Is a software metric used to indicate the complexity of a program. Use the following formula to calculate cyclomatic complexity (CYC): CYC = E – N + 2P
- Run the existing test ~10 times: 
	* Does it pass/fail every time? no
	* Describe how you can avoid tests like this from becoming "brittle"
- Describe how "return once" and "return often and early" functions differ in complexity and testing
Minimize the number of returns in each routine. It's harder to understand a routine if, reading it at the bottom, you're unaware of the possibility that it returned somewhere above.

Use a return when it enhances readability. In certain routines, once you know the answer, you want to return it to the calling routine immediately. If the routine is defined in such a way that it doesn't require any cleanup, not returning immediately means that you have to write more code.

https://stackoverflow.com/a/733858

- Without modifying the User.cs code, use VS 2017 Enterprise or [coverlet](https://github.com/tonerdo/coverlet) to determine tst coverage: 
	* Is it possible to get full code coverage?
	No
	* Are all code paths covered or is there dead code? Why could the compiler not determine there was unreachable code?
	Because we have logic errors
	* How do access modifiers impact testing?
	Because we are not able to reach the methods

## Code Exercise
- Refactor the code to make it less complex and more easily tested. Remove invalid logic. 

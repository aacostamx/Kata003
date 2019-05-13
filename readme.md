# Kata 003

## Summary
Covers brittle unit tests, code coverage, and cyclomatic complexity

## Pre-Reading
- [Understanding Cyclomatic Complexity](https://blog.ndepend.com/understanding-cyclomatic-complexity/)
- [Specification Pattern](https://enterprisecraftsmanship.com/2016/02/08/specification-pattern-c-implementation/)

## Discussion
- What is cyclomatic complexity and how is it measured?
- Run the existing test ~10 times: 
	* Does it pass/fail every time?
	* Describe how you can avoid tests like this from becoming "brittle"
- Describe how "return once" and "return often and early" functions differ in complexity and testing
- Without modifying the User.cs code, use VS 2017 Enterprise or [coverlet](https://github.com/tonerdo/coverlet) to determine tst coverage: 
	* Is it possible to get full code coverage?
	* Are all code paths covered or is there dead code? Why could the compiler not determine there was unreachable code?
	* How do access modifiers impact testing?

## Code Exercise
- Refactor the code to make it less complex and more easily tested. Remove invalid logic. 

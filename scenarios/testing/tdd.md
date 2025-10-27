## TDD with JUnit in Java

Create a JUnit 5 unit test for a Java class named `Employees`.
- The `Employee` class has a `name` and a `salary` (double).
- The `Employees` class has a method `HighEarners` that returns a list of employees who satisfy a salary-based predicate.
- Initially, create a `HighEarners` variant that returns employees earning more than 100_000 and write tests accordingly.
- Edge cases: include a test case where the list of employees is empty and another where the list has a single employee whose salary does not exceed the threshold; in both cases the method should return an empty list.

Modify the `Employees` class to provide a `HighEarners` method that accepts a lambda strategy for salary selection using java.util.function.DoublePredicate (i.e., a lambda from double to boolean).
- Update the test class `EmployeesTests` to exercise the modified `HighEarners` method using lambda strategies (for example: a predicate that checks salary > 100_000, and other predicates for additional test coverage).
- Ensure tests cover the original edge cases with the new strategy-based method.

Show a recommended folder structure for the example (project layout, src/test separation, package names, and locations for Employees and EmployeesTests). 


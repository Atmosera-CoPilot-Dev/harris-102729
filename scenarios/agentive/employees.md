## Implementation and Testing with JUnit in Java

Project Structure:
```
Show a recommended Java project folder structure for a domain called `Employees`.  
Requirements:
- Use standard Java conventions with separate `src/main/java` and `src/test/java` folders.
- Suggest appropriate package names.
- Indicate where the `Employee`, `Employees`, and `EmployeesTests` classes should be located.
```

Implementation and Testing:
```
Create both the Java implementation classes and the JUnit 5 test class for an `Employees` domain using the project structure and package names from the previous prompt.

Requirements:
- Implement an immutable `Employee` class with `name` and `salary` (double).
- Implement an `Employees` class that manages a collection of `Employee` objects.
- Add a `highEarners` method to `Employees` that returns a list of employees matching a salary-based predicate.
- First, implement a `highEarners` variant that returns employees earning more than 100,000, and write corresponding JUnit 5 tests.
- Cover edge cases: empty employee list and a single employee below the threshold (both should return an empty list).
- Refactor `highEarners` to accept a `DoublePredicate` for flexible salary selection, and update tests accordingly.
- Ensure the design follows SOLID principles.
- Use the project structure and package names from the previous prompt.
```

Modifications:
```
Modify the `Employees` class to provide a `HighEarners` method that accepts a lambda strategy for salary selection using java.util.function.DoublePredicate (i.e., a lambda from double to boolean).
- Update the test class `EmployeesTests` to exercise the modified `HighEarners` method using lambda strategies (for example: a predicate that checks salary > 100_000, and other predicates for additional test coverage).
- Ensure tests cover the original edge cases with the new strategy-based method.
```



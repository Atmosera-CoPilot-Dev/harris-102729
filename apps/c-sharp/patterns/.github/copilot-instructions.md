---
applyTo: "**/*.cs"
description: "Instructions for generating C# code with Copilot."
---

# Copilot Code Generation Instructions

## General Guidelines
- Use camelCase for variable and method names.
- Use PascalCase for class and property names.
- Use double quotes for strings.
- Ensure all methods have XML documentation comments.
- Ensure consistent indentation using 2 spaces.
- Use `_` as a prefix for private member variables.
- Separate implementation and design by using interface (`.cs`) and implementation (`.cs`) files where applicable.
- Favor composition over inheritance where possible.

## Specific Instructions
- Use `readonly` for fields that do not change after initialization.
- Use `var` for type inference where appropriate.
- Prefer lambda expressions for anonymous methods.
- Use `StringBuilder` for string concatenation in loops or performance-critical code.
- Ensure all methods handle errors using exceptions.
- Verify that all included namespaces are used.
- Check for proper error handling in all methods.
- Ensure all loops have proper termination conditions.
- Use descriptive names for variables and methods.
- Avoid deeply nested code; refactor into smaller methods if necessary.
- Use `async`/`await` for asynchronous programming.
- Verify that all dependencies are listed in the `.csproj` file.
- Check for any potential performance issues.
- Ensure all abstract base classes have a virtual destructor equivalent (`Dispose` pattern if implementing `IDisposable`).
- Complete all open TODO comments in the code.

## Testing Guidelines
- Use xUnit for all tests.
- Ensure all tests are self-contained and do not rely on external state.
- Write tests for all public methods and classes.
- Ensure tests cover both typical and edge cases.
- Use descriptive names for test cases and methods.
- Ensure tests are independent and can be run in any order.

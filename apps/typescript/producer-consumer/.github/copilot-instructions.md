---
applyTo: '**/*.ts, **/*.js'
description: "  A prompt ladder to guide the refactoring of a producer-consumer example in TypeScript.
---

## General Guidelines
- Use camelCase for variable and function names.
- Use PascalCase for class names.
- Use double quotes for strings.
- Ensure all functions have JSDoc comments.
- Ensure consistent indentation using 2 spaces.
- Use `#` as a prefix for private class fields (ES2022+).
- Favor composition over inheritance where possible.

## Specific Instructions
- Use `const` for variables that do not change, `let` otherwise.
- Use `let` or `const` for block scoping.
- Prefer arrow functions for anonymous functions.
- Use template literals (`` `${}` ``) for string concatenation.
- Ensure all functions handle errors using exceptions (`try/catch`).
- Only import modules that are used.
- Check for proper error handling in all functions.
- Ensure all loops have proper termination conditions.
- Use descriptive names for variables and functions.
- Avoid deeply nested code; refactor into smaller functions if necessary.
- Ensure all promises are properly awaited using `async/await`.
- Verify that all dependencies are listed in `package.json`.
- Check for any potential performance issues.
- Ensure all abstract base classes have a proper `constructor` and, if needed, throw if instantiated directly.

## Testing Guidelines
- Use Jest for all tests. 
- Ensure all tests are self-contained and do not rely on external state.
- Write tests for all public functions and classes.
- Ensure tests cover both typical and edge cases.
- Use descriptive names for test cases and functions.

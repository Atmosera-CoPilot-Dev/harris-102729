# Technical Requirements: Template Method Pattern Refactoring

## 1. Project Structure
- Refactor the project into a clear folder hierarchy.
- Separate interfaces, implementations, and tests into distinct modules/files.
- Ensure `main.cpp` is refactored from monolithic code to use the Template Method Pattern.

## 2. Design Principles
- Apply SOLID principles:
  - **SRP:** Each class should have a single responsibility.
  - **OCP:** New report types can be added without modifying existing code.
  - **DIP:** High-level modules should not depend on low-level modules; use abstractions.

## 3. Template Method Pattern
- Implement the Template Method Pattern for report generation.
- Highlight the abstract base class and concrete subclasses.
- Allow for extension (e.g., new output formats like JSON/XML).

## 4. Unit Testing
- Use DocTest for unit tests.
- Cover all public methods of each class.
- Use mocks/stubs if needed to isolate dependencies.

## 5. Documentation
- Document the Template Method Pattern and its application in this project.
- Explain key pattern components: abstract base, template method, hooks, and concrete implementations.
- Include instructions for running and extending the application.

## 6. Output Flexibility
- Refactor output logic to support multiple formats (console, JSON, XML) while adhering to the Template Method Pattern.

---
*This specification is intended for students learning Copilot-assisted C++ development and design patterns.*
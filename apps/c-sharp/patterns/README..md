## Template Method Pattern Exercise

In this exercise, you will implement and enhance an application that uses the Template Method Pattern. The goal is to understand the pattern, refactor the project to follow best practices, and adhere to SOLID design principles.

The exercise is divided into two parts.

Part 1 focuses on the basic implementation of the Template Method Pattern, while Part 2 (optional) introduces a Strategy Pattern to handle multiple output formats.

Tip: 
- Add specs.md to the chat context BEFORE issuing a prompt from the ladder so Copilot honors all constraints
- Use the prompts provided as a guide to interact with Copilot effectively.
---

## Project Constraints
The solution contains two existing projects which must be retained:
- TemplateMethodApp (production code)
- TemplateMethodApp.Tests (test code)

Rules:
- Do not add, rename, or remove projects.
- All refactoring happens inside these projects.
- You may add new C# files and (optionally) create subfolders within the existing projects as part of the scaffolding exercise.
- The specific folder layout is intentionally not prescribed here; Prompt 2 (Scaffolding) is used to design it.
- Optional reference ideas and extended rationale live in specs.md (not mandatory for completion).

---

## Part 1: Basic Implementation

Here are some sample prompts you can use with Copilot to guide you through the refactoring and testing phases of this exercise:

1. **Understanding the Pattern**:
   - "What are some best practices for implementing the Template Method Pattern in C#?"

2. **Scaffolding**:
   - "Propose subfolder structure(s) inside the existing TemplateMethodApp and TemplateMethodApp.Tests projects (do not add or rename projects) to prepare for refactoring the monolithic Program.cs into a Template Method design. Show where the abstract template, concrete reports, future format strategies, factories, and test doubles will live.
   - The response should be in markdown format ready to be copied into a file."

3. **Refactoring**:
   - "Help me refactor the existing application to follow best practices for a Template Method Pattern implementation. The response should adhere to SOLID design principles and be structured in accordance with recommended project structuring."

4. **Testing Phase**:
   - "Outline strategies for effective unit testing of the application components."

5. **Unit Tests**:
   - "Generate unit tests for the classes, ensuring that all public methods are covered."
   - "Is there any need to create mock objects for dependencies to isolate the unit tests?"
   - "Run the tests after implementation to verify functionality and identify any issues."

6. **Documentation**:
   - "Create documentation that explains the Template Method Pattern and how it is applied in this application."
   - "What are the key components of the Template Method Pattern that should be highlighted in the documentation?"
	
7. **Enhancements**:
   - "Is there a pattern that could be applied to improve the maintainability and readability of the code?"
   - "The code as written renders output to the console. How can I modify it to allow for different output formats, such as JSON or XML, while still adhering to the Template Method Pattern?"

---

## Part 2: Template + Strategy 

Goal: Add multiple output formats (e.g., console text, JSON, XML, Markdown) without changing the template algorithm sequence.

Focus: Keep Template Method for ordering; introduce a Strategy for formatting/output concerns.

Core Refactor Targets:
- Extract all rendering from the template base into a formatter abstraction.
- Inject a chosen formatter (runtime selection or simple factory).
- Ensure adding a new format requires only a new formatter.

Prompting Ideas (ask Copilot):
- "List responsibilities that belong in a formatting strategy vs the template."
- "Propose a minimal interface for a report formatting strategy."
- "Suggest format-specific behaviors I might need for JSON vs plain text."
- "Generate test double prompts to verify the call order of the template method."
- "How can I let users pick a format via a command-line argument without coupling?"
- "What SOLID principles are improved by adding a formatting strategy?"

Stretch Prompts:
- "How would I support streaming very large reports while preserving the template pattern?"
- "Suggest an approach to validate row length vs headings without leaking concerns."
- "Show a prompt I can use to add a new CSV formatter safely." (No code yet.)

Deliverable: Template still defines order; at least two interchangeable format strategies; tests proving correct sequence and easy extensibility.



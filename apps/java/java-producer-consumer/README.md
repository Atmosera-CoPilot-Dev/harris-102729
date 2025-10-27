This repository contains a simple Java implementation of the Producer-Consumer pattern using a blocking queue and multithreading.

Use the following prompts to guide the development and enhancement of the project:

# Java Producer-Consumer — Copilot Chat Prompts

1. "Review the repository and README; summarize the current state and list missing components for a complete Java producer-consumer example."
2. "Propose a minimal project structure (package names, classes, test layout) and pick Maven or Gradle with reasons."
3. "Draft a high-level design: class responsibilities, data flow, thread model, shutdown behavior, and error handling."
4. "List the exact files to create (paths) and a one-line description for each file."
5. "Generate skeletons only (class and method signatures, package declarations, imports) for those files — no method bodies."
6. "Implement the Producer using ExecutorService and a BlockingQueue, including graceful shutdown and backpressure notes."
7. "Implement the Consumer that processes messages from the queue with retry and error handling guidance."
8. "Create the main App class to wire Producer and Consumer, parse simple CLI args, and register a JVM shutdown hook."
9. "Suggest logging setup (SLF4J + simple config) and what to log at DEBUG/INFO/ERROR levels."
10. "Propose unit test cases (JUnit) and integration test strategy for producer-consumer behavior and shutdown."
11. "Generate a sample Maven/Gradle build file with dependencies for JUnit and SLF4J."
12. "Produce concise README sections: build, run, sample output, and how to extend the example."
13. "Perform a focused code review on the generated code: point out concurrency issues, resource leaks, and style improvements."
14. "Suggest performance optimizations and scalability considerations (batching, queue tuning, backpressure techniques)."
15. "Generate a final checklist of changes to commit and a short git commit message template for each logical change."




Use the Agent mode to perform all steps.

## Instructions to create an app using Agentive AI (Java)

1. Create a new Java source file named Program.java inside a directory named `lambda` (or create a package `lambda` and place Program.java in the matching folder structure).

2. At the top of the file, include the necessary import directives for input/output and collections and functional interfaces:
   - java.util.Scanner
   - java.util.List
   - java.util.ArrayList
   - java.util.function.Function

3. Declare a package (for example, `lambda`) and place all code inside it.

4. Create a public class `LambdaGen` (or `Program`) and include the following members:
   - Two static factory methods:
     - `SqrGen`: returns a `Function<Double, Double>` that computes the square of a double argument.
     - `CubeGen`: returns a `Function<Double, Double>` that computes the cube of a double argument.
   - A `public static void main(String[] args)` method that drives the program.

5. In the `main` method:
   - Create a `List<Function<Double, Double>>` to hold the functions returned by `SqrGen` and `CubeGen`.
   - Use a `Scanner` to prompt the user to enter up to 10 real numbers. Stop reading earlier if the user enters the sentinel value `-1`.
   - Store the entered numbers in a `List<Double>`.
   - Add the functions produced by `SqrGen` and `CubeGen` to the functions list.
   - For each entered number, compute and print a formatted row that shows the original number, its square, and its cube (for example, "n: 2.5   Squared: 6.25    Cubed: 15.625"). Use printf or String.format for neat alignment.

6. Build and run:
   - For a minimal workflow, compile with `javac` and run with `java` from a terminal (PowerShell, CMD, or other shell).
   - Optionally create a Maven or Gradle project if you prefer a build tool.
   - Add a `.gitignore` to exclude compiled files and IDE metadata (e.g., ignore `bin/`, `out/`, `target/`, `.classpath`, `.project`, and IDE folders).

Notes:
- Keep method and variable names clear and idiomatic for Java.
- No sample code is included here; implement the described classes and methods in Java following standard language conventions.

This file is an example prompt to pass to a code-generating assistant (for example, Copilot) to produce a working GitHub Actions workflow file at '.github/workflows/build_and_test.yml'. Give the assistant the exact, actionable requirements below so it can emit a complete YAML workflow.

Requirements for the generated workflow:
- Workflow name: wf-build-and-test
- Triggers:
  - push to the main branch, but only when changes are within 'src/**' or 'tests/**'
  - pull_request targeting the main branch, but only when changes are within 'src/**' or 'tests/**'
  - workflow_dispatch for manual runs
- Single job:
  - id/name: job-build-and-test
  - runs-on: microsoft/windows-latest
- Steps (in order):
  1. Checkout repository using actions/checkout@v4.
  2. Set up Java using actions/setup-java@v4:
     - distribution: Eclipse Temurin
     - java-version: '17'
  3. Ensure Maven 3.9.x is available and run the build and tests:
     - Restore/resolve dependencies and run build+tests with: mvn -B clean verify
     - The generated workflow should install or use hosted Maven tooling appropriate for Maven 3.9.x.
  4. Upload artifacts for debugging:
     - Use actions/upload-artifact to upload build logs and test reports. Example locations for Maven: target/surefire-reports/**, target/failsafe-reports/**, target/*.log
- Failure behavior: the workflow should stop and report failure as soon as any step fails (default behavior of GitHub Actions).
- Output: The generated workflow YAML must be valid and self-contained so it can run on GitHub Actions without requiring further manual edits.





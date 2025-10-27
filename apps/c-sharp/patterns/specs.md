# Design Specifications (Condensed)

Purpose: Two-phase lab demonstrating Template Method (Phase 1) and Template + Strategy (Phase 2) for report generation with clean extensibility and SOLID alignment.

---
## 1. Project Constraints
- Keep existing projects: TemplateMethodApp, TemplateMethodApp.Tests.
- Do not add/rename/remove projects.
- Add new files / subfolders only as needed (structure decided during scaffolding prompt).

---
## 2. Phase 1: Template Method
Goal: Extract a monolithic console report into an abstract template + concrete data providers.

Template Responsibilities:
- Define invariant sequence: Title -> Headings -> Rows -> Footer.
- Orchestrate execution via public Generate() (may keep old TemplateMethod() temporarily).

Primitive Operations (abstract hooks):
- GetTitle(): string
- GetHeadings(): IList<string>
- GetRows(): IList<IList<string>>
- GetFooter(): string

Initial Concrete Class:
- CompanyReport implements hooks with static sample data.

Rules / Constraints:
- No conditional branching in template for variation; use polymorphism.
- Keep rendering local (console) in Phase 1 but encapsulated for later extraction.
- Fail fast on null data.

SOLID (Phase 1 Focus):
- SRP: Base = ordering; subclass = data.
- OCP: Add new report via subclass.
- LSP: Subclasses must not change ordering semantics.
- ISP: Small hook surface.
- DIP: Not yet (rendering still concrete).

Avoid:
- Exposing rendering helpers publicly.
- Mixing formatting logic inside data hooks.
- Column mismatch silently ignored (decide policy early – throw or normalize later).

---
## 3. Phase 2: Add Strategy (Formatting)
Goal: Support multiple output formats without altering algorithm order.

Introduce IReportFormatter:
- FormatTitle(string)
- FormatHeadings(IReadOnlyList<string>)
- FormatRows(IReadOnlyList<IReadOnlyList<string>>)
- FormatFooter(string)

Template Changes:
- Inject IReportFormatter via constructor.
- Generate() collects primitive data, validates, calls formatter methods in fixed order, assembles final string (caller decides destination: console/file/etc.).

Concrete Formatters (minimum):
- PlainTextReportFormatter
- JsonReportFormatter
(Optional): XmlReportFormatter, MarkdownReportFormatter.

Validation (in template before formatting):
- Non-null title, headings, rows.
- Each row count == headings count (throw ArgumentException if mismatch).

Optional Factory:
- FormatterFactory.Create(key) -> IReportFormatter (maps e.g., "text", "json").

SOLID Improvements (Phase 2):
- SRP: Split ordering vs representation.
- OCP: Add format via new formatter only.
- DIP: Template depends on formatter abstraction.
- LSP/ISP maintained.

---
## 4. Data & DTO (Optional)
Optional ReportData DTO (Title, Headings, Rows, Footer) for a future unified Format(ReportData) method or streaming variant.

Streaming (Stretch):
- Introduce IStreamingReportFormatter returning IEnumerable<string> per section to handle large datasets incrementally.

---
## 5. Testing Strategy
Unit Tests (xUnit already present; adapt if switching):
1. Order Test: Spy formatter records method call sequence -> assert Title, Headings, Rows, Footer.
2. Formatter Output Tests: Golden string comparisons for each formatter with sample data.
3. Validation Tests: Mismatched column counts, empty headings, null hooks throw expected exceptions.
4. Factory Tests: Known keys -> correct type; unknown key -> fallback or error.
5. Integration Test: CompanyReport + each formatter -> non-empty output; JSON parses; plain text contains headings.

Edge Cases:
- Empty rows list (allowed -> just headings + footer).
- Footer null -> treat as empty string.

---
## 6. Error Handling Policy
- Throw ArgumentNullException for null primitive hook results (except footer -> empty).
- Throw ArgumentException for column count mismatch.
- Let formatter-specific exceptions bubble (template does not swallow).

---
## 7. Acceptance Criteria
Phase 1:
- Abstract template with Generate() ordering logic.
- CompanyReport outputs correct console representation.
- No conditional logic deciding report type inside template.

Phase 2:
- Rendering extracted to IReportFormatter.
- At least PlainText + JSON implementations.
- Template unit test proving call order.
- Adding a new format requires ONLY a new formatter + (optional) factory entry; no template change.

Quality:
- Code documented (XML summaries on public members).
- Validation enforced before formatting.
- Tests pass.

---
## 8. Appendix (Optional Folder Sketches)
Potential (non-binding): Reports/, Formatting/, Factories/, Infrastructure/, TestDoubles/.

End of condensed specification.

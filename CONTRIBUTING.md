# Contributing to xyLOGIX.Core.Extensions

Thank you for contributing to `xyLOGIX.Core.Extensions`.

This repository contains a proprietary .NET Framework 4.8 / C# 7.3 module that extends the .NET Base Class Library and Windows Forms with defensive, heavily documented utility methods, fluent action classes, dynamic helpers, provider infrastructure, and NUnit test coverage.

## Important licensing and header notice

This codebase is **not MIT licensed**.

Do not add MIT license text, MIT license references, or MIT-style source-file header blocks to new or existing files.

Source files in this repository generally begin directly with `using` directives, `#pragma` directives, or a `namespace` declaration. Preserve any existing file header or above-namespace documentation if it is already present, but do not introduce a new mandatory file-header standard.

All source code, documentation, designs, specifications, and related artifacts are confidential and proprietary to xyLOGIX, LLC unless explicitly stated otherwise by the repository owner.

## Technology stack

Use the repository's existing stack and project style:

- .NET Framework 4.8.
- C# 7.3.
- Legacy MSBuild `.csproj` project format.
- `packages.config` NuGet package management.
- Visual Studio 2022/2026-compatible `.sln` files.
- Windows Forms 2.0 where WinForms extensions or interfaces are involved.
- PostSharp 2024.1.6 and PostSharp Diagnostics.
- log4net 3.0.3 through `xyLOGIX.Core.Debug`.
- AlphaFS 2.2.6 where file-system operations already use it.
- Newtonsoft.Json 13.0.3 where already present.
- Vsxmd 1.4.5 for XML-documentation-to-Markdown generation.
- NUnit 4.3.2 for the test project.
- StrongNamer 0.2.5 where already present.

Do not convert projects to SDK-style format, change package-management style, introduce nullable reference types, or use language features newer than C# 7.3.

## Repository shape

The solution file is `xyLOGIX.Core.Extensions.sln`.

The module contains these projects in the tarball:

- `xyLOGIX.Core.Extensions`
- `xyLOGIX.Core.Extensions.Actions`
- `xyLOGIX.Core.Extensions.Dynamic`
- `xyLOGIX.Core.Extensions.Providers.Interfaces`
- `xyLOGIX.Core.Extensions.Providers`
- `xyLOGIX.Core.Extensions.Providers.Factories`
- `xyLOGIX.Core.Extensions.Tests`

The solution also references external sibling repositories/projects, including:

- `xyLOGIX.Core.Debug`
- `xyLOGIX.Collections.Synchronized`

Do not assume those external projects can be edited as part of this repository unless the prompt explicitly provides them or requests cross-repository work.

## Module architecture and dependency direction

Maintain the existing acyclic dependency direction:

- `xyLOGIX.Core.Extensions.Providers.Interfaces` defines the provider contract.
- `xyLOGIX.Core.Extensions.Providers` implements the provider contract.
- `xyLOGIX.Core.Extensions.Providers.Factories` exposes provider factory accessors.
- `xyLOGIX.Core.Extensions` consumes the provider factory and interfaces where needed.
- `xyLOGIX.Core.Extensions.Actions` exposes independent static action helpers.
- `xyLOGIX.Core.Extensions.Dynamic` exposes independent dynamic-value helpers.
- `xyLOGIX.Core.Extensions.Tests` tests the module behavior.

Avoid circular dependencies. Before adding a project reference, verify the existing reference graph and ensure the new reference cannot create a direct or transitive cycle.

Do not split this repository into additional module projects unless explicitly requested.

## Design intent

`xyLOGIX.Core.Extensions` is a foundational utility module. Changes should preserve its role as a dependable extension-method and helper library for other xyLOGIX products.

Prioritize:

- Backward compatibility for public API consumers.
- Small, focused methods and classes.
- Extension methods that are safe to call on invalid or borderline inputs when feasible.
- Defensive validation and safe default return values.
- Clear XML documentation suitable for generated Markdown output.
- Loose coupling through existing interfaces and provider abstractions.
- Minimal churn to public API shape unless explicitly requested.

Avoid broad architectural rewrites unless they are the requested work.

## Project responsibilities

### `xyLOGIX.Core.Extensions`

This is the primary library. It contains:

- Static `*Extensions` classes for BCL, collection, path, markdown, enum, type, string, numeric, and WinForms types.
- WinForms interfaces such as `IForm`, `IControl`, `IUserControl`, `IScrollableControl`, `IComboBox`, `IListView`, and `ITextBox`.
- Helper types such as `BoundComboBox` and `EnumBoundComboBoxItem`.
- Enums and validators such as `LanguageArticleType`, `LanguageArticleTypeValidator`, and `ReplaceAnyOfOption`.
- Static helper/action-style classes such as `Calculate` and `Transform`.

When adding extension methods, place them in the extension class that matches the extended type. If no suitable class exists, create a public static `<Type>Extensions` class in the `xyLOGIX.Core.Extensions` namespace.

### `xyLOGIX.Core.Extensions.Actions`

This project contains static action classes such as `Prefer` and `Round`.

Action classes should be public static, verb-named, and expose methods whose names read fluently at the call site.

### `xyLOGIX.Core.Extensions.Dynamic`

This project contains dynamic-value helpers such as `DynamicPrefer`.

Keep dynamic-specific behavior isolated here so the main extension library does not accumulate avoidable `dynamic` usage.

### `xyLOGIX.Core.Extensions.Providers.Interfaces`

This project contains provider contracts, currently including `IControlFormAssociationProvider`.

Interfaces should define only the contract needed by consumers. Avoid leaking implementation details into interface documentation.

### `xyLOGIX.Core.Extensions.Providers`

This project contains provider implementations, currently including `ControlFormAssociationProvider`.

Provider implementations should preserve singleton-style access, defensive validation, and thread-aware collection behavior already present in the code.

### `xyLOGIX.Core.Extensions.Providers.Factories`

This project contains factory accessors such as `GetControlFormAssociationProvider`.

Factory methods should follow the existing `GetXxx.SoleInstance()` pattern.

### `xyLOGIX.Core.Extensions.Tests`

This project contains NUnit tests for extension and action behavior.

Add tests here only when requested or when the change is risky enough to warrant test coverage.

## Code-generation and response-order preferences

When generating code for this repository, produce code in reference order:

1. Code that depends on nothing else.
2. Code that depends on the preceding code.
3. Code that depends on that, and so forth.

Within a class, place field and constant declarations before properties that depend on them. This prevents paste-in workflows from producing confusing compiler errors as the code is copied from top to bottom.

When generating a brand-new Strategy Pattern family, define items in this order:

1. Strategy enum.
2. Strategy interface.
3. Abstract base class using the Template Method pattern.
4. Concrete strategy classes, one by one.
5. Factory for each concrete class when applicable.
6. Strategy factory.

Generate the smallest useful code delta that fully answers the prompt. Do not teach experienced contributors how to add files to projects unless the prompt asks for that.

If a task is large, break the work into clear steps and stop at the requested step. Do not ask about unrelated new tasks until the current task is complete.

## Coding standards

### C# language level

Use C# 7.3 syntax only.

Do not use:

- Nullable reference types.
- Records.
- Init-only setters.
- File-scoped namespaces.
- Top-level statements.
- Global using directives.
- Switch expressions.
- Range or index syntax.
- `using var` declarations.
- Default interface members.

### Defensive programming

Validate inputs early and explicitly.

Do not assume:

- Strings are nonblank.
- Paths exist.
- Collections contain useful values.
- Enum values are inside the defined value set.
- WinForms controls have handles.
- WinForms controls are not disposed or disposing.
- Cross-thread control access is safe.
- File-system operations succeed.
- External helper methods return useful values.
- Numeric, size, count, or index values are positive or in range.

Prefer simple guard clauses and early returns over deep nesting. Negate `if` statements where doing so reduces nesting and cyclomatic complexity.

Avoid combining eager-return validation gates with `&&` or `||` when separate checks would produce clearer logging and safer control flow. Prefer one validation per line with its own return path when feasible.

### Result-variable pattern

Methods that return a value should normally use a local `result` variable initialized to the default failure value.

```csharp
public bool TryDoSomething(string value)
{
    var result = false;

    try
    {
        if (string.IsNullOrWhiteSpace(value)) return result;

        // Perform work here.

        /* If we made it this far with no Exception(s) getting caught, then assume that the operation(s) succeeded. */
        result = true;
    }
    catch (Exception ex)
    {
        // dump all the exception info to the log
        DebugUtils.LogException(ex);

        result = false;
    }

    return result;
}
```

Follow the surrounding file's established result-assignment style when it is more specific than the generic example above.

For logic gates in `bool` methods, it is acceptable to set `result` to the optimistic value before a gate, log the gate, and then reset it to the default value if the gate fails. Match the surrounding method style.

### Exception handling

Most nontrivial methods in this repository are wrapped in `try`/`catch` blocks.

When adding or modifying methods:

- Catch `Exception` at the method boundary where the surrounding code does so.
- Log exceptions using `DebugUtils.LogException(ex);` unless the surrounding code uses a different mechanism.
- Place `// dump all the exception info to the log` immediately before `DebugUtils.LogException(ex);`.
- Return a safe default after logging.
- Do not swallow exceptions silently.

### Logging style

The repository uses `xyLOGIX.Core.Debug.DebugUtils` for diagnostic output.

Preserve existing logging conventions:

- Include declaring type and method context in log messages where the surrounding file does so.
- Use `*** SUCCESS ***` for successful gates or completed operations.
- Use `*** ERROR ***` for failed gates or failed operations.
- Use `*** WARNING ***` for non-fatal anomalies.
- Use `Proceeding...` or `Stopping...` when it clarifies control flow.
- Log final `Result = {result}` values where the surrounding method family does so.

Do not replace explicit diagnostic logging with terse or implicit behavior.

Refrain from using `GetType().Name` in logging messages. Prefer the literal type name in the message text when the type is known.

### PostSharp attributes

This codebase uses PostSharp attributes throughout.

Common patterns include:

- `[Log(AttributeExclude = true)]` for static constructors and methods that should be excluded from logging.
- `[ExplicitlySynchronized]` on classes that coordinate shared mutable state.
- `[NotLogged]` on parameters or return values that should not be logged.
- Assembly-level logging rules in `GlobalAspects.cs`.

Do not regenerate `GlobalAspects.cs` unless explicitly requested.

Do not apply `[Log(AttributeExclude = true)]` to enums or enum members.

Static classes that expose static helper, action, extension, or factory methods should generally define a static constructor decorated with `[Log(AttributeExclude = true)]`, matching the surrounding project style.

### `[NotLogged]` usage

Use `[NotLogged]` on method parameters that should not be captured by PostSharp logging.

Apply `[NotLogged]` to method parameters whose types are complex or sensitive, including:

- Reference types other than ordinary scalar cases.
- `object`.
- Delegates.
- WinForms controls and forms.
- Collections.
- Value types used as structured values, such as `Guid`, `Rectangle`, or other structs.

Apply `[return: NotLogged]` to methods that return non-primitive or sensitive values.

Do not add `[return: NotLogged]` to properties solely because the property type is complex. The projects' `GlobalAspects.cs` files already exclude property getters and setters from logging.

For `string` parameters and return values, follow the surrounding file and current owner preference. When in doubt, mark method `string` parameters and method `string` return values as not logged.

### Properties, fields, and accessors

Place fields and constants before properties that use them.

Use auto-properties where possible. Use backing fields only when a value must be cached, validation must be applied, or an event must be raised when a value changes.

Property getters and setters should be decorated at the accessor level with `[DebuggerStepThrough]` when the surrounding code does so.

For auto-properties, prefer this form when editing or adding similar code:

```csharp
public string Text
{
    [DebuggerStepThrough] get;
    [DebuggerStepThrough] set;
}
```

Do not use expression-bodied properties or expression-bodied accessors when the surrounding code uses statement bodies or accessor attributes.

### General code style

Prefer `var`, `out var`, and pattern matching when compatible with C# 7.3 and when the surrounding code style supports it.

Do not use `#region` or `#endregion`.

Avoid `++` and `--`; prefer `Interlocked.Increment` and `Interlocked.Decrement` when mutation must be atomic or thread-aware.

Delete dead code when a refactor makes it obsolete, unless the prompt explicitly asks to preserve it.

Do not regenerate `AssemblyInfo.cs` unless explicitly requested.

Do not place project files beside the solution file. Each project should remain in its own project directory below the solution directory.

## Extension-method conventions

Extension classes should be public static and named after the extended type, for example:

- `StringExtensions`
- `EnumerableExtensions`
- `ControlExtensions`
- `FormExtensions`
- `ComboBoxExtensions`
- `DictionaryExtensions`

When adding an extension method:

- Put it in the most specific existing `*Extensions` class.
- Use the `this` parameter name used by the surrounding class where possible.
- Validate the receiver parameter if it can be `null`.
- Prefer safe default values over thrown exceptions, unless the existing method family intentionally throws.
- Preserve XML documentation and examples consistent with nearby methods.
- Avoid extension classes outside a namespace/project ending in `.Extensions` unless the existing project already establishes a different pattern.

## WinForms extension and interface guidance

This repository includes WinForms utility extensions and lightweight interfaces, but it does not define application dialogs or wizard forms.

For WinForms extension methods:

- Respect disposed, disposing, and handle-created state checks where relevant.
- Use `InvokeIfRequired` patterns for cross-thread UI updates.
- Do not add ProjectCloner-specific dialog, MVP, wizard, or dark-theme form rules to this repository.
- Do not introduce UI control designer conventions unless this module actually adds forms or designer files.
- Do not put control text or user-visible control values into `Resources.resx` unless the repository owner explicitly asks.

For WinForms interfaces such as `IForm`, `IControl`, `IUserControl`, and related contracts:

- Keep interfaces focused on reusable surface area.
- Do not add members that are specific to one application's dialog workflow.
- Avoid introducing dependencies that would make provider/interface projects reference implementation projects.

## Provider and factory guidance

The provider trio exists to maintain clean dependency direction around control-to-form association behavior.

When changing provider behavior:

- Keep `IControlFormAssociationProvider` in the interfaces project.
- Keep `ControlFormAssociationProvider` in the provider implementation project.
- Keep `GetControlFormAssociationProvider.SoleInstance()` in the factories project.
- Do not bypass the factory from consumers that already use it.
- Preserve singleton semantics and defensive validation.
- Avoid circular references between provider projects.

Factory classes are static and named fluently, such as `GetControlFormAssociationProvider`. Factory methods should read naturally at the call site, such as `GetControlFormAssociationProvider.SoleInstance()`.

## Enum and validator guidance

Enums in this repository include `LanguageArticleType` and `ReplaceAnyOfOption`.

For enums:

- Alphabetize members when adding new ones.
- Do not assign explicit values except `Unknown = -1` where an `Unknown` member is used.
- Keep `Unknown = -1` as the final member when present.
- XML document every enum and every enum member.
- Do not apply PostSharp `[Log]` attributes to enums or enum members.

For validators:

- Keep validator logic close to the value set it validates unless a separate project is explicitly requested.
- Validate enum values before switching on them.
- Return `false` for invalid values rather than throwing unless the existing contract says otherwise.
- Provide or preserve `IsValid` and `IsValidSilent` style entry points where the surrounding validator pattern uses them.

## XML documentation standards

XML documentation is important because this repository uses Vsxmd to generate Markdown documentation.

### General rules

- Document public, internal, protected, and private code entities when generating or revising code.
- Preserve existing documentation unless the behavior changes.
- Prefer fully qualified `<see cref="..." />` references when they resolve without creating a circular dependency or requiring an inappropriate project reference.
- Use `<c>...</c>` for file names, attributes, code constructs, and conceptual type mentions that should not be cross-reference targets.
- Use `<see langword="null" />`, `<see langword="true" />`, and `<see langword="false" />` for C# keywords when referring to the keyword value.
- Use `<paramref name="..." />` when referring to a method parameter.
- Use `<para />` between adjacent documentation sentences when multiline remarks are needed.
- Prefer XML documentation that resembles Microsoft Learn output.
- Use `(Required.)` or `(Optional.)` at the beginning of `<param>` tag contents when generating new parameter documentation.
- When documenting generic types in `cref` values, prefer the backtick-plus-arity notation when needed, such as `T:Namespace.Type`1`.

### Type and member references

Use these `cref` prefixes where appropriate:

- `T:` for classes, interfaces, structs, delegates, and enums.
- `M:` for methods and constructors.
- `P:` for properties.
- `F:` for fields, constants, and enum members.
- `E:` for events.

Refer to `System.String.Empty` and `System.Guid.Empty` with `F:` references when a cross-reference is appropriate.

When referring to the `xyLOGIX.Core.Debug.DebugUtils.LogException(System.Exception,System.Boolean)` method in XML documentation, use its fully qualified method signature.

### Value-type and reference-type wording

Use reference semantics accurately.

For reference types, use wording such as `Reference to an instance of ...` when appropriate.

For value types, do not write `Reference to a...`. Prefer wording such as `A <see cref="T:System.String" /> value...`, `A <see cref="T:System.Int32" /> value...`, or `A <see cref="T:System.Guid" /> value...` as appropriate.

### Interface documentation

When creating or updating interfaces:

- Begin interface summaries with `Defines the publicly-exposed events, methods and properties of ...` when that convention fits the interface.
- Define only the public contract needed by consumers.
- Keep documentation duplicatable on implementing members.
- Avoid referring to private helper methods in interface documentation.

### Conceptual references and circular dependencies

When documentation mentions a type that is not available without creating a new reference or cycle, use `<c>TypeName</c>` rather than `<see cref="T:..." />`.

Use `<see cref="T:..." />`, `<see cref="M:..." />`, `<see cref="P:..." />`, `<see cref="F:..." />`, and `<see cref="E:..." />` only when the reference is available and appropriate.

### XML documentation formatting

The existing codebase contains both multi-line XML documentation and ReSharper-formatted wrapping. Preserve existing formatting when editing nearby code.

When generating new standalone code for paste-in use, prefer concise single-line XML documentation for each code entity when it remains readable, because ReSharper can reflow it afterward.

Do not churn XML documentation solely to change line wrapping.

## Events

When adding events:

- Do not declare an event unless it is actually raised.
- Provide a corresponding `protected virtual OnXxx(...)` method for instance members.
- Use null-conditional invocation, for example `SomeEvent?.Invoke(...)`.
- Preserve existing delegate and `EventArgs` patterns.
- Remove the `sealed` modifier from a class if a new `protected virtual` event invoker must be added.

For static classes, follow the existing event-raising pattern used by the surrounding code.

## Collections, iteration, and LINQ

Avoid materializing collections unless it is necessary for correctness, performance, or thread safety.

Do not iterate an `IEnumerable<T>` more than once needlessly.

When a thread-safe snapshot is required, materialize with `ToArray()` and iterate the snapshot, unless the source is already a known concurrent or synchronized collection.

Avoid LINQ extension methods in hot, multithreaded, or parallel-processing paths when an explicit loop provides safer control. LINQ is acceptable in ordinary non-thread-sensitive code when it improves clarity and matches the surrounding implementation.

Preserve `AdvisableDictionary` or other synchronized collection usage where already present.

## Package and dependency management

This module intentionally uses `packages.config` and locked package versions.

When changing dependencies:

- Do not migrate to `PackageReference` unless explicitly requested.
- Do not update package versions as an incidental cleanup.
- Keep `allowedVersions` ranges aligned with pinned package versions where already present.
- Keep `PostSharp.props`, `PostSharp.targets`, `NUnit.props`, and `Vsxmd.targets` imports intact.
- Do not add project references unless there is a clear requirement and no circular dependency risk.

## Build and generated documentation behavior

The projects import Vsxmd targets and contain generated `README.md` files.

When changing XML documentation or project metadata:

- Ensure the generated documentation remains useful.
- Avoid breaking Vsxmd generation.
- Keep project `README.md` files and XML docs conceptually aligned when public API behavior changes.
- Do not churn generated documentation unless the prompt asks for it or the source documentation change requires it.

## Source formatting

Preserve the existing formatting style unless the prompt specifically requests formatting changes.

The codebase currently contains:

- Legacy CRLF-formatted files.
- BOM-prefixed C# files in many places.
- Multi-line XML documentation in many existing files.
- ReSharper-friendly accessor attributes such as `[DebuggerStepThrough] get;`.
- Long method and documentation blocks that favor clarity over terseness.

Do not churn files for formatting-only reasons unless that is the requested change.

When editing only formatting, ensure behavior, metadata values, package IDs, package versions, target frameworks, and binding redirects remain unchanged.

## Testing guidance

The repository includes `xyLOGIX.Core.Extensions.Tests` using NUnit 4.3.2.

When adding or updating tests:

- Put tests in `xyLOGIX.Core.Extensions.Tests` unless a new test project is explicitly requested.
- Prefer focused fixtures that correspond to the concrete class or extension class under test.
- Preserve existing NUnit style and naming patterns.
- Use `Assert.That(...)` as the surrounding tests do.
- Wrap test bodies in `try`/`catch` when following repository-wide test style.
- Log exceptions and rethrow them; do not swallow test failures.

## Read-before-write workflow

Before modifying existing code:

1. Read the target file.
2. Read nearby related files, especially interfaces, providers, factories, enums, validators, and tests.
3. If a class is `partial`, scan adjacent files for other parts of the same class.
4. Check the `.csproj` for compile inclusion and package/reference context.
5. Determine whether the requested change already exists.
6. Emit the smallest useful delta.

Do not regenerate an entire file when a small targeted change is sufficient.

When producing a drop-in replacement for an existing file, keep unchanged code faithful to the original file.

## Commit-message guidance

Commit messages should follow the repository's concise outline style:

- First line: present-tense, sentence-case summary, no more than 50 characters.
- First word of the first line is a present-tense verb.
- If a single file is being added as the only change, use `Create` followed by the file name.
- If a single file is being modified as the only change, use `Update` followed by the file name.
- Second line: blank.
- Body: present-tense outline bullets.
- Wrap file names, paths, code entities, package IDs, XML elements, and values in backticks in the body.
- Do not put backticks in the top line.
- Do not use Comprehensive Commit format.

## Pull request and issue guidance

When drafting issues or pull requests:

- Be concise and technical.
- Use backticks around code entities, file names, paths, package IDs, and configuration values.
- Do not use Comprehensive Commit format for titles.
- Keep the focus on the requested change and observed repository behavior.

## Out-of-scope guidance from other repositories

Do not copy ProjectCloner-specific dialog, MVP, wizard, dark-theme control, Visual Studio Template Wizard, or application workflow conventions into this repository unless this codebase later adds those components.

This `CONTRIBUTING.md` intentionally does not require:

- MIT license headers.
- Mandatory source-file header blocks.
- ProjectCloner-specific WinForms dialog rules.
- MVP presenter wiring rules for application dialogs.
- Wizard step dialog conventions.
- Dark-theme control conventions for application forms.

Those patterns belong to other xyLOGIX repositories unless explicitly introduced here.

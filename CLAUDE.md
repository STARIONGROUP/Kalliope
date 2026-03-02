# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Kalliope is a set of C# libraries for reading and writing ORM2 (Object-Role Modeling) files. It is used by Starion Group to perform code generation from ORM models. Licensed under Apache 2.0.

## Build & Test Commands

```bash
# Restore and build
dotnet restore Kalliope.sln
dotnet build Kalliope.sln --no-restore

# Run all tests
dotnet test Kalliope.sln --no-build --verbosity normal

# Run a single test by fully qualified name
dotnet test Kalliope.sln --no-build --filter "FullyQualifiedName~Kalliope.Generator.Tests.Generators.DtoGeneratorTestFixture.Verify_that_DTOs_are_generated"

# Run all tests in a specific test class
dotnet test Kalliope.sln --no-build --filter "FullyQualifiedName~DtoGeneratorTestFixture"

# Run a specific test project
dotnet test Kalliope.Generator.Tests/Kalliope.Generator.Tests.csproj --no-build

# Test with coverage (as CI does)
dotnet-coverage collect "dotnet test Kalliope.sln --no-restore --no-build" -f xml -o "coverage.xml"
```

Target frameworks: `netstandard2.0` for libraries, `net10.0` for generators and tests.

## Architecture

### Data Flow

```
ORM2 files (.orm)
    → [Kalliope.Xml] OrmXmlReader deserializes into DTOs
    → [Kalliope.Dal] Assembler converts DTOs → POCOs (with ConcurrentDictionary cache)
    → [Kalliope] POCO object graph (domain model)
    → [Kalliope.OO] ClassGenerator maps to OO classes
```

### Code Generation Flow

```
[Kalliope] POCO classes decorated with [Domain], [Property], [Container] attributes
    → [Kalliope.Generator] DropGenerator reflects on POCOs → TypeDrop/PropertyDrop
    → DotLiquid templates (in Kalliope.Generator/Templates/)
    → Generated output: Kalliope.DTO/AutoGenDto/, Kalliope.Dal/AutoGenModelThing/
```

### Projects

- **Kalliope** — Core POCO domain model (~239 classes). Root entity is `OrmRoot`; base class is `ModelThing`. Key types: `ObjectType`, `EntityType`, `ValueType`, `FactType`, `Role`, constraints. Organized into namespaces: Core, Absorption, Diagrams, CustomProperties, ShapeGrouping.
- **Kalliope.Common** — Custom attributes (`PropertyAttribute`, `ContainerAttribute`, `DomainAttribute`) and enums (`TypeKind`, `AggregationKind`, `Multiplicity`) that drive code generation via reflection.
- **Kalliope.DTO** — Auto-generated Data Transfer Objects. `AutoGenDto/` is generated; partial classes in `Dto/` are hand-coded. Do not hand-edit files in `AutoGenDto/`.
- **Kalliope.Dal** — Auto-generated assembler extensions and factories in `AutoGenModelThing/`. Converts DTOs to POCOs using `Assembler` with `Lazy<ModelThing>` and `ConcurrentDictionary`.
- **Kalliope.Generator** — Code generator using DotLiquid templates and Roslyn for formatting. Templates: `dto-class-template.liquid`, `poco-extensions-class-template.liquid`, `poco-factory-class-template.liquid`, etc.
- **Kalliope.Xml** — Reads/writes ORM2 `.orm` files (NORMA/NORMA Pro format).
- **Kalliope.OO** — Maps ORM models to object-oriented classes (`EntityClass`, `ObjectifiedClass`, `Property`, `ReferenceProperty`).

### Testing

- NUnit 4.x with `[TestFixture]` classes named `*TestFixture`. Mocking with Moq. Use Assert.That syntax.
- Generator tests compare output against `Expected/` reference files. Line endings are normalized for cross-platform comparison.
- XML tests use ORM model files from `Data/` directories (Bird Identification, IT Management, ORM_Lab1-8, Talent, etc.).

## Code Style

- 4-space indentation, no tabs
- No underscore prefix for member names; use `this.` for instance access
- Use `var` when the type is obvious; use C# type aliases (`int` not `Int32`)
- Always use curly braces for blocks, even single-line
- `using` statements inside namespace
- No `#region` directives
- All files must have the Apache 2.0 copyright header with "Starion Group S.A."
- ReSharper `.DotSettings` file is available for style enforcement

## Branch Strategy

- `master` — stable releases
- `development` — integration branch
- Feature branches off `development`; PRs go to `development`, never from/to `master` directly

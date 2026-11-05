# C# Practice Tutorial

A collection of small C# console applications for practicing language fundamentals, object-oriented programming, collections, and generics. Each project has its own `Program.cs` with examples you can read, run, and modify independently.

## Projects

| Project | Topics |
| --- | --- |
| `C# Tutorial` | Data types, parsing, dates, output formatting, and string operations |
| `Conditionals While Exceptions` | Conditionals, switch statements, loops, user input, and exception handling |
| `Looping Arrays StringBuilder` | Arrays, array operations, loops, `StringBuilder`, globalization, and type casting |
| `Classes & OOP` | Classes, objects, methods, constructors, and inheritance |
| `Constructors Properties` | Constructor overloads, getters, setters, validation, and static members |
| `Inheritance Polymorphism` | Inheritance, method overriding, nested classes, and polymorphism |
| `Abstract Class Polymorphism` | Abstract classes and shape implementations with circles and rectangles |
| `Interfaces` | Interface implementations with vehicles, electronic devices, and commands |
| `Collections` | `ArrayList`, dictionaries, queues, stacks, and collection operations |
| `Generics` | Generic lists, methods, structs, and delegates |
| `OOP Game` | A console battle simulation using warrior and battle classes |
| `Various` | Basic variables and console output |

## Requirements

- [Git](https://git-scm.com/downloads) to clone the repository.
- [.NET SDK](https://dotnet.microsoft.com/download):
  - .NET 8 SDK and runtime for all projects except `Various`.
  - .NET 10 SDK and runtime for `Various`, which targets `net10.0`.
- Optional: a C# editor such as Visual Studio or Visual Studio Code.

Install both .NET versions if you want to run every project. Check your installed SDKs and runtimes with:

```sh
dotnet --list-sdks
dotnet --list-runtimes
```

## Getting Started

Clone the repository and enter its directory:

```sh
git clone https://github.com/muktadiranik/cs-practice-tutorial.git
cd cs-practice-tutorial
```

Run an individual project from the repository root:

```sh
dotnet run --project "C# Tutorial/C# Tutorial.csproj"
```

Try other examples by changing the project path:

```sh
dotnet run --project "Abstract Class Polymorphism/Abstract Class Polymorphism.csproj"
dotnet run --project "Collections/Collections.csproj"
dotnet run --project "Various/Various.csproj"
```

`dotnet run` restores dependencies and builds the selected project automatically. Some examples, especially `Conditionals While Exceptions`, prompt for console input.

## Building

Build a single project without running it:

```sh
dotnet build "Generics/Generics.csproj"
```

The solution currently includes only `C# Tutorial`, `Classes & OOP`, `Conditionals While Exceptions`, and `Looping Arrays StringBuilder`. Build those four together with:

```sh
dotnet build cs-practice-tutorial.sln
```

Build or run the remaining projects directly using their `.csproj` paths.

## Practicing

Start with the fundamentals, move through classes and inheritance, and then explore interfaces, collections, and generics. Read each project's `Program.cs`, predict the output, run it, and experiment with the values or add your own examples.

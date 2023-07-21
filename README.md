# Advanced C# Practice

Understand more advanced C# coding.
The content below is learning notes.

- [x] Linq: Integration of query capabilities, AKA queries against data are expressed as simple strings without type checking at compile time or IntelliSense support;
- [x] Non-specific to a particular data type. Define generic classes, interfaces, abstract classes, fields, methods, static methods, properties, events, delegates, and operators using the type parameter and without the specific data type, similar to C++ templates;
- [x] CLR: Common Language Runtime is like JVM but only runs on Windows.
- Both Vritual Machines (VMs)
- Both include garbage collection
- Both employ stack-based operations
- Both include runtime-level security
- Both have methods for exception handling
- Intermediate language is compiled at runtime to machine language through just-in-time compilation
- [x] Mono: Free and Open Source/ Xamarin Lead/ Cross-platform/ Better Development Tools for Linux
- .NetFramework: WPF, Windows Forms, ASP.NET - Base Libraries: .Net Framework Class Library
- .NET Core: UWP, ASP.NET Core - Base Libraries: CoreFx Class Library
- Xamarin: Xamarin.iOS, Xamarin.Android, Xamarin.Forms, Xamarin.Mac - Base Libraries: Mono Class Library
- [x] .Net Standard Library: One library to rule them all later introduced by Microsoft
- [x] Delegates: a type safe function pointer, a reference type variable that can hold a reference to a method in order to delegate to reference a particular method. 
- The delegate must define parameters with types that match the parameter types contained in the relevant method.
- A delegate must also define a return type that matches the return type of the relevant method.
- Whenever a delegate is instantiated, its instance can be associated with any method with compatible parameters and return type that can be invoked or called through the delegate instance.
- Basically multiple methods can be invoked or called thorugh one delegate call.
- [ ] Variance: 
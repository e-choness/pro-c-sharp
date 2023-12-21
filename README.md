# S.O.L.I.D Principle - C# Version

## Dependency Inversion

Utilizing interfaces and factories to decouple dependencies from each of the classes.
So that we can use each classes based on their abstractions rather than direct calls.

### SOLID Library

| Class | Interface |
|---|---|
| `ILogger` | `Logger` |
| `IMessageSender` | `Mailer` |
| `IMessageSender` | `Texter` |
| `Retailer` | `IVendor` |
| `Game` | `IProduct` |

### Take Away

In this case IMessageSender is decoupling Texter and Mailer from their dependencies for Retailer. When creating a new instance of Retailer, Both Mailer and Texter can be used for its constructor, no need to override or modify the class directly and worry about modifying the other parts of the program ending up break anything.

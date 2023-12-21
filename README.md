# S.O.L.I.D Principle - C# Version

## Single Responsibility

For code readability and maintainability, most of the code are best be written in multiple segaments. Ideally programmers don't have to scroll up and down to read a single function. Each of the methods just do one thing, that one function can be reused in multiple places.

For this example

- `GameValidator` only takes game copy information to validate it's id and price.
- `WishlistRecorder` only takes game copy information and record it to a wishlist.
- `StandardMessager` only outputs messages that are relevant to the situations such as application starting and ending messages, validation errors, etc.

TODO: No wishlist in this demo yet, it would be nice to add in the future.

### Take Away

A good tech design solution before coding is always a good practice, make sure to think through which part of the product can be generalized in the code and consider possible resuable functions to extract from.

## Dependency Inversion

Utilizing interfaces and factories to decouple dependencies from each of the classes.
So that we can use each classes based on their abstractions rather than direct calls.

### Take Away

In this case `IMessageSender` is decoupling `Texter` and `Mailer` from their dependencies for `Retailer`. When creating a new instance of `Retailer`, Both `Mailer` and `Texter` can be used for its constructor, no need to override or modify the class directly and worry about modifying the other parts of the program ending up break anything.

## SOLID Library

| Interface | Class | Description |
|---|---|---|
| `ILogger` | `Logger` | Logging information on the console. |
| `IMessageSender` | `Mailer` | Sending sales message through email. |
| `IMessageSender` | `Texter` | Sending sales message through text message. |
| `Retailer` | `IVendor` | Manage sales and stocks. |
| `Game` | `IProduct` | A model that helds game copy information. |
|  | `GameValidator` | A service that validates game copy information. |
|  | `StandardMessager` | A service that holds application messages |
|  | `WishlistRecorder` | A service that record game copy information to a wishlist |
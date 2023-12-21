# S.O.L.I.D Principle - C# Version

## :paperclip: Single Responsibility

For code readability and maintainability, most of the code are best be written in multiple segaments. Ideally programmers don't have to scroll up and down to read a single function. Each of the methods just do one thing, that one function can be reused in multiple places.

For this example

- `GameValidator` only takes game copy information to validate it's id and price.
- `WishlistRecorder` only takes game copy information and record it to a wishlist.
- `StandardMessager` only outputs messages that are relevant to the situations such as application starting and ending messages, validation errors, etc.

- [x] ~~No wishlist in this demo yet, it would be nice to add in the future.~~ Wishlist is now in Open Close Principle Demo.

### :pencil2: Take Away

A good tech design solution before coding is always a good practice, make sure to think through which part of the product can be generalized in the code and consider possible resuable functions to extract from.

## :open_file_folder: Open Close Principle

For the code extensibility and scalability, the less we try to navigate multiple places to make a single change would be better than apply changes to different parts of the code and introduce potential bugs in the future.

Open Close Principle can help retain the part of the model used in the code and expand it without modifying existing code (Addition instead of change).

For this example

- `IWishlisted` makes sure that each genre of the games can have a associated genre whenever a wishlist record is created.
- `WishlistRecorder` is responsible for creating and recording game info into a wishlist record. When a record is in the list, just check `IsWishlisted` to `true`.

### :pencil2: Take Away

Another way to achieve open close principle is to use virtual and override to make sure the code doesn't repeat the same part over and over again. In this example however, it works in this scale.

## :gem: Dependency Inversion

Utilizing interfaces and factories to decouple dependencies from each of the classes.
So that we can use each classes based on their abstractions rather than direct calls.

### :pencil2: Take Away

In this case `IMessageSender` is decoupling `Texter` and `Mailer` from their dependencies for `Retailer`. When creating a new instance of `Retailer`, Both `Mailer` and `Texter` can be used for its constructor, no need to override or modify the class directly and worry about modifying the other parts of the program ending up break anything.

## :book: SOLID Library

| Interface | Class | Description |
|---|---|---|
| `ILogger` | `Logger` | Logging information on the console. |
| `IMessageSender` | `Mailer` | Sending sales message through email. |
| `IMessageSender` | `Texter` | Sending sales message through text message. |
| `IVendor` | `Retailer` | Manage sales and stocks. |
| `IProduct` | `Game` | A model that helds game copy information. |
| `IWishlisted` | `RolePlayingGame` | Role Playing Game info model |
| `IWishlisted` | `FirstPersonShooter` | First Person Shooter info model |
| `IWishlisted` | `RealTimeStrategy` | Real Time Strategy info model |
| `IWishlisted` | `ImmersiveSims` | Immersive Sims info model |
|  | `GameValidator` | A service that validates game copy information. |
|  | `StandardMessager` | A service that holds application messages |
|  | `WishlistRecorder` | A service that record game copy information to a wishlist |

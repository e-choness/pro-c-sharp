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

## :cyclone: Liskov Substitution Principle

The principle's name doesn't help understand the concept of it at all 😕. But sitting through it's definition, it all comes down to help programmers to structure readable and expandable code using better inheritance methods.

For this example

- `Personnel` is the base class has all the common traits of any employees of the store system. Have a contract `IPersonnel` helps to create a base interface that enforces `Personnel` to implement all the members needed.
- `IManager` can have a hashset of team members that are marked as `IManaged`.
- `IManaged` members only apply to the ones that have a manager above the hireracy, and one manager can be assigned via any models that have `IManager` as contract.
- Both `IManager` and `IMananged` are inherited from `IPersonnel`, because interfaces cannot directly inherit from concrete class, this is an extra step to make sure those contracts have the base class properties.

### :pencil2: Take Away

Keep specific traits separated from the base class helps reduce redundancies from badly designed inheritance structure. Some objects do not necessarily inherit from the same class, only share the same traits. It would be better to take those traits out and have a interface to indicate them.

## :dizzy_face: Interface segregation

Instead of a gigantic definition of one class that has all the members and methods in one definition. Divide and conquer each pieces of them so that we can create monstrosities little by little, just kidding...

For this example

- `IDigitalCopy` and `IPhysicalCopy` are implemented with different purchasing information. Digital copies are often done in online transactions, so keep record of transaction id and customer email makes sense. Physical copies can be purchased in stores and online, they both have receipts and often customer phone numbers are contact info.
- `IStandardEdition` is the base interface that holds only bare minimum information of a game copy.
- `ISpecialEdition` inherits from `IStandardEdition` with some more little gadgets. :sleepy:
- `IGotyEdition` further inherits from `ISpecialEdition` with even more juicy stuff. Then you will see the monstrosity that is `GotyFullGame` that got out of this contract.

### :pencil2: Take Away

Interface segregation is a useful tool to implement the only parts that are necessary for creating models and components and get rid of the parts that are not needed.

## :gem: Dependency Inversion

Utilizing interfaces and factories to decouple dependencies from each of the classes.
So that we can use each classes based on their abstractions rather than direct calls.

For this example

- `IMessageSender` is decoupling `Texter` and `Mailer` from their dependencies for `Retailer`.
- When creating a new instance of `Retailer`, Both `Mailer` and `Texter` can be used for its constructor, no need to override or modify the class directly and worry about modifying the other parts of the program ending up break anything.

### :pencil2: Take Away

Make sure the functionalities are contained within the classes and have them handle what is their supposed responsibilities. Avoid direct dependencies and instantiations as much as possible so that the modules are reusable for development, production and tests.

## :book: SOLID Library

| Interface | Class | Description |
|---|---|---|
| `ILogger` | `Logger` | Logging information on the console. |
| `IMessageSender` | `Mailer` | Sending sales message through email. |
| `IMessageSender` | `Texter` | Sending sales message through text message. |
| `IVendor` | `Retailer` | Manage sales and stocks. |
| `IProduct` | `Game` | A model that helds game copy information. |
| `IWishlisted` | `RolePlayingGame` | Role Playing Game info model. |
| `IWishlisted` | `FirstPersonShooter` | First Person Shooter info model. |
| `IWishlisted` | `RealTimeStrategy` | Real Time Strategy info model. |
| `IWishlisted` | `ImmersiveSims` | Immersive Sims info model. |
| `IPersonnel` | `Personnel` | A base model for store employees. |
| `IManaged` | `Receptionist` | A model for receptionist. |
| `IManaged` `IManager`| `StoreSupervisor` | A model for store supervisor. |
| `IManager` | `StoreOverseer` | A model for store overseer. |
| `IDigitalCopy` `IStandardEdition` | `StandardDigitalGame` | Standard edition digital game definition inherited from `Game` |
| `IPhysicalCopy` `ISpecialEdition` | `SpecialPhysicalGame` | Special edition physical game copy definition inherited from `Game` |
| `IPhysicalCopy` `IDigital` `IGotyEdition` | `GotyFullGame` | What a monstrosity I've created... Geez :satisfied: |
|  | `GameValidator` | A service that validates game copy information. |
|  | `StandardMessager` | A service that holds application messages. |
|  | `WishlistRecorder` | A service that record game copy information to a wishlist. |

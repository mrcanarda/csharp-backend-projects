// // // // // // // // DAY 2 - OOP: Class, Constructor, Property

// // // // // // // User user1 = new User("Can", "can@example.com", 25);
// // // // // // // User user2 = new User("Eylul", "eylul@example.com", 24);

// // // // // // // user1.PrintInfo();
// // // // // // // user2.PrintInfo();

// // // // // // // Console.WriteLine(user1.GetSummary());

// // // // // // // user1.IsActive = false;
// // // // // // // Console.WriteLine($"User1 active: {user1.IsActive}");

// // // // // // // class User
// // // // // // // {
// // // // // // //     public string Name { get; set; }
// // // // // // //     public string Email { get; set; }
// // // // // // //     public int Age { get; set; }
// // // // // // //     public bool IsActive { get; set; }

// // // // // // //     public User(string name, string email, int age)
// // // // // // //     {
// // // // // // //         Name = name;
// // // // // // //         Email = email;
// // // // // // //         Age = age;
// // // // // // //         IsActive = true;
// // // // // // //     }

// // // // // // //     public void PrintInfo()
// // // // // // //     {
// // // // // // //         Console.WriteLine($"Name: {Name}, Email: {Email}, Age: {Age}, Active: {IsActive}");
// // // // // // //     }

// // // // // // //     public string GetSummary()
// // // // // // //     {
// // // // // // //         return $"{Name} ({Email})";
// // // // // // //     }
// // // // // // // }

// // // // // // // DAY 2 - OOP: Inheritance

// // // // // //  // Base class 

// // // // // // Animal user1 = new Dog("Rex", "German Shepherd");
// // // // // // Animal user2 = new Cat("Whiskers"); 

// // // // // // user1.MakeSound();
// // // // // // user2.MakeSound();

// // // // // // user1.PrintInfo(); 
// // // // // // user2.PrintInfo(); 

// // // // // // // Base class 
// // // // // // abstract class Animal
// // // // // // {
// // // // // //     public string Name {get; set; }

// // // // // //     public Animal(string name)
// // // // // //     {
// // // // // //         Name = name;
// // // // // //     }
// // // // // //     // Abstract method - must be implemented by child
// // // // // //     public abstract void MakeSound(); 

// // // // // //         // Virtual method - can be overridden by child 
// // // // // //         public virtual void PrintInfo()
// // // // // //     {
// // // // // //         Console.WriteLine($"Animal: {Name}"); 
// // // // // //     }

// // // // // // }

// // // // // // // Child class - Dog 
// // // // // // class Dog : Animal
// // // // // // {
// // // // // //     public string Breed {get; set; }
// // // // // //        public Dog(string name, string breed) : base(name)
// // // // // //     {
// // // // // //         Breed = breed;
// // // // // //     }

// // // // // //     // override abstract method 

// // // // // //     // Override abstract method - zorunlu
// // // // // //     public override void MakeSound()
// // // // // //     {
// // // // // //         Console.WriteLine($"{Name} says: Woof!");
// // // // // //     }
// // // // // //   // Override virtual method - isteğe bağlı
// // // // // //     public override void PrintInfo()
// // // // // //     {
// // // // // //         Console.WriteLine($"Dog: {Name}, Breed: {Breed}");
// // // // // //     }
// // // // // // }
// // // // // // // Child class - Cat
// // // // // // class Cat : Animal
// // // // // // {
// // // // // //     public Cat(string name) : base(name) { }

// // // // // //     public override void MakeSound()
// // // // // //     {
// // // // // //         Console.WriteLine($"{Name} says: Meow!");
// // // // // //     }
// // // // // //     // PrintInfo override yok - Animal'ın default'u kullanılır
// // // // // // }
// // // // // // DAY 3 - OOP: Interface

// // // // // // Interface = a contract. Any class that implements it MUST define these methods.
// // // // // // A class can implement multiple interfaces — unlike inheritance (single base class only).


// // // // // Duck donald = new Duck("Donald");
// // // // // Fish nemo   = new Fish("Nemo");
// // // // // Eagle sam   = new Eagle("Sam");

// // // // // // List<ISwimmable> can hold any object that implements ISwimmable
// // // // // // Donald (Duck) and Nemo (Fish) qualify — Sam (Eagle) does not
// // // // // Console.WriteLine("=== Swimmers ==="); 
// // // // // List<ISwimmable> swimmers = new() { donald, nemo };

// // // // // foreach(ISwimmable swimmer in swimmers)
// // // // // {
// // // // //     swimmer.Swim(); 
// // // // //     Console.WriteLine($"Syle: {swimmer.SwimStyle}");
// // // // // }

// // // // // // List<IFlyable> can hold Duck and Eagle — Fish does not qualify
// // // // // Console.WriteLine("\n=== Flyers ===");
// // // // // List<IFlyable> flyers = new() { donald, sam };

// // // // // foreach (IFlyable flyer in flyers)
// // // // // {
// // // // //     flyer.Fly();
// // // // //     Console.WriteLine($"  Max altitude: {flyer.MaxAltitudeMeters} m");
// // // // // }

// // // // // // 'is' keyword — checks if an object implements an interface at runtime
// // // // // // If true, typed variable is available directly (no cast needed)
// // // // // Console.WriteLine("\n=== Capability Check ===");
// // // // // CheckCapabilities(donald);
// // // // // CheckCapabilities(nemo);
// // // // // CheckCapabilities(sam);

// // // // // static void CheckCapabilities(object animal)
// // // // // {
// // // // //     string name = animal.GetType().Name;

// // // // //        if (animal is ISwimmable swimmer)
// // // // //         Console.WriteLine($"{name} can swim  — style: {swimmer.SwimStyle}");

// // // // //         if (animal is IFlyable flyer)
// // // // //    Console.WriteLine($"{name} can fly   — max altitude: {flyer.MaxAltitudeMeters} m");
// // // // // }

// // // // // // Interfaces -- 

// // // // // interface ISwimmable
// // // // // {
// // // // //     void Swim(); 
// // // // //     string SwimStyle {get; }
// // // // // }

// // // // // interface IFlyable
// // // // // {
// // // // //     void Fly();
// // // // //     int MaxAltitudeMeters{get; }
// // // // // }

// // // // // // Classes--- 

// // // // // // Duck implements both interfaces 

// // // // // class Duck : ISwimmable, IFlyable
// // // // // {
// // // // //     public string Name {get; }

// // // // //     public Duck(string name)
// // // // //     {
// // // // //         Name = name; 
// // // // //     }

// // // // //     // Swimmable 
// // // // //     public void Swim ()
// // // // //     {
// // // // //     Console.WriteLine($"{Name} (Duck) is paddling on the water.");
// // // // //     }
// // // // //     public string SwimStyle => "Paddling"; 

// // // // //     // Flyable 
// // // // //     public void Fly()
// // // // //     {
// // // // //         Console.WriteLine($"{Name} (Duck) is flying low over the lake.");
// // // // //     }
// // // // //     public int MaxAltitudeMeters => 500;
// // // // // }

// // // // // // Fish implements only ISwimmable 

// // // // // class Fish: ISwimmable
// // // // // {
// // // // //     public string Name {get; }

// // // // //     public Fish (String name)
// // // // //     {
// // // // //         Name = name;
// // // // //     }
// // // // //     public void Swim()
// // // // //     {
// // // // //       Console.WriteLine($"{Name} (Fish) is gliding silently through the water.");
// // // // //     } 
// // // // //     public string SwimStyle => "Gliding"; 
// // // // // }

// // // // // // Eahle implements only IFlyable

// // // // // class Eagle : IFlyable
// // // // // {
// // // // //     public string Name { get; }

// // // // //    public Eagle(string name)
// // // // //     {
// // // // //         Name = name;
// // // // //     }

// // // // //     public void Fly()
// // // // //     {
// // // // //         Console.WriteLine($"{Name} (Eagle) is soaring ag high altitude.");
// // // // //     }

// // // // //     public int MaxAltitudeMeters => 3000; 
// // // // // }

// // // // // DAY 4 - OOP: Encapsulation

// // // // // private  = only accessible inside this class
// // // // // protected = accessible inside this class AND subclasses
// // // // // public  = accessible from anywhere



// // // // BankAccount account = new BankAccount ("Can", 1000); 
// // // // account.PrintInfo(); 

// // // // account.Deposit(500); 
// // // // account.Withdraw(200); 
// // // // account.Withdraw(9999); 

// // // // account.PrintInfo(); 

// // // // // This would cause a compile error — balance is private:
// // // // // account._balance = 99999; 

// // // // Console.WriteLine("\n--- Inheritance + Encapsulation ---"); 

// // // // PremiumAccount premium = new PremiumAccount("Eylul", 2000);
// // // // premium.Deposit(1000); 
// // // // premium.PrintInfo(); 
// // // // premium.ApplyBonus(); 

// // // // premium.PrintInfo(); 

// // // // // Base class 
// // // // class BankAccount
// // // // {
// // // //     // private - only this class can read or modify _balance
// // // //     private decimal _balance; 

// // // //     // public - readable from outside but bo public setter 
// // // //     public string OwnerName {get; }

// // // //     public BankAccount(string ownerName, decimal initialBalance)
// // // //     {
// // // //         OwnerName = ownerName; 
// // // //         _balance = initialBalance;
// // // //     }

// // // //     public void Deposit(decimal amount)
// // // //     {
// // // //         if (amount <= 0)
// // // //         {
// // // //             Console.WriteLine("Deposit amount must be positive."); 
// // // //             return;
// // // //         }
// // // //         _balance += amount;
// // // //         Console.WriteLine($"Deposit {amount:C}. New balance: {_balance:C} ");
// // // //     }

// // // //     public void Withdraw(decimal amount)
// // // //     {
// // // //         if (amount > _balance)
// // // //         {
// // // //             Console.WriteLine($"Insufficient funds. Balance: {_balance:C}"); 
// // // //             return; 
// // // //         }
// // // //         _balance -= amount; 
// // // //         Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}"); 
// // // //     }
// // // //     public void PrintInfo()
// // // //     {
// // // //         Console.WriteLine($"Account owner: {OwnerName} | Balance: {_balance:C}"); 
// // // //     }

// // // //     // protected - subclasses can access _balance through this 

// // // //     protected decimal GetBalance () => _balance;

// // // //     // protected - subclasses can modify _balance in a controlled way 
// // // //     protected void SetBalance(decimal amount)
// // // // {
// // // //     _balance = amount;
// // // // }
// // // // } 

// // // // // Subclass — accesses _balance only through protected methods

// // // // class PremiumAccount : BankAccount
// // // // {
// // // //     public PremiumAccount(string ownerName, decimal initialBalance) 
// // // //         : base(ownerName, initialBalance) { }

// // // //         public void ApplyBonus()
// // // //     {
// // // //         decimal bonus = GetBalance() * 0.10m; 
// // // //         SetBalance(GetBalance() + bonus); 
// // // //         Console.WriteLine($"Bonus applied: + {bonus:C}");
// // // //     }
// // // // }

// // // // DAY 5 - Collections: List<T> and Dictionary<TKey, TValue>


// // // // List <T> --- 

// // // using System.Net.Http.Headers;

// // // List <string> cities = new List<string>(); 

// // //  // Add 
// // //  cities.Add("Istanbul"); 
// // //  cities.Add("Berlin"); 
// // //  cities.Add("Tokyo"); 
// // //  cities.Add("Berlin"); 

// // //  Console.WriteLine($"Count: {cities.Count}"); 

// // //  // Access by index 
// // //  Console.WriteLine($"first city: {cities[0]}"); 

// // //  // Contains 

// // // Console.WriteLine($"Has Tokyo: {cities.Contains("Tokyo")}"); 

// // // //Remove 
// // // cities.Remove("Berlin"); // Remove only the first match 
// // // Console.WriteLine($"After remove, count: {cities.Count}"); 

// // // // Iterate 
// // // foreach (string city in cities )
// // // {
// // //     Console.WriteLine($" - {city}"); 
// // // }

// // // // List of object 
// // // List<Product> products = new List<Product>
// // // {
// // //     new Product("Keyboard", 79.99m), 
// // //     new Product("Mouse", 49.99m), 
// // //     new Product("Monitor", 39.99m)
// // // }; 

// // // // Find - returns first match or null 
// // // Product? found= products.Find(p => p.Name == "Mouse"); 
// // // Console.WriteLine($"\nFound: {found?.Name} - {found?.Price:C}"); 

// // // // RemoveAll - removes every match 

// // // products.RemoveAll(p => p.Price < 100m); 
// // // Console.WriteLine($"After RemoveAll (price < $100): {products.Count} products left"); 

// // // // --- Dictionary<TKey, TValue> ---
// // // // Key-value pairs. Keys must be unique. 

// // // Dictionary<string, int> scores = new Dictionary<string, int>();

// // // // Add 
// // // scores.Add("Can", 95); 
// // // scores.Add("Eylul", 88); 
// // // scores.Add("Cem", 72); 

// // // // Access by key 
// // // Console.WriteLine($"\nCan's score: {scores["Can"]}");

// // // // Update 
// // // scores["Can"] = 100; 
// // // Console.WriteLine($"Can's updated score: {scores["Can"]}"); 

// // // if (scores.ContainsKey("Eylul"))
// // // {
// // //     Console.WriteLine($"Eylul's score: {scores["Eylul"]}"); 
// // // }

// // // // TryGetValue — safer alternative to direct access

// // // if (scores.TryGetValue("Cem", out int cemScore))
// // // {
// // //     Console.WriteLine($"Cem's score: {cemScore}");
// // // } 

// // // // Iterate 

// // // Console.WriteLine("\nAll scores:");
// // // foreach (KeyValuePair<string, int> entry in scores)
// // // {
// // //     Console.WriteLine($"{entry.Key}: {entry.Value}");
// // // }

// // // // Remove 
// // // scores.Remove("Cem");
// // // Console.WriteLine($"After remove, count: {scores.Count}");

// // //  class Product
// // // {
// // //     public string Name {get; }
// // //     public decimal Price {get; }

// // //     public Product(string name, decimal price)
// // //     {
// // //         Name = name; 
// // //         Price = price; 
// // //     }
// // // }

// // // DAY 6 - LINQ: Where, Select, OrderBy, FirstOrDefault

// // // LINQ lets you query collections like a database.
// // // Two styles exist — we use method syntax (more common in real projects). 

// // using System.Net.Http.Headers;

// // List<Product> products = new List<Product>
// // {
// //     new Product("Keyboard", 79.99m, "Electronics"), 
// //     new Product("Mouse", 49.99m, "Electronics"), 
// //     new Product("Monitor", 399.99m, "Electronics"), 
// //     new Product("Desk", 249.99m, "Furniture"), 
// //     new Product("Chair", 189.99m, "Furniture"), 
// //     new Product("Notebook", 4.99m, "Stationery"), 
// //     new Product("Pen", 1.99m, "Stationery"),

// // }; 

// // // Where - filter-- 
// // // Returns all elements that match the condition 
// // List<Product> expensive = products 
// //     .Where(p=> p.Price > 100m)
// //     .ToList();

// //     Console.WriteLine("=== Exprensive products (> $100) ==="); 
// //     foreach (Product p in expensive) 
// //         Console.WriteLine($"{p.Name} - {p.Price:C}"); 

// //         // --- Select — transform / project ---
// // // Returns a new shape from each element 
// // List <string> names = products 
// //     .Select(p => p.Name)
// //     .ToList(); 

// //     Console.WriteLine("\n=== Product names only ===");
// //  foreach (string name in names)
// //  Console.WriteLine($"{name}"); 

// //  // Select into a new anonymous object 
// //  var summaries = products 
// //  .Select(p => new {p.Name, Label = $"{p.Name} ({p.Category})"})
// //  .ToList(); 

// // Console.WriteLine("\n=== Summaries ===");
// // foreach (var s in summaries)
// // Console.WriteLine($"{s.Label}"); 

// // // --- OrderBy / OrderByDescending ---
// // List<Product> byPrice = products 
// //     .OrderBy(p => p.Price)
// //     .ToList(); 

// // Console.WriteLine("\n=== Ordered by price (asc) ==="); 
// // foreach (Product p in byPrice)
// //     Console.WriteLine($"{p.Name} - {p.Price:C}"); 

// // // --- FirstOrDefault ---
// // // Returns the first match, or null if nothing found — never throws

// // Product? cheapest = products 
// // .OrderBy(p=> p.Price)
// // .FirstOrDefault(); 

// // Console.WriteLine($"\nCheapest: {cheapest?.Name} - {cheapest?.Price:C}"); 

// // Product? missing = products.FirstOrDefault(p => p.Name == "Lamp");
// // Console.WriteLine($"Missing product: {missing?.Name ?? "nor found"}"); 

// // // --- Chaining - combine multiple operators --- 
// // List<Product> result = products
// //     .Where(p => p.Category == "Electronics")
// //     .OrderByDescending(p=> p.Price)
// //     .ToList(); 

// //     Console.WriteLine("\n=== Electronics, most expensive first ==="); 
// //     foreach (Product p in result)
// //         Console.WriteLine($"{p.Name} - {p.Price:C}"); 

// // // --- Aggregates --- 
// // decimal total = products.Sum(p=> p.Price); 
// // decimal average = products.Average(p => p.Price);
// // int count = products.Count(p=> p.Category == "Stationery"); 

// // Console.WriteLine($"\nTotal: {total:C}"); 
// // Console.WriteLine($"Average: {average:C}"); 
// // Console.WriteLine($"Stationery count: {count}");

// // class Product
// // {
// //     public string Name {get; }
// //     public decimal Price {get; }

// //     public string Category {get; }

// //     public Product(string name, decimal price, string category)
// //     {
// //         Name = name; 
// //         Price = price; 
// //         Category = category; 
// //     }
// // }

// // DAY 7 - async/await, Task

// // async = this method contains asynchronous operations
// // await = wait for this operation without blocking the thread
// // Task  = represents an ongoing operation (like a promise)

// Console.WriteLine("=== Basic async/await ==="); 
// await RunBasicExample(); 

// Console.WriteLine("\n=== Returning a value from async ==="); 
// string result = await FetchUserName(1); 
// Console.WriteLine($"Fetched: {result}"); 

// Console.WriteLine("\n=== Multiple async calls — sequential ===");
// await RunSequential(); 

// Console.WriteLine("\n=== Multiple async calls - parallel ==="); 
// await RunParallel();

// // --- Basic example ---
// // async void is avoided in real code — use async Task instead 
// static async Task RunBasicExample()
// {
//     Console.WriteLine("Starting..."); 
//     await Task.Delay(500); 
//     Console.WriteLine("Done after 500ms delay"); 
// }

// // Task <T> async method that returns a value --- 
// static async Task<string> FetchUserName(int userId)
// {
//     await Task.Delay(300); 
//     return $"User:{userId}";
// }

// // --- Sequential — one after the other ---
// // Total time: ~1500ms

// static async Task RunSequential()
// {
//     string a = await SimulateApiCall("Oders", 500); 
//     string b = await SimulateApiCall("Products", 500); 
//     string c = await SimulateApiCall("Users", 500);

//     Console.WriteLine($" {a}"); 
//     Console.WriteLine($" {b}"); 
//     Console.WriteLine($" {c}"); 
// }
 
//  // --- Parallel — all at the same time ---
// // Total time: ~500ms (longest single call), not 1500ms
// static async Task RunParallel()
// {
//     Task<string> taskA = SimulateApiCall("Orders", 500); 
//     Task<string> taskB = SimulateApiCall("Products", 500); 
//     Task<string> taskC = SimulateApiCall("Users", 500); 

//     string[] results = await Task.WhenAll(taskA, taskB, taskC); 

//     foreach (string r in results) 
//         Console.WriteLine($"{r}");
// }

// // Helper — simulates an async operation (API call, DB query, etc.)
// static async Task<string> SimulateApiCall(string endpoint, int delayMs)
// {
//     await Task.Delay(delayMs); 
//     return $"{endpoint} response received."; 
// }

// DAY 2 - OOP: Class, Constructor, Property
// DAY 3 - OOP: Inheritance
// DAY 4 - OOP: Encapsulation
// DAY 5 - Collections
// DAY 6 - LINQ
// DAY 7 - async/await
// (previous days commented out — see git history)

// DAY 8 - Exception Handling: try / catch / finally

// try     = run this code, watch for errors
// catch   = if an error occurs, handle it here
// finally = always runs, error or not (cleanup goes here)

Console.WriteLine("=== Basic try/catch ===");
BasicExample();

Console.WriteLine("\n=== Multiple catch blocks ===");
MultipleCatch(null);
MultipleCatch("abc");
MultipleCatch("10");

Console.WriteLine("\n=== Finally ===");
FinallyExample();

Console.WriteLine("\n=== Custom exception ===");
ProcessAge(25);
ProcessAge(-5);

Console.WriteLine("\n=== Async try/catch ===");
await ReadFileAsync("config.json");

// --- Methods ---

static void BasicExample()
{
    try
    {
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine(numbers[10]); // Index out of range
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"Caught: {ex.Message}");
    }
}

static void MultipleCatch(string? input)
{
    try
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input), "Input cannot be null.");

        int value = int.Parse(input);
        Console.WriteLine($"Parsed value: {value}");
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine($"Null error: {ex.Message}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Format error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}");
    }
}

static void FinallyExample()
{
    try
    {
        Console.WriteLine("Opening resource...");
        throw new Exception("Something went wrong.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Caught: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Resource closed. (finally block)");
    }
}

static void ProcessAge(int age)
{
    try
    {
        if (age < 0 || age > 150)
            throw new InvalidAgeException(age);

        Console.WriteLine($"Age accepted: {age}");
    }
    catch (InvalidAgeException ex)
    {
        Console.WriteLine($"Invalid age caught: {ex.Message}");
    }
}

static async Task ReadFileAsync(string fileName)
{
    try
    {
        Console.WriteLine($"Reading {fileName}...");
        await Task.Delay(200);
        throw new FileNotFoundException($"File not found: {fileName}");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine($"File error: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("File operation finished. (finally)");
    }
}

// --- Classes — always at the bottom ---

class InvalidAgeException : Exception
{
    public int Age { get; }

    public InvalidAgeException(int age)
        : base($"Age {age} is not valid. Must be between 0 and 150.")
    {
        Age = age;
    }
}
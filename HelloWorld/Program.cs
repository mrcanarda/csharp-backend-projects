// // DAY 1 - Variables and Data Types

// // Integer - whole numbers
// int age = 25;
// int year = 2026;

// // Double - decimal numbers
// double price = 99.99;
// double pi = 3.14159;

// // String - text
// string name = "Can";
// string city = "Istanbul";

// // Boolean - true/false
// bool isEmployed = true;
// bool isStudent = false;

// // Print all variables
// Console.WriteLine("Name: " + name);
// Console.WriteLine("Age: " + age);
// Console.WriteLine("City: " + city);
// Console.WriteLine("Price: " + price);
// Console.WriteLine("Is Employed: " + isEmployed);
// Console.WriteLine("Year: " + year);

// DAY 1 - String Operations
// string firstName = "Can";
// string lastName = "Arda";

// // String concatenation
// string fullName = firstName + " " + lastName;
// Console.WriteLine("Full name: " + fullName);

// // String interpolation - cleaner way
// Console.WriteLine($"Hello, {firstName} {lastName}!");
// Console.WriteLine($"Name length: {fullName.Length}");
// Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
// Console.WriteLine($"Lowercase: {fullName.ToLower()}");

// // Check if string contains something
// bool hasAra = fullName.Contains("Arda");
// Console.WriteLine($"Contains 'Arda': {hasAra}");

// DAY 1 - Nullable Types 

// Normal int - connot be null 

// int age = 25; 

// // Nullable int - can be null 

// int? nullableAge = null; 
// int? anotherAge = 30; 

// // Check if null before using 
// if (nullableAge == null)
// {
//     Console.WriteLine("Age is not provided"); 
// }

// // Null coalescing operator - just like JavaScript ?? 

// int finalAge = nullableAge ?? 0; 
// Console.WriteLine($"Final age: {finalAge}");

// // Nullable string 
// string? username= null; 
// Console.WriteLine($"Username: {username ?? "Anonymous"}");

// // If value exist, use it 

// if (anotherAge.HasValue)
// {
//     Console.WriteLine($"Another age: {anotherAge.Value}");
// }

// // DAY 1 - Conditions

// int score = 75;

// // if / else if / else
// if (score >= 90)
// {
//     Console.WriteLine("Grade: A");
// }
// else if (score >= 80)
// {
//     Console.WriteLine("Grade: B");
// }
// else if (score >= 70)
// {
//     Console.WriteLine("Grade: C");
// }
// else
// {
//     Console.WriteLine("Grade: F");
// }

// // Switch expression - modern C# syntax
// string result = score switch
// {
//     >= 90 => "Excellent",
//     >= 80 => "Good",
//     >= 70 => "Average",
//     _ => "Failed"
// };

// Console.WriteLine($"Result: {result}");

// // Ternary operator - same as JavaScript
// string status = score >= 70 ? "Passed" : "Failed";
// Console.WriteLine($"Status: {status}");

// DAY 1 - Loops 

// // for loop 
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"For loop: {i}");
// }

// // while loop 
// int count = 0; 
// while (count < 3)
// {
//      Console.WriteLine($"While loop: {count}");
//     count++;
// }

// // foreach logo - most common in C#

// string [] cities = {"Istanbul", "Berlin", "London" }; 
// foreach(string city in cities)
// {
//     Console.WriteLine($"City: {city}"); 
// }

// // foreach with index using LINQ 
// foreach (var (city, index) in cities.Select((c, i) => (c, i)))
// {
//     Console.WriteLine($"{index}: {city}");
// }

// DAY 1 - Methods (Functions)

// Basic method with return type
int Add(int a, int b)
{
    return a + b;
}

// Void method - returns nothing
void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// Method with default parameter
void PrintInfo(string name, int age = 0)
{
    Console.WriteLine($"Name: {name}, Age: {age}");
}

// Method with multiple return values (tuple)
(string, int) GetUser()
{
    return ("Can", 25);
}

// Expression body method - short syntax
int Multiply(int a, int b) => a * b;

// Call all methods
int result = Add(10, 5);
Console.WriteLine($"Add: {result}");

Greet("Can");

PrintInfo("Arda");
PrintInfo("Can", 25);

var (name, age) = GetUser();
Console.WriteLine($"User: {name}, {age}");

Console.WriteLine($"Multiply: {Multiply(4, 5)}");
// DAY 2 - OOP: Class, Constructor, Property

User user1 = new User("Can", "can@example.com", 25);
User user2 = new User("Eylul", "eylul@example.com", 24);

user1.PrintInfo();
user2.PrintInfo();

Console.WriteLine(user1.GetSummary());

user1.IsActive = false;
Console.WriteLine($"User1 active: {user1.IsActive}");

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }

    public User(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
        IsActive = true;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}, Age: {Age}, Active: {IsActive}");
    }

    public string GetSummary()
    {
        return $"{Name} ({Email})";
    }
}
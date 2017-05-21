using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Local Time Zone Info\n====================");
        Console.WriteLine($"Id:\t\t{TimeZoneInfo.Local.Id}");
        Console.WriteLine($"Display Name:\t{TimeZoneInfo.Local.DisplayName}");
        Console.WriteLine($"StandardName:\t{TimeZoneInfo.Local.StandardName}");
        Console.WriteLine($"DaylightName:\t{TimeZoneInfo.Local.DaylightName}");
        Console.WriteLine($"BaseUtcOffset:\t{TimeZoneInfo.Local.BaseUtcOffset}");
        Console.WriteLine();

        Console.WriteLine("Now\n===");
        Display(DateTime.Now);

        Console.WriteLine("UtcNow\n======");
        Display(DateTime.UtcNow);
    }

    static void Display(DateTime dt)
    {
        Console.WriteLine(dt.ToString());
        Console.WriteLine($"Kind:\t{dt.Kind}");
        Console.WriteLine($"UTC:\t{dt.ToUniversalTime().ToString()}");
        Console.WriteLine($"Local:\t{dt.ToLocalTime().ToString()}");
        Console.WriteLine();
    }
}

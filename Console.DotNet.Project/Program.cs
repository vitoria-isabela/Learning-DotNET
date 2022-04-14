using Humanizer;
using System.Diagnostics;
using System.IO;

//Console.WriteLine("Quantities:");
//HumanizeQuantities();

//Console.WriteLine("\nDate/Time Manipulation:");
//HumanizeDates();

//static void HumanizeQuantities()
//{
//    Console.WriteLine("case".ToQuantity(0));
//    Console.WriteLine("case".ToQuantity(1));
//    Console.WriteLine("case".ToQuantity(5));
//}

//static void HumanizeDates()
//{
//    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
//    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
//    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
//    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
//}

IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("C:\\Users\\6113826\\source\\repos\\Learning-DotNET\\Console.DotNet.Project");
IEnumerable<string> listOfFiles = Directory.EnumerateFiles("C:\\Users\\6113826\\source\\repos\\Learning-DotNET\\Console.DotNet.Project");

Console.WriteLine("Directories: ");
foreach (var dir in listOfDirectories)
{
    Console.WriteLine(dir);
}

Console.WriteLine(" ");

Console.WriteLine("Files: ");
foreach (var file in listOfFiles)
{
    Console.WriteLine(file);
}
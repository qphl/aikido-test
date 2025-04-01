// See https://aka.ms/new-console-template for more information

var filePath = Console.ReadLine();
if (filePath != null)
{
    var file = File.ReadAllText(filePath);
    Console.WriteLine(file);
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string? mystring = "    ";

if (!string.IsNullOrWhiteSpace(mystring))
{
    Console.WriteLine(mystring);
}
else
{
    Console.WriteLine("valid string into null");
}
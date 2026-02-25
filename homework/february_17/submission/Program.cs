

Console.WriteLine("Hello, What is your name?");

var name = Console.ReadLine();
Console.Write("Hello There ");
Console.WriteLine(name);

Console.WriteLine("What is your age?");
var age = Console.ReadLine();

Console.WriteLine("is it your birthday?");

var isbirthday  = Console.ReadLine();
if (isbirthday == "yes")
{
    Console.WriteLine("Happy Birthday!");
}
else if  (isbirthday == "no")
{
    Console.WriteLine("Oh. Sorry it's not your birthday.");
}
else
{
    Console.WriteLine("What do you mean? How did you forget your birthday?");
}
{}
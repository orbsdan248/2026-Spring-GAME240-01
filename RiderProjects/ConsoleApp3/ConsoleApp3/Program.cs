// See https://aka.ms/new-console-template for more information

string message = "We share a name!";

Console.WriteLine("What is your first name?");
String firstname = Console.ReadLine();
Console.WriteLine("What is your last name?");
String lastname = Console.ReadLine();

if (firstname == "Thomas" || lastname == "Giovanola")
{
Console.WriteLine(message);
}

if (firstname == "Thomas" && lastname == "Giovanola")
{
    Console.WriteLine("We share the same full name!");
}

// != means not true
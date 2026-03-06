// See https://aka.ms/new-console-template for more information

string whileloop;
int result;
string consent;
Console.WriteLine("Which one do you want? (1-10)");
whileloop = Console.ReadLine(); 
if(whileloop == "1")
{
    result = 0;
    while (result < 5)
    {
        result = result + 1;
        Console.WriteLine(result);
    }
}

if (whileloop == "2")
{
    result = 99;
    while (result < 150)
    {
        result = result + 1;
        Console.WriteLine(result);
    }
}

if (whileloop == "3")
{
    result = -2;
    while (result < 100)
    {
        result = result + 2;
        Console.WriteLine(result);
    }
}

if (whileloop == "4")
{ result = 22;
    while (result > -20)
    {
        result = result - 2;
        Console.WriteLine(result);
    }
}

if  (whileloop == "5")
{
    result = -2;
    while (result < 100)
    {
        result = result + 3;
        Console.WriteLine(result);
    }
}

if (whileloop == "6")
{
    result = 1;
        while(result < 1024)
        { result = result * 2;
            Console.WriteLine(result);}
}

if (whileloop == "7")
{
    consent = "no";
    while (consent != "yes")
    {
        Console.WriteLine("Do you want the loop to stop?");
        consent = Console.ReadLine();
    }
}

if (whileloop == "8")
{
    while (true)
    {
        Console.WriteLine("True");
        Console.WriteLine("False");
    }
}

int IsEven;
int IsOdd;
if (whileloop == "9")
{
    result = 0;
    IsOdd = -1;
    IsEven = 0;    
    while (result < 20)
    {
        result = result + 2;
        IsEven = IsEven + 2;
        IsOdd = IsOdd + 2;    
        Console.WriteLine(IsOdd + " odd");
        Console.WriteLine(IsEven + " even");
    }
}

string string2 = "Once upon a midnight dreary";
if (whileloop == "10")
{
    int index = 0;
    while (index < string2.Length)
    {
        Console.Write(string2[index]);
        Thread.Sleep(millisecondsTimeout:100);
        index = index + 1;
    }
}
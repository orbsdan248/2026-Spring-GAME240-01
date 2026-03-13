// See https://aka.ms/new-console-template for more information

int[] numbers = [0, 16, 80, -10, -72];

int result;



if(numbers[0] > numbers[1])
{
    result = numbers[0];
}
else
{
    result = numbers[1];
}

int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine("Biggest is " + result);
    if (numbers[index] > result)
    {
        result = numbers[index];
    }

    index++;
}

result = 0;

if(numbers[0] < numbers[1])
{
    result = numbers[0];
}
else
{
    result = numbers[1];
}

index = 0;
while (index < numbers.Length + 1)
{
    Console.WriteLine("Smallest is " + result);
    if (numbers[index] < result)
    {
        result = numbers[index];
    }
    index++;
}


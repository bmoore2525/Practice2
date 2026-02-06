


int total = 0;
int[] numbers = { 1, 2, 3, 4, 5 };

foreach(int num in numbers)
{
    Console.WriteLine(num);
    total += num;
}

Console.WriteLine(total);

Console.WriteLine();

total = 0;
for(int i = numbers.Length; i >= 1; i--)
{
    
    Console.WriteLine(i);
    total += i;
    
}
Console.WriteLine(total);
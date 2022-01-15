
List<int> num = new List<int>()
{
41,1,   22,  82,  27,
84 , 40,  2,   36,  3,
21  ,64,  26,  5,   95,
94,  8,   52,  61,  30,
93,  18,  99,  27,  41,
1,   41,  15,  38,  80,
81,  24,  72,  36,  100,
99,  32,  32,  11,  38,
55 , 34,  24,  12,  99,
62,  42,  1,   71,  18,
56,  39,  84,  31,  14,
48,  70,  3,   9,   97,
44,  51,  82,  6,   16,
94 , 73,  40 , 12 , 63,
65 , 13,  70,  66,  56,
61 , 77,  37 , 45 , 35,
51,  1 ,41 , 82,  12,
19 , 79 , 94 , 50  ,9,
25 , 32 , 26 , 57 , 2,
2  , 24,  76,  58,  65
};
foreach(var i in num)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Even!");
    }
    if (i % 2 != 0)
    {
        Console.WriteLine("Odd!");
    }
}
var count1 = 0;
var total = 0;
foreach(var i in num)
{
    total += i;
    count1++;
}
Console.WriteLine($"Total number of ints in the list are {count1}");
Console.WriteLine(total / count1);
var max = 0;
var min = 1000;
foreach(var i in num)
{
    if(i > max)
    {
        max = i;
    }
    if (i < min)
    {
        min = i;
    }
}
Console.WriteLine($"Max is {max}");
Console.WriteLine($"Min is {min}");
Random random = new Random();
var one = random.Next(101);
var two = random.Next(101);
if((num[one]*num[two]) % 2 == 0)
{
    Console.WriteLine("The product is even");
    Console.WriteLine(num[one]*num[two]);
}
if ((num[one] * num[two]) % 2 != 0)
{
    Console.WriteLine("The product is odd");
    Console.WriteLine(num[one] * num[two]);
}
//Make a pyramid using the number providing and that will also be the width
Console.WriteLine("Pick a number");
var pyramid = Console.ReadLine();
var pyramid1 = Int32.Parse(pyramid);
for(var i = pyramid1; i >= 0; i--)
{
    for(var p = 0; p < i; p++)
    {
        Console.Write(pyramid1);
    }
    Console.WriteLine();
}
int[] values = Console.ReadLine() //5 2 13
     .Split()
    .Select(int.Parse)
    .ToArray();

int[] input = Console.ReadLine() //1 13 45 32 4
    .Split()
    .Select(int.Parse)
    .ToArray();

int valuesToPush = values[0];//5
int valuesToPop = values[1];//2
int lookUpValue = values[2];//13

Stack<int> stack =
    new Stack<int>(input.Take(valuesToPush));

while (stack.Count > 0 && valuesToPop > 0)
{
    stack.Pop();
    valuesToPop--;
}

if (stack.Contains(lookUpValue))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(stack.Min());
}
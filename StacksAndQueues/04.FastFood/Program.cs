int foodQuantity = int.Parse(Console.ReadLine()); // 348

int[] orders = Console.ReadLine() //20 54 30 16 7 9
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> foodOrders
    = new Queue<int>(orders);

Console.WriteLine(foodOrders.Max());

while (foodOrders.Count > 0 && foodQuantity > 0)
{
    int currentOrder = foodOrders.Peek(); //348 - 20 > 0 = true

    if (foodQuantity - currentOrder >= 0)
    {
        foodQuantity -= foodOrders.Dequeue();
    }
    else
    {
        break;
    }
}

if (foodOrders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ", foodOrders)}");
}
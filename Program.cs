int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
int myInt;
Console.WriteLine($"Min = {nums.Min()}");
Console.WriteLine($"Max = {nums.Max()}");
Console.WriteLine($"Max less than 10000 = {nums.Where(x => x < 10000).Max()}");
Console.WriteLine($"Between 10 and 100 = {String.Join(",", nums.Where(x => x > 10 && x < 100).ToList())}"); // To me, between means just that: between, not 10 and not 100.
Console.WriteLine($"From 100000 to 999999 inclusive = {String.Join(",", nums.Where(x => x >= 100000 && x <= 999999).ToList())}");
Console.WriteLine($"All even numbers counted = {nums.Where(x => x % 2 == 0).Count()}");


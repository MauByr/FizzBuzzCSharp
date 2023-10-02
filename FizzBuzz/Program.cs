// See https://aka.ms/new-console-template for more information

using FizzBuzz;

Console.WriteLine("Hello, World!");


var fb = new FizzBuzzer(new List<FizzBuzzRule>(new[]
{
    new FizzBuzzRule(3, x => x.Add("Fizz")),
    new FizzBuzzRule(5, x => x.Add("Buzz")),
    new FizzBuzzRule(7, x => x.Add("Bang")),
    new FizzBuzzRule(11, x =>
    {
        x.Clear();
        x.Add("Bong");
    }),
    new FizzBuzzRule(13,
        x => x.Insert(x.Any(w => w.StartsWith("B")) ? x.FindIndex(w => w.StartsWith("B")) : x.Count, "Fezz")),
    new FizzBuzzRule(17, x => x.Reverse()),
}));


for (var i = 1; i <= 13 * 3 * 7 * 5; i++)
{
    Console.WriteLine(fb.Process(i));
}
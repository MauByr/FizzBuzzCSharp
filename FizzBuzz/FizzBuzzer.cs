namespace FizzBuzz;

using System.Collections.Generic;

public class FizzBuzzer
{
    private readonly List<FizzBuzzRule> _rules;

    public FizzBuzzer(List<FizzBuzzRule> rules)
    {
        _rules = rules;
    }

    public string Process(int n)
    {
        var output = new List<string>();
        _rules
            .Where(rule => n % rule.Num == 0)
            .ToList()
            .ForEach(x=>x.Process(output));
        
        return string.Concat(output.DefaultIfEmpty(n.ToString()));
    }
}
namespace FizzBuzz;
//public Action<IEnumerable<string>> void FizzBuzzRuleProcess(List<string> current);
public class FizzBuzzRule
{
    public int Num { get; }
    public Action<List<string>> Process { get; }


    public FizzBuzzRule(int num, Action<List<string>> process)
    {
        Num = num;
        Process = process;
    }
}
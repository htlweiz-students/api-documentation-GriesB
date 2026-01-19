using AverageCalculator;

namespace Program00;

public class Program {
    public static int Main(string[] argv) {
        Average calculator = new([]);
        calculator.Add([0.1, 9.9, 2.0]);
        calculator.Add(2.5);
        Console.WriteLine(calculator.GetAverage());
        Console.WriteLine(calculator.Count());
        foreach (var val in calculator.GetElements()) {
            Console.WriteLine(val);
        }
        Console.WriteLine(calculator.ToString());
        return 0;
    }
}
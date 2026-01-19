
namespace AverageCalculator;

public class Average
{
    private List<double> saved;
    private double avrVal;
    private int amount;
    public Average(List<double> setSaved)
    {
        saved = setSaved;
    }
    public void Add(double value)
    {
        saved.Add(value);
    }
    public void Add(double[] value)
    {
        saved.AddRange<double>(value);
    }

    public double GetAverage()
    {
        double toDivide = 0;
        if (saved.Count == 0)
        {
            return 0;
        }
        else
        {
            foreach (var val in saved)
            {
                toDivide += val;
            }
            avrVal = toDivide / saved.Count;
            return toDivide / saved.Count;
        }
    }

    public double[] GetElements()
    {
        return saved.ToArray();
    }
    public int Count()
    {
        amount = saved.Count;
        return saved.Count;
    }
    public override string ToString()
    {
        return($"Average: {avrVal}, amount of values: {amount}");
    }
}


namespace AverageCalculator;

public class Average
{
    private List<double> saved;
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
            return toDivide / saved.Count;
        }
    }

    public double[] GetElements()
    {
        return saved.ToArray();
    }
    public int Count()
    {
        return saved.Count;
    }
}

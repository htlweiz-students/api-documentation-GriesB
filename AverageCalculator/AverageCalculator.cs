namespace AverageCalculator;

public class AverageCalculator
{
    private int count;
    private double[] saved = [];
    private double total;
    public AverageCalculator (double[] values) {
        foreach (var val in values) {
            count++;
            saved[count-1] = val;
            total += val;
        }
    }

    public void Add(double value) {
        count++;
        saved[count-1] = value;
        total += value;
    }
    public void Add(double[] value) {
        foreach (var val in value)
        {
        count++;
        saved[count-1] = val;
        total += val;
        }
    }
}

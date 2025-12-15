namespace AverageCalculator;

public class AverageCalculator
{
    private double Average;
    private double[] Elements;
    private int count;
    public AverageCalculator(double[] values) {
        foreach val in values {
            count++;
            Average = Average + val;
        }
    }
}

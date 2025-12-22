
namespace AverageCalculator;

public class Average
{
    private List<double> saved;
    public Average() {
        saved = new List<double>();        
    }
    public void Add(double value) {
        saved.Add(value);
    }
    public void Add(double[] value) {
        saved.AddRange<double>(value);
    }

    public double GetAverage() {
        double toDivide = 0;
        if (saved.Count == 0){
            return 0;
        } else {
        foreach (var val in saved) {
            toDivide += val;
        }
        return toDivide/saved.Count;
        }
    }

    public double[]
     GetElements() {
        if (saved.Count == 0) {
            return [0.0];
        } else {
        return saved;
        }
    }
    public int Count() {
        return saved.Count;
    }
}

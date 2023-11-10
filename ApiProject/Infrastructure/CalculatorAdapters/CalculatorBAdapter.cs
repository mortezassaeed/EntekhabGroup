namespace Infrastructure.CalculatorAdapters;

public class CalculatorBAdapter : ICalculatorAdapter
{
    public decimal Calculate(decimal rightOfAttraction, decimal basicSalary)
    {
        OvertimePolicies.OvertimeCalculator overtimeCalculator = new();
        return overtimeCalculator.CalculatorB(rightOfAttraction + basicSalary);
    }
}

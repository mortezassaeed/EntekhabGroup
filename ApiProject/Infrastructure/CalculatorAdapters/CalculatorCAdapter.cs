namespace Infrastructure.CalculatorAdapters;

public class CalculatorCAdapter : ICalculatorAdapter
{
    public decimal Calculate(decimal rightOfAttraction, decimal basicSalary)
    {
        OvertimePolicies.OvertimeCalculator overtimeCalculator = new();
        return overtimeCalculator.CalculatorC(rightOfAttraction + basicSalary);
    }
}

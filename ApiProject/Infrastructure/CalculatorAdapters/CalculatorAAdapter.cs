namespace Infrastructure.CalculatorAdapters;

public class CalculatorAAdapter : ICalculatorAdapter
{
    public decimal Calculate(decimal rightOfAttraction, decimal basicSalary)
    {
        OvertimePolicies.OvertimeCalculator overtimeCalculator = new();
        return overtimeCalculator.CalculatorA(rightOfAttraction + basicSalary);
    }
}
using Domain;

namespace Infrastructure.SalaryRequestParser;

public interface ISalaryRequestParser
{
    PersonSalary Parse(string Data);
}
using Domain;

namespace Infrastructure.SalaryRequestParser;

public class CustomSalaryRequestParser : ISalaryRequestParser
{
    public PersonSalary Parse(string Data)
    {
        // TODO parse request;
        return new PersonSalary();
    }
}


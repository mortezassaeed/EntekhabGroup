using Domain;

namespace Infrastructure.SalaryRequestParser;

public class CSVSalaryRequestParser : ISalaryRequestParser
{
    public PersonSalary Parse(string Data)
    {
        // TODO parse request;
        return new PersonSalary();
    }
}


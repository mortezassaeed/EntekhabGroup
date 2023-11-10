namespace Infrastructure.SalaryRequestParser;

public interface ISalaryRequestParserFactory
{
    ISalaryRequestParser GetParse(string parserName);
}

namespace Infrastructure.SalaryRequestParser;

internal class SalaryRequestParserFactory : ISalaryRequestParserFactory
{
    private Dictionary<string, ISalaryRequestParser> _parsers = new Dictionary<string, ISalaryRequestParser>
    {

        ["Json"] = new JsonSalaryRequestParser(),
        ["XML"] = new XMLSalaryRequestParser(),
        ["CSV"] = new CSVSalaryRequestParser(),
        ["Custom"] = new CustomSalaryRequestParser()
    };

    public ISalaryRequestParser GetParse(string parserName)
    {
        if (_parsers.ContainsKey(parserName))
        {
            return _parsers[parserName];
        }

        throw new ArgumentException("parser not exist");
    }
}

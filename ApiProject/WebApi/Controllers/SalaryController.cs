using ApplicationServices;
using Infrastructure.CalculatorAdapters;
using Infrastructure.SalaryRequestParser;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("{datatype}/[controller]")]
public class SalaryController : ControllerBase
{

    private readonly IOverTimeCalculatorHandler _overTimeCalculatorHandler;
    private readonly ISalaryRequestParserFactory _salaryRequestParserFactory;

    public SalaryController(IOverTimeCalculatorHandler overTimeCalculatorHandler, ISalaryRequestParserFactory salaryRequestParserFactory)
    {
        _overTimeCalculatorHandler = overTimeCalculatorHandler;
        _salaryRequestParserFactory = salaryRequestParserFactory;
    }

    public record CalcRequest(string data, string OverTimeCalculator);

    [HttpPost]
    public IActionResult Calc([FromRoute] string datatype, [FromBody] CalcRequest request)
    {

        decimal overTimeResult = 0;
        var salaryRequestData = _salaryRequestParserFactory.GetParse(datatype).Parse(request.data);
        _overTimeCalculatorHandler.HandleRequest(request.OverTimeCalculator, salaryRequestData.Allowance, salaryRequestData.BasicSalary, ref overTimeResult);
        //TODO : Bring all these methods into the facade layer.
        //TODO : Calculate based on a formula inside an application service.
        return Ok();
    }

    // TODO CRUD Actions
}
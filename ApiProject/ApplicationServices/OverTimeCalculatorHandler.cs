using ApplicationServices.Handlers;

namespace ApplicationServices;

internal class OverTimeCalculatorHandler : IOverTimeCalculatorHandler
{
    private readonly IEnumerable<IOverTimeHandler> _handlers;

    public OverTimeCalculatorHandler(IEnumerable<IOverTimeHandler> handlers)
    {
        handlers.Aggregate((all, next) => all.SetNext(next));
        _handlers = handlers;
    }

    public void HandleRequest(string calcName, decimal rightOfAttraction, decimal basicSalary, ref decimal result)
    {
        _handlers.First().HandleRequest(calcName, rightOfAttraction, basicSalary, ref result);
    }
}

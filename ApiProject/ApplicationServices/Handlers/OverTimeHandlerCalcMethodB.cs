using Infrastructure.CalculatorAdapters;

namespace ApplicationServices.Handlers;

internal class OverTimeHandlerCalcMethodB : IOverTimeHandler
{
    private IOverTimeHandler _nextHandler;

    public IOverTimeHandler SetNext(IOverTimeHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public void HandleRequest(string calcName, decimal rightOfAttraction, decimal basicSalary, ref decimal result)
    {
        if (calcName == "CalculatorB")
        {
            result = new CalculatorAAdapter().Calculate(rightOfAttraction, basicSalary);
            return;
        }

        if (_nextHandler is not null)
        {
            _nextHandler.HandleRequest(calcName, rightOfAttraction, basicSalary, ref result); // TODO : create base handler to implement this part for all Childs 
        }
    }
}


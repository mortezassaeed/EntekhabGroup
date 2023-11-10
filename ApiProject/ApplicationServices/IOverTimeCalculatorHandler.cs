namespace ApplicationServices
{
    public interface IOverTimeCalculatorHandler
    {
        void HandleRequest(string calcName, decimal rightOfAttraction, decimal basicSalary, ref decimal result);
    }
}
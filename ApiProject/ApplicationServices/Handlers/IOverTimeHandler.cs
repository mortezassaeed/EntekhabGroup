using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Handlers;

public interface IOverTimeHandler
{
    IOverTimeHandler SetNext(IOverTimeHandler handler);
    void HandleRequest(string calcName, decimal rightOfAttraction, decimal basicSalary, ref decimal result);
}


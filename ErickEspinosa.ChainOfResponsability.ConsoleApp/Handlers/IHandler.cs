using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.ChainOfResponsability.ConsoleApp.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}

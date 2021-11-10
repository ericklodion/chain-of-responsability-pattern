using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.ChainOfResponsability.ConsoleApp.Handlers
{
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
                return this._nextHandler.Handle(request);
            else
                return null;
        }
    }
}

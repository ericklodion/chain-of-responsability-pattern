using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.ChainOfResponsability.ConsoleApp.Handlers
{
    class StockHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            //Chamar rotina para atualização de estoque por exemplo

            return base.Handle(request);
        }
    }
}

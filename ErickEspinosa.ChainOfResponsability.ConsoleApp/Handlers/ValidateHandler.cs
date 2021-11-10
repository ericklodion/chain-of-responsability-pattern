using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.ChainOfResponsability.ConsoleApp.Handlers
{
    class ValidateHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            //Chamar rotina para validar o pedido por exemplo

            return base.Handle(request);
        }
    }
}

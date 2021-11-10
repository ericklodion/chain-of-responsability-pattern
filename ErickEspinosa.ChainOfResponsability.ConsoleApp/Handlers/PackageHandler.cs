using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.ChainOfResponsability.ConsoleApp.Handlers
{
    class PackageHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            //Chamar rotina para preparação de envio por exemplo

            return base.Handle(request);
        }
    }
}

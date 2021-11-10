using ErickEspinosa.ChainOfResponsability.ConsoleApp.Handlers;
using System;

namespace ErickEspinosa.ChainOfResponsability.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var validate = new ValidateHandler();
            var stock = new StockHandler();
            var package = new PackageHandler();

            //Aqui definimos a ordem dos handlers e poderiamos até montar um tratamento para caso ocorra erro em um deles abortar o processo.
            validate.SetNext(stock).SetNext(package);

            //Aqui disparamos o primeiro handler da sequencia
            validate.Handle(null);
        }
    }
}

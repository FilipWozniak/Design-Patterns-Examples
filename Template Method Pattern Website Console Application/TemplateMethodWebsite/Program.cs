using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            Website businessman = new JobOfferWebsite();
            businessman.CreateWebsite("No Fluff Jobs");

            Console.WriteLine();

            Website blogger = new BlogWebsite();
            blogger.CreateWebsite("C# Developer Personal Blog");

            Console.WriteLine();

            Website developer = new PortfolioWebsite();
            developer.CreateWebsite(".NET Developer Portfolio");

            Console.Read();
            return;
        }
    }
}
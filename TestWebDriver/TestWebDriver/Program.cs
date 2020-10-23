using Microsoft.Edge.SeleniumTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new EdgeOptions();
            options.UseChromium = true;
            var driver = new EdgeDriver(options);
            driver.Navigate().GoToUrl(@"https://www.microsoft.com/");
            driver.Manage().Window.Maximize();
            Console.ReadKey();
        }
    }
}

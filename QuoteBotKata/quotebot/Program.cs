using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteBotKata
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomaticQuoteBot bot = new AutomaticQuoteBot();
            bot.sendAllQuotes("FAST");
        }
    }
}

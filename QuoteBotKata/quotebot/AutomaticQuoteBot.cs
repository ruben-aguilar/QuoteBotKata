using QuoteBotKata.quotebot;
using System.Collections.Generic;

namespace QuoteBotKata
{
    public class AutomaticQuoteBot
    {
        public void sendAllQuotes(string mode)
        {
            List<string> blogs = AdSpace.AdSpaces;
            foreach(string blog in blogs)
            {
                BlogAuctionTask auctionTask = new BlogAuctionTask();
                auctionTask.PriceAndPublish(blog, mode);
            }
        }
    }
}